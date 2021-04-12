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
    public partial class frmCliente : Form
    {
        private Cliente Actual;


  

        public frmCliente()
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

        private void ActivarControles(bool estado)
        {
            this.gbCliente.Enabled = estado;
            this.gbListado.Enabled = !estado;
            if (estado == true)
            {
                this.txtNombres.Focus();
            }
            else
            {
                this.dgvListado.Focus();
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Cliente cli;

            if (this.ValidateChildren() == true)
            {
                if (this.Actual == null)
                {
                    cli = new Cliente();
                    Program.Clientes.Add(cli);
                }
                else
                {
                    cli = this.Actual;
                }
                this.GuardarDatos(cli);
                this.ListarClientes();
                this.ActivarControles(false);
            }
        }

        private void ListarClientes()
        {
            this.dgvListado.DataSource = null;
            if (Program.Clientes.Count > 0)
            {
                this.dgvListado.AutoGenerateColumns = false;
                this.dgvListado.DataSource = Program.Clientes;
            }
        }

        private void GuardarDatos(Cliente cli)
        {
            cli.TipoDocumento = (DocumentoPersona)this.cboTipoDoc.SelectedItem;
            cli.Nombres = this.txtNombres.Text;
            cli.Apellidos = this.txtApellidos.Text;
            cli.NumeroDocumento = this.txtNumDoc.Text;
            cli.FechaNacimiento = this.dtFechaNac.Value;
            cli.Vigente = this.chkVigente.Checked;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.LimpiarControles();
            this.ActivarControles(true);
            this.Actual = null;
        }

        private void LimpiarControles()
        {
            this.cboTipoDoc.SelectedIndex = -1;
            this.txtNombres.Text = "";
            this.txtApellidos.Text = "";
            this.txtNumDoc.Text = "";
            this.dtFechaNac.Value = DateTime.Now;
            this.chkVigente.Checked = true;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        { 
            if (this.dgvListado.CurrentRow != null)
          {
                this.Actual = (Cliente)this.dgvListado.CurrentRow.DataBoundItem;
                this.PresentarDatos();
          }
          else
          {
                MessageBox.Show("Debe seleccionar un cliente", this.Text);
                this.dgvListado.Focus();
            }

        }

        private void PresentarDatos()
        {
            this.cboTipoDoc.Text = this.Actual.TipoDocumento.Nombre;
            this.txtNombres.Text = this.Actual.Nombres;
            this.txtApellidos.Text = this.Actual.Apellidos;
            this.txtNumDoc.Text = this.Actual.NumeroDocumento;
            this.dtFechaNac.Value = this.Actual.FechaNacimiento;
            this.chkVigente.Checked = this.Actual.Vigente;
            this.ActivarControles(true);
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            this.CargarDocumentos();
        }

        private void CargarDocumentos()
        {
            if (Program.DocumentosPer.Count > 0)
            {
                this.cboTipoDoc.DisplayMember = "Nombre";
                this.cboTipoDoc.DataSource = Program.DocumentosPer;
            }
        }
    }
}
