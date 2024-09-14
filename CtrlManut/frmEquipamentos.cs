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
    public partial class frmEquipamentos : Form
    {
        public frmEquipamentos()
        {
            userConectado = frmLogin.userConectado;
            InitializeComponent();
        }

        public string userConectado;
        public int equip_id;
        public string equip_nome;
        public string equip_local;

        
        #region metodos
       

        private void PesquisarEquip()
        {
            clsDados dados = new clsDados();
            List<CtrlManut.clsDados.Equipamentos> listaEquip = new List<CtrlManut.clsDados.Equipamentos>();
            listaEquip = dados.Pesquisar_Equip();

            lstEquip.Items.Clear();

            foreach (var itemLista in listaEquip)
            {
                if (itemLista.equip_nome.ToString().StartsWith(txtPesquisa.Text))
                {                    
                    ListViewItem objLstViewItem = new ListViewItem();
                    objLstViewItem.Text = itemLista.equip_id.ToString();
                    objLstViewItem.SubItems.Add(itemLista.equip_nome);
                    objLstViewItem.SubItems.Add(itemLista.equip_local);
                    lstEquip.Items.Add(objLstViewItem);
                }                
            }
        }

        private void EditarEquip()
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
                    if (lstEquip.SelectedItems.Count > 0)
                    {
                        equip_id = Convert.ToInt32(lstEquip.SelectedItems[0].Text);
                        equip_nome = lstEquip.SelectedItems[0].SubItems[1].Text;
                        equip_local = lstEquip.SelectedItems[0].SubItems[2].Text;
                        txtEquip.Text = equip_nome;
                        txtLocal.Text = equip_local;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);                
            }
            lstEquip.Items.Clear();
        }

        private void ExcluirEquip()
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
                    if (lstEquip.SelectedItems.Count > 0)
                    {
                        ctrl = Convert.ToInt32(lstEquip.SelectedItems[0].Text);
                        clsDados dados = new clsDados();
                        if (ctrl > 0)
                        {
                            dados.Excluir_Equip(ctrl);
                            MessageBox.Show("Registro excluído com sucesso");
                            lstEquip.Items.Clear();
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


        private void InserirEquip(int equip_id, string equip_nome, string equip_local)
        {
            try
            {
                clsDados dados = new clsDados();
                dados.Inserir_Equip(equip_id, equip_nome, equip_local);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);               
            }

        }

        #endregion


        #region Botões

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            PesquisarEquip();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            EditarEquip();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtEquip.Text) && !String.IsNullOrEmpty(txtLocal.Text))
            {
                if (equip_id == 0)
                {
                    equip_nome = txtEquip.Text;
                    equip_local = txtLocal.Text;
                    InserirEquip(equip_id, equip_nome, equip_local);
                    MessageBox.Show("Equipamento Cadastrado com Sucesso!");
                    txtEquip.Clear();
                    txtLocal.Clear();
                    lstEquip.Items.Clear();
                }
                else
                {
                    clsDados dados = new clsDados();
                    equip_nome = txtEquip.Text;
                    equip_local = txtLocal.Text;
                    dados.Atualizar_Equip(equip_id, equip_nome, equip_local);
                    MessageBox.Show("Equipamento Atualizado com Sucesso!");
                    txtEquip.Clear();
                    txtLocal.Clear();
                    lstEquip.Items.Clear();
                }
            }
            else
            {
                if (String.IsNullOrEmpty(txtEquip.Text))
                {
                    epErro.SetError(txtEquip, "Informe o nome do equipamento!");
                }
                if (String.IsNullOrEmpty(txtLocal.Text))
                {
                    epErro.SetError(txtLocal, "Informe o Local!");
                }
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
           ExcluirEquip();            
        }
        #endregion

        

  }
}

