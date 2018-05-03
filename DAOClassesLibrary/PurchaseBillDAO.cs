using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MyObject;
using DAOClassesLibrary;
using MyClassesLibrary;

namespace DAOClassesLibrary
{
	public class PurchaseBillDAO : IDAO<PurchaseBill>
	{
		public List<PurchaseBill> getList()
		{
			List<PurchaseBill> mlist = new List<PurchaseBill>();
			SqlDataReader reader = MyConnect.getReader("select * from get_PurchaseBills");
			while (reader.Read())
			{
				PurchaseBill bill = new PurchaseBill();
				bill.purchaseID = reader.GetString(0);
				bill.employee = new EmployeeDAO().getObject(reader.GetString(1));
				bill.purchaseDate = reader.GetDateTime(2);
				bill.totalPrice = long.Parse(reader[3].ToString());
				mlist.Add(bill);
			}
			return mlist;
		}

		public DataTable getTable()
		{
			throw new NotImplementedException();
		}

		public bool AddObject(PurchaseBill bill)
		{
			return MyConnect.MyExecuteQuery("insert into Purchase values('" + bill.purchaseID + "','" + bill.employee.Id + "','" + bill.purchaseDate.ToString("yyyy-MM-dd") + "','" + bill.totalPrice.ToString() + "','')");
		}

		public bool UpdateObject(PurchaseBill bill)
		{
			throw new NotImplementedException();
		}

		public bool DeleteObject(string id)
		{
			return MyConnect.MyExecuteQuery("delete from Purchase where ID_Purchase = '"+id+"'");
		}

		public bool checkID(string id)
		{
			return !String.IsNullOrEmpty(MyConnect.getString("select ID_Purchase from Purchase where ID_Purchase='"+id+"'"));
		}

		public PurchaseBill getObject(string id)
		{
			PurchaseBill bill = new PurchaseBill();
			SqlDataReader reader = MyConnect.getReader("select * from Purchase where ID_Purchase='"+id+"'");
			while (reader.Read())
			{
				bill.purchaseID = reader.GetString(0);
				bill.employee = new EmployeeDAO().getObject(reader.GetString(1));
				bill.purchaseDate = reader.GetDateTime(2);
				bill.totalPrice = long.Parse(reader[3].ToString());
			}
			return bill;
		}
		public string createID(string date)
		{
			return MyConnect.MyExecuteScalar("select dbo.get_PurchaseBill('" + date + "')");
		}
		public string getTotalMoney(string id)
		{
			return MyConnect.MyExecuteScalar("select dbo.TotalPruchasePrice('"+id+"')");
		}
	}
}
