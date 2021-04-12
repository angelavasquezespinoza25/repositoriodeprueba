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
    public partial class frmUsuario : Form
    {
        private Usuario Actual;
        public frmUsuario()
        {
            InitializeComponent();
            this.cboTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cboTipo.Items.Add("Administrador");
            this.cboTipo.Items.Add("Limitado");
            this.cboTrabajador.DropDownStyle = ComboBoxStyle.DropDownList;
            textClave.Text = ""; 
            textClave.PasswordChar = '*';
            textClave.MaxLength = 20;
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.LimpiarControles();
            this.ActivarControles(true);
            this.Actual = null;
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Usuario usu;

            if (this.ValidateChildren() == true)
            {
                if (this.Actual == null)
                {
                    usu = new Usuario();
                    Program.Usuarios.Add(usu);
                }
                else
                {
                    usu = this.Actual;
                }
                this.GuardarDatos(usu);
                this.ListarUsuarios();
                this.ActivarControles(false);
            }
            
        }
        private void ListarUsuarios()
        {
            this.dgvListado.DataSource = null;
           if (Program.Usuarios.Count>0)
            {
                this.dgvListado.DataSource = Program.Usuarios;

            }
            
        }

        private void GuardarDatos(Usuario wUsuario)
        {
            wUsuario.Trabajador = (Trabajador)this.cboTrabajador.SelectedItem;
            wUsuario.Nombre = this.textNombre.Text;
            wUsuario.Clave = this.textClave.Text;
            wUsuario.Tipo = (string)this.cboTipo.SelectedItem;
            wUsuario.Vigente = this.cbVigente.Checked;
        }
        private void ActivarControles(bool estado)
        {
            this.gbUsuario.Enabled = estado;
            this.gbListado.Enabled = !estado;
            if (estado == true)
            {
                this.cboTrabajador.Focus();
            }
            else
            {
                this.dgvListado.Focus();
            }
        }

        private void LimpiarControles()
        {
            this.cboTrabajador.SelectedIndex = -1;
            this.textNombre.Text = "";
            this.textClave.Text = "";
            this.cboTipo.SelectedIndex = -1;
            this.cbVigente.Checked = false;
       
        }
        

        private void CargarTrabajadores()
        {
            if (Program.Trabajadores.Count > 0)
            {
                this.cboTrabajador.DisplayMember = "NombresCompletos";
                this.cboTrabajador.DataSource = Program.Trabajadores;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            
            this.CargarTrabajadores();
            this.ListarUsuarios();
        }

      private void dgvListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in this.dgvListado.Rows)
            {
              
                    Usuario usu = row.DataBoundItem as Usuario;
                    if (usu.Vigente == false)
                    {
                        row.DefaultCellStyle.BackColor = Color.Red;
                    }
                    else
                    {
                     row.DefaultCellStyle.BackColor = Color.LightGreen;
                    }
                
            }
        }
        

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (this.dgvListado.CurrentRow != null)
            {
                this.Actual = (Usuario)this.dgvListado.CurrentRow.DataBoundItem;
                this.PresentarDatos();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un Usuario", this.Text);
                this.dgvListado.Focus();
            }
        }
        private void PresentarDatos()
        {
            this.cboTrabajador.Text = this.Actual.Trabajador.NombresCompletos;
            this.textNombre.Text = this.Actual.Nombre;
            this.textClave.Text = this.Actual.Clave;
            this.cboTipo.Text = this.Actual.Tipo;
            this.cbVigente.Checked = this.Actual.Vigente;
            this.ActivarControles(true);
        }
    }
    }
