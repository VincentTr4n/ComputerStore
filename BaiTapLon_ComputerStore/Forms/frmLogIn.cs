using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using System.Data.SqlClient;
using MaterialSkin;
using MyClassesLibrary;
using MyObject;
using DAOClassesLibrary;
using System.Threading;

namespace BaiTapLon_ComputerStore
{
    public partial class frmLogIn : MaterialSkin.Controls.MaterialForm
    {
        private bool select = true; //selcet text
        private bool username, email, password, confirompw;
        private string code = "";
        private string myEmail = "";
        AccountDAO ac = new AccountDAO();
        Account account;

		//Thread thread;
        public frmLogIn()
        {
            InitializeComponent();
            this.FormClosed += (o, e) => { Application.Exit(); };
			var skin = MaterialSkinManager.Instance;
			skin.AddFormToManage(this);
			skin.Theme = MaterialSkinManager.Themes.DARK;
			skin.ColorScheme = new ColorScheme(Primary.Green600, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
		}
		//
		//From load
        private void frmLogIn_Load(object sender, EventArgs e)
        {
            Screen s = Screen.PrimaryScreen;
            this.Left = (s.WorkingArea.Width - this.Width) / 2;
            this.Top = (s.WorkingArea.Height - this.Height) / 2;
            pnLogin.Visible = true;
            pnSignIn.Visible = false;
            btSignIn.Enabled = false;
            //Stop flickering
            typeof(Panel).InvokeMember("DoubleBuffered",
            BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
            null, pnLogin, new object[] { true });
            //Remember account
            if (!String.IsNullOrEmpty(Properties.Settings.Default.UserName) && !String.IsNullOrEmpty(Properties.Settings.Default.Password))
            {
                txUserName.Text = StringPassword.DecrytString(Properties.Settings.Default.UserName, Properties.Resources.KeyCrypt);
                txPassword.Text = StringPassword.DecrytString(Properties.Settings.Default.Password, Properties.Resources.KeyCrypt);
            }
			txUserName.AutoCompleteMode = AutoCompleteMode.Suggest;
			txUserName.AutoCompleteSource = AutoCompleteSource.CustomSource;
			setAutoCompleteCollection();
        }

		//Set Auto Complete Collection
		void setAutoCompleteCollection()
		{
			AutoCompleteStringCollection col = new AutoCompleteStringCollection();
			SqlDataReader reader = MyConnect.getReader("select * from get_all_user");
			while (reader.Read())
			{
				col.Add(reader.GetString(0));
			}
			txUserName.AutoCompleteCustomSource = col;
			if (!reader.IsClosed) reader.Close();
		}

        #region Panel log in
        //Mouse
        private void lbSignup_MouseLeave(object sender, EventArgs e)
        {
            var temp = sender as Label;
            temp.ForeColor = Color.Blue;
        }

        private void lbSignUp_MouseHover(object sender, EventArgs e)
        {
            var temp = sender as Label;
            temp.ForeColor = Color.White;
        }

        private void txUserName_Click(object sender, EventArgs e)
        {
            var myTextBox = sender as TextBox;
            if (select) { myTextBox.SelectAll(); select = false; } else select = true;
        }

        //Log in
        private void btLogin_Click(object sender, EventArgs e)
        {
            errorUserName.Icon = Properties.Resources.ERROR;
            errorPassword.Icon = Properties.Resources.ERROR;
            if (String.IsNullOrEmpty(txUserName.Text)) errorUserName.SetError(txUserName, "Please enter user name!!"); //check textbox username
            else errorUserName.SetError(txUserName, null);
            if (String.IsNullOrEmpty(txPassword.Text)) errorPassword.SetError(txPassword, "Please enter password!!"); //check textbox password
            else errorUserName.SetError(txPassword, null);
            if (!String.IsNullOrEmpty(txUserName.Text) && !String.IsNullOrEmpty(txPassword.Text))
                if (MyChecker.checkUserName(txUserName.Text) && MyChecker.checkPassword(txUserName.Text, txPassword.Text))
                {
                    MessageBox.Show("Log In successfully!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information); lbErrorLogIn.Visible = false;
                    if (cbRemember.Checked)
                    {
                        //save user name and password in setting file
                        string key = Properties.Resources.KeyCrypt;
                        Properties.Settings.Default.UserName = StringPassword.EncrytString(txUserName.Text, key);
                        Properties.Settings.Default.Password = StringPassword.EncrytString(txPassword.Text, key);
                        Properties.Settings.Default.Save();
                    }
                    //Useris accessing
                    Properties.Settings.Default.Accessing = txUserName.Text;
                    Properties.Settings.Default.Service = ac.getObject(txUserName.Text).service;
                    Properties.Settings.Default.Save();
					this.Hide();
					frmMain main = new frmMain();
					main.setUserAccessing("User is accessing : " + txUserName.Text);
					main.Show();
					
                }
                else lbErrorLogIn.Visible = true;

        }

		//private void OpenMainForm()
		//{
		//	frmMain main = new frmMain();
		//	main.setUserAccessing("User is accessing : " + txUserName.Text);
		//	Application.Run(main);
		//}

		//Sign In
		private void lbSignUp_Click(object sender, EventArgs e)
        {
            pnSignIn.Visible = true;
            pnForgetPw.Visible = false;
            reset();
            backToolStripMenuItem.Enabled = true;
			lbTitle.Text = "Sign In";
        }
        //Foget password
        private void lbForgetPassword_Click(object sender, EventArgs e)
        {
            backToolStripMenuItem.Enabled = true;
            pnForgetPw.Visible = true;
            pnSignIn.Visible = true;
            reset();
            txSendEmail.Focus();
            groupBox1.Visible = false;
			lbTitle.Text = "Change passowrd";
		}
        //TextChanged
        private void txUserName_TextChanged(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(txUserName.Text)) { MyChecker.setErr(txUserName, errorUserName, "Please enter username!", Properties.Resources.ERROR); lbErrorLogIn.Visible = false; }
            else errorUserName.Clear();
        }

        private void txPassword_TextChanged(object sender, EventArgs e)
        {
            errorPassword.Icon = Properties.Resources.ERROR;
            if (String.IsNullOrEmpty(txPassword.Text)) { MyChecker.setErr(txPassword, errorPassword, "Please enter password!", Properties.Resources.ERROR); lbErrorLogIn.Visible = false; }
            else errorPassword.Clear();
        }

        #endregion

        #region Panel sign in
        private void lbBack_Click(object sender, EventArgs e)
        {
            backToolStripMenuItem.Enabled = false;
            pnLogin.Visible = true;
            pnSignIn.Visible = false;
            pnForgetPw.Visible = false;
            reset();
			lbTitle.Text = "Log In";
		}

        //Mouse
        private void lbBack_MouseHover(object sender, EventArgs e)
        {
            lbBack.ForeColor = Color.DeepSkyBlue;
        }

        private void lbBack_MouseLeave(object sender, EventArgs e)
        {
            lbBack.ForeColor = Color.Blue;
        }
        //All empty
        private bool checkNotEmptyOrNull()
        {
            if (!String.IsNullOrEmpty(txNewUserName.Text) && !String.IsNullOrEmpty(txNewEmail.Text) && !String.IsNullOrEmpty(txNewPassword.Text) && !String.IsNullOrEmpty(txConfiromPw.Text)) return true;
            return false;
        }
        //TextChanged
        private void txNewUserName_TextChanged(object sender, EventArgs e)
        {
            btSignIn.Enabled = checkNotEmptyOrNull();
            if (String.IsNullOrEmpty(txNewUserName.Text)) { username = false; return; }
            else if (MyChecker.checkUserName(txNewUserName.Text)) { MyChecker.setErr(txNewUserName, errorUserName, "User name alreader exists!", Properties.Resources.ERROR); username = false; }
            else { MyChecker.setErr(txNewUserName, errorUserName, "Available!", Properties.Resources.OK); username = true; }
        }

        private void txNewEmail_TextChanged(object sender, EventArgs e)
        {
            var temp = sender as TextBox;
            btSignIn.Enabled = checkNotEmptyOrNull();
            if (String.IsNullOrEmpty(temp.Text)) { email = false; return; }
            else if (!MyChecker.isEmail(temp.Text)) { MyChecker.setErr(temp, errorEmail, "Email Invailable!", Properties.Resources.ERROR); email = false; }
            else { MyChecker.setErr(temp, errorEmail, "Available!", Properties.Resources.OK); email = true; }
        }

        private void txNewPassword_TextChanged(object sender, EventArgs e)
        {
            var temp = sender as TextboxPassword;
            btSignIn.Enabled = checkNotEmptyOrNull();
            if (String.IsNullOrEmpty(temp.Text)) { password = false; return; }
            else if (MyChecker.HaveUnicodeCharacter(temp.Text)) { MyChecker.setErr(temp, errorPassword, "Can't accept password with a unicode character. Please try again!!", Properties.Resources.ERROR); password = false; }
            else if (!MyChecker.isPassword(temp.Text)) { MyChecker.setErr(temp, errorPassword, "Password need a-z, A-Z, 0-9 and symbol for a stronger password!", Properties.Resources.ERROR); password = false; }
            else { MyChecker.setErr(temp, errorPassword, "Available!", Properties.Resources.OK); password = true; }

        }

        private void txConfiromPw_TextChanged(object sender, EventArgs e)
        {
            btSignIn.Enabled = checkNotEmptyOrNull();
            if (String.IsNullOrEmpty(txConfiromPw.Text)) { confirompw = false; return; }
            else if (txConfiromPw.Text.Equals(txNewPassword.Text) && !String.IsNullOrEmpty(txConfiromPw.Text)) { MyChecker.setErr(txConfiromPw, errorConfiromPw, "Available!", Properties.Resources.OK); confirompw = true; }
            else { MyChecker.setErr(txConfiromPw, errorConfiromPw, "Password do not match", Properties.Resources.ERROR); confirompw = false; }
        }

        //Create new account
        private void btSignIn_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(MyConnect.getString("select Email from LogIn where Email=N'" + txNewEmail.Text + "'"))) { MyChecker.setErr(txNewEmail, errorEmail, "Email Invailable!", Properties.Resources.ERROR); email = false; txNewEmail.Focus(); return; }
            if (!username) { txNewUserName.Focus(); return; }
            else if (!email) { txNewEmail.Focus(); return; }
            else if (!password) { txNewPassword.Focus(); return; }
            else if (!confirompw) { txConfiromPw.Focus(); return; }
            else
            {
                if (ac.AddObject(new Account(txNewUserName.Text, StringPassword.EncrytString(txNewPassword.Text, Properties.Resources.KeyCrypt),cbManager.Checked,txNewEmail.Text))) MessageBox.Show("Create new account successfully!");
                else MessageBox.Show("Can't create account!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				setAutoCompleteCollection();
            }

        }

        //Reset
        private void reset()
        {
            errorUserName.Clear();
            errorPassword.Clear();
            txNewEmail.Text = txNewPassword.Text = txNewUserName.Text = txConfiromPw.Text = txForgetPw.Text = txCode.Text = txReEnterPw.Text = txForgetPw.Text = txSendEmail.Text = "";
            txNewUserName.Focus();
            errorEmail.Clear();
            errorConfiromPw.Clear();
        }


        #endregion

        #region Panel forget password
        private void lbBack2_MouseLeave(object sender, EventArgs e)
        {
            lbBack2.ForeColor = Color.Blue;
        }

        private void txReEnterPw_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txReEnterPw.Text)) { confirompw = false; return; }
            else if (txReEnterPw.Text.Equals(txForgetPw.Text) && !String.IsNullOrEmpty(txReEnterPw.Text)) { MyChecker.setErr(txReEnterPw, errorConfiromPw, "Available!", Properties.Resources.OK); confirompw = true; }
            else { MyChecker.setErr(txReEnterPw, errorConfiromPw, "Password do not match", Properties.Resources.ERROR); confirompw = false; }
        }
        //Click
        private void btCheck_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txCode.Text) && !String.IsNullOrEmpty(code) && txCode.Text.Equals(code))
            {
                groupBox1.Visible = true;
                txForgetPw.Focus();
            }
            else { MessageBox.Show("Please check code again or your Email!", "Waring!", MessageBoxButtons.OK, MessageBoxIcon.Warning); if (String.IsNullOrEmpty(txSendEmail.Text)) txSendEmail.Focus(); else txCode.Focus(); }
        }

        private void btApply_Click(object sender, EventArgs e)
        {
            string key = StringPassword.RandomStringGenerator(10);
            account.password=StringPassword.EncrytString(txForgetPw.Text,Properties.Resources.KeyCrypt);
            if (ac.UpdateObject(account)) MessageBox.Show("Successfully!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("Please check password or email again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btSend_Click(object sender, EventArgs e)
        {
            code = StringPassword.RandomStringGenerator(6);
            account = (ac.getObject(ac.getUserName(txSendEmail.Text)));
            if (String.IsNullOrEmpty(txSendEmail.Text)) return;
            if (String.IsNullOrEmpty(account.username)) { MyChecker.setErr(txSendEmail, errorEmail, "Email is not available!", Properties.Resources.ERROR); txSendEmail.Focus(); }
            else if (MyAction.sendEmail(txSendEmail.Text, code)) { MessageBox.Show("If you don't received code, Please try send again!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information); myEmail = txSendEmail.Text; }
            else { MessageBox.Show("If you don't received code, Please try send again!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error); txSendEmail.Focus(); }
            groupBox1.Visible = false;
        }

        private void lbBack2_MouseHover(object sender, EventArgs e)
        {
            lbBack2.ForeColor = Color.DeepSkyBlue;
        }
        #endregion

        //Context menu strip
        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
            System.Diagnostics.Process.Start(Application.ExecutablePath, "/restart" + System.Diagnostics.Process.GetCurrentProcess().Id);
        }
    }
}
