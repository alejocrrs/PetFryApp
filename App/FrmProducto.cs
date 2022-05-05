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
    public partial class FrmProducto : Form
    {
        private FrmInicio _formInicio;
        private int _idProducto;

        public FrmInicio FormInicio { get => _formInicio; set => _formInicio = value; }
        public int IdProducto { get => _idProducto; set => _idProducto = value; }

        public FrmProducto(FrmInicio formInicio)
        {
            FormInicio = formInicio;
            IdProducto = -1;
            InitializeComponent();
        }

        public FrmProducto(FrmInicio formInicio, int idProducto)
        {
            FormInicio = formInicio;
            IdProducto = idProducto;
            InitializeComponent();

            List<string> producto = Productos.BuscarPorId(IdProducto);
            Text = $"Editar producto #{IdProducto}";
            txtNombre.Text = producto[1];
            numValor.Value = Convert.ToDecimal(producto[2]);
            txtNotas.Text = producto[3];
            btnAgregar.Text = "Editar";
        }

        private bool VerificarNombre()
        {
            txtNombre.Focus();

            if (txtNombre.Text.Length == 0)
            {
                MessageBox.Show("Por favor, ingresa el nombre descriptivo.", "Dato requerido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool VerificarValor()
        {
            numValor.Focus();

            return true;
        }

        private bool VerificarNotas()
        {
            txtNotas.Focus();

            return true;
        }

        private bool VerificarDatos()
        {
            return VerificarNombre() && VerificarValor() && VerificarNotas();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (VerificarDatos())
            {
                if (IdProducto == -1)
                {
                    Productos.Crear(txtNombre.Text, Convert.ToString(numValor.Value).Replace(",", "."), txtNotas.Text);
                }
                else
                {
                    Productos.ActualizarPorId(IdProducto, txtNombre.Text, Convert.ToString(numValor.Value).Replace(",", "."), txtNotas.Text);
                }

                FormInicio.ActualizarProductos();
                Close();
            }
        }
    }
}
