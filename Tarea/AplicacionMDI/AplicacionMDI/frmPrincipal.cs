using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionMDI
{
  public partial class frmPrincipal : Form
  {
    public frmPrincipal()
    {
      InitializeComponent();
    }

    private void mnuCategorias_Click(object sender, EventArgs e)
    {
      frmCategorias frm = new frmCategorias();

      frm.MdiParent = this;
      frm.WindowState = FormWindowState.Maximized;
      frm.Show();
      //frm.ListarCategorias();
      // Singleton
    }

    private void mnuProductos_Click(object sender, EventArgs e)
    {
            if (Program.Categorias.Count > 0)
            {
                frmProducto frm = new frmProducto();

                frm.MdiParent = this;
                frm.WindowState = FormWindowState.Maximized;
                frm.Show();

            }
            else
            {
                MessageBox.Show("Primero debe registrar una categoria", this.Text);
            }
    }

    private void mnuVenta_Click(object sender, EventArgs e)
    {
      frmVenta  frm = new frmVenta();

      frm.MdiParent = this;
      frm.WindowState = FormWindowState.Maximized;
      frm.Show();
    }

        private void mnuClientes_Click(object sender, EventArgs e)
        {
            frmCliente frm = new frmCliente();

            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void mnuLocal_Click(object sender, EventArgs e)
        {
            frmLocal frm = new frmLocal();

            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void mnuDocumentoPersonas_Click(object sender, EventArgs e)
        {
            frmDocumentoPersona frm = new frmDocumentoPersona();

            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void mnuTrabajadores_Click(object sender, EventArgs e)
        {
           if (Program.DocumentosPer.Count > 0)
            {
                frmTrabajador frm = new frmTrabajador();

                frm.MdiParent = this;
                frm.WindowState = FormWindowState.Maximized;
                frm.Show();
            }
            else
               MessageBox.Show("Primero Registre al menos un Tipo de Documento de Persona", this.Text);
        }

        private void mnuUsuario_Click(object sender, EventArgs e)
        {
            if (Program.Trabajadores.Count > 0)
            {
                frmUsuario frm = new frmUsuario();

                frm.MdiParent = this;
                frm.WindowState = FormWindowState.Maximized;
                frm.Show();
            }
            else
            {
                MessageBox.Show("Primero Registrar Trabajador", this.Text,
               MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }
    }
}
