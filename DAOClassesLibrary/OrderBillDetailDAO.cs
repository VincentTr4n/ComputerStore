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
	public class OrderBillDetailDAO : IDAO<OrderBillDetail>
	{
		ProductDAO pd = new ProductDAO();
		public bool AddObject(OrderBillDetail o)
		{
			return MyConnect.MyExecuteQuery("insert into OrderDetail values('" + o.orderBill.orderID + "','" + o.product.productID + "'," + o.quantily + "," + o.price + "," + o.discount + ")");
		}
		public bool checkID(string id)
		{
			throw new NotImplementedException();
		}
		public bool checkID(string orderID, string productID)
		{
			return checkPrimaryKey("select ID_Product from Orderdetail where ID_Product='" + productID + "' and ID_Order='" + orderID + "'");
		}

		public bool DeleteObject(string id)
		{
			throw new NotImplementedException();
		}
		public bool DeleteObject(string orderID, string productID)
		{
			return MyConnect.MyExecuteQuery("delete from OrderDetail where ID_Order='" + orderID + "' and ID_Product='" + productID + "'");
		}

		public List<OrderBillDetail> getList()
		{
			throw new NotImplementedException();
		}
		public List<OrderBillDetail> getList(string id)
		{
			List<OrderBillDetail> mlist = new List<OrderBillDetail>();
			DataTable table = MyConnect.getTable("select * from show_orderDetail where ID_Order='" + id + "'");
			for (int i = 0; i < table.Rows.Count; i++)
			{
				DataRow row = table.Rows[i];
				OrderBillDetail detail = new OrderBillDetail();
				detail.orderBill = new OrderBillDAO().getObject(row[1].ToString());
				detail.product = pd.getObject(row[0].ToString());
				detail.quantily = Convert.ToInt16(row[3].ToString());
				detail.discount = Convert.ToInt16(row[4].ToString());
				detail.price = long.Parse(row[5].ToString());
				mlist.Add(detail);
			}
			MyConnect.Disconncet();
			return mlist;
		}

		public OrderBillDetail getObject(string id)
		{
			throw new NotImplementedException();
		}
		public OrderBillDetail getObject(string orderID, string productID)
		{
			System.Data.SqlClient.SqlDataReader reader = MyConnect.getReader("select * from show_orderDetail where ID_Order='" + orderID + "' and ID_Product='" + productID + "'");
			OrderBillDetail detail = new OrderBillDetail();
			detail.orderBill = new OrderBillDAO().getObject(reader.GetString(0));
			detail.product = new ProductDAO().getObject(reader.GetString(1));
			detail.quantily = Convert.ToInt16(reader[3].ToString());
			detail.discount = Convert.ToInt16(reader[4].ToString());
			detail.price = long.Parse(reader[5].ToString());
			reader.Close();
			MyConnect.Disconncet();
			return detail;
		}

		public DataTable getTable()
		{
			return MyConnect.getTable("select * from show_orderDetail");
		}
		public DataTable getTable(string id)
		{
			return MyConnect.getTable("select * from show_orderDetail where ID_Order='" + id + "'");
		}

		public bool UpdateObject(OrderBillDetail o)
		{
			return MyConnect.MyExecuteQuery("update OrderDetail set QuantityOrder=" + o.quantily + ",Discount=" + o.discount + " where ID_Order='" + o.orderBill.orderID + "' and ID_Product='" + o.product.productID + "'");
		}
		bool checkPrimaryKey(string sql)
		{
			if (String.IsNullOrEmpty(MyConnect.getString(sql))) return true;
			return false;
		}
	}
}
