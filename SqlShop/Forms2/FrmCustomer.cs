using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SqlShop.ModelView.DTO;
using SqlShop.DayaLayer.Models.Entity;
using Telerik.WinControls.UI;

namespace SqlShop.Forms
{
    public partial class FrmCustomer : UserControl
    {
        public CustomerViewModel CustomerViewModel { get; set; }

        private string[] ColumnNames = new string[] { "آیدی", "نام مشتری", "نام خانوادگی مشتری",
            "شماره تلفن", "ایمیل", "آدرس" };

        public FrmCustomer()
        {
            InitializeComponent();

            CustomerViewModel = new CustomerViewModel();
            RvgCustomers.ColumnCount = ColumnNames.Length;
            SelectData();
        }

        private void FrmCustomer_Load(object sender, EventArgs e)
        {
            
        }

        private void SelectData()
        {
            RvgCustomers.RowCount = CustomerViewModel.GetAllEntities().Count;
        }

        private void RvgCustomers_CellValueNeeded(object sender, Telerik.WinControls.UI.VirtualGridCellValueNeededEventArgs e)
        {
            if (e.ColumnIndex < 0) return;
            if (e.RowIndex == RadVirtualGrid.HeaderRowIndex)
            {
                e.Value = ColumnNames[e.ColumnIndex];
            }
            if (e.RowIndex >= 0 && e.RowIndex < CustomerViewModel.GetAllEntities().Count)
            {
                e.Value = ((List<Customer>)CustomerViewModel.GetAllEntities())[e.RowIndex][e.ColumnIndex];
            }
        }

        private void RvgCustomers_CellValuePushed(object sender, VirtualGridCellValuePushedEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case 0:
                    ((List<Customer>)CustomerViewModel.GetAllEntities())[e.RowIndex].CustomerId = Convert.ToInt64(e.Value.ToString());
                    break;
                case 1:
                    ((List<Customer>)CustomerViewModel.GetAllEntities())[e.RowIndex].FirstName = e.Value.ToString();
                    break;
                case 2:
                    ((List<Customer>)CustomerViewModel.GetAllEntities())[e.RowIndex].LastName = e.Value.ToString();
                    break;
                case 3:
                    ((List<Customer>)CustomerViewModel.GetAllEntities())[e.RowIndex].PhoneNumber = e.Value.ToString();
                    break;
                case 4:
                    ((List<Customer>)CustomerViewModel.GetAllEntities())[e.RowIndex].Email = e.Value.ToString();
                    break;
                case 5:
                    ((List<Customer>)CustomerViewModel.GetAllEntities())[e.RowIndex].Address = e.Value.ToString();
                    break;
                case 6:
                    ((List<Customer>)CustomerViewModel.GetAllEntities())[e.RowIndex].IsActive = Convert.ToByte(e.Value.ToString());
                    break;
                default:
                    break;
            }
        }
    }
}
