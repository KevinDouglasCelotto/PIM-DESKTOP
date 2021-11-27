using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sistema.DAL;

namespace ProjetoPIM04.Apresentacao
{
    public partial class Checkin : Form
    {
        public Checkin()
        {
            InitializeComponent();
        }

        private void tb_ClienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tb_ClienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.projetoLoginDataSet1);

        }

        private void Checkin_Load(object sender, EventArgs e)
        {

            this.tabelaCCBindingSource.DataSource = DataContextFactory.DataContext.TabelaCC;
            // TODO: esta linha de código carrega dados na tabela 'projetoLoginDataSet.tb_Checkin'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_CheckinTableAdapter.Fill(this.projetoLoginDataSet.tb_Checkin);
            // TODO: esta linha de código carrega dados na tabela 'projetoLoginDataSet1.tb_Cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_ClienteTableAdapter.Fill(this.projetoLoginDataSet1.tb_Cliente);

        }
    }
}
