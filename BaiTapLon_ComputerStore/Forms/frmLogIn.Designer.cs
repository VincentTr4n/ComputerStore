using System.Drawing;
using System.Windows.Forms;

namespace BaiTapLon_ComputerStore
{
    partial class frmLogIn
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogIn));
			this.myToolTop = new System.Windows.Forms.ToolTip(this.components);
			this.cbManager = new System.Windows.Forms.CheckBox();
			this.txNewEmail = new System.Windows.Forms.TextBox();
			this.txNewUserName = new System.Windows.Forms.TextBox();
			this.txUserName = new System.Windows.Forms.TextBox();
			this.txConfiromPw = new BaiTapLon_ComputerStore.TextboxPassword();
			this.txNewPassword = new BaiTapLon_ComputerStore.TextboxPassword();
			this.txPassword = new BaiTapLon_ComputerStore.TextboxPassword();
			this.errorUserName = new System.Windows.Forms.ErrorProvider(this.components);
			this.pnLogin = new System.Windows.Forms.Panel();
			this.ctmLogIn = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pnSignIn = new System.Windows.Forms.Panel();
			this.pnForgetPw = new System.Windows.Forms.Panel();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btApply = new System.Windows.Forms.Button();
			this.txReEnterPw = new BaiTapLon_ComputerStore.TextboxPassword();
			this.label14 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.txForgetPw = new BaiTapLon_ComputerStore.TextboxPassword();
			this.btCheck = new System.Windows.Forms.Button();
			this.txCode = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.btSend = new System.Windows.Forms.Button();
			this.txSendEmail = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.lbBack2 = new System.Windows.Forms.Label();
			this.btSignIn = new System.Windows.Forms.Button();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.lbBack = new System.Windows.Forms.Label();
			this.lbForgetPassword = new System.Windows.Forms.Label();
			this.lbErrorLogIn = new System.Windows.Forms.Label();
			this.lbSignIn = new System.Windows.Forms.Label();
			this.btLogin = new System.Windows.Forms.Button();
			this.cbRemember = new System.Windows.Forms.CheckBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.errorPassword = new System.Windows.Forms.ErrorProvider(this.components);
			this.errorConfiromPw = new System.Windows.Forms.ErrorProvider(this.components);
			this.errorEmail = new System.Windows.Forms.ErrorProvider(this.components);
			this.lbTitle = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.errorUserName)).BeginInit();
			this.pnLogin.SuspendLayout();
			this.ctmLogIn.SuspendLayout();
			this.pnSignIn.SuspendLayout();
			this.pnForgetPw.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorPassword)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorConfiromPw)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorEmail)).BeginInit();
			this.SuspendLayout();
			// 
			// myToolTop
			// 
			this.myToolTop.AutomaticDelay = 1;
			this.myToolTop.AutoPopDelay = 1000;
			this.myToolTop.InitialDelay = 1;
			this.myToolTop.ReshowDelay = 0;
			// 
			// cbManager
			// 
			this.cbManager.AutoSize = true;
			this.cbManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbManager.ForeColor = System.Drawing.Color.White;
			this.cbManager.Location = new System.Drawing.Point(215, 257);
			this.cbManager.Name = "cbManager";
			this.cbManager.Size = new System.Drawing.Size(68, 17);
			this.cbManager.TabIndex = 18;
			this.cbManager.Text = "Manager";
			this.myToolTop.SetToolTip(this.cbManager, "Are you a manager?");
			this.cbManager.UseVisualStyleBackColor = true;
			// 
			// txNewEmail
			// 
			this.txNewEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txNewEmail.Location = new System.Drawing.Point(138, 102);
			this.txNewEmail.Name = "txNewEmail";
			this.txNewEmail.Size = new System.Drawing.Size(292, 26);
			this.txNewEmail.TabIndex = 8;
			this.myToolTop.SetToolTip(this.txNewEmail, "Format Email abc@xxx.xxx");
			this.txNewEmail.Click += new System.EventHandler(this.txUserName_Click);
			this.txNewEmail.TextChanged += new System.EventHandler(this.txNewEmail_TextChanged);
			// 
			// txNewUserName
			// 
			this.txNewUserName.AutoCompleteCustomSource.AddRange(new string[] {
            "cotyeyddca1",
            "cotyey",
            "cotyeydd",
            "cotyeyddca",
            "coty",
            "cotye"});
			this.txNewUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txNewUserName.Location = new System.Drawing.Point(138, 44);
			this.txNewUserName.Name = "txNewUserName";
			this.txNewUserName.Size = new System.Drawing.Size(292, 26);
			this.txNewUserName.TabIndex = 7;
			this.myToolTop.SetToolTip(this.txNewUserName, "Enter new user name");
			this.txNewUserName.Click += new System.EventHandler(this.txUserName_Click);
			this.txNewUserName.TextChanged += new System.EventHandler(this.txNewUserName_TextChanged);
			// 
			// txUserName
			// 
			this.txUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txUserName.Location = new System.Drawing.Point(223, 123);
			this.txUserName.Name = "txUserName";
			this.txUserName.Size = new System.Drawing.Size(267, 26);
			this.txUserName.TabIndex = 4;
			this.myToolTop.SetToolTip(this.txUserName, "Enter user name");
			this.txUserName.Click += new System.EventHandler(this.txUserName_Click);
			this.txUserName.TextChanged += new System.EventHandler(this.txUserName_TextChanged);
			// 
			// txConfiromPw
			// 
			this.txConfiromPw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txConfiromPw.Location = new System.Drawing.Point(138, 213);
			this.txConfiromPw.Name = "txConfiromPw";
			this.txConfiromPw.PasswordChar = '*';
			this.txConfiromPw.Size = new System.Drawing.Size(292, 26);
			this.txConfiromPw.TabIndex = 10;
			this.myToolTop.SetToolTip(this.txConfiromPw, "Re-enter password");
			this.txConfiromPw.Click += new System.EventHandler(this.txUserName_Click);
			this.txConfiromPw.TextChanged += new System.EventHandler(this.txConfiromPw_TextChanged);
			// 
			// txNewPassword
			// 
			this.txNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txNewPassword.Location = new System.Drawing.Point(138, 159);
			this.txNewPassword.Name = "txNewPassword";
			this.txNewPassword.PasswordChar = '*';
			this.txNewPassword.Size = new System.Drawing.Size(292, 26);
			this.txNewPassword.TabIndex = 9;
			this.myToolTop.SetToolTip(this.txNewPassword, "Password need a-z, A-Z, 0-9 , Symbol and contain at least 8 characters");
			this.txNewPassword.Click += new System.EventHandler(this.txUserName_Click);
			this.txNewPassword.TextChanged += new System.EventHandler(this.txNewPassword_TextChanged);
			// 
			// txPassword
			// 
			this.txPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txPassword.Location = new System.Drawing.Point(223, 161);
			this.txPassword.Name = "txPassword";
			this.txPassword.PasswordChar = '*';
			this.txPassword.Size = new System.Drawing.Size(267, 26);
			this.txPassword.TabIndex = 5;
			this.myToolTop.SetToolTip(this.txPassword, "Enter password");
			this.txPassword.TextChanged += new System.EventHandler(this.txPassword_TextChanged);
			// 
			// errorUserName
			// 
			this.errorUserName.BlinkRate = 1;
			this.errorUserName.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
			this.errorUserName.ContainerControl = this;
			// 
			// pnLogin
			// 
			this.pnLogin.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.pnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pnLogin.ContextMenuStrip = this.ctmLogIn;
			this.pnLogin.Controls.Add(this.pnSignIn);
			this.pnLogin.Controls.Add(this.lbForgetPassword);
			this.pnLogin.Controls.Add(this.lbErrorLogIn);
			this.pnLogin.Controls.Add(this.lbSignIn);
			this.pnLogin.Controls.Add(this.btLogin);
			this.pnLogin.Controls.Add(this.cbRemember);
			this.pnLogin.Controls.Add(this.txPassword);
			this.pnLogin.Controls.Add(this.txUserName);
			this.pnLogin.Controls.Add(this.label4);
			this.pnLogin.Controls.Add(this.label3);
			this.pnLogin.Controls.Add(this.label1);
			this.pnLogin.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.pnLogin.Location = new System.Drawing.Point(0, 63);
			this.pnLogin.Name = "pnLogin";
			this.pnLogin.Size = new System.Drawing.Size(589, 308);
			this.pnLogin.TabIndex = 0;
			// 
			// ctmLogIn
			// 
			this.ctmLogIn.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetToolStripMenuItem,
            this.backToolStripMenuItem});
			this.ctmLogIn.Name = "ctmLogIn";
			this.ctmLogIn.Size = new System.Drawing.Size(103, 48);
			// 
			// resetToolStripMenuItem
			// 
			this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
			this.resetToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
			this.resetToolStripMenuItem.Text = "Reset";
			this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
			// 
			// backToolStripMenuItem
			// 
			this.backToolStripMenuItem.Name = "backToolStripMenuItem";
			this.backToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
			this.backToolStripMenuItem.Text = "Back";
			this.backToolStripMenuItem.Click += new System.EventHandler(this.lbBack_Click);
			// 
			// pnSignIn
			// 
			this.pnSignIn.BackColor = System.Drawing.Color.SlateGray;
			this.pnSignIn.ContextMenuStrip = this.ctmLogIn;
			this.pnSignIn.Controls.Add(this.pnForgetPw);
			this.pnSignIn.Controls.Add(this.btSignIn);
			this.pnSignIn.Controls.Add(this.cbManager);
			this.pnSignIn.Controls.Add(this.txConfiromPw);
			this.pnSignIn.Controls.Add(this.txNewPassword);
			this.pnSignIn.Controls.Add(this.txNewEmail);
			this.pnSignIn.Controls.Add(this.txNewUserName);
			this.pnSignIn.Controls.Add(this.label10);
			this.pnSignIn.Controls.Add(this.label9);
			this.pnSignIn.Controls.Add(this.label8);
			this.pnSignIn.Controls.Add(this.label7);
			this.pnSignIn.Controls.Add(this.label6);
			this.pnSignIn.Controls.Add(this.lbBack);
			this.pnSignIn.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnSignIn.Location = new System.Drawing.Point(0, 0);
			this.pnSignIn.Name = "pnSignIn";
			this.pnSignIn.Size = new System.Drawing.Size(589, 308);
			this.pnSignIn.TabIndex = 15;
			this.pnSignIn.TabStop = true;
			// 
			// pnForgetPw
			// 
			this.pnForgetPw.BackColor = System.Drawing.Color.SlateGray;
			this.pnForgetPw.ContextMenuStrip = this.ctmLogIn;
			this.pnForgetPw.Controls.Add(this.groupBox1);
			this.pnForgetPw.Controls.Add(this.btCheck);
			this.pnForgetPw.Controls.Add(this.txCode);
			this.pnForgetPw.Controls.Add(this.label12);
			this.pnForgetPw.Controls.Add(this.btSend);
			this.pnForgetPw.Controls.Add(this.txSendEmail);
			this.pnForgetPw.Controls.Add(this.label11);
			this.pnForgetPw.Controls.Add(this.lbBack2);
			this.pnForgetPw.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnForgetPw.Location = new System.Drawing.Point(0, 0);
			this.pnForgetPw.Name = "pnForgetPw";
			this.pnForgetPw.Size = new System.Drawing.Size(589, 308);
			this.pnForgetPw.TabIndex = 13;
			this.pnForgetPw.MouseLeave += new System.EventHandler(this.lbBack_MouseLeave);
			this.pnForgetPw.MouseHover += new System.EventHandler(this.lbBack_MouseHover);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btApply);
			this.groupBox1.Controls.Add(this.txReEnterPw);
			this.groupBox1.Controls.Add(this.label14);
			this.groupBox1.Controls.Add(this.label13);
			this.groupBox1.Controls.Add(this.txForgetPw);
			this.groupBox1.Location = new System.Drawing.Point(70, 103);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(459, 151);
			this.groupBox1.TabIndex = 7;
			this.groupBox1.TabStop = false;
			// 
			// btApply
			// 
			this.btApply.BackColor = System.Drawing.Color.Blue;
			this.btApply.ForeColor = System.Drawing.Color.White;
			this.btApply.Location = new System.Drawing.Point(358, 112);
			this.btApply.Name = "btApply";
			this.btApply.Size = new System.Drawing.Size(75, 26);
			this.btApply.TabIndex = 8;
			this.btApply.Text = "Apply";
			this.btApply.UseVisualStyleBackColor = false;
			this.btApply.Click += new System.EventHandler(this.btApply_Click);
			// 
			// txReEnterPw
			// 
			this.txReEnterPw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txReEnterPw.Location = new System.Drawing.Point(40, 111);
			this.txReEnterPw.Name = "txReEnterPw";
			this.txReEnterPw.PasswordChar = '*';
			this.txReEnterPw.Size = new System.Drawing.Size(228, 26);
			this.txReEnterPw.TabIndex = 28;
			this.txReEnterPw.TextChanged += new System.EventHandler(this.txReEnterPw_TextChanged);
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.ForeColor = System.Drawing.Color.White;
			this.label14.Location = new System.Drawing.Point(37, 90);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(117, 15);
			this.label14.TabIndex = 6;
			this.label14.Text = "Re-enter password :";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.ForeColor = System.Drawing.Color.White;
			this.label13.Location = new System.Drawing.Point(37, 32);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(94, 15);
			this.label13.TabIndex = 5;
			this.label13.Text = "New password :";
			// 
			// txForgetPw
			// 
			this.txForgetPw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txForgetPw.Location = new System.Drawing.Point(40, 52);
			this.txForgetPw.Name = "txForgetPw";
			this.txForgetPw.PasswordChar = '*';
			this.txForgetPw.Size = new System.Drawing.Size(228, 26);
			this.txForgetPw.TabIndex = 27;
			this.txForgetPw.TextChanged += new System.EventHandler(this.txNewPassword_TextChanged);
			// 
			// btCheck
			// 
			this.btCheck.BackColor = System.Drawing.Color.Blue;
			this.btCheck.ForeColor = System.Drawing.Color.White;
			this.btCheck.Location = new System.Drawing.Point(361, 71);
			this.btCheck.Name = "btCheck";
			this.btCheck.Size = new System.Drawing.Size(75, 26);
			this.btCheck.TabIndex = 6;
			this.btCheck.Text = "Check";
			this.btCheck.UseVisualStyleBackColor = false;
			this.btCheck.Click += new System.EventHandler(this.btCheck_Click);
			// 
			// txCode
			// 
			this.txCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txCode.Location = new System.Drawing.Point(168, 70);
			this.txCode.Name = "txCode";
			this.txCode.Size = new System.Drawing.Size(140, 26);
			this.txCode.TabIndex = 26;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.ForeColor = System.Drawing.Color.White;
			this.label12.Location = new System.Drawing.Point(77, 76);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(72, 15);
			this.label12.TabIndex = 4;
			this.label12.Text = "Enter code :";
			// 
			// btSend
			// 
			this.btSend.BackColor = System.Drawing.Color.Blue;
			this.btSend.ForeColor = System.Drawing.Color.White;
			this.btSend.Location = new System.Drawing.Point(444, 33);
			this.btSend.Name = "btSend";
			this.btSend.Size = new System.Drawing.Size(75, 26);
			this.btSend.TabIndex = 3;
			this.btSend.Text = "Send";
			this.btSend.UseVisualStyleBackColor = false;
			this.btSend.Click += new System.EventHandler(this.btSend_Click);
			// 
			// txSendEmail
			// 
			this.txSendEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txSendEmail.Location = new System.Drawing.Point(82, 33);
			this.txSendEmail.Name = "txSendEmail";
			this.txSendEmail.Size = new System.Drawing.Size(318, 26);
			this.txSendEmail.TabIndex = 25;
			this.txSendEmail.TabStop = false;
			this.txSendEmail.TextChanged += new System.EventHandler(this.txNewEmail_TextChanged);
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.ForeColor = System.Drawing.Color.White;
			this.label11.Location = new System.Drawing.Point(79, 9);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(72, 15);
			this.label11.TabIndex = 1;
			this.label11.Text = "Your email :";
			// 
			// lbBack2
			// 
			this.lbBack2.AutoSize = true;
			this.lbBack2.BackColor = System.Drawing.Color.Transparent;
			this.lbBack2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lbBack2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbBack2.ForeColor = System.Drawing.Color.Blue;
			this.lbBack2.Location = new System.Drawing.Point(8, 275);
			this.lbBack2.Name = "lbBack2";
			this.lbBack2.Size = new System.Drawing.Size(51, 24);
			this.lbBack2.TabIndex = 0;
			this.lbBack2.Text = "Back";
			this.lbBack2.Click += new System.EventHandler(this.lbBack_Click);
			this.lbBack2.MouseLeave += new System.EventHandler(this.lbBack2_MouseLeave);
			this.lbBack2.MouseHover += new System.EventHandler(this.lbBack2_MouseHover);
			// 
			// btSignIn
			// 
			this.btSignIn.BackColor = System.Drawing.Color.DodgerBlue;
			this.btSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btSignIn.ForeColor = System.Drawing.Color.White;
			this.btSignIn.Location = new System.Drawing.Point(458, 263);
			this.btSignIn.Name = "btSignIn";
			this.btSignIn.Size = new System.Drawing.Size(119, 36);
			this.btSignIn.TabIndex = 12;
			this.btSignIn.Text = "Create account";
			this.btSignIn.UseVisualStyleBackColor = false;
			this.btSignIn.Click += new System.EventHandler(this.btSignIn_Click);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.ForeColor = System.Drawing.Color.White;
			this.label10.Location = new System.Drawing.Point(135, 257);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(52, 13);
			this.label10.TabIndex = 6;
			this.label10.Text = "Service : ";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.ForeColor = System.Drawing.Color.White;
			this.label9.Location = new System.Drawing.Point(135, 197);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(102, 13);
			this.label9.TabIndex = 5;
			this.label9.Text = "Confirom password :";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.Color.White;
			this.label8.Location = new System.Drawing.Point(135, 86);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(38, 13);
			this.label8.TabIndex = 4;
			this.label8.Text = "Email :";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.White;
			this.label7.Location = new System.Drawing.Point(135, 143);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(59, 13);
			this.label7.TabIndex = 3;
			this.label7.Text = "Password :";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.White;
			this.label6.Location = new System.Drawing.Point(135, 28);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(64, 13);
			this.label6.TabIndex = 2;
			this.label6.Text = "User name :";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbBack
			// 
			this.lbBack.AutoSize = true;
			this.lbBack.BackColor = System.Drawing.Color.Transparent;
			this.lbBack.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lbBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbBack.ForeColor = System.Drawing.Color.Blue;
			this.lbBack.Location = new System.Drawing.Point(13, 275);
			this.lbBack.Name = "lbBack";
			this.lbBack.Size = new System.Drawing.Size(51, 24);
			this.lbBack.TabIndex = 0;
			this.lbBack.Text = "Back";
			this.lbBack.Click += new System.EventHandler(this.lbBack_Click);
			this.lbBack.MouseLeave += new System.EventHandler(this.lbBack_MouseLeave);
			this.lbBack.MouseHover += new System.EventHandler(this.lbBack_MouseHover);
			// 
			// lbForgetPassword
			// 
			this.lbForgetPassword.AutoSize = true;
			this.lbForgetPassword.BackColor = System.Drawing.Color.Transparent;
			this.lbForgetPassword.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lbForgetPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbForgetPassword.ForeColor = System.Drawing.Color.Blue;
			this.lbForgetPassword.Location = new System.Drawing.Point(79, 281);
			this.lbForgetPassword.Name = "lbForgetPassword";
			this.lbForgetPassword.Size = new System.Drawing.Size(120, 18);
			this.lbForgetPassword.TabIndex = 14;
			this.lbForgetPassword.Text = "Forget password";
			this.lbForgetPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lbForgetPassword.Click += new System.EventHandler(this.lbForgetPassword_Click);
			this.lbForgetPassword.MouseLeave += new System.EventHandler(this.lbSignup_MouseLeave);
			this.lbForgetPassword.MouseHover += new System.EventHandler(this.lbSignUp_MouseHover);
			// 
			// lbErrorLogIn
			// 
			this.lbErrorLogIn.BackColor = System.Drawing.Color.Transparent;
			this.lbErrorLogIn.ForeColor = System.Drawing.Color.Red;
			this.lbErrorLogIn.Location = new System.Drawing.Point(220, 82);
			this.lbErrorLogIn.Name = "lbErrorLogIn";
			this.lbErrorLogIn.Size = new System.Drawing.Size(270, 38);
			this.lbErrorLogIn.TabIndex = 13;
			this.lbErrorLogIn.Text = "Your log in user name or password incorrect.\r\nPlease try again.";
			this.lbErrorLogIn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lbErrorLogIn.Visible = false;
			// 
			// lbSignIn
			// 
			this.lbSignIn.AutoSize = true;
			this.lbSignIn.BackColor = System.Drawing.Color.Transparent;
			this.lbSignIn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lbSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbSignIn.ForeColor = System.Drawing.Color.Blue;
			this.lbSignIn.Location = new System.Drawing.Point(9, 281);
			this.lbSignIn.Name = "lbSignIn";
			this.lbSignIn.Size = new System.Drawing.Size(52, 18);
			this.lbSignIn.TabIndex = 11;
			this.lbSignIn.Text = "Sign in";
			this.lbSignIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lbSignIn.Click += new System.EventHandler(this.lbSignUp_Click);
			this.lbSignIn.MouseLeave += new System.EventHandler(this.lbSignup_MouseLeave);
			this.lbSignIn.MouseHover += new System.EventHandler(this.lbSignUp_MouseHover);
			// 
			// btLogin
			// 
			this.btLogin.BackColor = System.Drawing.Color.Blue;
			this.btLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btLogin.ForeColor = System.Drawing.Color.White;
			this.btLogin.Location = new System.Drawing.Point(475, 252);
			this.btLogin.Name = "btLogin";
			this.btLogin.Size = new System.Drawing.Size(102, 47);
			this.btLogin.TabIndex = 7;
			this.btLogin.Text = "Log in";
			this.btLogin.UseVisualStyleBackColor = false;
			this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
			// 
			// cbRemember
			// 
			this.cbRemember.AutoSize = true;
			this.cbRemember.BackColor = System.Drawing.Color.Transparent;
			this.cbRemember.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbRemember.ForeColor = System.Drawing.Color.Blue;
			this.cbRemember.Location = new System.Drawing.Point(223, 193);
			this.cbRemember.Name = "cbRemember";
			this.cbRemember.Size = new System.Drawing.Size(110, 19);
			this.cbRemember.TabIndex = 6;
			this.cbRemember.Text = "Remember me";
			this.cbRemember.UseVisualStyleBackColor = false;
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Blue;
			this.label4.Location = new System.Drawing.Point(78, 156);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(139, 38);
			this.label4.TabIndex = 3;
			this.label4.Text = "Password :";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Blue;
			this.label3.Location = new System.Drawing.Point(78, 118);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(139, 38);
			this.label3.TabIndex = 2;
			this.label3.Text = "User name :";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Tempus Sans ITC", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Blue;
			this.label1.Location = new System.Drawing.Point(3, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(583, 73);
			this.label1.TabIndex = 0;
			this.label1.Text = "Computer Store";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// errorPassword
			// 
			this.errorPassword.BlinkRate = 1;
			this.errorPassword.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
			this.errorPassword.ContainerControl = this;
			// 
			// errorConfiromPw
			// 
			this.errorConfiromPw.BlinkRate = 1;
			this.errorConfiromPw.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
			this.errorConfiromPw.ContainerControl = this;
			// 
			// errorEmail
			// 
			this.errorEmail.BlinkRate = 1;
			this.errorEmail.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
			this.errorEmail.ContainerControl = this;
			// 
			// lbTitle
			// 
			this.lbTitle.BackColor = System.Drawing.Color.Transparent;
			this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbTitle.ForeColor = System.Drawing.Color.White;
			this.lbTitle.Location = new System.Drawing.Point(9, 26);
			this.lbTitle.Name = "lbTitle";
			this.lbTitle.Size = new System.Drawing.Size(372, 34);
			this.lbTitle.TabIndex = 1;
			this.lbTitle.Text = "Log In";
			this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// frmLogIn
			// 
			this.AcceptButton = this.btLogin;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(589, 371);
			this.Controls.Add(this.lbTitle);
			this.Controls.Add(this.pnLogin);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Location = new System.Drawing.Point(900, 500);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(605, 410);
			this.Name = "frmLogIn";
			this.Load += new System.EventHandler(this.frmLogIn_Load);
			((System.ComponentModel.ISupportInitialize)(this.errorUserName)).EndInit();
			this.pnLogin.ResumeLayout(false);
			this.pnLogin.PerformLayout();
			this.ctmLogIn.ResumeLayout(false);
			this.pnSignIn.ResumeLayout(false);
			this.pnSignIn.PerformLayout();
			this.pnForgetPw.ResumeLayout(false);
			this.pnForgetPw.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorPassword)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorConfiromPw)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorEmail)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private Panel pnLogin;
        private Label label1;
        private Label label3;
        private Label label4;
        private TextboxPassword txPassword;
        private CheckBox cbRemember;
        private Label lbSignIn;
        private ToolTip myToolTop;
        private Label lbErrorLogIn;
        private ErrorProvider errorUserName;
        private ErrorProvider errorPassword;
        private Label lbForgetPassword;
        private Panel pnSignIn;
        private Label lbBack;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox txNewUserName;
        private TextBox txNewEmail;
        private TextboxPassword txNewPassword;
        private TextboxPassword txConfiromPw;
        private CheckBox cbManager;
        private Button btSignIn;
        private ErrorProvider errorConfiromPw;
        private ErrorProvider errorEmail;
        private Panel pnForgetPw;
        private Label lbBack2;
        private Label label11;
        private TextBox txSendEmail;
        private Button btSend;
        private Label label12;
        private TextBox txCode;
        private Button btCheck;
        private GroupBox groupBox1;
        private Button btApply;
        private Label label13;
        private TextboxPassword txForgetPw;
        private TextboxPassword txReEnterPw;
        private Label label14;
        private ContextMenuStrip ctmLogIn;
        private ToolStripMenuItem resetToolStripMenuItem;
        private ToolStripMenuItem backToolStripMenuItem;
		private Label lbTitle;
		private Button btLogin;
		private TextBox txUserName;
	}
}