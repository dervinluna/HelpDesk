using ProyectoHelpDesk.Back;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoHelpDesk.Front
{
    public partial class Login2 : Form
    {
        
        string password;
        string user;
        public Login2()
        {
            InitializeComponent();
        }


        private void Login2_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            
            login verifica = new login();
            
            switch(verifica.Guardando(password, user).tipo)
            {
                case 10:
                    
                    break;
                    case 11:
                    break;
                    case 12:
                    MessageBox.Show("Bienvenido cliente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Ocultar el formulario actual
                    this.Hide();
                    cliente clientes = new cliente();
                    clientes.Show();
                    break; 
                default: MessageBox.Show("Ha ocurrido un error. Revise los datos enviados... ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            user = txtUser.Text;

        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            password=txtPass.Text;

        }
    }
}
