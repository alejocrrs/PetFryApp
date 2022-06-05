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
    public partial class FrmOrden : Form
    {
        private FrmInicio _formInicio;
        private int _idOrden;
        private bool _primeraVez;

        public FrmInicio FormInicio { get => _formInicio; set => _formInicio = value; }
        public int IdOrden { get => _idOrden; set => _idOrden = value; }

        public bool PrimeraVez { get => _primeraVez; set => _primeraVez = value; }

        public FrmOrden(FrmInicio formInicio)
        {
            FormInicio = formInicio;
            IdOrden = -1;
            PrimeraVez = true;
            InitializeComponent();
        }

        public FrmOrden(FrmInicio formInicio, int idOrden)
        {
            FormInicio = formInicio;
            IdOrden = idOrden;
            PrimeraVez = true;
            InitializeComponent();

            List<string> orden = Ordenes.BuscarPorId(IdOrden);
            Text = $"Editar orden #{IdOrden}";
            txtCliente.Text = orden[1];
            txtMascota.Text = orden[2];
            cboTipo.Text = orden[3];
            txtArticulo.Text = orden[4];
            numValor.Value = Convert.ToDecimal(orden[5]);
            txtNotas.Text = orden[7];
            btnAgregar.Text = "Editar";
        }

        public string ObtenerCliente()
        {
            return txtCliente.Text;
        }

        public void SeleccionarCliente(string idCliente)
        {
            txtCliente.Text = idCliente;
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            new FrmOrdenCliente(this).ShowDialog();
        }

        public string ObtenerMascota()
        {
            return txtMascota.Text;
        }

        public void SeleccionarMascota(string idMascota)
        {
            txtMascota.Text = idMascota;
        }

        public void DeseleccionarMascota()
        {
            txtMascota.Clear();
        }

        private void btnMascota_Click(object sender, EventArgs e)
        {
            new FrmOrdenMascota(this).ShowDialog();
        }

        private void cboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboTipo.SelectedItem.ToString())
            {
                case "Productos":
                    lblArticulo.Text = "Producto";
                    break;
                case "Servicios":
                    lblArticulo.Text = "Servicio";
                    break;
            }

            if (PrimeraVez)
            {
                PrimeraVez = false;
            }
            else
            {
                DeseleccionarArticulo();
            }
        }

        public string ObtenerArticulo()
        {
            return txtArticulo.Text;
        }

        public string ObtenerTipo()
        {
            return cboTipo.SelectedItem.ToString();
        }

        public void SeleccionarArticulo(string idArticulo, decimal valor)
        {
            txtArticulo.Text = idArticulo;
            ActualizarValor(valor);
        }

        public void DeseleccionarArticulo()
        {
            txtArticulo.Clear();
            ActualizarValor(0);
        }

        private void ActualizarValor(decimal valor)
        {
            numValor.Value = valor;
        }

        private void btnArticulo_Click(object sender, EventArgs e)
        {
            if (cboTipo.SelectedItem is null)
            {
                MessageBox.Show("Por favor, selecciona un tipo de orden.", "Dato requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                new FrmOrdenArticulo(this).ShowDialog();
            }
        }

        private bool VerificarCliente()
        {
            btnCliente.Focus();

            if (txtCliente.Text.Length == 0)
            {
                MessageBox.Show("Por favor, selecciona un cliente.", "Dato requerido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if (Clientes.BuscarPorId(Convert.ToInt32(txtCliente.Text)).Count == 0)
            {
                MessageBox.Show("Por favor, selecciona un cliente existente.", "Dato requerido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool VerificarMascota()
        {
            btnMascota.Focus();

            return true;
        }

        private bool VerificarTipo()
        {
            cboTipo.Focus();

            if (cboTipo.SelectedItem is null)
            {
                MessageBox.Show("Por favor, selecciona un tipo de orden.", "Dato requerido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool VerificarArticulo()
        {
            btnArticulo.Focus();

            if (txtArticulo.Text.Length == 0)
            {
                MessageBox.Show("Por favor, selecciona un artículo.", "Dato requerido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool VerificarNotas()
        {
            txtNotas.Focus();

            return true;
        }

        private bool VerificarDatos()
        {
            return VerificarCliente() && VerificarMascota() && VerificarTipo() && VerificarArticulo() && VerificarNotas();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (VerificarDatos())
            {
                if (txtMascota.Text.Length == 0) { txtMascota.Text = "NULL"; }

                if (IdOrden == -1)
                {
                    Ordenes.Crear(txtCliente.Text, txtMascota.Text, cboTipo.SelectedItem.ToString(), txtArticulo.Text, txtNotas.Text);
                }
                else
                {
                    Ordenes.ActualizarPorId(IdOrden, txtCliente.Text, txtMascota.Text, cboTipo.SelectedItem.ToString(), txtArticulo.Text, txtNotas.Text);
                }

                FormInicio.ActualizarOrdenes();
                Close();
            }
        }
    }
}
