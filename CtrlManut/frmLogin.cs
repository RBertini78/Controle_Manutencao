using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;

namespace CtrlManut
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            Thread thread = new Thread(new ThreadStart(SplashScreen));
            thread.Start();
            Thread.Sleep(5000);
            thread.Abort();
            InitializeComponent();
        }

        public void SplashScreen()
        {
            Application.Run(new frmSplash());
        }

        public static string userConectado;
        public int idLogin;
        public string usuario;
        public string senha;

        
        private void CarregarUser()
        {
            usuario = txtUsuario.Text;
            senha = txtSenha.Text;
            clsDados dados = new clsDados();


            dados.Conectar_User(usuario, senha);
                   if(userConectado == txtUsuario.Text)
                   {
                    frmPrincipal p = new frmPrincipal();
                    this.Hide();
                    p.Show();
                    }
                else
                {
                    MessageBox.Show("Usuário e/ou senha incorretas","Aviso de Segurança",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    txtUsuario.Clear();
                    txtUsuario.Focus();
                    txtSenha.Clear();
                }
            }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUsuario.Text != "" && txtSenha.Text != "")
                {
                    CarregarUser();
                }
                else
                {
                    MessageBox.Show("Usuário e/ou senha não podem ficar vazios", "Aviso de Segurança", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu o seguinte erro:" + ex.Message);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }            
   }
}
