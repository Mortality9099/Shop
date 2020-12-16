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
    public partial class FrmOrders : Telerik.WinControls.UI.RadForm
    {
        public OrderViewModel OrderViewModel { get; set; }
        public OrderDetailsViewModel OrderDetailsViewModel { get; set; }

        public FrmOrders()
        {
            InitializeComponent();

            OrderViewModel = new OrderViewModel();
            OrderDetailsViewModel = new OrderDetailsViewModel();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            RgvOrders.DataSource = OrderViewModel.GetAllEntities();
        }

        private void UpdateOrderGridView()
        {
            RgvOrders.DataSource = OrderViewModel.GetAllEntities();
        }

        private void UpdateOrderDetails()
        {
            RgvOrderDetails.DataSource = OrderDetailsViewModel.GetAllEntities(SelectedOrder(RgvOrders.CurrentRow));
        }

        private Order SelectedOrder(GridViewRowInfo currentRow)
        {
            long orderId = (long) currentRow.Cells["OrderId"].Value;
            return OrderViewModel.GetEntity(orderId);
        }

        private void RgvOrders_CurrentRowChanged(object sender, Telerik.WinControls.UI.CurrentRowChangedEventArgs e)
        {
            UpdateOrderDetails();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (RgvOrders.CurrentRow != null)
            {
                DialogResult dialogResult = MessageBox.Show("آیا میخواهید این فاکتور را حذف کنید؟", "هشدار", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.OK)
                {
                    OrderViewModel.RemoveEntity(SelectedOrder(RgvOrders.CurrentRow));
                    MessageBox.Show("فاکتور با موفقیت حذف شد");
                    UpdateOrderGridView();
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateOrderGridView();
        }
    }
}
