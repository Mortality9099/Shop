using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using SqlShop.DayaLayer.Models.Entity;
using SqlShop.ModelView.DTO;
using Telerik.WinControls.UI;

namespace SqlShop.View.Forms
{
    public partial class FrmProduct : RadForm
    {
        public ProductViewModel ProductViewModel { get; set; }
        public SupplierViewModel SupplierViewModel { get; set; }
        public CategoryViewModel CategoryViewModel { get; set; }

        public FrmProduct()
        {
            InitializeComponent();

            ProductViewModel = new ProductViewModel();
            SupplierViewModel = new SupplierViewModel();
            CategoryViewModel = new CategoryViewModel();
        }

        // Override Method 'OnLoad'
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            //this.RcboxCategories.AutoSizeDropDownToBestFit = true;
            this.RcboxSuppliers.AutoSizeDropDownToBestFit = true;


            RefreshForm();

            DeselectGridViewCurrentRow();
            DeselectSupplierComboBoxCurrentRow();
            DeselectCategoryComboBoxCurrentRow();
        }

        #region -----  Methods  -----

        private void DeselectSupplierComboBoxCurrentRow()
        {
            RcboxSuppliers.SelectedItem = null;
        }

        private void DeselectCategoryComboBoxCurrentRow()
        {
            RcboxCategories.SelectedItem = null;
        }

        private void DeselectGridViewCurrentRow()
        {
            try
            {
                RgvProducts.CurrentRow = null;
            }
            catch (Exception)
            {
            }
            finally
            {
                btnModify.Enabled = false;
            }
        }

        private void RefreshForm()
        {
            RgvProducts.DataSource = ProductViewModel.GetAllNonDeletedEntities();

            RcboxSuppliers.DataSource = SupplierViewModel.GetAllEntities();
            RcboxCategories.DataSource = CategoryViewModel.GetAllEntities();
        }

        private void ValidateAllTextBoxes()
        {
            txtProductName_Validated(new object(), new EventArgs());
            txtUnitPrice_Validated(new object(), new EventArgs());
            txtQty_Validated(new object(), new EventArgs());
            txtDiscount_Validated(new object(), new EventArgs());
        }

        private void ValidateComboBoxes()
        {
            RcboxCategories_Validated(new object(), new EventArgs());
            RcboxSuppliers_Validated(new object(), new EventArgs());
        }

        private Product GetNewProductInfo()
        {
            try
            {
                string productName = txtProductName.Text;
                decimal unitPrice = decimal.Parse(txtUnitPrice.Text);
                decimal qty = decimal.Parse(txtQty.Text);
                decimal discount;
                if (txtDiscount.Text.Equals(string.Empty))
                {
                    discount = 0;
                }
                else
                {
                    discount = decimal.Parse(txtDiscount.Text);
                }
                long categoryId = Convert.ToInt64(RcboxCategories.SelectedValue);
                //Category category = CategoryViewModel.GetEntity(categoryId);
                long supplierId = Convert.ToInt64(RcboxSuppliers.SelectedValue);

                return new Product(productName, unitPrice, qty, discount, categoryId, supplierId);
            }
            catch (Exception)
            {
                return null;
            }
        }

        private void ClearAllTextBoxes()
        {
            txtProductName.Text = string.Empty;
            txtUnitPrice.Text = string.Empty;
            txtQty.Text = string.Empty;
            txtDiscount.Text = string.Empty;
        }

        private void UpdatePanel(GridViewRowInfo currentRow)
        {
            if (currentRow != null)
            {
                txtProductName.Text = GetSafeString(currentRow.Cells["ProductName"].Value);
                txtUnitPrice.Text = GetSafeString(currentRow.Cells["UnitPrice"].Value);
                txtQty.Text = GetSafeString(currentRow.Cells["Qty"].Value);
                txtDiscount.Text = GetSafeString(currentRow.Cells["Discount"].Value);

                RcboxCategories.SelectedValue = currentRow.Cells["CategoryId"].Value;
                RcboxSuppliers.SelectedValue = currentRow.Cells["SupplierId"].Value;
                // Prevent accidental validation
                ValidateAllTextBoxes();
            }
            else
            {
                txtProductName.Text = string.Empty;
                txtUnitPrice.Text = string.Empty;
                txtQty.Text = string.Empty;
                txtDiscount.Text = string.Empty;
                DeselectCategoryComboBoxCurrentRow();
                DeselectSupplierComboBoxCurrentRow();
            }
        }

        private string GetSafeString(object value)
        {
            if (value == null)
            {
                return string.Empty;
            }

            return value.ToString();
        }

        private Product GetCurrentSelectedProduct(GridViewRowInfo currentRow)
        {
            return ProductViewModel.GetEntity((long)currentRow.Cells["ProductId"].Value);
        }
        #endregion

        #region -----  Events  -----

        private void btnSave_Click(object sender, EventArgs e)
        {
            ValidateAllTextBoxes();
            ValidateComboBoxes();

            // Check if no errors occured from the input
            if (lblProductNameWarning.Visible || lblUnitPriceWarning.Visible ||
                lblQtyWarning.Visible || lblDiscountWarning.Visible || lblCategoryWarning.Visible
                || lblSupplierWarning.Visible)
                return;

            Product newProduct = GetNewProductInfo();
            if (ProductViewModel.GetAllEntities().Contains(newProduct))
            {
                lblResult.Text = "این محصول قبلا در سیستم ثبت شده است";
                lblResult.Visible = true;
                lblResult.ForeColor = Color.DarkRed;
                lblResult.Location = new Point(213, 204);
            }
            else
            {
                ProductViewModel.InsertEntity(newProduct);

                lblResult.Text = "محصول با موفقیت ثبت شد";
                lblResult.Visible = true;
                lblResult.Location = new Point(284, 204);
                lblResult.ForeColor = Color.Green;

                RefreshForm();
                ClearAllTextBoxes();
                DeselectCategoryComboBoxCurrentRow();
                DeselectSupplierComboBoxCurrentRow();
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            ValidateAllTextBoxes();
            ValidateComboBoxes();

            if (lblProductNameWarning.Visible || lblUnitPriceWarning.Visible
                || lblQtyWarning.Visible || lblDiscountWarning.Visible ||
                lblCategoryWarning.Visible || lblSupplierWarning.Visible)
                return;

            Product CurrentProduct = GetCurrentSelectedProduct(RgvProducts.CurrentRow);

            CurrentProduct.ProductName = txtProductName.Text;
            CurrentProduct.UnitPrice = decimal.Parse(txtUnitPrice.Text);
            CurrentProduct.Qty = decimal.Parse(txtQty.Text);
            CurrentProduct.Discount = decimal.Parse(txtDiscount.Text);
            CurrentProduct.CategoryId = (long)RcboxCategories.SelectedValue;
            CurrentProduct.SupplierId = (long)RcboxSuppliers.SelectedValue;

            ProductViewModel.ModifyEntity(CurrentProduct);

            lblResult.Text = "تغییرات اعمال شد";
            lblResult.ForeColor = Color.Green;
            lblResult.Location = new Point(346, 204);
            lblResult.Visible = true;

            btnUpdate_Click(new object(), new EventArgs());
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (RgvProducts.CurrentRow == null)
            {
                lblResult.Text = "هیچ سطری برای حذف انتخاب نشده است";
                lblResult.ForeColor = Color.DarkRed;
                lblResult.Location = new Point(215, 204);
                lblResult.Visible = true;
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("آیا میخواهید این محصول را حذف کنید؟", "هشدار", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.OK)
                {
                    ProductViewModel.RemoveEntity(GetCurrentSelectedProduct(RgvProducts.CurrentRow));
                    
                    btnUpdate_Click(new object(), new EventArgs());

                    lblResult.Text = "مشتری با موفقیت حذف شد";
                    lblResult.ForeColor = Color.Green;
                    lblResult.Location = new Point(280, 201);
                    lblResult.Visible = true;
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            RefreshForm();
            DeselectGridViewCurrentRow();
            DeselectSupplierComboBoxCurrentRow();
            DeselectCategoryComboBoxCurrentRow();
        }

        private void RgvProducts_CurrentRowChanged(object sender, CurrentRowChangedEventArgs e)
        {
            UpdatePanel(RgvProducts.CurrentRow);
            btnModify.Enabled = true;
        }

        private void txtProductName_Validated(object sender, EventArgs e)
        {
            if (txtProductName.Text.Equals(string.Empty))
            {
                lblProductNameWarning.Visible = true;
            }
            else
            {
                lblProductNameWarning.Visible = false;
            }
        }

        private void txtUnitPrice_Validated(object sender, EventArgs e)
        {
            Regex integerNumber = new Regex("^[0-9]+$");
            Regex decimalNumber = new Regex("^[0-9]*[.][0-9]+$");
            if (txtUnitPrice.Text.Equals(string.Empty))
            {
                lblUnitPriceWarning.Text = "قیمت واحد نمیتواند خالی باشد";
                lblUnitPriceWarning.Location = new Point(347, 86);
                lblUnitPriceWarning.Visible = true;
            }
            else if (!integerNumber.IsMatch(txtUnitPrice.Text) &&
                !decimalNumber.IsMatch(txtUnitPrice.Text))
            {
                lblUnitPriceWarning.Text = "قیمت واحد نمیتواند شامل کاراکتر باشد";
                lblUnitPriceWarning.Location = new Point(316, 86);
                lblUnitPriceWarning.Visible = true;
            }
            else
            {
                lblUnitPriceWarning.Visible = false;
            }
        }

        private void txtQty_Validated(object sender, EventArgs e)
        {
            Regex integerMatcher = new Regex("^[0-9]+$");
            Regex decimalNumber = new Regex("^[0-9]*[.][0-9]+$");
            if (txtQty.Text.Equals(string.Empty))
            {
                lblQtyWarning.Text = "تعداد نمیتواند خالی باشد";
                lblQtyWarning.Location = new Point(373, 116);
                lblQtyWarning.Visible = true;
            }
            else if (!integerMatcher.IsMatch(txtQty.Text) && 
                !decimalNumber.IsMatch(txtQty.Text))
            {
                lblQtyWarning.Text = "تعداد نمیتواند شامل کاراکتر باشد";
                lblQtyWarning.Location = new Point(341, 116);
                lblQtyWarning.Visible = true;
            }
            else
            {
                lblQtyWarning.Visible = false;
            }
        }

        private void txtDiscount_Validated(object sender, EventArgs e)
        {
            Regex integerNumber = new Regex("^[0-9]+$");
            Regex decimalNumber = new Regex("^[0-9]*[.][0-9]+$");
            if (!decimalNumber.IsMatch(txtDiscount.Text) &&
                !integerNumber.IsMatch(txtDiscount.Text))
            {
                lblDiscountWarning.Text = "تخفیف نمیتواند شامل کاراکتر باشد";
                lblDiscountWarning.Location = new Point(334, 142);
                lblDiscountWarning.Visible = true;
            }
            else
            {
                decimal toNumber = Convert.ToDecimal(txtDiscount.Text);
                if (!(toNumber >= 0 && toNumber <= 100))
                {
                    lblDiscountWarning.Text = "تخفیف باید عددی بین یک تا صد باشد";
                    lblDiscountWarning.Location = new Point(314, 142);
                    lblDiscountWarning.Visible = true;
                }
                else
                {
                    lblDiscountWarning.Visible = false;
                }
            }
        }

        private void RcboxCategories_Validated(object sender, EventArgs e)
        {
            if (RcboxCategories.SelectedValue == null)
            {
                lblCategoryWarning.Visible = true;
            }
            else
            {
                lblCategoryWarning.Visible = false;
            }
        }

        private void RcboxSuppliers_Validated(object sender, EventArgs e)
        {
            if (RcboxSuppliers.SelectedValue == null)
            {
                lblSupplierWarning.Visible = true;
            }
            else
            {
                lblSupplierWarning.Visible = false;
            }
        }

        #endregion

    }
}
