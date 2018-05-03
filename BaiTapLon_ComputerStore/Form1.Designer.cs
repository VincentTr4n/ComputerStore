namespace BaiTapLon_ComputerStore
{
    partial class Form1
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
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
			this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
			this.button3 = new System.Windows.Forms.Button();
			this.gridControl1 = new DevExpress.XtraGrid.GridControl();
			this.showEmployeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.showEmloyees = new BaiTapLon_ComputerStore.showEmloyees();
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colEmployeeID = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colEmployeeName = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colBirthDate = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colSex = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colAddress = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPhoneNumber = new DevExpress.XtraGrid.Columns.GridColumn();
			this.show_EmployeeTableAdapter = new BaiTapLon_ComputerStore.showEmloyeesTableAdapters.show_EmployeeTableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.showEmployeeBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.showEmloyees)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(12, 76);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(360, 20);
			this.textBox1.TabIndex = 0;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(12, 102);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(360, 20);
			this.textBox2.TabIndex = 1;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(12, 128);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(360, 20);
			this.textBox3.TabIndex = 2;
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(12, 156);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(360, 20);
			this.textBox4.TabIndex = 3;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(393, 76);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(125, 46);
			this.button1.TabIndex = 4;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(393, 223);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(125, 46);
			this.button2.TabIndex = 5;
			this.button2.Text = "button2";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Location = new System.Drawing.Point(12, 182);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(80, 17);
			this.checkBox1.TabIndex = 7;
			this.checkBox1.Text = "checkBox1";
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// comboBox1
			// 
			this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(215, 375);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(212, 21);
			this.comboBox1.TabIndex = 8;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// navBarControl1
			// 
			this.navBarControl1.ActiveGroup = this.navBarGroup1;
			this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup1});
			this.navBarControl1.Location = new System.Drawing.Point(48, 223);
			this.navBarControl1.Name = "navBarControl1";
			this.navBarControl1.OptionsNavPane.ExpandedWidth = 140;
			this.navBarControl1.Size = new System.Drawing.Size(140, 69);
			this.navBarControl1.TabIndex = 9;
			this.navBarControl1.Text = "navBarControl1";
			// 
			// navBarGroup1
			// 
			this.navBarGroup1.Caption = "navBarGroup1";
			this.navBarGroup1.Name = "navBarGroup1";
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(393, 166);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(125, 46);
			this.button3.TabIndex = 10;
			this.button3.Text = "button3";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// gridControl1
			// 
			this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gridControl1.DataSource = this.showEmployeeBindingSource;
			this.gridControl1.Location = new System.Drawing.Point(548, 92);
			this.gridControl1.MainView = this.gridView1;
			this.gridControl1.Name = "gridControl1";
			this.gridControl1.Size = new System.Drawing.Size(478, 435);
			this.gridControl1.TabIndex = 11;
			this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
			// 
			// showEmployeeBindingSource
			// 
			this.showEmployeeBindingSource.DataMember = "show_Employee";
			this.showEmployeeBindingSource.DataSource = this.showEmloyees;
			// 
			// showEmloyees
			// 
			this.showEmloyees.DataSetName = "showEmloyees";
			this.showEmloyees.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// gridView1
			// 
			this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colEmployeeID,
            this.colEmployeeName,
            this.colBirthDate,
            this.colSex,
            this.colAddress,
            this.colPhoneNumber});
			this.gridView1.GridControl = this.gridControl1;
			this.gridView1.Name = "gridView1";
			this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
			// 
			// colEmployeeID
			// 
			this.colEmployeeID.FieldName = "Employee ID";
			this.colEmployeeID.Name = "colEmployeeID";
			this.colEmployeeID.Visible = true;
			this.colEmployeeID.VisibleIndex = 0;
			// 
			// colEmployeeName
			// 
			this.colEmployeeName.FieldName = "Employee Name";
			this.colEmployeeName.Name = "colEmployeeName";
			this.colEmployeeName.Visible = true;
			this.colEmployeeName.VisibleIndex = 1;
			// 
			// colBirthDate
			// 
			this.colBirthDate.FieldName = "BirthDate";
			this.colBirthDate.Name = "colBirthDate";
			this.colBirthDate.Visible = true;
			this.colBirthDate.VisibleIndex = 2;
			// 
			// colSex
			// 
			this.colSex.FieldName = "Sex";
			this.colSex.Name = "colSex";
			this.colSex.Visible = true;
			this.colSex.VisibleIndex = 3;
			// 
			// colAddress
			// 
			this.colAddress.FieldName = "Address";
			this.colAddress.Name = "colAddress";
			this.colAddress.Visible = true;
			this.colAddress.VisibleIndex = 4;
			// 
			// colPhoneNumber
			// 
			this.colPhoneNumber.FieldName = "PhoneNumber";
			this.colPhoneNumber.Name = "colPhoneNumber";
			this.colPhoneNumber.Visible = true;
			this.colPhoneNumber.VisibleIndex = 5;
			// 
			// show_EmployeeTableAdapter
			// 
			this.show_EmployeeTableAdapter.ClearBeforeFill = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1038, 539);
			this.Controls.Add(this.gridControl1);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.navBarControl1);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.showEmployeeBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.showEmloyees)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.ComboBox comboBox1;
		private DevExpress.XtraNavBar.NavBarControl navBarControl1;
		private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
		private System.Windows.Forms.Button button3;
		private DevExpress.XtraGrid.GridControl gridControl1;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		private showEmloyees showEmloyees;
		private System.Windows.Forms.BindingSource showEmployeeBindingSource;
		private showEmloyeesTableAdapters.show_EmployeeTableAdapter show_EmployeeTableAdapter;
		private DevExpress.XtraGrid.Columns.GridColumn colEmployeeID;
		private DevExpress.XtraGrid.Columns.GridColumn colEmployeeName;
		private DevExpress.XtraGrid.Columns.GridColumn colBirthDate;
		private DevExpress.XtraGrid.Columns.GridColumn colSex;
		private DevExpress.XtraGrid.Columns.GridColumn colAddress;
		private DevExpress.XtraGrid.Columns.GridColumn colPhoneNumber;
	}
}