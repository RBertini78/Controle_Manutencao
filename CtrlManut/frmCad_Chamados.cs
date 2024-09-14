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
    public partial class frmCad_Chamados : Form
    {
        public frmCad_Chamados()
        {
            InitializeComponent();
        }

        private void tab_chamadosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tab_chamadosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cM_DataSet);

        }

        private void frmCad_Chamados_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cM_DataSet.tab_chamados' table. You can move, or remove it, as needed.
            this.tab_chamadosTableAdapter.Fill(this.cM_DataSet.tab_chamados);
            // TODO: This line of code loads data into the 'cM_DataSet.tab_problemas' table. You can move, or remove it, as needed.
            this.tab_problemasTableAdapter.Fill(this.cM_DataSet.tab_problemas);
            // TODO: This line of code loads data into the 'cM_DataSet.tab_funcionarios' table. You can move, or remove it, as needed.
            this.tab_funcionariosTableAdapter.Fill(this.cM_DataSet.tab_funcionarios);
            // TODO: This line of code loads data into the 'cM_DataSet.tab_equipamento' table. You can move, or remove it, as needed.
            this.tab_equipamentoTableAdapter.Fill(this.cM_DataSet.tab_equipamento);
            // TODO: This line of code loads data into the 'cM_DataSet.tab_chamados' table. You can move, or remove it, as needed.
            this.tab_chamadosTableAdapter.Fill(this.cM_DataSet.tab_chamados);

        }

        private void tab_equipamentoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tab_equipamentoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cM_DataSet);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

   }
}
