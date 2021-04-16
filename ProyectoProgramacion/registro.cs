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
    public partial class registro : Form
    {
        private Copia_de_clase_libro lb = new Copia_de_clase_libro();
        private Copia_de_clase_usuario db = new Copia_de_clase_usuario();
        private clase_registro cl_1 = new clase_registro();
        public registro()
        {
            InitializeComponent();
            timer1.Enabled = true;
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                cl_1.ingresar_a_la_Base_De_Datos(txt_codigo_registro.Text, txt_codigo_usuario.Text, txt_codi_libr.Text, txt_fec_salid.Text, this.txt_estado.Text);
                MessageBox.Show("Ingresado a la base de datos");
                button3_Click_1(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar a la base de datos" + Environment.NewLine + ex.Message);
            }
            txt_codi_libr.Clear();
            txt_codigo_registro.Clear();
            txt_codigo_usuario.Clear();
            txt_estado.Clear();
            txt_fec_salid.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                cl_1.actualizar_dato(txt_codigo_registro.Text, txt_codigo_usuario.Text, txt_codi_libr.Text);
                MessageBox.Show("Datos Actualizados", "alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                button3_Click_1(sender, e);
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
                button3_Click_1(sender, e);
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
                Application.DoEvents();
                dt_usuario = lb.Traer_datos_de_access_estudiantes();
                Application.DoEvents();
                this.dataGridView3.DataSource = dt_usuario.DefaultView;
                Application.DoEvents();
                panel1.Visible = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("error al conectar a la base de datos access" + Environment.NewLine + ex.Message);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int renglon = dataGridView2.CurrentCell.RowIndex;

            {
                txt_codigo_usuario.Text = dataGridView2[0, renglon].Value.ToString();
                panel1.Visible = false;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int renglon = dataGridView3.CurrentCell.RowIndex;

            {
                txt_codi_libr.Text = dataGridView3[0, renglon].Value.ToString();
                panel2.Visible = false;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {

            try
            {
                DataTable dt_estudiantes, dt_carreras = new DataTable();
                label1.Text = "Buscando informacion en access";
                Application.DoEvents();
                dt_estudiantes = cl_1.Traer_datos_de_access_estudiantes();
                label1.Text = "cargando controles";
                Application.DoEvents();
                this.dataGridView1.DataSource = dt_estudiantes.DefaultView;
                label1.Text = "Listo";
                Application.DoEvents();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error al conectar a la base de datos access" + Environment.NewLine + ex.Message);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txt_fec_salid.Text = DateTime.Now.ToString();
        }

        private void txt_codigo_usuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.solonumeros(e);
        }

        private void txt_estado_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.sololetras(e);
        }

        private void dataGridView2_DoubleClick(object sender, EventArgs e)
        {
            string par1;
            par1 = Convert.ToString(this.dataGridView2.CurrentRow.Cells["DNI"].Value);
            int renglon = dataGridView2.CurrentCell.RowIndex;

            {
                txt_codigo_usuario.Text = dataGridView2[0, renglon].Value.ToString();
               
            }
            panel1.Visible = false;
        }

        private void dataGridView3_DoubleClick(object sender, EventArgs e)
        {
            string par1;
            par1 = Convert.ToString(this.dataGridView3.CurrentRow.Cells["cod_libr"].Value);
            int renglon = dataGridView3.CurrentCell.RowIndex;

            {
                txt_codi_libr.Text = dataGridView3[0, renglon].Value.ToString();
                panel2.Visible = false;
            }
        }
    }
}
