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
    public partial class devolucion : Form
    {
        private Copia_de_clase_registro db = new Copia_de_clase_registro();
        private Clase_devolucion cl_1 = new Clase_devolucion();
        public devolucion()
        {
            InitializeComponent();
            timer1.Enabled = true;
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
                cl_1.ingresar_a_la_Base_De_Datos(txt_codigo_registro.Text, this.txt_fec_entrada.Text);
                MessageBox.Show("Ingresado a la base de datos");
                button3_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar a la base de datos" + Environment.NewLine + ex.Message);
            }
            txt_codigo_registro.Clear();
            txt_fec_entrada.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                cl_1.actualizar_dato(txt_codigo_registro.Text, txt_fec_entrada.Text);
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
                cedula_seleccionada = this.dataGridView1.SelectedRows[0].Cells["cod_registro"].Value.ToString();
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

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt_usuario, dt_carreras = new DataTable();
                Application.DoEvents();
                dt_usuario = db.Traer_datos_de_access_estudiantes();
                Application.DoEvents();
                this.dataGridView2.DataSource = dt_usuario.DefaultView;
                panel1.Visible = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("error al conectar a la base de datos access" + Environment.NewLine + ex.Message);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int renglon = dataGridView2.CurrentCell.RowIndex;

            {
                txt_codigo_registro.Text = dataGridView2[0, renglon].Value.ToString();
                panel1.Visible = false;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txt_fec_entrada.Text = DateTime.Now.ToString();
        }

        private void dataGridView2_DoubleClick(object sender, EventArgs e)
        {
            string par1;
            par1 = Convert.ToString(this.dataGridView2.CurrentRow.Cells["cod_registro"].Value);
            int renglon = dataGridView2.CurrentCell.RowIndex;

            {
                txt_codigo_registro.Text = dataGridView2[0, renglon].Value.ToString();
                panel1.Visible = false;
            }
        }
       }
    }
