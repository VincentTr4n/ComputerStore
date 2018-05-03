using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapLon_ComputerStore
{
	public class PurchaseBillDetail
	{
		public Products product { get; set; }
		public PurchaseBill bill { get; set;}
		public int quantily { get; set; }
		public long price { get; set; }
		public long total
		{
			get { return quantily * price; }
		}
	}
}
