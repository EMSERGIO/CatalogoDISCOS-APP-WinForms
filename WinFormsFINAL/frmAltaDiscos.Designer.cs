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
            this.SuspendLayout();
            // 
            // lblTituloDisco
            // 
            this.lblTituloDisco.AutoSize = true;
            this.lblTituloDisco.Location = new System.Drawing.Point(15, 59);
            this.lblTituloDisco.Name = "lblTituloDisco";
            this.lblTituloDisco.Size = new System.Drawing.Size(109, 13);
            this.lblTituloDisco.TabIndex = 0;
            this.lblTituloDisco.Text = "TITULO DEL DISCO:";
            // 
            // lblTotalCanciones
            // 
            this.lblTotalCanciones.AutoSize = true;
            this.lblTotalCanciones.Location = new System.Drawing.Point(15, 89);
            this.lblTotalCanciones.Name = "lblTotalCanciones";
            this.lblTotalCanciones.Size = new System.Drawing.Size(128, 13);
            this.lblTotalCanciones.TabIndex = 1;
            this.lblTotalCanciones.Text = "TOTAL DE CANCIONES:";
            // 
            // txtTitDisco
            // 
            this.txtTitDisco.Location = new System.Drawing.Point(141, 56);
            this.txtTitDisco.Name = "txtTitDisco";
            this.txtTitDisco.Size = new System.Drawing.Size(121, 20);
            this.txtTitDisco.TabIndex = 3;
            // 
            // txtCanCanciones
            // 
            this.txtCanCanciones.Location = new System.Drawing.Point(141, 82);
            this.txtCanCanciones.Name = "txtCanCanciones";
            this.txtCanCanciones.Size = new System.Drawing.Size(121, 20);
            this.txtCanCanciones.TabIndex = 4;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(53, 193);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "ACEPTAR";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(159, 193);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblEstilo
            // 
            this.lblEstilo.AutoSize = true;
            this.lblEstilo.Location = new System.Drawing.Point(15, 116);
            this.lblEstilo.Name = "lblEstilo";
            this.lblEstilo.Size = new System.Drawing.Size(45, 13);
            this.lblEstilo.TabIndex = 8;
            this.lblEstilo.Text = "ESTILO";
            // 
            // lblTipoEdicion
            // 
            this.lblTipoEdicion.AutoSize = true;
            this.lblTipoEdicion.Location = new System.Drawing.Point(15, 138);
            this.lblTipoEdicion.Name = "lblTipoEdicion";
            this.lblTipoEdicion.Size = new System.Drawing.Size(100, 13);
            this.lblTipoEdicion.TabIndex = 9;
            this.lblTipoEdicion.Text = "TIPO DE EDICION:";
            // 
            // cboEstilo
            // 
            this.cboEstilo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstilo.FormattingEnabled = true;
            this.cboEstilo.Location = new System.Drawing.Point(141, 108);
            this.cboEstilo.Name = "cboEstilo";
            this.cboEstilo.Size = new System.Drawing.Size(121, 21);
            this.cboEstilo.TabIndex = 10;
            // 
            // cboTipoEdicion
            // 
            this.cboTipoEdicion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoEdicion.FormattingEnabled = true;
            this.cboTipoEdicion.Location = new System.Drawing.Point(141, 135);
            this.cboTipoEdicion.Name = "cboTipoEdicion";
            this.cboTipoEdicion.Size = new System.Drawing.Size(121, 21);
            this.cboTipoEdicion.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "CARGANDO DISCOS";
            // 
            // frmAltaDiscos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 245);
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
            this.Text = "Nuevo Disco";
            this.Load += new System.EventHandler(this.frmAltaDiscos_Load);
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
    }
}