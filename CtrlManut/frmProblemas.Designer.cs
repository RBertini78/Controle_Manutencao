namespace CtrlManut
{
    partial class frmProblemas
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
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProblema = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstProb = new System.Windows.Forms.ListView();
            this.Codigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tipo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Problema = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.epErro = new System.Windows.Forms.ErrorProvider(this.components);
            this.ttProb = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epErro)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTipo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtProblema);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(489, 97);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastrar problema:";
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(67, 56);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(301, 20);
            this.txtTipo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tipo:";
            // 
            // txtProblema
            // 
            this.txtProblema.Location = new System.Drawing.Point(67, 17);
            this.txtProblema.Name = "txtProblema";
            this.txtProblema.Size = new System.Drawing.Size(301, 20);
            this.txtProblema.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Problema:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstProb);
            this.groupBox2.Controls.Add(this.txtPesquisar);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(13, 117);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(489, 212);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pesquisar problemas:";
            // 
            // lstProb
            // 
            this.lstProb.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Codigo,
            this.Tipo,
            this.Problema});
            this.lstProb.FullRowSelect = true;
            this.lstProb.GridLines = true;
            this.lstProb.Location = new System.Drawing.Point(6, 48);
            this.lstProb.MultiSelect = false;
            this.lstProb.Name = "lstProb";
            this.lstProb.Size = new System.Drawing.Size(477, 158);
            this.lstProb.TabIndex = 4;
            this.lstProb.UseCompatibleStateImageBehavior = false;
            this.lstProb.View = System.Windows.Forms.View.Details;
            // 
            // Codigo
            // 
            this.Codigo.Text = "Código";
            // 
            // Tipo
            // 
            this.Tipo.Text = "Tipo";
            this.Tipo.Width = 121;
            // 
            // Problema
            // 
            this.Problema.Text = "Problema";
            this.Problema.Width = 289;
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(67, 17);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(301, 20);
            this.txtPesquisar.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Problema: ";
            // 
            // btnDeletar
            // 
            this.btnDeletar.Image = global::CtrlManut.Properties.Resources.delete_48;
            this.btnDeletar.Location = new System.Drawing.Point(184, 347);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(75, 57);
            this.btnDeletar.TabIndex = 6;
            this.ttProb.SetToolTip(this.btnDeletar, "Excluir");
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.Image = global::CtrlManut.Properties.Resources.save_48;
            this.btnGravar.Location = new System.Drawing.Point(265, 347);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 57);
            this.btnGravar.TabIndex = 7;
            this.ttProb.SetToolTip(this.btnGravar, "Salvar");
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Image = global::CtrlManut.Properties.Resources.search_48;
            this.btnPesquisar.Location = new System.Drawing.Point(346, 347);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 57);
            this.btnPesquisar.TabIndex = 8;
            this.ttProb.SetToolTip(this.btnPesquisar, "Pesquisar");
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Image = global::CtrlManut.Properties.Resources.Shutdown_48;
            this.btnSair.Location = new System.Drawing.Point(427, 347);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 57);
            this.btnSair.TabIndex = 9;
            this.ttProb.SetToolTip(this.btnSair, "Sair");
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Image = global::CtrlManut.Properties.Resources.pencil_48;
            this.btnEditar.Location = new System.Drawing.Point(103, 347);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 57);
            this.btnEditar.TabIndex = 5;
            this.ttProb.SetToolTip(this.btnEditar, "Editar");
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // epErro
            // 
            this.epErro.ContainerControl = this;
            // 
            // ttProb
            // 
            this.ttProb.IsBalloon = true;
            this.ttProb.ShowAlways = true;
            // 
            // frmProblemas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 413);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmProblemas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProblemas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epErro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProblema;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lstProb;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.ErrorProvider epErro;
        private System.Windows.Forms.ColumnHeader Codigo;
        private System.Windows.Forms.ColumnHeader Tipo;
        private System.Windows.Forms.ColumnHeader Problema;
        private System.Windows.Forms.ToolTip ttProb;
    }
}