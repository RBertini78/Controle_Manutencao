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
    public partial class frmTecnicos : Form
    {
        public frmTecnicos()
        {
            userConectado = frmLogin.userConectado;
            InitializeComponent();
        }

        public int tec_id;
        public string tec_nome;
        public string userConectado;

        #region Métodos
        private void EditarTec()
        {
            try
            {
                if (userConectado != "tecnicos")
                {
                    MessageBox.Show("Ação não autorizada!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtPesquisar.Clear();
                }
                else
                {
                    clsDados dados = new clsDados();
                    if (lstTec.SelectedItems.Count > 0)
                    {
                        tec_id = Convert.ToInt32(lstTec.SelectedItems[0].Text);
                        tec_nome = lstTec.SelectedItems[0].SubItems[1].Text;
                        txtTecnico.Text = tec_nome;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }
            lstTec.Items.Clear();
            txtPesquisar.Clear();
        }

        public void ExcluirTec()
        {
            try
            {
                int ctrl = 0;

                if (userConectado != "tecnicos")
                {
                    MessageBox.Show("Você não tem autorização para esta ação", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (lstTec.SelectedItems.Count > 0)
                    {
                        ctrl = Convert.ToInt32(lstTec.SelectedItems[0].Text);
                        clsDados dados = new clsDados();
                        if (ctrl > 0)
                        {
                            dados.Excluir_Tec(ctrl);
                            MessageBox.Show("Técnico excluído com sucesso");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Selecione um técnico primeiro", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro!" + ex.Message);
            }
            lstTec.Items.Clear();
            txtPesquisar.Clear();
        }

        public void GravarTec(int tec_id, string tec_nome)
        {
            try
            {
                clsDados dados = new clsDados();
                dados.Inserir_Tec(tec_id, tec_nome);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }
        }

        private void PesquisarTec()
        {
            clsDados dados = new clsDados();
            List<clsDados.Tecnicos> listaTec = new List<clsDados.Tecnicos>();
            listaTec = dados.Pesquisar_Tec();

            lstTec.Items.Clear();

            foreach (var itemLista in listaTec)
            {
                if (itemLista.tec_nome.ToString().StartsWith(txtPesquisar.Text))
                {
                    ListViewItem objLstViewItem = new ListViewItem();
                    objLstViewItem.Text = itemLista.tec_id.ToString();
                    objLstViewItem.SubItems.Add(itemLista.tec_nome);
                    lstTec.Items.Add(objLstViewItem);
                }  
            }
            txtPesquisar.Clear();
        }

        #endregion
        
        #region Botões

        private void btnEditar_Click(object sender, EventArgs e)
        {
            EditarTec();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            ExcluirTec();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtTecnico.Text))
            {
                if (tec_id == 0)
                {
                    tec_nome = txtTecnico.Text;
                    GravarTec(tec_id, tec_nome);
                    MessageBox.Show("Técnico Cadastrado com Sucesso!");
                    txtTecnico.Clear();                    
                }
                else
                {
                    clsDados dados = new clsDados();
                    tec_nome = txtTecnico.Text;                    
                    dados.Atualizar_Tec(tec_id, tec_nome);
                    MessageBox.Show("Técnico Atualizado com Sucesso!");
                    txtTecnico.Clear();                    
                }
            }
            else
            {
                if (String.IsNullOrEmpty(txtTecnico.Text))
                {
                    epErro.SetError(txtTecnico, "Informe o nome do Técnico!");
                }                
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            PesquisarTec();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

    }
}
