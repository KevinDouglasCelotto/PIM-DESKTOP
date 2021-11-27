using ProjetoPIM04.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoPIM04.Apresentacao
{
    public partial class Cadastre_se : Form
    {
        public Cadastre_se()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            String mensagem = controle.cadastrar(txbLogin.Text, txbSenha.Text, txbConfSenha.Text);
            if(controle.tem)//mensagem de sucesso
            {
                MessageBox.Show(mensagem, "Cadastro", MessageBoxButtons.OK);
            }else
            {
                MessageBox.Show(controle.mensagem);//mensagem de erro
            }

            //senhas tem que contem caracteres e numeros
            //antes de cadastrar ver se ja existe email com este nome
        }
    }
}
