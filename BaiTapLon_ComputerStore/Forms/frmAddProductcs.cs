using DAOClassesLibrary;
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
	public partial class frmAddProductcs : MetroFramework.Forms.MetroForm
	{
		TypeDAO td = new TypeDAO();
		SupplierDAO sd = new SupplierDAO();
		ProductDAO pd = new ProductDAO();
		public bool check { get; set; }
		public string productID { get; set; }
		public frmAddProductcs()
		{
			InitializeComponent();
		}

		private void frmAddProductcs_Load(object sender, EventArgs e)
		{
			//Combox Types
			cbType.DataSource = td.getTable();
			cbType.DisplayMember = "TypeName";
			cbType.ValueMember = "ID_Type";
			//Combox Suppliers
			cbSupplier.DataSource = sd.getTable();
			cbSupplier.DisplayMember = "CompanyName";
			cbSupplier.ValueMember = "ID_supplier";
		}

		private void sbtCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void sbtApply_Click(object sender, EventArgs e)
		{
			if (!checkEmpty()) return;
			if (pd.AddObject(getProduct()))
			{
				if (mcbCreateID.Checked) pd.updateTEMP(txID.Text);
				check = true;
				productID = txID.Text;
				this.Close();
			}
			else
			{
				check = false;
			}
		}
		//
		// auto create ID
		private void mcbCreateID_CheckedChanged(object sender, EventArgs e)
		{
			if (mcbCreateID.Checked)
			{
				txID.Text = pd.createProductID();
				txID.Enabled = false;
			}
			else
			{
				txID.Text = "";
				txID.Enabled = true;
			}
		}
		//
		//Check All control text Empty
		bool checkEmpty()
		{
			if (String.IsNullOrEmpty(txID.Text))
			{
				MessageBox.Show("Please enter full information!", "Warring!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txID.Focus();
				return false;
			}
			if (String.IsNullOrEmpty(txName.Text))
			{
				MessageBox.Show("Please enter full information!", "Warring!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txName.Focus();
				return false;
			}
			if (String.IsNullOrEmpty(cbSupplier.Text))
			{
				MessageBox.Show("Please enter full information!", "Warring!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				cbSupplier.Focus();
				return false;
			}
			if (String.IsNullOrEmpty(cbType.Text))
			{
				MessageBox.Show("Please enter full information!", "Warring!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				cbType.Focus();
				return false;
			}
			if (!pd.checkID(txID.Text))
			{
				MessageBox.Show("Product ID is unavailable", "Warring!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txID.Focus();
				return false;
			}
			return true;
		}
		//
		//Get Product
		Products getProduct()
		{
			Products p = new Products();
			p.productID = txID.Text;
			p.productName = txName.Text;
			Types t = td.getObject(cbType.SelectedValue.ToString());
			Supplier s = sd.getObject(cbSupplier.SelectedValue.ToString());
			p.Type = t;
			p.supplier = s;
			p.warranty = Convert.ToInt16(txWarranty.Text);
			p.productPrice = 0;
			p.purchasePrice = 0;
			return p;
		}

	}
}
