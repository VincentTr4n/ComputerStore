using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MyObject;
using MyClassesLibrary;

namespace DAOClassesLibrary
{
	public class SupplierDAO : IDAO<Supplier>
	{
		public bool AddObject(Supplier o)
		{
			throw new NotImplementedException();
		}

		public bool checkID(string id)
		{
			return !String.IsNullOrEmpty(MyConnect.getString("select ID_Supplier from Suppliers where ID_Supplier = '"+id+"'"));
		}

		public bool DeleteObject(string id)
		{
			throw new NotImplementedException();
		}

		public List<Supplier> getList()
		{

			List<Supplier> mlist = new List<Supplier>();
			SqlDataReader reader = MyConnect.getReader("select * from Suppliers");
			while (reader.Read())
			{
				Supplier s = new Supplier();
				s.supplierID = reader.GetString(0);
				s.companyName = reader.GetString(1);
				s.Description = reader.GetString(2);
				s.Headquarters = reader.GetString(3);
				mlist.Add(s);
			}
			reader.Close();
			MyConnect.Disconncet();
			return mlist;

		}

		public Supplier getObject(string id)
		{
			Supplier s = new Supplier();
			SqlDataReader reader = MyConnect.getReader("select * from Suppliers where ID_Supplier='"+id+"'");
			while (reader.Read())
			{
				s.supplierID = reader.GetString(0);
				s.companyName = reader.GetString(1);
				s.Description = reader.GetString(2);
				s.Headquarters = reader.GetString(3);
			}
			reader.Close();
			MyConnect.Disconncet();
			return s;
		}

		public DataTable getTable()
		{
			return MyConnect.getTable("select * from Suppliers");
		}

		public bool UpdateObject(Supplier o)
		{
			throw new NotImplementedException();
		}

	}
}
