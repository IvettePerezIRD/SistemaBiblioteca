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
    public partial class impri_libros : Form
    {
        public impri_libros()
        {
            InitializeComponent();
        }

        private void impri_libros_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'labase1DataSet.libro' Puede moverla o quitarla según sea necesario.
            this.libroTableAdapter.Fill(this.labase1DataSet.libro);

            this.reportViewer1.RefreshReport();
        }
    }
}
