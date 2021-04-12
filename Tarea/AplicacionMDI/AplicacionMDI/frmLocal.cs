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
    public partial class frmLocal : Form
    {
        private Local Actual;

        public frmLocal()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.ActivarControles(false);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.LimpiarControles();
            this.ActivarControles(true);
            this.Actual = null;
        }

        private void ActivarControles(bool estado)
        {
            this.gbLocal.Enabled = estado;
            this.gbListado.Enabled = !estado;
            if (estado == true)
            {
                this.txtNombre.Focus();
            }
            else
            {
                this.dgvListado.Focus();
            }
        }

        private void LimpiarControles()
        {
            this.txtNombre.Text = "";
            this.txtDireccion.Text = "";
            this.txtTelefono.Text = "";
            this.chkVigente.Checked = true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Local loc;

            if (this.ValidateChildren() == true)
            {
                if (this.Actual == null)
                {
                    loc = new Local();
                    Program.Locales.Add(loc);
                }
                else
                {
                    loc = this.Actual;
                }
                this.GuardarDatos(loc);
                this.ListarLocales();
                this.ActivarControles(false);
            }
        }

        private void ListarLocales()
        {
            this.dgvListado.DataSource = null;
            if (Program.Locales.Count > 0)
            {
                this.dgvListado.AutoGenerateColumns = false;
                this.dgvListado.DataSource = Program.Locales;
            }
        }

        private void GuardarDatos(Local loc)
        {
            loc.Nombre = this.txtNombre.Text;
            loc.Direccion = this.txtDireccion.Text;
            loc.Telefono = this.txtTelefono.Text;
            loc.Vigente = this.chkVigente.Checked;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (this.dgvListado.CurrentRow != null)
            {
                this.Actual = (Local)this.dgvListado.CurrentRow.DataBoundItem;
                this.PresentarDatos();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un Local", this.Text);
                this.dgvListado.Focus();
            }
        }

        private void PresentarDatos()
        {
            this.txtNombre.Text = this.Actual.Nombre;
            this.txtDireccion.Text = this.Actual.Direccion;
            this.txtTelefono.Text = this.Actual.Telefono;
            this.chkVigente.Checked = this.Actual.Vigente;
            this.ActivarControles(true);
        }
    }
}
