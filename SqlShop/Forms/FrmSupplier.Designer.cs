namespace SqlShop.View.Forms
{
    partial class FrmSupplier
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
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn15 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn9 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn10 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn11 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition5 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn16 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn12 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn17 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn18 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn19 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn20 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn21 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition6 = new Telerik.WinControls.UI.TableViewDefinition();
            this.RgvSuppliers = new Telerik.WinControls.UI.RadGridView();
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RgvProducts = new Telerik.WinControls.UI.RadGridView();
            this.btnUpdate = new Telerik.WinControls.UI.RadButton();
            this.btnDelete = new Telerik.WinControls.UI.RadButton();
            this.btnModify = new Telerik.WinControls.UI.RadButton();
            this.btnSave = new Telerik.WinControls.UI.RadButton();
            this.radLabel6 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.lblTitle = new Telerik.WinControls.UI.RadLabel();
            this.lblAddressWarning = new Telerik.WinControls.UI.RadLabel();
            this.lblContactNameWarning = new Telerik.WinControls.UI.RadLabel();
            this.txtLastName = new Telerik.WinControls.UI.RadTextBox();
            this.radTextBox2 = new Telerik.WinControls.UI.RadTextBox();
            this.txtContactName = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.txtAddress = new Telerik.WinControls.UI.RadTextBox();
            this.txtPhoneNumber = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.lblPhoneNumberWarning = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.RgvSuppliers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RgvSuppliers.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RgvProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RgvProducts.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnModify)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblAddressWarning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblContactNameWarning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLastName)).BeginInit();
            this.txtLastName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContactName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhoneNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblPhoneNumberWarning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // RgvSuppliers
            // 
            this.RgvSuppliers.Location = new System.Drawing.Point(12, 227);
            // 
            // 
            // 
            this.RgvSuppliers.MasterTemplate.AllowAddNewRow = false;
            this.RgvSuppliers.MasterTemplate.AllowColumnReorder = false;
            this.RgvSuppliers.MasterTemplate.AllowDragToGroup = false;
            gridViewDecimalColumn15.DataType = typeof(long);
            gridViewDecimalColumn15.FieldName = "SupplierId";
            gridViewDecimalColumn15.HeaderText = "آیدی تامین کننده";
            gridViewDecimalColumn15.IsAutoGenerated = true;
            gridViewDecimalColumn15.Name = "SupplierId";
            gridViewDecimalColumn15.Width = 120;
            gridViewTextBoxColumn9.FieldName = "ContactName";
            gridViewTextBoxColumn9.HeaderText = "نام تامین کننده";
            gridViewTextBoxColumn9.IsAutoGenerated = true;
            gridViewTextBoxColumn9.Name = "ContactName";
            gridViewTextBoxColumn9.Width = 150;
            gridViewTextBoxColumn10.FieldName = "PhoneNumber";
            gridViewTextBoxColumn10.HeaderText = "شماره تلفن";
            gridViewTextBoxColumn10.IsAutoGenerated = true;
            gridViewTextBoxColumn10.Name = "PhoneNumber";
            gridViewTextBoxColumn10.Width = 140;
            gridViewTextBoxColumn11.FieldName = "Address";
            gridViewTextBoxColumn11.HeaderText = "آدرس";
            gridViewTextBoxColumn11.IsAutoGenerated = true;
            gridViewTextBoxColumn11.Name = "Address";
            gridViewTextBoxColumn11.Width = 250;
            this.RgvSuppliers.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn15,
            gridViewTextBoxColumn9,
            gridViewTextBoxColumn10,
            gridViewTextBoxColumn11});
            this.RgvSuppliers.MasterTemplate.DataSource = this.supplierBindingSource;
            this.RgvSuppliers.MasterTemplate.ViewDefinition = tableViewDefinition5;
            this.RgvSuppliers.Name = "RgvSuppliers";
            this.RgvSuppliers.ReadOnly = true;
            this.RgvSuppliers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RgvSuppliers.Size = new System.Drawing.Size(722, 143);
            this.RgvSuppliers.TabIndex = 91;
            this.RgvSuppliers.CurrentRowChanged += new Telerik.WinControls.UI.CurrentRowChangedEventHandler(this.RgvSuppliers_CurrentRowChanged);
            // 
            // supplierBindingSource
            // 
            this.supplierBindingSource.DataSource = typeof(SqlShop.DayaLayer.Models.Entity.Supplier);
            // 
            // RgvProducts
            // 
            this.RgvProducts.Location = new System.Drawing.Point(12, 406);
            // 
            // 
            // 
            this.RgvProducts.MasterTemplate.AllowAddNewRow = false;
            this.RgvProducts.MasterTemplate.AllowDragToGroup = false;
            gridViewDecimalColumn16.DataType = typeof(long);
            gridViewDecimalColumn16.FieldName = "ProductId";
            gridViewDecimalColumn16.HeaderText = "آیدی";
            gridViewDecimalColumn16.IsAutoGenerated = true;
            gridViewDecimalColumn16.Name = "ProductId";
            gridViewDecimalColumn16.Width = 70;
            gridViewTextBoxColumn12.FieldName = "ProductName";
            gridViewTextBoxColumn12.HeaderText = "نام محصول";
            gridViewTextBoxColumn12.IsAutoGenerated = true;
            gridViewTextBoxColumn12.Name = "ProductName";
            gridViewTextBoxColumn12.Width = 140;
            gridViewDecimalColumn17.DataType = typeof(long);
            gridViewDecimalColumn17.FieldName = "CategoryId";
            gridViewDecimalColumn17.HeaderText = "آیدی گروه کالا";
            gridViewDecimalColumn17.IsAutoGenerated = true;
            gridViewDecimalColumn17.Name = "CategoryId";
            gridViewDecimalColumn17.Width = 110;
            gridViewDecimalColumn18.DataType = typeof(long);
            gridViewDecimalColumn18.FieldName = "SupplierId";
            gridViewDecimalColumn18.HeaderText = "آیدی تامین کننده";
            gridViewDecimalColumn18.IsAutoGenerated = true;
            gridViewDecimalColumn18.Name = "SupplierId";
            gridViewDecimalColumn18.Width = 110;
            gridViewDecimalColumn19.FieldName = "UnitPrice";
            gridViewDecimalColumn19.HeaderText = "قیمت واحد(تومان)";
            gridViewDecimalColumn19.IsAutoGenerated = true;
            gridViewDecimalColumn19.Name = "UnitPrice";
            gridViewDecimalColumn19.Width = 120;
            gridViewDecimalColumn20.FieldName = "Qty";
            gridViewDecimalColumn20.HeaderText = "تعداد";
            gridViewDecimalColumn20.IsAutoGenerated = true;
            gridViewDecimalColumn20.Name = "Qty";
            gridViewDecimalColumn20.Width = 85;
            gridViewDecimalColumn21.FieldName = "Discount";
            gridViewDecimalColumn21.HeaderText = "تخفیف %";
            gridViewDecimalColumn21.IsAutoGenerated = true;
            gridViewDecimalColumn21.Name = "Discount";
            gridViewDecimalColumn21.Width = 80;
            this.RgvProducts.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn16,
            gridViewTextBoxColumn12,
            gridViewDecimalColumn17,
            gridViewDecimalColumn18,
            gridViewDecimalColumn19,
            gridViewDecimalColumn20,
            gridViewDecimalColumn21});
            this.RgvProducts.MasterTemplate.ViewDefinition = tableViewDefinition6;
            this.RgvProducts.Name = "RgvProducts";
            this.RgvProducts.ReadOnly = true;
            this.RgvProducts.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RgvProducts.Size = new System.Drawing.Size(729, 138);
            this.RgvProducts.TabIndex = 90;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(454, 161);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(71, 30);
            this.btnUpdate.TabIndex = 83;
            this.btnUpdate.Text = "به روز رسانی";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(531, 161);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(64, 30);
            this.btnDelete.TabIndex = 89;
            this.btnDelete.Text = "حذف";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(601, 161);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(64, 30);
            this.btnModify.TabIndex = 84;
            this.btnModify.Text = "ویرایش";
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(670, 161);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(64, 30);
            this.btnSave.TabIndex = 85;
            this.btnSave.Text = "ذخیره";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // radLabel6
            // 
            this.radLabel6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.radLabel6.Font = new System.Drawing.Font("IRANSans Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.radLabel6.Location = new System.Drawing.Point(572, 376);
            this.radLabel6.Name = "radLabel6";
            this.radLabel6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radLabel6.Size = new System.Drawing.Size(162, 24);
            this.radLabel6.TabIndex = 86;
            this.radLabel6.Text = "لیست محصولات تامین کننده";
            this.radLabel6.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // radLabel2
            // 
            this.radLabel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.radLabel2.Font = new System.Drawing.Font("IRANSans Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.radLabel2.Location = new System.Drawing.Point(613, 197);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(121, 24);
            this.radLabel2.TabIndex = 87;
            this.radLabel2.Text = "لیست تامین کننده ها";
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTitle.Font = new System.Drawing.Font("IRANSans Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblTitle.Location = new System.Drawing.Point(666, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(68, 24);
            this.lblTitle.TabIndex = 88;
            this.lblTitle.Text = "تامین کننده";
            // 
            // lblAddressWarning
            // 
            this.lblAddressWarning.Font = new System.Drawing.Font("IRANSans Light", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblAddressWarning.ForeColor = System.Drawing.Color.DarkRed;
            this.lblAddressWarning.Location = new System.Drawing.Point(50, 131);
            this.lblAddressWarning.Name = "lblAddressWarning";
            this.lblAddressWarning.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblAddressWarning.Size = new System.Drawing.Size(117, 20);
            this.lblAddressWarning.TabIndex = 94;
            this.lblAddressWarning.Text = "آدرس نمیتواند خالی باشد";
            this.lblAddressWarning.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.lblAddressWarning.Visible = false;
            // 
            // lblContactNameWarning
            // 
            this.lblContactNameWarning.Font = new System.Drawing.Font("IRANSans Light", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblContactNameWarning.ForeColor = System.Drawing.Color.DarkRed;
            this.lblContactNameWarning.Location = new System.Drawing.Point(462, 70);
            this.lblContactNameWarning.Name = "lblContactNameWarning";
            this.lblContactNameWarning.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblContactNameWarning.Size = new System.Drawing.Size(158, 20);
            this.lblContactNameWarning.TabIndex = 95;
            this.lblContactNameWarning.Text = "نام تامین کننده نمیتواند خالی باشد";
            this.lblContactNameWarning.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.lblContactNameWarning.Visible = false;
            // 
            // txtLastName
            // 
            this.txtLastName.Controls.Add(this.radTextBox2);
            this.txtLastName.Location = new System.Drawing.Point(94, 44);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtLastName.Size = new System.Drawing.Size(133, 20);
            this.txtLastName.TabIndex = 93;
            // 
            // radTextBox2
            // 
            this.radTextBox2.Location = new System.Drawing.Point(0, 0);
            this.radTextBox2.Name = "radTextBox2";
            this.radTextBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radTextBox2.Size = new System.Drawing.Size(133, 20);
            this.radTextBox2.TabIndex = 93;
            // 
            // txtContactName
            // 
            this.txtContactName.Location = new System.Drawing.Point(462, 44);
            this.txtContactName.Name = "txtContactName";
            this.txtContactName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtContactName.Size = new System.Drawing.Size(133, 20);
            this.txtContactName.TabIndex = 92;
            this.txtContactName.Validated += new System.EventHandler(this.txtContactName_Validated);
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("IRANSans Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.radLabel1.Location = new System.Drawing.Point(245, 39);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radLabel1.Size = new System.Drawing.Size(37, 24);
            this.radLabel1.TabIndex = 96;
            this.radLabel1.Text = "آدرس";
            this.radLabel1.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // radLabel3
            // 
            this.radLabel3.Font = new System.Drawing.Font("IRANSans Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.radLabel3.Location = new System.Drawing.Point(613, 39);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radLabel3.Size = new System.Drawing.Size(87, 24);
            this.radLabel3.TabIndex = 97;
            this.radLabel3.Text = "نام تامین کننده";
            this.radLabel3.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(50, 44);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.txtAddress.RootElement.StretchVertically = true;
            this.txtAddress.Size = new System.Drawing.Size(177, 77);
            this.txtAddress.TabIndex = 93;
            this.txtAddress.Validated += new System.EventHandler(this.txtAddress_Validated);
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(462, 101);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPhoneNumber.Size = new System.Drawing.Size(133, 20);
            this.txtPhoneNumber.TabIndex = 93;
            this.txtPhoneNumber.Validated += new System.EventHandler(this.txtPhoneNumber_Validated);
            // 
            // radLabel4
            // 
            this.radLabel4.Font = new System.Drawing.Font("IRANSans Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.radLabel4.Location = new System.Drawing.Point(613, 97);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radLabel4.Size = new System.Drawing.Size(66, 24);
            this.radLabel4.TabIndex = 97;
            this.radLabel4.Text = "شماره تلفن";
            this.radLabel4.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblPhoneNumberWarning
            // 
            this.lblPhoneNumberWarning.Font = new System.Drawing.Font("IRANSans Light", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblPhoneNumberWarning.ForeColor = System.Drawing.Color.DarkRed;
            this.lblPhoneNumberWarning.Location = new System.Drawing.Point(462, 127);
            this.lblPhoneNumberWarning.Name = "lblPhoneNumberWarning";
            this.lblPhoneNumberWarning.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPhoneNumberWarning.Size = new System.Drawing.Size(140, 20);
            this.lblPhoneNumberWarning.TabIndex = 94;
            this.lblPhoneNumberWarning.Text = "شماره تلفن نمیتواند خالی باشد";
            this.lblPhoneNumberWarning.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.lblPhoneNumberWarning.Visible = false;
            // 
            // FrmSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(807, 788);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.radLabel4);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.lblPhoneNumberWarning);
            this.Controls.Add(this.lblAddressWarning);
            this.Controls.Add(this.lblContactNameWarning);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtContactName);
            this.Controls.Add(this.RgvSuppliers);
            this.Controls.Add(this.RgvProducts);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.radLabel6);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSupplier";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "FrmSupplier";
            ((System.ComponentModel.ISupportInitialize)(this.RgvSuppliers.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RgvSuppliers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RgvProducts.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RgvProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnModify)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblAddressWarning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblContactNameWarning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLastName)).EndInit();
            this.txtLastName.ResumeLayout(false);
            this.txtLastName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContactName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhoneNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblPhoneNumberWarning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView RgvSuppliers;
        private Telerik.WinControls.UI.RadGridView RgvProducts;
        private Telerik.WinControls.UI.RadButton btnUpdate;
        private Telerik.WinControls.UI.RadButton btnDelete;
        private Telerik.WinControls.UI.RadButton btnModify;
        private Telerik.WinControls.UI.RadButton btnSave;
        private Telerik.WinControls.UI.RadLabel radLabel6;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel lblTitle;
        private Telerik.WinControls.UI.RadLabel lblAddressWarning;
        private Telerik.WinControls.UI.RadLabel lblContactNameWarning;
        private Telerik.WinControls.UI.RadTextBox txtLastName;
        private Telerik.WinControls.UI.RadTextBox txtContactName;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadTextBox radTextBox2;
        private Telerik.WinControls.UI.RadTextBox txtAddress;
        private Telerik.WinControls.UI.RadTextBox txtPhoneNumber;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadLabel lblPhoneNumberWarning;
        private System.Windows.Forms.BindingSource supplierBindingSource;
    }
}
