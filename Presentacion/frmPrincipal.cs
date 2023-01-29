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
using Dominio;
using Negocio;

namespace Presentacion
{
    public partial class frmPrincipal : Form
    {
        
        List<Producto> listaProducto;
        public frmPrincipal()
        {
            InitializeComponent();
        }
        private Producto seleccionado;

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        public extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        public extern static void SendMessage(System.IntPtr hWnd, int Msg, int wParam, int lParam);

        //EVENTOS
        private void pbSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void btnDetalle_Click(object sender, EventArgs e)
        {
                seleccionado = (Producto)dgvPlanilla.CurrentRow.DataBoundItem;
                frmDetalleProducto detalle = new frmDetalleProducto(seleccionado);
                detalle.ShowDialog();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmProducto agregar = new frmProducto();
            agregar.ShowDialog();
            cargarPlanilla();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            seleccionado = (Producto)dgvPlanilla.CurrentRow.DataBoundItem;
            frmProducto editar = new frmProducto(seleccionado);
            editar.ShowDialog();
            cargarPlanilla();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            cargarPlanilla();
            cargarComboBox();
            deshabilitarBoton();
        }

        private void dgvPlanilla_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPlanilla.CurrentRow != null)
            {
                Producto seleccionado = (Producto)dgvPlanilla.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.Imagen);
                deshabilitarBoton();
            }
        }

        private void txtFiltroRapido_TextChanged(object sender, EventArgs e)
        {
            List<Producto> listaFiltrada = new List<Producto>();
            string filtroRapido = txtFiltroRapido.Text;
            if (filtroRapido != null)
            {
                listaFiltrada = listaProducto.FindAll(x => x.Nombre.ToLower().Contains(filtroRapido.ToLower()) || x.Codigo.ToLower().Contains(filtroRapido.ToLower()));
            }
            else
            {
                listaFiltrada = listaProducto;
            }
            dgvPlanilla.DataSource = null;
            dgvPlanilla.DataSource = listaFiltrada;
            ocultarColumnas();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ProductoNegocio negocio = new ProductoNegocio();
            try
            {
                if (validarFiltro())
                {
                    return;
                }

                string campo = cboCampo.SelectedItem.ToString();
                string criterio = cboCriterio.SelectedItem.ToString();
                string filtro = txtFiltro.Text;
                dgvPlanilla.DataSource = negocio.Filtrar(campo, criterio, filtro);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cboCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cboCampo.SelectedItem.ToString();
            if (opcion == "Precio")
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Mayor a");
                cboCriterio.Items.Add("Menor a");
                cboCriterio.Items.Add("Igual a");
            }
            else
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Comienza con");
                cboCriterio.Items.Add("Termina con");
                cboCriterio.Items.Add("Contiene");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ProductoNegocio negocio = new ProductoNegocio();
            Producto seleccionado;

            try
            {
                DialogResult respuesta = MessageBox.Show("¿Desea eliminar el registro?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Producto)dgvPlanilla.CurrentRow.DataBoundItem;
                    negocio.eliminarFijo(seleccionado.Id);
                    cargarPlanilla();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //MÉTODOS
        private void cargarPlanilla()
        {
            ProductoNegocio lista = new ProductoNegocio();
            listaProducto = lista.Listar();
            dgvPlanilla.DataSource = listaProducto;
            ocultarColumnas();
        }
        private void cargarImagen(string imagen)
        {
            try
            {
                pbProductos.Load(imagen);
            }
            catch (Exception)
            {
                pbProductos.Load("https://bicentenario.gob.pe/biblioteca/themes/biblioteca/assets/images/not-available-es.png");
            }
        }
        private void ocultarColumnas()
        {
            dgvPlanilla.Columns["Id"].Visible = false;
            dgvPlanilla.Columns["Imagen"].Visible = false;
            dgvPlanilla.Columns["Preciodb"].Visible = false;
        }
        private bool validarFiltro()
        {
            if (cboCampo.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccione el campo!");
                cboCampo.Focus();
                return true;
            }
            if (cboCriterio.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccione el criterio!");
                cboCriterio.Focus();
                return true;
            }
            if (cboCampo.SelectedItem.ToString() == "Precio")
            {
                if (string.IsNullOrEmpty(txtFiltro.Text))
                {
                    MessageBox.Show("Debes cargar el filtro!");
                    txtFiltro.Focus();
                    return true;
                }
                if (!(soloNumero(txtFiltro.Text)))
                {
                    MessageBox.Show("Error solo ingresar números!");
                    txtFiltro.Focus();
                    return true;
                }
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
        private void cargarComboBox()
        {
            cboCampo.Items.Add("Marca");
            cboCampo.Items.Add("Categoria");
            cboCampo.Items.Add("Precio");
        }
        private void deshabilitarBoton()
        {
            if (dgvPlanilla.CurrentRow != null)
            {
                btnDetalle.Enabled = true;
                btnEditar.Enabled = true;
                btnEliminar.Enabled = true;
            }
            else
            {
                btnDetalle.Enabled = false;
                btnEditar.Enabled = false;
                btnEliminar.Enabled = false;
            }

        }

        //EVENTOS MOUSE ENTER Y LEAVE
        private void dgvPlanilla_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                dgvPlanilla.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightBlue;
            }
        }

        private void dgvPlanilla_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                dgvPlanilla.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
            }
        }

        private void btnDetalle_MouseEnter(object sender, EventArgs e)
        {
            stlEstado.Text = "Ver detalle del producto.";
        }

        private void btnDetalle_MouseLeave(object sender, EventArgs e)
        {
            stlEstado.Text = "Listo.";
        }

        private void btnAgregar_MouseEnter(object sender, EventArgs e)
        {
            stlEstado.Text = "Agregar nuevo producto.";
        }

        private void btnEditar_MouseEnter(object sender, EventArgs e)
        {
            stlEstado.Text = "Editar el producto seleccionado.";
        }

        private void btnEliminar_MouseEnter(object sender, EventArgs e)
        {
            stlEstado.Text = "Eliminar el registro seleccionado.";
        }

        private void btnBuscar_MouseEnter(object sender, EventArgs e)
        {
            stlEstado.Text = "Filtrar productos con los parámetro seleccionados.";
        }

        private void txtFiltroRapido_MouseEnter(object sender, EventArgs e)
        {
            stlEstado.Text = "Filtro rápido por nombre o código de producto.";
        }

        private void pbSalir_MouseEnter(object sender, EventArgs e)
        {
            stlEstado.Text = "Cerrar aplicaición.";
        }

        private void pbMinimizar_MouseEnter(object sender, EventArgs e)
        {
            stlEstado.Text = "Minimizar aplicación.";
        }

        private void pbProductos_MouseEnter(object sender, EventArgs e)
        {
            stlEstado.Text = "Imágen del producto.";
        }

        private void dgvPlanilla_MouseEnter(object sender, EventArgs e)
        {
            stlEstado.Text = "Planilla de productos.";
        }
    }
}
