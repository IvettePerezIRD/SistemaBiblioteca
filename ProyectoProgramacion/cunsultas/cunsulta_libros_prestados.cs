using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoProgramacion
{
    public partial class cunsulta_libros_prestados : Form
    {
        private clase_registro cl_1 = new clase_registro();
        DataBase BD = new DataBase();
        string sql;
        public cunsulta_libros_prestados()
        {
            InitializeComponent();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt_estudiantes, dt_carreras = new DataTable();
                Application.DoEvents();
                dt_estudiantes = cl_1.Traer_datos_de_access_estudiantes();
                Application.DoEvents();
                this.dataGridView1.DataSource = dt_estudiantes.DefaultView;
                Application.DoEvents();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error al conectar a la base de datos access" + Environment.NewLine + ex.Message);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            sql = "SELECT*FROM registro WHERE DNI='" + txt_bncuenta.Text + "'";
            dataGridView1.DataSource = BD.consultar(sql, "registro");
        }

        private void cunsulta_libros_prestados_Load(object sender, EventArgs e)
        {
            BD.IniciarConexion(@"labase1.mdb");
            dataGridView1.DataMember = "registro";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
        

        private void button3_Click(object sender, EventArgs e)
        {
            impri_prestam li = new impri_prestam();
            li.ShowDialog();
        }

    }
}
