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
    public partial class cunsulta_libros_existentes : Form
    {
        private clase_libro cl_1 = new clase_libro();
        DataBase BD = new DataBase();
        string sql;
        public cunsulta_libros_existentes()
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
            sql = "SELECT*FROM libro WHERE cod_libr='" + txt_bncuenta.Text + "'";
            dataGridView1.DataSource = BD.consultar(sql, "libro");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sql = "SELECT*FROM libro WHERE nombr_libr='" + txt_buscar.Text + "'";
            dataGridView1.DataSource = BD.consultar(sql, "libro");
        }

        private void cunsulta_libros_existentes_Load(object sender, EventArgs e)
        {
            BD.IniciarConexion(@"labase1.mdb");
            dataGridView1.DataMember = "libro";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
       

        private void button3_Click(object sender, EventArgs e)
        {
            impri_libros li = new impri_libros();
            li.ShowDialog();
        }
    }
}
