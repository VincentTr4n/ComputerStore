using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapLon_ComputerStore
{
	public class Employee 
    {
        string _id;
        string _name;
        DateTime _birtheDate;
        bool _sex;
        string _address;
        long _phonenumber;
		Image _image;

        public Employee() { }
        public Employee(string id,string name,DateTime birtheDaate,bool sex,string address,long phonenumber,Image image)
        {
            _id = id; _name = name; _birtheDate = birtheDaate; _sex = sex; _address = address; _phonenumber = phonenumber; _image = image;
        }

        public string Id { get { return _id; } set { _id = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        public DateTime BirthDate { get { return _birtheDate; } set { _birtheDate = value; } }
        public bool Sex { get { return _sex; } set { _sex = value; } }
        public string Address { get { return _address; } set { _address = value; } }
        public long PhoneNumber { get { return _phonenumber; } set { _phonenumber = value; } }
		public Image EmpImage { get { return _image ; } set { _image = value; } }

		public override string ToString()
        {
            return "Employee [ID = "+_id+", NAME = "+_name+", BIRTHDATE = "+_birtheDate+", SEX = "+_sex+", ADDRESS = "+_address+"]";
        }
    }
}
