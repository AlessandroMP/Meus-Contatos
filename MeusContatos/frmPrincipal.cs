using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeusContatos
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void cONTATOSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cONTATOSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.agendaDeContatosDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'agendaDeContatosDataSet.CONTATOS'. Você pode movê-la ou removê-la conforme necessário.
            this.cONTATOSTableAdapter.Fill(this.agendaDeContatosDataSet.CONTATOS);

        }
    }
}
