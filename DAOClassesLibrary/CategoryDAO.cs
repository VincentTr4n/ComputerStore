using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using MyObject;
using DAOClassesLibrary;
using MyClassesLibrary;

namespace DAOClassesLibrary
{
	public class CategoryDAO : IDAO<Category>
	{
		public List<Category> getList()
		{
			List<Category> mlist = new List<Category>();
			SqlDataReader reader = MyConnect.getReader("select * from Categorys");
			while (reader.Read())
			{
				Category c = new Category();
				c.categoryID = Convert.ToInt16(reader[0]);
				c.categoryName = reader.GetString(1);
				mlist.Add(c);
			}
			reader.Close();
			MyConnect.Disconncet();
			return mlist;
		}

		public bool AddObject(Category o)
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

		public Category getObject(string id)
		{
			throw new NotImplementedException();
		}

		public DataTable getTable()
		{
			throw new NotImplementedException();
		}

		public bool UpdateObject(Category o)
		{
			throw new NotImplementedException();
		}
	}
}
