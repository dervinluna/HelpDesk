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
using ProyectoHelpDesk.Back;

namespace ProyectoHelpDesk
{
    public partial class jefeit : Form
    {
        public static SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP_SERVER;Initial Catalog=helpdesk;Integrated Security=True");
        int ticket;
        JefeIt JEFEIT = new JefeIt();
        public jefeit()
        {
            InitializeComponent();
           
        }

        private void jefeit_Load(object sender, EventArgs e)
        {
            string consulta = "select *from Solicitud";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conn);
            DataTable dt = new DataTable();
            conn.Open();
            adaptador.Fill(dt);
            conn.Close();
            dataGridView1.DataSource= dt;

        }

        private void textBDescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void txtTicket_TextChanged(object sender, EventArgs e)
        {
            ticket = Int32.Parse(txtTicket.Text);

        }

        private void reasignar_Click(object sender, EventArgs e)
        {
            JEFEIT.Reasignar(ticket);
            string consulta = "select *from Solicitud";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conn);
            DataTable dt = new DataTable();
            conn.Open();
            adaptador.Fill(dt);
            conn.Close();
            dataGridView1.DataSource = dt;
        }

        private void aprobar_Click(object sender, EventArgs e)
        {
            JEFEIT.Aprobar(ticket);
            string consulta = "select *from Solicitud";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conn);
            DataTable dt = new DataTable();
            conn.Open();
            adaptador.Fill(dt);
            conn.Close();
            dataGridView1.DataSource = dt;
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            JEFEIT.Cancelar(ticket);
            string consulta = "select *from Solicitud";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conn);
            DataTable dt = new DataTable();
            conn.Open();
            adaptador.Fill(dt);
            conn.Close();
            dataGridView1.DataSource = dt;
        }

        private void calificado_Click(object sender, EventArgs e)
        {
            JEFEIT.Calificar(ticket);
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
            JEFEIT.Pendiente(ticket);
            string consulta = "select *from Solicitud";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conn);
            DataTable dt = new DataTable();
            conn.Open();
            adaptador.Fill(dt);
            conn.Close();
            dataGridView1.DataSource = dt;
        }
    }
}
