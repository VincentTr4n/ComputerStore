using DAOClassesLibrary;
using MyClassesLibrary;
using MyObject;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAOClassesLibrary
{
	public class EmployeeDAO : IDAO<Employee>
    {
        //Get list emp
        public List<Employee> getList()
        {
            List<Employee> mList = new List<Employee>();
            try
            {
                SqlDataReader reader =  MyConnect.getReader("select * from Employee");
                while (reader.Read())
                {
					Image image = null;
					if (!reader.IsDBNull(6)) image = ImageSQL.ByteArrayToImage((byte[])reader[6]);
                    Employee e = new Employee(reader.GetString(0), reader.GetString(1),reader.GetDateTime(2),reader.GetBoolean(3),reader.GetString(4),long.Parse(reader.GetInt64(5).ToString()),image);
                    mList.Add(e);
                }

				MyConnect.Disconncet();
				reader.Close();
            }
            catch { return null; }
            return mList;
        }
		//
		//Get table
		public System.Data.DataTable getTable()
		{
			return MyConnect.getTable("select * from show_Employee");
		}
		public System.Data.DataTable getTable(int month,int year)
		{
			return MyConnect.getTable("exec ReportEmployees @month="+month+",@year="+year);
		}

		//Delete emp
		public bool DeleteEmp(string id)
        {
            return MyConnect.MyExecuteQuery("delete from Employee where ID_Emp=N'"+id+"'");
        }

		public bool AddObject(Employee o)
		{
			byte[] image = o.EmpImage==null?null: ImageSQL.ImageToByteArray(o.EmpImage);
			return MyConnect.MyExecuteQuery("insert into Employee values(N'" + o.Id + "',N'" + SolveInput.StandardizedString(o.Name) + "','" + o.BirthDate.ToString("yyyy-MM-dd") + "'," + (o.Sex ? 1 : 0) + ",N'" + o.Address + "'," + o.PhoneNumber + ",@image)", image);
		}

		public bool UpdateObject(Employee o)
		{
			byte[] image = o.EmpImage == null ? null : ImageSQL.ImageToByteArray(o.EmpImage);
			return MyConnect.MyExecuteQuery("update Employee set Name_Emp=N'" + SolveInput.StandardizedString(o.Name) + "',BirthDate='" + o.BirthDate.ToString("yyyy-MM-dd") + "',Sex=" + (o.Sex ? 1 : 0) + ",Address=N'" + o.Address + "',PhoneNumber=" + o.PhoneNumber + ",EmpImage=@image where ID_Emp=N'" + o.Id + "'",image);
		}

		public bool DeleteObject(string id)
		{
			return MyConnect.MyExecuteQuery("delete from Employee where ID_Emp=N'" + id + "'");
		}

		public Employee getObject(string id)
		{
			Employee e = new Employee();
			SqlDataReader reader = MyConnect.getReader("select * from Employee where ID_Emp=N'" + id + "'");
			while (reader.Read())
			{
				Image image = null;
				if(!reader.IsDBNull(6)) image = ImageSQL.ByteArrayToImage((byte[])reader[6]);
				e = new Employee(reader.GetString(0), reader.GetString(1), reader.GetDateTime(2), reader.GetBoolean(3), reader.GetString(4), long.Parse(reader.GetInt64(5).ToString()),image);
			}
			reader.Close();
			return e;
		}

		public bool checkID(string id)
		{
			return !String.IsNullOrEmpty(MyConnect.getString("select ID_Emp from Employee where ID_Emp=N'" + id + "'"));
		}
		public string QuantilyProductSold(string id,int month,int year)
		{
			string res = MyConnect.MyExecuteScalar("select dbo.QP_Emp('" + id + "'," + month + "," + year + ")");
			return String.IsNullOrEmpty(res) ? "0" : res ;
		}
		public string ProseedsOfSale(string id, int month, int year)
		{
			string res = MyConnect.MyExecuteScalar("select dbo.POS_Emp('" + id + "'," + month + "," + year + ")");
			return String.IsNullOrEmpty(res) ? "0" : res ;
		}
		public string EmployeeIdMax()
		{
			DataTable table = getTable();
			string max = table.Rows[table.Rows.Count - 1][0].ToString();
			return max;
		}
	}
}
