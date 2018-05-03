using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MyClassesLibrary;
using DAOClassesLibrary;
using MyObject;

namespace BaiTapLon_ComputerStore
{
    public partial class Form1 : MaterialSkin.Controls.MaterialForm
    {
        AccountDAO ac = new AccountDAO();
		CustomerDAO cc = new CustomerDAO();
        public Form1()
        {
            InitializeComponent();
			
        }

        private void button1_Click(object sender, EventArgs e)
        {
			//Account account = ac.getAccount("cotyeyddca1");
			//MessageBox.Show(account.username + "--" + account.password + "--" + account.service + "--" + account.email);
			//Account account = (ac.getAccount(ac.getUserName("cotyeyddca1")));
			//MessageBox.Show(account.username + "--" + account.password + "--" + account.service + "--" + account.email);
			//string sql = "insert into Employee values(N'E00003',N'Nguyễn Văn B','"+DateTime.Now.ToShortDateString()+"', 1,N'Hà Nội',01696223412)";
			//         if (MyConnect.MyExecuteQuery(sql)) MessageBox.Show("OK");
			//         else MessageBox.Show("NO");
			//MyConnect.Connect();
			//if (MyConnect.MyExecuteQuery("execute insert_Suppliers @com = '" + textBox1.Text + "',@des='" + textBox2.Text + "',@head = '" + textBox3.Text + "'"))
			//	MessageBox.Show("OK");
			//else MessageBox.Show("NO");
			//textBox1.Text = textBox2.Text = textBox3.Text = "";
			Customer c = new Customer();
			c.ID = textBox1.Text;
			c.Name = textBox2.Text;
			c.phoneNumber = textBox3.Text;
			c.Address = textBox4.Text;
			//c.Typer = checkBox1.Checked;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.InitialDirectory = @"D:\";
            sfd.Filter = "Text file(*.txt)|*.txt |Word Document(*.doc)| *.doc | All files(*.*) | *.* ";
            sfd.DefaultExt = ".txt";
            sfd.AddExtension = true;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Stream s = File.Open(sfd.FileName, FileMode.CreateNew);
                StreamWriter writer = new StreamWriter(s);
                string temp = "";
                foreach(Employee emp in new EmployeeDAO().getList())
                {
                    temp = emp.Sex ? "Male" : "Female";
                    writer.WriteLine(emp.Id + " || " + emp.Name + " || " + emp.BirthDate + " || " + temp + " || " +emp.Address + " || " +emp.PhoneNumber);
                }
                writer.Close();
                s.Close(); 
            }


        }

		private void Form1_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'showEmloyees.show_Employee' table. You can move, or remove it, as needed.

			this.show_EmployeeTableAdapter.Fill(this.showEmloyees.show_Employee);
			comboBox1.DataSource = MyConnect.getTable("select * from Employee");
			comboBox1.DisplayMember = "Name_Emp";
			comboBox1.ValueMember = "ID_Emp";
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			var id = (DataRowView)comboBox1.SelectedItem;
			//MessageBox.Show(comboBox1.SelectedValue.ToString());
		}

		private void button3_Click(object sender, EventArgs e)
		{
			//MessageBox.Show(MyConnect.getString("select Quantity from Products where ID_Product='P0000000001'"));
			//DateTime d = DateTime.Parse("2/1/2017");
			//MessageBox.Show(d.AddDays(-10).ToString());
			string temp = SolveInput.StandardizedString("TrầN đỨc     cừ");
			MessageBox.Show(temp);
		}

		
		public static IEnumerable<DateTime> GetAllDatesAndInitializeTickets(DateTime startingDate, DateTime endingDate)
		{
			List<DateTime> allDates = new List<DateTime>();

			for (DateTime i = startingDate; i <= endingDate; i = i.AddDays(1))
			{
				allDates.Add(i);
			}
			return allDates.AsReadOnly();
		}

		private void Form1_FormClosed(object sender, FormClosedEventArgs e)
		{
			this.showEmployeeBindingSource.EndEdit();
		}
	}
}
