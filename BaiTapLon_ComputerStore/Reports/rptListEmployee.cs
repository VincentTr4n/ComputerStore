using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace BaiTapLon_ComputerStore.Reports
{
	public partial class rptListEmployee : DevExpress.XtraReports.UI.XtraReport
	{
		public rptListEmployee()
		{
			InitializeComponent();
			Month.Value = DateTime.Now.Month;
			Year.Value = DateTime.Now.Year;

		}
	}
}
