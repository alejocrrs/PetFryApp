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
    public partial class FrmServicio : Form
    {
        private FrmInicio _formInicio;
        private int _idServicio;

        public FrmInicio FormInicio { get => _formInicio; set => _formInicio = value; }
        public int IdServicio { get => _idServicio; set => _idServicio = value; }

        public FrmServicio(FrmInicio formInicio)
        {
            FormInicio = formInicio;
            IdServicio = -1;
            InitializeComponent();
        }

        public FrmServicio(FrmInicio formInicio, int idServicio)
        {
            FormInicio = formInicio;
            IdServicio = idServicio;
            InitializeComponent();

            List<string> servicio = Servicios.BuscarPorId(IdServicio);
            Text = $"Editar servicio #{IdServicio}";
            txtNombre.Text = servicio[1];
            numValor.Value = Convert.ToDecimal(servicio[2]);
            txtNotas.Text = servicio[3];
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
                if (IdServicio == -1)
                {
                    Servicios.Crear(txtNombre.Text, Convert.ToString(numValor.Value).Replace(",", "."), txtNotas.Text);
                }
                else
                {
                    Servicios.ActualizarPorId(IdServicio, txtNombre.Text, Convert.ToString(numValor.Value).Replace(",", "."), txtNotas.Text);
                }

                FormInicio.ActualizarServicios();
                Close();
            }
        }
    }
}
