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
    public partial class frmFuncionario : Form
    {
        public frmFuncionario()
        {
            userConectado = frmLogin.userConectado;
            InitializeComponent();
        }

        public string userConectado;
        public int func_id;
        public string func_nome;
        public string func_cargo;

        #region Metodos

        private void PesquisarFunc()
        {
            clsDados dados = new clsDados();
            List<CtrlManut.clsDados.Funcionarios> listaFunc = new List<CtrlManut.clsDados.Funcionarios>();
            listaFunc = dados.Pesquisar_Func();

            lstFunc.Items.Clear();

            foreach (var itemLista in listaFunc)
            {
                if (itemLista.func_nome.ToString().StartsWith(txtPesquisar.Text))
                {
                    ListViewItem objLstViewItem = new ListViewItem();
                    objLstViewItem.Text = itemLista.func_id.ToString();
                    objLstViewItem.SubItems.Add(itemLista.func_nome);
                    objLstViewItem.SubItems.Add(itemLista.func_cargo);
                    lstFunc.Items.Add(objLstViewItem);
                }
            }
            txtPesquisar.Clear();
        }

        private void EditarFunc()
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
                    if (lstFunc.SelectedItems.Count > 0)
                    {
                        func_id = Convert.ToInt32(lstFunc.SelectedItems[0].Text);
                        func_nome = lstFunc.SelectedItems[0].SubItems[1].Text;
                        func_cargo = lstFunc.SelectedItems[0].SubItems[2].Text;
                        txtNomeFunc.Text = func_nome;
                        txtCargoFunc.Text = func_cargo;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);                
            }
            lstFunc.Items.Clear();
            txtPesquisar.Clear();
        }

        private void ExcluirFunc()
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
                    if (lstFunc.SelectedItems.Count > 0)
                    {
                        ctrl = Convert.ToInt32(lstFunc.SelectedItems[0].Text);
                        clsDados dados = new clsDados();
                        if (ctrl > 0)
                        {
                            dados.Excluir_Func(ctrl);
                            MessageBox.Show("Funcionário excluído com sucesso");                            
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
            lstFunc.Items.Clear();
            txtPesquisar.Clear();

        }

        private void InserirFunc(int func_id, string func_nome, string func_cargo)
        {
            try
            {
                clsDados dados = new clsDados();
                dados.Incluir_Func(func_id, func_nome, func_cargo);
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
            EditarFunc();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            ExcluirFunc();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtNomeFunc.Text) && !String.IsNullOrEmpty(txtCargoFunc.Text))
            {
                if (func_id == 0)
                {
                    func_nome = txtNomeFunc.Text;
                    func_cargo = txtCargoFunc.Text;
                    InserirFunc(func_id, func_nome, func_cargo);
                    MessageBox.Show("Funcionário Cadastrado com Sucesso!");
                    txtNomeFunc.Clear();
                    txtCargoFunc.Clear();
                }
                else
                {
                    clsDados dados = new clsDados();
                    func_nome = txtNomeFunc.Text;
                    func_cargo = txtCargoFunc.Text;
                    dados.Atualizar_Func(func_id, func_nome, func_cargo);
                    MessageBox.Show("Funcionário Atualizado com Sucesso!");
                    txtNomeFunc.Clear();
                    txtCargoFunc.Clear();
                }
            }
            else
            {
                if (String.IsNullOrEmpty(txtNomeFunc.Text))
                {
                    epErro.SetError(txtNomeFunc, "Informe o nome do funcionário!");
                }
                if (String.IsNullOrEmpty(txtCargoFunc.Text))
                {
                    epErro.SetError(txtCargoFunc, "Informe o Cargo do funcionário!");
                }
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            PesquisarFunc();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        
    }
}
