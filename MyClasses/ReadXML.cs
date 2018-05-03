using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace MyClassesLibrary
{
	public class ReadXML
	{
		public static string GetString(string fileName,string node)
		{
			XmlDocument xml = new XmlDocument();
			xml.Load(fileName);
			return xml.SelectSingleNode(node).InnerText;
		}
	}
}
