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
    public partial class impri_user : Form
    {
        public impri_user()
        {
            InitializeComponent();
        }

        private void impri_user_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'labase1DataSet.usuario' Puede moverla o quitarla según sea necesario.
            this.usuarioTableAdapter.Fill(this.labase1DataSet.usuario);

            this.reportViewer1.RefreshReport();
        }
    }
}
