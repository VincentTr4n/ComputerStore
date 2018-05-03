using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyObject
{
	public class PurchaseBill
	{
		public string purchaseID { get; set; }
		public Employee employee { get; set; }
		public DateTime purchaseDate { get; set; }
		public long totalPrice { get; set; }
	}
}
