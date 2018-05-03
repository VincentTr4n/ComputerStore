namespace BaiTapLon_ComputerStore
{
	partial class frmReports
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.chartControl = new DevExpress.XtraCharts.ChartControl();
			this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
			this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
			this.ItemPrice = new DevExpress.XtraNavBar.NavBarItem();
			this.ItemQuantily = new DevExpress.XtraNavBar.NavBarItem();
			this.ItemType = new DevExpress.XtraNavBar.NavBarItem();
			this.navBarGroup2 = new DevExpress.XtraNavBar.NavBarGroup();
			this.ItemIncome = new DevExpress.XtraNavBar.NavBarItem();
			this.navBarItem1 = new DevExpress.XtraNavBar.NavBarItem();
			this.waitForm = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::BaiTapLon_ComputerStore.Forms.WaitForm1), true, true);
			this.btExcel = new DevExpress.XtraEditors.SimpleButton();
			this.btPrint = new DevExpress.XtraEditors.SimpleButton();
			((System.ComponentModel.ISupportInitialize)(this.chartControl)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
			this.SuspendLayout();
			// 
			// chartControl
			// 
			this.chartControl.AnimationStartMode = DevExpress.XtraCharts.ChartAnimationMode.OnDataChanged;
			this.chartControl.DataBindings = null;
			this.chartControl.Legend.Name = "Default Legend";
			this.chartControl.Location = new System.Drawing.Point(179, 63);
			this.chartControl.Name = "chartControl";
			this.chartControl.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
			this.chartControl.Size = new System.Drawing.Size(978, 574);
			this.chartControl.TabIndex = 0;
			// 
			// navBarControl1
			// 
			this.navBarControl1.ActiveGroup = this.navBarGroup1;
			this.navBarControl1.Dock = System.Windows.Forms.DockStyle.Left;
			this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup1,
            this.navBarGroup2});
			this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.ItemPrice,
            this.ItemQuantily,
            this.ItemIncome,
            this.ItemType,
            this.navBarItem1});
			this.navBarControl1.Location = new System.Drawing.Point(20, 60);
			this.navBarControl1.Name = "navBarControl1";
			this.navBarControl1.OptionsNavPane.ExpandedWidth = 153;
			this.navBarControl1.Size = new System.Drawing.Size(153, 610);
			this.navBarControl1.TabIndex = 1;
			this.navBarControl1.Text = "navBarControl1";
			// 
			// navBarGroup1
			// 
			this.navBarGroup1.Caption = "Produtcs";
			this.navBarGroup1.Expanded = true;
			this.navBarGroup1.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.ItemPrice),
            new DevExpress.XtraNavBar.NavBarItemLink(this.ItemQuantily),
            new DevExpress.XtraNavBar.NavBarItemLink(this.ItemType)});
			this.navBarGroup1.Name = "navBarGroup1";
			// 
			// ItemPrice
			// 
			this.ItemPrice.Caption = "Price";
			this.ItemPrice.Name = "ItemPrice";
			this.ItemPrice.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem1_LinkClicked);
			// 
			// ItemQuantily
			// 
			this.ItemQuantily.Caption = "Quantiy";
			this.ItemQuantily.Name = "ItemQuantily";
			this.ItemQuantily.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.ItemQuantily_LinkClicked);
			// 
			// ItemType
			// 
			this.ItemType.Caption = "Product Types";
			this.ItemType.Name = "ItemType";
			this.ItemType.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.ItemType_LinkClicked);
			// 
			// navBarGroup2
			// 
			this.navBarGroup2.Caption = "Revenue/Expenditure";
			this.navBarGroup2.Expanded = true;
			this.navBarGroup2.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.ItemIncome),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem1)});
			this.navBarGroup2.Name = "navBarGroup2";
			// 
			// ItemIncome
			// 
			this.ItemIncome.Caption = "Revenue of Month";
			this.ItemIncome.Name = "ItemIncome";
			this.ItemIncome.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.ItemIncome_LinkClicked);
			// 
			// navBarItem1
			// 
			this.navBarItem1.Caption = "Revenue of Days";
			this.navBarItem1.Name = "navBarItem1";
			this.navBarItem1.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem1_LinkClicked_1);
			// 
			// waitForm
			// 
			this.waitForm.ClosingDelay = 500;
			// 
			// btExcel
			// 
			this.btExcel.Location = new System.Drawing.Point(1065, 643);
			this.btExcel.Name = "btExcel";
			this.btExcel.Size = new System.Drawing.Size(75, 38);
			this.btExcel.TabIndex = 2;
			this.btExcel.Text = "Excel";
			this.btExcel.Click += new System.EventHandler(this.btExcel_Click);
			// 
			// btPrint
			// 
			this.btPrint.Location = new System.Drawing.Point(984, 643);
			this.btPrint.Name = "btPrint";
			this.btPrint.Size = new System.Drawing.Size(75, 38);
			this.btPrint.TabIndex = 3;
			this.btPrint.Text = "Print";
			this.btPrint.Click += new System.EventHandler(this.btPrint_Click);
			// 
			// frmReports
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1180, 690);
			this.Controls.Add(this.btPrint);
			this.Controls.Add(this.btExcel);
			this.Controls.Add(this.navBarControl1);
			this.Controls.Add(this.chartControl);
			this.MaximizeBox = false;
			this.Name = "frmReports";
			this.Resizable = false;
			this.Text = "Reports";
			this.Load += new System.EventHandler(this.frmReports_Load);
			((System.ComponentModel.ISupportInitialize)(this.chartControl)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraCharts.ChartControl chartControl;
		private DevExpress.XtraNavBar.NavBarControl navBarControl1;
		private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
		private DevExpress.XtraNavBar.NavBarItem ItemPrice;
		private DevExpress.XtraNavBar.NavBarItem ItemQuantily;
		private DevExpress.XtraNavBar.NavBarGroup navBarGroup2;
		private DevExpress.XtraNavBar.NavBarItem ItemIncome;
		private DevExpress.XtraNavBar.NavBarItem ItemType;
		private DevExpress.XtraNavBar.NavBarItem navBarItem1;
		private DevExpress.XtraSplashScreen.SplashScreenManager waitForm;
		private DevExpress.XtraEditors.SimpleButton btExcel;
		private DevExpress.XtraEditors.SimpleButton btPrint;
	}
}