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
    public partial class frmChamado : Form
    {
        public frmChamado()
        {
            userConectado = frmLogin.userConectado;            
            InitializeComponent();
        }

        int cham_id;
        int cham_equip_id;
        int cham_func_id;
        int cham_prob_id;
        string cham_obs;
        string cham_data;
        string cham_osaberta;
        string equip_nome;
        string func_nome;
        string prob_nome;
        string userConectado;
               

        #region Métodos       

        private void EditarCham()
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
                    if (lstCham.SelectedItems.Count > 0)
                    {
                        cham_id = Convert.ToInt32(lstCham.SelectedItems[0].Text);
                        equip_nome = lstCham.SelectedItems[0].SubItems[1].Text;
                        func_nome = lstCham.SelectedItems[0].SubItems[2].Text;
                        prob_nome = lstCham.SelectedItems[0].SubItems[3].Text;
                        cham_obs = lstCham.SelectedItems[0].SubItems[4].Text;
                        cham_osaberta = lstCham.SelectedItems[0].SubItems[6].Text;
                        cmbEquip.Text = equip_nome;
                        cmbEquip.Enabled = false;
                        cmbFunc.Text = func_nome;
                        cmbFunc.Enabled = false;
                        cmbProb.Text = prob_nome;
                        cmbProb.Enabled = false;
                        txtObs.Text = cham_obs;
                        if (cham_osaberta == "1")
                        {
                            txtOsAberta.Text = "Sim";     
                        }
                        else
                        {
                            txtOsAberta.Text = "Não";
                        }
                        txtData.Text = DateTime.Now.ToShortDateString();

                    }
                    else
                    {
                        MessageBox.Show("Selecione um chamado primeiro.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);                
            }
            lstCham.Items.Clear();
            txtPesquisar.Clear();
        }
        

        private void ExcluirCham()
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
                    if (lstCham.SelectedItems.Count > 0)
                    {
                        ctrl = Convert.ToInt32(lstCham.SelectedItems[0].Text);
                        clsDados dados = new clsDados();
                        if (ctrl > 0)
                        {
                            dados.Excluir_Cham(ctrl);
                            MessageBox.Show("Chamado excluído com sucesso");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Selecione um chamado primeiro", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch (Exception ex)
            {
               MessageBox.Show("Ocorreu um erro!" + ex.Message);               
            }
            lstCham.Items.Clear();
            txtPesquisar.Clear();
        }

        private void GravarCham(int cham_id, int cham_equip_id, int cham_func_id, int cham_prob_id, string cham_obs, string cham_data, string cham_osaberta)
        {
            try
            {
                clsDados dados = new clsDados();
                dados.Inserir_Cham(cham_id, cham_equip_id, cham_func_id,cham_prob_id, cham_obs, cham_data, cham_osaberta);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }
        }

        private void PesquisarCham()
        {
            clsDados dados = new clsDados();
            List<clsDados.Chamados> listaCham = new List<clsDados.Chamados>();
            listaCham = dados.Pesquisar_Cham();

            lstCham.Items.Clear();

            foreach (var itemLista in listaCham)
            {
                if (rbEquip.Checked == true)
                {
                    if (itemLista.equip_nome.ToString().StartsWith(txtPesquisar.Text))
                    {
                        ListViewItem objLstViewItem = new ListViewItem();
                        objLstViewItem.Text = itemLista.cham_id.ToString();
                        objLstViewItem.SubItems.Add(itemLista.equip_nome);
                        objLstViewItem.SubItems.Add(itemLista.func_nome);
                        objLstViewItem.SubItems.Add(itemLista.prob_nome);
                        objLstViewItem.SubItems.Add(itemLista.cham_obs);
                        objLstViewItem.SubItems.Add(itemLista.cham_data);
                        objLstViewItem.SubItems.Add(itemLista.cham_osaberta);
                        lstCham.Items.Add(objLstViewItem);
                    }                  
                }
                if (rbFunc.Checked == true)
                {
                     if (itemLista.func_nome.ToString().StartsWith(txtPesquisar.Text))
                    {
                        ListViewItem objLstViewItem = new ListViewItem();
                        objLstViewItem.Text = itemLista.cham_id.ToString();
                        objLstViewItem.SubItems.Add(itemLista.equip_nome);
                        objLstViewItem.SubItems.Add(itemLista.func_nome);
                        objLstViewItem.SubItems.Add(itemLista.prob_nome);
                        objLstViewItem.SubItems.Add(itemLista.cham_obs);
                        objLstViewItem.SubItems.Add(itemLista.cham_data);
                        objLstViewItem.SubItems.Add(itemLista.cham_osaberta);
                        lstCham.Items.Add(objLstViewItem);
                    }
                }
                txtPesquisar.Clear();
            }
        }

        private void AbrirOS()
        {
            int cham_id;
            string cham_equip_nome;
            string cham_func_nome;
            string cham_prob_nome;
            string cham_obs;
            string cham_data;

            try
            {

                if (lstCham.SelectedItems.Count > 0)
                {
                    cham_id = Convert.ToInt32(lstCham.SelectedItems[0].Text);
                    cham_equip_nome = lstCham.SelectedItems[0].SubItems[1].Text;
                    cham_func_nome = lstCham.SelectedItems[0].SubItems[2].Text;
                    cham_prob_nome = lstCham.SelectedItems[0].SubItems[3].Text;
                    cham_obs = lstCham.SelectedItems[0].SubItems[4].Text;
                    cham_data = lstCham.SelectedItems[0].SubItems[5].Text;

                    frmOrdemServico objFrmOS = new frmOrdemServico();
                    objFrmOS.cham_id = cham_id;
                    objFrmOS.cham_equip_nome = cham_equip_nome;
                    objFrmOS.cham_func_nome = cham_func_nome;
                    objFrmOS.cham_prob_nome = cham_prob_nome;
                    objFrmOS.cham_obs = cham_obs;
                    objFrmOS.cham_data = cham_data;
                    objFrmOS.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu o seguinte erro: " + ex.Message);
            }
            lstCham.Items.Clear();
        }

        private void CarregarCmbEquip()
        {
            clsDados dados = new clsDados();
            List<clsDados.Equipamentos> listEquip = new List<clsDados.Equipamentos>();
            listEquip = dados.Pesquisar_Equip();

            cmbEquip.DataSource = listEquip;
            cmbEquip.DisplayMember = "equip_nome";
            cmbEquip.ValueMember = "equip_id";
            cmbEquip.Text = "";            
        }

        private void CarregarCmbFunc()
        {
            clsDados dados = new clsDados();
            List<clsDados.Funcionarios> listFunc = new List<clsDados.Funcionarios>();
            listFunc = dados.Pesquisar_Func();

            cmbFunc.DataSource = listFunc;
            cmbFunc.DisplayMember = "func_nome";
            cmbFunc.ValueMember = "func_id";
            cmbFunc.Text = "";
        }

        private void CarregarCmbProb()
        {
            clsDados dados = new clsDados();
            List<clsDados.Problemas> listProb = new List<clsDados.Problemas>();
            listProb = dados.Pesquisar_Prob();

            cmbProb.DataSource = listProb;
            cmbProb.DisplayMember = "prob_nome";
            cmbProb.ValueMember = "prob_id";                               
            cmbProb.Text = "";
        }

        private void CarregarData()
        {
            txtData.Text = DateTime.Now.ToShortDateString();
        }

        #endregion 

        

        #region Botões

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            PesquisarCham();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(cmbEquip.Text) && !String.IsNullOrEmpty(cmbProb.Text) && !String.IsNullOrEmpty(cmbFunc.Text) && !String.IsNullOrEmpty(txtObs.Text))
            {
                if (cham_id == 0)
                {
                    clsDados dados = new clsDados();
                    cham_equip_id = Convert.ToInt32(cmbEquip.SelectedValue);
                    cham_func_id = Convert.ToInt32(cmbFunc.SelectedValue);
                    cham_prob_id = Convert.ToInt32(cmbProb.SelectedValue);
                    cham_obs = txtObs.Text;
                    cham_data = txtData.Text;
                    cham_osaberta = "0";
                    GravarCham(cham_id, cham_equip_id, cham_func_id, cham_prob_id, cham_obs, cham_data, cham_osaberta);
                    MessageBox.Show("Chamado Cadastrado com sucesso!");
                    cmbEquip.Text = "";
                    cmbFunc.Text = "";
                    cmbProb.Text = "";
                    txtObs.Clear();
                }
                else
                {
                    clsDados dados = new clsDados();
                    cham_equip_id = Convert.ToInt32(cmbEquip.SelectedValue);
                    cham_func_id = Convert.ToInt32(cmbFunc.SelectedValue);
                    cham_prob_id = Convert.ToInt32(cmbProb.SelectedValue);
                    cham_obs = txtObs.Text;
                    cham_data = txtData.Text;
                    cham_osaberta = "0";
                    dados.Atualizar_Cham(cham_id, cham_equip_id, cham_func_id, cham_prob_id, cham_obs, cham_data, cham_osaberta);
                    MessageBox.Show("Chamado Atualizado com sucesso!");
                    cmbEquip.Text = "";
                    cmbFunc.Text = "";
                    cmbProb.Text = "";
                    txtObs.Clear();
                }
            }
            else
            {
                if (String.IsNullOrEmpty(cmbEquip.Text))
                {
                    epErro.SetError(cmbEquip, "Selecione o equipamento!");
                }
                if (String.IsNullOrEmpty(cmbFunc.Text))
                {
                    epErro.SetError(cmbFunc, "Selecione o funcionário!");
                }
                if (String.IsNullOrEmpty(cmbProb.Text))
                {
                    epErro.SetError(cmbProb, "Selecione o problema!");
                }
            }

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            ExcluirCham();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            EditarCham();
        }

        private void btnAbrirOS_Click(object sender, EventArgs e)
        {
            AbrirOS();
            this.Close();
        }

        private void frmChamado_Load(object sender, EventArgs e)
        {
            CarregarCmbEquip();
            CarregarCmbFunc();
            CarregarCmbProb();
            CarregarData();
        }
       
        #endregion             

        
        
    }
}
