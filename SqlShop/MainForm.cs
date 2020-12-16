using System;
using System.Drawing;
using System.Windows.Forms;
using SqlShop.View.Forms;
using Telerik.WinControls.UI;

namespace SqlShop.View
{
    public partial class MainForm : RadForm
    {
        public RadForm CustomerForm { get; set; }
        public RadForm ProductForm { get; set; }
        public RadForm CategoryForm { get; set; }
        public RadForm SellProductForm { get; set; }
        public RadForm OrderForm { get; set; }
        public RadForm SupplierForm { get; set; }

        public MainForm()
        {
            InitializeComponent();

            CustomerForm = new FrmCustomer(); 
            ProductForm = new FrmProduct();
            CategoryForm = new FrmCategory();
            SellProductForm = new FrmSellProduct();
            OrderForm = new FrmOrders();
            SupplierForm = new FrmSupplier();
        }

        #region -----  Button Click Events  -----

        private void btnProducts_Click(object sender, EventArgs e)
        {
            HideOtherForm("FrmProduct");
            if (IsAlreadyOpened("FrmProduct"))
                return;
            ProductForm.MdiParent = this;
            ProductForm.Show();
            ProductForm.Location = new Point(150, 20);

        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            HideOtherForm("FrmCustomer");
            if (IsAlreadyOpened("FrmCustomer"))
                return;
            CustomerForm.MdiParent = this;
            CustomerForm.Show();
            CustomerForm.Location = new Point(200, 20);
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            HideOtherForm("FrmSupplier");
            if (IsAlreadyOpened("FrmSupplier"))
                return;
            SupplierForm.MdiParent = this;
            SupplierForm.Show();
            SupplierForm.Location = new Point(200, 20);
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            HideOtherForm("FrmCategory");
            if (IsAlreadyOpened("FrmCategory"))
                return;
            CategoryForm.MdiParent = this;
            CategoryForm.Show();
            CategoryForm.Location = new Point(200, 20);
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            HideOtherForm("FrmOrders");
            if (IsAlreadyOpened("FrmOrders"))
                return;
            OrderForm.MdiParent = this;
            OrderForm.Show();
            OrderForm.Location = new Point(200, 20);
        }

        private void btnSellProducts_Click(object sender, EventArgs e)
        {
            HideOtherForm("FrmSellProduct");
            if (IsAlreadyOpened("FrmSellProduct"))
                return;
            SellProductForm.MdiParent = this;
            SellProductForm.Show();
            SellProductForm.Location = new Point(200, 20);
        }

        #endregion

        #region -----  Methods  -----

        private bool IsAlreadyOpened(string formName)
        {
            FormCollection Forms = Application.OpenForms;

            foreach (RadForm form in Forms)
            {
                if (form.Name.Equals(formName))
                    return true;
            }
            return false;
        }

        private void HideOtherForm(string formName)
        {
            FormCollection Forms = Application.OpenForms;

            foreach (RadForm Form in Forms)
            {
                if (Form.Name.Equals(formName) || Form.Name.Equals(this.Name))
                    continue;

                Form.Hide();
                break;
            }
        }

        #endregion
    }
}
