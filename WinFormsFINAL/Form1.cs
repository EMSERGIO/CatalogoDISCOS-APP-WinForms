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
    public partial class frmDiscos : Form
    {
        private List<Discos> listaDiscos;
        public frmDiscos()
        {
            InitializeComponent();
        }

        private void fmrDiscos_Load(object sender, EventArgs e)
        {
            DiscosNegocio negocio = new DiscosNegocio();
            try
            {
                listaDiscos = negocio.listar();
                dgvDiscos.DataSource = listaDiscos;
                dgvDiscos.Columns["UrlImagen"].Visible = false;
                cargarImagen(listaDiscos[0].UrlImagen);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void dgvDiscos_SelectionChanged(object sender, EventArgs e)
        {
            Discos seleccionado = (Discos)dgvDiscos.CurrentRow.DataBoundItem;
            cargarImagen(seleccionado.UrlImagen);
        }
        private void cargarImagen(string imagen) 
        {
            try
            {
                pxbDiscos.Load(imagen);
            }
            catch (Exception) 
            {
                pxbDiscos.Load("http://img2.wikia.nocookie.net/__cb20140518072131/towerofsaviors/images/4/47/Placeholder.png");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaDiscos alta = new frmAltaDiscos();
            alta.ShowDialog();
        }
    }
}
