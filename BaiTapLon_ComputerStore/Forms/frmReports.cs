using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraCharts;
using DevExpress.XtraNavBar;
using MyClassesLibrary;
using DAOClassesLibrary;

namespace BaiTapLon_ComputerStore
{
	public partial class frmReports : MetroFramework.Forms.MetroForm
	{
		ProductDAO pd = new ProductDAO();
		DataTable table = new DataTable();
		EnumReportState State;
		public frmReports()
		{
			InitializeComponent();
		}

		private void frmReports_Load(object sender, EventArgs e)
		{
			foreach (NavBarGroup group in navBarControl1.Groups) group.Expanded = false;
		}
		//
		// Report Product Price
		private void navBarItem1_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
		{
			waitForm.ShowWaitForm();
			clearText();
			ChartTitle title = new ChartTitle();
			title.Text = "Price Report";
			System.Threading.Thread.Sleep(1000);
			chartControl.Titles.Add(title);
			chartControl.DataSource = pd.getTable();
			Series s1 = new Series();
			s1.Name = "Purchase Price";
			chartControl.Series.Add(s1);
			s1.ArgumentDataMember = "Name_Pro";
			s1.ValueDataMembers.AddRange(new string[] { "PurchasePrice" });
			Series s2 = new Series();
			s2.Name = "Product Price";
			chartControl.Series.Add(s2);
			s2.ArgumentDataMember = "Name_Pro";
			s2.ValueDataMembers.AddRange(new string[] { "ProductPrice" });
			waitForm.CloseWaitForm();
			this.State = EnumReportState.Price;
		}
		//
		// Report Product Quantily
		private void ItemQuantily_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
		{
			waitForm.ShowWaitForm();
			clearText();
			ChartTitle title = new ChartTitle();
			title.Text = "Quantily Report";
			chartControl.Titles.Add(title);
			System.Threading.Thread.Sleep(1000);
			chartControl.DataSource = pd.getTable(EnumShowProduct.ShowReportQuantily);
			Series s1 = new Series();
			s1.Name = "On Purchase";
			s1.View.Color = Color.Green;
			chartControl.Series.Add(s1);
			s1.ArgumentDataMember = "Name_Pro";
			s1.ValueDataMembers.AddRange(new string[] { "QuantilyOnPurchase" });
			Series s2 = new Series();
			s2.Name = "On Order";
			chartControl.Series.Add(s2);
			s2.ArgumentDataMember = "Name_Pro";
			s2.ValueDataMembers.AddRange(new string[] { "QuantilyOnOrder" });
			waitForm.CloseWaitForm();
			this.State = EnumReportState.Quantiy;
		}
		//
		// Monthly report
		private void ItemIncome_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
		{
			frmPickDateTime frm = new frmPickDateTime();
			frm.myState = EnumPickDateTime.PickYear;
			if (frm.ShowDialog() == DialogResult.OK)
			{
				waitForm.ShowWaitForm();
				clearText();
				ChartTitle title = new ChartTitle();
				title.Text = "Monthly Report";
				chartControl.Titles.Add(title);
				System.Threading.Thread.Sleep(1000);
				table = MyConnect.getTable("execute ShowMothlyReports @y = " + frm.year);
				chartControl.DataSource = table;

				Series s2 = new Series("Purchase", ViewType.Bar);
				s2.View.Color = Color.Blue;
				chartControl.Series.Add(s2);
				s2.ArgumentDataMember = "Month";
				s2.ValueDataMembers.AddRange(new string[] { "TotalPurchase" });

				Series s1 = new Series("Sale", ViewType.Bar);
				s1.View.Color = Color.PaleVioletRed;
				chartControl.Series.Add(s1);
				s1.ArgumentDataMember = "Month";
				s1.ValueDataMembers.AddRange(new string[] { "TotalSale" });
				
				waitForm.CloseWaitForm();
				this.State = EnumReportState.RevenueOfMonth;
			}
		}
		void clearText()
		{
			chartControl.Titles.Clear();
			chartControl.Series.Clear();
			table = null;
		}
		//
		// Report Product Typer Sold
		private void ItemType_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
		{
			waitForm.ShowWaitForm();
			clearText();
			ChartTitle title = new ChartTitle();
			title.Text = "Product Types Report";
			chartControl.Titles.Add(title);
			chartControl.DataSource = null;
			System.Threading.Thread.Sleep(1000);
			table = MyConnect.getTable("select * from CountTypePorduct");
			Series s1 = new Series("Type", ViewType.Pie);
			for (int i = 0; i < table.Rows.Count; i++)
			{
				s1.Points.Add(new SeriesPoint(table.Rows[i][0].ToString(), Convert.ToInt16(table.Rows[i][1].ToString())));
			}
			s1.Label.TextPattern = "{A}: {VP:p0}";
			chartControl.Series.Add(s1);
			waitForm.CloseWaitForm();
			this.State = EnumReportState.ProductTypes;
		}
		//
		// Days Report
		private void navBarItem1_LinkClicked_1(object sender, NavBarLinkEventArgs e)
		{

			frmPickDateTime frm = new frmPickDateTime();
			frm.myState = EnumPickDateTime.PickDays;
			if (frm.ShowDialog() == DialogResult.OK)
			{
				waitForm.ShowWaitForm();
				clearText();
				ChartTitle title = new ChartTitle();
				title.Text = "Days Report From : " + frm.startDate.ToShortDateString() + " To " + frm.endDate.ToShortDateString();
				chartControl.Titles.Add(title);
				System.Threading.Thread.Sleep(1000);

				table = MyConnect.getTable("execute DaysReport @start ='" + frm.startDate.ToString("yyyy-MM-dd") + "',@end = '" + frm.endDate.ToString("yyyy-MM-dd") + "'");

				Series s1 = new Series("Total", ViewType.Line);
				s1.View.Color = Color.Orange;
				chartControl.Series.Add(s1);
				int i = 0, j = 0;
				foreach (DateTime date in MyAction.GetAllDates(frm.startDate, frm.endDate))
				{
					if (j < table.Rows.Count)
					{
						DateTime temp = DateTime.Parse(table.Rows[j][0].ToString());
						if (temp.Equals(date))
						{
							s1.Points.Add(new SeriesPoint(temp.ToString("dd-MM-yyyy"), long.Parse(table.Rows[j][1].ToString())));
							j++;
						}
						else s1.Points.Add(new SeriesPoint(date.ToString("dd-MM-yyyy"), 0));
					}
					else s1.Points.Add(new SeriesPoint(date.ToString("dd-MM-yyyy"), 0));
					i++;
				}
				chartControl.Series.Add(s1);
				//MessageBox.Show(table.Rows[0][1].ToString());
				waitForm.CloseWaitForm();
				this.State = EnumReportState.RevenueOfDays;
			}
		}


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
				if (State == EnumReportState.RevenueOfMonth) excel.ExportExcelReports(table, 2, "Reprot of Monthly", "Report of Monthly", save.FileName);
				else if (State == EnumReportState.Price) excel.ExportExcelReports(table, 2, "Reprot of Product Price", "Reprot of Product Price", save.FileName);
				else if (State == EnumReportState.Quantiy) excel.ExportExcelReports(table, 2, "Reprot of Product Quantily", "Reprot of Product Quantily", save.FileName);
				else if (State == EnumReportState.ProductTypes) excel.ExportExcelReports(table, 2, "Reprot of Product Types", "Reprot of Product Types", save.FileName);
				else if (State == EnumReportState.RevenueOfDays) excel.ExportExcelReports(table, 2, "Reprot of Days", "Report of Days", save.FileName);
				waitForm.CloseWaitForm();
			}
		}

		private void btPrint_Click(object sender, EventArgs e)
		{
			if (chartControl.Series.Count > 0)
			{
				chartControl.ShowPrintPreview();
			}
		}
	}
}
