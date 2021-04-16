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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }
        string text = "SISTEMA DE BIBLIOTECA";
        static int index = 0;

        private void lIBROSToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void eDITORIALToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aUTORToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void eSTUDIANTEToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void rEGISTROToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dEVOLUCIONToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void librosPretadosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listaDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void librosExistentesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void devolucionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {
            usuario li = new usuario();
            li.Show();
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            Libro li = new Libro();
            li.Show();
        }

        private void toolStripMenuItem14_Click(object sender, EventArgs e)
        {
            registro li = new registro();
            li.Show();
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            Editorial li = new Editorial();
            li.Show();
        }

        private void toolStripMenuItem15_Click(object sender, EventArgs e)
        {
            devolucion li = new devolucion();
            li.Show();
        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            autor li = new autor();
            li.Show();
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            cunsulta_devolucion li = new cunsulta_devolucion();
            li.Show();
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            cunsulta_libros_existentes li = new cunsulta_libros_existentes();
            li.Show();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            cunsulta_libros_prestados li=new cunsulta_libros_prestados();
            li.Show();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            cunsulta_usuarios li = new cunsulta_usuarios();
            li.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItem22_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            f li = new f();
            li.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = text.Substring(0, index) + "_";
            index++;
            if (index == text.Length + 1)
            {
                index = 0;
                //timer1.Enabled = false;
            }
        }

        private void registrarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            usuario li = new usuario();
            li.Show();
        }

        private void reistrarLibrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Libro li = new Libro();
            li.Show();
        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            registro li = new registro();
            li.Show();
        }

        private void registrarDevolucionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            devolucion li = new devolucion();
            li.Show();

        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            usuario li = new usuario();
            li.Show();
        }

        private void toolStripMenuItem6_Click_1(object sender, EventArgs e)
        {
            Libro li = new Libro();
            li.Show();

        }

        private void toolStripMenuItem3_Click_1(object sender, EventArgs e)
        {
            registro li = new registro();
            li.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            devolucion li = new devolucion();
            li.Show();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void informeDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cunsulta_usuarios li = new cunsulta_usuarios();
            li.Show();
        }

        private void informeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cunsulta_libros_existentes li = new cunsulta_libros_existentes();
            li.Show();

        }

        private void informePrestamosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cunsulta_libros_prestados li = new cunsulta_libros_prestados();
            li.Show();
        }

        private void informeDeDevolucionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cunsulta_devolucion li = new cunsulta_devolucion();
            li.Show();
        }

        private void autorToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            autor li = new autor();
            li.Show();
        }

        private void editorilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Editorial li = new Editorial();
            li.Show();
        }

        private void toolStripMenuItem5_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("iexplore.exe", "https://www.facebook.com/YCproduccions");
        }

        private void toolStripMenuItem12_Click_1(object sender, EventArgs e)
        {
            usuario li = new usuario();
            li.Show();
        }

        private void toolStripMenuItem2_Click_1(object sender, EventArgs e)
        {
            usuario li = new usuario();
            li.Show();
        }

        private void toolStripMenuItem14_Click_1(object sender, EventArgs e)
        {
            Libro li = new Libro();
            li.Show();
        }

        private void toolStripMenuItem7_Click_1(object sender, EventArgs e)
        {
            Libro li = new Libro();
            li.Show();
        }

        private void toolStripMenuItem15_Click_1(object sender, EventArgs e)
        {
            autor li = new autor();
            li.Show();

        }

        private void toolStripMenuItem16_Click(object sender, EventArgs e)
        {
            Editorial li = new Editorial();
            li.Show();
        }

        private void toolStripMenuItem18_Click(object sender, EventArgs e)
        {
            registro li = new registro();
            li.Show();
        }

        private void toolStripMenuItem20_Click(object sender, EventArgs e)
        {
            devolucion li = new devolucion();
            li.Show();
        }

        private void toolStripMenuItem8_Click_1(object sender, EventArgs e)
        {
            registro li = new registro();
            li.Show();
        }

        private void toolStripMenuItem9_Click_1(object sender, EventArgs e)
        {
            devolucion li = new devolucion();
            li.Show();
        }

        private void toolStripMenuItem22_Click_1(object sender, EventArgs e)
        {
            cunsulta_usuarios li = new cunsulta_usuarios();
            li.Show();
        }

        private void toolStripMenuItem23_Click(object sender, EventArgs e)
        {
            cunsulta_libros_existentes li = new cunsulta_libros_existentes();
            li.Show();

        }

        private void toolStripMenuItem24_Click(object sender, EventArgs e)
        {
            cunsulta_libros_prestados li = new cunsulta_libros_prestados();
            li.Show();
        }

        private void toolStripMenuItem25_Click(object sender, EventArgs e)
        {
            cunsulta_devolucion li = new cunsulta_devolucion();
            li.Show();
        }

        private void toolStripMenuItem26_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("iexplore.exe", "https://www.facebook.com/YCproduccions");
        }

        private void toolStripMenuItem27_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItem10_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void usuarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            report_useuario li = new report_useuario();
            li.ShowDialog();
        }

        private void prestamoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            report_prestam li = new report_prestam();
            li.ShowDialog();
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            f li = new f();
            li.Show();
        }

        private void menu_Load(object sender, EventArgs e)
        {

        }
    }
}
