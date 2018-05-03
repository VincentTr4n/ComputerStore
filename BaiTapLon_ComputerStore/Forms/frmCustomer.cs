using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;
using MyObject;
using DAOClassesLibrary;
using BaiTapLon_ComputerStore.Reports;

namespace BaiTapLon_ComputerStore
{
	public partial class frmCustomer : MetroFramework.Forms.MetroForm
	{
		CustomerDAO cd = new CustomerDAO();
		public DataRow dataRow { get; set; }
		public frmCustomer()
		{
			InitializeComponent();
		}

		private void frmCustomer_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'showCustomers.Customers' table. You can move, or remove it, as needed.
			this.customersTableAdapter.Fill(this.showCustomers.Customers);
			//gridControl1.DataSource = cd.getTable();
		}

		private void sbtCancel_Click(object sender, EventArgs e)
		{
			try
			{
				customersBindingSource.EndEdit();
				customersTableAdapter.Update(showCustomers);
			}
			catch
			{
				//DevExpress.XtraEditors.XtraMessageBox.Show("Error!");
				//return;
			}
			this.Close();
		}

		private void sbtNew_Click(object sender, EventArgs e)
		{
			MainView.AddNewRow();
		}

		private void sbtApply_Click(object sender, EventArgs e)
		{
			DataRow row;
			for (int i = 0; i < MainView.RowCount - 1; i++)
			{
				row = MainView.GetDataRow(i);
				if (row.RowState == DataRowState.Added)
				{
					Customer cus = getCustomerFromRow(row, i);
					if (cus == null) return;
					if (!cd.AddObject(cus)) { DevExpress.XtraEditors.XtraMessageBox.Show("Error"); MainView.FocusedRowHandle = i; return; }
					else dataRow = row;
				}
				if (row.RowState == DataRowState.Modified)
				{
					Customer cus = getCustomerFromRow(row, i);
					if (cus == null) return;
					if (!cd.UpdateObject(cus)) { DevExpress.XtraEditors.XtraMessageBox.Show("Error"); MainView.FocusedRowHandle = i; return; }
				}
			}
			//customersBindingSource.EndEdit();
			//customersTableAdapter.Update(showCustomers);
		}

		private void sbtDelete_Click(object sender, EventArgs e)
		{
			if (MainView.GetSelectedRows().Length > 0)
			{
				string id = MainView.GetDataRow(MainView.GetSelectedRows()[0])[0].ToString();
				if (cd.DeleteObject(id)) MainView.DeleteSelectedRows();
			}
			else DevExpress.XtraEditors.XtraMessageBox.Show("Please select a row before delete!");

		}

		private void MainView_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
		{
			
		}

		private void MainView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
		{
			if (e.Column.FieldName == "Phone")
			{
				try
				{
					long a = long.Parse(e.Value.ToString());
				}
				catch
				{
					DevExpress.XtraEditors.XtraMessageBox.Show("Error");
				}
			}
		}
		Customer getCustomerFromRow(DataRow row,int i)
		{
			for (int j = 0; j < MainView.Columns.Count; j++)
				if (row.IsNull(j)) { DevExpress.XtraEditors.XtraMessageBox.Show("Error"); MainView.FocusedRowHandle = i; return null; }
			Customer cus = new Customer
			{
				ID = row[0].ToString(),
				Name = row[1].ToString(),
				phoneNumber = row[2].ToString(),
				Address = row[3].ToString(),
				email = row[4].ToString(),
			};
			return cus;
		}

		private void frmCustomer_FormClosing(object sender, FormClosingEventArgs e)
		{
			
		}
		//
		// Print Customer

		private void simpleButton1_Click(object sender, EventArgs e)
		{
			frmPrint frm = new frmPrint();
			frm.PrintTopPurchase();
			frm.ShowDialog(this);
		}

		private void gridControl1_Click(object sender, EventArgs e)
		{

		}
	}
}
