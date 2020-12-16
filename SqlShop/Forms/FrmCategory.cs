using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SqlShop.DayaLayer.Models.Entity;
using SqlShop.ModelView.DTO;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace SqlShop.View.Forms
{
    public partial class FrmCategory : Telerik.WinControls.UI.RadForm
    {
        public CategoryViewModel CategoryViewModel { get; set; }
        public ProductViewModel ProductViewModel { get; set; }

        public FrmCategory()
        {
            InitializeComponent();

            CategoryViewModel = new CategoryViewModel();
            ProductViewModel = new ProductViewModel();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            RgvCategories.DataSource = CategoryViewModel.GetAllEntities();
            
        }

        #region -----  Methods  -----

        private void UpdatePanelInfo(GridViewRowInfo currentRow)
        {
            if (currentRow != null)
            {
                txtCategoryName.Text = currentRow.Cells["CategoryName"].Value as string;
            }
            else
            {
                txtCategoryName.Text = string.Empty;
            }
        }

        private void UpdateProductGridView(GridViewRowInfo currentRow)
        {
            try
            {
                long categoryId = Convert.ToInt64(currentRow.Cells["CategoryId"].Value);
                Category currentSelectedCategory = CategoryViewModel.GetEntity(categoryId);
                RgvProducts.DataSource = ProductViewModel.GetAllEntities(currentSelectedCategory);
            }
            catch(NullReferenceException)
            {
            }
            
        }

        private void UpdateCategoryGridView()
        {
            RgvCategories.DataSource = CategoryViewModel.GetAllEntities();
        }

        private Category GetSelectedCategory(GridViewRowInfo currentRow)
        {
            long categoryId = (long) currentRow.Cells["CategoryId"].Value;
            return CategoryViewModel.GetEntity(categoryId);
        }

        #endregion

        #region -----  Events  -----

        private void txtCategoryName_Validated(object sender, EventArgs e)
        {
            if (txtCategoryName.Text.Equals(string.Empty))
            {
                lblCategoryNameWarning.Visible = true;
            }
            else
            {
                lblCategoryNameWarning.Visible = false;
            }
        }

        private void RgvCategories_CurrentRowChanged(object sender, CurrentRowChangedEventArgs e)
        {
            UpdatePanelInfo(RgvCategories.CurrentRow);
            UpdateProductGridView(RgvCategories.CurrentRow);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            txtCategoryName_Validated(new object(), new EventArgs());

            if (lblCategoryNameWarning.Visible)
                return;

            Category newCategory = new Category(txtCategoryName.Text);

            if (CategoryViewModel.GetAllEntities().Contains(newCategory))
            {
                MessageBox.Show("این گروه کالا قبلا در سیستم ثبت شده است");
            }
            else
            {
                CategoryViewModel.InsertEntity(newCategory);
                MessageBox.Show("محصول با موفقیت ثبت شد");
                UpdateCategoryGridView();
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            txtCategoryName_Validated(new object(), new EventArgs());

            if (lblCategoryNameWarning.Visible)
                return;

            string categoryName = txtCategoryName.Text;
            Category selectedCategory = GetSelectedCategory(RgvCategories.CurrentRow);
            selectedCategory.CategoryName = categoryName;
            CategoryViewModel.ModifyEntity(selectedCategory);
            MessageBox.Show("تغییرات اعمال شد");
            UpdateCategoryGridView();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            GridViewRowInfo currentRow = RgvCategories.CurrentRow;
            if (currentRow != null)
            {
                DialogResult dialogResult = MessageBox.Show("آیا میخواهید این محصول را حذف کنید؟", "هشدار", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.OK)
                {
                    Category selectedCategory = GetSelectedCategory(currentRow);
                    CategoryViewModel.RemoveEntity(selectedCategory);
                    MessageBox.Show("گروه کالا با موفقیت حذف شد");
                    UpdateCategoryGridView();
                    UpdateProductGridView(RgvCategories.CurrentRow);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateCategoryGridView();
            UpdateProductGridView(RgvCategories.CurrentRow);
            txtCategoryName.Text = string.Empty;
        }

        #endregion

        
    }
}
