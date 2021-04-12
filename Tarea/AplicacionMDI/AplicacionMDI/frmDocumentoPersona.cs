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
    public partial class frmDocumentoPersona : Form
    {
        private DocumentoPersona Actual;
        public frmDocumentoPersona()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            DocumentoPersona docper;

            if (this.ValidateChildren() == true)
            {
                if (this.Actual == null)
                {
                    docper = new DocumentoPersona();
                    Program.DocumentosPer.Add(docper);
                }
                else
                {
                    docper = this.Actual;
                }
                this.GuardarDatos(docper);
                this.ListarDocumentosPersona();
                this.ActivarControles(false);
            }
        }

        private void ActivarControles(bool estado)
        {
            this.gbDocumento.Enabled = estado;
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

        private void ListarDocumentosPersona()
        {
            this.dgvListado.DataSource = null;
            if (Program.DocumentosPer.Count > 0)
            {
                this.dgvListado.AutoGenerateColumns = false;
                this.dgvListado.DataSource = Program.DocumentosPer;
            }
        }

        private void GuardarDatos(DocumentoPersona wDocper)
        {
            wDocper.Nombre = this.txtNombre.Text;
            wDocper.Siglas = this.txtSiglas.Text;
            wDocper.Valores = (int) this.nudValores.Value;
            wDocper.Vigente = this.chkVigente.Checked;
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
            this.txtSiglas.Text = "";
            this.nudValores.Value = 0 ;
            this.chkVigente.Checked = true;
            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (this.dgvListado.CurrentRow != null)
            {
                this.Actual = (DocumentoPersona)this.dgvListado.CurrentRow.DataBoundItem;
                this.PresentarDatos();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un Documento", this.Text);
                this.dgvListado.Focus();
            }
        }

        private void PresentarDatos()
        {
            this.txtNombre.Text = this.Actual.Nombre;
            this.txtSiglas.Text = this.Actual.Siglas;
            this.nudValores.Value = this.Actual.Valores;
            this.chkVigente.Checked = this.Actual.Vigente;
            this.ActivarControles(true);
        }

        private void frmDocumentoPersona_Load(object sender, EventArgs e)
        {
            this.ListarDocumentosPersona();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
