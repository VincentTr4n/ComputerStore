using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyObject
{
    public class Account
    {
        private string _username;
        private string _password; //Encrypted
        private string _email;
        private bool _service;
        
        public Account() { }
        public Account(string username,string password,bool service, string email)
        {
            _username = username;
            _password = password;
            _email = email;
            _service = service;
         }
        public string username { get { return _username; } set { _username = value; } }
        public string password { get { return _password; } set { _password = value; } }
        public string email { get { return _email; } set { _email = value; } }
        public bool service { get { return _service; } set { _service = value; } }
        public override string ToString()
        {
            return "Account [username = " + _username + ", password = " + _password + ", email = " + _email+ ", service = " + _service + " ]";
        }
    }
}
