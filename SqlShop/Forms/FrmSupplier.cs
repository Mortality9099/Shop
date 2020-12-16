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
    public partial class FrmSupplier : Telerik.WinControls.UI.RadForm
    {
        public SupplierViewModel SupplierViewModel { get; set; }
        public ProductViewModel ProductViewModel { get; set; }

        public FrmSupplier()
        {
            InitializeComponent();

            SupplierViewModel = new SupplierViewModel();
            ProductViewModel = new ProductViewModel();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            RgvSuppliers.DataSource = SupplierViewModel.GetAllEntities();

            // Product GridView 
            RgvProducts.DataSource = ProductViewModel.GetAllEntities(GetSelectedSupplier(RgvSuppliers.CurrentRow));
        }

        #region -----  Methods  -----

        private void UpdatePanelInfo(GridViewRowInfo currentRow)
        {
            if (currentRow != null)
            {
                txtContactName.Text = currentRow.Cells["ContactName"].Value as string;
                txtPhoneNumber.Text = currentRow.Cells["PhoneNumber"].Value as string;
                txtAddress.Text = currentRow.Cells["Address"].Value as string;
            }
            else
            {
                ClearPanel();
            }
        }

        private void UpdateProductGridView(GridViewRowInfo currentRow)
        {
            try
            {
                long supplierId = Convert.ToInt64(currentRow.Cells["SupplierId"].Value);
                Supplier selectedSupplier = SupplierViewModel.GetEntity(supplierId);
                RgvProducts.DataSource = ProductViewModel.GetAllEntities(selectedSupplier);
            }
            catch (NullReferenceException)
            {
            }

        }

        private void UpdateSupplierGridView()
        {
            RgvSuppliers.DataSource = SupplierViewModel.GetAllEntities();
        }

        private Supplier GetSelectedSupplier(GridViewRowInfo currentRow)
        {
            long supplierId = (long)currentRow.Cells["SupplierId"].Value;
            return SupplierViewModel.GetEntity(supplierId);
        }

        private void ValidatePanel()
        {
            txtContactName_Validated(new object(), new EventArgs());
            txtPhoneNumber_Validated(new object(), new EventArgs());
            txtAddress_Validated(new object(), new EventArgs());
        }

        private Supplier GetNewSupplierInfo()
        {
            string contactName = txtContactName.Text;
            string phoneNumber = txtPhoneNumber.Text;
            string address = txtAddress.Text;

            return new Supplier(contactName, address, phoneNumber);
        }

        private void ClearPanel()
        {
            txtContactName.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtPhoneNumber.Text = string.Empty;
        }

        #endregion

        #region -----  Events  -----

        #region -----  Validated Events  -----

        private void txtContactName_Validated(object sender, EventArgs e)
        {
            if (txtContactName.Text.Equals(string.Empty))
                lblContactNameWarning.Visible = true;

            else
                lblContactNameWarning.Visible = false;
        }

        private void txtPhoneNumber_Validated(object sender, EventArgs e)
        {
            if (txtPhoneNumber.Text.Equals(string.Empty))
                lblPhoneNumberWarning.Visible = true;

            else
                lblPhoneNumberWarning.Visible = false;
        }

        private void txtAddress_Validated(object sender, EventArgs e)
        {
            if (txtAddress.Text.Equals(string.Empty))
                lblAddressWarning.Visible = true;

            else
                lblAddressWarning.Visible = false;
        }

        #endregion

        private void RgvSuppliers_CurrentRowChanged(object sender, CurrentRowChangedEventArgs e)
        {
            UpdatePanelInfo(RgvSuppliers.CurrentRow);
            UpdateProductGridView(RgvSuppliers.CurrentRow);
        }

        #region -----  Button_Click Events  -----

        private void btnSave_Click(object sender, EventArgs e)
        {
            ValidatePanel();

            if (lblContactNameWarning.Visible || lblPhoneNumberWarning.Visible
                || lblAddressWarning.Visible)
                return;

            Supplier newSupplier = GetNewSupplierInfo();

            if (SupplierViewModel.GetAllEntities().Contains(newSupplier))
            {
                MessageBox.Show("این تامین کننده قبلا در سیستم ثبت شده است");
            }
            else
            {
                SupplierViewModel.InsertEntity(newSupplier);
                MessageBox.Show("تامین کننده با موفقیت ثبت شد");
                UpdateSupplierGridView();
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            ValidatePanel();
            if (lblContactNameWarning.Visible || lblPhoneNumberWarning.Visible
                || lblAddressWarning.Visible)
                return;

            Supplier selectedSupplier = GetSelectedSupplier(RgvSuppliers.CurrentRow);
            selectedSupplier.ContactName = txtContactName.Text;
            selectedSupplier.Address = txtAddress.Text;
            selectedSupplier.PhoneNumber = txtPhoneNumber.Text;

            SupplierViewModel.ModifyEntity(selectedSupplier);
            MessageBox.Show("تامین کننده با موفقیت تغییر کرد");
            UpdateSupplierGridView();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            GridViewRowInfo currentRow = RgvSuppliers.CurrentRow;
            if (currentRow != null)
            {
                DialogResult dialogResult = MessageBox.Show(
                    "آیا میخواهید این تامین کننده را حذف کنید؟", "هشدار"
                    , MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.OK)
                {
                    SupplierViewModel.RemoveEntity(GetSelectedSupplier(RgvSuppliers.CurrentRow));
                    MessageBox.Show("تامین کننده با موفقیت حذف گردید");
                    UpdateSupplierGridView();
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateSupplierGridView();
            ClearPanel();
            
        }

        #endregion

        #endregion

    }
}
