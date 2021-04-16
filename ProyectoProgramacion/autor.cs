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
    public partial class autor : Form
    {
        private clase_autor cl_1 = new clase_autor();
        public autor()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                cl_1.ingresar_a_la_Base_De_Datos(txt_codigo_libr.Text, txt_codigo_estud.Text, this.txt_fec_prestamo.Text);
                MessageBox.Show("Ingresado a la base de datos");
                button3_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar a la base de datos" + Environment.NewLine + ex.Message);
            }
            txt_codigo_estud.Clear();
            txt_codigo_libr.Clear();
            txt_fec_prestamo.Clear();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                cl_1.actualizar_dato(txt_codigo_libr.Text, txt_codigo_estud.Text, txt_fec_prestamo.Text);
                MessageBox.Show("Datos Actualizados", "alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                button3_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar a la base de datos" + Environment.NewLine + ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                string cedula_seleccionada = null;
                cedula_seleccionada = this.dataGridView1.SelectedRows[0].Cells["cod_autor"].Value.ToString();
                cl_1.Borrar_Estudiante_Seleccionado(cedula_seleccionada);
                MessageBox.Show("Borrado con exito", "mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                button3_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("error al conectar a la base de datos access" + Environment.NewLine + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txt_codigo_estud_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.sololetras(e);
        }

        private void txt_fec_prestamo_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.sololetras(e);
        }
    }
}
