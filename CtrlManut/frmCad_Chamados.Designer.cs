namespace CtrlManut
{
    partial class frmCad_Chamados
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
            System.Windows.Forms.Label equip_nomeLabel;
            System.Windows.Forms.Label equip_localLabel;
            System.Windows.Forms.Label func_nomeLabel;
            System.Windows.Forms.Label prob_tipoLabel;
            System.Windows.Forms.Label prob_nomeLabel;
            System.Windows.Forms.Label cham_idLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCad_Chamados));
            this.cM_DataSet = new CtrlManut.CM_DataSet();
            this.tab_equipamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tab_equipamentoTableAdapter = new CtrlManut.CM_DataSetTableAdapters.tab_equipamentoTableAdapter();
            this.tableAdapterManager = new CtrlManut.CM_DataSetTableAdapters.TableAdapterManager();
            this.equip_nomeComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.equip_localComboBox = new System.Windows.Forms.ComboBox();
            this.tab_funcionariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tab_funcionariosTableAdapter = new CtrlManut.CM_DataSetTableAdapters.tab_funcionariosTableAdapter();
            this.func_nomeComboBox = new System.Windows.Forms.ComboBox();
            this.tab_problemasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tab_problemasTableAdapter = new CtrlManut.CM_DataSetTableAdapters.tab_problemasTableAdapter();
            this.prob_tipoComboBox = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.tab_chamadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tab_chamadosTableAdapter = new CtrlManut.CM_DataSetTableAdapters.tab_chamadosTableAdapter();
            this.cham_idLabel1 = new System.Windows.Forms.Label();
            this.prob_nomeComboBox = new System.Windows.Forms.ComboBox();
            equip_nomeLabel = new System.Windows.Forms.Label();
            equip_localLabel = new System.Windows.Forms.Label();
            func_nomeLabel = new System.Windows.Forms.Label();
            prob_tipoLabel = new System.Windows.Forms.Label();
            prob_nomeLabel = new System.Windows.Forms.Label();
            cham_idLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cM_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tab_equipamentoBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tab_funcionariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tab_problemasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tab_chamadosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cM_DataSet
            // 
            this.cM_DataSet.DataSetName = "CM_DataSet";
            this.cM_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tab_equipamentoBindingSource
            // 
            this.tab_equipamentoBindingSource.DataMember = "tab_equipamento";
            this.tab_equipamentoBindingSource.DataSource = this.cM_DataSet;
            // 
            // tab_equipamentoTableAdapter
            // 
            this.tab_equipamentoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tab_chamadosTableAdapter = this.tab_chamadosTableAdapter;
            this.tableAdapterManager.tab_equipamentoTableAdapter = this.tab_equipamentoTableAdapter;
            this.tableAdapterManager.tab_funcionariosTableAdapter = this.tab_funcionariosTableAdapter;
            this.tableAdapterManager.tab_osTableAdapter = null;
            this.tableAdapterManager.tab_problemasTableAdapter = this.tab_problemasTableAdapter;
            this.tableAdapterManager.tab_tecnicosTableAdapter = null;
            this.tableAdapterManager.tab_usuariosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CtrlManut.CM_DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // equip_nomeLabel
            // 
            equip_nomeLabel.AutoSize = true;
            equip_nomeLabel.Location = new System.Drawing.Point(6, 45);
            equip_nomeLabel.Name = "equip_nomeLabel";
            equip_nomeLabel.Size = new System.Drawing.Size(72, 13);
            equip_nomeLabel.TabIndex = 0;
            equip_nomeLabel.Text = "Equipamento:";
            // 
            // equip_nomeComboBox
            // 
            this.equip_nomeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tab_equipamentoBindingSource, "equip_nome", true));
            this.equip_nomeComboBox.DataSource = this.tab_equipamentoBindingSource;
            this.equip_nomeComboBox.DisplayMember = "equip_nome";
            this.equip_nomeComboBox.FormattingEnabled = true;
            this.equip_nomeComboBox.Location = new System.Drawing.Point(6, 61);
            this.equip_nomeComboBox.Name = "equip_nomeComboBox";
            this.equip_nomeComboBox.Size = new System.Drawing.Size(244, 21);
            this.equip_nomeComboBox.TabIndex = 1;
            this.equip_nomeComboBox.ValueMember = "equip_nome";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.prob_nomeComboBox);
            this.groupBox1.Controls.Add(cham_idLabel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cham_idLabel1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(prob_nomeLabel);
            this.groupBox1.Controls.Add(prob_tipoLabel);
            this.groupBox1.Controls.Add(this.prob_tipoComboBox);
            this.groupBox1.Controls.Add(func_nomeLabel);
            this.groupBox1.Controls.Add(this.func_nomeComboBox);
            this.groupBox1.Controls.Add(equip_localLabel);
            this.groupBox1.Controls.Add(this.equip_localComboBox);
            this.groupBox1.Controls.Add(this.equip_nomeComboBox);
            this.groupBox1.Controls.Add(equip_nomeLabel);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(561, 350);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chamado:";
            // 
            // equip_localLabel
            // 
            equip_localLabel.AutoSize = true;
            equip_localLabel.Location = new System.Drawing.Point(299, 45);
            equip_localLabel.Name = "equip_localLabel";
            equip_localLabel.Size = new System.Drawing.Size(36, 13);
            equip_localLabel.TabIndex = 2;
            equip_localLabel.Text = "Local:";
            // 
            // equip_localComboBox
            // 
            this.equip_localComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tab_equipamentoBindingSource, "equip_local", true));
            this.equip_localComboBox.FormattingEnabled = true;
            this.equip_localComboBox.Items.AddRange(new object[] {
            "",
            "Auditório",
            "Cinema",
            "Coordenação",
            "Secretaria",
            "Laboratório Informática",
            "Sala 27",
            "Sala 28",
            "Sala 29",
            "Sala 30",
            "Sala 31",
            "Sala 32",
            "Sala 33",
            "Sala 34",
            "Sala 35",
            "Sala 36",
            "Sala 37",
            "Sala 38",
            "Sala 39",
            "Sala 40",
            "Sala 41",
            "Sala 101",
            "Sala 102",
            "Sala 103",
            "Sala 201",
            "Sala 202",
            "Sala 203",
            "Sala 301",
            "Sala 302",
            "Sala 303",
            "Sala 401",
            "Sala 402",
            "Sala 403",
            "Sala 501",
            "Sala 502",
            "Sala 503"});
            this.equip_localComboBox.Location = new System.Drawing.Point(302, 61);
            this.equip_localComboBox.Name = "equip_localComboBox";
            this.equip_localComboBox.Size = new System.Drawing.Size(226, 21);
            this.equip_localComboBox.TabIndex = 3;
            // 
            // tab_funcionariosBindingSource
            // 
            this.tab_funcionariosBindingSource.DataMember = "tab_funcionarios";
            this.tab_funcionariosBindingSource.DataSource = this.cM_DataSet;
            // 
            // tab_funcionariosTableAdapter
            // 
            this.tab_funcionariosTableAdapter.ClearBeforeFill = true;
            // 
            // func_nomeLabel
            // 
            func_nomeLabel.AutoSize = true;
            func_nomeLabel.Location = new System.Drawing.Point(6, 94);
            func_nomeLabel.Name = "func_nomeLabel";
            func_nomeLabel.Size = new System.Drawing.Size(59, 13);
            func_nomeLabel.TabIndex = 4;
            func_nomeLabel.Text = "Solicitante:";
            // 
            // func_nomeComboBox
            // 
            this.func_nomeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tab_funcionariosBindingSource, "func_nome", true));
            this.func_nomeComboBox.DataSource = this.tab_funcionariosBindingSource;
            this.func_nomeComboBox.DisplayMember = "func_nome";
            this.func_nomeComboBox.FormattingEnabled = true;
            this.func_nomeComboBox.Location = new System.Drawing.Point(9, 110);
            this.func_nomeComboBox.Name = "func_nomeComboBox";
            this.func_nomeComboBox.Size = new System.Drawing.Size(241, 21);
            this.func_nomeComboBox.TabIndex = 5;
            this.func_nomeComboBox.ValueMember = "func_nome";
            // 
            // tab_problemasBindingSource
            // 
            this.tab_problemasBindingSource.DataMember = "tab_problemas";
            this.tab_problemasBindingSource.DataSource = this.cM_DataSet;
            // 
            // tab_problemasTableAdapter
            // 
            this.tab_problemasTableAdapter.ClearBeforeFill = true;
            // 
            // prob_tipoLabel
            // 
            prob_tipoLabel.AutoSize = true;
            prob_tipoLabel.Location = new System.Drawing.Point(299, 94);
            prob_tipoLabel.Name = "prob_tipoLabel";
            prob_tipoLabel.Size = new System.Drawing.Size(74, 13);
            prob_tipoLabel.TabIndex = 6;
            prob_tipoLabel.Text = "Problema tipo:";
            // 
            // prob_tipoComboBox
            // 
            this.prob_tipoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tab_problemasBindingSource, "prob_tipo", true));
            this.prob_tipoComboBox.FormattingEnabled = true;
            this.prob_tipoComboBox.Items.AddRange(new object[] {
            "",
            "Hardware",
            "Software"});
            this.prob_tipoComboBox.Location = new System.Drawing.Point(302, 110);
            this.prob_tipoComboBox.Name = "prob_tipoComboBox";
            this.prob_tipoComboBox.Size = new System.Drawing.Size(226, 21);
            this.prob_tipoComboBox.TabIndex = 7;
            // 
            // prob_nomeLabel
            // 
            prob_nomeLabel.AutoSize = true;
            prob_nomeLabel.Location = new System.Drawing.Point(6, 141);
            prob_nomeLabel.Name = "prob_nomeLabel";
            prob_nomeLabel.Size = new System.Drawing.Size(105, 13);
            prob_nomeLabel.TabIndex = 8;
            prob_nomeLabel.Text = "Descrição Problema:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 210);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(522, 125);
            this.textBox1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Observação:";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(385, 369);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(466, 369);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // tab_chamadosBindingSource
            // 
            this.tab_chamadosBindingSource.DataMember = "tab_chamados";
            this.tab_chamadosBindingSource.DataSource = this.cM_DataSet;
            // 
            // tab_chamadosTableAdapter
            // 
            this.tab_chamadosTableAdapter.ClearBeforeFill = true;
            // 
            // cham_idLabel
            // 
            cham_idLabel.AutoSize = true;
            cham_idLabel.Location = new System.Drawing.Point(9, 16);
            cham_idLabel.Name = "cham_idLabel";
            cham_idLabel.Size = new System.Drawing.Size(73, 13);
            cham_idLabel.TabIndex = 4;
            cham_idLabel.Text = "Nº. Chamado:";
            // 
            // cham_idLabel1
            // 
            this.cham_idLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tab_chamadosBindingSource, "cham_id", true));
            this.cham_idLabel1.Location = new System.Drawing.Point(103, 16);
            this.cham_idLabel1.Name = "cham_idLabel1";
            this.cham_idLabel1.Size = new System.Drawing.Size(105, 23);
            this.cham_idLabel1.TabIndex = 5;
            this.cham_idLabel1.Text = "label2";
            // 
            // prob_nomeComboBox
            // 
            this.prob_nomeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tab_problemasBindingSource, "prob_nome", true));
            this.prob_nomeComboBox.DataSource = this.tab_problemasBindingSource;
            this.prob_nomeComboBox.DisplayMember = "prob_nome";
            this.prob_nomeComboBox.FormattingEnabled = true;
            this.prob_nomeComboBox.Location = new System.Drawing.Point(9, 157);
            this.prob_nomeComboBox.Name = "prob_nomeComboBox";
            this.prob_nomeComboBox.Size = new System.Drawing.Size(519, 21);
            this.prob_nomeComboBox.TabIndex = 14;
            this.prob_nomeComboBox.ValueMember = "prob_nome";
            // 
            // frmCad_Chamados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 407);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCad_Chamados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Chamados";
            this.Load += new System.EventHandler(this.frmCad_Chamados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cM_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tab_equipamentoBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tab_funcionariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tab_problemasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tab_chamadosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CM_DataSet cM_DataSet;
        private System.Windows.Forms.BindingSource tab_equipamentoBindingSource;
        private CM_DataSetTableAdapters.tab_equipamentoTableAdapter tab_equipamentoTableAdapter;
        private CM_DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private CM_DataSetTableAdapters.tab_funcionariosTableAdapter tab_funcionariosTableAdapter;
        private System.Windows.Forms.ComboBox equip_nomeComboBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox equip_localComboBox;
        private System.Windows.Forms.BindingSource tab_funcionariosBindingSource;
        private CM_DataSetTableAdapters.tab_problemasTableAdapter tab_problemasTableAdapter;
        private System.Windows.Forms.ComboBox func_nomeComboBox;
        private System.Windows.Forms.BindingSource tab_problemasBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox prob_tipoComboBox;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnSair;
        private CM_DataSetTableAdapters.tab_chamadosTableAdapter tab_chamadosTableAdapter;
        private System.Windows.Forms.BindingSource tab_chamadosBindingSource;
        private System.Windows.Forms.Label cham_idLabel1;
        private System.Windows.Forms.ComboBox prob_nomeComboBox;

    }
}