using ProyectoHelpDesk.Back;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoHelpDesk.Front
{
    public partial class Login : Form
    {
        string password;
        string user;
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            login verifica = new login();

            switch (verifica.Guardando(password, user).tipo)
            {
                case 10:
                    MessageBox.Show("Bienvenido Jefe It", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Ocultar el formulario actual
                    this.Hide();
                    jefeit jefe = new jefeit();
                    jefe.Show();

                    break;
                case 11:
                    MessageBox.Show("Bienvenido Tecnico", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Ocultar el formulario actual
                    this.Hide();
                    tecnico tecni = new tecnico();
                    tecni.Show();
                    break;
                case 12:
                    MessageBox.Show("Bienvenido cliente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Ocultar el formulario actual
                    this.Hide();
                    cliente clientes = new cliente();
                    clientes.Show();
                    break;
                default:
                    MessageBox.Show("Ha ocurrido un error. Revise los datos enviados... ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            password= txtPass.Text;
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {
            user = txtUser.Text;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
