using DAOClassesLibrary;
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
	public class PurchaseDetailDAO : IDAO<PurchaseBillDetail>
	{
		public bool AddObject(PurchaseBillDetail o)
		{
			return MyConnect.MyExecuteQuery("insert into PurchaseDetail values('"+o.bill.purchaseID+"','"+o.product.productID+"',"+o.quantily+","+o.price+")");
		}

		public bool checkID(string id)
		{
			throw new NotImplementedException();
		}

		public bool DeleteObject(string id)
		{
			return MyConnect.MyExecuteQuery("delete from PurchaseDetail where ID_Product='"+id+"'");
		}
		//
		//Another method
		public bool DeleteObject(string purchase,string product)
		{
			return MyConnect.MyExecuteQuery("delete from PurchaseDetail where ID_Product='" + product + "' and ID_Purchase ='" + purchase + "'");
		}
		public List<PurchaseBillDetail> getList()
		{
			List<PurchaseBillDetail> mlist = new List<PurchaseBillDetail>();
			SqlDataReader reader = MyConnect.getReader("");
			while (reader.Read())
			{
				PurchaseBillDetail pd = new PurchaseBillDetail();
				pd.bill = new PurchaseBillDAO().getObject(reader.GetString(0));
				pd.product = new ProductDAO().getObject(reader.GetString(1));
				pd.quantily = Convert.ToInt16(reader[3]);
				pd.price = long.Parse(reader[4].ToString());
			}
			reader.Close();
			MyConnect.Disconncet();
			return mlist;
		}

		public List<PurchaseBillDetail> getList(string id)
		{
			List<PurchaseBillDetail> mlist = new List<PurchaseBillDetail>();
			SqlDataReader reader = MyConnect.getReader("select * from show_purshaseDetial where ID_Purchase='" + id + "'");
			while (reader.Read())
			{
				PurchaseBillDetail pd = new PurchaseBillDetail();
				pd.bill = new PurchaseBillDAO().getObject(reader.GetString(0));
				pd.product = new ProductDAO().getObject(reader.GetString(1));
				pd.quantily = Convert.ToInt16(reader[3]);
				pd.price = long.Parse(reader[4].ToString());
			}
			reader.Close();
			MyConnect.Disconncet();
			return mlist;
		}

		public PurchaseBillDetail getObject(string id)
		{
			PurchaseBillDetail pd = new PurchaseBillDetail();
			SqlDataReader reader = MyConnect.getReader("");
			while (reader.Read())
			{
				pd.bill = new PurchaseBillDAO().getObject(reader.GetString(0));
				pd.product = new ProductDAO().getObject(reader.GetString(1));
				pd.quantily = reader.GetInt16(2);
				pd.price = long.Parse(reader[3].ToString());
			}
			reader.Close();
			MyConnect.Disconncet();
			return pd;
		}


		public DataTable getTable()
		{
			return MyConnect.getTable("select * from show_purshaseDetial");
		}
		public DataTable getTable(string id)
		{
			return MyConnect.getTable("select * from show_purshaseDetial where ID_Purchase='"+id+"'");
		}

		public bool UpdateObject(PurchaseBillDetail o)
		{
			return MyConnect.MyExecuteQuery("update PurchaseDetail set QuantiyPurchase="+o.quantily+",Price="+o.price+ " where ID_Purchase ='"+o.bill.purchaseID+"' and ID_Product='"+o.product.productID+"'");
		}
		public PurchaseBillDetail getObject(string purchase,string product)
		{
			PurchaseBillDetail pd = new PurchaseBillDetail();
			SqlDataReader reader = MyConnect.getReader("select * from PurchaseDetail where ID_Purchase ='" + purchase + "' and ID_Product='" + product + "'");
			while (reader.Read())
			{
				pd.bill = new PurchaseBillDAO().getObject(reader.GetString(0));
				pd.product = new ProductDAO().getObject(reader.GetString(1));
				pd.quantily = reader.GetInt16(2);
				pd.price = long.Parse(reader[3].ToString());
			}
			reader.Close();
			MyConnect.Disconncet();
			return pd;
		}
	}
}
