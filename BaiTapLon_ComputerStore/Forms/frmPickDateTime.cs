using DAOClassesLibrary;
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
	public partial class frmPickDateTime : MetroFramework.Forms.MetroForm
	{
		public EnumPickDateTime myState { get; set; }
		int _year = DateTime.Now.Year;
		DateTime _startDate = DateTime.Now;
		DateTime _endDate = DateTime.Now;
		bool check = true;
		public frmPickDateTime()
		{
			InitializeComponent();
			
		}

		private void frmPickDateTime_Load(object sender, EventArgs e)
		{
			if (myState == EnumPickDateTime.PickYear)
			{
				tabControl.SelectedIndex=0;
				for (int i = 0; i < 100; i++) cbPickYear.Properties.Items.Add(DateTime.Now.Year-i);
				cbPickYear.SelectedIndex = 0;
			}
			if (myState == EnumPickDateTime.PickDays)
			{
				tabControl.SelectedIndex=1;
			}
		}

		private void btCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btApply_Click(object sender, EventArgs e)
		{
			if (myState == EnumPickDateTime.PickYear) _year = Convert.ToInt16(cbPickYear.Text);
			if (myState == EnumPickDateTime.PickDays)
			{
				if (dpStart.DateTime < dpEnd.DateTime)
				{
					_startDate = dpStart.DateTime;
					_endDate = dpEnd.DateTime;
					check = true;
				}
				else { DevExpress.XtraEditors.XtraMessageBox.Show("Please chose again!!"); check = false; }
			}
		}
		//
		// My Getter
		public int year { get { return _year; } }
		public DateTime startDate { get { return _startDate; } }
		public DateTime endDate { get { return _endDate; } }

		private void frmPickDateTime_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (!check) e.Cancel = true;
		}
		//
		// Date Time Change
		private void dpEnd_EditValueChanged(object sender, EventArgs e)
		{
			if (dpEnd.DateTime > DateTime.Now) dpEnd.DateTime = DateTime.Now;
		}
	}
}
