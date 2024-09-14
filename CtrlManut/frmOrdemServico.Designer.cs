namespace CtrlManut
{
    partial class frmOrdemServico
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbTec = new System.Windows.Forms.ComboBox();
            this.txtDtConc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDtCham = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFunc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEquip = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtChamID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtSolucao = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lstOS = new System.Windows.Forms.ListView();
            this.Codigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ChamCodigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tecnico = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Solucao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DataConclusao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mskPesquisa = new System.Windows.Forms.MaskedTextBox();
            this.rbData = new System.Windows.Forms.RadioButton();
            this.rbFechada = new System.Windows.Forms.RadioButton();
            this.rbAberta = new System.Windows.Forms.RadioButton();
            this.btnConcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtStatus);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cmbTec);
            this.groupBox1.Controls.Add(this.txtDtConc);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtObs);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtDtCham);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtFunc);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtProb);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtEquip);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtChamID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(747, 206);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastrar OS";
            // 
            // txtStatus
            // 
            this.txtStatus.Enabled = false;
            this.txtStatus.Location = new System.Drawing.Point(603, 36);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(132, 20);
            this.txtStatus.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(600, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Status:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(412, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Técnico Responsável:";
            // 
            // cmbTec
            // 
            this.cmbTec.FormattingEnabled = true;
            this.cmbTec.Location = new System.Drawing.Point(415, 36);
            this.cmbTec.Name = "cmbTec";
            this.cmbTec.Size = new System.Drawing.Size(167, 21);
            this.cmbTec.TabIndex = 14;
            // 
            // txtDtConc
            // 
            this.txtDtConc.Enabled = false;
            this.txtDtConc.Location = new System.Drawing.Point(268, 36);
            this.txtDtConc.Name = "txtDtConc";
            this.txtDtConc.Size = new System.Drawing.Size(129, 20);
            this.txtDtConc.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(265, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Data Conclusão:";
            // 
            // txtObs
            // 
            this.txtObs.Enabled = false;
            this.txtObs.Location = new System.Drawing.Point(318, 95);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(417, 98);
            this.txtObs.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(315, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Observação:";
            // 
            // txtDtCham
            // 
            this.txtDtCham.Enabled = false;
            this.txtDtCham.Location = new System.Drawing.Point(109, 36);
            this.txtDtCham.Name = "txtDtCham";
            this.txtDtCham.Size = new System.Drawing.Size(138, 20);
            this.txtDtCham.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(106, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Data Chamado:";
            // 
            // txtFunc
            // 
            this.txtFunc.Enabled = false;
            this.txtFunc.Location = new System.Drawing.Point(10, 173);
            this.txtFunc.Name = "txtFunc";
            this.txtFunc.Size = new System.Drawing.Size(285, 20);
            this.txtFunc.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Funcionário:";
            // 
            // txtProb
            // 
            this.txtProb.Enabled = false;
            this.txtProb.Location = new System.Drawing.Point(10, 134);
            this.txtProb.Name = "txtProb";
            this.txtProb.Size = new System.Drawing.Size(285, 20);
            this.txtProb.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Problema:";
            // 
            // txtEquip
            // 
            this.txtEquip.Enabled = false;
            this.txtEquip.Location = new System.Drawing.Point(10, 95);
            this.txtEquip.Name = "txtEquip";
            this.txtEquip.Size = new System.Drawing.Size(285, 20);
            this.txtEquip.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Equipamento:";
            // 
            // txtChamID
            // 
            this.txtChamID.Enabled = false;
            this.txtChamID.Location = new System.Drawing.Point(10, 36);
            this.txtChamID.Name = "txtChamID";
            this.txtChamID.Size = new System.Drawing.Size(80, 20);
            this.txtChamID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chamado nº:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtSolucao);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(13, 226);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(747, 105);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Solução";
            // 
            // txtSolucao
            // 
            this.txtSolucao.Location = new System.Drawing.Point(105, 20);
            this.txtSolucao.Multiline = true;
            this.txtSolucao.Name = "txtSolucao";
            this.txtSolucao.Size = new System.Drawing.Size(630, 76);
            this.txtSolucao.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Solução adotada:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lstOS);
            this.groupBox3.Controls.Add(this.mskPesquisa);
            this.groupBox3.Controls.Add(this.rbData);
            this.groupBox3.Controls.Add(this.rbFechada);
            this.groupBox3.Controls.Add(this.rbAberta);
            this.groupBox3.Location = new System.Drawing.Point(13, 337);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(747, 222);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pesquisar OS:";
            // 
            // lstOS
            // 
            this.lstOS.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Codigo,
            this.ChamCodigo,
            this.Status,
            this.Tecnico,
            this.Solucao,
            this.DataConclusao});
            this.lstOS.FullRowSelect = true;
            this.lstOS.GridLines = true;
            this.lstOS.Location = new System.Drawing.Point(7, 44);
            this.lstOS.Name = "lstOS";
            this.lstOS.Size = new System.Drawing.Size(734, 172);
            this.lstOS.TabIndex = 4;
            this.lstOS.UseCompatibleStateImageBehavior = false;
            this.lstOS.View = System.Windows.Forms.View.Details;
            // 
            // Codigo
            // 
            this.Codigo.Text = "Código";
            // 
            // ChamCodigo
            // 
            this.ChamCodigo.Text = "Nº Chamado";
            this.ChamCodigo.Width = 75;
            // 
            // Status
            // 
            this.Status.Text = "Status";
            this.Status.Width = 84;
            // 
            // Tecnico
            // 
            this.Tecnico.Text = "Técnico";
            this.Tecnico.Width = 108;
            // 
            // Solucao
            // 
            this.Solucao.Text = "Solução";
            this.Solucao.Width = 309;
            // 
            // DataConclusao
            // 
            this.DataConclusao.Text = "Data Conclusão";
            this.DataConclusao.Width = 92;
            // 
            // mskPesquisa
            // 
            this.mskPesquisa.Location = new System.Drawing.Point(244, 19);
            this.mskPesquisa.Mask = "00/00/0000";
            this.mskPesquisa.Name = "mskPesquisa";
            this.mskPesquisa.Size = new System.Drawing.Size(70, 20);
            this.mskPesquisa.TabIndex = 3;
            this.mskPesquisa.ValidatingType = typeof(System.DateTime);
            // 
            // rbData
            // 
            this.rbData.AutoSize = true;
            this.rbData.Location = new System.Drawing.Point(194, 20);
            this.rbData.Name = "rbData";
            this.rbData.Size = new System.Drawing.Size(48, 17);
            this.rbData.TabIndex = 2;
            this.rbData.TabStop = true;
            this.rbData.Text = "Data";
            this.rbData.UseVisualStyleBackColor = true;
            // 
            // rbFechada
            // 
            this.rbFechada.AutoSize = true;
            this.rbFechada.Location = new System.Drawing.Point(102, 20);
            this.rbFechada.Name = "rbFechada";
            this.rbFechada.Size = new System.Drawing.Size(67, 17);
            this.rbFechada.TabIndex = 1;
            this.rbFechada.TabStop = true;
            this.rbFechada.Text = "Fechada";
            this.rbFechada.UseVisualStyleBackColor = true;
            // 
            // rbAberta
            // 
            this.rbAberta.AutoSize = true;
            this.rbAberta.Location = new System.Drawing.Point(10, 20);
            this.rbAberta.Name = "rbAberta";
            this.rbAberta.Size = new System.Drawing.Size(56, 17);
            this.rbAberta.TabIndex = 0;
            this.rbAberta.TabStop = true;
            this.rbAberta.Text = "Aberta";
            this.rbAberta.UseVisualStyleBackColor = true;
            // 
            // btnConcluir
            // 
            this.btnConcluir.Image = global::CtrlManut.Properties.Resources.tick_48;
            this.btnConcluir.Location = new System.Drawing.Point(278, 565);
            this.btnConcluir.Name = "btnConcluir";
            this.btnConcluir.Size = new System.Drawing.Size(75, 57);
            this.btnConcluir.TabIndex = 3;
            this.btnConcluir.UseVisualStyleBackColor = true;
            this.btnConcluir.Click += new System.EventHandler(this.btnConcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Image = global::CtrlManut.Properties.Resources.pencil_48;
            this.btnEditar.Location = new System.Drawing.Point(359, 565);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 57);
            this.btnEditar.TabIndex = 4;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.Image = global::CtrlManut.Properties.Resources.delete_48;
            this.btnDeletar.Location = new System.Drawing.Point(440, 565);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(75, 57);
            this.btnDeletar.TabIndex = 5;
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.Image = global::CtrlManut.Properties.Resources.save_48;
            this.btnGravar.Location = new System.Drawing.Point(523, 565);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 57);
            this.btnGravar.TabIndex = 6;
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Image = global::CtrlManut.Properties.Resources.search_48;
            this.btnPesquisar.Location = new System.Drawing.Point(604, 565);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 57);
            this.btnPesquisar.TabIndex = 7;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Image = global::CtrlManut.Properties.Resources.Shutdown_48;
            this.btnSair.Location = new System.Drawing.Point(685, 565);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 57);
            this.btnSair.TabIndex = 8;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmOrdemServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 633);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnConcluir);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmOrdemServico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ordem de Servico";
            this.Load += new System.EventHandler(this.frmOrdemServico_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtFunc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtProb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEquip;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtChamID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbTec;
        private System.Windows.Forms.TextBox txtDtConc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDtCham;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtSolucao;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.MaskedTextBox mskPesquisa;
        private System.Windows.Forms.RadioButton rbData;
        private System.Windows.Forms.RadioButton rbFechada;
        private System.Windows.Forms.RadioButton rbAberta;
        private System.Windows.Forms.Button btnConcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.ListView lstOS;
        private System.Windows.Forms.ColumnHeader Codigo;
        private System.Windows.Forms.ColumnHeader ChamCodigo;
        private System.Windows.Forms.ColumnHeader Status;
        private System.Windows.Forms.ColumnHeader Tecnico;
        private System.Windows.Forms.ColumnHeader Solucao;
        private System.Windows.Forms.ColumnHeader DataConclusao;
        private System.Windows.Forms.Button btnSair;
    }
}