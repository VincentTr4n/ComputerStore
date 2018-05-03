using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapLon_ComputerStore
{
	public class Customer
	{
		public string ID { get; set; }
		public string Name { get; set; }
		public string phoneNumber { get; set; }
		public string Address { get; set; }

		public string email { get; set; }
		public override string ToString()
		{
			return "Person [ID = " + ID + ", NAME = " + Name + ", ADDRESS = " + Address + ", Type = "+email+"]";
		}
	}
}
