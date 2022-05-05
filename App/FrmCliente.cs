using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Main;

namespace App
{
    public partial class FrmCliente : Form
    {
        private FrmInicio _formInicio;
        private int _idCliente;

        public FrmInicio FormInicio { get => _formInicio; set => _formInicio = value; }
        public int IdCliente { get => _idCliente; set => _idCliente = value;}

        public FrmCliente(FrmInicio formInicio)
        {
            FormInicio = formInicio;
            IdCliente = -1;
            InitializeComponent();
        }

        public FrmCliente(FrmInicio formInicio, int idCliente)
        {
            FormInicio = formInicio;
            IdCliente = idCliente;
            InitializeComponent();

            List<string> cliente = Clientes.BuscarPorId(IdCliente);
            Text = $"Editar cliente #{IdCliente}";
            txtDocumento.Text = cliente[1];
            txtNombre.Text = cliente[2];
            txtTelefono.Text = cliente[3];
            txtDireccion.Text = cliente[4];
            txtCorreo.Text = cliente[5];
            btnAgregar.Text = "Editar";
        }

        private bool VerificarDocumento()
        {
            txtDocumento.Focus();

            if (txtDocumento.Text.Length == 0)
            {
                MessageBox.Show("Por favor, ingresa el número de documento.", "Dato requerido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if (!Int64.TryParse(txtDocumento.Text, out _))
            {
                MessageBox.Show("El número de documento debe contener solo valores numéricos.", "Dato inválido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if (Clientes.BuscarPorDocumento(txtDocumento.Text).Count > 0 && IdCliente != Clientes.BuscarIdPorDocumento(txtDocumento.Text))
            {
                MessageBox.Show("El número de documento ya está registrado.", "Dato inválido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool VerificarNombre()
        {
            txtNombre.Focus();

            if (txtNombre.Text.Length == 0)
            {
                MessageBox.Show("Por favor, ingresa el nombre completo.", "Dato requerido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool VerificarTelefono()
        {
            txtTelefono.Focus();

            if (txtTelefono.Text.Length == 0)
            {
                MessageBox.Show("Por favor, ingresa el número de teléfono.", "Dato requerido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if (!Int64.TryParse(txtTelefono.Text, out _))
            {
                MessageBox.Show("El número de teléfono debe contener solo valores numéricos.", "Dato inválido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool VerificarDireccion()
        {
            txtDireccion.Focus();

            if (txtDireccion.Text.Length == 0)
            {
                MessageBox.Show("Por favor, ingresa la dirección de residencia.", "Dato requerido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool VerificarCorreo()
        {
            txtCorreo.Focus();

            if (txtCorreo.Text.Length == 0)
            {
                MessageBox.Show("Por favor, ingresa el correo electrónico.", "Dato requerido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if (!new EmailAddressAttribute().IsValid(txtCorreo.Text))
            {
                MessageBox.Show("El correo electrónico no cumple con la estructura básica (Ejemplo: nombre@ejemplo.com).", "Dato inválido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool VerificarDatos()
        {
            return VerificarDocumento() && VerificarNombre() && VerificarTelefono() && VerificarDireccion() && VerificarCorreo();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (VerificarDatos())
            {
                if (IdCliente == -1)
                {
                    Clientes.Crear(txtDocumento.Text, txtNombre.Text, txtTelefono.Text, txtDireccion.Text, txtCorreo.Text);
                }
                else
                {
                    Clientes.ActualizarPorId(IdCliente, txtDocumento.Text, txtNombre.Text, txtTelefono.Text, txtDireccion.Text, txtCorreo.Text);
                }

                FormInicio.ActualizarClientes();
                Close();
            }
        }
    }
}
