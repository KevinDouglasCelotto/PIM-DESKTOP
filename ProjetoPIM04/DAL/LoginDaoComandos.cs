using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPIM04.DAL
{
    class LoginDaoComandos
    {
        public bool tem = false;
        public String mensagem = "";//tudo ok
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        SqlDataReader dr;
        public bool verificarLogin(String login, String senha)
        {
            //procurar no banco o login e senha
            cmd.CommandText = "select * from logins where email = @login and senha = @senha";
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@senha", senha);

            try
            {
                cmd.Connection = con.conectar();
                dr= cmd.ExecuteReader();
                if(dr.HasRows)//se foi encontrado no banco
                {
                    tem = true;
                }
                con.desconectar();
                dr.Close();
            }
            catch (SqlException)//mensagem de erro
            {
                this.mensagem = "Erro com Banco de Dados";
            }
            return tem;
        }
        public String cadastrar(String email, String senha, String confSenha)
        {
            tem = false;
            //comandos para inserir
            if (senha.Equals(confSenha))
            {
                cmd.CommandText = "insert into logins values (@e,@s)";
                cmd.Parameters.AddWithValue("@e", email);
                cmd.Parameters.AddWithValue("@s", senha);

                try
                {
                    cmd.Connection = con.conectar();
                    cmd.ExecuteNonQuery();
                    con.desconectar();
                    this.mensagem = "Cadastrado com sucesso!";
                    tem = true;

                }
                catch (SqlException)
                {
                    this.mensagem = "Erro com Banco de Dados";
                }
            }
            else
            {
                this.mensagem = "Senhas não correspondem!";
            }
            return mensagem;
        }
            
     }
}

