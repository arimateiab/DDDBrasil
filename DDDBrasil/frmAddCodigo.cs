using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace DDDBrasil
{
    public partial class frmAddCodigo : Form
    {
        
        private string _ddd;
        public frmAddCodigo()
        {
            InitializeComponent();
        }

        public frmAddCodigo(string ddd)
        {
            InitializeComponent();
            _ddd = ddd;
        }

        private void dDDBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            dDDBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(codigoDDDDataSet);

        }

        private void frmAddCodigo_Load(object sender, EventArgs e)
        {
            if (_ddd != "")
            {
                btnSalvar.Text = "Atualizar";
                dDDTableAdapter.upVendedor(codigoDDDDataSet.DDD, _ddd);
            }
            else
            {
                // TODO: This line of code loads data into the 'codigoDDDDataSet.DDD' table. You can move, or remove it, as needed.
                dDDTableAdapter.Fill(codigoDDDDataSet.DDD);
                dDDBindingSource.AddNew();
                uFTextBox.Focus();
            }
            

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparTxt(this);
        }

        private void LimparTxt(Control controles)
        {

            foreach (Control ctl in controles.Controls)
            {
                if (ctl is TextBox) ctl.Text = "";
                if (ctl is MaskedTextBox) ctl.Text = "";
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (btnSalvar.Text == @"Atualizar" )
            {
                var vend = vENDENDORTextBox.Text;
                var cod = txtddd.Text;
                var mul = mUNICÍPIOTextBox.Text;

                var c = new Conexao();
                c.Atualizar(vend, cod, mul);
                Close();
                
            }
            else
            {
                Validate();
                dDDBindingSource.EndEdit();
                tableAdapterManager.UpdateAll(codigoDDDDataSet);
                Close();
            }
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            dDDBindingSource.CancelEdit();
            LimparTxt(this);
        }

        private void btnFehcar_Click(object sender, EventArgs e)
        {
            dDDBindingSource.CancelEdit();
            LimparTxt(this);
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            dDDBindingSource.AddNew();
        }
    }
}
