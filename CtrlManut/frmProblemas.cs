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
    public partial class frmProblemas : Form
    {
        public frmProblemas()
        {
            userConectado = frmLogin.userConectado;
            InitializeComponent();
        }

        string userConectado;
        int prob_id;
        string prob_nome;
        string prob_tipo;

        #region Métodos
        private void PesquisarProb()
        {
            clsDados dados = new clsDados();
            List<CtrlManut.clsDados.Problemas> listaProb = new List<CtrlManut.clsDados.Problemas>();
            listaProb = dados.Pesquisar_Prob();

            lstProb.Items.Clear();

            foreach (var itemLista in listaProb)
            {
                if (itemLista.prob_nome.ToString().StartsWith(txtPesquisar.Text))
                {
                    ListViewItem objLstViewItem = new ListViewItem();
                    objLstViewItem.Text = itemLista.prob_id.ToString();
                    objLstViewItem.SubItems.Add(itemLista.prob_tipo);
                    objLstViewItem.SubItems.Add(itemLista.prob_nome);
                    lstProb.Items.Add(objLstViewItem);
                }
            }

        }

        private void EditarProb()
        {
            try
            {
                if (userConectado != "tecnicos")
                {
                    MessageBox.Show("Ação não autorizada!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    clsDados dados = new clsDados();
                    if (lstProb.SelectedItems.Count > 0)
                    {
                        prob_id = Convert.ToInt32(lstProb.SelectedItems[0].Text);
                        prob_tipo = lstProb.SelectedItems[0].SubItems[1].Text;
                        prob_nome = lstProb.SelectedItems[0].SubItems[2].Text;
                        txtProblema.Text = prob_nome;
                        txtTipo.Text = prob_tipo;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }
            lstProb.Items.Clear();
        }

        private void ExcluirProb()
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
                    if (lstProb.SelectedItems.Count > 0)
                    {
                        ctrl = Convert.ToInt32(lstProb.SelectedItems[0].Text);
                        clsDados dados = new clsDados();
                        if (ctrl > 0)
                        {
                            dados.Excluir_Func(ctrl);
                            MessageBox.Show("Funcionário excluído com sucesso");
                            lstProb.Items.Clear();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Selecione um funcionário primeiro", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro!" + ex.Message);
            }

        }

        private void InserirProb(int prob_id, string prob_tipo, string prob_nome)
        {
            try
            {
                clsDados dados = new clsDados();
                dados.Inserir_Prob(prob_id, prob_tipo, prob_nome);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }
        }

        #endregion

        #region Botões

        private void btnEditar_Click(object sender, EventArgs e)
        {
            EditarProb();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            ExcluirProb();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtProblema.Text) && !String.IsNullOrEmpty(txtTipo.Text))
            {
                if (prob_id == 0)
                {
                    prob_nome = txtProblema.Text;
                    prob_tipo = txtTipo.Text;
                    InserirProb(prob_id, prob_tipo, prob_nome);
                    MessageBox.Show("Problema Cadastrado com Sucesso!");
                    txtProblema.Clear();
                    txtTipo.Clear();                    
                }
                else
                {
                    clsDados dados = new clsDados();
                    prob_nome = txtProblema.Text;
                    prob_tipo = txtTipo.Text;
                    dados.Atualizar_Prob(prob_id, prob_tipo, prob_nome);
                    MessageBox.Show("Problema Atualizado com Sucesso!");
                    txtProblema.Clear();
                    txtTipo.Clear();                    
                }
            }
            else
            {
                if (String.IsNullOrEmpty(txtProblema.Text))
                {
                    epErro.SetError(txtProblema, "Informe o problema!");
                }
                if (String.IsNullOrEmpty(txtTipo.Text))
                {
                    epErro.SetError(txtTipo, "Informe o tipo do problema!");
                }
            }
        }
        

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            PesquisarProb();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion      
    }
}
