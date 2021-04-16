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
    public partial class f : Form
    {
        public f()
        {
            InitializeComponent();
        }

        private void email_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("iexplore", " https:" + email.Text);
        }

        private void email2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("iexplore", " https:" + email2.Text);
        }

        private void f_Activated(object sender, EventArgs e)
        {
            ok.Focus();
        }

        private void ok_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
