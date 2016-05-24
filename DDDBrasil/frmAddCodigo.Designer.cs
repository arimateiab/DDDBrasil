namespace DDDBrasil
{
    partial class frmAddCodigo
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
            System.Windows.Forms.Label uFLabel;
            System.Windows.Forms.Label lOCALIDADELabel;
            System.Windows.Forms.Label mUNICÍPIOLabel;
            System.Windows.Forms.Label cÓDIGO_DDDLabel;
            System.Windows.Forms.Label vENDENDORLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddCodigo));
            this.uFTextBox = new System.Windows.Forms.TextBox();
            this.lOCALIDADETextBox = new System.Windows.Forms.TextBox();
            this.mUNICÍPIOTextBox = new System.Windows.Forms.TextBox();
            this.txtddd = new System.Windows.Forms.MaskedTextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnFehcar = new System.Windows.Forms.Button();
            this.vENDENDORTextBox = new System.Windows.Forms.TextBox();
            this.dDDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.codigoDDDDataSet = new DDDBrasil.CodigoDDDDataSet();
            this.dDDTableAdapter = new DDDBrasil.CodigoDDDDataSetTableAdapters.DDDTableAdapter();
            this.tableAdapterManager = new DDDBrasil.CodigoDDDDataSetTableAdapters.TableAdapterManager();
            uFLabel = new System.Windows.Forms.Label();
            lOCALIDADELabel = new System.Windows.Forms.Label();
            mUNICÍPIOLabel = new System.Windows.Forms.Label();
            cÓDIGO_DDDLabel = new System.Windows.Forms.Label();
            vENDENDORLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dDDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codigoDDDDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // uFLabel
            // 
            uFLabel.AutoSize = true;
            uFLabel.Location = new System.Drawing.Point(15, 56);
            uFLabel.Name = "uFLabel";
            uFLabel.Size = new System.Drawing.Size(24, 13);
            uFLabel.TabIndex = 9;
            uFLabel.Text = "UF:";
            // 
            // lOCALIDADELabel
            // 
            lOCALIDADELabel.AutoSize = true;
            lOCALIDADELabel.Location = new System.Drawing.Point(70, 56);
            lOCALIDADELabel.Name = "lOCALIDADELabel";
            lOCALIDADELabel.Size = new System.Drawing.Size(77, 13);
            lOCALIDADELabel.TabIndex = 10;
            lOCALIDADELabel.Text = "LOCALIDADE:";
            // 
            // mUNICÍPIOLabel
            // 
            mUNICÍPIOLabel.AutoSize = true;
            mUNICÍPIOLabel.Location = new System.Drawing.Point(278, 56);
            mUNICÍPIOLabel.Name = "mUNICÍPIOLabel";
            mUNICÍPIOLabel.Size = new System.Drawing.Size(66, 13);
            mUNICÍPIOLabel.TabIndex = 11;
            mUNICÍPIOLabel.Text = "MUNICÍPIO:";
            // 
            // cÓDIGO_DDDLabel
            // 
            cÓDIGO_DDDLabel.AutoSize = true;
            cÓDIGO_DDDLabel.Location = new System.Drawing.Point(491, 56);
            cÓDIGO_DDDLabel.Name = "cÓDIGO_DDDLabel";
            cÓDIGO_DDDLabel.Size = new System.Drawing.Size(31, 13);
            cÓDIGO_DDDLabel.TabIndex = 12;
            cÓDIGO_DDDLabel.Text = "DDD";
            // 
            // uFTextBox
            // 
            this.uFTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dDDBindingSource, "UF", true));
            this.uFTextBox.Location = new System.Drawing.Point(18, 72);
            this.uFTextBox.Name = "uFTextBox";
            this.uFTextBox.Size = new System.Drawing.Size(43, 20);
            this.uFTextBox.TabIndex = 5;
            // 
            // lOCALIDADETextBox
            // 
            this.lOCALIDADETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dDDBindingSource, "LOCALIDADE", true));
            this.lOCALIDADETextBox.Location = new System.Drawing.Point(70, 72);
            this.lOCALIDADETextBox.Name = "lOCALIDADETextBox";
            this.lOCALIDADETextBox.Size = new System.Drawing.Size(198, 20);
            this.lOCALIDADETextBox.TabIndex = 6;
            // 
            // mUNICÍPIOTextBox
            // 
            this.mUNICÍPIOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dDDBindingSource, "MUNICÍPIO", true));
            this.mUNICÍPIOTextBox.Location = new System.Drawing.Point(281, 72);
            this.mUNICÍPIOTextBox.Name = "mUNICÍPIOTextBox";
            this.mUNICÍPIOTextBox.Size = new System.Drawing.Size(198, 20);
            this.mUNICÍPIOTextBox.TabIndex = 7;
            // 
            // txtddd
            // 
            this.txtddd.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dDDBindingSource, "CÓDIGO DDD", true));
            this.txtddd.Location = new System.Drawing.Point(494, 72);
            this.txtddd.Mask = "###";
            this.txtddd.Name = "txtddd";
            this.txtddd.Size = new System.Drawing.Size(28, 20);
            this.txtddd.TabIndex = 8;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(19, 11);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(102, 32);
            this.btnLimpar.TabIndex = 0;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(150, 11);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(102, 32);
            this.btnSalvar.TabIndex = 1;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(281, 11);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(102, 32);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(412, 11);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(102, 32);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Adcionar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnFehcar
            // 
            this.btnFehcar.Location = new System.Drawing.Point(543, 11);
            this.btnFehcar.Name = "btnFehcar";
            this.btnFehcar.Size = new System.Drawing.Size(102, 32);
            this.btnFehcar.TabIndex = 4;
            this.btnFehcar.Text = "Fechar";
            this.btnFehcar.UseVisualStyleBackColor = true;
            this.btnFehcar.Click += new System.EventHandler(this.btnFehcar_Click);
            // 
            // vENDENDORLabel
            // 
            vENDENDORLabel.AutoSize = true;
            vENDENDORLabel.Location = new System.Drawing.Point(527, 56);
            vENDENDORLabel.Name = "vENDENDORLabel";
            vENDENDORLabel.Size = new System.Drawing.Size(79, 13);
            vENDENDORLabel.TabIndex = 13;
            vENDENDORLabel.Text = "VENDENDOR:";
            // 
            // vENDENDORTextBox
            // 
            this.vENDENDORTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dDDBindingSource, "VENDENDOR", true));
            this.vENDENDORTextBox.Location = new System.Drawing.Point(528, 72);
            this.vENDENDORTextBox.Name = "vENDENDORTextBox";
            this.vENDENDORTextBox.Size = new System.Drawing.Size(117, 20);
            this.vENDENDORTextBox.TabIndex = 14;
            // 
            // dDDBindingSource
            // 
            this.dDDBindingSource.DataMember = "DDD";
            this.dDDBindingSource.DataSource = this.codigoDDDDataSet;
            // 
            // codigoDDDDataSet
            // 
            this.codigoDDDDataSet.DataSetName = "CodigoDDDDataSet";
            this.codigoDDDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dDDTableAdapter
            // 
            this.dDDTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DDDTableAdapter = this.dDDTableAdapter;
            this.tableAdapterManager.UpdateOrder = DDDBrasil.CodigoDDDDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // frmAddCodigo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 102);
            this.Controls.Add(vENDENDORLabel);
            this.Controls.Add(this.vENDENDORTextBox);
            this.Controls.Add(this.btnFehcar);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.txtddd);
            this.Controls.Add(uFLabel);
            this.Controls.Add(this.uFTextBox);
            this.Controls.Add(lOCALIDADELabel);
            this.Controls.Add(this.lOCALIDADETextBox);
            this.Controls.Add(mUNICÍPIOLabel);
            this.Controls.Add(this.mUNICÍPIOTextBox);
            this.Controls.Add(cÓDIGO_DDDLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddCodigo";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Novo DDD";
            this.Load += new System.EventHandler(this.frmAddCodigo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dDDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codigoDDDDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CodigoDDDDataSet codigoDDDDataSet;
        private System.Windows.Forms.BindingSource dDDBindingSource;
        private CodigoDDDDataSetTableAdapters.DDDTableAdapter dDDTableAdapter;
        private CodigoDDDDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox uFTextBox;
        private System.Windows.Forms.TextBox lOCALIDADETextBox;
        private System.Windows.Forms.TextBox mUNICÍPIOTextBox;
        private System.Windows.Forms.MaskedTextBox txtddd;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnFehcar;
        private System.Windows.Forms.TextBox vENDENDORTextBox;
    }
}