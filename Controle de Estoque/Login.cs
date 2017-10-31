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
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }

        private void pgb_login_Click(object sender, EventArgs e)
        {
            


        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (txt_usuario.Text == "capoia" && mtb_senha.Text == "08109250")
            {
                pgb_login.Visible = true;
                do
                {
                    pgb_login.Value = pgb_login.Value + 2;
                } while (pgb_login.Value < 100);

                MessageBox.Show("Logado com sucesso!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Usuario ou senha incorreto", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
