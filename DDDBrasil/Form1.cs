using System;
using System.Windows.Forms;

namespace DDDBrasil
{
    public partial class FrmDDD : Form
    {
        public FrmDDD()
        {
            InitializeComponent();
        }

        private void dDDBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            dDDBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(codigoDDDDataSet);

        }

        private void FrmDDD_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'codigoDDDDataSet.VENDEDOR' table. You can move, or remove it, as needed.
            vENDEDORTableAdapter.Fill(codigoDDDDataSet.VENDEDOR);
            // TODO: This line of code loads data into the 'codigoDDDDataSet.DDD' table. You can move, or remove it, as needed.
            dDDTableAdapter.Fill(codigoDDDDataSet.DDD);

        }

        private void Pesquisar()
        {
            if (cbbPesquisa.Text == "MUNICIPIO")
            {
                dDDTableAdapter.municipio(codigoDDDDataSet.DDD, txtPesquisa.Text);
            }
            if (cbbPesquisa.Text == "DDD")
            {
                dDDTableAdapter.codigoddd(codigoDDDDataSet.DDD, txtPesquisa.Text);
            }
            if (cbbPesquisa.Text == "VENDEDOR")
            {
                vENDEDORTableAdapter.FillVendedor(codigoDDDDataSet.VENDEDOR, txtPesquisa.Text);
            }

        }

        private void txtPesquisa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Pesquisar();
            }
        }

        private void cbbPesquisa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtPesquisa.Text == "")
            {
                FrmDDD_Load(sender, e);
            }
            else
            {
                Pesquisar();
            }
            
        }

        private void btnNovoDDD_Click(object sender, EventArgs e)
        {
            frmAddCodigo f = new frmAddCodigo();
            f.ShowDialog();
            FrmDDD_Load(sender, e);
        }

        private void btnCadVendedor_Click(object sender, EventArgs e)
        {
            frmVendedor v = new frmVendedor();
            v.ShowDialog();
            FrmDDD_Load(sender, e);
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            var a = new frmAddCodigo(cÓDIGO_DDDTextBox.Text);
            a.ShowDialog();
            FrmDDD_Load(sender, e);
        }
    }
}
