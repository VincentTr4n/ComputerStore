using MyClassesLibrary;
using MyObject;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAOClassesLibrary
{
	public class ProductDAO : IDAO<Products>
	{
		public DataView dv { get; set; }
		public ProductDAO()
		{
			
		}
		//
		//Get list
		public List<Products> getList()
		{
			List<Products> mlist = new List<Products>();
			SqlDataReader reader = MyConnect.getReader("select * from get_products");
			while (reader.Read())
			{
				Products p = new Products();
				p.productID = reader.GetString(0);
				p.productName = reader.GetString(1);
				Types t = new Types();
				t.typeName= reader.GetString(2);
				p.Type = t;
				Supplier s = new Supplier();
				s.companyName = reader.GetString(3);
				p.supplier = s;
				p.quantily = Convert.ToInt16(reader[4]);
				p.purchasePrice = long.Parse(reader[5].ToString());
				p.productPrice = long.Parse(reader[6].ToString());
				p.warranty = Convert.ToInt16(reader[7]);
				mlist.Add(p);
			}
			reader.Close();
			MyConnect.Disconncet();
			return mlist;
		}

		//
		//Get a product
		public Products getObject(string id)
		{
			Products p = new Products();
			SqlDataReader reader = MyConnect.getReader("select * from  get_products where ID_Product = N'" + id + "'");
			while (reader.Read())
			{
				p.productID = reader.GetString(0);
				p.productName = reader.GetString(1);
				Types t = new Types();
				t.typeName = reader.GetString(2);
				p.Type = t;
				Supplier s = new Supplier();
				s.companyName = reader.GetString(3);
				p.supplier = s;
				p.quantily = Convert.ToInt16(reader[4]);
				p.purchasePrice = long.Parse(reader[5].ToString());
				p.productPrice = long.Parse(reader[6].ToString());
				p.warranty = Convert.ToInt16(reader[7]);
			}
			
			reader.Close();
			MyConnect.Disconncet();
			return p;
		}
		//
		//Get table
		public DataTable getTable()
		{
			return MyConnect.getTable("select * from  get_products");
		}
		public DataTable getTable(dynamic state)
		{
			if (state == EnumShowProduct.ShowWithName)
				return MyConnect.getTable("select ID_Product,Name_Pro from  get_products");
			if(state == EnumShowProduct.ShowReportQuantily)
				return MyConnect.getTable("select * from rptProductQuantily");
			return MyConnect.getTable("select * from  get_products");
		}
		public DataTable getTable(string typeShow)
		{
			return MyConnect.getTable("select * from  get_products where TypeName='"+typeShow+"'");
		}
		//
		//Auto create ID
		public string createProductID()
		{
			return MyConnect.MyExecuteScalar("select dbo.create_ProductID()");
		}
		//
		//Check valid ID
		public bool checkID(string id)
		{
			return checkPrimaryKey("select ID_Product from Products where ID_Product=N'" + id + "'");
		}
		//
		//Update data
		public bool UpdateObject(Products o)
		{
			return (MyConnect.MyExecuteQuery("execute update_Product @id=N'"+o.productID+"',@name=N'"+o.productName+"',@typename=N'"+o.Type.typeName+"',@company=N'"+o.supplier.companyName+"',@quantily="+o.quantily+",@purchase="+o.purchasePrice+",@price="+o.productPrice+",@warranty="+o.warranty+""));
		}
		//
		//Insert data
		public bool AddObject(Products o)
		{
			return (MyConnect.MyExecuteQuery("insert into Products values (N'" + o.productID + "',N'" + o.productName + "',N'" + o.Type.typeID + "',N'" + o.supplier.supplierID + "'," + o.quantily + "," + o.purchasePrice + "," + o.productPrice + "," + o.warranty + ")"));
		}
		//
		//Update Product ID in TEMP
		public void updateTEMP(string id)
		{
			MyConnect.MyExecuteQuery("update TEMP set ProductID_temp=N'" + id + "'");
		}
		//
		//Delete product
		public bool DeleteObject(string id)
		{
			return MyConnect.MyExecuteQuery("delete from Products where ID_Product=N'" + id + "'");
		}
		//
		//
		bool checkPrimaryKey(string sql)
		{
			if (String.IsNullOrEmpty(MyConnect.getString(sql))) return true;
			return false;
		}
	}
}
