namespace CtrlManut
{
    partial class frmEquipamentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEquipamentos));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtLocal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEquip = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lstEquip = new System.Windows.Forms.ListView();
            this.Codigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Equipamento = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Local = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.epErro = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnSair = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.ttEquip = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epErro)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtLocal);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtEquip);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(472, 86);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastrar:";
            // 
            // txtLocal
            // 
            this.txtLocal.Location = new System.Drawing.Point(85, 49);
            this.txtLocal.Name = "txtLocal";
            this.txtLocal.Size = new System.Drawing.Size(197, 20);
            this.txtLocal.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Local:";
            // 
            // txtEquip
            // 
            this.txtEquip.Location = new System.Drawing.Point(85, 17);
            this.txtEquip.Name = "txtEquip";
            this.txtEquip.Size = new System.Drawing.Size(197, 20);
            this.txtEquip.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Equipamento:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtPesquisa);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lstEquip);
            this.groupBox2.Location = new System.Drawing.Point(13, 105);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(471, 210);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Consultar:";
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(130, 22);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(242, 20);
            this.txtPesquisa.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Equipamento:";
            // 
            // lstEquip
            // 
            this.lstEquip.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Codigo,
            this.Equipamento,
            this.Local});
            this.lstEquip.FullRowSelect = true;
            this.lstEquip.GridLines = true;
            this.lstEquip.Location = new System.Drawing.Point(9, 56);
            this.lstEquip.MultiSelect = false;
            this.lstEquip.Name = "lstEquip";
            this.lstEquip.Size = new System.Drawing.Size(456, 140);
            this.lstEquip.TabIndex = 2;
            this.lstEquip.UseCompatibleStateImageBehavior = false;
            this.lstEquip.View = System.Windows.Forms.View.Details;
            // 
            // Codigo
            // 
            this.Codigo.Text = "Código";
            // 
            // Equipamento
            // 
            this.Equipamento.Text = "Equipamento";
            this.Equipamento.Width = 194;
            // 
            // Local
            // 
            this.Local.Text = "Local";
            this.Local.Width = 194;
            // 
            // epErro
            // 
            this.epErro.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epErro.ContainerControl = this;
            // 
            // btnSair
            // 
            this.btnSair.Image = global::CtrlManut.Properties.Resources.Shutdown_48;
            this.btnSair.Location = new System.Drawing.Point(392, 322);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 57);
            this.btnSair.TabIndex = 7;
            this.ttEquip.SetToolTip(this.btnSair, "Sair");
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Image = global::CtrlManut.Properties.Resources.pencil_48;
            this.btnEditar.Location = new System.Drawing.Point(67, 322);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 57);
            this.btnEditar.TabIndex = 6;
            this.ttEquip.SetToolTip(this.btnEditar, "Editar");
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Image = global::CtrlManut.Properties.Resources.search_48;
            this.btnPesquisar.Location = new System.Drawing.Point(310, 321);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 57);
            this.btnPesquisar.TabIndex = 2;
            this.ttEquip.SetToolTip(this.btnPesquisar, "Pesquisar");
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.Image = global::CtrlManut.Properties.Resources.save_48;
            this.btnGravar.Location = new System.Drawing.Point(229, 321);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 57);
            this.btnGravar.TabIndex = 4;
            this.ttEquip.SetToolTip(this.btnGravar, "Salvar");
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.Image = global::CtrlManut.Properties.Resources.delete_48;
            this.btnDeletar.Location = new System.Drawing.Point(148, 321);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(75, 57);
            this.btnDeletar.TabIndex = 8;
            this.ttEquip.SetToolTip(this.btnDeletar, "Excluir");
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // ttEquip
            // 
            this.ttEquip.IsBalloon = true;
            this.ttEquip.ShowAlways = true;
            // 
            // frmEquipamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 382);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEquipamentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Equipamentos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epErro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtLocal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEquip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.ListView lstEquip;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.ColumnHeader Codigo;
        private System.Windows.Forms.ColumnHeader Equipamento;
        private System.Windows.Forms.ColumnHeader Local;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider epErro;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.ToolTip ttEquip;
    }
}