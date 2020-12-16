namespace SqlShop.View.Forms
{
    partial class FrmCustomer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.btnDelete = new Telerik.WinControls.UI.RadButton();
            this.btnModify = new Telerik.WinControls.UI.RadButton();
            this.btnSave = new Telerik.WinControls.UI.RadButton();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel6 = new Telerik.WinControls.UI.RadLabel();
            this.lblTitle = new Telerik.WinControls.UI.RadLabel();
            this.txtEmail = new Telerik.WinControls.UI.RadTextBox();
            this.txtLastName = new Telerik.WinControls.UI.RadTextBox();
            this.txtAddress = new Telerik.WinControls.UI.RadTextBox();
            this.txtFirstName = new Telerik.WinControls.UI.RadTextBox();
            this.txtPhone = new Telerik.WinControls.UI.RadTextBox();
            this.lblFirstNameWarning = new Telerik.WinControls.UI.RadLabel();
            this.lblPhoneWarning = new Telerik.WinControls.UI.RadLabel();
            this.radLabel9 = new Telerik.WinControls.UI.RadLabel();
            this.lblLastNameWarning = new Telerik.WinControls.UI.RadLabel();
            this.lblEmailWarning = new Telerik.WinControls.UI.RadLabel();
            this.lblAddressWarning = new Telerik.WinControls.UI.RadLabel();
            this.RgvCustomers = new Telerik.WinControls.UI.RadGridView();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblResult = new Telerik.WinControls.UI.RadLabel();
            this.btnUpdate = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnModify)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLastName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFirstName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblFirstNameWarning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblPhoneWarning)).BeginInit();
            this.lblPhoneWarning.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblLastNameWarning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblEmailWarning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblAddressWarning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RgvCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RgvCustomers.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(466, 166);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(64, 30);
            this.btnDelete.TabIndex = 56;
            this.btnDelete.Text = "حذف";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnModify
            // 
            this.btnModify.Enabled = false;
            this.btnModify.Location = new System.Drawing.Point(536, 166);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(64, 30);
            this.btnModify.TabIndex = 7;
            this.btnModify.Text = "ویرایش";
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(606, 166);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(64, 30);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "ذخیره";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // radLabel3
            // 
            this.radLabel3.Font = new System.Drawing.Font("IRANSans Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.radLabel3.Location = new System.Drawing.Point(557, 103);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radLabel3.Size = new System.Drawing.Size(66, 24);
            this.radLabel3.TabIndex = 13;
            this.radLabel3.Text = "شماره تلفن";
            this.radLabel3.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // radLabel4
            // 
            this.radLabel4.Font = new System.Drawing.Font("IRANSans Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.radLabel4.Location = new System.Drawing.Point(557, 129);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radLabel4.Size = new System.Drawing.Size(36, 24);
            this.radLabel4.TabIndex = 14;
            this.radLabel4.Text = "ایمیل";
            this.radLabel4.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("IRANSans Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.radLabel2.Location = new System.Drawing.Point(557, 73);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radLabel2.Size = new System.Drawing.Size(117, 24);
            this.radLabel2.TabIndex = 15;
            this.radLabel2.Text = "نام خانوادگی مشتری";
            this.radLabel2.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // radLabel5
            // 
            this.radLabel5.Font = new System.Drawing.Font("IRANSans Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.radLabel5.Location = new System.Drawing.Point(208, 44);
            this.radLabel5.Name = "radLabel5";
            this.radLabel5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radLabel5.Size = new System.Drawing.Size(37, 24);
            this.radLabel5.TabIndex = 16;
            this.radLabel5.Text = "آدرس";
            this.radLabel5.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("IRANSans Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.radLabel1.Location = new System.Drawing.Point(557, 43);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radLabel1.Size = new System.Drawing.Size(64, 24);
            this.radLabel1.TabIndex = 17;
            this.radLabel1.Text = "نام مشتری";
            this.radLabel1.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // radLabel6
            // 
            this.radLabel6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.radLabel6.Font = new System.Drawing.Font("IRANSans Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.radLabel6.Location = new System.Drawing.Point(523, 205);
            this.radLabel6.Name = "radLabel6";
            this.radLabel6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radLabel6.Size = new System.Drawing.Size(147, 24);
            this.radLabel6.TabIndex = 18;
            this.radLabel6.Text = "لیست مشتری های موجود";
            this.radLabel6.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTitle.Font = new System.Drawing.Font("IRANSans Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblTitle.Location = new System.Drawing.Point(625, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(45, 24);
            this.lblTitle.TabIndex = 19;
            this.lblTitle.Text = "مشتری";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(409, 134);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(133, 20);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.Validated += new System.EventHandler(this.txtEmail_Validated);
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(409, 78);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtLastName.Size = new System.Drawing.Size(133, 20);
            this.txtLastName.TabIndex = 1;
            this.txtLastName.Validated += new System.EventHandler(this.txtLastName_Validated);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(21, 49);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.txtAddress.RootElement.StretchVertically = true;
            this.txtAddress.Size = new System.Drawing.Size(167, 79);
            this.txtAddress.TabIndex = 4;
            this.txtAddress.Validated += new System.EventHandler(this.txtAddress_Validated);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(409, 48);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtFirstName.Size = new System.Drawing.Size(133, 20);
            this.txtFirstName.TabIndex = 0;
            this.txtFirstName.Validated += new System.EventHandler(this.txtFirstName_Validated);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(409, 108);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(133, 20);
            this.txtPhone.TabIndex = 2;
            this.txtPhone.Validated += new System.EventHandler(this.txtPhone_Validated);
            // 
            // lblFirstNameWarning
            // 
            this.lblFirstNameWarning.Font = new System.Drawing.Font("IRANSans Light", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblFirstNameWarning.ForeColor = System.Drawing.Color.DarkRed;
            this.lblFirstNameWarning.Location = new System.Drawing.Point(297, 47);
            this.lblFirstNameWarning.Name = "lblFirstNameWarning";
            this.lblFirstNameWarning.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblFirstNameWarning.Size = new System.Drawing.Size(104, 20);
            this.lblFirstNameWarning.TabIndex = 17;
            this.lblFirstNameWarning.Text = "نام نمیتواند خالی باشد";
            this.lblFirstNameWarning.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.lblFirstNameWarning.Visible = false;
            // 
            // lblPhoneWarning
            // 
            this.lblPhoneWarning.Controls.Add(this.radLabel9);
            this.lblPhoneWarning.Font = new System.Drawing.Font("IRANSans Light", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblPhoneWarning.ForeColor = System.Drawing.Color.DarkRed;
            this.lblPhoneWarning.Location = new System.Drawing.Point(261, 107);
            this.lblPhoneWarning.Name = "lblPhoneWarning";
            this.lblPhoneWarning.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPhoneWarning.Size = new System.Drawing.Size(140, 20);
            this.lblPhoneWarning.TabIndex = 17;
            this.lblPhoneWarning.Text = "شماره تلفن نمیتواند خالی باشد";
            this.lblPhoneWarning.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.lblPhoneWarning.Visible = false;
            // 
            // radLabel9
            // 
            this.radLabel9.Font = new System.Drawing.Font("IRANSans Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.radLabel9.Location = new System.Drawing.Point(0, 25);
            this.radLabel9.Name = "radLabel9";
            this.radLabel9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radLabel9.Size = new System.Drawing.Size(64, 24);
            this.radLabel9.TabIndex = 17;
            this.radLabel9.Text = "نام مشتری";
            this.radLabel9.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblLastNameWarning
            // 
            this.lblLastNameWarning.Font = new System.Drawing.Font("IRANSans Light", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblLastNameWarning.ForeColor = System.Drawing.Color.DarkRed;
            this.lblLastNameWarning.Location = new System.Drawing.Point(253, 77);
            this.lblLastNameWarning.Name = "lblLastNameWarning";
            this.lblLastNameWarning.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblLastNameWarning.Size = new System.Drawing.Size(148, 20);
            this.lblLastNameWarning.TabIndex = 17;
            this.lblLastNameWarning.Text = "نام خانوادگی نمیتواند خالی باشد";
            this.lblLastNameWarning.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.lblLastNameWarning.Visible = false;
            // 
            // lblEmailWarning
            // 
            this.lblEmailWarning.Font = new System.Drawing.Font("IRANSans Light", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblEmailWarning.ForeColor = System.Drawing.Color.DarkRed;
            this.lblEmailWarning.Location = new System.Drawing.Point(216, 133);
            this.lblEmailWarning.Name = "lblEmailWarning";
            this.lblEmailWarning.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblEmailWarning.Size = new System.Drawing.Size(185, 20);
            this.lblEmailWarning.TabIndex = 17;
            this.lblEmailWarning.Text = "فرمت وارد شده برای ایمیل صحیح نیست";
            this.lblEmailWarning.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.lblEmailWarning.Visible = false;
            // 
            // lblAddressWarning
            // 
            this.lblAddressWarning.Font = new System.Drawing.Font("IRANSans Light", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblAddressWarning.ForeColor = System.Drawing.Color.DarkRed;
            this.lblAddressWarning.Location = new System.Drawing.Point(21, 136);
            this.lblAddressWarning.Name = "lblAddressWarning";
            this.lblAddressWarning.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblAddressWarning.Size = new System.Drawing.Size(117, 20);
            this.lblAddressWarning.TabIndex = 17;
            this.lblAddressWarning.Text = "آدرس نمیتواند خالی باشد";
            this.lblAddressWarning.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.lblAddressWarning.Visible = false;
            // 
            // RgvCustomers
            // 
            this.RgvCustomers.Location = new System.Drawing.Point(8, 239);
            // 
            // 
            // 
            this.RgvCustomers.MasterTemplate.AllowAddNewRow = false;
            this.RgvCustomers.MasterTemplate.AllowDragToGroup = false;
            gridViewDecimalColumn1.DataType = typeof(long);
            gridViewDecimalColumn1.FieldName = "CustomerId";
            gridViewDecimalColumn1.HeaderText = "آیدی";
            gridViewDecimalColumn1.IsAutoGenerated = true;
            gridViewDecimalColumn1.Name = "CustomerId";
            gridViewDecimalColumn1.Width = 40;
            gridViewTextBoxColumn1.FieldName = "FirstName";
            gridViewTextBoxColumn1.HeaderText = "نام";
            gridViewTextBoxColumn1.IsAutoGenerated = true;
            gridViewTextBoxColumn1.Name = "FirstName";
            gridViewTextBoxColumn1.Width = 70;
            gridViewTextBoxColumn2.FieldName = "LastName";
            gridViewTextBoxColumn2.HeaderText = "نام خانوادگی";
            gridViewTextBoxColumn2.IsAutoGenerated = true;
            gridViewTextBoxColumn2.Name = "LastName";
            gridViewTextBoxColumn2.Width = 110;
            gridViewTextBoxColumn3.FieldName = "PhoneNumber";
            gridViewTextBoxColumn3.HeaderText = "شماره تلفن";
            gridViewTextBoxColumn3.IsAutoGenerated = true;
            gridViewTextBoxColumn3.Name = "PhoneNumber";
            gridViewTextBoxColumn3.Width = 130;
            gridViewTextBoxColumn4.FieldName = "Email";
            gridViewTextBoxColumn4.HeaderText = "ایمیل";
            gridViewTextBoxColumn4.IsAutoGenerated = true;
            gridViewTextBoxColumn4.Name = "Email";
            gridViewTextBoxColumn4.Width = 150;
            gridViewTextBoxColumn5.FieldName = "Address";
            gridViewTextBoxColumn5.HeaderText = "آدرس";
            gridViewTextBoxColumn5.IsAutoGenerated = true;
            gridViewTextBoxColumn5.Name = "Address";
            gridViewTextBoxColumn5.Width = 150;
            this.RgvCustomers.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn1,
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5});
            this.RgvCustomers.MasterTemplate.DataSource = this.customerBindingSource;
            this.RgvCustomers.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.RgvCustomers.Name = "RgvCustomers";
            this.RgvCustomers.ReadOnly = true;
            this.RgvCustomers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RgvCustomers.Size = new System.Drawing.Size(666, 235);
            this.RgvCustomers.TabIndex = 20;
            this.RgvCustomers.CurrentRowChanged += new Telerik.WinControls.UI.CurrentRowChangedEventHandler(this.RgvCustomers_CurrentRowChanged);
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataSource = typeof(SqlShop.DayaLayer.Models.Entity.Customer);
            // 
            // lblResult
            // 
            this.lblResult.Font = new System.Drawing.Font("IRANSans Light", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblResult.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblResult.Location = new System.Drawing.Point(279, 201);
            this.lblResult.Name = "lblResult";
            this.lblResult.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblResult.Size = new System.Drawing.Size(161, 25);
            this.lblResult.TabIndex = 17;
            this.lblResult.Text = "مشتری با موفقیت حذف شد";
            this.lblResult.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.lblResult.Visible = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(389, 166);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(71, 30);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "به روز رسانی";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // FrmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(687, 510);
            this.Controls.Add(this.RgvCustomers);
            this.Controls.Add(this.lblAddressWarning);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblEmailWarning);
            this.Controls.Add(this.lblLastNameWarning);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.radLabel4);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.radLabel5);
            this.Controls.Add(this.lblPhoneWarning);
            this.Controls.Add(this.lblFirstNameWarning);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.radLabel6);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtPhone);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCustomer";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "FrmCustomer";
            this.Load += new System.EventHandler(this.FrmCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnModify)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLastName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFirstName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblFirstNameWarning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblPhoneWarning)).EndInit();
            this.lblPhoneWarning.ResumeLayout(false);
            this.lblPhoneWarning.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblLastNameWarning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblEmailWarning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblAddressWarning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RgvCustomers.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RgvCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Telerik.WinControls.UI.RadButton btnDelete;
        private Telerik.WinControls.UI.RadButton btnModify;
        private Telerik.WinControls.UI.RadButton btnSave;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel6;
        private Telerik.WinControls.UI.RadLabel lblTitle;
        private Telerik.WinControls.UI.RadTextBox txtEmail;
        private Telerik.WinControls.UI.RadTextBox txtLastName;
        private Telerik.WinControls.UI.RadTextBox txtAddress;
        private Telerik.WinControls.UI.RadTextBox txtFirstName;
        private Telerik.WinControls.UI.RadTextBox txtPhone;
        private Telerik.WinControls.UI.RadLabel lblFirstNameWarning;
        private Telerik.WinControls.UI.RadLabel lblPhoneWarning;
        private Telerik.WinControls.UI.RadLabel radLabel9;
        private Telerik.WinControls.UI.RadLabel lblLastNameWarning;
        private Telerik.WinControls.UI.RadLabel lblEmailWarning;
        private Telerik.WinControls.UI.RadLabel lblAddressWarning;
        private Telerik.WinControls.UI.RadGridView RgvCustomers;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private Telerik.WinControls.UI.RadLabel lblResult;
        private Telerik.WinControls.UI.RadButton btnUpdate;
    }
}
