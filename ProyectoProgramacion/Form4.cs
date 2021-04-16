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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtresultado.Text = (Convert.ToInt32(txt1.Text) + Convert.ToInt32(txt2.Text) + Convert.ToInt32(txt3.Text) + Convert.ToInt32(txt4.Text) + Convert.ToInt32(txt5.Text)).ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt1.Clear();
            txt2.Clear();
            txt3.Clear();
            txt4.Clear();
            txt5.Clear();
            txtresultado.Clear();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}   
