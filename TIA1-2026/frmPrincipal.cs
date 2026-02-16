using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TIA1_2026.Facturación;
using TIA1_2026.Seguridad;
using TIA1_2026.Tablas;

namespace TIA1_2026
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void AbrirFormulario(Form formulario)
        {
            // Cierra cualquier MDI hijo abierto
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }

            // Configura el nuevo formulario hijo
            formulario.MdiParent = this;
            formulario.StartPosition = FormStartPosition.Manual;
            formulario.Location = new Point(0, 0);
            formulario.WindowState = FormWindowState.Maximized;

            formulario.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ayudaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AbrirFormulario (new frmAyuda());
        }
                      
        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmAcercaDe());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmClientes());
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmProductos());
        }

        private void categoríasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmCategoria());
        }

        private void faToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmFacturas());
        }

        private void informesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmInformes());
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmEmpleados());
        }

        private void rolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmRolEmpleados());
        }

        private void seguridadToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmAdminSeguridad());
        }
    }
}

