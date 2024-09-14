using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace CtrlManut
{
    public class clsDados
    {
        public string strConexao = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

        #region Equipamentos
        public class Equipamentos
        {
            public int equip_id { get; set;}
            public string equip_nome { get; set; }
            public string equip_local { get; set; }
        }

        public void Atualizar_Equip(int equip_id, string equip_nome, string equip_local)
        {
            string strUpdate = "UPDATE tab_equipamento " + "SET equip_nome = @equip_nome, equip_local = @equip_local WHERE equip_id = @equip_id";
            using (SqlConnection objConexao = new SqlConnection(strConexao))
            {                
                using (SqlCommand objCmd = new SqlCommand(strUpdate, objConexao))
                {
                    objCmd.Parameters.AddWithValue("@equip_id", equip_id);
                    objCmd.Parameters.AddWithValue("@equip_nome", equip_nome);
                    objCmd.Parameters.AddWithValue("@equip_local", equip_local);

                    objConexao.Open();
                    objCmd.ExecuteNonQuery();
                    objConexao.Close();
                }
            }
        }

        public void Excluir_Equip(int equip_id)
        {
            string strDelete = "DELETE FROM tab_equipamento WHERE equip_id = @equip_id";
            using (SqlConnection objConexão = new SqlConnection(strConexao))
            {
                using (SqlCommand cmd = new SqlCommand(strDelete, objConexão))
                {
                    cmd.Parameters.AddWithValue("@equip_id", equip_id);
                    objConexão.Open();
                    cmd.ExecuteNonQuery();
                    objConexão.Close();
                }
            }
        }


        public void Inserir_Equip(int equip_id, string equip_nome, string equip_local)
        {
            string strInsert = "INSERT INTO tab_equipamento VALUES " + "(@equip_nome, @equip_local)";
            using (SqlConnection objConexao = new SqlConnection(strConexao))
            {
                using (SqlCommand cmd = new SqlCommand(strInsert, objConexao))
                {
                    cmd.Parameters.AddWithValue("@equip_nome", equip_nome);
                    cmd.Parameters.AddWithValue("@equip_local", equip_local);

                    objConexao.Open();
                    cmd.ExecuteNonQuery();
                    objConexao.Close();
                }
            }
        }

        public List<Equipamentos> Pesquisar_Equip()
        {
            string strSelect = "SELECT equip_id, equip_nome, equip_local FROM tab_equipamento";
            List<Equipamentos> lstEquip = new List<Equipamentos>();
            using (SqlConnection objConexao = new SqlConnection(strConexao))
            {
                using (SqlCommand cmd = new SqlCommand(strSelect, objConexao))
                {
                    objConexao.Open();
                    SqlDataReader objDR = cmd.ExecuteReader();
                    if(objDR.HasRows)
                    {
                        while(objDR.Read())
                        {
                            Equipamentos objEquip = new Equipamentos();
                            objEquip.equip_id = Convert.ToInt32(objDR["equip_id"].ToString());
                            objEquip.equip_nome = objDR["equip_nome"].ToString();
                            objEquip.equip_local = objDR["equip_local"].ToString();
                            lstEquip.Add(objEquip);
                        }
                        objDR.Close();
                    }
                    objConexao.Close();
                }
            }
            return lstEquip;
        }
        #endregion

        #region Usuários
        public class Usuarios
        {
            public int idLogin { get; set; }
            public string usuario { get; set; }
            public string senha { get; set; }
        }

        public void Atualizar_User(int idLogin, string usuario, string senha)
        {
            string strUpdate = "UPDATE tab_usuarios " + "SET usuario = @usuario, senha = @senha WHERE idLogin = @idLogin";
            using (SqlConnection objConexao = new SqlConnection(strConexao))
            {
                using (SqlCommand cmd = new SqlCommand(strUpdate, objConexao))
                {
                    cmd.Parameters.AddWithValue("@idLogin", idLogin);
                    cmd.Parameters.AddWithValue("@usuario", usuario);
                    cmd.Parameters.AddWithValue("@senha", senha);

                    objConexao.Open();
                    cmd.ExecuteNonQuery();
                    objConexao.Close();
                }
            }
        }

        public void Excluir_User(int idLogin)
        {
            string strDelete = "DELETE FROM tab_usuarios WHERE idLogin = @idLogin";
            using (SqlConnection objConexao = new SqlConnection(strConexao))
            {
                using (SqlCommand cmd = new SqlCommand(strDelete, objConexao))
                {
                    cmd.Parameters.AddWithValue("@idLogin", idLogin);
                    objConexao.Open();
                    cmd.ExecuteNonQuery();
                    objConexao.Close();
                }
            }
        }

        public void Inserir_User(int idLogin, string usuario, string senha)
        {
            string strInsert = "INSERT INTO tab_usuarios VALUES " + "(@usuario, @senha)";
            using (SqlConnection objConexao = new SqlConnection(strConexao))
            {
                using (SqlCommand cmd = new SqlCommand(strInsert, objConexao))
                {
                    cmd.Parameters.AddWithValue("@usuario", usuario);
                    cmd.Parameters.AddWithValue("@senha", senha);
                    objConexao.Open();
                    cmd.ExecuteNonQuery();
                    objConexao.Close();
                }
            }
        }

        public void Conectar_User(string usuario, string senha)
        {
            string strSelect = "SELECT idLogin, usuario, senha FROM tab_usuarios WHERE usuario = @usuario and senha = @senha";
            
            using (SqlConnection objConexao = new SqlConnection(strConexao))
            {
                using (SqlCommand cmd = new SqlCommand(strSelect, objConexao))
                {
                    cmd.Parameters.AddWithValue("@usuario", usuario);
                    cmd.Parameters.AddWithValue("@senha", senha);
                    objConexao.Open();
                    SqlDataReader objDR = cmd.ExecuteReader();
                    if (objDR.HasRows)
                    {
                        while (objDR.Read())
                        {
                            frmLogin.userConectado = usuario;
                        }
                        objDR.Close();
                    }
                    objConexao.Close();
                }
            }           
        }

        public List<Usuarios> Pesquisar_User()
        {
            string strSelect = "SELECT idLogin, usuario, senha FROM tab_usuarios";
            List<Usuarios> lstUser = new List<Usuarios>();
            using (SqlConnection objConexao = new SqlConnection(strConexao))
            {
                using (SqlCommand cmd = new SqlCommand(strSelect, objConexao))
                {
                    objConexao.Open();
                    SqlDataReader objDR = cmd.ExecuteReader();
                    if (objDR.HasRows)
                    {
                        while (objDR.Read())
                        {
                            Usuarios objUser = new Usuarios();
                            objUser.idLogin = Convert.ToInt32(objDR["idLogin"].ToString());
                            objUser.usuario = objDR["usuario"].ToString();
                            objUser.senha = objDR["senha"].ToString();
                            lstUser.Add(objUser);
                        }
                        objDR.Close();
                    }
                    objConexao.Close();
                }
            }
            return lstUser;
        }
        #endregion

        #region Tecnicos
        public class Tecnicos
        {
            public int tec_id { get; set; }
            public string tec_nome { get; set; }
        }

        public void Atualizar_Tec(int tec_id, string tec_nome)
        {
            string strUpdate = "UPDATE tab_tecnicos " + "SET tec_nome = @tec_nome WHERE tec_id = @tec_id";
            using (SqlConnection objConexao = new SqlConnection(strConexao))
            {
                using (SqlCommand cmd = new SqlCommand(strUpdate, objConexao))
                {
                    cmd.Parameters.AddWithValue("@tec_id", tec_id);
                    cmd.Parameters.AddWithValue("@tec_nome", tec_nome);

                    objConexao.Open();
                    cmd.ExecuteNonQuery();
                    objConexao.Close();
                }
            }
        }

        public void Excluir_Tec(int tec_id)
        {
            string strDelete = "DELETE FROM tab_tecnicos WHERE tec_id = @tec_id";
            using (SqlConnection objConexao = new SqlConnection(strConexao))
            {
                using (SqlCommand cmd = new SqlCommand(strDelete, objConexao))
                {
                    cmd.Parameters.AddWithValue("@tec_id", tec_id);

                    objConexao.Open();
                    cmd.ExecuteNonQuery();
                    objConexao.Close();
                }
            }
        }

        public void Inserir_Tec(int tec_id, string tec_nome)
        {
            string strInsert = "INSERT INTO tab_tecnicos VALUES " + "(@tec_nome)";
            using (SqlConnection objConexao = new SqlConnection(strConexao))
            {
                using (SqlCommand cmd = new SqlCommand(strInsert, objConexao))
                {
                    cmd.Parameters.AddWithValue("@tec_nome", tec_nome);

                    objConexao.Open();
                    cmd.ExecuteNonQuery();
                    objConexao.Close();
                }
            }
        }

        public List<Tecnicos> Pesquisar_Tec()
        {
            string strSelect = "SELECT tec_id, tec_nome FROM tab_tecnicos";
            List<Tecnicos> lstTecnicos = new List<Tecnicos>();
            using (SqlConnection objConexao = new SqlConnection(strConexao))
            {
                using (SqlCommand cmd = new SqlCommand(strSelect, objConexao))
                {
                    objConexao.Open();
                    SqlDataReader objDR = cmd.ExecuteReader();
                    if(objDR.HasRows)
                    {
                        while(objDR.Read())
                        {
                            Tecnicos objTecnicos = new Tecnicos();
                            objTecnicos.tec_id = Convert.ToInt32(objDR["tec_id"].ToString());
                            objTecnicos.tec_nome =objDR["tec_nome"].ToString();
                            lstTecnicos.Add(objTecnicos);
                        }
                        objDR.Close();
                    }
                    objConexao.Close();
                }
            }
            return lstTecnicos;
        }
        #endregion

        #region Funcionarios
        public class Funcionarios
        {
            public int func_id { get; set; }
            public string func_nome { get; set; }
            public string func_cargo { get; set; }
        }

        public void Atualizar_Func(int func_id, string func_nome, string func_cargo)
        {
            string strUpdate = "UPDATE tab_funcionarios " + "SET func_nome = @func_nome, func_cargo = @func_cargo WHERE func_id = @func_id";
            using (SqlConnection objConexao = new SqlConnection(strConexao))
            {
                using (SqlCommand cmd = new SqlCommand(strUpdate, objConexao))
                {
                    cmd.Parameters.AddWithValue("@func_id", func_id);
                    cmd.Parameters.AddWithValue("@func_nome", func_nome);
                    cmd.Parameters.AddWithValue("@func_cargo", func_cargo);
                    objConexao.Open();
                    cmd.ExecuteNonQuery();
                    objConexao.Close();
                }
            }
        }

        public void Excluir_Func(int func_id)
        {
            string strDelete = "DELETE from tab_funcionarios WHERE func_id = @func_id";
            using (SqlConnection objConexao = new SqlConnection(strConexao))
            {
                using (SqlCommand cmd = new SqlCommand(strDelete, objConexao))
                {
                    cmd.Parameters.AddWithValue("@func_id", func_id);
                    objConexao.Open();
                    cmd.ExecuteNonQuery();
                    objConexao.Close();
                }
            }
        }

        public void Incluir_Func(int func_id, string func_nome, string func_cargo)
        {
            string strInsert = "INSERT INTO tab_funcionarios VALUES" + "(@func_nome, @func_cargo)";
            using (SqlConnection objConexao = new SqlConnection(strConexao))
            {
                using (SqlCommand cmd = new SqlCommand(strInsert, objConexao))
                {
                    cmd.Parameters.AddWithValue("@func_nome", func_nome);
                    cmd.Parameters.AddWithValue("@func_cargo", func_cargo);
                    objConexao.Open();
                    cmd.ExecuteNonQuery();
                    objConexao.Close();
                }
            }
        }
        public List<Funcionarios> Pesquisar_Func()
        {
            string strSelect = "SELECT func_id, func_nome, func_cargo FROM tab_funcionarios";
            List<Funcionarios> lstFunc = new List<Funcionarios>();
            using (SqlConnection objConexao = new SqlConnection(strConexao))
            {
                using (SqlCommand cmd = new SqlCommand(strSelect, objConexao))
                {
                    objConexao.Open();
                    SqlDataReader objDR = cmd.ExecuteReader();
                    if (objDR.HasRows)
                    {
                        while (objDR.Read())
                        {
                            Funcionarios objFunc = new Funcionarios();
                            objFunc.func_id = Convert.ToInt32(objDR["func_id"].ToString());
                            objFunc.func_nome = objDR["func_nome"].ToString();
                            objFunc.func_cargo = objDR["func_cargo"].ToString();
                            lstFunc.Add(objFunc);
                        }
                        objDR.Close();
                    }
                    objConexao.Close();
                }
            }
            return lstFunc;
        }

        #endregion

        #region Problemas
        public class Problemas
        {
            public int prob_id { get; set; }
            public string prob_tipo { get; set; }
            public string prob_nome { get; set; }
        }

        public void Atualizar_Prob(int prob_id, string prob_tipo, string prob_nome)
        {
            string strUpdate = "UPDATE tab_problemas " + "SET prob_tipo = @prob_tipo, prob_nome = @prob_nome WHERE prob_id = @prob_id";
            using (SqlConnection objConexao = new SqlConnection(strConexao))
            {
                using (SqlCommand cmd = new SqlCommand(strUpdate, objConexao))
                {
                    cmd.Parameters.AddWithValue("@prob_id", prob_id);
                    cmd.Parameters.AddWithValue("@prob_tipo", prob_tipo);
                    cmd.Parameters.AddWithValue("@prob_nome", prob_nome);

                    objConexao.Open();
                    cmd.ExecuteNonQuery();
                    objConexao.Close();
                }
            }
        }

        public void Excluir_Prob(int prob_id)
        {
            string strDelete = "DELETE FROM tab_problemas WHERE prob_id = @prob_id";

            using (SqlConnection objConexao = new SqlConnection(strConexao))
            {
                using (SqlCommand cmd = new SqlCommand(strDelete, objConexao))
                {
                    cmd.Parameters.AddWithValue("@prob_id", prob_id);

                    objConexao.Open();
                    cmd.ExecuteNonQuery();
                    objConexao.Close();
                }
            }
        }

        public void Inserir_Prob(int prob_id, string prob_tipo, string prob_nome)
        {
            string strInsert = "INSERT INTO tab_problemas VALUES " + "(@prob_tipo, @prob_nome)";
            using (SqlConnection objConexao = new SqlConnection(strConexao))
            {
                using (SqlCommand cmd = new SqlCommand(strInsert, objConexao))
                {
                    cmd.Parameters.AddWithValue("@prob_tipo", prob_tipo);
                    cmd.Parameters.AddWithValue("@prob_nome", prob_nome);

                    objConexao.Open();
                    cmd.ExecuteNonQuery();
                    objConexao.Close();
                }
            }
        }

        public List<Problemas> Pesquisar_Prob()
        {
            string strSelect = "SELECT prob_id, prob_tipo, prob_nome FROM tab_problemas";
            List<Problemas> lstProb = new List<Problemas>();
            
            using (SqlConnection objConexao = new SqlConnection(strConexao))
            {
                using (SqlCommand cmd = new SqlCommand(strSelect, objConexao))
                {
                    objConexao.Open();

                    SqlDataReader objDR = cmd.ExecuteReader();

                    if (objDR.HasRows)
                    {
                        while (objDR.Read())
                        {
                            Problemas objProblemas = new Problemas();
                            objProblemas.prob_id = Convert.ToInt32(objDR["prob_id"].ToString());
                            objProblemas.prob_tipo = objDR["prob_tipo"].ToString();
                            objProblemas.prob_nome = objDR["prob_nome"].ToString();
                            lstProb.Add(objProblemas);
                        }
                        objDR.Close();
                    }
                    objConexao.Close();
                }
            }
            return lstProb;
        }
        #endregion

        #region OS
        public class Os
        {
            public int os_id { get; set; }
            public int os_chamado_id { get; set; }
            public string os_status { get; set; }
            public int os_tecnico_id { get; set; }
            public string os_solução { get; set; }
            public string os_dt_entrega { get; set; }
            public string os_tecnico { get; set; }
        }

        public void Atualizar_Os(int os_id, int os_chamado_id, string os_status, int os_tecnico_id, string os_solucao, string os_dt_entrega)
        {
            string strUpdate = "UPDATE tab_os " + "SET os_chamado_id = @os_chamado_id, os_status = @os_status, os_tecnico_id = @os_tecnico_id, os_solucao = @os_solucao, os_dt_entrega = @os_dt_entrega WHERE os_id = @os_id";
            using (SqlConnection objConexao = new SqlConnection(strConexao))
            {
                using (SqlCommand cmd = new SqlCommand(strUpdate, objConexao))
                {
                    cmd.Parameters.AddWithValue("@os_id", os_id);
                    cmd.Parameters.AddWithValue("@os_chamado_id", os_chamado_id);
                    cmd.Parameters.AddWithValue("@os_status", os_status);
                    cmd.Parameters.AddWithValue("@os_tecnico_id", os_tecnico_id);
                    cmd.Parameters.AddWithValue("@os_solucao", os_solucao);
                    cmd.Parameters.AddWithValue("@os_dt_entrega", os_dt_entrega);

                    objConexao.Open();
                    cmd.ExecuteNonQuery();
                    objConexao.Close();
                }
            }
        }

        public void Excluir_Os(int os_id)
        {
            string strDelete = "DELETE FROM tab_os WHERE os_id = @os_id";
            using (SqlConnection objConexao = new SqlConnection(strConexao))
            {
                using (SqlCommand cmd = new SqlCommand(strDelete, objConexao))
                {
                    cmd.Parameters.AddWithValue("@os_id", os_id);

                    objConexao.Open();
                    cmd.ExecuteNonQuery();
                    objConexao.Close();                    
                }
            }
        }

        public void Incluir_Os(int os_id, int os_chamado_id, string os_status, int os_tecnico_id, string os_solucao, string os_dt_entrega)
        {
            string strInsert = "INSERT INTO tab_os VALUES " + "(os_chamado_id, os_status, os_tecnico_id, os_solucao, os_dt_entrega";

            using (SqlConnection objConexao = new SqlConnection(strConexao))
            {
                using (SqlCommand cmd = new SqlCommand(strInsert, objConexao))
                {
                    cmd.Parameters.AddWithValue("@os_id", os_id);
                    cmd.Parameters.AddWithValue("@os_chamado_id", os_chamado_id);
                    cmd.Parameters.AddWithValue("@os_status", os_status);
                    cmd.Parameters.AddWithValue("@os_tecnico_id", os_tecnico_id);
                    cmd.Parameters.AddWithValue("@os_solucao", os_solucao);
                    cmd.Parameters.AddWithValue("@os_dt_entrega", os_dt_entrega);

                    objConexao.Open();
                    cmd.ExecuteNonQuery();
                    objConexao.Close();
                }
            }
        }

        public List<Os> Pesquisar_Os()
        {
            string strSelect = "SELECT os_id, os_chamado_id, os_status, os_tecnico_id, tec_nome, os_solucao, os_dt_entrega FROM tab_os  tos INNER JOIN tab_tecnicos tt ON tos.os_tecnico_id = tt.tec_id";
            List<Os> lstOs = new List<Os>();
            using (SqlConnection objConexao = new SqlConnection(strConexao))
            {
                using (SqlCommand cmd = new SqlCommand(strSelect, objConexao))
                {
                    objConexao.Open();

                    SqlDataReader objDR = cmd.ExecuteReader();

                    if (objDR.HasRows)
                    {
                        while (objDR.Read())
                        {
                            Os objOs = new Os();
                            objOs.os_id = Convert.ToInt32(objDR["os_id"].ToString());
                            objOs.os_chamado_id = Convert.ToInt32(objDR["os_chamado_id"].ToString());
                            objOs.os_status = objDR["os_status"].ToString();
                            objOs.os_tecnico = objDR["tec_nome"].ToString();
                            objOs.os_solução = objDR["os_solucao"].ToString();
                            objOs.os_dt_entrega = objDR["os_dt_entrega"].ToString();
                            lstOs.Add(objOs);
                        }
                        objDR.Close();
                    }
                    objConexao.Close();
                }
            }
            return lstOs;
        }
        #endregion

        #region Chamados
        public class Chamados
        {
            public int cham_id { get; set; }
            public int cham_equip_id { get; set; }
            public int cham_func_id { get; set; }
            public int cham_prob_id { get; set; }
            public string cham_obs { get; set; }
            public string cham_data { get; set; }
            public string cham_osaberta { get; set; }
            public string equip_nome { get; set; }
            public string func_nome { get; set; }
            public string prob_nome { get; set; }
        }

        public void Atualizar_Cham(int cham_id, int cham_equip_id, int cham_func_id, int cham_prob_id, string cham_obs, string cham_data, string cham_osaberta)
        {
            string strUpdate = "UPDATE tab_chamados " + "SET cham_equip_id = @cham_equip_id, cham_func_id = @cham_func_id, cham_prob_id = @cham_prob_id, cham_obs = @cham_obs, cham_data = @cham_data, cham_osaberta = @cham_osaberta WHERE cham_id = @cham_id";

            using (SqlConnection objConexao = new SqlConnection(strConexao))
            {
                using (SqlCommand cmd = new SqlCommand(strUpdate, objConexao))
                {
                    cmd.Parameters.AddWithValue("@cham_id", cham_id);
                    cmd.Parameters.AddWithValue("@cham_equip_id", cham_equip_id);
                    cmd.Parameters.AddWithValue("@cham_func_id", cham_func_id);
                    cmd.Parameters.AddWithValue("@cham_prob_id", cham_prob_id);
                    cmd.Parameters.AddWithValue("@cham_obs", cham_obs);
                    cmd.Parameters.AddWithValue("@cham_data", cham_data);
                    cmd.Parameters.AddWithValue("@cham_osaberta", cham_osaberta);

                    objConexao.Open();
                    cmd.ExecuteNonQuery();
                    objConexao.Close();
                }
            }
        }

        public void Excluir_Cham(int cham_id)
        {
            string strDelete = "DELETE FROM tab_chamados WHERE cham_id = @cham_id";

            using (SqlConnection objConexao = new SqlConnection(strConexao))
            {
                using (SqlCommand cmd = new SqlCommand(strDelete, objConexao))
                {
                    cmd.Parameters.AddWithValue("@cham_id", cham_id);

                    objConexao.Open();
                    cmd.ExecuteNonQuery();
                    objConexao.Close();
                }
            }
        }

        public void Inserir_Cham(int cham_id, int cham_equip_id, int cham_func_id, int cham_prob_id, string cham_obs, string cham_data, string cham_osaberta)
        {
            string strInsert = "INSERT INTO tab_chamados VALUES " + "(@cham_equip_id, @cham_func_id, @cham_prob_id, @cham_obs, @cham_data, @cham_osaberta)";

            using (SqlConnection objConexao = new SqlConnection(strConexao))
            {
                using (SqlCommand cmd = new SqlCommand(strInsert, objConexao))
                {
                    cmd.Parameters.AddWithValue("@cham_equip_id", cham_equip_id);
                    cmd.Parameters.AddWithValue("@cham_func_id", cham_func_id);
                    cmd.Parameters.AddWithValue("@cham_prob_id", cham_prob_id);
                    cmd.Parameters.AddWithValue("@cham_obs", cham_obs);
                    cmd.Parameters.AddWithValue("@cham_data", cham_data);
                    cmd.Parameters.AddWithValue("@cham_osaberta", cham_osaberta);

                    objConexao.Open();
                    cmd.ExecuteNonQuery();
                    objConexao.Close();
                }
            }
        }

        public List<Chamados> Pesquisar_Cham()
        {
            string strSelect = "SELECT cham_id, equip_nome, func_nome, prob_nome, cham_obs, cham_data, cham_osaberta FROM tab_equipamento te INNER JOIN tab_chamados tc ON tc.cham_equip_id = te.equip_id INNER JOIN tab_funcionarios tf ON tc.cham_func_id = tf.func_id INNER JOIN tab_problemas tp ON tc.cham_prob_id = tp.prob_id";
            List<Chamados> lstCham = new List<Chamados>();

            using (SqlConnection objConexao = new SqlConnection(strConexao))
            {
                using (SqlCommand cmd = new SqlCommand(strSelect, objConexao))
                {
                    objConexao.Open();

                    SqlDataReader objDR = cmd.ExecuteReader();

                    if (objDR.HasRows)
                    {
                        while (objDR.Read())
                        {
                            Chamados objCham = new Chamados();
                            objCham.cham_id = Convert.ToInt32(objDR["cham_id"].ToString());
                            objCham.equip_nome = objDR["equip_nome"].ToString();                            
                            objCham.func_nome = objDR["func_nome"].ToString();
                            objCham.prob_nome = objDR["prob_nome"].ToString();
                            objCham.cham_obs = objDR["cham_obs"].ToString();
                            objCham.cham_data = objDR["cham_data"].ToString();
                            objCham.cham_osaberta = objDR["cham_osaberta"].ToString();
                            lstCham.Add(objCham);
                        }
                        objDR.Close();
                    }
                    objConexao.Close();
                }
            }
            return lstCham;
        }

        

        #endregion

        
    }
}
