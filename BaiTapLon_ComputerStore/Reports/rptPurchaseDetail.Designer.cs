namespace BaiTapLon_ComputerStore.Reports
{
	partial class rptPurchaseDetail
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

		#region Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			DevExpress.XtraReports.UI.XRSummary xrSummary1 = new DevExpress.XtraReports.UI.XRSummary();
			DevExpress.XtraReports.UI.XRSummary xrSummary2 = new DevExpress.XtraReports.UI.XRSummary();
			DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery1 = new DevExpress.DataAccess.Sql.StoredProcQuery();
			DevExpress.DataAccess.Sql.QueryParameter queryParameter1 = new DevExpress.DataAccess.Sql.QueryParameter();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rptPurchaseDetail));
			this.Detail = new DevExpress.XtraReports.UI.DetailBand();
			this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
			this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
			this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell11 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell12 = new DevExpress.XtraReports.UI.XRTableCell();
			this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
			this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
			this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
			this.xrLabel15 = new DevExpress.XtraReports.UI.XRLabel();
			this.pDate = new DevExpress.XtraReports.Parameters.Parameter();
			this.xrLabel14 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel12 = new DevExpress.XtraReports.UI.XRLabel();
			this.pEmployee = new DevExpress.XtraReports.Parameters.Parameter();
			this.xrTable2 = new DevExpress.XtraReports.UI.XRTable();
			this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
			this.xrTableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell8 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell9 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
			this.lbWeb = new DevExpress.XtraReports.UI.XRLabel();
			this.lbPhone = new DevExpress.XtraReports.UI.XRLabel();
			this.lbAddress = new DevExpress.XtraReports.UI.XRLabel();
			this.lbName = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
			this.ID = new DevExpress.XtraReports.Parameters.Parameter();
			this.GroupFooter1 = new DevExpress.XtraReports.UI.GroupFooterBand();
			this.xrLabel16 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrTable3 = new DevExpress.XtraReports.UI.XRTable();
			this.xrTableRow3 = new DevExpress.XtraReports.UI.XRTableRow();
			this.xrTableCell13 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell14 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrLabel18 = new DevExpress.XtraReports.UI.XRLabel();
			this.show_orderDetailTableAdapter = new BaiTapLon_ComputerStore.ShowOrderDetailTableAdapters.show_orderDetailTableAdapter();
			this.show_purshaseDetialTableAdapter = new BaiTapLon_ComputerStore.ShowPurchaseDetailTableAdapters.show_purshaseDetialTableAdapter();
			this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.xrTable2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.xrTable3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
			// 
			// Detail
			// 
			this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable1});
			this.Detail.HeightF = 25F;
			this.Detail.Name = "Detail";
			this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
			this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			// 
			// xrTable1
			// 
			this.xrTable1.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
			this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(9.999974F, 0F);
			this.xrTable1.Name = "xrTable1";
			this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
			this.xrTable1.SizeF = new System.Drawing.SizeF(706.9999F, 25F);
			this.xrTable1.StylePriority.UseBorders = false;
			this.xrTable1.StylePriority.UseTextAlignment = false;
			this.xrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			// 
			// xrTableRow1
			// 
			this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell1,
            this.xrTableCell2,
            this.xrTableCell3,
            this.xrTableCell11,
            this.xrTableCell12});
			this.xrTableRow1.Name = "xrTableRow1";
			this.xrTableRow1.Weight = 1D;
			// 
			// xrTableCell1
			// 
			this.xrTableCell1.Name = "xrTableCell1";
			xrSummary1.Func = DevExpress.XtraReports.UI.SummaryFunc.RecordNumber;
			xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
			this.xrTableCell1.Summary = xrSummary1;
			this.xrTableCell1.Text = "xrTableCell1";
			this.xrTableCell1.Weight = 0.35416671752929685D;
			// 
			// xrTableCell2
			// 
			this.xrTableCell2.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "getPurchaseBill.Name_Pro")});
			this.xrTableCell2.Name = "xrTableCell2";
			this.xrTableCell2.Weight = 2.0937500226251053D;
			// 
			// xrTableCell3
			// 
			this.xrTableCell3.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "getPurchaseBill.QuantiyPurchase")});
			this.xrTableCell3.Name = "xrTableCell3";
			this.xrTableCell3.Weight = 0.79541794736670846D;
			// 
			// xrTableCell11
			// 
			this.xrTableCell11.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "getPurchaseBill.Price", "{0:#,#}")});
			this.xrTableCell11.Name = "xrTableCell11";
			this.xrTableCell11.Weight = 2.052081911094862D;
			// 
			// xrTableCell12
			// 
			this.xrTableCell12.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "getPurchaseBill.Total")});
			this.xrTableCell12.Name = "xrTableCell12";
			this.xrTableCell12.StylePriority.UseTextAlignment = false;
			this.xrTableCell12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			this.xrTableCell12.Weight = 1.7745831481512624D;
			// 
			// TopMargin
			// 
			this.TopMargin.HeightF = 50F;
			this.TopMargin.Name = "TopMargin";
			this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
			this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			// 
			// BottomMargin
			// 
			this.BottomMargin.HeightF = 50F;
			this.BottomMargin.Name = "BottomMargin";
			this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
			this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			// 
			// ReportHeader
			// 
			this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel15,
            this.xrLabel14,
            this.xrLabel12,
            this.xrTable2,
            this.xrLabel8,
            this.xrLabel6,
            this.xrLabel2,
            this.lbWeb,
            this.lbPhone,
            this.lbAddress,
            this.lbName,
            this.xrLabel1});
			this.ReportHeader.HeightF = 314.5833F;
			this.ReportHeader.Name = "ReportHeader";
			// 
			// xrLabel15
			// 
			this.xrLabel15.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding(this.pDate, "Text", "{0:dd/MM/yyyy}")});
			this.xrLabel15.LocationFloat = new DevExpress.Utils.PointFloat(124.2082F, 197.4375F);
			this.xrLabel15.Name = "xrLabel15";
			this.xrLabel15.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel15.SizeF = new System.Drawing.SizeF(130.5834F, 23F);
			this.xrLabel15.StylePriority.UseTextAlignment = false;
			this.xrLabel15.Text = "xrLabel15";
			this.xrLabel15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// pDate
			// 
			this.pDate.Description = "Parameter1";
			this.pDate.Name = "pDate";
			this.pDate.Type = typeof(System.DateTime);
			// 
			// xrLabel14
			// 
			this.xrLabel14.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding(this.ID, "Text", "")});
			this.xrLabel14.LocationFloat = new DevExpress.Utils.PointFloat(124.2082F, 174.4375F);
			this.xrLabel14.Name = "xrLabel14";
			this.xrLabel14.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel14.SizeF = new System.Drawing.SizeF(130.5834F, 22.99998F);
			this.xrLabel14.StylePriority.UseTextAlignment = false;
			this.xrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// xrLabel12
			// 
			this.xrLabel12.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding(this.pEmployee, "Text", "")});
			this.xrLabel12.LocationFloat = new DevExpress.Utils.PointFloat(124.2082F, 220.4375F);
			this.xrLabel12.Name = "xrLabel12";
			this.xrLabel12.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel12.SizeF = new System.Drawing.SizeF(233.7083F, 23F);
			this.xrLabel12.StylePriority.UseTextAlignment = false;
			this.xrLabel12.Text = "xrLabel12";
			this.xrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// pEmployee
			// 
			this.pEmployee.Description = "Parameter1";
			this.pEmployee.Name = "pEmployee";
			// 
			// xrTable2
			// 
			this.xrTable2.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
			this.xrTable2.LocationFloat = new DevExpress.Utils.PointFloat(9.999977F, 289.5833F);
			this.xrTable2.Name = "xrTable2";
			this.xrTable2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow2});
			this.xrTable2.SizeF = new System.Drawing.SizeF(707F, 25F);
			this.xrTable2.StylePriority.UseBorders = false;
			this.xrTable2.StylePriority.UseTextAlignment = false;
			this.xrTable2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			// 
			// xrTableRow2
			// 
			this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell4,
            this.xrTableCell5,
            this.xrTableCell6,
            this.xrTableCell8,
            this.xrTableCell9});
			this.xrTableRow2.Name = "xrTableRow2";
			this.xrTableRow2.Weight = 1D;
			// 
			// xrTableCell4
			// 
			this.xrTableCell4.Name = "xrTableCell4";
			this.xrTableCell4.Text = "No";
			this.xrTableCell4.Weight = 0.35416668096082005D;
			// 
			// xrTableCell5
			// 
			this.xrTableCell5.Name = "xrTableCell5";
			this.xrTableCell5.Text = "Product Name";
			this.xrTableCell5.Weight = 2.0937496203741697D;
			// 
			// xrTableCell6
			// 
			this.xrTableCell6.Name = "xrTableCell6";
			this.xrTableCell6.Text = "Quantily";
			this.xrTableCell6.Weight = 0.79541788385053958D;
			// 
			// xrTableCell8
			// 
			this.xrTableCell8.Name = "xrTableCell8";
			this.xrTableCell8.Text = "Price";
			this.xrTableCell8.Weight = 2.0520820968415547D;
			// 
			// xrTableCell9
			// 
			this.xrTableCell9.Name = "xrTableCell9";
			this.xrTableCell9.Text = "Total";
			this.xrTableCell9.Weight = 1.7745831449580523D;
			// 
			// xrLabel8
			// 
			this.xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(14.16664F, 174.4375F);
			this.xrLabel8.Name = "xrLabel8";
			this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel8.SizeF = new System.Drawing.SizeF(90.625F, 23F);
			this.xrLabel8.StylePriority.UseTextAlignment = false;
			this.xrLabel8.Text = "Bill :";
			this.xrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// xrLabel6
			// 
			this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(14.16658F, 220.4375F);
			this.xrLabel6.Name = "xrLabel6";
			this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel6.SizeF = new System.Drawing.SizeF(107.2917F, 22.99998F);
			this.xrLabel6.StylePriority.UseTextAlignment = false;
			this.xrLabel6.Text = "Employee : ";
			this.xrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// xrLabel2
			// 
			this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(14.16664F, 197.4375F);
			this.xrLabel2.Name = "xrLabel2";
			this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel2.SizeF = new System.Drawing.SizeF(90.625F, 23F);
			this.xrLabel2.StylePriority.UseTextAlignment = false;
			this.xrLabel2.Text = "Date : ";
			this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// lbWeb
			// 
			this.lbWeb.Font = new System.Drawing.Font("Times New Roman", 8F);
			this.lbWeb.LocationFloat = new DevExpress.Utils.PointFloat(9.999974F, 68.99999F);
			this.lbWeb.Name = "lbWeb";
			this.lbWeb.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.lbWeb.SizeF = new System.Drawing.SizeF(309.375F, 23F);
			this.lbWeb.StylePriority.UseFont = false;
			this.lbWeb.StylePriority.UseTextAlignment = false;
			this.lbWeb.Text = "lbName";
			this.lbWeb.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// lbPhone
			// 
			this.lbPhone.Font = new System.Drawing.Font("Times New Roman", 8F);
			this.lbPhone.LocationFloat = new DevExpress.Utils.PointFloat(9.999974F, 45.99997F);
			this.lbPhone.Name = "lbPhone";
			this.lbPhone.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.lbPhone.SizeF = new System.Drawing.SizeF(309.375F, 23F);
			this.lbPhone.StylePriority.UseFont = false;
			this.lbPhone.StylePriority.UseTextAlignment = false;
			this.lbPhone.Text = "lbName";
			this.lbPhone.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// lbAddress
			// 
			this.lbAddress.LocationFloat = new DevExpress.Utils.PointFloat(9.999974F, 22.99999F);
			this.lbAddress.Name = "lbAddress";
			this.lbAddress.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.lbAddress.SizeF = new System.Drawing.SizeF(309.375F, 23F);
			this.lbAddress.StylePriority.UseTextAlignment = false;
			this.lbAddress.Text = "lbName";
			this.lbAddress.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// lbName
			// 
			this.lbName.Font = new System.Drawing.Font("Times New Roman", 16F);
			this.lbName.LocationFloat = new DevExpress.Utils.PointFloat(9.999974F, 0F);
			this.lbName.Name = "lbName";
			this.lbName.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.lbName.SizeF = new System.Drawing.SizeF(309.375F, 23F);
			this.lbName.StylePriority.UseFont = false;
			this.lbName.StylePriority.UseTextAlignment = false;
			this.lbName.Text = "lbName";
			this.lbName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// xrLabel1
			// 
			this.xrLabel1.Font = new System.Drawing.Font("Times New Roman", 20F);
			this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(186.0416F, 103.4584F);
			this.xrLabel1.Multiline = true;
			this.xrLabel1.Name = "xrLabel1";
			this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel1.SizeF = new System.Drawing.SizeF(314.5833F, 55.29169F);
			this.xrLabel1.StylePriority.UseFont = false;
			this.xrLabel1.StylePriority.UseTextAlignment = false;
			this.xrLabel1.Text = "Purchase Bill\r\n";
			this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			// 
			// ID
			// 
			this.ID.Description = "Parameter1";
			this.ID.Name = "ID";
			// 
			// GroupFooter1
			// 
			this.GroupFooter1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel16,
            this.xrTable3,
            this.xrLabel18});
			this.GroupFooter1.HeightF = 100F;
			this.GroupFooter1.Name = "GroupFooter1";
			// 
			// xrLabel16
			// 
			this.xrLabel16.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
			this.xrLabel16.LocationFloat = new DevExpress.Utils.PointFloat(602.7083F, 41.66667F);
			this.xrLabel16.Name = "xrLabel16";
			this.xrLabel16.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel16.SizeF = new System.Drawing.SizeF(100F, 23F);
			this.xrLabel16.StylePriority.UseFont = false;
			this.xrLabel16.StylePriority.UseTextAlignment = false;
			this.xrLabel16.Text = "Employee";
			this.xrLabel16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			// 
			// xrTable3
			// 
			this.xrTable3.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
			this.xrTable3.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 0F);
			this.xrTable3.Name = "xrTable3";
			this.xrTable3.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow3});
			this.xrTable3.SizeF = new System.Drawing.SizeF(706.9999F, 25F);
			this.xrTable3.StylePriority.UseBorders = false;
			// 
			// xrTableRow3
			// 
			this.xrTableRow3.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell13,
            this.xrTableCell14});
			this.xrTableRow3.Name = "xrTableRow3";
			this.xrTableRow3.Weight = 1D;
			// 
			// xrTableCell13
			// 
			this.xrTableCell13.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
			this.xrTableCell13.Name = "xrTableCell13";
			this.xrTableCell13.StylePriority.UseBorders = false;
			this.xrTableCell13.StylePriority.UseTextAlignment = false;
			this.xrTableCell13.Text = "Total : ";
			this.xrTableCell13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			this.xrTableCell13.Weight = 5.2954162597656245D;
			// 
			// xrTableCell14
			// 
			this.xrTableCell14.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
			this.xrTableCell14.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "getPurchaseBill.Total")});
			this.xrTableCell14.Name = "xrTableCell14";
			this.xrTableCell14.StylePriority.UseBorders = false;
			this.xrTableCell14.StylePriority.UseTextAlignment = false;
			xrSummary2.FormatString = "{0:#,#}";
			xrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
			this.xrTableCell14.Summary = xrSummary2;
			this.xrTableCell14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			this.xrTableCell14.Weight = 1.7745825195312501D;
			// 
			// xrLabel18
			// 
			this.xrLabel18.Font = new System.Drawing.Font("Times New Roman", 8F);
			this.xrLabel18.LocationFloat = new DevExpress.Utils.PointFloat(602.7083F, 64.66669F);
			this.xrLabel18.Name = "xrLabel18";
			this.xrLabel18.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel18.SizeF = new System.Drawing.SizeF(100F, 23F);
			this.xrLabel18.StylePriority.UseFont = false;
			this.xrLabel18.StylePriority.UseTextAlignment = false;
			this.xrLabel18.Text = "(signature...)";
			this.xrLabel18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			// 
			// show_orderDetailTableAdapter
			// 
			this.show_orderDetailTableAdapter.ClearBeforeFill = true;
			// 
			// show_purshaseDetialTableAdapter
			// 
			this.show_purshaseDetialTableAdapter.ClearBeforeFill = true;
			// 
			// sqlDataSource1
			// 
			this.sqlDataSource1.ConnectionName = "BaiTapLon_ComputerStore.Properties.Settings.ComputerStoreConnectionString";
			this.sqlDataSource1.Name = "sqlDataSource1";
			storedProcQuery1.Name = "getPurchaseBill";
			queryParameter1.Name = "@Bill";
			queryParameter1.Type = typeof(DevExpress.DataAccess.Expression);
			queryParameter1.Value = new DevExpress.DataAccess.Expression("[Parameters.ID]", typeof(string));
			storedProcQuery1.Parameters.Add(queryParameter1);
			storedProcQuery1.StoredProcName = "getPurchaseBill";
			this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery1});
			this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
			// 
			// rptPurchaseDetail
			// 
			this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.ReportHeader,
            this.GroupFooter1});
			this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlDataSource1});
			this.DataAdapter = this.show_purshaseDetialTableAdapter;
			this.DataMember = "getPurchaseBill";
			this.DataSource = this.sqlDataSource1;
			this.Margins = new System.Drawing.Printing.Margins(50, 50, 50, 50);
			this.PageHeight = 1169;
			this.PageWidth = 827;
			this.PaperKind = System.Drawing.Printing.PaperKind.A4;
			this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.pEmployee,
            this.ID,
            this.pDate});
			this.ScriptsSource = resources.GetString("$this.ScriptsSource");
			this.Version = "17.1";
			((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.xrTable2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.xrTable3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this)).EndInit();

		}

		#endregion

		private DevExpress.XtraReports.UI.DetailBand Detail;
		private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
		private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
		private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
		private DevExpress.XtraReports.UI.XRLabel xrLabel1;
		private DevExpress.XtraReports.UI.XRLabel lbName;
		private DevExpress.XtraReports.UI.XRLabel lbWeb;
		private DevExpress.XtraReports.UI.XRLabel lbPhone;
		private DevExpress.XtraReports.UI.XRLabel lbAddress;
		private DevExpress.XtraReports.UI.XRLabel xrLabel2;
		private DevExpress.XtraReports.UI.XRLabel xrLabel6;
		private DevExpress.XtraReports.UI.XRLabel xrLabel8;
		private DevExpress.XtraReports.UI.XRTable xrTable1;
		private DevExpress.XtraReports.UI.XRTableRow xrTableRow1;
		private DevExpress.XtraReports.UI.XRTableCell xrTableCell1;
		private DevExpress.XtraReports.UI.XRTableCell xrTableCell2;
		private DevExpress.XtraReports.UI.XRTableCell xrTableCell3;
		private DevExpress.XtraReports.UI.XRTable xrTable2;
		private DevExpress.XtraReports.UI.XRTableRow xrTableRow2;
		private DevExpress.XtraReports.UI.XRTableCell xrTableCell4;
		private DevExpress.XtraReports.UI.XRTableCell xrTableCell5;
		private DevExpress.XtraReports.UI.XRTableCell xrTableCell6;
		private DevExpress.XtraReports.UI.XRTableCell xrTableCell8;
		private DevExpress.XtraReports.UI.XRTableCell xrTableCell9;
		private DevExpress.XtraReports.UI.XRTableCell xrTableCell11;
		private DevExpress.XtraReports.UI.XRTableCell xrTableCell12;
		private DevExpress.XtraReports.UI.GroupFooterBand GroupFooter1;
		private DevExpress.XtraReports.UI.XRTable xrTable3;
		private DevExpress.XtraReports.UI.XRTableRow xrTableRow3;
		private DevExpress.XtraReports.UI.XRTableCell xrTableCell13;
		private DevExpress.XtraReports.UI.XRTableCell xrTableCell14;
		private ShowOrderDetailTableAdapters.show_orderDetailTableAdapter show_orderDetailTableAdapter;
		private DevExpress.XtraReports.Parameters.Parameter pEmployee;
		private DevExpress.XtraReports.Parameters.Parameter ID;
		private DevExpress.XtraReports.Parameters.Parameter pDate;
		private DevExpress.XtraReports.UI.XRLabel xrLabel15;
		private DevExpress.XtraReports.UI.XRLabel xrLabel14;
		private DevExpress.XtraReports.UI.XRLabel xrLabel12;
		private DevExpress.XtraReports.UI.XRLabel xrLabel16;
		private DevExpress.XtraReports.UI.XRLabel xrLabel18;
		private ShowPurchaseDetailTableAdapters.show_purshaseDetialTableAdapter show_purshaseDetialTableAdapter;
		private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
	}
}
