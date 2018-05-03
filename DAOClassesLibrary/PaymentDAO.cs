using DAOClassesLibrary;
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
	public class PaymentDAO : IDAO<Payment>
	{
		public bool AddObject(Payment o)
		{
			throw new NotImplementedException();
		}

		public bool checkID(string id)
		{
			throw new NotImplementedException();
		}

		public bool DeleteObject(string id)
		{
			throw new NotImplementedException();
		}

		public List<Payment> getList()
		{
			List<Payment> mlist = new List<Payment>();
			System.Data.DataTable table = getTable();
			foreach(DataRow row in table.Rows)
			{
				Payment p = new Payment();
				p.id = Convert.ToInt16(row[0].ToString());
				p.name = row[1].ToString();
				mlist.Add(p);
			}
			return mlist;
		}

		public Payment getObject(string id)
		{
			Payment p = new Payment();
			DataTable tabe = MyConnect.getTable("select * from Payment where PaymentType =" + id);
			p.id = Convert.ToInt16(tabe.Rows[0][0]);
			p.name = tabe.Rows[0][1].ToString();
			return p;
		}

		public DataTable getTable()
		{
			return MyConnect.getTable("select * from Payment");
		}

		public bool UpdateObject(Payment o)
		{
			throw new NotImplementedException();
		}
	}
}
