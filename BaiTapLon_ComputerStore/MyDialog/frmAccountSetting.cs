using DAOClassesLibrary;
using MyClassesLibrary;
using MyObject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapLon_ComputerStore
{
    public partial class frmAccountSetting : Form
    {
        private Account account;
        private bool show = true, curr, newpw, confirm;
        public frmAccountSetting()
        {
            InitializeComponent();
            //Text Change
            txChangeEmail.TextChanged += (o, e) =>
            {
                var temp = o as TextBox;
                if (!MyChecker.isEmail(temp.Text)) { MyChecker.setErr(temp, errorChangeEmail, "Email Invailable!", Properties.Resources.ERROR); return; }
                else { MyChecker.setErr(temp, errorChangeEmail, "Available!", Properties.Resources.OK); btChangeEmail.Enabled = true; }
            };
            //Button Click
            btChangeEmail.Click += (o, e) =>
            {
                frmEnterPassword frmPasswrod = new frmEnterPassword(btChangeEmail, txChangeEmail);
                frmPasswrod.ShowDialog();
            };
        }

        //Form load
        private void frmAccountSetting_Load(object sender, EventArgs e)
        {
            account = new AccountDAO().getObject(Properties.Settings.Default.Accessing);
            label1.Text = "User name : " + Properties.Settings.Default.Accessing;
            txChangeEmail.Text = account.email; 
            errorChangeEmail.Clear();
            btChangeEmail.Enabled = false;
            groupBox1.Visible = false;
        }
        //button edit
        private void button1_Click(object sender, EventArgs e)
        {
            if (show)
            {
                groupBox1.Visible = true;
                btEdit.Text = "Cancel";
                txCurrPassword.Focus();
                errorCur.Clear(); errorRe.Clear(); errorNew.Clear();
            }
            else
            {
                groupBox1.Visible = false;
                btEdit.Text = "Edit";
                txNewPassword.Text = txCurrPassword.Text = txConfirmPasswrod.Text = "";
            }
            show = !show;
        }
        //Text Change
        private void txCurrPassword_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txCurrPassword.Text)) { MyChecker.setErr(txCurrPassword, errorCur, "Enter your password", Properties.Resources.ERROR); curr = false; }
            else if (!txCurrPassword.Text.Equals(StringPassword.DecrytString(account.password, Properties.Resources.KeyCrypt))) { errorCur.Clear(); curr = false; }
            else { curr = true; errorCur.Clear(); }
        }

        private void txNewPassword_TextChanged(object sender, EventArgs e)
        {
            var temp = sender as TextboxPassword;
            if (String.IsNullOrEmpty(temp.Text)) { curr = false; }
            else if (MyChecker.HaveUnicodeCharacter(temp.Text)) { MyChecker.setErr(temp, errorNew, "Can't accept password with a unicode character. Please try again!!", Properties.Resources.ERROR); newpw = false; }
            else if (!MyChecker.isPassword(temp.Text)) { MyChecker.setErr(temp, errorNew, "Password need a-z, A-Z, 0-9 and symbol for a stronger password!", Properties.Resources.ERROR); newpw = false; }
            else { MyChecker.setErr(temp, errorNew, "Available!", Properties.Resources.OK); newpw = true; }
        }
        private void txConfirmPasswrod_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txConfirmPasswrod.Text)) { MyChecker.setErr(txConfirmPasswrod, errorRe, "Enter your password", Properties.Resources.ERROR); confirm = false; }
            else if (!txConfirmPasswrod.Text.Equals(txNewPassword.Text)) { MyChecker.setErr(txConfirmPasswrod, errorRe, "Password is not match!", Properties.Resources.ERROR); confirm = false; }
            else { MyChecker.setErr(txConfirmPasswrod, errorRe, "Available!", Properties.Resources.OK); confirm = true; }
        }
        //Button save
        private void btSaveShange_Click(object sender, EventArgs e)
        {
            if (!curr) { txCurrPassword.Focus(); MyChecker.setErr(txCurrPassword, errorCur, "Wrong passowrd!", Properties.Resources.ERROR); return; }
            if (!newpw) { txNewPassword.Focus(); return; }
            if (!confirm) { txConfirmPasswrod.Focus(); return; }
            account.password = StringPassword.EncrytString(txNewPassword.Text,Properties.Resources.KeyCrypt);
            if (new AccountDAO().UpdateObject(account)) MessageBox.Show("Password saved!", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("There was an error, can't save password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }
}
