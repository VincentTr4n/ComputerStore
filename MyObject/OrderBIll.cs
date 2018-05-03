using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyObject
{
	public class OrderBIll
	{
		public string orderID { get; set; }
		public Customer customer { get; set; }
		public Employee employee { get; set; }
		public DateTime orderDate { get; set; }
		public int payType { get; set; }
		public long total { get; set; }
	}
}
