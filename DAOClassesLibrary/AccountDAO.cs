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
    public class AccountDAO : IDAO<Account>
    {
        public string getUserName(string email)
        {
			return MyConnect.getString("select UserName from LogIn where Email = N'" + email + "'");
		}
		//
		// Interface

		public List<Account> getList()
		{
			throw new NotImplementedException();
		}

		public DataTable getTable()
		{
			throw new NotImplementedException();
		}

		public bool AddObject(Account o)
		{
			int i = o.service ? 1 : 0;
			return MyConnect.MyExecuteQuery("insert into LogIn values(N'" + o.username + "',N'" + o.password + "'," + i + ",N'" + o.email + "')");
		}

		public bool UpdateObject(Account o)
		{
			return MyConnect.MyExecuteQuery("update LogIn set Password=N'" + o.password + "',Service='" + o.service + "',Email=N'" + o.email + "' where UserName=N'" + o.username + "'");
		}

		public bool DeleteObject(string id)
		{
			return MyConnect.MyExecuteQuery("delete form LogIn where UserName=N'" + id + "'");
		}

		public Account getObject(string id)
		{
			Account account = new Account();
			SqlDataReader reader = MyConnect.getReader("select * from LogIn where UserName = N'" + id + "'");
			while (reader.Read())
			{
				account.username = reader.GetString(0);
				account.password = reader.GetString(1);
				account.service = reader.GetBoolean(2);
				account.email = reader.GetString(3);
			}
			reader.Close();
			MyConnect.Disconncet();
			return account;
		}

		public bool checkID(string id)
		{
			throw new NotImplementedException();
		}

	}
}
