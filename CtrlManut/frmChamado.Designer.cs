namespace CtrlManut
{
    partial class frmChamado
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtOsAberta = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.TextBox();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbFunc = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbProb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbEquip = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAbrirOS = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstCham = new System.Windows.Forms.ListView();
            this.Codigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Equipamento = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Funcionario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Problema = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Observacao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Data = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OsAberta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbEquip = new System.Windows.Forms.RadioButton();
            this.rbFunc = new System.Windows.Forms.RadioButton();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.epErro = new System.Windows.Forms.ErrorProvider(this.components);
            this.ttCham = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epErro)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtOsAberta);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtData);
            this.groupBox1.Controls.Add(this.txtObs);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbFunc);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbProb);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbEquip);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(743, 236);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Novo Chamado";
            // 
            // txtOsAberta
            // 
            this.txtOsAberta.Enabled = false;
            this.txtOsAberta.Location = new System.Drawing.Point(13, 202);
            this.txtOsAberta.Name = "txtOsAberta";
            this.txtOsAberta.Size = new System.Drawing.Size(87, 20);
            this.txtOsAberta.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "OS Aberta?";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Data:";
            // 
            // txtData
            // 
            this.txtData.Enabled = false;
            this.txtData.Location = new System.Drawing.Point(10, 146);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(223, 20);
            this.txtData.TabIndex = 8;
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(350, 90);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(387, 91);
            this.txtObs.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(347, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Observação:";
            // 
            // cmbFunc
            // 
            this.cmbFunc.FormattingEnabled = true;
            this.cmbFunc.Location = new System.Drawing.Point(10, 90);
            this.cmbFunc.Name = "cmbFunc";
            this.cmbFunc.Size = new System.Drawing.Size(304, 21);
            this.cmbFunc.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Funcionário:";
            // 
            // cmbProb
            // 
            this.cmbProb.FormattingEnabled = true;
            this.cmbProb.Location = new System.Drawing.Point(350, 36);
            this.cmbProb.Name = "cmbProb";
            this.cmbProb.Size = new System.Drawing.Size(324, 21);
            this.cmbProb.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(347, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Problema:";
            // 
            // cmbEquip
            // 
            this.cmbEquip.FormattingEnabled = true;
            this.cmbEquip.Location = new System.Drawing.Point(10, 36);
            this.cmbEquip.Name = "cmbEquip";
            this.cmbEquip.Size = new System.Drawing.Size(304, 21);
            this.cmbEquip.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Equipamento:";
            // 
            // btnAbrirOS
            // 
            this.btnAbrirOS.Image = global::CtrlManut.Properties.Resources.Note;
            this.btnAbrirOS.Location = new System.Drawing.Point(276, 512);
            this.btnAbrirOS.Name = "btnAbrirOS";
            this.btnAbrirOS.Size = new System.Drawing.Size(75, 57);
            this.btnAbrirOS.TabIndex = 1;
            this.btnAbrirOS.UseVisualStyleBackColor = true;
            this.btnAbrirOS.Click += new System.EventHandler(this.btnAbrirOS_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Image = global::CtrlManut.Properties.Resources.pencil_48;
            this.btnEditar.Location = new System.Drawing.Point(357, 512);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 57);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Image = global::CtrlManut.Properties.Resources.delete_48;
            this.btnExcluir.Location = new System.Drawing.Point(438, 512);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 57);
            this.btnExcluir.TabIndex = 3;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.Image = global::CtrlManut.Properties.Resources.save_48;
            this.btnGravar.Location = new System.Drawing.Point(519, 512);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 57);
            this.btnGravar.TabIndex = 4;
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Image = global::CtrlManut.Properties.Resources.search_48;
            this.btnPesquisar.Location = new System.Drawing.Point(600, 512);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 57);
            this.btnPesquisar.TabIndex = 5;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Image = global::CtrlManut.Properties.Resources.Shutdown_48;
            this.btnSair.Location = new System.Drawing.Point(681, 512);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 57);
            this.btnSair.TabIndex = 6;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstCham);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.txtPesquisar);
            this.groupBox2.Location = new System.Drawing.Point(13, 256);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(743, 235);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Consultar Chamado";
            // 
            // lstCham
            // 
            this.lstCham.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Codigo,
            this.Equipamento,
            this.Funcionario,
            this.Problema,
            this.Observacao,
            this.Data,
            this.OsAberta});
            this.lstCham.FullRowSelect = true;
            this.lstCham.GridLines = true;
            this.lstCham.Location = new System.Drawing.Point(6, 67);
            this.lstCham.Name = "lstCham";
            this.lstCham.Size = new System.Drawing.Size(731, 161);
            this.lstCham.TabIndex = 5;
            this.lstCham.UseCompatibleStateImageBehavior = false;
            this.lstCham.View = System.Windows.Forms.View.Details;
            // 
            // Codigo
            // 
            this.Codigo.Text = "Código";
            // 
            // Equipamento
            // 
            this.Equipamento.Text = "Equipamento";
            this.Equipamento.Width = 126;
            // 
            // Funcionario
            // 
            this.Funcionario.Text = "Funcionário";
            this.Funcionario.Width = 173;
            // 
            // Problema
            // 
            this.Problema.Text = "Problema";
            this.Problema.Width = 115;
            // 
            // Observacao
            // 
            this.Observacao.Text = "Observação";
            this.Observacao.Width = 115;
            // 
            // Data
            // 
            this.Data.Text = "Data";
            // 
            // OsAberta
            // 
            this.OsAberta.Text = "OS Aberta?";
            this.OsAberta.Width = 72;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbEquip);
            this.groupBox3.Controls.Add(this.rbFunc);
            this.groupBox3.Location = new System.Drawing.Point(13, 20);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(199, 41);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pesquisar por:";
            // 
            // rbEquip
            // 
            this.rbEquip.AutoSize = true;
            this.rbEquip.Location = new System.Drawing.Point(6, 18);
            this.rbEquip.Name = "rbEquip";
            this.rbEquip.Size = new System.Drawing.Size(87, 17);
            this.rbEquip.TabIndex = 0;
            this.rbEquip.TabStop = true;
            this.rbEquip.Text = "Equipamento";
            this.rbEquip.UseVisualStyleBackColor = true;
            // 
            // rbFunc
            // 
            this.rbFunc.AutoSize = true;
            this.rbFunc.Location = new System.Drawing.Point(111, 18);
            this.rbFunc.Name = "rbFunc";
            this.rbFunc.Size = new System.Drawing.Size(80, 17);
            this.rbFunc.TabIndex = 1;
            this.rbFunc.TabStop = true;
            this.rbFunc.Text = "Funcionário";
            this.rbFunc.UseVisualStyleBackColor = true;
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(263, 35);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(385, 20);
            this.txtPesquisar.TabIndex = 3;
            // 
            // epErro
            // 
            this.epErro.ContainerControl = this;
            // 
            // ttCham
            // 
            this.ttCham.IsBalloon = true;
            this.ttCham.ShowAlways = true;
            // 
            // frmChamado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 581);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAbrirOS);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmChamado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chamados";
            this.Load += new System.EventHandler(this.frmChamado_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epErro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbEquip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbFunc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbProb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOsAberta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.Button btnAbrirOS;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lstCham;
        private System.Windows.Forms.ColumnHeader Codigo;
        private System.Windows.Forms.ColumnHeader Equipamento;
        private System.Windows.Forms.ColumnHeader Funcionario;
        private System.Windows.Forms.ColumnHeader Problema;
        private System.Windows.Forms.ColumnHeader Observacao;
        private System.Windows.Forms.ColumnHeader Data;
        private System.Windows.Forms.ColumnHeader OsAberta;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbEquip;
        private System.Windows.Forms.RadioButton rbFunc;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.ErrorProvider epErro;
        private System.Windows.Forms.ToolTip ttCham;
    }
}