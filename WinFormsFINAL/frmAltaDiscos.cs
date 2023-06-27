using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace WinFormsFINAL
{
    public partial class frmAltaDiscos : Form
    {
        public frmAltaDiscos()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Discos dis = new Discos();
            DiscosNegocio negocio = new DiscosNegocio();
            try
            {
                dis.CantidadCanciones = int.Parse(txtCanCanciones.Text);
                dis.Titulo = txtTitDisco.Text;
                dis.Estilo = (Estilo)cboEstilo.SelectedItem;
                dis.TipoEdicion = (Estilo)cboTipoEdicion.SelectedItem;


                negocio.agregar(dis);
                MessageBox.Show("Agregado Exitosamente");
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
            try
            {
                cboEstilo.DataSource = estiloNegocio.listar();
                cboTipoEdicion.DataSource = estiloNegocio.listar();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
