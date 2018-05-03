using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace BaiTapLon_ComputerStore.Reports
{
	public partial class rptTopPurchase : DevExpress.XtraReports.UI.XtraReport
	{
		public rptTopPurchase()
		{
			InitializeComponent();
			Top.Value = 100;
		}
	}
}
