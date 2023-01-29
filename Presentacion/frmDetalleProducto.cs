using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class frmDetalleProducto : Form
    {
        private Producto producto = null;
        public frmDetalleProducto()
        {
            InitializeComponent();
        }
        public frmDetalleProducto(Producto seleccionado)
        {
            InitializeComponent();
            this.producto = seleccionado;
        }

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        public extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        public extern static void SendMessage(System.IntPtr hWnd, int Msg, int wParam, int lParam);


        private void pbSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pbMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pnlSup_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void frmDetalleProducto_Load(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            try
            {
                cboCategoria.DataSource = categoriaNegocio.Listar();
                cboCategoria.ValueMember = "Id";
                cboCategoria.DisplayMember = "Descripcion";
                cboMarca.DataSource = marcaNegocio.Listar();
                cboMarca.ValueMember = "Id";
                cboMarca.DisplayMember = "Descripcion";

                string imagen = producto.Imagen;
                txtCod.Text = producto.Codigo.ToString();
                txtNombre.Text = producto.Nombre;
                txtDesc.Text = producto.Detalle;
                txtPrecio.Text = producto.Precio.ToString();
                cargarImagen(imagen);
                cboCategoria.SelectedValue = producto.Categoria.Id;
                cboMarca.SelectedValue = producto.Marca.Id;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //MÉTODOS
        private void cargarImagen(string imagen)
        {
            try
            {
                pbImagen.Load(imagen);
            }
            catch (Exception)
            {
                pbImagen.Load("https://bicentenario.gob.pe/biblioteca/themes/biblioteca/assets/images/not-available-es.png");
            }
        }

        //EVENTOS MOUSE ENTER Y LEAVE
        private void pbMinimizar_MouseLeave(object sender, EventArgs e)
        {
            belblListo.Text = "Listo.";
        }

        private void pbMinimizar_MouseEnter(object sender, EventArgs e)
        {
            belblListo.Text = "Minimizar aplicación.";
        }

        private void pbSalir_MouseEnter(object sender, EventArgs e)
        {
            belblListo.Text = "Cerrar ventana.";
        }

        private void txtCod_MouseEnter(object sender, EventArgs e)
        {
            belblListo.Text = "Código del producto.";
        }

        private void txtNombre_MouseEnter(object sender, EventArgs e)
        {
            belblListo.Text = "Nombre del producto.";
        }

        private void txtDesc_MouseEnter(object sender, EventArgs e)
        {
            belblListo.Text = "Descripción del producto.";
        }

        private void cboCategoria_MouseEnter(object sender, EventArgs e)
        {
            belblListo.Text = "Categoría del producto.";
        }

        private void cboMarca_MouseEnter(object sender, EventArgs e)
        {
            belblListo.Text = "Marca del producto.";
        }

        private void txtPrecio_MouseEnter(object sender, EventArgs e)
        {
            belblListo.Text = "Precio del prodcuto.";
        }

        private void btnCerrar_MouseEnter(object sender, EventArgs e)
        {
            belblListo.Text = "Cerrar ventana.";
        }

        private void pbImagen_MouseEnter(object sender, EventArgs e)
        {
            belblListo.Text = "Imágen del producto.";
        }
    }
}
