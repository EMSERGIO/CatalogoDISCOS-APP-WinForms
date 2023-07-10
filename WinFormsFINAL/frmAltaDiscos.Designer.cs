namespace WinFormsFINAL
{
    partial class frmAltaDiscos
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
            this.lblTituloDisco = new System.Windows.Forms.Label();
            this.lblTotalCanciones = new System.Windows.Forms.Label();
            this.txtTitDisco = new System.Windows.Forms.TextBox();
            this.txtCanCanciones = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblEstilo = new System.Windows.Forms.Label();
            this.lblTipoEdicion = new System.Windows.Forms.Label();
            this.cboEstilo = new System.Windows.Forms.ComboBox();
            this.cboTipoEdicion = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFechaLanzamiento = new System.Windows.Forms.DateTimePicker();
            this.lblFechaLanzamiento = new System.Windows.Forms.Label();
            this.lblUrlImagen = new System.Windows.Forms.Label();
            this.txtUrlImagen = new System.Windows.Forms.TextBox();
            this.prbDiscos = new System.Windows.Forms.PictureBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.prbDiscos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloDisco
            // 
            this.lblTituloDisco.AutoSize = true;
            this.lblTituloDisco.Location = new System.Drawing.Point(34, 48);
            this.lblTituloDisco.Name = "lblTituloDisco";
            this.lblTituloDisco.Size = new System.Drawing.Size(109, 13);
            this.lblTituloDisco.TabIndex = 0;
            this.lblTituloDisco.Text = "TITULO DEL DISCO:";
            // 
            // lblTotalCanciones
            // 
            this.lblTotalCanciones.AutoSize = true;
            this.lblTotalCanciones.Location = new System.Drawing.Point(15, 106);
            this.lblTotalCanciones.Name = "lblTotalCanciones";
            this.lblTotalCanciones.Size = new System.Drawing.Size(128, 13);
            this.lblTotalCanciones.TabIndex = 1;
            this.lblTotalCanciones.Text = "TOTAL DE CANCIONES:";
            // 
            // txtTitDisco
            // 
            this.txtTitDisco.Location = new System.Drawing.Point(149, 41);
            this.txtTitDisco.Name = "txtTitDisco";
            this.txtTitDisco.Size = new System.Drawing.Size(167, 20);
            this.txtTitDisco.TabIndex = 0;
            // 
            // txtCanCanciones
            // 
            this.txtCanCanciones.Location = new System.Drawing.Point(149, 99);
            this.txtCanCanciones.Name = "txtCanCanciones";
            this.txtCanCanciones.Size = new System.Drawing.Size(167, 20);
            this.txtCanCanciones.TabIndex = 2;
            this.txtCanCanciones.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCanCanciones_KeyPress);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(74, 261);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(99, 44);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "ACEPTAR";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(180, 261);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(99, 44);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblEstilo
            // 
            this.lblEstilo.AutoSize = true;
            this.lblEstilo.Location = new System.Drawing.Point(95, 192);
            this.lblEstilo.Name = "lblEstilo";
            this.lblEstilo.Size = new System.Drawing.Size(48, 13);
            this.lblEstilo.TabIndex = 8;
            this.lblEstilo.Text = "ESTILO:";
            // 
            // lblTipoEdicion
            // 
            this.lblTipoEdicion.AutoSize = true;
            this.lblTipoEdicion.Location = new System.Drawing.Point(43, 224);
            this.lblTipoEdicion.Name = "lblTipoEdicion";
            this.lblTipoEdicion.Size = new System.Drawing.Size(100, 13);
            this.lblTipoEdicion.TabIndex = 9;
            this.lblTipoEdicion.Text = "TIPO DE EDICION:";
            // 
            // cboEstilo
            // 
            this.cboEstilo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstilo.FormattingEnabled = true;
            this.cboEstilo.Location = new System.Drawing.Point(149, 184);
            this.cboEstilo.Name = "cboEstilo";
            this.cboEstilo.Size = new System.Drawing.Size(167, 21);
            this.cboEstilo.TabIndex = 4;
            // 
            // cboTipoEdicion
            // 
            this.cboTipoEdicion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoEdicion.FormattingEnabled = true;
            this.cboTipoEdicion.Location = new System.Drawing.Point(149, 216);
            this.cboTipoEdicion.Name = "cboTipoEdicion";
            this.cboTipoEdicion.Size = new System.Drawing.Size(167, 21);
            this.cboTipoEdicion.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "CARGANDO DISCOS";
            // 
            // dtpFechaLanzamiento
            // 
            this.dtpFechaLanzamiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaLanzamiento.Location = new System.Drawing.Point(149, 71);
            this.dtpFechaLanzamiento.Name = "dtpFechaLanzamiento";
            this.dtpFechaLanzamiento.Size = new System.Drawing.Size(167, 20);
            this.dtpFechaLanzamiento.TabIndex = 1;
            // 
            // lblFechaLanzamiento
            // 
            this.lblFechaLanzamiento.AutoSize = true;
            this.lblFechaLanzamiento.Location = new System.Drawing.Point(0, 78);
            this.lblFechaLanzamiento.Name = "lblFechaLanzamiento";
            this.lblFechaLanzamiento.Size = new System.Drawing.Size(143, 13);
            this.lblFechaLanzamiento.TabIndex = 14;
            this.lblFechaLanzamiento.Text = "FECHA DE LANZAMIENTO:";
            // 
            // lblUrlImagen
            // 
            this.lblUrlImagen.AutoSize = true;
            this.lblUrlImagen.Location = new System.Drawing.Point(66, 135);
            this.lblUrlImagen.Name = "lblUrlImagen";
            this.lblUrlImagen.Size = new System.Drawing.Size(77, 13);
            this.lblUrlImagen.TabIndex = 15;
            this.lblUrlImagen.Text = "URL IMAGEN:";
            // 
            // txtUrlImagen
            // 
            this.txtUrlImagen.Location = new System.Drawing.Point(149, 128);
            this.txtUrlImagen.Name = "txtUrlImagen";
            this.txtUrlImagen.Size = new System.Drawing.Size(167, 20);
            this.txtUrlImagen.TabIndex = 3;
            this.txtUrlImagen.Leave += new System.EventHandler(this.txtUrlImagen_Leave);
            // 
            // prbDiscos
            // 
            this.prbDiscos.Location = new System.Drawing.Point(327, 12);
            this.prbDiscos.Name = "prbDiscos";
            this.prbDiscos.Size = new System.Drawing.Size(348, 293);
            this.prbDiscos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.prbDiscos.TabIndex = 17;
            this.prbDiscos.TabStop = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(149, 155);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(167, 21);
            this.btnAgregar.TabIndex = 18;
            this.btnAgregar.Text = "AGREGAR IMAGEN";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // frmAltaDiscos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 310);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.prbDiscos);
            this.Controls.Add(this.txtUrlImagen);
            this.Controls.Add(this.lblUrlImagen);
            this.Controls.Add(this.lblFechaLanzamiento);
            this.Controls.Add(this.dtpFechaLanzamiento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboTipoEdicion);
            this.Controls.Add(this.cboEstilo);
            this.Controls.Add(this.lblTipoEdicion);
            this.Controls.Add(this.lblEstilo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtCanCanciones);
            this.Controls.Add(this.txtTitDisco);
            this.Controls.Add(this.lblTotalCanciones);
            this.Controls.Add(this.lblTituloDisco);
            this.Name = "frmAltaDiscos";
            this.Text = "NUEVO DISCO";
            this.Load += new System.EventHandler(this.frmAltaDiscos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.prbDiscos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloDisco;
        private System.Windows.Forms.Label lblTotalCanciones;
        private System.Windows.Forms.TextBox txtTitDisco;
        private System.Windows.Forms.TextBox txtCanCanciones;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblEstilo;
        private System.Windows.Forms.Label lblTipoEdicion;
        private System.Windows.Forms.ComboBox cboEstilo;
        private System.Windows.Forms.ComboBox cboTipoEdicion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFechaLanzamiento;
        private System.Windows.Forms.Label lblFechaLanzamiento;
        private System.Windows.Forms.Label lblUrlImagen;
        private System.Windows.Forms.TextBox txtUrlImagen;
        private System.Windows.Forms.PictureBox prbDiscos;
        private System.Windows.Forms.Button btnAgregar;
    }
}