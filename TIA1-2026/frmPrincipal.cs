using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TIA1_2026
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ayudaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAyuda ayuda = new frmAyuda();
            ayuda.MdiParent = this;
            ayuda.Show();

        }
                      
        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAcercaDe AcercaDe = new frmAcercaDe();
            AcercaDe.MdiParent = this;
            AcercaDe.Show();
        }
    }
}
