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
    public partial class impri_prestam : Form
    {
        public impri_prestam()
        {
            InitializeComponent();
        }

        private void impri_prestam_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'labase1DataSet.registro' Puede moverla o quitarla según sea necesario.
            this.registroTableAdapter.Fill(this.labase1DataSet.registro);

            this.reportViewer1.RefreshReport();
        }
    }
}
