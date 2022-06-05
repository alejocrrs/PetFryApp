using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Main;

namespace App
{
    public partial class FrmInicio : Form
    {
        private int _idUsuario;

        public int IdUsuario { get => _idUsuario; set => _idUsuario = value; }

        public FrmInicio(int idUsuario)
        {
            InitializeComponent();
            IdUsuario = idUsuario;
        }

        #region General
        private void FrmInicio_Load(object sender, EventArgs e)
        {
            ActualizarClientes();
            ActualizarMascotas();
            ActualizarProductos();
            ActualizarServicios();
            ActualizarOrdenes();
        }

        private void tabMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabMenu.SelectedTab.Text)
            {
                case "Clientes":
                    ActualizarClientes();
                    break;
                case "Mascotas":
                    ActualizarMascotas();
                    break;
                case "Productos":
                    ActualizarProductos();
                    break;
                case "Servicios":
                    ActualizarServicios();
                    break;
                case "Ordenes":
                    ActualizarOrdenes();
                    break;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"¿Realmente quieres cerrar sesión?", "Salir", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Hide();
                new FrmLogueo().ShowDialog();
                Close();
            }
        }
        #endregion

        #region Clientes
        public bool ValidarSeleccionCliente()
        {
            return dgvClientes.SelectedRows.Count > 0;
        }

        public void SeleccionCliente()
        {
            if (ValidarSeleccionCliente())
            {
                btnClientesEditar.Enabled = true;
                btnClientesEliminar.Enabled = true;
            }
            else
            {
                btnClientesEditar.Enabled = false;
                btnClientesEliminar.Enabled = false;
            }
        }

        public void ActualizarClientes()
        {
            dgvClientes.Rows.Clear();

            List<List<string>> listaClientes = Clientes.Buscar();

            if (listaClientes is null)
            {
                MessageBox.Show("Ha ocurrido un error al cargar la lista de clientes.", "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                foreach (List<string> cliente in listaClientes)
                {
                    dgvClientes.Rows.Add(cliente.ToArray());
                }
            }

            SeleccionCliente();
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SeleccionCliente();
        }

        private void btnClientesAgregar_Click(object sender, EventArgs e)
        {
            new FrmCliente(this).ShowDialog();
        }

        private void btnClientesEditar_Click(object sender, EventArgs e)
        {
            if (ValidarSeleccionCliente())
            {
                int idCliente = Convert.ToInt32(dgvClientes.SelectedRows[0].Cells[0].Value);
                new FrmCliente(this, idCliente).ShowDialog();
            }
        }

        private bool ValidarEliminarCliente(int idCliente)
        {
            return true; // TERMINAR VALIDACIÓN DE ELIMINAR CLIENTE
        }

        private void btnClientesEliminar_Click(object sender, EventArgs e)
        {
            if (ValidarSeleccionCliente())
            {
                int idCliente = Convert.ToInt32(dgvClientes.SelectedRows[0].Cells[0].Value);

                if (MessageBox.Show($"¿Quieres eliminar el cliente #{idCliente}?", "Eliminar cliente", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (ValidarEliminarCliente(idCliente))
                    {
                        Clientes.EliminarPorId(idCliente);
                        ActualizarClientes();
                    }
                }
            }
        }
        #endregion

        #region Mascotas
        public bool ValidarSeleccionMascota()
        {
            return dgvMascotas.SelectedRows.Count > 0;
        }

        public void SeleccionMascota()
        {
            if (ValidarSeleccionMascota())
            {
                btnMascotasEditar.Enabled = true;
                btnMascotasEliminar.Enabled = true;
            }
            else
            {
                btnMascotasEditar.Enabled = false;
                btnMascotasEliminar.Enabled = false;
            }
        }

        public void ActualizarMascotas()
        {
            dgvMascotas.Rows.Clear();

            List<List<string>> listaMascotas = Mascotas.Buscar();

            if (listaMascotas is null)
            {
                MessageBox.Show("Ha ocurrido un error al cargar la lista de mascotas.", "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                foreach (List<string> mascota in listaMascotas)
                {
                    dgvMascotas.Rows.Add(mascota.ToArray());
                }
            }

            SeleccionMascota();
        }

        private void dgvMascotas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SeleccionMascota();
        }

        private void btnMascotasAgregar_Click(object sender, EventArgs e)
        {
            new FrmMascota(this).ShowDialog();
        }

        private void btnMascotasEditar_Click(object sender, EventArgs e)
        {
            if (ValidarSeleccionMascota())
            {
                int idMascota = Convert.ToInt32(dgvMascotas.SelectedRows[0].Cells[0].Value);
                new FrmMascota(this, idMascota).ShowDialog();
            }
        }

        private bool ValidarEliminarMascota(int idMascota)
        {
            return true; // TERMINAR VALIDACIÓN DE ELIMINAR MASCOTA
        }

        private void btnMascotasEliminar_Click(object sender, EventArgs e)
        {
            if (ValidarSeleccionMascota())
            {
                int idMascota = Convert.ToInt32(dgvMascotas.SelectedRows[0].Cells[0].Value);

                if (MessageBox.Show($"¿Quieres eliminar la mascota #{idMascota}?", "Eliminar mascota", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (ValidarEliminarCliente(idMascota))
                    {
                        Mascotas.EliminarPorId(idMascota);
                        ActualizarMascotas();
                    }
                }
            }
        }
        #endregion

        #region Productos
        public bool ValidarSeleccionProducto()
        {
            return dgvProductos.SelectedRows.Count > 0;
        }

        public void SeleccionProducto()
        {
            if (ValidarSeleccionProducto())
            {
                btnProductosEditar.Enabled = true;
                btnProductosEliminar.Enabled = true;
            }
            else
            {
                btnProductosEditar.Enabled = false;
                btnProductosEliminar.Enabled = false;
            }
        }

        public void ActualizarProductos()
        {
            dgvProductos.Rows.Clear();

            List<List<string>> listaProductos = Productos.Buscar();

            if (listaProductos is null)
            {
                MessageBox.Show("Ha ocurrido un error al cargar la lista de productos.", "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                foreach (List<string> producto in listaProductos)
                {
                    dgvProductos.Rows.Add(producto.ToArray());
                }
            }

            SeleccionProducto();
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SeleccionProducto();
        }

        private void btnProductosAgregar_Click(object sender, EventArgs e)
        {
            new FrmProducto(this).ShowDialog();
        }

        private void btnProductosEditar_Click(object sender, EventArgs e)
        {
            if (ValidarSeleccionProducto())
            {
                int idProducto = Convert.ToInt32(dgvProductos.SelectedRows[0].Cells[0].Value);
                new FrmProducto(this, idProducto).ShowDialog();
            }
        }

        private bool ValidarEliminarProducto(int idProducto)
        {
            return true; // TERMINAR VALIDACIÓN DE ELIMINAR PRODUCTO
        }

        private void btnProductoEliminar_Click(object sender, EventArgs e)
        {
            if (ValidarSeleccionProducto())
            {
                int idProducto = Convert.ToInt32(dgvProductos.SelectedRows[0].Cells[0].Value);

                if (MessageBox.Show($"¿Quieres eliminar el producto #{idProducto}?", "Eliminar producto", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (ValidarEliminarProducto(idProducto))
                    {
                        Productos.EliminarPorId(idProducto);
                        ActualizarProductos();
                    }
                }
            }
        }
        #endregion

        #region Servicios
        public bool ValidarSeleccionServicio()
        {
            return dgvServicios.SelectedRows.Count > 0;
        }

        public void SeleccionServicio()
        {
            if (ValidarSeleccionServicio())
            {
                btnServiciosEditar.Enabled = true;
                btnServiciosEliminar.Enabled = true;
            }
            else
            {
                btnServiciosEditar.Enabled = false;
                btnServiciosEliminar.Enabled = false;
            }
        }

        public void ActualizarServicios()
        {
            dgvServicios.Rows.Clear();

            List<List<string>> listaServicios = Servicios.Buscar();

            if (listaServicios is null)
            {
                MessageBox.Show("Ha ocurrido un error al cargar la lista de servicios.", "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                foreach (List<string> servicio in listaServicios)
                {
                    dgvServicios.Rows.Add(servicio.ToArray());
                }
            }

            SeleccionServicio();
        }

        private void dgvServicios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SeleccionServicio();
        }

        private void btnServiciosAgregar_Click(object sender, EventArgs e)
        {
            new FrmServicio(this).ShowDialog();
        }

        private void btnServiciosEditar_Click(object sender, EventArgs e)
        {
            if (ValidarSeleccionServicio())
            {
                int idServicio = Convert.ToInt32(dgvServicios.SelectedRows[0].Cells[0].Value);
                new FrmServicio(this, idServicio).ShowDialog();
            }
        }

        private bool ValidarEliminarServicio(int idServicio)
        {
            return true; // TERMINAR VALIDACIÓN DE ELIMINAR SERVICIO
        }

        private void btnServiciosEliminar_Click(object sender, EventArgs e)
        {
            if (ValidarSeleccionServicio())
            {
                int idServicio = Convert.ToInt32(dgvServicios.SelectedRows[0].Cells[0].Value);

                if (MessageBox.Show($"¿Quieres eliminar el servicio #{idServicio}?", "Eliminar servicio", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (ValidarEliminarServicio(idServicio))
                    {
                        Servicios.EliminarPorId(idServicio);
                        ActualizarServicios();
                    }
                }
            }
        }
        #endregion

        #region Ordenes
        public bool ValidarSeleccionOrden()
        {
            return dgvOrdenes.SelectedRows.Count > 0;
        }

        public void SeleccionOrden()
        {
            if (ValidarSeleccionOrden())
            {
                btnOrdenesEditar.Enabled = true;
                btnOrdenesEliminar.Enabled = true;
            }
            else
            {
                btnOrdenesEditar.Enabled = false;
                btnOrdenesEliminar.Enabled = false;
            }
        }

        public void ActualizarOrdenes()
        {
            dgvOrdenes.Rows.Clear();

            List<List<string>> listaOrdenes = Ordenes.Buscar();

            if (listaOrdenes is null)
            {
                MessageBox.Show("Ha ocurrido un error al cargar la lista de órdenes.", "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                foreach (List<string> orden in listaOrdenes)
                {
                    dgvOrdenes.Rows.Add(orden.ToArray());
                }
            }

            SeleccionOrden();
        }

        private void dgvOrdenes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SeleccionOrden();
        }

        private void btnOrdenesAgregar_Click(object sender, EventArgs e)
        {
            new FrmOrden(this).ShowDialog();
        }

        private void btnOrdenesEditar_Click(object sender, EventArgs e)
        {
            if (ValidarSeleccionOrden())
            {
                int idOrden = Convert.ToInt32(dgvOrdenes.SelectedRows[0].Cells[0].Value);
                new FrmOrden(this, idOrden).ShowDialog();
            }
        }

        private void btnOrdenesEliminar_Click(object sender, EventArgs e)
        {
            if (ValidarSeleccionOrden())
            {
                int idOrden = Convert.ToInt32(dgvOrdenes.SelectedRows[0].Cells[0].Value);

                if (MessageBox.Show($"¿Quieres eliminar la orden #{idOrden}?", "Eliminar orden", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Ordenes.EliminarPorId(idOrden);
                    ActualizarOrdenes();
                }
            }
        }
        #endregion
    }
}
