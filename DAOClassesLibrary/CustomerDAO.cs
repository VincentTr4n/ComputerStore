using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MyObject;
using DAOClassesLibrary;
using MyClassesLibrary;

namespace DAOClassesLibrary
{
	public class CustomerDAO :IDAO<Customer>
	{
		public List<Customer> getList()
		{
			List<Customer> mlist = new List<Customer>();
			System.Data.SqlClient.SqlDataReader reader = MyConnect.getReader("select * from Customers");
			while (reader.Read())
			{
				Customer c = new Customer();
				c.ID = reader.GetString(0);
				c.Name = reader.GetString(1);
				c.phoneNumber = reader[2].ToString();
				c.Address = reader.GetString(3);
				c.email = reader.GetString(4);
				mlist.Add(c);
			}
			reader.Close();
			MyConnect.Disconncet();
			return mlist;
		}
		
		public bool AddObject(Customer o)
		{
			return MyConnect.MyExecuteQuery("insert into Customers values ('"+o.ID+"',N'"+SolveInput.StandardizedString(o.Name)+"','"+o.phoneNumber+"','"+o.Address+"','"+o.email+"',0)");
		}
		public bool UpdateObject(Customer c)
		{
			return MyConnect.MyExecuteQuery("update Customers set Name_Customer=N'" + SolveInput.StandardizedString(c.Name) + "',Phone='" + c.phoneNumber.ToString() + "',Address=N'" + c.Address + "',Email='"+c.email+ "' where ID_Customer='" + c.ID + "'");
		}
		public bool DeleteObject(string id)
		{
			return MyConnect.MyExecuteQuery("delete from Customers where ID_Customer='" + id + "'");
		}

		public DataTable getTable()
		{
			return MyConnect.getTable("select * from Customers");
		}

		public bool checkID(string id)
		{
			throw new NotImplementedException();
		}

		public Customer getObject(string id)
		{
			Customer c = new Customer();
			System.Data.SqlClient.SqlDataReader reader = MyConnect.getReader("select * from Customers where ID_Customer = '"+id+"'");
			while (reader.Read())
			{
				c.ID = reader.GetString(0);
				c.Name = reader.GetString(1);
				c.phoneNumber =reader[2].ToString();
				c.Address = reader.GetString(3);
				c.email = reader.GetString(4);
			}
			reader.Close();
			MyConnect.Disconncet();
			return c;
		}
	}
}
