namespace BaiTapLon_ComputerStore
{
	partial class frmCustomer
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomer));
			this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
			this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
			this.gridControl1 = new DevExpress.XtraGrid.GridControl();
			this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.showCustomers = new BaiTapLon_ComputerStore.showCustomers();
			this.MainView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colID_Customer1 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colName_Customer1 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPhone1 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colAddress1 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colEmail1 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.sbtCancel = new DevExpress.XtraEditors.SimpleButton();
			this.sbtApply = new DevExpress.XtraEditors.SimpleButton();
			this.sbtNew = new DevExpress.XtraEditors.SimpleButton();
			this.sbtDelete = new DevExpress.XtraEditors.SimpleButton();
			this.btPrint = new DevExpress.XtraEditors.SimpleButton();
			this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
			this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
			this.customersTableAdapter = new BaiTapLon_ComputerStore.showCustomersTableAdapters.CustomersTableAdapter();
			this.colID_Customer = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colName_Customer = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPhone = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colAddress = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
			this.panelControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
			this.layoutControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.showCustomers)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.MainView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
			this.SuspendLayout();
			// 
			// panelControl1
			// 
			this.panelControl1.Controls.Add(this.layoutControl1);
			this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panelControl1.Location = new System.Drawing.Point(20, 63);
			this.panelControl1.Name = "panelControl1";
			this.panelControl1.Size = new System.Drawing.Size(720, 423);
			this.panelControl1.TabIndex = 0;
			// 
			// layoutControl1
			// 
			this.layoutControl1.Controls.Add(this.gridControl1);
			this.layoutControl1.Controls.Add(this.sbtCancel);
			this.layoutControl1.Controls.Add(this.sbtApply);
			this.layoutControl1.Controls.Add(this.sbtNew);
			this.layoutControl1.Controls.Add(this.sbtDelete);
			this.layoutControl1.Controls.Add(this.btPrint);
			this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.layoutControl1.Location = new System.Drawing.Point(2, 2);
			this.layoutControl1.Name = "layoutControl1";
			this.layoutControl1.Root = this.layoutControlGroup1;
			this.layoutControl1.Size = new System.Drawing.Size(716, 419);
			this.layoutControl1.TabIndex = 0;
			this.layoutControl1.Text = "layoutControl1";
			// 
			// gridControl1
			// 
			this.gridControl1.DataSource = this.customersBindingSource;
			this.gridControl1.Location = new System.Drawing.Point(12, 12);
			this.gridControl1.MainView = this.MainView;
			this.gridControl1.Name = "gridControl1";
			this.gridControl1.Size = new System.Drawing.Size(692, 369);
			this.gridControl1.TabIndex = 4;
			this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.MainView});
			this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
			// 
			// customersBindingSource
			// 
			this.customersBindingSource.DataMember = "Customers";
			this.customersBindingSource.DataSource = this.showCustomers;
			// 
			// showCustomers
			// 
			this.showCustomers.DataSetName = "showCustomers";
			this.showCustomers.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// MainView
			// 
			this.MainView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID_Customer1,
            this.colName_Customer1,
            this.colPhone1,
            this.colAddress1,
            this.colEmail1});
			this.MainView.GridControl = this.gridControl1;
			this.MainView.Name = "MainView";
			this.MainView.OptionsFind.AlwaysVisible = true;
			this.MainView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
			this.MainView.OptionsView.ShowGroupPanel = false;
			this.MainView.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.MainView_CellValueChanged);
			// 
			// colID_Customer1
			// 
			this.colID_Customer1.Caption = "Customer ID";
			this.colID_Customer1.FieldName = "ID_Customer";
			this.colID_Customer1.Name = "colID_Customer1";
			this.colID_Customer1.Visible = true;
			this.colID_Customer1.VisibleIndex = 0;
			// 
			// colName_Customer1
			// 
			this.colName_Customer1.Caption = "Customer Name";
			this.colName_Customer1.FieldName = "Name_Customer";
			this.colName_Customer1.Name = "colName_Customer1";
			this.colName_Customer1.Visible = true;
			this.colName_Customer1.VisibleIndex = 1;
			// 
			// colPhone1
			// 
			this.colPhone1.FieldName = "Phone";
			this.colPhone1.Name = "colPhone1";
			this.colPhone1.Visible = true;
			this.colPhone1.VisibleIndex = 2;
			// 
			// colAddress1
			// 
			this.colAddress1.FieldName = "Address";
			this.colAddress1.Name = "colAddress1";
			this.colAddress1.Visible = true;
			this.colAddress1.VisibleIndex = 3;
			// 
			// colEmail1
			// 
			this.colEmail1.FieldName = "Email";
			this.colEmail1.Name = "colEmail1";
			this.colEmail1.Visible = true;
			this.colEmail1.VisibleIndex = 4;
			// 
			// sbtCancel
			// 
			this.sbtCancel.Location = new System.Drawing.Point(637, 385);
			this.sbtCancel.Name = "sbtCancel";
			this.sbtCancel.Size = new System.Drawing.Size(67, 22);
			this.sbtCancel.StyleController = this.layoutControl1;
			this.sbtCancel.TabIndex = 5;
			this.sbtCancel.Text = "Cancel";
			this.sbtCancel.Click += new System.EventHandler(this.sbtCancel_Click);
			// 
			// sbtApply
			// 
			this.sbtApply.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.sbtApply.Location = new System.Drawing.Point(493, 385);
			this.sbtApply.Name = "sbtApply";
			this.sbtApply.Size = new System.Drawing.Size(70, 22);
			this.sbtApply.StyleController = this.layoutControl1;
			this.sbtApply.TabIndex = 6;
			this.sbtApply.Text = "Apply";
			this.sbtApply.Click += new System.EventHandler(this.sbtApply_Click);
			// 
			// sbtNew
			// 
			this.sbtNew.Location = new System.Drawing.Point(12, 385);
			this.sbtNew.Name = "sbtNew";
			this.sbtNew.Size = new System.Drawing.Size(54, 22);
			this.sbtNew.StyleController = this.layoutControl1;
			this.sbtNew.TabIndex = 8;
			this.sbtNew.Text = "New Row";
			this.sbtNew.Click += new System.EventHandler(this.sbtNew_Click);
			// 
			// sbtDelete
			// 
			this.sbtDelete.Location = new System.Drawing.Point(567, 385);
			this.sbtDelete.Name = "sbtDelete";
			this.sbtDelete.Size = new System.Drawing.Size(66, 22);
			this.sbtDelete.StyleController = this.layoutControl1;
			this.sbtDelete.TabIndex = 9;
			this.sbtDelete.Text = "Delete";
			this.sbtDelete.Click += new System.EventHandler(this.sbtDelete_Click);
			// 
			// btPrint
			// 
			this.btPrint.Location = new System.Drawing.Point(413, 385);
			this.btPrint.Name = "btPrint";
			this.btPrint.Size = new System.Drawing.Size(76, 22);
			this.btPrint.StyleController = this.layoutControl1;
			this.btPrint.TabIndex = 10;
			this.btPrint.Text = "Top Purchase";
			this.btPrint.Click += new System.EventHandler(this.simpleButton1_Click);
			// 
			// layoutControlGroup1
			// 
			this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.layoutControlGroup1.GroupBordersVisible = false;
			this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.emptySpaceItem1,
            this.layoutControlItem5,
            this.layoutControlItem4,
            this.layoutControlItem3,
            this.layoutControlItem6});
			this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
			this.layoutControlGroup1.Name = "layoutControlGroup1";
			this.layoutControlGroup1.Size = new System.Drawing.Size(716, 419);
			this.layoutControlGroup1.TextVisible = false;
			// 
			// layoutControlItem1
			// 
			this.layoutControlItem1.Control = this.gridControl1;
			this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Size = new System.Drawing.Size(696, 373);
			this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem1.TextVisible = false;
			// 
			// layoutControlItem2
			// 
			this.layoutControlItem2.Control = this.sbtCancel;
			this.layoutControlItem2.Location = new System.Drawing.Point(625, 373);
			this.layoutControlItem2.Name = "layoutControlItem2";
			this.layoutControlItem2.Size = new System.Drawing.Size(71, 26);
			this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem2.TextVisible = false;
			// 
			// emptySpaceItem1
			// 
			this.emptySpaceItem1.AllowHotTrack = false;
			this.emptySpaceItem1.Location = new System.Drawing.Point(58, 373);
			this.emptySpaceItem1.Name = "emptySpaceItem1";
			this.emptySpaceItem1.Size = new System.Drawing.Size(343, 26);
			this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
			// 
			// layoutControlItem5
			// 
			this.layoutControlItem5.Control = this.sbtNew;
			this.layoutControlItem5.Location = new System.Drawing.Point(0, 373);
			this.layoutControlItem5.Name = "layoutControlItem5";
			this.layoutControlItem5.Size = new System.Drawing.Size(58, 26);
			this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem5.TextVisible = false;
			// 
			// layoutControlItem4
			// 
			this.layoutControlItem4.Control = this.sbtDelete;
			this.layoutControlItem4.Location = new System.Drawing.Point(555, 373);
			this.layoutControlItem4.Name = "layoutControlItem4";
			this.layoutControlItem4.Size = new System.Drawing.Size(70, 26);
			this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem4.TextVisible = false;
			// 
			// layoutControlItem3
			// 
			this.layoutControlItem3.Control = this.sbtApply;
			this.layoutControlItem3.Location = new System.Drawing.Point(481, 373);
			this.layoutControlItem3.Name = "layoutControlItem3";
			this.layoutControlItem3.Size = new System.Drawing.Size(74, 26);
			this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem3.TextVisible = false;
			// 
			// layoutControlItem6
			// 
			this.layoutControlItem6.Control = this.btPrint;
			this.layoutControlItem6.Location = new System.Drawing.Point(401, 373);
			this.layoutControlItem6.Name = "layoutControlItem6";
			this.layoutControlItem6.Size = new System.Drawing.Size(80, 26);
			this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem6.TextVisible = false;
			// 
			// customersTableAdapter
			// 
			this.customersTableAdapter.ClearBeforeFill = true;
			// 
			// colID_Customer
			// 
			this.colID_Customer.Caption = "Customer ID";
			this.colID_Customer.FieldName = "ID_Customer";
			this.colID_Customer.Name = "colID_Customer";
			this.colID_Customer.Visible = true;
			this.colID_Customer.VisibleIndex = 0;
			// 
			// colName_Customer
			// 
			this.colName_Customer.Caption = "Customer Name";
			this.colName_Customer.FieldName = "Name_Customer";
			this.colName_Customer.Name = "colName_Customer";
			this.colName_Customer.Visible = true;
			this.colName_Customer.VisibleIndex = 1;
			// 
			// colPhone
			// 
			this.colPhone.FieldName = "Phone";
			this.colPhone.Name = "colPhone";
			this.colPhone.Visible = true;
			this.colPhone.VisibleIndex = 2;
			// 
			// colAddress
			// 
			this.colAddress.FieldName = "Address";
			this.colAddress.Name = "colAddress";
			this.colAddress.Visible = true;
			this.colAddress.VisibleIndex = 3;
			// 
			// colEmail
			// 
			this.colEmail.FieldName = "Email";
			this.colEmail.Name = "colEmail";
			this.colEmail.Visible = true;
			this.colEmail.VisibleIndex = 4;
			// 
			// frmCustomer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(760, 506);
			this.Controls.Add(this.panelControl1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "frmCustomer";
			this.Resizable = false;
			this.Text = "Customer";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCustomer_FormClosing);
			this.Load += new System.EventHandler(this.frmCustomer_Load);
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
			this.panelControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
			this.layoutControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.showCustomers)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.MainView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraEditors.PanelControl panelControl1;
		private DevExpress.XtraLayout.LayoutControl layoutControl1;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
		private DevExpress.XtraEditors.SimpleButton sbtCancel;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
		private DevExpress.XtraEditors.SimpleButton sbtApply;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
		private DevExpress.XtraEditors.SimpleButton sbtNew;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
		private DevExpress.XtraEditors.SimpleButton sbtDelete;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
		private showCustomers showCustomers;
		private System.Windows.Forms.BindingSource customersBindingSource;
		private showCustomersTableAdapters.CustomersTableAdapter customersTableAdapter;
		private DevExpress.XtraGrid.GridControl gridControl1;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
		private DevExpress.XtraGrid.Columns.GridColumn colID_Customer;
		private DevExpress.XtraGrid.Columns.GridColumn colName_Customer;
		private DevExpress.XtraGrid.Columns.GridColumn colPhone;
		private DevExpress.XtraGrid.Columns.GridColumn colAddress;
		private DevExpress.XtraGrid.Columns.GridColumn colEmail;
		private DevExpress.XtraGrid.Views.Grid.GridView MainView;
		private DevExpress.XtraGrid.Columns.GridColumn colID_Customer1;
		private DevExpress.XtraGrid.Columns.GridColumn colName_Customer1;
		private DevExpress.XtraGrid.Columns.GridColumn colPhone1;
		private DevExpress.XtraGrid.Columns.GridColumn colAddress1;
		private DevExpress.XtraGrid.Columns.GridColumn colEmail1;
		private DevExpress.XtraEditors.SimpleButton btPrint;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
	}
}