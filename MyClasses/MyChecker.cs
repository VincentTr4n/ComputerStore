using MyClassesLibrary;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyClassesLibrary
{
    public class MyChecker
    {
        public static bool checkUserName(string username)
        {
            if (String.IsNullOrEmpty(username)) return false;
            string sql = "select UserName from LogIn where UserName=N'" + username +"'";
            if (String.IsNullOrEmpty(MyConnect.getString(sql))) return false;
            return true;
        }
        public static bool checkPassword(string username,string password)
        {
            string sql1 = "select Password from LogIn where UserName=N'" + username + "'";
            string key = ReadXML.GetString("MyResource.xml","setting/KeyCrypt");
            string s = StringPassword.DecrytString(MyConnect.getString(sql1),key);
            if (String.IsNullOrEmpty(s)) return false;
            if (s.Equals(password)) return true;
            return false;
        }
        public static bool isEmail(string email)
        {
            if(String.IsNullOrEmpty(email)) return false;
            return Regex.IsMatch(email, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
        }
        public static bool isPassword(string input)
        {
            int count = 0;
            if (Regex.IsMatch(input, "[\\d]")) count++;
            if (Regex.IsMatch(input, "[a-z]")) count++;
            if (Regex.IsMatch(input, "[A-Z]")) count++;
            if (Regex.IsMatch(input, @"[`!@#$%^&*()_+|\-=\\{}\[\]:"";'<>?,./]")) count++;
            if (count == 4) return Regex.IsMatch(input, @"[a-zA-Z0-9`!@#$%^&*()_+|\-=\\{}\[\]:"";'<>?,./]{8}");
            return false;
        }
        public static bool HaveUnicodeCharacter(string s)
        {
            for (int i = 0; i < s.Length; i++) if (Convert.ToInt16(s[i]) > 126) return true;
            return false;
        }
        public static void setErr(Control control, ErrorProvider err, string content, Icon ico)
        {
            err.Icon = ico;
            err.SetError(control, content);
        }
		public static bool checkPrimaryKey(string sql)
		{
			if (String.IsNullOrEmpty(MyConnect.getString(sql))) return true;
			return false;
		}
    }
}
