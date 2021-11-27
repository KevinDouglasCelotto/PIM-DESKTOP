using ProjetoPIM04.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoPIM04.Apresentacao
{
    public partial class CadastroCliente : Form
    {
        public CadastroCliente()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=YGOR-PC\SQLEXPRESS;Initial Catalog=ProjetoLogin;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;

        public void desabilitaCampos()
        {
            txbID.Enabled = false;
            txbNome.Enabled = false;
            txbEmail.Enabled = false;
            txbFone.Enabled = false;
            txbCPF.Enabled = false;
        }

        public void habilitaCampos()
        {
            txbNome.Enabled = true;
            txbEmail.Enabled = true;
            txbFone.Enabled = true;
            txbCPF.Enabled = true;
        }

        public void limparCampos()
        {
            txbID.Text = "";
            txbNome.Text = "";
            txbEmail.Text = "";
            txbFone.Text = "";
            txbCPF.Text = "";
        }


        private void CadastroCliente_Load(object sender, EventArgs e)
        {
            desabilitaCampos();//chamando o metodo para desabilitar os campos
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string strSQL = "Select cl_cpf from tb_cliente where cl_cpf =" + txbCPF.Text;
                cmd.Connection = con;
                cmd.CommandText = strSQL;
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    MessageBox.Show("CPF Já Cadastrado!");

                    con.Close();
                }
                else
                {
                    if (!dr.IsClosed) { dr.Close(); }
                    //Inserindo dados no banco
                    strSQL = "Insert into tb_cliente(cl_nome,cl_email,cl_fone,cl_cpf)values(@nome,@email,@fone,@cpf)";
                    cmd.Parameters.Add("@nome", SqlDbType.VarChar).Value = txbNome.Text;
                    cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = txbEmail.Text;
                    cmd.Parameters.Add("@fone", SqlDbType.VarChar).Value = txbFone.Text;
                    cmd.Parameters.Add("@cpf", SqlDbType.VarChar).Value = txbCPF.Text;
                    cmd.Connection = con;
                    cmd.CommandText = strSQL;

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Dados do cliente cadastrados com sucesso!");

                    cmd.Parameters.Clear();
                    con.Close();//Fechando conexão com banco

                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
                con.Close();//Fechando conexão com banco
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string strSQL = "Select * from tb_cliente where cl_cpf =" + txbConsulta.Text;
                cmd.Connection = con;
                cmd.CommandText = strSQL;
                dr = cmd.ExecuteReader();
                if (!dr.HasRows)// "!" foi usado para negação
                {
                    MessageBox.Show("CPF não cadastrado!!");
                    con.Close();
                }
                else
                {
                    dr.Read();
                    txbID.Text = dr["cl_id"].ToString();
                    txbNome.Text = dr["cl_nome"].ToString();
                    txbEmail.Text = dr["cl_email"].ToString();
                    txbFone.Text = dr["cl_fone"].ToString();
                    txbCPF.Text = dr["cl_cpf"].ToString();

                    habilitaCampos();

                    if(!dr.IsClosed) { dr.Close(); }
                    con.Close();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
                con.Close();//Fechando conexão com banco
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            habilitaCampos();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string strSQL = "delete from tb_cliente where cl_id = " + txbID.Text;

                cmd.Connection = con;
                cmd.CommandText = strSQL;

                cmd.ExecuteNonQuery();

                MessageBox.Show("Registro excluido com sucesso!!");
                limparCampos();
                con.Close();
            }
            catch(Exception erro)
            {
                MessageBox.Show(erro.Message);
                con.Close();
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
