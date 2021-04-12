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
    public partial class frmTrabajador : Form
    {
        private Trabajador Actual;
        public frmTrabajador()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Trabajador trab;

            if (this.ValidateChildren() == true)
            {
                if (this.Actual == null)
                {
                    trab = new Trabajador();
                    Program.Trabajadores.Add(trab);
                }
                else
                {
                    trab = this.Actual;
                }
                this.GuardarDatos(trab);
                this.ListarTrabajadores();
                this.ActivarControles(false);
            }
        }

        private void ActivarControles(bool estado)
        {
            this.gbTrabajador.Enabled = estado;
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

        private void ListarTrabajadores()
        {
            this.dgvListado.DataSource = null;
            if (Program.Trabajadores.Count > 0)
            {
                this.dgvListado.AutoGenerateColumns = false;
                this.dgvListado.DataSource = Program.Trabajadores;
            }
        }

        private void GuardarDatos(Trabajador wtrab)
        {
            wtrab.Nombres = this.txtNombre.Text;
            wtrab.Apellidos=  this.txtApellidos.Text;
            wtrab.TipoDocumento = (DocumentoPersona)this.cboTipoDoc.SelectedItem;
            wtrab.NumeroDocumento = this.txtNumeroDocumento.Text;
            wtrab.Celular = this.txtCelular.Text;
            wtrab.Correo = this.txtCorreo.Text;
            wtrab.FechaNacimiento = this.dtFechaNac.Value;
            wtrab.Vigente = this.chkVigente.Checked;
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

        private void LimpiarControles()
        {
            this.txtNombre.Text = "";
            this.txtApellidos.Text = "";
            this.cboTipoDoc.SelectedItem = -1;
            this.txtNumeroDocumento.Text = "";
            this.txtCelular.Text = "";
            this.txtCorreo.Text = "";
            this.dtFechaNac.Value = DateTime.Now;
            this.chkVigente.Checked = true;     
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (this.dgvListado.CurrentRow != null)
            {
                this.Actual = (Trabajador)this.dgvListado.CurrentRow.DataBoundItem;
                this.PresentarDatos();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un Trabajador", this.Text);
                this.dgvListado.Focus();
            }
        }

        private void PresentarDatos()
        {
            this.txtNombre.Text = this.Actual.Nombres;
            this.txtApellidos.Text = this.Actual.Apellidos;
            this.cboTipoDoc.SelectedItem = this.Actual.TipoDocumento;
            this.txtNumeroDocumento.Text = this.Actual.NumeroDocumento;
            this.txtCelular.Text = this.Actual.Celular;
            this.txtCorreo.Text = this.Actual.Correo;
            this.dtFechaNac.Value = this.Actual.FechaNacimiento;
            this.chkVigente.Checked = this.Actual.Vigente;
            this.ActivarControles(true);
        }

        

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frmDocumentoPersona_Load(object sender, EventArgs e)
        {
            this.CargarDocumentoPersona();
            //this.ListarProductos();
        }

        private void CargarDocumentoPersona()
        {
            if (Program.DocumentosPer.Count > 0)
            {
                this.cboTipoDoc.DisplayMember = "Siglas";
                this.cboTipoDoc.DataSource = Program.DocumentosPer;
            }
        }
    }
}
