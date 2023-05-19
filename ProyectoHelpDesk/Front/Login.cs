using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProyectoHelpDesk.Front
{
    public partial class Login : UserControl
    {
        public Login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           

        }
        private void txtuser_Enter(object sender, EventArgs e)
        {
            if (textUsuario.Text == "Usuario")
            {
                textUsuario.Text = "";
                textUsuario.ForeColor = Color.LightGray;
            }
        }
        private void txtuser_Leave(object sender, EventArgs e)
        {
            if (textUsuario.Text == "")
            {
                textUsuario.Text = "Usuario";
                textUsuario.ForeColor = Color.Silver;
            }
        }

        private void textPassword_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtpass_Enter(object sender, EventArgs e)
        {
            if (textPassword.Text == "Contraseña")
            {
                textPassword.Text = "Contraseña";
                textPassword.ForeColor = Color.LightGray;
                textPassword.UseSystemPasswordChar = true;
            }
        }
        private void txtpass_Leave(object sender, EventArgs e)
        {
            if (textPassword.Text == "")
            {
                textPassword.Text = "Contraseña";
                textPassword.ForeColor = Color.Silver;
                textPassword.UseSystemPasswordChar = false;
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void butnIniciar_Click(object sender, EventArgs e)
        {

        }
    }
}
