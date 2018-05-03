using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;
using System.Collections.Generic;
using DAOClassesLibrary;
using MyObject;

namespace BaiTapLon_ComputerStore.Reports
{
	public partial class rptPurchaseDetail : DevExpress.XtraReports.UI.XtraReport
	{
		InforDAO inforDAO = new InforDAO();
		public rptPurchaseDetail()
		{
			InitializeComponent();
			StoreInfor infor = inforDAO.getObject();
			lbName.Text = infor.name;
			lbAddress.Text = infor.address;
			lbPhone.Text = infor.phoneNumber;
			lbWeb.Text = infor.website;

		}
		public void InitData(string employee,string bill,DateTime date)
		{
			ID.Value = bill;
			pDate.Value = date;
			pEmployee.Value = employee;
			//objectDataSource1.DataSource = mlist;
		}
	}
}
