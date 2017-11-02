using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Controle_de_Estoque
{
    public partial class frm_telainicial : Form
    {
        public frm_telainicial()
        {
            InitializeComponent();
            
        }

        private void Inicial_Load(object sender, EventArgs e)
        {
           
        }

        private void oláToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
                    }

        private void relatoriosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void estoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ms_menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void registrarVendaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frm_registrarvenda C = new frm_registrarvenda();
            C.MdiParent = frm_telainicial.ActiveForm;
            C.Show();

        }
    }
}
