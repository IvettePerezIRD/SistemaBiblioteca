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
    public partial class Libro : Form
    {
        private Copia_de_clase_editorial db = new Copia_de_clase_editorial();
        private Copia_de_clase_autor lb = new Copia_de_clase_autor();
        private clase_libro cl_1 = new clase_libro();
        public Libro()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                cl_1.ingresar_a_la_Base_De_Datos(txt_codigo_libr.Text, txt_nombre_libr.Text, txt_autor.Text, txt_numpagin.Text, txt_gener.Text, txt_cod_editorial.Text, txt_fec_edicion.Text, txt_fec_public.Text, txt_edicion.Text, txt_idioma.Text, txt_numejemplars.Text, this.txt_ntomos.Text);
                MessageBox.Show("Ingresado a la base de datos");
                button3_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar a la base de datos" + Environment.NewLine + ex.Message);
            }
            txt_autor.Clear();
            txt_cod_editorial.Clear();
            txt_codigo_libr.Clear();
            txt_idioma.Clear();
            txt_nombre_libr.Clear();
            txt_ntomos.Clear();
            txt_numejemplars.Clear();
            txt_numpagin.Clear();
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                cl_1.actualizar_dato(txt_nombre_libr.Text, txt_nombre_libr.Text, txt_codigo_libr.Text);
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
                cedula_seleccionada = this.dataGridView1.SelectedRows[0].Cells["cod_libr"].Value.ToString();
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
                dt_usuario = lb.Traer_datos_de_access_estudiantes();
                Application.DoEvents();
                this.dataGridView2.DataSource = dt_usuario.DefaultView;
                Application.DoEvents();
                dt_usuario = db.Traer_datos_de_access_estudiantes();
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

        private void button8_Click(object sender, EventArgs e)
        {
            int renglon = dataGridView3.CurrentCell.RowIndex;

            {
                txt_cod_editorial.Text = dataGridView3[0, renglon].Value.ToString();
                panel2.Visible = false;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int renglon = dataGridView2.CurrentCell.RowIndex;

            {
                txt_autor.Text = dataGridView2[0, renglon].Value.ToString();
                panel1.Visible = false;
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

        private void txt_nombre_libr_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.sololetras(e);
        }

        private void txt_autor_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.sololetras(e);
        }

        private void txt_gener_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.sololetras(e);
        }

        private void txt_idioma_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.sololetras(e);
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            txt_autor.Clear();
            txt_cod_editorial.Clear();
            txt_codigo_libr.Clear();
            txt_idioma.Clear();
            txt_nombre_libr.Clear();
            txt_ntomos.Clear();
            txt_numejemplars.Clear();
            txt_numpagin.Clear();
        }

        private void txt_numpagin_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.solonumeros(e);
        }

        private void txt_numejemplars_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.solonumeros(e);
        }

        private void txt_ntomos_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.solonumeros(e);
        }

        private void dataGridView2_DoubleClick(object sender, EventArgs e)
        {
            string par1;
            par1 = Convert.ToString(this.dataGridView2.CurrentRow.Cells["cod_autor"].Value);
            int renglon = dataGridView2.CurrentCell.RowIndex;
            {
                txt_autor.Text = dataGridView2[0, renglon].Value.ToString();
                panel1.Visible = false;
            }
        }

        private void dataGridView3_DoubleClick(object sender, EventArgs e)
        {
            string par1;
            par1 = Convert.ToString(this.dataGridView3.CurrentRow.Cells["cod_editorial"].Value);
            int renglon = dataGridView3.CurrentCell.RowIndex;

            {
                txt_cod_editorial.Text = dataGridView3[0, renglon].Value.ToString();
                panel2.Visible = false;
            }
        }
    }
}
