using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BaiTapLon_ComputerStore.Reports;
using MyClassesLibrary;
using MyObject;
using DAOClassesLibrary;

namespace BaiTapLon_ComputerStore
{
	public partial class frmEmployee : MetroFramework.Forms.MetroForm
	{
		EmployeeDAO ed = new EmployeeDAO();
		EnumStateAction State = EnumStateAction.Cancel;
		public frmEmployee()
		{
			InitializeComponent();
		}

		private void frmEmployee_Load(object sender, EventArgs e)
		{
			gridControl1.DataSource = ed.getTable();

			int year = DateTime.Now.Year;
			for (int i = 0; i < 100; i++) cbYear.Properties.Items.Add((year--).ToString());
			birthDate.DateTime = DateTime.Now;
			cbMonth.SelectedIndex = cbYear.SelectedIndex = 0;
			txQuantily.Text = txRevenue.Text =txPhone.Text= "0";
			btCancel.Enabled = btDelete.Enabled = btApply.Enabled = false;
		}

		private void txRevenue_TextChanged(object sender, EventArgs e)
		{
			lbRevenue.Text = MyAction.FormatMoney(txRevenue.Text);
		}
		//
		// Set Employee into controls
		void setText(Employee emp)
		{
			txID.Text = emp.Id;
			txName.Text = emp.Name;
			txPhone.Text = emp.PhoneNumber.ToString();
			txAddress.Text = emp.Address;
			birthDate.DateTime = emp.BirthDate;
			cbSex.SelectedIndex = emp.Sex ? 0 : 1;
			imgEmployee.Image = emp.EmpImage;
			txQuantily.Text = ed.QuantilyProductSold(emp.Id, cbMonth.SelectedIndex, Convert.ToInt16(cbYear.Text));
			txRevenue.Text = ed.ProseedsOfSale(emp.Id, cbMonth.SelectedIndex, Convert.ToInt16(cbYear.Text));
		}
		//
		// Get employee from controls
		Employee getEmployeeFormText()
		{
			Employee emp = new Employee();
			emp.Id = txID.Text;
			emp.Name = txName.Text;
			emp.PhoneNumber = long.Parse(txPhone.Text);
			emp.Address = txAddress.Text;
			emp.EmpImage = imgEmployee.Image;
			emp.BirthDate = birthDate.DateTime;
			emp.Sex = (cbSex.SelectedIndex == 1) ? false : true;
			return emp;
		}
		private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
		{
			setText(ed.getObject(gridView1.GetDataRow(e.RowHandle)[0].ToString()));
			grStatistical.Enabled = true;
			State = EnumStateAction.Cancel;
		}

		private void simpleButton1_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		//
		// Show infor
		private void cbMonth_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (!String.IsNullOrEmpty(txID.Text))
			{
				txQuantily.Text = ed.QuantilyProductSold(txID.Text, cbMonth.SelectedIndex, Convert.ToInt16(cbYear.Text));
				txRevenue.Text = ed.ProseedsOfSale(txID.Text, cbMonth.SelectedIndex, Convert.ToInt16(cbYear.Text));
			}
		}
		//
		// Save Change
		private bool checkText()
		{
			if (String.IsNullOrEmpty(txName.Text)) return false;
			if (String.IsNullOrEmpty(txAddress.Text)) return false;
			//if (imgEmployee.Image == null) return false;
			return true;
		}
		private void btApply_Click(object sender, EventArgs e)
		{
			//MessageBox.Show(getEmployeeFormText().ToString());
			if (!checkText())
			{
				XtraMessageBox.Show("Check Infor agagin!");
				return;
			}
			if (State == EnumStateAction.Insert) { showMess(ed.AddObject(getEmployeeFormText())); gridControl1.DataSource = ed.getTable(); btApply.Enabled = false; }
			if (State == EnumStateAction.Update) { showMess(ed.UpdateObject(getEmployeeFormText())); gridControl1.DataSource = ed.getTable(); btApply.Enabled = false; }
			grStatistical.Enabled = true;
			btCancel.Enabled = false;
		}
		void showMess(bool check)
		{
			if (check) XtraMessageBox.Show("Saved!");
			else XtraMessageBox.Show("Error!");
		}
		//
		// Add New Employee
		private void btAdd_Click(object sender, EventArgs e)
		{
			btCancel.Enabled = true;
			setText(new Employee());
			txID.Text = MyAction.AutoIncreaseID("E", ed.EmployeeIdMax(), 5);
			grStatistical.Enabled = false;
			btApply.Enabled = true;
			State = EnumStateAction.Insert;
		}
		//
		// Edit Employee
		private void btEdit_Click(object sender, EventArgs e)
		{
			btCancel.Enabled = true;
			grStatistical.Enabled = false;
			btApply.Enabled = true;
			State = EnumStateAction.Update;
			setText(ed.getObject(gridView1.GetDataRow(gridView1.GetSelectedRows()[0])[0].ToString()));
		}
		//
		// Delete Employee
		private void btDelete_Click(object sender, EventArgs e)
		{
			XtraMessageBox.Show("Don't delete employee information >.< ahihi !");
		}
		//
		// Cancel Change
		private void btCancel_Click(object sender, EventArgs e)
		{
			State = EnumStateAction.Cancel;
			setText(ed.getObject(gridView1.GetDataRow(gridView1.GetSelectedRows()[0])[0].ToString()));
		}
		//
		// Only Accept Number
		private void txPhone_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsNumber(e.KeyChar) && e.KeyChar != '\b') e.Handled = true;
		}
		//
		// Choose Image
		private void btOpenImage_Click(object sender, EventArgs e)
		{
			OpenFileDialog open = new OpenFileDialog();
			open.Filter = "(*.png)|*.png";
			if (open.ShowDialog() == DialogResult.OK)
			{
				imgEmployee.Image = Image.FromFile(open.FileName);
			}
		}
		//
		// Set 0 for textbox Phone Number when empty
		private void txPhone_TextChanged(object sender, EventArgs e)
		{
			if (String.IsNullOrEmpty(txPhone.Text)) txPhone.Text = "0";
		}

		private void btExcel_Click(object sender, EventArgs e)
		{
			using(frmPrint frm = new frmPrint())
			{
				frm.PrintListEmp();
				frm.ShowDialog();
			}
		}
	}
}
