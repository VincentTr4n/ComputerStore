using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyObject
{
	public class Products
	{
		public string productID { get; set; }
		public string productName { get; set; }
		public Types Type { get; set; }
		public Supplier supplier { get; set; }
		public int quantily { get; set; }
		public long purchasePrice { get; set; }
		public long productPrice { get; set; }
		public int warranty { get; set; }
		public Products() { }
		public Products(string id,string name,Types t,Supplier s,int q,long purchaseP,long productP,int w)
		{
			productID = id;
			productName = name;
			Type = t;
			supplier = s;
			quantily = q;
			purchasePrice = purchaseP;
			productPrice = productP;
			warranty = w;
		}
	}
}
