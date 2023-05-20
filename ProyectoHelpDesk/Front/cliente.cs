using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoHelpDesk.Back;

namespace ProyectoHelpDesk.Front
{
    public partial class cliente : Form
    {
        string descrip;
        int idClient;
        
       
        Cliente   client= new Cliente();
        JefeIt jefeIt = new JefeIt();
       
        public cliente()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (client.Generar(descrip, idClient))
            {
                
                MessageBox.Show("Acción realizada con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBIdCliente.Text = string.Empty;
                textBDescripcion.Text = "";
                
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error. Revise los datos enviados...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void textBDescripcion_TextChanged(object sender, EventArgs e)
        {
            descrip = textBDescripcion.Text;
           

        }

        private void textBIdCliente_TextChanged(object sender, EventArgs e)
        {
            string dato = textBIdCliente.Text;

            if (string.IsNullOrEmpty(dato))
            {

            }
            else
            {
                idClient = Int32.Parse(dato);
            }
        }

            idClient =   Int32.Parse(dato);
             }


        private void cliente_Load(object sender, EventArgs e)
        {
           
        }

    }
}
