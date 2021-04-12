namespace AplicacionMDI
{
    partial class frmTrabajador
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
            this.gbTrabajador = new System.Windows.Forms.GroupBox();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.dtFechaNac = new System.Windows.Forms.DateTimePicker();
            this.lblTipoDocumento = new System.Windows.Forms.Label();
            this.cboTipoDoc = new System.Windows.Forms.ComboBox();
            this.chkVigente = new System.Windows.Forms.CheckBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.txtNumeroDocumento = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblCelular = new System.Windows.Forms.Label();
            this.lblNumerodocumento = new System.Windows.Forms.Label();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.gbListado = new System.Windows.Forms.GroupBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.dgvListado = new System.Windows.Forms.DataGridView();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.cdNombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdApellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdTipoDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdNrodoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdCelular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdVigente = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.gbTrabajador.SuspendLayout();
            this.gbListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
            this.SuspendLayout();
            // 
            // gbTrabajador
            // 
            this.gbTrabajador.Controls.Add(this.lblFechaNacimiento);
            this.gbTrabajador.Controls.Add(this.dtFechaNac);
            this.gbTrabajador.Controls.Add(this.lblTipoDocumento);
            this.gbTrabajador.Controls.Add(this.cboTipoDoc);
            this.gbTrabajador.Controls.Add(this.chkVigente);
            this.gbTrabajador.Controls.Add(this.btnCancelar);
            this.gbTrabajador.Controls.Add(this.btnAceptar);
            this.gbTrabajador.Controls.Add(this.txtCorreo);
            this.gbTrabajador.Controls.Add(this.txtCelular);
            this.gbTrabajador.Controls.Add(this.txtNumeroDocumento);
            this.gbTrabajador.Controls.Add(this.txtApellidos);
            this.gbTrabajador.Controls.Add(this.txtNombre);
            this.gbTrabajador.Controls.Add(this.lblCorreo);
            this.gbTrabajador.Controls.Add(this.lblCelular);
            this.gbTrabajador.Controls.Add(this.lblNumerodocumento);
            this.gbTrabajador.Controls.Add(this.lblApellidos);
            this.gbTrabajador.Controls.Add(this.lblNombre);
            this.gbTrabajador.Enabled = false;
            this.gbTrabajador.Location = new System.Drawing.Point(11, 19);
            this.gbTrabajador.Name = "gbTrabajador";
            this.gbTrabajador.Size = new System.Drawing.Size(315, 456);
            this.gbTrabajador.TabIndex = 0;
            this.gbTrabajador.TabStop = false;
            this.gbTrabajador.Text = "Trabajador";
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(20, 230);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(63, 13);
            this.lblFechaNacimiento.TabIndex = 16;
            this.lblFechaNacimiento.Text = "Fecha Nac.";
            // 
            // dtFechaNac
            // 
            this.dtFechaNac.Location = new System.Drawing.Point(94, 224);
            this.dtFechaNac.Name = "dtFechaNac";
            this.dtFechaNac.Size = new System.Drawing.Size(177, 20);
            this.dtFechaNac.TabIndex = 15;
            // 
            // lblTipoDocumento
            // 
            this.lblTipoDocumento.AutoSize = true;
            this.lblTipoDocumento.Location = new System.Drawing.Point(29, 127);
            this.lblTipoDocumento.Name = "lblTipoDocumento";
            this.lblTipoDocumento.Size = new System.Drawing.Size(54, 13);
            this.lblTipoDocumento.TabIndex = 14;
            this.lblTipoDocumento.Text = "Tipo Doc.";
            // 
            // cboTipoDoc
            // 
            this.cboTipoDoc.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cboTipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoDoc.FormattingEnabled = true;
            this.cboTipoDoc.Location = new System.Drawing.Point(94, 124);
            this.cboTipoDoc.Name = "cboTipoDoc";
            this.cboTipoDoc.Size = new System.Drawing.Size(177, 21);
            this.cboTipoDoc.TabIndex = 13;
            // 
            // chkVigente
            // 
            this.chkVigente.AutoSize = true;
            this.chkVigente.Location = new System.Drawing.Point(107, 372);
            this.chkVigente.Name = "chkVigente";
            this.chkVigente.Size = new System.Drawing.Size(62, 17);
            this.chkVigente.TabIndex = 12;
            this.chkVigente.Text = "Vigente";
            this.chkVigente.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(177, 416);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(43, 416);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 10;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(94, 326);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(177, 20);
            this.txtCorreo.TabIndex = 9;
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(94, 276);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(177, 20);
            this.txtCelular.TabIndex = 8;
            // 
            // txtNumeroDocumento
            // 
            this.txtNumeroDocumento.Location = new System.Drawing.Point(94, 174);
            this.txtNumeroDocumento.Name = "txtNumeroDocumento";
            this.txtNumeroDocumento.Size = new System.Drawing.Size(177, 20);
            this.txtNumeroDocumento.TabIndex = 7;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(94, 78);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(177, 20);
            this.txtApellidos.TabIndex = 6;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(94, 37);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(177, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Location = new System.Drawing.Point(37, 329);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(38, 13);
            this.lblCorreo.TabIndex = 4;
            this.lblCorreo.Text = "Correo";
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Location = new System.Drawing.Point(38, 279);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(39, 13);
            this.lblCelular.TabIndex = 3;
            this.lblCelular.Text = "Celular";
            // 
            // lblNumerodocumento
            // 
            this.lblNumerodocumento.AutoSize = true;
            this.lblNumerodocumento.Location = new System.Drawing.Point(3, 177);
            this.lblNumerodocumento.Name = "lblNumerodocumento";
            this.lblNumerodocumento.Size = new System.Drawing.Size(85, 13);
            this.lblNumerodocumento.TabIndex = 2;
            this.lblNumerodocumento.Text = "Nro. Documento";
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Location = new System.Drawing.Point(39, 81);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(49, 13);
            this.lblApellidos.TabIndex = 1;
            this.lblApellidos.Text = "Apellidos";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(39, 40);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // gbListado
            // 
            this.gbListado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbListado.Controls.Add(this.btnModificar);
            this.gbListado.Controls.Add(this.btnNuevo);
            this.gbListado.Controls.Add(this.dgvListado);
            this.gbListado.Location = new System.Drawing.Point(362, 19);
            this.gbListado.Name = "gbListado";
            this.gbListado.Size = new System.Drawing.Size(392, 413);
            this.gbListado.TabIndex = 1;
            this.gbListado.TabStop = false;
            this.gbListado.Text = "Listado";
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificar.Location = new System.Drawing.Point(302, 372);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevo.Location = new System.Drawing.Point(195, 372);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 1;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // dgvListado
            // 
            this.dgvListado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cdNombres,
            this.cdApellidos,
            this.cdTipoDoc,
            this.cdNrodoc,
            this.cdCelular,
            this.cdVigente});
            this.dgvListado.Location = new System.Drawing.Point(6, 19);
            this.dgvListado.Name = "dgvListado";
            this.dgvListado.Size = new System.Drawing.Size(380, 327);
            this.dgvListado.TabIndex = 0;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Location = new System.Drawing.Point(679, 452);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // cdNombres
            // 
            this.cdNombres.DataPropertyName = "Nombres";
            this.cdNombres.HeaderText = "Nombres";
            this.cdNombres.Name = "cdNombres";
            // 
            // cdApellidos
            // 
            this.cdApellidos.DataPropertyName = "Apellidos";
            this.cdApellidos.HeaderText = "Apellidos";
            this.cdApellidos.Name = "cdApellidos";
            // 
            // cdTipoDoc
            // 
            this.cdTipoDoc.DataPropertyName = "TipoDocumento";
            this.cdTipoDoc.HeaderText = "Tipo Doc.";
            this.cdTipoDoc.Name = "cdTipoDoc";
            // 
            // cdNrodoc
            // 
            this.cdNrodoc.DataPropertyName = "NumeroDocumento";
            this.cdNrodoc.HeaderText = "Nro. Doc.";
            this.cdNrodoc.Name = "cdNrodoc";
            // 
            // cdCelular
            // 
            this.cdCelular.DataPropertyName = "Celular";
            this.cdCelular.HeaderText = "Celular";
            this.cdCelular.Name = "cdCelular";
            // 
            // cdVigente
            // 
            this.cdVigente.DataPropertyName = "Vigente";
            this.cdVigente.HeaderText = "Vigente";
            this.cdVigente.Name = "cdVigente";
            // 
            // frmTrabajador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 487);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.gbListado);
            this.Controls.Add(this.gbTrabajador);
            this.Name = "frmTrabajador";
            this.Text = "Gestion Trabajador";
            this.gbTrabajador.ResumeLayout(false);
            this.gbTrabajador.PerformLayout();
            this.gbListado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbTrabajador;
        private System.Windows.Forms.GroupBox gbListado;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.TextBox txtNumeroDocumento;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.Label lblNumerodocumento;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.DataGridView dgvListado;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lblTipoDocumento;
        private System.Windows.Forms.ComboBox cboTipoDoc;
        private System.Windows.Forms.CheckBox chkVigente;
        private System.Windows.Forms.DateTimePicker dtFechaNac;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdNombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdApellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdTipoDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdNrodoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdCelular;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cdVigente;
    }
}