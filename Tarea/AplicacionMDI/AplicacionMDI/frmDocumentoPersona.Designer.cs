namespace AplicacionMDI
{
    partial class frmDocumentoPersona
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
            this.gbDocumento = new System.Windows.Forms.GroupBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblSiglas = new System.Windows.Forms.Label();
            this.lblValores = new System.Windows.Forms.Label();
            this.chkVigente = new System.Windows.Forms.CheckBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtSiglas = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gbListado = new System.Windows.Forms.GroupBox();
            this.dgvListado = new System.Windows.Forms.DataGridView();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.nudValores = new System.Windows.Forms.NumericUpDown();
            this.cdNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdSiglas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdValores = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdVigente = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.gbDocumento.SuspendLayout();
            this.gbListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudValores)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDocumento
            // 
            this.gbDocumento.Controls.Add(this.nudValores);
            this.gbDocumento.Controls.Add(this.btnCancelar);
            this.gbDocumento.Controls.Add(this.btnAceptar);
            this.gbDocumento.Controls.Add(this.txtSiglas);
            this.gbDocumento.Controls.Add(this.txtNombre);
            this.gbDocumento.Controls.Add(this.chkVigente);
            this.gbDocumento.Controls.Add(this.lblValores);
            this.gbDocumento.Controls.Add(this.lblSiglas);
            this.gbDocumento.Controls.Add(this.lblNombre);
            this.gbDocumento.Enabled = false;
            this.gbDocumento.Location = new System.Drawing.Point(16, 16);
            this.gbDocumento.Name = "gbDocumento";
            this.gbDocumento.Size = new System.Drawing.Size(336, 294);
            this.gbDocumento.TabIndex = 0;
            this.gbDocumento.TabStop = false;
            this.gbDocumento.Text = "Documento de Persona";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(31, 51);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // lblSiglas
            // 
            this.lblSiglas.AutoSize = true;
            this.lblSiglas.Location = new System.Drawing.Point(31, 101);
            this.lblSiglas.Name = "lblSiglas";
            this.lblSiglas.Size = new System.Drawing.Size(35, 13);
            this.lblSiglas.TabIndex = 1;
            this.lblSiglas.Text = "Siglas";
            // 
            // lblValores
            // 
            this.lblValores.AutoSize = true;
            this.lblValores.Location = new System.Drawing.Point(31, 159);
            this.lblValores.Name = "lblValores";
            this.lblValores.Size = new System.Drawing.Size(42, 13);
            this.lblValores.TabIndex = 2;
            this.lblValores.Text = "Valores";
            // 
            // chkVigente
            // 
            this.chkVigente.AutoSize = true;
            this.chkVigente.Location = new System.Drawing.Point(111, 214);
            this.chkVigente.Name = "chkVigente";
            this.chkVigente.Size = new System.Drawing.Size(62, 17);
            this.chkVigente.TabIndex = 3;
            this.chkVigente.Text = "Vigente";
            this.chkVigente.UseVisualStyleBackColor = true;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(86, 48);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(188, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // txtSiglas
            // 
            this.txtSiglas.Location = new System.Drawing.Point(86, 98);
            this.txtSiglas.Name = "txtSiglas";
            this.txtSiglas.Size = new System.Drawing.Size(188, 20);
            this.txtSiglas.TabIndex = 5;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(54, 252);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 7;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(180, 252);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // gbListado
            // 
            this.gbListado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbListado.Controls.Add(this.btnModificar);
            this.gbListado.Controls.Add(this.btnNuevo);
            this.gbListado.Controls.Add(this.dgvListado);
            this.gbListado.Location = new System.Drawing.Point(368, 23);
            this.gbListado.Name = "gbListado";
            this.gbListado.Size = new System.Drawing.Size(347, 286);
            this.gbListado.TabIndex = 1;
            this.gbListado.TabStop = false;
            this.gbListado.Text = "Listado";
            // 
            // dgvListado
            // 
            this.dgvListado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cdNombre,
            this.cdSiglas,
            this.cdValores,
            this.cdVigente});
            this.dgvListado.Location = new System.Drawing.Point(6, 19);
            this.dgvListado.Name = "dgvListado";
            this.dgvListado.Size = new System.Drawing.Size(335, 205);
            this.dgvListado.TabIndex = 0;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevo.Location = new System.Drawing.Point(154, 245);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 1;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificar.Location = new System.Drawing.Point(253, 245);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Location = new System.Drawing.Point(634, 329);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // nudValores
            // 
            this.nudValores.Location = new System.Drawing.Point(86, 159);
            this.nudValores.Name = "nudValores";
            this.nudValores.Size = new System.Drawing.Size(120, 20);
            this.nudValores.TabIndex = 9;
            // 
            // cdNombre
            // 
            this.cdNombre.DataPropertyName = "Nombre";
            this.cdNombre.HeaderText = "Nombre";
            this.cdNombre.Name = "cdNombre";
            // 
            // cdSiglas
            // 
            this.cdSiglas.DataPropertyName = "Siglas";
            this.cdSiglas.HeaderText = "Siglas";
            this.cdSiglas.Name = "cdSiglas";
            // 
            // cdValores
            // 
            this.cdValores.DataPropertyName = "Valores";
            this.cdValores.HeaderText = "Valores";
            this.cdValores.Name = "cdValores";
            // 
            // cdVigente
            // 
            this.cdVigente.DataPropertyName = "Vigente";
            this.cdVigente.HeaderText = "Vigente";
            this.cdVigente.Name = "cdVigente";
            // 
            // frmDocumentoPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 364);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.gbListado);
            this.Controls.Add(this.gbDocumento);
            this.Name = "frmDocumentoPersona";
            this.Text = "Gestion Documento de Persona";
            this.gbDocumento.ResumeLayout(false);
            this.gbDocumento.PerformLayout();
            this.gbListado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudValores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDocumento;
        private System.Windows.Forms.TextBox txtSiglas;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.CheckBox chkVigente;
        private System.Windows.Forms.Label lblValores;
        private System.Windows.Forms.Label lblSiglas;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.GroupBox gbListado;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.DataGridView dgvListado;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.NumericUpDown nudValores;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdSiglas;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdValores;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cdVigente;
    }
}