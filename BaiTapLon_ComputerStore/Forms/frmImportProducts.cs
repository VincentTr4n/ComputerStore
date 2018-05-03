using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using BaiTapLon_ComputerStore.Reports;
using MyClassesLibrary;
using DAOClassesLibrary;
using MyObject;

namespace BaiTapLon_ComputerStore
{
	public partial class frmImportProducts : MaterialSkin.Controls.MaterialForm
	{
		EmployeeDAO ec = new EmployeeDAO();
		ProductDAO pc = new ProductDAO();
		PurchaseBillDAO pd = new PurchaseBillDAO();
		PurchaseDetailDAO pDetail = new PurchaseDetailDAO();
		TypeDAO td = new TypeDAO();

		public frmImportProducts()
		{
			InitializeComponent();
			var skin = MaterialSkinManager.Instance;
			skin.AddFormToManage(this);
			skin.Theme = MaterialSkinManager.Themes.DARK;
			skin.ColorScheme = new ColorScheme(Primary.Green600, Primary.BlueGrey900, Primary.BlueGrey600, Accent.Orange700, TextShade.WHITE);
		}

		private void frmImportProducts_Load(object sender, EventArgs e)
		{

			//set list employtee
			cbEmployee.Properties.DataSource = ec.getTable();
			cbEmployee.Properties.DisplayMember = "Employee Name";
			cbEmployee.Properties.ValueMember = "Employee ID";
			//
			//Set list product
			foreach (Products p in pc.getList())
			{
				cbProductID.Properties.Items.Add(p.productID);
			}
			foreach (PurchaseBill bill in pd.getList())
				txPurchaseID.Properties.Items.Add(bill.purchaseID);
			gridControl1.DataSource = null;

			txPrice.Text = txTotal.Text = "0";
			btPrint.Enabled = false;

			MainView.AddNewRow();
		}
		//
		//Update Bill ID
		private void sbtNewBill_Click(object sender, EventArgs e)
		{
			purchaseDate.DateTime = DateTime.Now;
			//txPurchaseID.Properties.Items.Add(purchaseDate.DateTime.ToString("yyyyMMdd") + "/" + pd.createID(purchaseDate.DateTime.ToString("yyyy-MM-dd")));
			txPurchaseID.Text = purchaseDate.DateTime.ToString("yyyyMMdd") + "/" + pd.createID(purchaseDate.DateTime.ToString("yyyy-MM-dd"));
			cbProductID.Text = txName.Text = txPrice.Text = txQuantily.Text = cbEmployee.Text = null ;
			gridControl1.DataSource = null;
			txTotal.Text = "0";
		}
		// 
		//Select Name
		private void cbProductID_SelectedValueChanged(object sender, EventArgs e)
		{
			Products p = pc.getObject(cbProductID.Text);
			txName.Text = p.productName;
			txType.Text = td.getName(cbProductID.Text);
			txQuantily.Text = "1";
			txPrice.Text = p.purchasePrice.ToString();
			sbtAdd.Enabled = true;
		}
		//
		//Set format money to text 
		private void txPrice_TextChanged(object sender, EventArgs e)
		{
			if (!String.IsNullOrEmpty(txPrice.Text))
				slbPrice.Text = String.Format(CultureInfo.InvariantCulture, "{0:N0}", long.Parse(txPrice.Text)) + " VND";
			else slbPrice.Text = "0 VND";
		}
		//
		//Onley accept number
		private void txPrice_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsNumber(e.KeyChar) && e.KeyChar != '\b') e.Handled = true;
		}
		//
		//Import product into Bill Detail
		private void sbtAdd_Click(object sender, EventArgs e)
		{
			if(String.IsNullOrEmpty(txPurchaseID.Text))
			{
				MessageBox.Show("Please enter a Bill ID!!", "Warring!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txPurchaseID.Focus();
				return;
			}
			if (String.IsNullOrEmpty(cbEmployee.Text))
			{
				MessageBox.Show("Please choose a Employee!!", "Warring!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				cbEmployee.Focus();
				return;
			}
			//
			//Check Product ID
			if (String.IsNullOrEmpty(cbProductID.Text))
			{
				MessageBox.Show("Please chose a Product ID!!", "Warring!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				cbProductID.Focus();
				return;
			}
			//
			//Check purchase price
			if (String.IsNullOrEmpty(txPrice.Text))
			{
				MessageBox.Show("Please enter price!!", "Warring!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txPrice.Focus();
				return;
			}
			if (cbEmployee.EditValue == null)
			{
				MessageBox.Show("Please choose a employee!!", "Warring!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				cbEmployee.Focus();
				return;

			}
			//
			//If bill ID not exists then add new bill
			if (!pd.checkID(txPurchaseID.Text))
			{
				PurchaseBill bill = new PurchaseBill();
				bill.purchaseID = txPurchaseID.Text;
				Employee emp = ec.getObject(cbEmployee.EditValue.ToString());
				bill.employee = emp;
				bill.purchaseDate = purchaseDate.DateTime;
				bill.totalPrice = long.Parse(txTotal.Text);
				pd.AddObject(bill);
				txPurchaseID.Properties.Items.Add(txPurchaseID.Text);
			}
			//
			//import product into bill detail
			PurchaseBillDetail p = new PurchaseBillDetail();
			p.bill = pd.getObject(txPurchaseID.Text);
			p.product = pc.getObject(cbProductID.Text);
			p.quantily = Convert.ToInt16(txQuantily.Text);
			p.price = long.Parse(txPrice.Text);
			if (!pDetail.AddObject(p)) MessageBox.Show("Check Information again!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			//
			//Load grid control again
			gridControl1.DataSource = pDetail.getTable(txPurchaseID.Text);
			txTotal.Text = pd.getTotalMoney(txPurchaseID.Text);
			//cbProductID.Text = txName.Text = txPrice.Text = txQuantily.Text = "";
			sbtAdd.Enabled = false;
		}
		//
		// Bill
		private void txPurchaseID_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				gridControl1.DataSource = pDetail.getTable(txPurchaseID.SelectedText);
				var bill = pd.getObject(txPurchaseID.SelectedText);
				purchaseDate.DateTime = bill.purchaseDate;
				cbEmployee.Text = ec.getObject(bill.employee.Id).Name;
				txTotal.Text = bill.totalPrice.ToString();
			}
			catch { purchaseDate.DateTime = DateTime.Now; }
			sbtAdd.Enabled = true;
			btPrint.Enabled = !String.IsNullOrEmpty(txPurchaseID.Text);
		}
		//
		//Update
		private void sbtUpdate_Click(object sender, EventArgs e)
		{
			DataRow row;
			if (MainView.RowCount == 1)
			{
				row = MainView.GetDataRow(0);
				updateGridControl(row, 0);
			}
			for (int i = 0; i < MainView.RowCount; i++)
			{
				row = MainView.GetDataRow(i);
				if (row.RowState == DataRowState.Modified)
				{
					updateGridControl(row, i);
				}
			}
			var bill = pd.getObject(txPurchaseID.SelectedText);
			txTotal.Text = bill.totalPrice.ToString();
			MessageBox.Show("Update successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
		//
		//Delete
		private void sbtDelete_Click(object sender, EventArgs e)
		{
			if (MainView.GetSelectedRows().Length == 0) MessageBox.Show("Please select a row before delete!", "Warring!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			else
			{
				var row = MainView.GetDataRow(MainView.GetSelectedRows()[0]);
				if (MessageBox.Show("Are you sure delete this record?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
					if (pDetail.DeleteObject(row[2].ToString(), row[0].ToString()))
					{
						MainView.DeleteSelectedRows();
						txTotal.Text = pd.getTotalMoney(txPurchaseID.Text);
						MessageBox.Show("Delete successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					else MessageBox.Show("Check information again!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		//
		//Update grid control
		void updateGridControl(DataRow row, int index)
		{
			PurchaseBillDetail detail = new PurchaseBillDetail();
			detail.product = new ProductDAO().getObject(row[0].ToString());
			detail.bill = new PurchaseBillDAO().getObject(row[2].ToString());
			detail.quantily = Convert.ToInt16(row[3].ToString());
			detail.price = long.Parse(row[4].ToString());
			MainView.SetRowCellValue(index, "Total", (Convert.ToInt16(row[3].ToString()) * long.Parse(row[4].ToString())).ToString());
			if (!pDetail.UpdateObject(detail))
			{
				MessageBox.Show("Check information again!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				MainView.SelectRow(index);
				return;
			}
			
		}
		//
		//Add new product
		private void mbtNewProduct_Click(object sender, EventArgs e)
		{
			frmAddProductcs frm = new frmAddProductcs();
			frm.ShowDialog();
			frm.Owner = this;
			if (frm.check)
			{
				cbProductID.Properties.Items.Add(frm.productID);
			}
			
		}
		//
		//Eixt
		private void sbtExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		//
		//Delete BIll
		private void sbtDeleteBill_Click(object sender, EventArgs e)
		{
			if (!String.IsNullOrEmpty(txPurchaseID.Text))
			{
				if(MessageBox.Show("Are you sure remove this bill?", "Warring!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					deleteBill();
					pd.DeleteObject(txPurchaseID.Text);
					txPurchaseID.Properties.Items.Remove(txPurchaseID.Text);
					txPurchaseID.SelectedIndex = 0;
				}
			}
			else
			{
				MessageBox.Show("Please choose one bill", "Waring!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}
		private void deleteBill()
		{
			for(int i = 0; i < MainView.RowCount; i++)
			{
				string id = MainView.GetDataRow(i)[0].ToString();
				string bill = txPurchaseID.Text;
				pDetail.DeleteObject(bill,id);
			}
		}
		private void MainView_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
		{
			DataRow row = MainView.GetDataRow(e.RowHandle);
			cbProductID.EditValue = row[0].ToString();
		}

		private void MainView_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
		{
			DataRow row = MainView.GetDataRow(e.RowHandle);
			cbProductID.EditValue = row[0].ToString();
		}

		private void txTotal_TextChanged(object sender, EventArgs e)
		{
			slbTotal.Text = MyAction.FormatMoney(txTotal.Text);
		}

		private void btPrint_Click(object sender, EventArgs e)
		{
			using (frmPrint frm = new frmPrint())
			{
				splashScreenManager1.ShowWaitForm();
				frm.PrintPurchaseBill(txPurchaseID.Text, cbEmployee.Text, purchaseDate.DateTime);
				splashScreenManager1.CloseWaitForm();
				frm.ShowDialog();
				frm.Owner = this;
				
			}
		}

	}
}

