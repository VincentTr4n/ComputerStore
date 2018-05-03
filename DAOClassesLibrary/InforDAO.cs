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
	public class InforDAO : IDAO<StoreInfor>
	{
		public bool AddObject(StoreInfor o)
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

		public List<StoreInfor> getList()
		{
			throw new NotImplementedException();
		}

		public StoreInfor getObject(string id)
		{
			throw new NotImplementedException();
		}
		public StoreInfor getObject()
		{
			StoreInfor infor = new StoreInfor();
			using (DataTable table = getTable())
			{
				if (table.Rows.Count < 1) return null;
				DataRow row = table.Rows[0];
				infor.name = row[0].ToString();
				infor.phoneNumber = row[1].ToString();
				infor.address = row[2].ToString();
				infor.website = row[3].ToString();
				return infor;
			}
		}

		public DataTable getTable()
		{
			return MyConnect.getTable("select * from StoreInformation");
		}

		public bool UpdateObject(StoreInfor o)
		{
			throw new NotImplementedException();
		}
	}
}
