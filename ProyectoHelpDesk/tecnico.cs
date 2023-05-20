using ProyectoHelpDesk.Back;
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

namespace ProyectoHelpDesk
{
    public partial class tecnico : Form
    {
        public static SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP_SERVER;Initial Catalog=helpdesk;Integrated Security=True");
        int ticket;
        int idtecnico;
        Tecnico TECNICO = new Tecnico();
        public tecnico()
        {
            InitializeComponent();
        }

        private void tecnico_Load(object sender, EventArgs e)
        {
            string consulta = "select *from Solicitud";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conn);
            DataTable dt = new DataTable();
            conn.Open();
            adaptador.Fill(dt);
            conn.Close();
            dataGridView1.DataSource = dt;
        }

        private void reasignar_Click(object sender, EventArgs e)
        {
            TECNICO.Asignar(ticket, idtecnico);
            string consulta = "select *from Solicitud";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conn);
            DataTable dt = new DataTable();
            conn.Open();
            adaptador.Fill(dt);
            conn.Close();
            dataGridView1.DataSource = dt;
        }

        private void pendiente_Click(object sender, EventArgs e)
        {
            TECNICO.Terminar(ticket);
            string consulta = "select *from Solicitud";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conn);
            DataTable dt = new DataTable();
            conn.Open();
            adaptador.Fill(dt);
            conn.Close();
            dataGridView1.DataSource = dt;
        }

        private void txtTicket_TextChanged(object sender, EventArgs e)
        {
            ticket = Int32.Parse(txtTicket.Text);
        }

        private void aprobar_Click(object sender, EventArgs e)
        {

        }

        private void calificado_Click(object sender, EventArgs e)
        {

        }

        private void cancelar_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            idtecnico = Int32.Parse(txtIdtec.Text);
        }
    }
}
