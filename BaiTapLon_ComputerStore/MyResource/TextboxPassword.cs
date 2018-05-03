using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapLon_ComputerStore
{
    class TextboxPassword : TextBox
    {
        private bool check = true;
        private bool select = true;
        public Button btn { get; set; }
        public TextboxPassword()
        {
            ConfigurePasswordBox();
        }
        private void ConfigurePasswordBox()
        {
            btn = new Button();
            btn.Size = new Size(25, this.ClientSize.Height + 2);
            btn.Dock = DockStyle.Right;
            btn.Cursor = Cursors.Default;
            btn.FlatStyle = FlatStyle.Flat;
            btn.ForeColor = Color.Red;
            btn.Image = Properties.Resources.showPassword;
            btn.Enabled = false;
            btn.FlatAppearance.BorderSize = 0;
            btn.TabIndex = 999;
            btn.Click += btn_Click;
            btn.Enabled = false;
            this.Controls.Add(btn);
            
            SendMessage(this.Handle, 0xd3, (IntPtr)2, (IntPtr)(btn.Width << 16));

            //event handler
            this.TextChanged += (o , e) => { check = true; this.PasswordChar = '*'; if (String.IsNullOrEmpty(this.Text)) btn.Enabled = false; else btn.Enabled = true; };
            this.Click += (o , e) => { if (select) { this.SelectAll(); select = false; } else select = true; };
            
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wp, IntPtr lp);
        private void btn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.Text)) return;
            if (!check) { check = true; this.PasswordChar = '*'; }
            else { check = false; this.PasswordChar = '\0'; }
            this.Focus();
        }
    }
}
