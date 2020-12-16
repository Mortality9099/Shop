namespace SqlShop.View
{
    partial class MainForm
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
            this.btnSellProducts = new Telerik.WinControls.UI.RadButton();
            this.btnSupplier = new Telerik.WinControls.UI.RadButton();
            this.btnCustomer = new Telerik.WinControls.UI.RadButton();
            this.btnCategory = new Telerik.WinControls.UI.RadButton();
            this.btnProducts = new Telerik.WinControls.UI.RadButton();
            this.btnOrders = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.btnSellProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSupplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSellProducts
            // 
            this.btnSellProducts.Location = new System.Drawing.Point(35, 374);
            this.btnSellProducts.Name = "btnSellProducts";
            this.btnSellProducts.Size = new System.Drawing.Size(114, 35);
            this.btnSellProducts.TabIndex = 5;
            this.btnSellProducts.Text = "فروش محصول";
            this.btnSellProducts.Click += new System.EventHandler(this.btnSellProducts_Click);
            // 
            // btnSupplier
            // 
            this.btnSupplier.Location = new System.Drawing.Point(35, 269);
            this.btnSupplier.Name = "btnSupplier";
            this.btnSupplier.Size = new System.Drawing.Size(114, 35);
            this.btnSupplier.TabIndex = 3;
            this.btnSupplier.Text = "تامین کننده";
            this.btnSupplier.Click += new System.EventHandler(this.btnSupplier_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.Location = new System.Drawing.Point(35, 215);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(114, 35);
            this.btnCustomer.TabIndex = 2;
            this.btnCustomer.Text = "مشتری ";
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnCategory
            // 
            this.btnCategory.Location = new System.Drawing.Point(35, 158);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(114, 35);
            this.btnCategory.TabIndex = 1;
            this.btnCategory.Text = "گروه کالا";
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.Font = new System.Drawing.Font("IRANSansWeb", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnProducts.Location = new System.Drawing.Point(35, 101);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(114, 35);
            this.btnProducts.TabIndex = 0;
            this.btnProducts.Text = "کالا";
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // btnOrders
            // 
            this.btnOrders.Location = new System.Drawing.Point(35, 321);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(114, 35);
            this.btnOrders.TabIndex = 4;
            this.btnOrders.Text = "فاکتور های فروش";
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1014, 591);
            this.Controls.Add(this.btnOrders);
            this.Controls.Add(this.btnSupplier);
            this.Controls.Add(this.btnCustomer);
            this.Controls.Add(this.btnCategory);
            this.Controls.Add(this.btnSellProducts);
            this.Controls.Add(this.btnProducts);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "فروشگاه";
            ((System.ComponentModel.ISupportInitialize)(this.btnSellProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSupplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Telerik.WinControls.UI.RadButton btnSellProducts;
        private Telerik.WinControls.UI.RadButton btnSupplier;
        private Telerik.WinControls.UI.RadButton btnCustomer;
        private Telerik.WinControls.UI.RadButton btnCategory;
        private Telerik.WinControls.UI.RadButton btnProducts;
        private Telerik.WinControls.UI.RadButton btnOrders;
    }
}
