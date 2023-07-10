using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;
using System.Configuration;

namespace WinFormsFINAL
{
    public partial class frmAltaDiscos : Form
    {
        private Discos discos = null;
        private OpenFileDialog archivo = null;

        public frmAltaDiscos()
        {
            InitializeComponent();
        }
        public frmAltaDiscos(Discos discos)
        {
            InitializeComponent();
            this.discos = discos;
            Text = "MODIFICAR DISCO";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            
            DiscosNegocio negocio = new DiscosNegocio();

            try
            {
                if (discos == null)
                    discos = new Discos();
                discos.Titulo = txtTitDisco.Text;
                discos.FechaLanzamiento = dtpFechaLanzamiento.Text;
                discos.CantidadCanciones = int.Parse(txtCanCanciones.Text);
                discos.UrlImagen = txtUrlImagen.Text;
                discos.Estilo = (Estilo)cboEstilo.SelectedItem;
                discos.TipoEdicion = (TiposEdicion)cboTipoEdicion.SelectedItem;

                if (discos.Id != 0)
                {
                    negocio.modificar(discos);
                    MessageBox.Show("Modificado Exitosamente");
                }
                else
                {
                    negocio.agregar(discos);
                    MessageBox.Show("Agregado Exitosamente");
                }
                //Guardo imagen si la levanto localmente
                if (archivo != null && !(txtUrlImagen.Text.ToUpper().Contains("HTTP")))
                {
                    File.Copy(archivo.FileName, ConfigurationManager.AppSettings["imagen-folder"] + archivo.SafeFileName);
                }

                Close();
                
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.ToString());

            }
        }

        private void frmAltaDiscos_Load(object sender, EventArgs e)
        {
            EstiloNegocio estiloNegocio = new EstiloNegocio();
            TipoEdicionNegocio tipoEdicionNegocio = new TipoEdicionNegocio();
            try
            {
                cboEstilo.DataSource = estiloNegocio.listar();
                cboEstilo.ValueMember = "Id";
                cboEstilo.DisplayMember = "Descripcion";
                cboTipoEdicion.DataSource = tipoEdicionNegocio.listar();
                cboTipoEdicion.ValueMember = "Id";
                cboTipoEdicion.DisplayMember = "Description";

                if (discos != null )
                {
                    txtTitDisco.Text = discos.Titulo;
                    dtpFechaLanzamiento.Text = discos.FechaLanzamiento;
                    txtCanCanciones.Text = discos.CantidadCanciones.ToString();
                    txtUrlImagen.Text = discos.UrlImagen;
                    cargarImagen(discos.UrlImagen);
                    cboEstilo.SelectedValue = discos.Estilo.Id;
                    cboTipoEdicion.SelectedValue = discos.TipoEdicion.Id;

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtCanCanciones_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                e.Handled = true;
        }
        private void txtUrlImagen_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtUrlImagen.Text);
        }
        private void cargarImagen(string imagen)
        {
            try
            {
                prbDiscos.Load(imagen);
            }
            catch (Exception)
            {
                prbDiscos.Load("http://img2.wikia.nocookie.net/__cb20140518072131/towerofsaviors/images/4/47/Placeholder.png");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            archivo = new OpenFileDialog();
            archivo.Filter = "jpg|*.jpg;|png|*.png;|jpeg|*.jpeg";
            if(archivo.ShowDialog() == DialogResult.OK) 
            {
                txtUrlImagen.Text = archivo.FileName;
                cargarImagen(archivo.FileName);

                //guando la imagen
                //File.Copy(archivo.FileName, ConfigurationManager.AppSettings["imagen-folder"] + archivo.SafeFileName);
            }
        }
    }
}
