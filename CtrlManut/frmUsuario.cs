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
    public partial class frmUsuario : Form
    {
        public frmUsuario()
        {
            userConectado = frmLogin.userConectado;
            InitializeComponent();
        }

        string userConectado;
        int idLogin;
        string usuario;
        string senha;

        #region Métodos

        private void PesquisarUser()
        {
            clsDados dados = new clsDados();
            List<CtrlManut.clsDados.Usuarios> listaUser = new List<CtrlManut.clsDados.Usuarios>();
            listaUser = dados.Pesquisar_User();

            lstUser.Items.Clear();

            foreach (var itemLista in listaUser)
            {
                if (itemLista.usuario.ToString().StartsWith(txtPesquisa.Text))
                {
                    ListViewItem objLstViewItem = new ListViewItem();
                    objLstViewItem.Text = itemLista.idLogin.ToString();
                    objLstViewItem.SubItems.Add(itemLista.usuario);
                    objLstViewItem.SubItems.Add(itemLista.senha);
                    lstUser.Items.Add(objLstViewItem);
                }
            }
        }

        private void EditarUser()
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
                    if (lstUser.SelectedItems.Count > 0)
                    {
                        idLogin = Convert.ToInt32(lstUser.SelectedItems[0].Text);
                        usuario = lstUser.SelectedItems[0].SubItems[1].Text;
                        senha = lstUser.SelectedItems[0].SubItems[2].Text;
                        txtUsuario.Text = usuario;
                        txtSenha.Text = senha;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }
            lstUser.Items.Clear();
        }

        private void ExcluirUser()
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
                    if (lstUser.SelectedItems.Count > 0)
                    {
                        ctrl = Convert.ToInt32(lstUser.SelectedItems[0].Text);
                        clsDados dados = new clsDados();
                        if (ctrl > 0)
                        {
                            dados.Excluir_User(ctrl);
                            MessageBox.Show("Registro excluído com sucesso");
                            lstUser.Items.Clear();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Selecione um registro primeiro", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro!" + ex.Message);
            }
        }

        private void InserirUser(int idLogin, string usuario, string senha)
        {
            try
            {
                clsDados dados = new clsDados();
                dados.Inserir_User(idLogin, usuario, senha);

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
            EditarUser();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            ExcluirUser();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtUsuario.Text) && !String.IsNullOrEmpty(txtSenha.Text))
            {
                if (txtSenha.Text != txtConfirma.Text)
                {
                    MessageBox.Show("As senhas não combinam.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtUsuario.Clear();
                    txtSenha.Clear();
                    txtConfirma.Clear();
                }
                else
                {

                    if (idLogin == 0)
                    {
                        usuario = txtUsuario.Text;
                        senha = txtSenha.Text;
                        InserirUser(idLogin, senha, usuario);
                        MessageBox.Show("Usuário Cadastrado com Sucesso!");
                        txtUsuario.Clear();
                        txtSenha.Clear();
                        txtConfirma.Clear();
                        lstUser.Items.Clear();
                    }
                    else
                    {
                        clsDados dados = new clsDados();
                        usuario = txtUsuario.Text;
                        senha = txtSenha.Text;
                        dados.Atualizar_User(idLogin, usuario, senha);
                        MessageBox.Show("Usuário Atualizado com Sucesso!");
                        txtUsuario.Clear();
                        txtSenha.Clear();
                        txtConfirma.Clear();
                        lstUser.Items.Clear();
                    }
                }
            }
            else
            {
                if (String.IsNullOrEmpty(txtUsuario.Text))
                {
                    epErro.SetError(txtUsuario, "Informe o usuário!");
                }
                if (String.IsNullOrEmpty(txtSenha.Text))
                {
                    epErro.SetError(txtSenha, "Informe a senha!");
                }
                if (String.IsNullOrEmpty(txtConfirma.Text))
                {
                    epErro.SetError(txtSenha, "Informe a confirmação da senha!");
                }
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            PesquisarUser();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion
    }
}
