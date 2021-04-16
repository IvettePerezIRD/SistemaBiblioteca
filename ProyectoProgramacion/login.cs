using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ProyectoProgramacion
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
            
        }

        private void login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Quiere Cerrar el sistema?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = progressBar1.Value + 5;
            if (Convert.ToInt32(progressBar1.Value) == 100)
            {
                timer1.Stop();
                timer1.Enabled = false;
                // MessageBox.Show("Bienvenido al sistema " + txt_user.Text, "Usuario autorizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                menu li = new menu();
                this.Hide();
                li.Show();

            }
            }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection Conexion = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\cuentas.accdb");
            Conexion.Open();
            String Consulta = "select password,cuenta_usuario from usuarios where password='" + txt_pass.Text + "' and cuenta_usuario ='" + txt_user.Text + "';";
            OleDbCommand Comando = new OleDbCommand(Consulta, Conexion);
            OleDbDataReader LectorDatos;
            LectorDatos = Comando.ExecuteReader();
            Boolean ExistenciaRegistros = LectorDatos.HasRows;
            if (ExistenciaRegistros)
            {
                timer1.Start();
            }


            else
            {
                MessageBox.Show("Acceso denegado " + txt_user.Text, "Usuario NO autorizado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        }
    }

