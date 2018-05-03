using DAOClassesLibrary;
using MyClassesLibrary;
using MyObject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapLon_ComputerStore
{
    public partial class frmEnterPassword : Form
    {
        private Account account;
        public frmEnterPassword(Button btChangeEmail, TextBox txChangeEmail)
        {
            InitializeComponent();
            txPassword.TextChanged += (o, e) =>
              {
                  if (!String.IsNullOrEmpty(txPassword.Text)) btOk.Enabled = true;
                  else { btOk.Enabled = false; MyChecker.setErr(txPassword, errorPassword, "Please enter password!", Properties.Resources.ERROR); }
              };
            btOk.Click += (o, e) =>
            {
                if (txPassword.Text.Equals(StringPassword.DecrytString(account.password,Properties.Resources.KeyCrypt)))
                {
                    account.email = txChangeEmail.Text;
                    if (new AccountDAO().UpdateObject(account)) MessageBox.Show("Successfully!", "Informaation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else MessageBox.Show("Error, Check your Email again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btChangeEmail.Enabled = false;
                    this.Close();
                }
                else MyChecker.setErr(txPassword, errorPassword, "Passwrod is not avalibale!", Properties.Resources.ERROR);
            };
        }

        private void frmEnterPassword_Load(object sender, EventArgs e)
        {
            account = new AccountDAO().getObject(Properties.Settings.Default.Accessing);
            txPassword.Focus();
        }
    }
}
