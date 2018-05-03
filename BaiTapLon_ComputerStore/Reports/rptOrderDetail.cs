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
	public partial class rptOrderDetail : DevExpress.XtraReports.UI.XtraReport
	{
		InforDAO inforDAO = new InforDAO();
		public rptOrderDetail()
		{
			InitializeComponent();
			StoreInfor infor = inforDAO.getObject();
			lbName.Text = infor.name;
			lbAddress.Text = infor.address;
			lbPhone.Text = infor.phoneNumber;
			lbWeb.Text = infor.website;

		}
		public void InitData(string customer,string address,string payment,string employee,string phone,string bill,DateTime date,List<OrderBillDetail> mlist)
		{
			pCustomer.Value = customer;
			pAddress.Value = address;
			pPayment.Value = payment;
			pEmployee.Value = employee;
			pPhone.Value = phone;
			PBillID.Value = bill;
			pDate.Value = date;
			objectDataSource1.DataSource = mlist;
		}
	}
}
