using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using SqlShop.DayaLayer.Models.Entity;
using SqlShop.ModelView.DTO;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace SqlShop.View.Forms
{
    public partial class FrmCustomer : RadForm
    {
        public CustomerViewModel CustomerViewModel { get; set; }

        public FrmCustomer()
        {
            InitializeComponent();

            CustomerViewModel = new CustomerViewModel();
        }

        #region ------ Events ------

        private void FrmCustomer_Load(object sender, EventArgs e)
        {
            UpdateGridInfo();
            DeselectCurrentRow();
        }

        #region -----  Validated Events  -----

        private void txtFirstName_Validated(object sender, EventArgs e)
        {
            if (txtFirstName.Text.Equals(string.Empty))
            {
                lblFirstNameWarning.Visible = true;
            }
            else
            {
                lblFirstNameWarning.Visible = false;
            }
        }

        private void txtLastName_Validated(object sender, EventArgs e)
        {
            if (txtLastName.Text.Equals(string.Empty))
            {
                lblLastNameWarning.Visible = true;
            }
            else
            {
                lblLastNameWarning.Visible = false;
            }
        }

        private void txtPhone_Validated(object sender, EventArgs e)
        {
            if (txtPhone.Text.Equals(string.Empty))
            {
                lblPhoneWarning.Visible = true;
            }
            else
            {
                lblPhoneWarning.Visible = false;
            }
        }

        private void txtEmail_Validated(object sender, EventArgs e)
        {
            bool isEmail = Regex.IsMatch(txtEmail.Text, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);

            if (txtEmail.Text.Equals(string.Empty))
            {
                lblEmailWarning.Text = "ایمیل نمیتواند خالی باشد";
                lblEmailWarning.Location = new Point(285, 133);
                lblEmailWarning.Visible = true;
            }
            else if (!isEmail)
            {
                lblEmailWarning.Text = "فرمت وارد شده برای ایمیل صحیح نیست";
                lblEmailWarning.Location = new Point(216, 133);
                lblEmailWarning.Visible = true;
            }
            else
            {
                lblEmailWarning.Visible = false;
            }
        }

        private void txtAddress_Validated(object sender, EventArgs e)
        {
            if (txtAddress.Text.Equals(string.Empty))
            {
                lblAddressWarning.Visible = true;
            }
            else
            {
                lblAddressWarning.Visible = false;
            }
        }

        #endregion

        #region -----  Buttons Click  -----

        private void btnSave_Click(object sender, EventArgs e)
        {
            ValidateAllTextBoxes();

            Customer newCustomer = GetNewCustomerInfo();

            if (newCustomer != null)
            {
                if (CustomerViewModel.GetAllEntities().Contains(newCustomer))
                {
                    lblResult.Text = "مشتری قبلا در سیستم ثبت شده است";
                    lblResult.ForeColor = Color.DarkRed;
                    lblResult.Location = new Point(216, 201);
                    lblResult.Visible = true;
                }
                else
                {
                    CustomerViewModel.InsertEntity(newCustomer);
                    UpdateGridInfo();
                    lblResult.Text = "مشتری با موفقیت ثبت شد";
                    lblResult.ForeColor = Color.ForestGreen;
                    lblResult.Location = new Point(261, 201);
                    lblResult.Visible = true;
                }
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            ValidateAllTextBoxes();
            if (lblFirstNameWarning.Visible || lblLastNameWarning.Visible || lblPhoneWarning.Visible
                || lblEmailWarning.Visible || lblAddressWarning.Visible)
            {
                lblResult.Text = "تغییرات ثبت نشد!";
                lblResult.ForeColor = Color.DarkRed;
                lblResult.Visible = true;
                return;
            }
            Customer modifiedCustomer = GetSelectedCustomerRef(RgvCustomers.CurrentRow);

            modifiedCustomer.FirstName = txtFirstName.Text;
            modifiedCustomer.LastName = txtLastName.Text;
            modifiedCustomer.PhoneNumber = txtPhone.Text;
            modifiedCustomer.Email = txtEmail.Text;
            modifiedCustomer.Address = txtAddress.Text;

            CustomerViewModel.ModifyEntity(modifiedCustomer);
            UpdateGridInfo();

            lblResult.Text = "تغیرات با موفقیت اعمال شد";
            lblResult.ForeColor = Color.ForestGreen;
            lblResult.Visible = true;


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (RgvCustomers.CurrentRow != null)
            {
                DialogResult dialogResult = MessageBox.Show("آیا میخواهید این مشتری را حذف کنید؟", "هشدار", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.OK)
                {
                    CustomerViewModel.RemoveEntity(GetSelectedCustomerRef(RgvCustomers.CurrentRow));
                    UpdateGridInfo();
                    lblResult.Text = "مشتری با موفقیت حذف شد";
                    lblResult.ForeColor = Color.DarkRed;
                    lblResult.Location = new Point(280, 201);
                    lblResult.Visible = true;
                }
            }
            else
            {
                lblResult.Text = "هیچ مشتری ای برای حذف انتخاب نشده است";
                lblResult.ForeColor = Color.DarkRed;
                lblResult.Location = new Point(192, 201);
                lblResult.Visible = true;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateGridInfo();
            DeselectCurrentRow();
        }

        #endregion

        private void RgvCustomers_CurrentRowChanged(object sender, CurrentRowChangedEventArgs e)
        {
            UpdatePanelInfo(RgvCustomers.CurrentRow);
            btnModify.Enabled = true;
        }

        #endregion

        #region -----  Methods  -----

        private void ValidateAllTextBoxes()
        {
            txtFirstName_Validated(new object(), new EventArgs());
            txtLastName_Validated(new object(), new EventArgs());
            txtPhone_Validated(new object(), new EventArgs());
            txtEmail_Validated(new object(), new EventArgs());
            txtAddress_Validated(new object(), new EventArgs());
        }

        private Customer GetNewCustomerInfo()
        {
            if (lblFirstNameWarning.Visible)
                return null;
            string firstName = txtFirstName.Text;

            if (lblLastNameWarning.Visible)
                return null;
            string lastName = txtLastName.Text;

            if (lblPhoneWarning.Visible)
                return null;
            string phone = txtPhone.Text;

            if (lblEmailWarning.Visible)
                return null;
            string email = txtEmail.Text;

            if (lblAddressWarning.Visible)
                return null;
            string address = txtAddress.Text;

            return new Customer(firstName, lastName, phone, email, address);
        }

        private void UpdatePanelInfo(GridViewRowInfo currentRow)
        {
            if (currentRow != null)
            {
                txtFirstName.Text = GetSafeString(currentRow.Cells["FirstName"].Value);
                txtLastName.Text = GetSafeString(currentRow.Cells["LastName"].Value);
                txtPhone.Text = GetSafeString(currentRow.Cells["PhoneNumber"].Value);
                txtEmail.Text = GetSafeString(currentRow.Cells["Email"].Value);
                txtAddress.Text = GetSafeString(currentRow.Cells["Address"].Value);
                // Prevent accidental validation
                ValidateAllTextBoxes();
            }
            else
            {
                txtFirstName.Text = string.Empty;
                txtLastName.Text = string.Empty;
                txtPhone.Text = string.Empty;
                txtEmail.Text = string.Empty;
                txtAddress.Text = string.Empty;
            }
        }

        private void UpdateGridInfo()
        {
            RgvCustomers.DataSource = CustomerViewModel.GetAllNonDeletedEntities();
        }

        private string GetSafeString(object value)
        {
            if (value == null)
            {
                return string.Empty;
            }

            return value.ToString();
        }

        private void DeselectCurrentRow()
        {
            try
            {
                RgvCustomers.CurrentRow = null;
            }
            catch (Exception)
            {
            }
            finally
            {
                btnModify.Enabled = false;
            }
        }

        private Customer GetSelectedCustomerRef(GridViewRowInfo currentRow)
        {
            long CustomerId = Convert.ToInt64(currentRow.Cells["CustomerId"].Value);
            return CustomerViewModel.GetEntity(CustomerId);
        }

        #endregion

    }
}
