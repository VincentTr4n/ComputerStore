using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using MyClassesLibrary;

namespace MyClassesLibrary
{
	public class MyConnect
	{
		public static SqlConnection con;
		public static void Connect()
		{
				con = new SqlConnection(ReadXML.GetString("MyConnect.xml","setting/connectionString"));
				con.Open();
		}
		public static void Disconncet()
		{
			try
			{
				if (con.State == ConnectionState.Open)
				{
					con.Close();
					con = null;
				}
			}
			catch
			{
				//con.Close();
				con = null;
			}
		}
		public static bool MyExecuteQuery(string sql)
		{
			MyConnect.Connect();
			using (SqlCommand cmd = new SqlCommand(sql, con))
			{
				try
				{

					cmd.ExecuteNonQuery();
				}
				catch
				{
					return false;
				}
				finally
				{
					MyConnect.Disconncet();
					cmd.Dispose();
				}
				return true;
			}
		}
		public static bool MyExecuteQuery(string sql, byte[] image)
		{
			MyConnect.Connect();
			using (SqlCommand cmd = new SqlCommand(sql, con))
			{
				try
				{
					if (image == null) cmd.Parameters.Add("@image", SqlDbType.Image).Value = DBNull.Value ;
					else cmd.Parameters.AddWithValue("@image", image);
					cmd.ExecuteNonQuery();
				}
				catch
				{
					return false;
				}
				finally
				{
					MyConnect.Disconncet();
					cmd.Dispose();
				}
				return true;
			}
		}
		public static string getString(string sql)
		{
			string s = null;
			MyConnect.Connect();
			using (SqlCommand cmd = new SqlCommand(sql, con))
			{
				using (SqlDataReader reader = cmd.ExecuteReader())
				{
					while (reader.Read())
					{
						s = reader[0].ToString();
					}
					MyConnect.Disconncet();
					cmd.Dispose();
					reader.Close();
					return s;
				}
			}
		}

		public static SqlDataReader getReader(string sql)
		{
			MyConnect.Connect();
			SqlCommand cmd = new SqlCommand(sql, con);
			SqlDataReader reader = cmd.ExecuteReader();
			return reader;
		}
		public static DataTable getTable(string strSelect)
		{
			DataTable table = new DataTable();
			MyConnect.Connect();
			SqlDataAdapter adapter = new SqlDataAdapter(strSelect, con);
			adapter.Fill(table);
			MyConnect.Disconncet();
			adapter.Dispose();
			return table;
		}
		public static string MyExecuteScalar(string sql)
		{
			MyConnect.Connect();
			SqlCommand cmd = new SqlCommand(sql, con);
			string s = cmd.ExecuteScalar().ToString();
			MyConnect.Disconncet();
			cmd.Dispose();
			return s;
		}

	}
}
