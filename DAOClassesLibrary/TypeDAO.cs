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
	public class TypeDAO : IDAO<Types>
	{
		public bool AddObject(Types o)
		{
			throw new NotImplementedException();
		}

		public bool checkID(string id)
		{
			return !String.IsNullOrEmpty(MyConnect.getString("select ID_Type from ProductTypes where ID_Type ='" + id+"'"));
		}

		public bool DeleteObject(string id)
		{
			throw new NotImplementedException();
		}

		public List<Types> getList()
		{
			List<Types> mlist = new List<Types>();
			SqlDataReader reader =  MyConnect.getReader("select * from ProductTypes");
			while (reader.Read())
			{
				Types temp = new Types();
				temp.typeID = reader.GetString(0);
				temp.typeName = reader.GetString(1);
				temp.Description = reader.GetString(2);
				Category c = new Category();
				c.categoryID = Convert.ToInt16(reader[3]);
				mlist.Add(temp);
			}
			reader.Close();
			MyConnect.Disconncet();
			return mlist;
		}
		public List<Types> getList(int id)
		{
			List<Types> mlist = new List<Types>();
			SqlDataReader reader = MyConnect.getReader("execute get_typesOnCategory @categoryID = "+id+"");
			while (reader.Read())
			{
				Types temp = new Types();
				temp.typeID = reader.GetString(0);
				temp.typeName = reader.GetString(1);
				temp.Description = reader.GetString(2);
				Category c = new Category();
				c.categoryID = Convert.ToInt16(reader[3]);
				temp.category = c;
				mlist.Add(temp);
			}
			reader.Close();
			MyConnect.Disconncet();
			return mlist;
		}
		public string getName(string id)
		{
			return MyConnect.MyExecuteScalar("select dbo.get_TypeName('"+id+"')");
		}

		public Types getObject(string id)
		{
			Types temp = new Types();
			SqlDataReader reader = MyConnect.getReader("select * from ProductTypes where ID_Type = '"+id+"'");
			while (reader.Read())
			{
				temp.typeID = reader.GetString(0);
				temp.typeName = reader.GetString(1);
				temp.Description = reader.GetString(2);
				Category c = new Category();
				c.categoryID = Convert.ToInt16(reader[3]);
			}
			reader.Close();
			MyConnect.Disconncet();

			return temp;
		}

		public DataTable getTable()
		{
			return MyConnect.getTable("select * from ProductTypes");
		}

		public bool UpdateObject(Types o)
		{
			throw new NotImplementedException();
		}
	}
}
