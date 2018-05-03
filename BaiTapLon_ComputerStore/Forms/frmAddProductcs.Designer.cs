namespace BaiTapLon_ComputerStore
{
	partial class frmAddProductcs
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
			this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
			this.txID = new System.Windows.Forms.TextBox();
			this.cbType = new System.Windows.Forms.ComboBox();
			this.cbSupplier = new System.Windows.Forms.ComboBox();
			this.mcbCreateID = new MetroFramework.Controls.MetroCheckBox();
			this.sbtApply = new DevExpress.XtraEditors.SimpleButton();
			this.sbtCancel = new DevExpress.XtraEditors.SimpleButton();
			this.txName = new DevExpress.XtraEditors.MemoEdit();
			this.txWarranty = new DevExpress.XtraEditors.SpinEdit();
			this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
			this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
			this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
			((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
			this.layoutControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.txName.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txWarranty.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
			this.SuspendLayout();
			// 
			// layoutControl1
			// 
			this.layoutControl1.Controls.Add(this.txID);
			this.layoutControl1.Controls.Add(this.cbType);
			this.layoutControl1.Controls.Add(this.cbSupplier);
			this.layoutControl1.Controls.Add(this.mcbCreateID);
			this.layoutControl1.Controls.Add(this.sbtApply);
			this.layoutControl1.Controls.Add(this.sbtCancel);
			this.layoutControl1.Controls.Add(this.txName);
			this.layoutControl1.Controls.Add(this.txWarranty);
			this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.layoutControl1.Location = new System.Drawing.Point(20, 60);
			this.layoutControl1.Name = "layoutControl1";
			this.layoutControl1.Root = this.layoutControlGroup1;
			this.layoutControl1.Size = new System.Drawing.Size(517, 166);
			this.layoutControl1.TabIndex = 0;
			this.layoutControl1.Text = "layoutControl1";
			// 
			// txID
			// 
			this.txID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txID.Location = new System.Drawing.Point(95, 12);
			this.txID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txID.Name = "txID";
			this.txID.Size = new System.Drawing.Size(166, 20);
			this.txID.TabIndex = 13;
			// 
			// cbType
			// 
			this.cbType.FormattingEnabled = true;
			this.cbType.Location = new System.Drawing.Point(348, 12);
			this.cbType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cbType.Name = "cbType";
			this.cbType.Size = new System.Drawing.Size(157, 21);
			this.cbType.TabIndex = 11;
			// 
			// cbSupplier
			// 
			this.cbSupplier.DropDownHeight = 100;
			this.cbSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbSupplier.FormattingEnabled = true;
			this.cbSupplier.IntegralHeight = false;
			this.cbSupplier.Location = new System.Drawing.Point(348, 37);
			this.cbSupplier.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cbSupplier.Name = "cbSupplier";
			this.cbSupplier.Size = new System.Drawing.Size(157, 21);
			this.cbSupplier.TabIndex = 10;
			// 
			// mcbCreateID
			// 
			this.mcbCreateID.Location = new System.Drawing.Point(12, 134);
			this.mcbCreateID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.mcbCreateID.Name = "mcbCreateID";
			this.mcbCreateID.Size = new System.Drawing.Size(249, 20);
			this.mcbCreateID.TabIndex = 7;
			this.mcbCreateID.Text = "Auto Create ID";
			this.mcbCreateID.UseSelectable = true;
			this.mcbCreateID.CheckedChanged += new System.EventHandler(this.mcbCreateID_CheckedChanged);
			// 
			// sbtApply
			// 
			this.sbtApply.Location = new System.Drawing.Point(341, 131);
			this.sbtApply.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.sbtApply.Name = "sbtApply";
			this.sbtApply.Size = new System.Drawing.Size(80, 23);
			this.sbtApply.StyleController = this.layoutControl1;
			this.sbtApply.TabIndex = 8;
			this.sbtApply.Text = "Apply";
			this.sbtApply.Click += new System.EventHandler(this.sbtApply_Click);
			// 
			// sbtCancel
			// 
			this.sbtCancel.Location = new System.Drawing.Point(425, 131);
			this.sbtCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.sbtCancel.Name = "sbtCancel";
			this.sbtCancel.Size = new System.Drawing.Size(80, 23);
			this.sbtCancel.StyleController = this.layoutControl1;
			this.sbtCancel.TabIndex = 9;
			this.sbtCancel.Text = "Cancel";
			this.sbtCancel.Click += new System.EventHandler(this.sbtCancel_Click);
			// 
			// txName
			// 
			this.txName.Location = new System.Drawing.Point(12, 56);
			this.txName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txName.Name = "txName";
			this.txName.Size = new System.Drawing.Size(249, 74);
			this.txName.StyleController = this.layoutControl1;
			this.txName.TabIndex = 14;
			// 
			// txWarranty
			// 
			this.txWarranty.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.txWarranty.Location = new System.Drawing.Point(348, 62);
			this.txWarranty.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txWarranty.Name = "txWarranty";
			this.txWarranty.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.txWarranty.Properties.MaxLength = 1;
			this.txWarranty.Properties.MaxValue = new decimal(new int[] {
            9,
            0,
            0,
            0});
			this.txWarranty.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.txWarranty.Size = new System.Drawing.Size(157, 22);
			this.txWarranty.StyleController = this.layoutControl1;
			this.txWarranty.TabIndex = 15;
			// 
			// layoutControlGroup1
			// 
			this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.layoutControlGroup1.GroupBordersVisible = false;
			this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.emptySpaceItem2,
            this.layoutControlItem3,
            this.emptySpaceItem1,
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem7,
            this.layoutControlItem8});
			this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
			this.layoutControlGroup1.Name = "layoutControlGroup1";
			this.layoutControlGroup1.Size = new System.Drawing.Size(517, 166);
			this.layoutControlGroup1.TextVisible = false;
			// 
			// layoutControlItem4
			// 
			this.layoutControlItem4.Control = this.mcbCreateID;
			this.layoutControlItem4.Location = new System.Drawing.Point(0, 122);
			this.layoutControlItem4.Name = "layoutControlItem4";
			this.layoutControlItem4.Size = new System.Drawing.Size(253, 24);
			this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem4.TextVisible = false;
			// 
			// layoutControlItem5
			// 
			this.layoutControlItem5.Control = this.sbtApply;
			this.layoutControlItem5.Location = new System.Drawing.Point(329, 119);
			this.layoutControlItem5.Name = "layoutControlItem5";
			this.layoutControlItem5.Size = new System.Drawing.Size(84, 27);
			this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem5.TextVisible = false;
			// 
			// layoutControlItem6
			// 
			this.layoutControlItem6.Control = this.sbtCancel;
			this.layoutControlItem6.Location = new System.Drawing.Point(413, 119);
			this.layoutControlItem6.Name = "layoutControlItem6";
			this.layoutControlItem6.Size = new System.Drawing.Size(84, 27);
			this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem6.TextVisible = false;
			// 
			// emptySpaceItem2
			// 
			this.emptySpaceItem2.AllowHotTrack = false;
			this.emptySpaceItem2.Location = new System.Drawing.Point(253, 119);
			this.emptySpaceItem2.Name = "emptySpaceItem2";
			this.emptySpaceItem2.Size = new System.Drawing.Size(76, 27);
			this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
			// 
			// layoutControlItem3
			// 
			this.layoutControlItem3.Control = this.cbSupplier;
			this.layoutControlItem3.Location = new System.Drawing.Point(253, 25);
			this.layoutControlItem3.Name = "layoutControlItem3";
			this.layoutControlItem3.Size = new System.Drawing.Size(244, 25);
			this.layoutControlItem3.Text = "Supplier";
			this.layoutControlItem3.TextSize = new System.Drawing.Size(80, 16);
			// 
			// emptySpaceItem1
			// 
			this.emptySpaceItem1.AllowHotTrack = false;
			this.emptySpaceItem1.Location = new System.Drawing.Point(253, 76);
			this.emptySpaceItem1.Name = "emptySpaceItem1";
			this.emptySpaceItem1.Size = new System.Drawing.Size(244, 43);
			this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
			// 
			// layoutControlItem1
			// 
			this.layoutControlItem1.Control = this.txID;
			this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Size = new System.Drawing.Size(253, 25);
			this.layoutControlItem1.Text = "Product ID";
			this.layoutControlItem1.TextSize = new System.Drawing.Size(80, 16);
			// 
			// layoutControlItem2
			// 
			this.layoutControlItem2.Control = this.cbType;
			this.layoutControlItem2.Location = new System.Drawing.Point(253, 0);
			this.layoutControlItem2.Name = "layoutControlItem2";
			this.layoutControlItem2.Size = new System.Drawing.Size(244, 25);
			this.layoutControlItem2.Text = "Type";
			this.layoutControlItem2.TextSize = new System.Drawing.Size(80, 16);
			// 
			// layoutControlItem7
			// 
			this.layoutControlItem7.Control = this.txName;
			this.layoutControlItem7.Location = new System.Drawing.Point(0, 25);
			this.layoutControlItem7.Name = "layoutControlItem7";
			this.layoutControlItem7.Size = new System.Drawing.Size(253, 97);
			this.layoutControlItem7.Text = "Product Name";
			this.layoutControlItem7.TextLocation = DevExpress.Utils.Locations.Top;
			this.layoutControlItem7.TextSize = new System.Drawing.Size(80, 16);
			// 
			// layoutControlItem8
			// 
			this.layoutControlItem8.Control = this.txWarranty;
			this.layoutControlItem8.Location = new System.Drawing.Point(253, 50);
			this.layoutControlItem8.Name = "layoutControlItem8";
			this.layoutControlItem8.Size = new System.Drawing.Size(244, 26);
			this.layoutControlItem8.Text = "Warranty";
			this.layoutControlItem8.TextSize = new System.Drawing.Size(80, 16);
			// 
			// frmAddProductcs
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(557, 246);
			this.Controls.Add(this.layoutControl1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MaximizeBox = false;
			this.Name = "frmAddProductcs";
			this.Resizable = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Product";
			this.Load += new System.EventHandler(this.frmAddProductcs_Load);
			((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
			this.layoutControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.txName.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txWarranty.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraLayout.LayoutControl layoutControl1;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
		private MetroFramework.Controls.MetroCheckBox mcbCreateID;
		private System.Windows.Forms.ComboBox cbSupplier;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
		private System.Windows.Forms.ComboBox cbType;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
		private System.Windows.Forms.TextBox txID;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
		private DevExpress.XtraEditors.SimpleButton sbtApply;
		private DevExpress.XtraEditors.SimpleButton sbtCancel;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
		private DevExpress.XtraEditors.MemoEdit txName;
		private DevExpress.XtraEditors.SpinEdit txWarranty;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
	}
}