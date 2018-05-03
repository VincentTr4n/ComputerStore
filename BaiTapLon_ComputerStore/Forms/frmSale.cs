using BaiTapLon_ComputerStore.Reports;
using DAOClassesLibrary;
using MaterialSkin;
using MyClassesLibrary;
using MyObject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapLon_ComputerStore
{
	public partial class frmSale : MaterialSkin.Controls.MaterialForm
	{
		OrderBillDAO od = new OrderBillDAO();
		EmployeeDAO ed = new EmployeeDAO();
		CustomerDAO cd = new CustomerDAO();
		ProductDAO pd = new ProductDAO();
		OrderBillDetailDAO detail = new OrderBillDetailDAO();
		PaymentDAO payment = new PaymentDAO();
		DataTable cusTable;

		public frmSale()
		{
			InitializeComponent();
			var skin = MaterialSkinManager.Instance;
			skin.AddFormToManage(this);
			skin.Theme = MaterialSkinManager.Themes.DARK;
			skin.ColorScheme = new ColorScheme(Primary.Green600, Primary.BlueGrey900, Primary.BlueGrey600, Accent.Orange700, TextShade.WHITE);
			cusTable = ed.getTable();
		}

		private void frmSale_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'showOrderDetail.show_orderDetail' table. You can move, or remove it, as needed.
			this.show_orderDetailTableAdapter.Fill(this.showOrderDetail.show_orderDetail);
			DateOrder.DateTime = DateTime.Now;

			gridControl1.DataSource = null;
			//Combo box Employees
			cbEmployee.Properties.DataSource = cusTable;
			cbEmployee.Properties.DisplayMember = "Employee Name";
			cbEmployee.Properties.ValueMember = "Employee ID";
			//
			cbCustomerID.Properties.DataSource = cd.getTable();
			cbCustomerID.Properties.DisplayMember = "Name_Customer";
			cbCustomerID.Properties.ValueMember = "ID_Customer";

			//
			//foreach (Products pro in pd.getList()) cbProductID.Properties.Items.Add(pro.productID);
			//
			//
			cbProductID.Properties.DataSource = pd.getTable(EnumShowProduct.ShowWithName);
			cbProductID.Properties.DisplayMember = "ID_Product";
			cbProductID.Properties.ValueMember = "ID_Product";
			//
			foreach (Payment p in payment.getList()) cbPayType.Properties.Items.Add(p.name);
			//
			foreach (OrderBIll bill in od.getList(DateTime.Now)) cbBillID.Properties.Items.Add(bill.orderID);
			//
			txPrice.Text = txTotal.Text = "0";
			gridControl1.DataSource = null;
			btPrint.Enabled = false;

			dateStart.DateTime = dateEnd.DateTime = DateTime.Now;

		}
		//
		//Only accept number
		private void txPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsNumber(e.KeyChar) && e.KeyChar != '\b') e.Handled = true;
		}
		//
		// New bill
		private void btNewID_Click(object sender, EventArgs e)
		{
			string id = MyAction.AutoCreateID(DateTime.Now.ToString("yyyyMMdd") + "/OB");
			while (!od.checkID(id))
			{
				id = MyAction.AutoCreateID(DateTime.Now.ToString("yyyyMMdd") + "/OB");
			}
			cbBillID.Text = id;
			//cbBillID.Properties.Items.Add(id);
			txTotal.Text = "0";
			txDiscount.Value = 0;
			DateOrder.DateTime = DateTime.Now;
			btPrint.Enabled = true;
		}

		//
		//Select Customer
		private void cbCustomerID_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (String.IsNullOrEmpty(cbCustomerID.Text))
			{
				txPhoneNumber.Text = txAddress.Text = "";
			}
			else
			{
				Customer cus = cd.getObject(cbCustomerID.EditValue.ToString());
				txPhoneNumber.Text = cus.phoneNumber.ToString();
				txAddress.Text = cus.Address;
			}
			
		}
		//
		// Choose Product ID
		private void cbProductID_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (detail.checkID(cbBillID.SelectedText, cbProductID.SelectedText) && !String.IsNullOrEmpty(cbProductID.Text))
			{
				Products pro = pd.getObject(cbProductID.Text);
				txProductName.Text = pro.productName;
				txPrice.Text = pro.productPrice.ToString();
				txProductType.Text = pro.Type.typeName;
				txQuantily.Properties.MaxValue = pro.quantily;
				txQuantily.Value = 1;
				btAdd.Enabled = true;
			}
			else
			{
				txPrice.Text = "0";
				txProductType.Text = txProductName.Text = null;
				btAdd.Enabled = false;
			}
		}
		//
		//Add
		private void btAddProduct_Click(object sender, EventArgs e)
		{
			if (AcceptText())
			{
				//
				// Add Bill
				if (od.checkID(cbBillID.Text))
				{
					OrderBIll bill = new OrderBIll();
					bill.orderID = cbBillID.Text;
					bill.customer = cd.getObject(cbCustomerID.EditValue.ToString());
					bill.employee = ed.getObject(cbEmployee.EditValue.ToString());
					bill.orderDate = DateOrder.DateTime;
					bill.payType = cbPayType.SelectedIndex;
					bill.total = long.Parse(txTotal.Text);
					od.AddObject(bill);
					cbBillID.Properties.Items.Add(cbBillID.Text);
				}
				if (String.IsNullOrEmpty(cbProductID.Text))
				{
					cbProductID.Focus();
					MessageBox.Show("Please choose a product", "Waring!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}
				//
				// Add Detail Bill
				if (!detail.checkID(cbBillID.Text, cbProductID.Text))
				{
					MessageBox.Show("ID is unavaillable,Please choose another!", "Warring", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}
				OrderBillDetail d = new OrderBillDetail();
				d.orderBill = od.getObject(cbBillID.Text);
				d.product = pd.getObject(cbProductID.Text);
				d.quantily = Convert.ToInt16(txQuantily.Text);
				d.discount = Convert.ToInt16(txDiscount.Text);
				d.price = long.Parse(txPrice.Text);
				detail.AddObject(d);
				gridControl1.DataSource = detail.getTable(cbBillID.Text);
				//
				// Update Total Money
				txTotal.Text = od.getTotalMoney(cbBillID.Text);
				txQuantily.Properties.MaxValue = 1;
			}
		}
		//
		// Exit button
		private void btExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		//
		// Format Price
		private void txPrice_TextChanged(object sender, EventArgs e)
		{
			slbPrice.Text = MyAction.FormatMoney(txPrice.Text);
		}
		//
		// Format Total Money
		private void txTotal_TextChanged(object sender, EventArgs e)
		{
			slbTotal.Text = MyAction.FormatMoney(txTotal.Text);
		}
		//
		// Set tool tip
		private void txDiscount_EditValueChanged(object sender, EventArgs e)
		{
			txDiscount.ToolTip = txDiscount.Text + "%";
		}
		//
		// Select a Bill
		private void cbBillID_EditValueChanged(object sender, EventArgs e)
		{
			OrderBIll bill = od.getObject(cbBillID.Text);
			if (bill != null)
			{
				DateOrder.DateTime = bill.orderDate;
				cbEmployee.Text = bill.employee.Name;
				cbCustomerID.Text = bill.customer.Name;
				cbPayType.SelectedIndex = bill.payType;
				gridControl1.DataSource = detail.getTable(cbBillID.Text);
				txTotal.Text = bill.total.ToString();
				btPrint.Enabled = true;
			}
			else
			{
				TextBillReset();
				btPrint.Enabled = false;
			}
		}
		//
		// Reset text Bill Infor
		void TextBillReset()
		{
			DateOrder.DateTime = DateTime.Now;
			cbEmployee.EditValue = cbCustomerID.EditValue = cbPayType.Text = txTotal.Text = null;
			gridControl1.DataSource = null;
		}
		//
		// Reset text Prodcut Infor
		void TextProductReset()
		{
			cbProductID.Text = txQuantily.Text = txDiscount.Text = txTotal.Text = null;
		}
		//
		// Delete Bill
		private void btDeleteBill_Click(object sender, EventArgs e)
		{
			if (String.IsNullOrEmpty(cbBillID.Text))
			{
				cbBillID.Focus();
				MessageBox.Show("Please enter a bill ID", "Waring!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			if (MessageBox.Show("Are you sure delete this record?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				deleteBill();
				od.DeleteObject(cbBillID.Text);
				cbBillID.Properties.Items.RemoveAt(cbBillID.SelectedIndex);
				cbBillID.Text = null;
				TextBillReset();
				TextProductReset();
			}
		}
		private void deleteBill()
		{
			for (int i = 0; i < MainView.RowCount; i++)
				detail.DeleteObject(cbBillID.Text, MainView.GetDataRow(i)[0].ToString());
		}
		//
		// Delete row
		private void btDelete_Click(object sender, EventArgs e)
		{
			if (MainView.GetSelectedRows().Length == 0) MessageBox.Show("Please select a row before delete!", "Warring!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			else
			{
				var row = MainView.GetDataRow(MainView.GetSelectedRows()[0]);
				if (MessageBox.Show("Are you sure delete this record?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
					if (detail.DeleteObject(row[1].ToString(), row[0].ToString()))
					{
						MainView.DeleteSelectedRows();
						txTotal.Text = od.getTotalMoney(cbBillID.EditValue.ToString());
						MessageBox.Show("Delete successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					else MessageBox.Show("Check information again!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		//
		// Update row
		private void btUpdate_Click(object sender, EventArgs e)
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
			MainView.RefreshData();
		}
		//
		// Update function
		void updateGridControl(DataRow row, int index)
		{
			OrderBillDetail Odetail = new OrderBillDetail();
			Odetail.product = new ProductDAO().getObject(row[0].ToString());
			Odetail.orderBill = new OrderBillDAO().getObject(row[1].ToString());
			Odetail.quantily = Convert.ToInt16(row[3].ToString());
			Odetail.price = long.Parse(row[5].ToString());
			Odetail.discount = Convert.ToInt16(row[4].ToString());
			MainView.SetRowCellValue(index, "Total", Odetail.quantily * Odetail.price * (1 - Odetail.discount / 100));
			if (!detail.UpdateObject(Odetail))
				 MessageBox.Show("Check information again!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			var bill = od.getObject(cbBillID.Text);
			txTotal.Text = bill.total.ToString();
		}
		//
		// Check Text
		bool AcceptText()
		{
			if (String.IsNullOrEmpty(cbBillID.Text))
			{
				cbBillID.Focus();
				MessageBox.Show("Please enter a bill ID", "Waring!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}
			if (String.IsNullOrEmpty(cbCustomerID.Text))
			{
				cbCustomerID.Focus();
				MessageBox.Show("Please choose a customer", "Waring!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}
			if (String.IsNullOrEmpty(cbEmployee.Text))
			{
				cbEmployee.Focus();
				MessageBox.Show("Please choose a employee", "Waring!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}
			if (String.IsNullOrEmpty(cbPayType.Text))
			{
				cbPayType.Focus();
				MessageBox.Show("Please choose a payment type", "Waring!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}
			return true;
		}
		//
		// Export Excel
		private void simpleButton2_Click(object sender, EventArgs e)
		{
			if (AcceptText())
			{
				InforDAO infor = new InforDAO();
				SaveFileDialog dialog = new SaveFileDialog();
				dialog.Filter = "Excel Document (*.xlsx) | *.xlsx";
				dialog.AddExtension = true;
				dialog.DefaultExt = ".xlsx";
				if (dialog.ShowDialog() == DialogResult.OK)
				{
					WorkWithExcel excel = new WorkWithExcel();
					excel.ExportBill(infor.getObject(), MainView, od.getObject(cbBillID.Text), dialog.FileName, 1, 1);
					DevExpress.XtraEditors.XtraMessageBox.Show("Successfully!!");
				}
			}
		}
		//
		// Add new Customers
		private void simpleButton1_Click(object sender, EventArgs e)
		{
			frmCustomer frm = new frmCustomer();
			if (frm.ShowDialog() == DialogResult.OK)
			{
				cbCustomerID.Properties.DataSource = cd.getTable();
			}
		}
		//
		// Print Bill

		private void simpleButton3_Click(object sender, EventArgs e)
		{
			if (AcceptText())
			{
				waitForm.ShowWaitForm();
				frmPrint frm = new frmPrint();
				List<OrderBillDetail> mlist = detail.getList(cbBillID.Text);
				frm.PrintOrderBill(cbBillID.Text, mlist);
				waitForm.CloseWaitForm();
				frm.ShowDialog();
			}
		}
		//
		// Search Order ID
		private void btSearch_Click(object sender, EventArgs e)
		{
			listBoxID.Items.Clear();
			var list = od.getList().Where(o => o.orderDate >= dateStart.DateTime.Date && o.orderDate <= dateEnd.DateTime.Date).ToList();
			foreach (var item in list)
			{
				listBoxID.Items.Add(item.orderID);
			}
			temp = listBoxID.Items.Cast<string>().ToList();
		}

		List<string> temp = null;
		//
		// Filter ID
		private void textEdit1_EditValueChanged(object sender, EventArgs e)
		{
			if (temp != null && temp.Count > 0)
			{
				listBoxID.Items.Clear();
				listBoxID.Items.AddRange(temp.Where(item => item.Contains(txFilter.Text)).ToArray());
			}
		}
		//
		// Chose a order bill ID
		private void listBoxID_MouseClick(object sender, MouseEventArgs e)
		{
			if (listBoxID.Items.Count > 0)
			{
				cbBillID.Text = listBoxID.SelectedItem.ToString();
				cbBillID_EditValueChanged(sender, e);
			}
		}
	}
}
