using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Threading;
using System.ComponentModel;
using System.Globalization;

namespace MyClassesLibrary
{
    public class MyAction
    {
        public static string[] MyReader(string path)
        {
            return File.ReadAllLines(path);
        }
        public static void MyWriter(string[]a,string path)
        {
            using(StreamWriter writer = new StreamWriter(path))
            {
                foreach (string s in a)
                {
                    writer.WriteLine(s);
                }
            }
        }
        public static bool sendEmail(string toEmail,string code)
        {
            try
            {
				SmtpClient client = new SmtpClient
				{
					Host = ReadXML.GetString("MyResource.xml","setting/hostID"),
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    Credentials = new System.Net.NetworkCredential(ReadXML.GetString("MyResource.xml", "setting/Email"), ReadXML.GetString("MyResource.xml", "setting/Password")),
                    Timeout = 10000,
                };
                MailMessage mess = new MailMessage(ReadXML.GetString("MyResource.xml", "setting/Email"), toEmail, "Recover password", code);
                client.Send(mess);
            }
            catch
            {
                return false;
            }
            return true;
        }
		//
		//
		public static string AutoCreateID(string start)
		{
			Random r = new Random();
			int res = r.Next(1000, 99999);
			return start + res;
		}
		//
		// 
		public static string FormatMoney(string money,string location = "vn")
		{
			string last = "";
			if (location == "vn") last = " VND";
			if (location == "us") last = " USA";
			if (location == "en") last = " Pound";
			if (!String.IsNullOrEmpty(money)) return String.Format(CultureInfo.InvariantCulture, "{0:N0}", long.Parse(money)) + last ;
			return "0 VND";
		}
		//
		//
		public static string AutoIncreaseID(string start,string pre,int lenght)
		{
			StringBuilder buid = new StringBuilder();
			int size = Convert.ToInt16(pre.Substring(1, pre.Length - 1));
			int d = lenght - (size++).ToString().Length;
			buid.Append(start);
			for (int i = 0; i < d; i++) buid.Append("0");
			buid.Append(size.ToString());
			return buid.ToString();
		}
		//
		//
		public static IEnumerable<DateTime> GetAllDates(DateTime startingDate, DateTime endingDate)
		{
			List<DateTime> allDates = new List<DateTime>();

			for (DateTime i = startingDate; i <= endingDate; i = i.AddDays(1))
			{
				allDates.Add(i);
			}
			return allDates.AsReadOnly();
		}
	}
}
