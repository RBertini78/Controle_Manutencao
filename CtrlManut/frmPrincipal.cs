using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CtrlManut
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnChamados_Click(object sender, EventArgs e)
        {
            frmChamado chamados = new frmChamado();
            chamados.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEquip_Click(object sender, EventArgs e)
        {
            frmEquipamentos equipamentos = new frmEquipamentos();
            equipamentos.Show();
        }

        private void btnFunc_Click(object sender, EventArgs e)
        {
            frmFuncionario funcionarios = new frmFuncionario();
            funcionarios.Show();
        }

        private void btnProb_Click(object sender, EventArgs e)
        {
            frmProblemas problemas = new frmProblemas();
            problemas.Show();
        }

        private void btnTecnicos_Click(object sender, EventArgs e)
        {
            frmTecnicos tecnicos = new frmTecnicos();
            tecnicos.Show();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            frmUsuario usuarios = new frmUsuario();
            usuarios.Show();
        }

        private void btnOS_Click(object sender, EventArgs e)
        {
            frmOrdemServico ordemservico = new frmOrdemServico();
            ordemservico.Show();
        }

        private void btnRelatorios_Click(object sender, EventArgs e)
        {
            frmRelatorios relatorios = new frmRelatorios();
            relatorios.Show();
        }
        
    }
}
