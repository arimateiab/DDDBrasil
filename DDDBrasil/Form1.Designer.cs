namespace DDDBrasil
{
    partial class FrmDDD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDDD));
            this.dDDBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.dDDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.codigoDDDDataSet = new DDDBrasil.CodigoDDDDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.uFTextBox = new System.Windows.Forms.TextBox();
            this.lOCALIDADETextBox = new System.Windows.Forms.TextBox();
            this.mUNICÍPIOTextBox = new System.Windows.Forms.TextBox();
            this.cÓDIGO_DDDTextBox = new System.Windows.Forms.TextBox();
            this.dDDDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VENDENDOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbbPesquisa = new System.Windows.Forms.ComboBox();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.btnNovoDDD = new System.Windows.Forms.Button();
            this.vENDENDORComboBox = new System.Windows.Forms.ComboBox();
            this.vENDEDORBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnCadVendedor = new System.Windows.Forms.Button();
            this.dDDTableAdapter = new DDDBrasil.CodigoDDDDataSetTableAdapters.DDDTableAdapter();
            this.tableAdapterManager = new DDDBrasil.CodigoDDDDataSetTableAdapters.TableAdapterManager();
            this.vENDEDORTableAdapter = new DDDBrasil.CodigoDDDDataSetTableAdapters.VENDEDORTableAdapter();
            this.btnAtualizar = new System.Windows.Forms.Button();
            uFLabel = new System.Windows.Forms.Label();
            lOCALIDADELabel = new System.Windows.Forms.Label();
            mUNICÍPIOLabel = new System.Windows.Forms.Label();
            cÓDIGO_DDDLabel = new System.Windows.Forms.Label();
            vENDENDORLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dDDBindingNavigator)).BeginInit();
            this.dDDBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dDDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codigoDDDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dDDDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENDEDORBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // uFLabel
            // 
            uFLabel.AutoSize = true;
            uFLabel.Location = new System.Drawing.Point(21, 77);
            uFLabel.Name = "uFLabel";
            uFLabel.Size = new System.Drawing.Size(24, 13);
            uFLabel.TabIndex = 3;
            uFLabel.Text = "UF:";
            // 
            // lOCALIDADELabel
            // 
            lOCALIDADELabel.AutoSize = true;
            lOCALIDADELabel.Location = new System.Drawing.Point(94, 77);
            lOCALIDADELabel.Name = "lOCALIDADELabel";
            lOCALIDADELabel.Size = new System.Drawing.Size(77, 13);
            lOCALIDADELabel.TabIndex = 4;
            lOCALIDADELabel.Text = "LOCALIDADE:";
            // 
            // mUNICÍPIOLabel
            // 
            mUNICÍPIOLabel.AutoSize = true;
            mUNICÍPIOLabel.Location = new System.Drawing.Point(320, 77);
            mUNICÍPIOLabel.Name = "mUNICÍPIOLabel";
            mUNICÍPIOLabel.Size = new System.Drawing.Size(66, 13);
            mUNICÍPIOLabel.TabIndex = 5;
            mUNICÍPIOLabel.Text = "MUNICÍPIO:";
            // 
            // cÓDIGO_DDDLabel
            // 
            cÓDIGO_DDDLabel.AutoSize = true;
            cÓDIGO_DDDLabel.Location = new System.Drawing.Point(546, 77);
            cÓDIGO_DDDLabel.Name = "cÓDIGO_DDDLabel";
            cÓDIGO_DDDLabel.Size = new System.Drawing.Size(79, 13);
            cÓDIGO_DDDLabel.TabIndex = 6;
            cÓDIGO_DDDLabel.Text = "CÓDIGO DDD:";
            // 
            // vENDENDORLabel
            // 
            vENDENDORLabel.AutoSize = true;
            vENDENDORLabel.Location = new System.Drawing.Point(646, 76);
            vENDENDORLabel.Name = "vENDENDORLabel";
            vENDENDORLabel.Size = new System.Drawing.Size(79, 13);
            vENDENDORLabel.TabIndex = 7;
            vENDENDORLabel.Text = "VENDENDOR:";
            // 
            // dDDBindingNavigator
            // 
            this.dDDBindingNavigator.AddNewItem = null;
            this.dDDBindingNavigator.BindingSource = this.dDDBindingSource;
            this.dDDBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.dDDBindingNavigator.DeleteItem = null;
            this.dDDBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.dDDBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.dDDBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.dDDBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.dDDBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.dDDBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.dDDBindingNavigator.Name = "dDDBindingNavigator";
            this.dDDBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.dDDBindingNavigator.Size = new System.Drawing.Size(822, 25);
            this.dDDBindingNavigator.TabIndex = 0;
            this.dDDBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // uFTextBox
            // 
            this.uFTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dDDBindingSource, "UF", true));
            this.uFTextBox.Location = new System.Drawing.Point(21, 93);
            this.uFTextBox.Name = "uFTextBox";
            this.uFTextBox.ReadOnly = true;
            this.uFTextBox.Size = new System.Drawing.Size(46, 20);
            this.uFTextBox.TabIndex = 8;
            // 
            // lOCALIDADETextBox
            // 
            this.lOCALIDADETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dDDBindingSource, "LOCALIDADE", true));
            this.lOCALIDADETextBox.Location = new System.Drawing.Point(94, 93);
            this.lOCALIDADETextBox.Name = "lOCALIDADETextBox";
            this.lOCALIDADETextBox.ReadOnly = true;
            this.lOCALIDADETextBox.Size = new System.Drawing.Size(199, 20);
            this.lOCALIDADETextBox.TabIndex = 9;
            // 
            // mUNICÍPIOTextBox
            // 
            this.mUNICÍPIOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dDDBindingSource, "MUNICÍPIO", true));
            this.mUNICÍPIOTextBox.Location = new System.Drawing.Point(320, 93);
            this.mUNICÍPIOTextBox.Name = "mUNICÍPIOTextBox";
            this.mUNICÍPIOTextBox.ReadOnly = true;
            this.mUNICÍPIOTextBox.Size = new System.Drawing.Size(199, 20);
            this.mUNICÍPIOTextBox.TabIndex = 10;
            // 
            // cÓDIGO_DDDTextBox
            // 
            this.cÓDIGO_DDDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dDDBindingSource, "CÓDIGO DDD", true));
            this.cÓDIGO_DDDTextBox.Location = new System.Drawing.Point(546, 93);
            this.cÓDIGO_DDDTextBox.Name = "cÓDIGO_DDDTextBox";
            this.cÓDIGO_DDDTextBox.ReadOnly = true;
            this.cÓDIGO_DDDTextBox.Size = new System.Drawing.Size(73, 20);
            this.cÓDIGO_DDDTextBox.TabIndex = 11;
            // 
            // dDDDataGridView
            // 
            this.dDDDataGridView.AllowUserToAddRows = false;
            this.dDDDataGridView.AllowUserToDeleteRows = false;
            this.dDDDataGridView.AllowUserToResizeColumns = false;
            this.dDDDataGridView.AllowUserToResizeRows = false;
            this.dDDDataGridView.AutoGenerateColumns = false;
            this.dDDDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dDDDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dDDDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.VENDENDOR});
            this.dDDDataGridView.DataSource = this.dDDBindingSource;
            this.dDDDataGridView.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dDDDataGridView.Location = new System.Drawing.Point(21, 133);
            this.dDDDataGridView.Name = "dDDDataGridView";
            this.dDDDataGridView.ReadOnly = true;
            this.dDDDataGridView.Size = new System.Drawing.Size(789, 284);
            this.dDDDataGridView.TabIndex = 14;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "UF";
            this.dataGridViewTextBoxColumn1.HeaderText = "UF";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 30;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "LOCALIDADE";
            this.dataGridViewTextBoxColumn2.HeaderText = "LOCALIDADE";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 280;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "MUNICÍPIO";
            this.dataGridViewTextBoxColumn3.HeaderText = "MUNICÍPIO";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 260;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "CÓDIGO DDD";
            this.dataGridViewTextBoxColumn4.HeaderText = "DDD";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 40;
            // 
            // VENDENDOR
            // 
            this.VENDENDOR.DataPropertyName = "VENDENDOR";
            this.VENDENDOR.HeaderText = "VENDENDOR";
            this.VENDENDOR.Name = "VENDENDOR";
            this.VENDENDOR.ReadOnly = true;
            this.VENDENDOR.Width = 120;
            // 
            // cbbPesquisa
            // 
            this.cbbPesquisa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbPesquisa.FormattingEnabled = true;
            this.cbbPesquisa.Items.AddRange(new object[] {
            "MUNICIPIO",
            "VENDEDOR",
            "DDD"});
            this.cbbPesquisa.Location = new System.Drawing.Point(143, 40);
            this.cbbPesquisa.Name = "cbbPesquisa";
            this.cbbPesquisa.Size = new System.Drawing.Size(117, 21);
            this.cbbPesquisa.TabIndex = 2;
            this.cbbPesquisa.SelectedIndexChanged += new System.EventHandler(this.cbbPesquisa_SelectedIndexChanged);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(21, 40);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(116, 20);
            this.txtPesquisa.TabIndex = 1;
            this.txtPesquisa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPesquisa_KeyPress);
            // 
            // btnNovoDDD
            // 
            this.btnNovoDDD.Location = new System.Drawing.Point(635, 423);
            this.btnNovoDDD.Name = "btnNovoDDD";
            this.btnNovoDDD.Size = new System.Drawing.Size(75, 23);
            this.btnNovoDDD.TabIndex = 15;
            this.btnNovoDDD.Text = "Novo";
            this.btnNovoDDD.UseVisualStyleBackColor = true;
            this.btnNovoDDD.Click += new System.EventHandler(this.btnNovoDDD_Click);
            // 
            // vENDENDORComboBox
            // 
            this.vENDENDORComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dDDBindingSource, "VENDENDOR", true));
            this.vENDENDORComboBox.DataSource = this.vENDEDORBindingSource;
            this.vENDENDORComboBox.DisplayMember = "NOME";
            this.vENDENDORComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.vENDENDORComboBox.FormattingEnabled = true;
            this.vENDENDORComboBox.Location = new System.Drawing.Point(646, 92);
            this.vENDENDORComboBox.Name = "vENDENDORComboBox";
            this.vENDENDORComboBox.Size = new System.Drawing.Size(118, 21);
            this.vENDENDORComboBox.TabIndex = 12;
            this.vENDENDORComboBox.ValueMember = "NOME";
            // 
            // vENDEDORBindingSource
            // 
            this.vENDEDORBindingSource.DataMember = "VENDEDOR";
            this.vENDEDORBindingSource.DataSource = this.codigoDDDDataSet;
            // 
            // btnCadVendedor
            // 
            this.btnCadVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadVendedor.Location = new System.Drawing.Point(770, 91);
            this.btnCadVendedor.Name = "btnCadVendedor";
            this.btnCadVendedor.Size = new System.Drawing.Size(40, 23);
            this.btnCadVendedor.TabIndex = 13;
            this.btnCadVendedor.Text = ". . .";
            this.btnCadVendedor.UseVisualStyleBackColor = true;
            this.btnCadVendedor.Click += new System.EventHandler(this.btnCadVendedor_Click);
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
            this.tableAdapterManager.VENDEDORTableAdapter = null;
            // 
            // vENDEDORTableAdapter
            // 
            this.vENDEDORTableAdapter.ClearBeforeFill = true;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(717, 423);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(75, 23);
            this.btnAtualizar.TabIndex = 16;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // FrmDDD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 455);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnCadVendedor);
            this.Controls.Add(vENDENDORLabel);
            this.Controls.Add(this.vENDENDORComboBox);
            this.Controls.Add(this.btnNovoDDD);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.cbbPesquisa);
            this.Controls.Add(this.dDDDataGridView);
            this.Controls.Add(uFLabel);
            this.Controls.Add(this.uFTextBox);
            this.Controls.Add(lOCALIDADELabel);
            this.Controls.Add(this.lOCALIDADETextBox);
            this.Controls.Add(mUNICÍPIOLabel);
            this.Controls.Add(this.mUNICÍPIOTextBox);
            this.Controls.Add(cÓDIGO_DDDLabel);
            this.Controls.Add(this.cÓDIGO_DDDTextBox);
            this.Controls.Add(this.dDDBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmDDD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DDDs do Brasil";
            this.Load += new System.EventHandler(this.FrmDDD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dDDBindingNavigator)).EndInit();
            this.dDDBindingNavigator.ResumeLayout(false);
            this.dDDBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dDDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codigoDDDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dDDDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENDEDORBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CodigoDDDDataSet codigoDDDDataSet;
        private System.Windows.Forms.BindingSource dDDBindingSource;
        private CodigoDDDDataSetTableAdapters.DDDTableAdapter dDDTableAdapter;
        private CodigoDDDDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator dDDBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.TextBox uFTextBox;
        private System.Windows.Forms.TextBox lOCALIDADETextBox;
        private System.Windows.Forms.TextBox mUNICÍPIOTextBox;
        private System.Windows.Forms.TextBox cÓDIGO_DDDTextBox;
        private System.Windows.Forms.ComboBox cbbPesquisa;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Button btnNovoDDD;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn VENDENDOR;
        private System.Windows.Forms.ComboBox vENDENDORComboBox;
        private System.Windows.Forms.BindingSource vENDEDORBindingSource;
        private CodigoDDDDataSetTableAdapters.VENDEDORTableAdapter vENDEDORTableAdapter;
        private System.Windows.Forms.Button btnCadVendedor;
        private System.Windows.Forms.DataGridView dDDDataGridView;
        private System.Windows.Forms.Button btnAtualizar;
    }
}

