using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class frmProducto : Form
    {
        private Producto producto = null;
        private OpenFileDialog archivo = null;
        public frmProducto()
        {
            InitializeComponent();
        }
        public frmProducto(Producto producto)
        {
            InitializeComponent();
            this.producto = producto;
            lblTitulo.Text = "MODIFICAR PRODUCTO";
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

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ProductoNegocio negocio = new ProductoNegocio();
            try
            {
                if (validarDatos())
                {
                    return;
                }
                if (producto == null)
                {
                    producto = new Producto();
                }

                producto.Codigo = txtCod.Text;
                producto.Nombre = txtNombre.Text;
                producto.Detalle = txtDesc.Text;
                producto.Imagen = txtImg.Text;
                producto.Precio = Convert.ToDouble(txtPrecio.Text);
                producto.Categoria = (Categoria)cboCategoria.SelectedItem;
                producto.Marca = (Marca)cboMarca.SelectedItem;

                if (producto.Id != 0)
                {
                    negocio.modificar(producto);
                    MessageBox.Show("Producto Modificado!");
                }
                else
                {
                    negocio.agregar(producto);
                    MessageBox.Show("Producto agregado!");
                }

                guardarImagen(archivo);
                Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void frmProducto_Load(object sender, EventArgs e)
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

                if (producto != null)
                {
                    txtCod.Text = producto.Codigo.ToString();
                    txtNombre.Text = producto.Nombre;
                    txtDesc.Text = producto.Detalle;
                    txtImg.Text = producto.Imagen;
                    txtPrecio.Text = producto.Precio.ToString();
                    cargarImagen(producto.Imagen);
                    cboCategoria.SelectedValue = producto.Categoria.Id;
                    cboMarca.SelectedValue = producto.Marca.Id;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void txtImg_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtImg.Text);
        }
        private void btnSubirImg_Click(object sender, EventArgs e)
        {
            archivo = new OpenFileDialog();
            archivo.Filter = "jpg|*.jpg;|png|*.png";
            if (archivo.ShowDialog() == DialogResult.OK)
            {
                txtImg.Text = archivo.FileName;
                cargarImagen(archivo.FileName);
            }
        }

        //MÉTODOS
        private bool validarDatos()
        {
            if (txtCod.Text == "")
            {
                MessageBox.Show("Completar el campo Código!");
                txtCod.Focus();
                return true;
            }
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Completar el campo Nombre!");
                txtNombre.Focus();
                return true;
            }
            if (txtPrecio.Text == "")
            {
                MessageBox.Show("Completar el campo Precio!");
                txtPrecio.Focus();
                return true;
            }
            if (soloNumero(txtPrecio.Text))
            {
                MessageBox.Show("Ingresar solo números en el campo Precio!");
                txtPrecio.Focus();
                return true;
            }
            if (cboCategoria.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccione una Categoría!");
                cboCategoria.Focus();
                return true;
            }
            if (cboMarca.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccione una Marca!");
                cboMarca.Focus();
                return true;
            }
            return false;
        }
        private bool soloNumero(string cadena)
        {
            foreach (char n in cadena)
            {
                if (!(char.IsNumber(n)))
                {
                    return false;
                }
            }
            return true;
        }
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
        private void guardarImagen(OpenFileDialog archivo)
        {
            if (archivo != null && !(txtImg.Text.ToUpper().Contains("HTTP")))
            {
                File.Copy(archivo.FileName, ConfigurationManager.AppSettings["Imagenes"] + archivo.SafeFileName);
            }
        }

        //EVENTOS MOUSE ENTER Y LEAVE
        private void pbMinimizar_MouseEnter(object sender, EventArgs e)
        {
            lblBarraEstado.Text = "Minimizar aplicación.";
        }

        private void pbMinimizar_MouseLeave(object sender, EventArgs e)
        {
            lblBarraEstado.Text = "Listo.";
        }

        private void pbSalir_MouseEnter(object sender, EventArgs e)
        {
            lblBarraEstado.Text = "Cerrar aplicación.";
        }

        private void btnAceptar_MouseEnter(object sender, EventArgs e)
        {
            lblBarraEstado.Text = "Aceptar los datos ingresados.";
        }

        private void btnCancelar_MouseEnter(object sender, EventArgs e)
        {
            lblBarraEstado.Text = "Cancelar registro y salir.";
        }

        private void pbImagen_MouseEnter(object sender, EventArgs e)
        {
            lblBarraEstado.Text = "Imágen del producto.";
        }

        private void txtCod_MouseEnter(object sender, EventArgs e)
        {
            lblBarraEstado.Text = "Código del producto.";
        }

        private void btnSubirImg_MouseEnter(object sender, EventArgs e)
        {
            lblBarraEstado.Text = "Cargar una imágen.";
        }

        private void txtNombre_MouseEnter(object sender, EventArgs e)
        {
            lblBarraEstado.Text = "Ingresar nombre del producto.";
        }

        private void txtDesc_MouseEnter(object sender, EventArgs e)
        {
            lblBarraEstado.Text = "Ingresar descripción del producto.";
        }

        private void txtImg_MouseEnter(object sender, EventArgs e)
        {
            lblBarraEstado.Text = "Ingresar Url de la imágen del producto.";
        }

        private void txtPrecio_MouseEnter(object sender, EventArgs e)
        {
            lblBarraEstado.Text = "Ingresar precio del prodcuto, agregar la coma y centavos.";
        }

        private void cboCategoria_MouseEnter(object sender, EventArgs e)
        {
            lblBarraEstado.Text = "Seleccionar la categoría del producto.";
        }

        private void cboMarca_MouseEnter(object sender, EventArgs e)
        {
            lblBarraEstado.Text = "Seleccionar la marca del producto.";
        }
    }
}
