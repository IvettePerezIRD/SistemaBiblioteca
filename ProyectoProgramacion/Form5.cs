using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Dll_LibreriaClase;





namespace ProyectoProgramacion
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        
        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dll_LibreriaClase.Class1 clase = new Dll_LibreriaClase.Class1();
            string HOla = null;
            HOla = clase.Hola();
            this.textBox1.Text = HOla.ToString();
        }

        private void Form5_MdiChildActivate(object sender, EventArgs e)
        {
            Form5 newMDIChild = new Form5();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }
    }
}
