using ProjetoPIM04.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPIM04.Modelo
{
    public class Controle
    {
        public bool tem;
        public String mensagem = "";
        public bool acessar(String login, String senha)
        {
            LoginDaoComandos loginDao = new LoginDaoComandos();
            tem = loginDao.verificarLogin(login, senha);
            if(!loginDao.mensagem.Equals(""))
            {
                this.mensagem = loginDao.mensagem;

            }
            return tem;
        }

        public String cadastrar(String email, String senha, String confSenha)
        {
            LoginDaoComandos loginDao = new LoginDaoComandos();
            this.mensagem = loginDao.cadastrar(email, senha, confSenha);
            if(loginDao.tem)//a mensagem que vai vir é que ocorreu tudo certo
            {
                this.tem = true;
            }
            return mensagem;
        }
    }
}
