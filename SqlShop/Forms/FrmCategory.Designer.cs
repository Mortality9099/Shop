namespace SqlShop.View.Forms
{
    partial class FrmCategory
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn16 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn17 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn18 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn19 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn20 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition5 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn21 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition6 = new Telerik.WinControls.UI.TableViewDefinition();
            this.btnUpdate = new Telerik.WinControls.UI.RadButton();
            this.btnDelete = new Telerik.WinControls.UI.RadButton();
            this.btnModify = new Telerik.WinControls.UI.RadButton();
            this.btnSave = new Telerik.WinControls.UI.RadButton();
            this.radLabel6 = new Telerik.WinControls.UI.RadLabel();
            this.lblTitle = new Telerik.WinControls.UI.RadLabel();
            this.txtCategoryName = new Telerik.WinControls.UI.RadTextBox();
            this.RgvProducts = new Telerik.WinControls.UI.RadGridView();
            this.RgvCategories = new Telerik.WinControls.UI.RadGridView();
            this.lblCategoryNameWarning = new Telerik.WinControls.UI.RadLabel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.btnUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnModify)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCategoryName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RgvProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RgvProducts.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RgvCategories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RgvCategories.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblCategoryNameWarning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(457, 165);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(71, 30);
            this.btnUpdate.TabIndex = 58;
            this.btnUpdate.Text = "به روز رسانی";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(534, 165);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(64, 30);
            this.btnDelete.TabIndex = 64;
            this.btnDelete.Text = "حذف";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(604, 165);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(64, 30);
            this.btnModify.TabIndex = 59;
            this.btnModify.Text = "ویرایش";
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(674, 165);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(64, 30);
            this.btnSave.TabIndex = 60;
            this.btnSave.Text = "ذخیره";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // radLabel6
            // 
            this.radLabel6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.radLabel6.Font = new System.Drawing.Font("IRANSans Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.radLabel6.Location = new System.Drawing.Point(597, 202);
            this.radLabel6.Name = "radLabel6";
            this.radLabel6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radLabel6.Size = new System.Drawing.Size(144, 24);
            this.radLabel6.TabIndex = 61;
            this.radLabel6.Text = "لیست محصولات گروه کالا";
            this.radLabel6.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTitle.Font = new System.Drawing.Font("IRANSans Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblTitle.Location = new System.Drawing.Point(654, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(51, 24);
            this.lblTitle.TabIndex = 62;
            this.lblTitle.Text = "گروه کالا";
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Location = new System.Drawing.Point(464, 72);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCategoryName.Size = new System.Drawing.Size(156, 20);
            this.txtCategoryName.TabIndex = 57;
            this.txtCategoryName.Validated += new System.EventHandler(this.txtCategoryName_Validated);
            // 
            // RgvProducts
            // 
            this.RgvProducts.Location = new System.Drawing.Point(12, 232);
            // 
            // 
            // 
            this.RgvProducts.MasterTemplate.AllowAddNewRow = false;
            this.RgvProducts.MasterTemplate.AllowDragToGroup = false;
            gridViewDecimalColumn15.DataType = typeof(long);
            gridViewDecimalColumn15.FieldName = "ProductId";
            gridViewDecimalColumn15.HeaderText = "آیدی";
            gridViewDecimalColumn15.IsAutoGenerated = true;
            gridViewDecimalColumn15.Name = "ProductId";
            gridViewDecimalColumn15.Width = 70;
            gridViewTextBoxColumn5.FieldName = "ProductName";
            gridViewTextBoxColumn5.HeaderText = "نام محصول";
            gridViewTextBoxColumn5.IsAutoGenerated = true;
            gridViewTextBoxColumn5.Name = "ProductName";
            gridViewTextBoxColumn5.Width = 140;
            gridViewDecimalColumn16.DataType = typeof(long);
            gridViewDecimalColumn16.FieldName = "CategoryId";
            gridViewDecimalColumn16.HeaderText = "آیدی گروه کالا";
            gridViewDecimalColumn16.IsAutoGenerated = true;
            gridViewDecimalColumn16.Name = "CategoryId";
            gridViewDecimalColumn16.Width = 110;
            gridViewDecimalColumn17.DataType = typeof(long);
            gridViewDecimalColumn17.FieldName = "SupplierId";
            gridViewDecimalColumn17.HeaderText = "آیدی تامین کننده";
            gridViewDecimalColumn17.IsAutoGenerated = true;
            gridViewDecimalColumn17.Name = "SupplierId";
            gridViewDecimalColumn17.Width = 110;
            gridViewDecimalColumn18.FieldName = "UnitPrice";
            gridViewDecimalColumn18.HeaderText = "قیمت واحد(تومان)";
            gridViewDecimalColumn18.IsAutoGenerated = true;
            gridViewDecimalColumn18.Name = "UnitPrice";
            gridViewDecimalColumn18.Width = 120;
            gridViewDecimalColumn19.FieldName = "Qty";
            gridViewDecimalColumn19.HeaderText = "تعداد";
            gridViewDecimalColumn19.IsAutoGenerated = true;
            gridViewDecimalColumn19.Name = "Qty";
            gridViewDecimalColumn19.Width = 85;
            gridViewDecimalColumn20.FieldName = "Discount";
            gridViewDecimalColumn20.HeaderText = "تخفیف %";
            gridViewDecimalColumn20.IsAutoGenerated = true;
            gridViewDecimalColumn20.Name = "Discount";
            gridViewDecimalColumn20.Width = 80;
            this.RgvProducts.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn15,
            gridViewTextBoxColumn5,
            gridViewDecimalColumn16,
            gridViewDecimalColumn17,
            gridViewDecimalColumn18,
            gridViewDecimalColumn19,
            gridViewDecimalColumn20});
            this.RgvProducts.MasterTemplate.DataSource = this.productBindingSource;
            this.RgvProducts.MasterTemplate.ViewDefinition = tableViewDefinition5;
            this.RgvProducts.Name = "RgvProducts";
            this.RgvProducts.ReadOnly = true;
            this.RgvProducts.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RgvProducts.Size = new System.Drawing.Size(729, 211);
            this.RgvProducts.TabIndex = 78;
            // 
            // RgvCategories
            // 
            this.RgvCategories.Location = new System.Drawing.Point(12, 42);
            // 
            // 
            // 
            this.RgvCategories.MasterTemplate.AllowAddNewRow = false;
            this.RgvCategories.MasterTemplate.AllowColumnReorder = false;
            this.RgvCategories.MasterTemplate.AllowDragToGroup = false;
            gridViewDecimalColumn21.DataType = typeof(long);
            gridViewDecimalColumn21.FieldName = "CategoryId";
            gridViewDecimalColumn21.HeaderText = "آیدی گروه کالا";
            gridViewDecimalColumn21.IsAutoGenerated = true;
            gridViewDecimalColumn21.Name = "CategoryId";
            gridViewDecimalColumn21.Width = 100;
            gridViewTextBoxColumn6.FieldName = "CategoryName";
            gridViewTextBoxColumn6.HeaderText = "نام گروه کالا";
            gridViewTextBoxColumn6.IsAutoGenerated = true;
            gridViewTextBoxColumn6.Name = "CategoryName";
            gridViewTextBoxColumn6.Width = 180;
            this.RgvCategories.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn21,
            gridViewTextBoxColumn6});
            this.RgvCategories.MasterTemplate.DataSource = this.categoryBindingSource;
            this.RgvCategories.MasterTemplate.ViewDefinition = tableViewDefinition6;
            this.RgvCategories.Name = "RgvCategories";
            this.RgvCategories.ReadOnly = true;
            this.RgvCategories.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RgvCategories.Size = new System.Drawing.Size(345, 175);
            this.RgvCategories.TabIndex = 79;
            this.RgvCategories.CurrentRowChanged += new Telerik.WinControls.UI.CurrentRowChangedEventHandler(this.RgvCategories_CurrentRowChanged);
            // 
            // lblCategoryNameWarning
            // 
            this.lblCategoryNameWarning.Font = new System.Drawing.Font("IRANSans Light", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblCategoryNameWarning.ForeColor = System.Drawing.Color.DarkRed;
            this.lblCategoryNameWarning.Location = new System.Drawing.Point(469, 103);
            this.lblCategoryNameWarning.Name = "lblCategoryNameWarning";
            this.lblCategoryNameWarning.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblCategoryNameWarning.Size = new System.Drawing.Size(144, 20);
            this.lblCategoryNameWarning.TabIndex = 80;
            this.lblCategoryNameWarning.Text = "نام گروه کالا نمیتواند خالی باشد";
            this.lblCategoryNameWarning.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.lblCategoryNameWarning.Visible = false;
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("IRANSans Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.radLabel1.Location = new System.Drawing.Point(635, 67);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radLabel1.Size = new System.Drawing.Size(70, 24);
            this.radLabel1.TabIndex = 81;
            this.radLabel1.Text = "نام گروه کالا";
            this.radLabel1.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // radLabel2
            // 
            this.radLabel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.radLabel2.Font = new System.Drawing.Font("IRANSans Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.radLabel2.Location = new System.Drawing.Point(270, 12);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(87, 24);
            this.radLabel2.TabIndex = 62;
            this.radLabel2.Text = "لیست گروه کالا";
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataSource = typeof(SqlShop.DayaLayer.Models.Entity.Category);
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(SqlShop.DayaLayer.Models.Entity.Product);
            // 
            // FrmCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(763, 637);
            this.Controls.Add(this.lblCategoryNameWarning);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.RgvCategories);
            this.Controls.Add(this.RgvProducts);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.radLabel6);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtCategoryName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCategory";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "FrmCategory";
            ((System.ComponentModel.ISupportInitialize)(this.btnUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnModify)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCategoryName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RgvProducts.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RgvProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RgvCategories.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RgvCategories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblCategoryNameWarning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadButton btnUpdate;
        private Telerik.WinControls.UI.RadButton btnDelete;
        private Telerik.WinControls.UI.RadButton btnModify;
        private Telerik.WinControls.UI.RadButton btnSave;
        private Telerik.WinControls.UI.RadLabel radLabel6;
        private Telerik.WinControls.UI.RadLabel lblTitle;
        private Telerik.WinControls.UI.RadTextBox txtCategoryName;
        private Telerik.WinControls.UI.RadGridView RgvProducts;
        private Telerik.WinControls.UI.RadGridView RgvCategories;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private System.Windows.Forms.BindingSource productBindingSource;
        private Telerik.WinControls.UI.RadLabel lblCategoryNameWarning;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
    }
}
