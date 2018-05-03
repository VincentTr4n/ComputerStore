namespace BaiTapLon_ComputerStore
{
    partial class frmAccountSetting
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txChangeEmail = new System.Windows.Forms.TextBox();
            this.btChangeEmail = new System.Windows.Forms.Button();
            this.errorChangeEmail = new System.Windows.Forms.ErrorProvider(this.components);
            this.btEdit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btSaveShange = new System.Windows.Forms.Button();
            this.txConfirmPasswrod = new BaiTapLon_ComputerStore.TextboxPassword();
            this.txNewPassword = new BaiTapLon_ComputerStore.TextboxPassword();
            this.txCurrPassword = new BaiTapLon_ComputerStore.TextboxPassword();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.errorCur = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorNew = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorRe = new System.Windows.Forms.ErrorProvider(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorChangeEmail)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorCur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorRe)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(460, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(56, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txChangeEmail
            // 
            this.txChangeEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txChangeEmail.Location = new System.Drawing.Point(136, 69);
            this.txChangeEmail.Name = "txChangeEmail";
            this.txChangeEmail.Size = new System.Drawing.Size(235, 26);
            this.txChangeEmail.TabIndex = 2;
            // 
            // btChangeEmail
            // 
            this.btChangeEmail.BackColor = System.Drawing.Color.RoyalBlue;
            this.btChangeEmail.ForeColor = System.Drawing.Color.White;
            this.btChangeEmail.Location = new System.Drawing.Point(395, 69);
            this.btChangeEmail.Name = "btChangeEmail";
            this.btChangeEmail.Size = new System.Drawing.Size(63, 26);
            this.btChangeEmail.TabIndex = 3;
            this.btChangeEmail.Text = "Change";
            this.btChangeEmail.UseVisualStyleBackColor = false;
            // 
            // errorChangeEmail
            // 
            this.errorChangeEmail.BlinkRate = 1;
            this.errorChangeEmail.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorChangeEmail.ContainerControl = this;
            // 
            // btEdit
            // 
            this.btEdit.BackColor = System.Drawing.Color.RoyalBlue;
            this.btEdit.ForeColor = System.Drawing.Color.White;
            this.btEdit.Location = new System.Drawing.Point(206, 105);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(63, 26);
            this.btEdit.TabIndex = 4;
            this.btEdit.Text = "Edit";
            this.btEdit.UseVisualStyleBackColor = false;
            this.btEdit.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btSaveShange);
            this.groupBox1.Controls.Add(this.txConfirmPasswrod);
            this.groupBox1.Controls.Add(this.txNewPassword);
            this.groupBox1.Controls.Add(this.txCurrPassword);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(50, 133);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(365, 166);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // btSaveShange
            // 
            this.btSaveShange.BackColor = System.Drawing.Color.RoyalBlue;
            this.btSaveShange.ForeColor = System.Drawing.Color.White;
            this.btSaveShange.Location = new System.Drawing.Point(156, 134);
            this.btSaveShange.Name = "btSaveShange";
            this.btSaveShange.Size = new System.Drawing.Size(63, 26);
            this.btSaveShange.TabIndex = 9;
            this.btSaveShange.Text = "Save";
            this.btSaveShange.UseVisualStyleBackColor = false;
            this.btSaveShange.Click += new System.EventHandler(this.btSaveShange_Click);
            // 
            // txConfirmPasswrod
            // 
            this.txConfirmPasswrod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txConfirmPasswrod.Location = new System.Drawing.Point(86, 96);
            this.txConfirmPasswrod.Name = "txConfirmPasswrod";
            this.txConfirmPasswrod.PasswordChar = '*';
            this.txConfirmPasswrod.Size = new System.Drawing.Size(235, 21);
            this.txConfirmPasswrod.TabIndex = 8;
            this.txConfirmPasswrod.TextChanged += new System.EventHandler(this.txConfirmPasswrod_TextChanged);
            // 
            // txNewPassword
            // 
            this.txNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txNewPassword.Location = new System.Drawing.Point(86, 58);
            this.txNewPassword.Name = "txNewPassword";
            this.txNewPassword.PasswordChar = '*';
            this.txNewPassword.Size = new System.Drawing.Size(235, 21);
            this.txNewPassword.TabIndex = 7;
            this.txNewPassword.TextChanged += new System.EventHandler(this.txNewPassword_TextChanged);
            // 
            // txCurrPassword
            // 
            this.txCurrPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txCurrPassword.Location = new System.Drawing.Point(86, 19);
            this.txCurrPassword.Name = "txCurrPassword";
            this.txCurrPassword.PasswordChar = '*';
            this.txCurrPassword.Size = new System.Drawing.Size(235, 21);
            this.txCurrPassword.TabIndex = 6;
            this.txCurrPassword.TextChanged += new System.EventHandler(this.txCurrPassword_TextChanged);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(6, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Re-Enter";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(6, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "New :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Current :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // errorCur
            // 
            this.errorCur.BlinkRate = 1;
            this.errorCur.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorCur.ContainerControl = this;
            // 
            // errorNew
            // 
            this.errorNew.BlinkRate = 1;
            this.errorNew.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorNew.ContainerControl = this;
            // 
            // errorRe
            // 
            this.errorRe.BlinkRate = 1;
            this.errorRe.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorRe.ContainerControl = this;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(98, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 23);
            this.label6.TabIndex = 6;
            this.label6.Text = "Change password";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Image = global::BaiTapLon_ComputerStore.Properties.Resources.myKey;
            this.label7.Location = new System.Drawing.Point(47, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 23);
            this.label7.TabIndex = 7;
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmAccountSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(470, 311);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.btChangeEmail);
            this.Controls.Add(this.txChangeEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAccountSetting";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Account setting";
            this.Load += new System.EventHandler(this.frmAccountSetting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorChangeEmail)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorCur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorRe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txChangeEmail;
        private System.Windows.Forms.Button btChangeEmail;
        private System.Windows.Forms.ErrorProvider errorChangeEmail;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private TextboxPassword txCurrPassword;
        private TextboxPassword txConfirmPasswrod;
        private TextboxPassword txNewPassword;
        private System.Windows.Forms.Button btSaveShange;
        private System.Windows.Forms.ErrorProvider errorCur;
        private System.Windows.Forms.ErrorProvider errorNew;
        private System.Windows.Forms.ErrorProvider errorRe;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}