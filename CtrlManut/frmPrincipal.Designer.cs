namespace CtrlManut
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.ttFunc = new System.Windows.Forms.ToolTip(this.components);
            this.btnRelatorios = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnTecnicos = new System.Windows.Forms.Button();
            this.btnProb = new System.Windows.Forms.Button();
            this.btnOS = new System.Windows.Forms.Button();
            this.btnFunc = new System.Windows.Forms.Button();
            this.btnEquip = new System.Windows.Forms.Button();
            this.btnChamados = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ttFunc
            // 
            this.ttFunc.IsBalloon = true;
            this.ttFunc.ShowAlways = true;
            // 
            // btnRelatorios
            // 
            this.btnRelatorios.Image = global::CtrlManut.Properties.Resources.relatorio_48;
            this.btnRelatorios.Location = new System.Drawing.Point(352, 107);
            this.btnRelatorios.Name = "btnRelatorios";
            this.btnRelatorios.Size = new System.Drawing.Size(75, 63);
            this.btnRelatorios.TabIndex = 8;
            this.ttFunc.SetToolTip(this.btnRelatorios, "Relatórios");
            this.btnRelatorios.UseVisualStyleBackColor = true;
            this.btnRelatorios.Click += new System.EventHandler(this.btnRelatorios_Click);
            // 
            // btnSair
            // 
            this.btnSair.Image = global::CtrlManut.Properties.Resources.Shutdown_48;
            this.btnSair.Location = new System.Drawing.Point(194, 203);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 63);
            this.btnSair.TabIndex = 7;
            this.ttFunc.SetToolTip(this.btnSair, "Sair do sistema");
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Image = global::CtrlManut.Properties.Resources.user_48;
            this.btnUsuarios.Location = new System.Drawing.Point(248, 107);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(75, 63);
            this.btnUsuarios.TabIndex = 6;
            this.ttFunc.SetToolTip(this.btnUsuarios, "Cadastro e consulta de usuários");
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnTecnicos
            // 
            this.btnTecnicos.Image = global::CtrlManut.Properties.Resources.helpdesk_48;
            this.btnTecnicos.Location = new System.Drawing.Point(143, 107);
            this.btnTecnicos.Name = "btnTecnicos";
            this.btnTecnicos.Size = new System.Drawing.Size(75, 63);
            this.btnTecnicos.TabIndex = 5;
            this.ttFunc.SetToolTip(this.btnTecnicos, "Cadastro e consulta de técnicos");
            this.btnTecnicos.UseVisualStyleBackColor = true;
            this.btnTecnicos.Click += new System.EventHandler(this.btnTecnicos_Click);
            // 
            // btnProb
            // 
            this.btnProb.Image = global::CtrlManut.Properties.Resources.Stop;
            this.btnProb.Location = new System.Drawing.Point(35, 107);
            this.btnProb.Name = "btnProb";
            this.btnProb.Size = new System.Drawing.Size(75, 63);
            this.btnProb.TabIndex = 4;
            this.ttFunc.SetToolTip(this.btnProb, "Cadastro e consulta de problemas");
            this.btnProb.UseVisualStyleBackColor = true;
            this.btnProb.Click += new System.EventHandler(this.btnProb_Click);
            // 
            // btnOS
            // 
            this.btnOS.Image = global::CtrlManut.Properties.Resources.Note;
            this.btnOS.Location = new System.Drawing.Point(352, 12);
            this.btnOS.Name = "btnOS";
            this.btnOS.Size = new System.Drawing.Size(75, 62);
            this.btnOS.TabIndex = 3;
            this.ttFunc.SetToolTip(this.btnOS, "Consulta ordem de serviço");
            this.btnOS.UseVisualStyleBackColor = true;
            this.btnOS.Click += new System.EventHandler(this.btnOS_Click);
            // 
            // btnFunc
            // 
            this.btnFunc.Image = global::CtrlManut.Properties.Resources.func_48;
            this.btnFunc.Location = new System.Drawing.Point(248, 12);
            this.btnFunc.Name = "btnFunc";
            this.btnFunc.Size = new System.Drawing.Size(75, 62);
            this.btnFunc.TabIndex = 2;
            this.ttFunc.SetToolTip(this.btnFunc, "Cadastro e Consluta de Funcionários");
            this.btnFunc.UseVisualStyleBackColor = true;
            this.btnFunc.Click += new System.EventHandler(this.btnFunc_Click);
            // 
            // btnEquip
            // 
            this.btnEquip.Image = global::CtrlManut.Properties.Resources.Computer;
            this.btnEquip.Location = new System.Drawing.Point(143, 12);
            this.btnEquip.Name = "btnEquip";
            this.btnEquip.Size = new System.Drawing.Size(75, 62);
            this.btnEquip.TabIndex = 1;
            this.ttFunc.SetToolTip(this.btnEquip, "Cadastro e consultas de funcionários");
            this.btnEquip.UseVisualStyleBackColor = true;
            this.btnEquip.Click += new System.EventHandler(this.btnEquip_Click);
            // 
            // btnChamados
            // 
            this.btnChamados.Image = global::CtrlManut.Properties.Resources.Chat;
            this.btnChamados.Location = new System.Drawing.Point(35, 12);
            this.btnChamados.Name = "btnChamados";
            this.btnChamados.Size = new System.Drawing.Size(75, 62);
            this.btnChamados.TabIndex = 0;
            this.ttFunc.SetToolTip(this.btnChamados, "Cadastro e consultas de chamados");
            this.btnChamados.UseVisualStyleBackColor = true;
            this.btnChamados.Click += new System.EventHandler(this.btnChamados_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 278);
            this.Controls.Add(this.btnRelatorios);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnUsuarios);
            this.Controls.Add(this.btnTecnicos);
            this.Controls.Add(this.btnProb);
            this.Controls.Add(this.btnOS);
            this.Controls.Add(this.btnFunc);
            this.Controls.Add(this.btnEquip);
            this.Controls.Add(this.btnChamados);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Controle de Manutenção";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnChamados;
        private System.Windows.Forms.Button btnEquip;
        private System.Windows.Forms.Button btnFunc;
        private System.Windows.Forms.Button btnOS;
        private System.Windows.Forms.Button btnProb;
        private System.Windows.Forms.Button btnTecnicos;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.ToolTip ttFunc;
        private System.Windows.Forms.Button btnRelatorios;
    }
}