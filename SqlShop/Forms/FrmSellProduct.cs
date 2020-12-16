using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using SqlShop.DayaLayer.Models.Entity;
using SqlShop.ModelView.DTO;
using Stimulsoft.Base.Drawing;
using Stimulsoft.Report;
using Stimulsoft.Report.Components;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace SqlShop.View.Forms
{
    public partial class FrmSellProduct : Telerik.WinControls.UI.RadForm
    {
        public Order Order { get; set; }
        public ICollection<OrderDetails> GridViewOrderDetails { get; set; }

        public CustomerViewModel CustomerViewModel { get; set; }
        public ProductViewModel ProductViewModel { get; set; }
        public OrderDetailsViewModel OrderDetailsViewModel { get; set; }
        public OrderViewModel OrderViewModel { get; set; }

        public FrmSellProduct()
        {
            InitializeComponent();

            CustomerViewModel = new CustomerViewModel();
            ProductViewModel = new ProductViewModel();
            OrderDetailsViewModel = new OrderDetailsViewModel();
            OrderViewModel = new OrderViewModel();


            GridViewOrderDetails = new BindingList<OrderDetails>();
            Order = new Order();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            RcboxCustomers.MultiColumnComboBoxElement.DropDownWidth = 300;
            RcboxCustomers.DataSource = CustomerViewModel.GetAllNonDeletedEntities();
            RcboxProducts.MultiColumnComboBoxElement.DropDownWidth = 400;
            RcboxProducts.DataSource = ProductViewModel.GetAllNonDeletedEntities();
            RgvOrderDetails.DataSource = GridViewOrderDetails;

            DeselectCustomerComboBox();
            DeselectProductComboBox();
        }

        #region -----  Methods  -----

        private void DeselectCustomerComboBox()
        {
            RcboxCustomers.SelectedItem = null;
            txtCustomerId.Text = string.Empty;
        }

        private void DeselectProductComboBox()
        {
            RcboxProducts.SelectedItem = null;
            txtProductId.Text = string.Empty;
        }

        private void ValidateDate()
        {
            try
            {
                int day = int.Parse(txtDay.Text);
                int month = int.Parse(txtMonth.Text);
                int year = int.Parse(txtYear.Text);

                if (!(day > 0 && day < 31))
                {
                    throw new Exception();
                }
                else if (!(month > 0 && month < 13))
                {
                    throw new Exception();
                }
                else if (!(year > 1380 && year < 1400))
                {
                    throw new Exception();
                }
                else
                {
                    lblDateResult.Visible = false;
                }
            }
            catch (Exception)
            {
                lblDateResult.Visible = true;
            }
        }
        private void ValidateTopPanel()
        {
            txtOrderCode_Validated(new object(), new EventArgs());
            ValidateDate();
            txtCustomerId_Validated(new object(), new EventArgs());
            RcboxCustomers_Validated(new object(), new EventArgs());
        }

        private void ValidateProductPanel()
        {
            txtProductId_Validated(new object(), new EventArgs());
            RcboxCustomers_Validated(new object(), new EventArgs());
            txtQty_Validated(new object(), new EventArgs());
        }

        private void UpdateGridView()
        {
            //RgvOrderDetails.DataSource = null;
            RgvOrderDetails.DataSource = GridViewOrderDetails;
            DeselectGridViewCurrentRow();
        }

        private bool ProductAlreadyEntered(long productId)
        {
            foreach (var orderDetails in GridViewOrderDetails)
            {
                if (orderDetails.ProductId == productId)
                {
                    return true;
                }
            }
            return false;
        }

        private decimal CalculateFinallPrice()
        {
            decimal finallPrice = 0;
            foreach (var OrderDetails in GridViewOrderDetails)
            {
                decimal thisOrderPrice = OrderDetails.UnitPrice * OrderDetails.Qty;
                thisOrderPrice = thisOrderPrice * (100 - OrderDetails.Discount)/100;
                finallPrice += thisOrderPrice;
            }
            return finallPrice;
        }

        private void UpdateProductPanel()
        {
            GridViewRowInfo currentRow = RgvOrderDetails.CurrentRow;
            if (currentRow != null)
            {
                long productId = Convert.ToInt64(currentRow.Cells["ProductId"].Value);
                txtProductId.Text = productId.ToString();
                RcboxProducts.SelectedValue = currentRow.Cells["ProductId"].Value;
                decimal qty = Convert.ToDecimal(currentRow.Cells["Qty"].Value);
                txtQty.Text = qty.ToString();

                txtProductId.Enabled = false;
                RcboxProducts.Enabled = false;
            }
            else
            {
                ClearProductPanel();

                txtProductId.Enabled = true;
                RcboxProducts.Enabled = true;
            }
        }

        private void ClearProductPanel()
        {
            txtProductId.Text = string.Empty;
            DeselectProductComboBox();
            txtQty.Text = string.Empty;
        }

        private void DeselectGridViewCurrentRow()
        {
            try
            {
                RgvOrderDetails.CurrentRow = null;
            }
            catch (Exception)
            {
            }
        }

        private OrderDetails GetOrderDetails(long productId)
        {
            foreach (var orderDetails in GridViewOrderDetails)
            {
                if (orderDetails.ProductId == productId)
                    return orderDetails;
            }

            return null;
        }

        private void RefreshPage()
        {
            ClearTopPanel();
            EnabledTopPanel(true);
            ClearProductPanel();
            InvisibleAllResultLabels();
            // Clear all items in GridOrderDetails
            GridViewOrderDetails.Clear();
            UpdateGridView();

            // Refresh RadCombobox Product and Customer
            RcboxCustomers.DataSource = CustomerViewModel.GetAllNonDeletedEntities();
            RcboxProducts.DataSource = ProductViewModel.GetAllNonDeletedEntities();

        }

        private void ClearTopPanel()
        {
            txtOrderCode.Text = string.Empty;
            txtDay.Text = string.Empty;
            txtMonth.Text = string.Empty;
            txtYear.Text = string.Empty;
            DeselectCustomerComboBox();
        }

        private void EnabledTopPanel(bool enable)
        {
            txtOrderCode.Enabled = enable;
            txtDay.Enabled = enable;
            txtMonth.Enabled = enable;
            txtYear.Enabled = enable;
            txtCustomerId.Enabled = enable;
            RcboxCustomers.Enabled = enable;
            btnRegisterCustomer.Enabled = enable;
        }
        private void InvisibleAllResultLabels()
        {
            lblOrderCodeResult.Visible = false;
            lblDateResult.Visible = false;
            lblCustomerResult.Visible = false;
            lblProductResult.Visible = false;
            lblQtyResult.Visible = false;
            lblCustomerName.Visible = false;
            lblFinalPrice.Text = "0";
        }

        #endregion

        #region -----  Events  -----

        private void RgvOrderDetails_CurrentRowChanged(object sender, Telerik.WinControls.UI.CurrentRowChangedEventArgs e)
        {
            UpdateProductPanel();
        }

        #region -----  SelectedValueChanged Events  -----

        private void RcboxCustomers_SelectedValueChanged(object sender, EventArgs e)
        {
            if (RcboxCustomers.SelectedValue != null)
            {
                lblCustomerResult.Visible = false;
                long CustomerId = (long)RcboxCustomers.SelectedValue;
                txtCustomerId.Text = CustomerId.ToString();
            }
        }

        private void RcboxProducts_SelectedValueChanged(object sender, EventArgs e)
        {
            if (RcboxProducts.SelectedValue != null)
            {
                lblProductResult.Visible = false;
                long ProductId = (long)RcboxProducts.SelectedValue;
                txtProductId.Text = ProductId.ToString();
            }
        }

        #endregion

        #region -----  Validated Events  -----

        private void RcboxCustomers_Validated(object sender, EventArgs e)
        {
            if (RcboxCustomers.SelectedValue == null)
            {
                lblCustomerResult.Visible = true;
            }
            else
            {
                lblCustomerResult.Visible = false;
            }
        }

        private void txtCustomerId_Validated(object sender, EventArgs e)
            {
            try
            {
                long CustomerId = long.Parse(txtCustomerId.Text);
                RcboxCustomers.SelectedValue = CustomerId;
                if ((long)RcboxCustomers.SelectedValue != CustomerId)
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                RcboxCustomers.SelectedItem = null;
                txtCustomerId.Text = string.Empty;
                lblCustomerResult.Visible = true;
            }
        }

        

        private void RcboxProducts_Validated(object sender, EventArgs e)
        {
            if (RcboxProducts.SelectedValue == null)
            {
                lblProductResult.Visible = true;
            }
            else
            {
                lblProductResult.Visible = false;
            }
        }

        private void txtProductId_Validated(object sender, EventArgs e)
        {
            try
            {
                long ProductId = long.Parse(txtProductId.Text);
                RcboxProducts.SelectedValue = ProductId;
                if ((long)RcboxProducts.SelectedValue != ProductId)
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                RcboxProducts.SelectedItem = null;
                txtProductId.Text = string.Empty;
                lblProductResult.Visible = true;
            }
        }

        private void txtOrderCode_Validated(object sender, EventArgs e)
        {
            if (txtOrderCode.Text.Equals(string.Empty))
            {
                lblOrderCodeResult.Visible = true;
            }
            else
            {
                lblOrderCodeResult.Visible = false;
            }
        }

        private void txtQty_Validated(object sender, EventArgs e)
        {
            if (txtQty.Text.Equals(string.Empty))
            {
                lblQtyResult.Text = "تعداد نمیتواند خالی باشد";
                lblQtyResult.Visible = true;
            }
            else
            {
                lblQtyResult.Visible = false;
            }
        }

        #endregion

        #region -----  ButtonClick Events  -----

        private void btnRegisterCustomer_Click(object sender, EventArgs e)
        {
            ValidateTopPanel();

            if (lblCustomerResult.Visible || lblOrderCodeResult.Visible || lblDateResult.Visible)
                return;

            string orderCode = txtOrderCode.Text;
            int day = int.Parse(txtDay.Text);
            int month = int.Parse(txtMonth.Text);
            int year = int.Parse(txtYear.Text);
            string orderDate = string.Format("{0}{1}{2}", year.ToString("D4"), month.ToString("D2")
                , day.ToString("D2"));
            long customerId = long.Parse(txtCustomerId.Text);
            Order.OrderCode = orderCode;
            Order.OrderDate = orderDate;
            Order.CustomerId = customerId;

            lblCustomerName.Text = RcboxCustomers.Text;
            
            // Disable Top Panel UserControls
            lblCustomerName.Visible = true;
            EnabledTopPanel(false);
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (!btnAddProduct.Enabled)
                return;

            ValidateProductPanel();

            if (lblProductResult.Visible || lblQtyResult.Visible)
                return;

            Product newProduct = ProductViewModel.GetEntity(long.Parse(txtProductId.Text));

            if (ProductAlreadyEntered(newProduct.ProductId))
            {
                MessageBox.Show("این محصول قبلا در فاکتور اضافه شده است.برای حذف یا " +
                    "ویرایش آن بر روی دکمه های مورد نظر کلیک کنید");
            }
            else
            {

                decimal unitPrice = newProduct.UnitPrice;
                decimal discount = newProduct.Discount;
                decimal qty = decimal.Parse(txtQty.Text);

                // Check the existance of the Product
                if (qty > newProduct.Qty)
                {
                    lblQtyResult.Text = "تعداد محصول های موجود کافی نیست";
                    lblQtyResult.Visible = true;
                }
                else
                {
                    lblQtyResult.Visible = false;

                    // Clear new OrderDetail and add it to the RadGridView
                    OrderDetails orderDetails = new OrderDetails()
                    {
                        UnitPrice = unitPrice,
                        Discount = discount,
                        Qty = qty,
                        ProductId = newProduct.ProductId
                    };
                    GridViewOrderDetails.Add(orderDetails);
                    UpdateGridView();
                    ClearProductPanel();
                    lblFinalPrice.Text = (long)CalculateFinallPrice()/1000 + " (x1000)تومان";
                }
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (RgvOrderDetails.CurrentRow == null)
            {
                MessageBox.Show("هیچ سطری برای تغییر انتخاب نشده است");
            }
            else
            {
                txtQty_Validated(new object(), new EventArgs());

                if (lblQtyResult.Visible)
                    return;

                // Modify Current Row
                long productId = Convert.ToInt64(RgvOrderDetails.CurrentRow.Cells["ProductId"].Value);
                OrderDetails CurrentOrderDetails = GetOrderDetails(productId);
                
                CurrentOrderDetails.Qty = decimal.Parse(txtQty.Text);
                UpdateGridView();

                lblFinalPrice.Text = (long)CalculateFinallPrice()/1000 + " (x1000)تومان";
                MessageBox.Show("تغییرات اعمال شد");
                
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            GridViewRowInfo currentRow = RgvOrderDetails.CurrentRow;
            if (currentRow != null)
            {
                DialogResult dialogResult = MessageBox.Show("آیا میخواهید این محصول را حذف کنید؟", "هشدار", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.OK)
                {
                    long productId = Convert.ToInt64(RgvOrderDetails.CurrentRow.Cells["ProductId"].Value);
                    GridViewOrderDetails.Remove(GetOrderDetails(productId));
                    UpdateGridView();
                    CalculateFinallPrice();
                }
            }
            else
            {
                MessageBox.Show("هیچ سطری انتخاب نشده است");
            }
        }

        private void btnRegisterOrder_Click(object sender, EventArgs e)
        {
            Order.FinallPrice = CalculateFinallPrice();

            OrderViewModel.InsertEntity(Order);

            foreach (var orderDetails in GridViewOrderDetails)
            {
                // Set the OrderId of the OrderDetails
                orderDetails.OrderId = Order.OrderId;
                // Add OrderDetails to the DataBase
                OrderDetailsViewModel.InsertEntity(orderDetails);
                // Modify the product (Qty)
                Product theProduct = ProductViewModel.GetEntity(orderDetails.ProductId);
                theProduct.Qty -= orderDetails.Qty;
                ProductViewModel.ModifyEntity(theProduct);
            }
            RefreshPage();

            lblOrderResult.Text = "فاکتور به شماره " + Order.OrderCode + " در تاریخ " +
                Order.OrderDate + " با موفقیت ثبت گردید";
            lblOrderResult.Visible = true;
        }

        private void btnPrintOrder_Click(object sender, EventArgs e)
        {
            //StiReport report = new StiReport();
            ////report.RegData(new DataSet());

            ////DataSet ds = new DataSet();
            //report.RegData("Order", CustomerViewModel.GetAllEntities());
            //StiPage Page = report.Pages[0];
            //StiHeaderBand HeaderBand = new StiHeaderBand();
            //HeaderBand.Height = 1;
            //HeaderBand.Name = "فاکتور فروش";
            //Page.Components.Add(HeaderBand);
            //StiText headerText = new StiText(new RectangleD(0, 0, 5, 0.5));
            //headerText.Text = "CompanyName";
            //headerText.HorAlignment = StiTextHorAlignment.Center;
            //headerText.Name = "HeaderText";
            //headerText.Brush = new StiSolidBrush(Color.LightGreen);
            //HeaderBand.Components.Add(headerText);



            //report.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            RefreshPage();
        }
        #endregion

        #region -----  KeyPress Events  -----

        private void txtOrderCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            var regex = new Regex(@"^[a-zA-Z]+$");
            if (regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }

        private void txtCustomerId_KeyPress(object sender, KeyPressEventArgs e)
        {
            var regex = new Regex(@"^[a-zA-Z]+$");
            if (regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }

        private void txtProductId_KeyPress(object sender, KeyPressEventArgs e)
        {
            var regex = new Regex(@"^[a-zA-Z]+$");
            if (regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }

        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            var regex = new Regex(@"^[a-zA-Z]+$");
            if (regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }

        private void txtDay_KeyPress(object sender, KeyPressEventArgs e)
        {
            var regex = new Regex(@"^[a-zA-Z]+$");
            if (regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }

        private void txtMonth_KeyPress(object sender, KeyPressEventArgs e)
        {
            var regex = new Regex(@"^[a-zA-Z]+$");
            if (regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }

        private void txtYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            var regex = new Regex(@"^[a-zA-Z]+$");
            if (regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }


        #endregion

        #endregion

    }
}
