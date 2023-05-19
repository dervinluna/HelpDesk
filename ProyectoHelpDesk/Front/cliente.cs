using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
<<<<<<< HEAD
using System.Data.SqlClient;
=======
>>>>>>> f9a017f3238c510e5494daea48cb1f1874920198
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
        String descrip;
        int idClient;
        Cliente   client= new Cliente();
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
            client.Generar(descrip, idClient);
            MessageBox.Show("Acción realizada con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void textBDescripcion_TextChanged(object sender, EventArgs e)
        {
            descrip = textBDescripcion.Text;
           

        }

        private void textBIdCliente_TextChanged(object sender, EventArgs e)
        {
            string dato = textBIdCliente.Text;
            idClient =   Int32.Parse(dato);
             }
<<<<<<< HEAD

        private void cliente_Load(object sender, EventArgs e)
        {
           
        }
=======
>>>>>>> f9a017f3238c510e5494daea48cb1f1874920198
    }
}
