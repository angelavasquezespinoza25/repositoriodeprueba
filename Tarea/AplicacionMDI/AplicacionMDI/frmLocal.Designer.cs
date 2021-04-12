namespace AplicacionMDI
{
    partial class frmLocal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbListado = new System.Windows.Forms.GroupBox();
            this.dgvListado = new System.Windows.Forms.DataGridView();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.gbLocal = new System.Windows.Forms.GroupBox();
            this.chkVigente = new System.Windows.Forms.CheckBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.cdCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdVigente = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.gbListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
            this.gbLocal.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbListado
            // 
            this.gbListado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbListado.Controls.Add(this.dgvListado);
            this.gbListado.Controls.Add(this.btnModificar);
            this.gbListado.Controls.Add(this.btnNuevo);
            this.gbListado.Location = new System.Drawing.Point(410, 12);
            this.gbListado.Name = "gbListado";
            this.gbListado.Size = new System.Drawing.Size(378, 253);
            this.gbListado.TabIndex = 3;
            this.gbListado.TabStop = false;
            this.gbListado.Text = "Listado";
            // 
            // dgvListado
            // 
            this.dgvListado.AllowUserToAddRows = false;
            this.dgvListado.AllowUserToDeleteRows = false;
            this.dgvListado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cdCategoria,
            this.cdNombre,
            this.cdPrecio,
            this.cdVigente});
            this.dgvListado.Location = new System.Drawing.Point(16, 28);
            this.dgvListado.MultiSelect = false;
            this.dgvListado.Name = "dgvListado";
            this.dgvListado.ReadOnly = true;
            this.dgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListado.Size = new System.Drawing.Size(352, 178);
            this.dgvListado.TabIndex = 0;
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnModificar.Location = new System.Drawing.Point(95, 219);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNuevo.Location = new System.Drawing.Point(14, 219);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 1;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // gbLocal
            // 
            this.gbLocal.Controls.Add(this.txtTelefono);
            this.gbLocal.Controls.Add(this.txtDireccion);
            this.gbLocal.Controls.Add(this.chkVigente);
            this.gbLocal.Controls.Add(this.btnCancelar);
            this.gbLocal.Controls.Add(this.btnAceptar);
            this.gbLocal.Controls.Add(this.label3);
            this.gbLocal.Controls.Add(this.txtNombre);
            this.gbLocal.Controls.Add(this.label2);
            this.gbLocal.Controls.Add(this.lblNombre);
            this.gbLocal.Enabled = false;
            this.gbLocal.Location = new System.Drawing.Point(12, 12);
            this.gbLocal.Name = "gbLocal";
            this.gbLocal.Size = new System.Drawing.Size(392, 266);
            this.gbLocal.TabIndex = 2;
            this.gbLocal.TabStop = false;
            this.gbLocal.Text = "Producto";
            // 
            // chkVigente
            // 
            this.chkVigente.AutoSize = true;
            this.chkVigente.Location = new System.Drawing.Point(96, 192);
            this.chkVigente.Name = "chkVigente";
            this.chkVigente.Size = new System.Drawing.Size(62, 17);
            this.chkVigente.TabIndex = 8;
            this.chkVigente.Text = "Vigente";
            this.chkVigente.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(308, 230);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(227, 230);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 9;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Telefono";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(96, 76);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(278, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Direccion";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(26, 83);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Location = new System.Drawing.Point(713, 271);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(96, 117);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(278, 20);
            this.txtDireccion.TabIndex = 11;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(96, 154);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(136, 20);
            this.txtTelefono.TabIndex = 12;
            // 
            // cdCategoria
            // 
            this.cdCategoria.DataPropertyName = "Nombre";
            this.cdCategoria.HeaderText = "Nombre";
            this.cdCategoria.Name = "cdCategoria";
            this.cdCategoria.ReadOnly = true;
            // 
            // cdNombre
            // 
            this.cdNombre.DataPropertyName = "Direccion";
            this.cdNombre.HeaderText = "Direccion";
            this.cdNombre.Name = "cdNombre";
            this.cdNombre.ReadOnly = true;
            // 
            // cdPrecio
            // 
            this.cdPrecio.DataPropertyName = "Telefono";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            this.cdPrecio.DefaultCellStyle = dataGridViewCellStyle1;
            this.cdPrecio.HeaderText = "Telefono";
            this.cdPrecio.Name = "cdPrecio";
            this.cdPrecio.ReadOnly = true;
            // 
            // cdVigente
            // 
            this.cdVigente.DataPropertyName = "Vigente";
            this.cdVigente.HeaderText = "Vigente";
            this.cdVigente.Name = "cdVigente";
            this.cdVigente.ReadOnly = true;
            this.cdVigente.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cdVigente.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // frmLocal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 308);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.gbListado);
            this.Controls.Add(this.gbLocal);
            this.Name = "frmLocal";
            this.Text = "frmLocal";
            this.gbListado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
            this.gbLocal.ResumeLayout(false);
            this.gbLocal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbListado;
        private System.Windows.Forms.DataGridView dgvListado;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.GroupBox gbLocal;
        private System.Windows.Forms.CheckBox chkVigente;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdPrecio;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cdVigente;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtDireccion;
    }
}