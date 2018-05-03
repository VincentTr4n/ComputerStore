namespace BaiTapLon_ComputerStore.Reports
{
	partial class rptProducts
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
			DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery1 = new DevExpress.DataAccess.Sql.StoredProcQuery();
			DevExpress.DataAccess.Sql.QueryParameter queryParameter1 = new DevExpress.DataAccess.Sql.QueryParameter();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rptProducts));
			DevExpress.XtraReports.UI.XRSummary xrSummary1 = new DevExpress.XtraReports.UI.XRSummary();
			this.Detail = new DevExpress.XtraReports.UI.DetailBand();
			this.xrTable2 = new DevExpress.XtraReports.UI.XRTable();
			this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
			this.xrTableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell7 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell8 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell10 = new DevExpress.XtraReports.UI.XRTableCell();
			this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
			this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
			this.xrPageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
			this.xrPageInfo2 = new DevExpress.XtraReports.UI.XRPageInfo();
			this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
			this.reportHeaderBand1 = new DevExpress.XtraReports.UI.ReportHeaderBand();
			this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
			this.groupHeaderBand1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
			this.xrPanel1 = new DevExpress.XtraReports.UI.XRPanel();
			this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
			this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
			this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell9 = new DevExpress.XtraReports.UI.XRTableCell();
			this.Title = new DevExpress.XtraReports.UI.XRControlStyle();
			this.DetailCaption3 = new DevExpress.XtraReports.UI.XRControlStyle();
			this.DetailData3 = new DevExpress.XtraReports.UI.XRControlStyle();
			this.DetailData3_Odd = new DevExpress.XtraReports.UI.XRControlStyle();
			this.DetailCaptionBackground3 = new DevExpress.XtraReports.UI.XRControlStyle();
			this.PageInfo = new DevExpress.XtraReports.UI.XRControlStyle();
			this.Top = new DevExpress.XtraReports.Parameters.Parameter();
			this.xrTableCell11 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell12 = new DevExpress.XtraReports.UI.XRTableCell();
			((System.ComponentModel.ISupportInitialize)(this.xrTable2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
			// 
			// Detail
			// 
			this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable2});
			this.Detail.HeightF = 25F;
			this.Detail.Name = "Detail";
			this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
			this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			// 
			// xrTable2
			// 
			this.xrTable2.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
			this.xrTable2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
			this.xrTable2.Name = "xrTable2";
			this.xrTable2.OddStyleName = "DetailData3_Odd";
			this.xrTable2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow2});
			this.xrTable2.SizeF = new System.Drawing.SizeF(650F, 25F);
			this.xrTable2.StylePriority.UseBorders = false;
			// 
			// xrTableRow2
			// 
			this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell12,
            this.xrTableCell5,
            this.xrTableCell6,
            this.xrTableCell7,
            this.xrTableCell8,
            this.xrTableCell10});
			this.xrTableRow2.Name = "xrTableRow2";
			this.xrTableRow2.Weight = 11.5D;
			// 
			// xrTableCell5
			// 
			this.xrTableCell5.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "TopSale.Product ID")});
			this.xrTableCell5.Name = "xrTableCell5";
			this.xrTableCell5.StyleName = "DetailData3";
			this.xrTableCell5.Text = "xrTableCell5";
			this.xrTableCell5.Weight = 0.11538464109898436D;
			// 
			// xrTableCell6
			// 
			this.xrTableCell6.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "TopSale.Product Name")});
			this.xrTableCell6.Name = "xrTableCell6";
			this.xrTableCell6.StyleName = "DetailData3";
			this.xrTableCell6.Text = "xrTableCell6";
			this.xrTableCell6.Weight = 0.27923076436119149D;
			// 
			// xrTableCell7
			// 
			this.xrTableCell7.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "TopSale.Price")});
			this.xrTableCell7.Name = "xrTableCell7";
			this.xrTableCell7.StyleName = "DetailData3";
			this.xrTableCell7.StylePriority.UseTextAlignment = false;
			this.xrTableCell7.Text = "xrTableCell7";
			this.xrTableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			this.xrTableCell7.Weight = 0.20327270329067834D;
			// 
			// xrTableCell8
			// 
			this.xrTableCell8.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "TopSale.Quantily Sold")});
			this.xrTableCell8.Name = "xrTableCell8";
			this.xrTableCell8.StyleName = "DetailData3";
			this.xrTableCell8.StylePriority.UseTextAlignment = false;
			this.xrTableCell8.Text = "xrTableCell8";
			this.xrTableCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			this.xrTableCell8.Weight = 0.10403498897321248D;
			// 
			// xrTableCell10
			// 
			this.xrTableCell10.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "TopSale.Total")});
			this.xrTableCell10.Name = "xrTableCell10";
			this.xrTableCell10.StylePriority.UseTextAlignment = false;
			this.xrTableCell10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			this.xrTableCell10.Weight = 0.24358974802201178D;
			// 
			// TopMargin
			// 
			this.TopMargin.HeightF = 100F;
			this.TopMargin.Name = "TopMargin";
			this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
			this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			// 
			// BottomMargin
			// 
			this.BottomMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPageInfo1,
            this.xrPageInfo2});
			this.BottomMargin.HeightF = 100F;
			this.BottomMargin.Name = "BottomMargin";
			this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
			this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			// 
			// xrPageInfo1
			// 
			this.xrPageInfo1.LocationFloat = new DevExpress.Utils.PointFloat(6F, 6F);
			this.xrPageInfo1.Name = "xrPageInfo1";
			this.xrPageInfo1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
			this.xrPageInfo1.SizeF = new System.Drawing.SizeF(313F, 23F);
			this.xrPageInfo1.StyleName = "PageInfo";
			// 
			// xrPageInfo2
			// 
			this.xrPageInfo2.Format = "Page {0} of {1}";
			this.xrPageInfo2.LocationFloat = new DevExpress.Utils.PointFloat(331F, 6F);
			this.xrPageInfo2.Name = "xrPageInfo2";
			this.xrPageInfo2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrPageInfo2.SizeF = new System.Drawing.SizeF(313F, 23F);
			this.xrPageInfo2.StyleName = "PageInfo";
			this.xrPageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			// 
			// sqlDataSource1
			// 
			this.sqlDataSource1.ConnectionName = "BaiTapLon_ComputerStore.Properties.Settings.ComputerStoreConnectionString";
			this.sqlDataSource1.Name = "sqlDataSource1";
			storedProcQuery1.Name = "TopSale";
			queryParameter1.Name = "@top";
			queryParameter1.Type = typeof(DevExpress.DataAccess.Expression);
			queryParameter1.Value = new DevExpress.DataAccess.Expression("[Parameters.Top]", typeof(int));
			storedProcQuery1.Parameters.Add(queryParameter1);
			storedProcQuery1.StoredProcName = "TopSale";
			this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery1});
			this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
			// 
			// reportHeaderBand1
			// 
			this.reportHeaderBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel1});
			this.reportHeaderBand1.HeightF = 60F;
			this.reportHeaderBand1.Name = "reportHeaderBand1";
			// 
			// xrLabel1
			// 
			this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(6F, 6F);
			this.xrLabel1.Name = "xrLabel1";
			this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel1.SizeF = new System.Drawing.SizeF(638F, 26F);
			this.xrLabel1.StyleName = "Title";
			this.xrLabel1.Text = "Top Products Sale";
			// 
			// groupHeaderBand1
			// 
			this.groupHeaderBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPanel1});
			this.groupHeaderBand1.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
			this.groupHeaderBand1.HeightF = 48F;
			this.groupHeaderBand1.Name = "groupHeaderBand1";
			// 
			// xrPanel1
			// 
			this.xrPanel1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable1});
			this.xrPanel1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
			this.xrPanel1.Name = "xrPanel1";
			this.xrPanel1.SizeF = new System.Drawing.SizeF(650F, 48F);
			this.xrPanel1.StyleName = "DetailCaptionBackground3";
			// 
			// xrTable1
			// 
			this.xrTable1.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
			this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 20F);
			this.xrTable1.Name = "xrTable1";
			this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
			this.xrTable1.SizeF = new System.Drawing.SizeF(650F, 28F);
			this.xrTable1.StylePriority.UseBorders = false;
			// 
			// xrTableRow1
			// 
			this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell11,
            this.xrTableCell1,
            this.xrTableCell2,
            this.xrTableCell3,
            this.xrTableCell4,
            this.xrTableCell9});
			this.xrTableRow1.Name = "xrTableRow1";
			this.xrTableRow1.Weight = 1D;
			// 
			// xrTableCell1
			// 
			this.xrTableCell1.Name = "xrTableCell1";
			this.xrTableCell1.StyleName = "DetailCaption3";
			this.xrTableCell1.Text = "Product ID";
			this.xrTableCell1.Weight = 0.11538463339739788D;
			// 
			// xrTableCell2
			// 
			this.xrTableCell2.Name = "xrTableCell2";
			this.xrTableCell2.StyleName = "DetailCaption3";
			this.xrTableCell2.Text = "Product Name";
			this.xrTableCell2.Weight = 0.27923081147203055D;
			// 
			// xrTableCell3
			// 
			this.xrTableCell3.Name = "xrTableCell3";
			this.xrTableCell3.StyleName = "DetailCaption3";
			this.xrTableCell3.StylePriority.UseTextAlignment = false;
			this.xrTableCell3.Text = "Price";
			this.xrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			this.xrTableCell3.Weight = 0.20327272917578307D;
			// 
			// xrTableCell4
			// 
			this.xrTableCell4.Multiline = true;
			this.xrTableCell4.Name = "xrTableCell4";
			this.xrTableCell4.StyleName = "DetailCaption3";
			this.xrTableCell4.StylePriority.UseTextAlignment = false;
			this.xrTableCell4.Text = "Quantily\r\n";
			this.xrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			this.xrTableCell4.Weight = 0.10403509699754142D;
			// 
			// xrTableCell9
			// 
			this.xrTableCell9.Borders = DevExpress.XtraPrinting.BorderSide.None;
			this.xrTableCell9.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
			this.xrTableCell9.Name = "xrTableCell9";
			this.xrTableCell9.StylePriority.UseBorders = false;
			this.xrTableCell9.StylePriority.UseFont = false;
			this.xrTableCell9.StylePriority.UseTextAlignment = false;
			this.xrTableCell9.Text = "Total";
			this.xrTableCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			this.xrTableCell9.Weight = 0.24358967632846215D;
			// 
			// Title
			// 
			this.Title.BackColor = System.Drawing.Color.Transparent;
			this.Title.BorderColor = System.Drawing.Color.Black;
			this.Title.Borders = DevExpress.XtraPrinting.BorderSide.None;
			this.Title.BorderWidth = 1F;
			this.Title.Font = new System.Drawing.Font("Tahoma", 14F);
			this.Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
			this.Title.Name = "Title";
			// 
			// DetailCaption3
			// 
			this.DetailCaption3.BackColor = System.Drawing.Color.Transparent;
			this.DetailCaption3.BorderColor = System.Drawing.Color.Transparent;
			this.DetailCaption3.Borders = DevExpress.XtraPrinting.BorderSide.None;
			this.DetailCaption3.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
			this.DetailCaption3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
			this.DetailCaption3.Name = "DetailCaption3";
			this.DetailCaption3.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
			this.DetailCaption3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// DetailData3
			// 
			this.DetailData3.Font = new System.Drawing.Font("Tahoma", 8F);
			this.DetailData3.ForeColor = System.Drawing.Color.Black;
			this.DetailData3.Name = "DetailData3";
			this.DetailData3.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
			this.DetailData3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// DetailData3_Odd
			// 
			this.DetailData3_Odd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
			this.DetailData3_Odd.BorderColor = System.Drawing.Color.Transparent;
			this.DetailData3_Odd.Borders = DevExpress.XtraPrinting.BorderSide.None;
			this.DetailData3_Odd.BorderWidth = 1F;
			this.DetailData3_Odd.Font = new System.Drawing.Font("Tahoma", 8F);
			this.DetailData3_Odd.ForeColor = System.Drawing.Color.Black;
			this.DetailData3_Odd.Name = "DetailData3_Odd";
			this.DetailData3_Odd.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
			this.DetailData3_Odd.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// DetailCaptionBackground3
			// 
			this.DetailCaptionBackground3.BackColor = System.Drawing.Color.Transparent;
			this.DetailCaptionBackground3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
			this.DetailCaptionBackground3.Borders = DevExpress.XtraPrinting.BorderSide.Top;
			this.DetailCaptionBackground3.BorderWidth = 2F;
			this.DetailCaptionBackground3.Name = "DetailCaptionBackground3";
			// 
			// PageInfo
			// 
			this.PageInfo.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
			this.PageInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
			this.PageInfo.Name = "PageInfo";
			this.PageInfo.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			// 
			// Top
			// 
			this.Top.Name = "Top";
			this.Top.Type = typeof(int);
			this.Top.ValueInfo = "0";
			// 
			// xrTableCell11
			// 
			this.xrTableCell11.Borders = DevExpress.XtraPrinting.BorderSide.None;
			this.xrTableCell11.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
			this.xrTableCell11.Name = "xrTableCell11";
			this.xrTableCell11.StylePriority.UseBorders = false;
			this.xrTableCell11.StylePriority.UseFont = false;
			this.xrTableCell11.StylePriority.UseTextAlignment = false;
			this.xrTableCell11.Text = "No";
			this.xrTableCell11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			this.xrTableCell11.Weight = 0.054487174432392621D;
			// 
			// xrTableCell12
			// 
			this.xrTableCell12.Name = "xrTableCell12";
			xrSummary1.Func = DevExpress.XtraReports.UI.SummaryFunc.RecordNumber;
			xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
			this.xrTableCell12.Summary = xrSummary1;
			this.xrTableCell12.Text = "xrTableCell12";
			this.xrTableCell12.Weight = 0.054487143270265381D;
			// 
			// rptProducts
			// 
			this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.reportHeaderBand1,
            this.groupHeaderBand1});
			this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlDataSource1});
			this.DataMember = "TopSale";
			this.DataSource = this.sqlDataSource1;
			this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.Top});
			this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.Title,
            this.DetailCaption3,
            this.DetailData3,
            this.DetailData3_Odd,
            this.DetailCaptionBackground3,
            this.PageInfo});
			this.Version = "17.1";
			((System.ComponentModel.ISupportInitialize)(this.xrTable2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this)).EndInit();

		}

		#endregion

		private DevExpress.XtraReports.UI.DetailBand Detail;
		private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
		private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
		private DevExpress.XtraReports.UI.XRTable xrTable2;
		private DevExpress.XtraReports.UI.XRTableRow xrTableRow2;
		private DevExpress.XtraReports.UI.XRTableCell xrTableCell5;
		private DevExpress.XtraReports.UI.XRTableCell xrTableCell6;
		private DevExpress.XtraReports.UI.XRTableCell xrTableCell7;
		private DevExpress.XtraReports.UI.XRTableCell xrTableCell8;
		private DevExpress.XtraReports.UI.XRPageInfo xrPageInfo1;
		private DevExpress.XtraReports.UI.XRPageInfo xrPageInfo2;
		private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
		private DevExpress.XtraReports.UI.ReportHeaderBand reportHeaderBand1;
		private DevExpress.XtraReports.UI.XRLabel xrLabel1;
		private DevExpress.XtraReports.UI.GroupHeaderBand groupHeaderBand1;
		private DevExpress.XtraReports.UI.XRPanel xrPanel1;
		private DevExpress.XtraReports.UI.XRTable xrTable1;
		private DevExpress.XtraReports.UI.XRTableRow xrTableRow1;
		private DevExpress.XtraReports.UI.XRTableCell xrTableCell1;
		private DevExpress.XtraReports.UI.XRTableCell xrTableCell2;
		private DevExpress.XtraReports.UI.XRTableCell xrTableCell3;
		private DevExpress.XtraReports.UI.XRTableCell xrTableCell4;
		private DevExpress.XtraReports.UI.XRControlStyle Title;
		private DevExpress.XtraReports.UI.XRControlStyle DetailCaption3;
		private DevExpress.XtraReports.UI.XRControlStyle DetailData3;
		private DevExpress.XtraReports.UI.XRControlStyle DetailData3_Odd;
		private DevExpress.XtraReports.UI.XRControlStyle DetailCaptionBackground3;
		private DevExpress.XtraReports.UI.XRControlStyle PageInfo;
		private DevExpress.XtraReports.UI.XRTableCell xrTableCell10;
		private DevExpress.XtraReports.UI.XRTableCell xrTableCell9;
		private DevExpress.XtraReports.Parameters.Parameter Top;
		private DevExpress.XtraReports.UI.XRTableCell xrTableCell12;
		private DevExpress.XtraReports.UI.XRTableCell xrTableCell11;
	}
}
