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
    public partial class frmOrdemServico : Form
    {
        public frmOrdemServico()
        {
            userConectado = frmLogin.userConectado;
            InitializeComponent();
        }

       public string userConectado;
       public int os_id;
       public int cham_id;
       public string status;
       public int os_tecnico_id;
       public string os_tec_nome;
       public string os_solucao;
       public string os_dt_entrega;
       public string cham_equip_nome;
       public string cham_func_nome;
       public string cham_prob_nome;
       public string cham_obs;
       public string cham_data;

       private void CarregarCmbTec()
       {
           clsDados dados = new clsDados();
           List<clsDados.Tecnicos> listTec = new List<clsDados.Tecnicos>();
           listTec = dados.Pesquisar_Tec();

           cmbTec.DataSource = listTec;
           cmbTec.DisplayMember = "tec_nome";
           cmbTec.ValueMember = "tec_id";
           cmbTec.Text = "";
       }

       private void CarregarChamado()
       {
           if (cham_id == 0)
           {
               txtChamID.Clear();
           }
           else
           {
               txtChamID.Text = cham_id.ToString();
           }
           txtDtCham.Text = cham_data;
           txtEquip.Text = cham_equip_nome;
           txtFunc.Text = cham_func_nome;
           txtProb.Text = cham_prob_nome;
           txtObs.Text = cham_obs;
       }

       private void EditarOS()
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
                    List<clsDados.Chamados> listaCham = new List<clsDados.Chamados>();
                    listaCham = dados.Pesquisar_Cham();
                    if (lstOS.SelectedItems.Count > 0)
                    {
                        os_id = Convert.ToInt32(lstOS.SelectedItems[0].Text);
                        status = lstOS.SelectedItems[0].SubItems[2].Text;
                        os_tec_nome = lstOS.SelectedItems[0].SubItems[3].Text;
                        os_solucao = lstOS.SelectedItems[0].SubItems[4].Text;
                        os_dt_entrega = lstOS.SelectedItems[0].SubItems[5].Text;
                        
                    }
           }
           catch (Exception ex)
           {
               
               throw;
           }

           /*
            * try
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
            * */
       }

       private void ExcluirOS()
       {

       }

       private void GravarOS()
       {

       }

       private void PesquisarOS()
       {           
           clsDados dados = new clsDados();
           List<clsDados.Os> listaOS = new List<clsDados.Os>();
           listaOS = dados.Pesquisar_Os();

           lstOS.Items.Clear();

           foreach (var itemLista in listaOS)
           {
               if (rbAberta.Checked == true)
               {
                   if (itemLista.os_status.ToString().StartsWith("A"))
                   {
                       ListViewItem objLstViewItem = new ListViewItem();
                       objLstViewItem.Text = itemLista.os_id.ToString();
                       objLstViewItem.SubItems.Add(itemLista.os_chamado_id.ToString());
                       objLstViewItem.SubItems.Add(itemLista.os_status);
                       objLstViewItem.SubItems.Add(itemLista.os_tecnico);
                       objLstViewItem.SubItems.Add(itemLista.os_solução);
                       objLstViewItem.SubItems.Add(itemLista.os_dt_entrega);
                       lstOS.Items.Add(objLstViewItem);
                   }                  
               }
               if (rbFechada.Checked == true)
               {
                   if (itemLista.os_status.ToString().StartsWith("F"))
                   {
                       ListViewItem objLstViewItem = new ListViewItem();
                       objLstViewItem.Text = itemLista.os_id.ToString();
                       objLstViewItem.SubItems.Add(itemLista.os_chamado_id.ToString());
                       objLstViewItem.SubItems.Add(itemLista.os_status);
                       objLstViewItem.SubItems.Add(itemLista.os_tecnico);
                       objLstViewItem.SubItems.Add(itemLista.os_solução);
                       objLstViewItem.SubItems.Add(itemLista.os_dt_entrega);
                       lstOS.Items.Add(objLstViewItem);
                   }
               }
               if (rbData.Checked == true)
               {
                   if (itemLista.os_dt_entrega.ToString() == mskPesquisa.Text)
                   {
                       ListViewItem objLstViewItem = new ListViewItem();
                       objLstViewItem.Text = itemLista.os_id.ToString();
                       objLstViewItem.SubItems.Add(itemLista.os_chamado_id.ToString());
                       objLstViewItem.SubItems.Add(itemLista.os_status);
                       objLstViewItem.SubItems.Add(itemLista.os_tecnico);
                       objLstViewItem.SubItems.Add(itemLista.os_solução);
                       objLstViewItem.SubItems.Add(itemLista.os_dt_entrega);
                       lstOS.Items.Add(objLstViewItem);
                   }
               }               
           }
           mskPesquisa.Clear();      
       }

       private void ConcluirOS()
       {

       }

       private void frmOrdemServico_Load(object sender, EventArgs e)
       {
           CarregarChamado();
           CarregarCmbTec();
       }

       private void btnSair_Click(object sender, EventArgs e)
       {
           this.Close();
       }

       private void btnPesquisar_Click(object sender, EventArgs e)
       {
           PesquisarOS();
       }

       private void btnGravar_Click(object sender, EventArgs e)
       {
           GravarOS();
       }

       private void btnDeletar_Click(object sender, EventArgs e)
       {
           ExcluirOS();
       }

       private void btnEditar_Click(object sender, EventArgs e)
       {
           EditarOS();
       }

       private void btnConcluir_Click(object sender, EventArgs e)
       {
           ConcluirOS();
       }

    }
}
