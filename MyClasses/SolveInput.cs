using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MyClassesLibrary
{
	public class SolveInput
    {
        public static string StandardizedString(string str)
        {
            if (String.IsNullOrEmpty(str)) return "";
            str = Regex.Replace(str.ToLower().Trim(),@"\s+"," ",RegexOptions.None);
            string[] temp = str.Split(' ');
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < temp.Length; i++)
            {
                //str += String.valueOf(temp[i].charAt(0)).toUpperCase() + temp[i].Substring(1);
                sb.Append(char.ToUpper(temp[i][0]));
                sb.Append(temp[i].Substring(1));
                if (i < temp.Length - 1) sb.Append(" ");
            }
            return sb.ToString();
        }
    }
}
