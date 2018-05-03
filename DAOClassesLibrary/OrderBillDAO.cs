using MyClassesLibrary;
using MyObject;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAOClassesLibrary
{
	public class OrderBillDAO : IDAO<OrderBIll>
	{
		CustomerDAO cd = new CustomerDAO();
		EmployeeDAO ed = new EmployeeDAO();
		 
		public bool AddObject(OrderBIll o)
		{
			return MyConnect.MyExecuteQuery("insert into Orders values('"+o.orderID+"','"+o.customer.ID+"','"+o.employee.Id+"','"+o.orderDate.ToString("yyyy-MM-dd")+"',"+o.payType+","+o.total+")");
		}

		public bool checkID(string id)
		{
			return String.IsNullOrEmpty(MyConnect.getString("select ID_Order from Orders where ID_Order='"+id+"'"));
		}

		public bool DeleteObject(string id)
		{
			return MyConnect.MyExecuteQuery("delete from Orders where ID_Order = '"+id+"'");
		}

		public List<OrderBIll> getList()
		{
			List<OrderBIll> mlist = new List<OrderBIll>();
			System.Data.SqlClient.SqlDataReader reader = MyConnect.getReader("select * from Orders");
			while (reader.Read())
			{
				OrderBIll bill = new OrderBIll();
				bill.orderID = reader.GetString(0);
				bill.customer = cd.getObject(reader.GetString(1));
				bill.employee = ed.getObject(reader.GetString(2));
				bill.orderDate = reader.GetDateTime(3);
				bill.payType = Convert.ToInt16(reader[4]);
				bill.total = long.Parse(reader[5].ToString());
				mlist.Add(bill);
			}
			reader.Close();
			MyConnect.Disconncet();
			return mlist;
		}
		public List<OrderBIll> getList(DateTime date)
		{
			List<OrderBIll> mlist = new List<OrderBIll>();
			System.Data.SqlClient.SqlDataReader reader = MyConnect.getReader("select * from Orders where OrderDate='"+date.ToString("yyyy-MM-dd")+"'");
			while (reader.Read())
			{
				OrderBIll bill = new OrderBIll();
				bill.orderID = reader.GetString(0);
				bill.customer = cd.getObject(reader.GetString(1));
				bill.employee = ed.getObject(reader.GetString(2));
				bill.orderDate = reader.GetDateTime(3);
				bill.payType = Convert.ToInt16(reader[4]);
				bill.total = long.Parse(reader[5].ToString());
				mlist.Add(bill);
			}
			reader.Close();
			MyConnect.Disconncet();
			return mlist;
		}

		public OrderBIll getObject(string id)
		{
			DataTable table = getTable(id);
			if (table.Rows.Count == 0) return null;
			DataRow row = table.Rows[0];
			OrderBIll bill = new OrderBIll();
			bill.orderID = row[0].ToString();
			bill.customer = cd.getObject(row[1].ToString());
			bill.employee = ed.getObject(row[2].ToString());
			bill.orderDate = DateTime.Parse(row[3].ToString());
			bill.payType = Convert.ToInt16(row[4].ToString());
			bill.total = long.Parse(row[5].ToString());
			return bill;
		}

		public DataTable getTable()
		{
			return MyConnect.getTable("select * from Orders");
		}
		public DataTable getTable(string id)
		{
			return MyConnect.getTable("select * from Orders where ID_Order='"+id+"'");
		}
		public bool UpdateObject(OrderBIll o)
		{
			throw new NotImplementedException();
		}
		public string getTotalMoney(string id)
		{
			string s = MyConnect.MyExecuteScalar("select dbo.TotalOrderPrice('" + id + "')");
			return String.IsNullOrEmpty(s) ? "0" : s;
		}
	}
}
