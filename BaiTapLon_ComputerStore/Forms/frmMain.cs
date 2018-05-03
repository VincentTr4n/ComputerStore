using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using DevExpress.XtraNavBar;
using DevExpress.XtraEditors;
using DAOClassesLibrary;
using MyObject;
using MyClassesLibrary;
using System.Threading;

namespace BaiTapLon_ComputerStore
{
	public partial class frmMain : MaterialSkin.Controls.MaterialForm
	{
		ProductDAO pc = new ProductDAO();
		CategoryDAO cc = new CategoryDAO();
		TypeDAO td = new TypeDAO();
		SupplierDAO sd = new SupplierDAO();

		//
		//Frame and Item
		TileItemFrame frDate;
		TileItemFrame frTime;

		TileItemElement itDate;
		TileItemElement itTime;

		MaterialSkinManager skin;


		enum Action { add, update }
		public frmMain()
		{
			InitializeComponent();
			skin = MaterialSkinManager.Instance;
			skin.AddFormToManage(this);
			skin.Theme = MaterialSkinManager.Themes.DARK;
			skin.ColorScheme = new ColorScheme(Primary.Green600, Primary.BlueGrey900, Primary.BlueGrey600, Accent.Orange700, TextShade.WHITE);
			setTile();
		}
		//
		// Form load
		private void frmMain_Load(object sender, EventArgs e)
		{
			Screen scr = Screen.PrimaryScreen;
			this.Left = (scr.WorkingArea.Width - this.Width) / 2;
			this.Top = (scr.WorkingArea.Height - this.Height) / 2;
			timer1.Start();
			tabControl.SelectedTab = tbMain;
			if (!Properties.Settings.Default.Service)
			{
				tileEmployees.Enabled = false;
				tileCustomers.Enabled = false;
				tileIDashboard.Enabled = false;
				tileReports.Enabled = false;
				tileAccoutSetting.Enabled = false;
			}

			tileTime.StartAnimation();
			tileAllProduct.StartAnimation();

			createNavBar();

			this.Text = new InforDAO().getObject().name;
		}

		//
		//Tile Time
		void setTile()
		{
			frDate = new TileItemFrame();
			itDate = new TileItemElement();
			itDate.TextAlignment = TileItemContentAlignment.MiddleCenter;
			frDate.Elements.Add(itDate);
			frDate.Elements[0].AnimateTransition = DevExpress.Utils.DefaultBoolean.True;

			frTime = new TileItemFrame();
			itTime = new TileItemElement();
			itTime.TextAlignment = TileItemContentAlignment.MiddleCenter;
			frTime.Elements.Add(itTime);
			frTime.Elements[0].AnimateTransition = DevExpress.Utils.DefaultBoolean.True;
			tileTime.Frames.Add(frDate);
			tileTime.Frames.Add(frTime);
		}

		//
		//Show current time
		private void timer1_Tick(object sender, EventArgs e)
		{
			lbDatetime.Text = DateTime.Now.ToString("dd/MM/yyyy - HH:mm:ss");
			itDate.Text = "<Size=+2><Color=Red><b>"+DateTime.Now.DayOfWeek +"   "+DateTime.Now.ToString("dd/MM/yyy")+"</b></Color></Size>";
			itTime.Text = "<Size=+2><Color=Red><b>Time  " + DateTime.Now.ToString("HH:mm:ss") + "</b></Color></Size>";
		}

		#region menu and form
		//
		//Set current user accessing
		public void setUserAccessing(string s)
		{
			lbAccessing.Text = s;
		}
		//
		// Show form account settings
		private void tileAccoutSetting_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
		{
			frmAccountSetting acs = new frmAccountSetting();
			acs.ShowDialog();
		}
		//
		//Log out
		private void tileLogOut_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
		{
			frmLogIn frm = new frmLogIn();
			frm.Show();
			this.Dispose();
		}

		private void LogOut()
		{
			Application.Run(new frmLogIn());
		}

		//
		// Show form employees
		private void tileEmployees_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
		{
			frmEmployee frm = new frmEmployee();
			frm.ShowDialog();
			frm.Owner = this;
		}

		//Exit application
		private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}
		#endregion

		#region Categorys
		//Clicked Item
		private void navBarControl_LinkClicked(object sender, NavBarLinkEventArgs e)
		{
			gridControl1.DataSource = pc.getTable(e.Link.Item.Caption);
		}
		//
		//Create NavBar Control
		void createNavBar()
		{
			foreach (Category c in cc.getList())
			{
				NavBarGroup group = new NavBarGroup(c.categoryName);
				foreach (Types t in td.getList(c.categoryID))
				{
					NavBarItem item = new NavBarItem(t.typeName);
					item.Tag = t.category.categoryID;
					group.ItemLinks.Add(item);
				}
				navBarControl.Groups.Add(group);
			}
		}
		//
		//Categorys
		#endregion

		#region All Products
		//
		//Show All Products
		private void mtProducts_Click(object sender, EventArgs e)
		{
			tabControl.SelectedTab = tbAllProducts;
			//Load data into Combo Box
			//Add type into combo box
			foreach (Types t in td.getList())
				ItemsCBTypes.Items.Add(t.typeName);
			//Add supplier into combo box
			foreach (Supplier s in sd.getList())
				ItemsCBCompany.Items.Add(s.companyName);
			gridControl1.DataSource = pc.getTable();

		}
		private void button1_Click(object sender, EventArgs e)
		{
			gridControl1.DataSource = null;
			pc.dv = null;
			tabControl.SelectedTab = tbMain;
			//
			// Start animation
			tileTime.StartAnimation();
			tileAllProduct.StartAnimation();
		}
		//
		//Update data from gridview

		bool check = Properties.Settings.Default.Service;
		private void sbtDelete_Click(object sender, EventArgs e)
		{
			if (check)
			{
				if (MainView.GetSelectedRows().Length == 0) MessageBox.Show("Please select a row before delete!", "Warring!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				else
				{
					var row = MainView.GetDataRow(MainView.GetSelectedRows()[0]);
					if (MessageBox.Show("Are you sure delete this record?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
						if (pc.DeleteObject(row[0].ToString()))
						{
							MainView.DeleteSelectedRows();
							MessageBox.Show("Delete successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
						}
						else MessageBox.Show("Check information again!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}
		//
		//Show form Import Product
		private void tileImportProduct_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
		{
			frmImportProducts frm = new frmImportProducts();
			frm.ShowDialog();
			frm.Owner = this;
		}
		private void MainView_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
		{
			var row = MainView.GetDataRow(MainView.GetSelectedRows()[0]);
			//MessageBox.Show("!!!");
			if(check) RowUpdated(row);
		}
		void RowUpdated(DataRow row)
		{
			Products p = new Products();
			p.productID = row[0].ToString();
			p.productName = row[1].ToString();
			Types t = new Types();
			t.typeName = row[2].ToString();
			p.Type = t;
			Supplier s = new Supplier();
			s.companyName = row[3].ToString();
			p.supplier = s;
			p.quantily = Convert.ToInt16(row[4].ToString());
			p.purchasePrice = long.Parse(row[5].ToString());
			p.productPrice = long.Parse(row[6].ToString());
			p.warranty = Convert.ToInt16(row[7].ToString());
			pc.UpdateObject(p);
		}

		private void tileAllProduct_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
		{
			waitForm.ShowWaitForm();
			System.Threading.Thread.Sleep(1000);
			navBarControl.Groups.Clear();
			tabControl.SelectedTab = tbAllProducts;
			//Load data into Combo Box
			//Add type into combo box
			foreach (Types t in td.getList())
				ItemsCBTypes.Items.Add(t.typeName);
			//Add supplier into combo box
			foreach (Supplier s in sd.getList())
				ItemsCBCompany.Items.Add(s.companyName);
			gridControl1.DataSource = pc.getTable();
			createNavBar();
			//
			// Stop animation
			tileTime.StopAnimation();
			tileAllProduct.StopAnimation();
			waitForm.CloseWaitForm();
		}
		#endregion

		private void navBarControl_GroupCollapsed(object sender, NavBarGroupEventArgs e)
		{
			int count = 0;
			foreach(NavBarGroup group in navBarControl.Groups)	if (group.Expanded) count++;
			if (count == 0) gridControl1.DataSource = pc.getTable();
		}

		private void tileSale_ItemClick(object sender, TileItemEventArgs e)
		{
			frmSale frm = new frmSale();
			frm.ShowDialog();
		}
		//
		//DARK themes
		private void darkThemeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			skin.Theme = MaterialSkinManager.Themes.DARK;
			lbDatetime.ForeColor = Color.White;
		}
		//
		//LIGHT themes

		private void lightThemeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			skin.Theme = MaterialSkinManager.Themes.LIGHT;
			lbDatetime.ForeColor = Color.Black;
		}
		//
		// Show Customer
		private void tileCustomers_ItemClick(object sender, TileItemEventArgs e)
		{
			frmCustomer frm = new frmCustomer();
			frm.ShowDialog();
			frm.Owner = this;
		}
		//
		// Print
		private void sbtPrint_Click(object sender, EventArgs e)
		{
			using(Reports.frmPrint frm = new Reports.frmPrint())
			{
				frm.PrintTopSale();
				frm.ShowDialog();
			}
		}
		//
		// Report with chart
		private void tileReports_ItemClick(object sender, TileItemEventArgs e)
		{
			frmReports frm = new frmReports();
			frm.ShowDialog();
			frm.Owner = this;
		}

		private void tileIDashboard_ItemClick(object sender, TileItemEventArgs e)
		{
			waitForm.ShowWaitForm();
			frmDashboardDesigner frm = new frmDashboardDesigner();
			waitForm.CloseWaitForm();
			frm.ShowDialog(this);
		}
		//
		// Export to Excel
		private void btExcel_Click(object sender, EventArgs e)
		{
			SaveFileDialog save = new SaveFileDialog();
			save.Filter = "(*.xlsx)|*.xlsx";
			save.DefaultExt = ".xlsx";
			save.AddExtension = true;
			if (save.ShowDialog(this) == DialogResult.OK)
			{
				waitForm.ShowWaitForm();
				WorkWithExcel excel = new WorkWithExcel();
				get_productsTableAdapter.Fill(computerStoreDataSet.get_products);
				excel.ExportExcelReports(computerStoreDataSet.get_products, 2, "Reprot of Products", "Reprot of Products", save.FileName);
				waitForm.CloseWaitForm();
			}
		}
	}
}
