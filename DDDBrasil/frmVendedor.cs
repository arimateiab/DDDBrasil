using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DDDBrasil
{
    public partial class frmVendedor : Form
    {
        public frmVendedor()
        {
            InitializeComponent();
        }

        private void vENDEDORBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            vENDEDORBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(codigoDDDDataSet);

        }

        private void frmVendedor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'codigoDDDDataSet.VENDEDOR' table. You can move, or remove it, as needed.
            vENDEDORTableAdapter.Fill(codigoDDDDataSet.VENDEDOR);
            vENDEDORBindingSource.AddNew();

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Validate();
            vENDEDORBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(codigoDDDDataSet);
            frmVendedor_Load(sender, e);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            vENDEDORBindingSource.AddNew();
        }

        private void btnFechcar_Click(object sender, EventArgs e)
        {
            vENDEDORBindingSource.CancelEdit();
            Close();
        }
    }
}
