
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
    public partial class Bem_vindo : Form
    {
        public Bem_vindo()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CadastroCliente cadcliente = new CadastroCliente();
            cadcliente.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmCk frm = new FrmCk();
            frm.Show();
        }
    }
}
