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
    public partial class FrmCk : Form
    {
        public FrmCk()
        {
            InitializeComponent();
        }

        private void tb_CkBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tb_CkBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.projetoLoginDataSet2);

        }

        private void FrmCk_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'projetoLoginDataSet2.tb_Ck'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_CkTableAdapter.Fill(this.projetoLoginDataSet2.tb_Ck);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
