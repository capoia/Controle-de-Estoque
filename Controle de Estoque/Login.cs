using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Controle_de_Estoque
{
    public partial class frm_login : Form // Variavel global para carregar a lista de usuarios
    {
        List<Usuario> usuarios = new List<Usuario>();

        public frm_login()
        {
            InitializeComponent();
        }

        private void pgb_login_Click(object sender, EventArgs e)
        {
            


        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string usuario= txt_usuario.Text, senha= mtb_senha.Text;
            
            Usuario user = usuarios.Where(a=> a.usuario == usuario).FirstOrDefault();


            if (user != null && user.senha == senha )
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

            try 
            {
                
                string[] array = File.ReadAllLines(@"C:\Users\weell\Desktop\users.txt");
                for (int i = 0; i < array.Length; i++)
                {
                    Usuario U = new Usuario();
                    string[] auxiliar = array[i].Split('|');
                    U.tipo = auxiliar[0];
                    U.usuario = auxiliar[1];
                    U.senha = auxiliar[2];
                    usuarios.Add(U);

                    
                }
            }
            catch (System.IO.FileNotFoundException)
            {
                StreamWriter users = new StreamWriter(@"C:\Users\weell\Desktop\users.txt");
                users.WriteLine("Administrador|ROOT|TOOR");
                users.Close();


                
                string[] array = File.ReadAllLines(@"C:\Users\weell\Desktop\users.txt");
                for (int i = 0; i < array.Length; i++)
                {
                    Usuario U = new Usuario();
                    string[] auxiliar = array[i].Split('|');
                    U.tipo = auxiliar[0];
                    U.usuario = auxiliar[1];
                    U.senha = auxiliar[2];
                    usuarios.Add(U);
                }
                users.Close();
                users.Dispose();

            }
        }
    }
}
