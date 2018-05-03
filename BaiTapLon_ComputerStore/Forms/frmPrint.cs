using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DAOClassesLibrary;
using MyObject;

namespace BaiTapLon_ComputerStore.Reports
{
	public partial class frmPrint : DevExpress.XtraEditors.XtraForm
	{
		OrderBillDAO od = new OrderBillDAO();
		CustomerDAO cd = new CustomerDAO();
		PaymentDAO pd = new PaymentDAO();
		public frmPrint()
		{
			InitializeComponent();
		}
		public void PrintOrderBill(string billID, List<OrderBillDetail> mlist)
		{
			OrderBIll bill = od.getObject(billID);
			Customer cus = bill.customer;
			Payment pay = pd.getObject(bill.payType.ToString());
			rptOrderDetail rpt = new rptOrderDetail();
			foreach (DevExpress.XtraReports.Parameters.Parameter p in rpt.Parameters)
				p.Visible = false;
			rpt.InitData(cus.Name, cus.Address, pay.name, bill.employee.Name, cus.phoneNumber, billID, bill.orderDate, mlist);
			documentViewer1.DocumentSource = rpt;
			rpt.CreateDocument();
		}
		public void PrintListEmp()
		{
			rptListEmployee rpt = new rptListEmployee();
			//rpt.InitData(month, year);
			documentViewer1.DocumentSource = rpt;
			rpt.CreateDocument();
		}
		public void PrintTopSale()
		{
			rptProducts rpt = new rptProducts();
			//rpt.InitData(month, year);
			documentViewer1.DocumentSource = rpt;
			rpt.CreateDocument();
		}
		public void PrintPurchaseBill(string bill, string employee, DateTime date)
		{
			rptPurchaseDetail rpt = new rptPurchaseDetail();
			foreach (DevExpress.XtraReports.Parameters.Parameter p in rpt.Parameters)
				p.Visible = false;
			rpt.InitData(employee, bill, date);
			documentViewer1.DocumentSource = rpt;
			rpt.CreateDocument();

		}
		public void PrintTopPurchase()
		{
			rptTopPurchase rpt = new rptTopPurchase();
			documentViewer1.DocumentSource = rpt;
			rpt.CreateDocument();
		}

		private void frmPrint_Load(object sender, EventArgs e)
		{

		}
	}
}