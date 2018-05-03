using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapLon_ComputerStore
{
	public class OrderBillDetail
	{
		public OrderBIll orderBill { get; set; }
		public Products product { get; set; }
		public int quantily { get; set; }
		public long price { get; set; }
		public double discount { get; set; }
		public long total
		{
			get { return long.Parse((quantily * price * (1 - discount / 100)).ToString()); }
		}
	}
}
