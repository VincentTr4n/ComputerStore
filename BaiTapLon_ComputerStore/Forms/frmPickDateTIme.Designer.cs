namespace BaiTapLon_ComputerStore
{
	partial class frmPickDateTime
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
			this.tabControl = new MaterialSkin.Controls.MaterialTabControl();
			this.tabYear = new System.Windows.Forms.TabPage();
			this.label1 = new System.Windows.Forms.Label();
			this.cbPickYear = new DevExpress.XtraEditors.ComboBoxEdit();
			this.tabDays = new System.Windows.Forms.TabPage();
			this.dpEnd = new DevExpress.XtraEditors.DateEdit();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.dpStart = new DevExpress.XtraEditors.DateEdit();
			this.btApply = new MaterialSkin.Controls.MaterialRaisedButton();
			this.btCancel = new MaterialSkin.Controls.MaterialRaisedButton();
			this.tabControl.SuspendLayout();
			this.tabYear.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cbPickYear.Properties)).BeginInit();
			this.tabDays.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dpEnd.Properties.CalendarTimeProperties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dpEnd.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dpStart.Properties.CalendarTimeProperties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dpStart.Properties)).BeginInit();
			this.SuspendLayout();
			// 
			// tabControl
			// 
			this.tabControl.Controls.Add(this.tabYear);
			this.tabControl.Controls.Add(this.tabDays);
			this.tabControl.Depth = 0;
			this.tabControl.Location = new System.Drawing.Point(23, 53);
			this.tabControl.MouseState = MaterialSkin.MouseState.HOVER;
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new System.Drawing.Size(373, 79);
			this.tabControl.TabIndex = 0;
			// 
			// tabYear
			// 
			this.tabYear.Controls.Add(this.label1);
			this.tabYear.Controls.Add(this.cbPickYear);
			this.tabYear.Location = new System.Drawing.Point(4, 22);
			this.tabYear.Name = "tabYear";
			this.tabYear.Padding = new System.Windows.Forms.Padding(3);
			this.tabYear.Size = new System.Drawing.Size(365, 53);
			this.tabYear.TabIndex = 0;
			this.tabYear.Text = "tabPage1";
			this.tabYear.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(310, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(45, 16);
			this.label1.TabIndex = 1;
			this.label1.Text = "YEAR";
			// 
			// cbPickYear
			// 
			this.cbPickYear.Location = new System.Drawing.Point(29, 18);
			this.cbPickYear.Name = "cbPickYear";
			this.cbPickYear.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbPickYear.Properties.Appearance.Options.UseFont = true;
			this.cbPickYear.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.cbPickYear.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
			this.cbPickYear.Size = new System.Drawing.Size(266, 24);
			this.cbPickYear.TabIndex = 0;
			// 
			// tabDays
			// 
			this.tabDays.Controls.Add(this.dpEnd);
			this.tabDays.Controls.Add(this.label3);
			this.tabDays.Controls.Add(this.label2);
			this.tabDays.Controls.Add(this.dpStart);
			this.tabDays.Location = new System.Drawing.Point(4, 22);
			this.tabDays.Name = "tabDays";
			this.tabDays.Padding = new System.Windows.Forms.Padding(3);
			this.tabDays.Size = new System.Drawing.Size(365, 53);
			this.tabDays.TabIndex = 1;
			this.tabDays.Text = "tabPage2";
			this.tabDays.UseVisualStyleBackColor = true;
			// 
			// dpEnd
			// 
			this.dpEnd.EditValue = null;
			this.dpEnd.Location = new System.Drawing.Point(226, 17);
			this.dpEnd.Name = "dpEnd";
			this.dpEnd.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dpEnd.Properties.Appearance.Options.UseFont = true;
			this.dpEnd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.dpEnd.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.dpEnd.Size = new System.Drawing.Size(129, 22);
			this.dpEnd.TabIndex = 3;
			this.dpEnd.EditValueChanged += new System.EventHandler(this.dpEnd_EditValueChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(195, 20);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(25, 16);
			this.label3.TabIndex = 2;
			this.label3.Text = "To";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(6, 20);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(39, 16);
			this.label2.TabIndex = 1;
			this.label2.Text = "From";
			// 
			// dpStart
			// 
			this.dpStart.EditValue = null;
			this.dpStart.Location = new System.Drawing.Point(60, 17);
			this.dpStart.Name = "dpStart";
			this.dpStart.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dpStart.Properties.Appearance.Options.UseFont = true;
			this.dpStart.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.dpStart.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.dpStart.Size = new System.Drawing.Size(129, 22);
			this.dpStart.TabIndex = 0;
			// 
			// btApply
			// 
			this.btApply.AutoSize = true;
			this.btApply.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.btApply.Depth = 0;
			this.btApply.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btApply.Icon = null;
			this.btApply.Location = new System.Drawing.Point(240, 134);
			this.btApply.MouseState = MaterialSkin.MouseState.HOVER;
			this.btApply.Name = "btApply";
			this.btApply.Primary = true;
			this.btApply.Size = new System.Drawing.Size(63, 36);
			this.btApply.TabIndex = 1;
			this.btApply.Text = "Apply";
			this.btApply.UseVisualStyleBackColor = true;
			this.btApply.Click += new System.EventHandler(this.btApply_Click);
			// 
			// btCancel
			// 
			this.btCancel.AutoSize = true;
			this.btCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.btCancel.Depth = 0;
			this.btCancel.Icon = null;
			this.btCancel.Location = new System.Drawing.Point(309, 134);
			this.btCancel.MouseState = MaterialSkin.MouseState.HOVER;
			this.btCancel.Name = "btCancel";
			this.btCancel.Primary = true;
			this.btCancel.Size = new System.Drawing.Size(73, 36);
			this.btCancel.TabIndex = 2;
			this.btCancel.Text = "Cancel";
			this.btCancel.UseVisualStyleBackColor = true;
			this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
			// 
			// frmPickDateTime
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(419, 187);
			this.Controls.Add(this.btCancel);
			this.Controls.Add(this.btApply);
			this.Controls.Add(this.tabControl);
			this.MaximizeBox = false;
			this.Name = "frmPickDateTime";
			this.Resizable = false;
			this.Text = "Pick Date Time";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPickDateTime_FormClosing);
			this.Load += new System.EventHandler(this.frmPickDateTime_Load);
			this.tabControl.ResumeLayout(false);
			this.tabYear.ResumeLayout(false);
			this.tabYear.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.cbPickYear.Properties)).EndInit();
			this.tabDays.ResumeLayout(false);
			this.tabDays.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dpEnd.Properties.CalendarTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dpEnd.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dpStart.Properties.CalendarTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dpStart.Properties)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private MaterialSkin.Controls.MaterialTabControl tabControl;
		private System.Windows.Forms.TabPage tabYear;
		private System.Windows.Forms.TabPage tabDays;
		private MaterialSkin.Controls.MaterialRaisedButton btApply;
		private MaterialSkin.Controls.MaterialRaisedButton btCancel;
		private DevExpress.XtraEditors.ComboBoxEdit cbPickYear;
		private System.Windows.Forms.Label label1;
		private DevExpress.XtraEditors.DateEdit dpStart;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private DevExpress.XtraEditors.DateEdit dpEnd;
	}
}