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
    public partial class FrmMascota : Form
    {
        private FrmInicio _formInicio;
        private int _idMascota;

        public FrmInicio FormInicio { get => _formInicio; set => _formInicio = value; }
        public int IdMascota { get => _idMascota; set => _idMascota = value; }

        public FrmMascota(FrmInicio formInicio)
        {
            FormInicio = formInicio;
            IdMascota = -1;
            InitializeComponent();
        }

        public FrmMascota(FrmInicio formInicio, int idMascota)
        {
            FormInicio = formInicio;
            IdMascota = idMascota;
            InitializeComponent();

            List<string> mascota = Mascotas.BuscarPorId(IdMascota);
            Text = $"Editar mascota #{IdMascota}";
            txtNombre.Text = mascota[1];
            txtPropietario.Text = mascota[2];
            cboAnimal.SelectedItem = mascota[3];
            txtRaza.Text = mascota[4];
            numPeso.Value = Convert.ToDecimal(mascota[5]);
            txtColor.Text = mascota[6];
            txtNotas.Text = mascota[7];
            btnAgregar.Text = "Editar";
        }

        public string ObtenerPropietario()
        {
            return txtPropietario.Text;
        }

        public void SeleccionarPropietario(string idPropietario)
        {
            txtPropietario.Text = idPropietario;
        }

        private void btnPropietario_Click(object sender, EventArgs e)
        {
            new FrmMascotaPropietario(this).ShowDialog();
        }

        private bool VerificarNombre()
        {
            txtNombre.Focus();

            if (txtNombre.Text.Length == 0)
            {
                MessageBox.Show("Por favor, ingresa el nombre o apodo.", "Dato requerido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool VerificarPropietario()
        {
            btnPropietario.Focus();

            if (txtPropietario.Text.Length == 0)
            {
                MessageBox.Show("Por favor, selecciona un propietario.", "Dato requerido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if (Clientes.BuscarPorId(Convert.ToInt32(txtPropietario.Text)).Count == 0)
            {
                MessageBox.Show("Por favor, selecciona un propietario existente.", "Dato requerido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool VerificarAnimal()
        {
            cboAnimal.Focus();

            if (cboAnimal.SelectedText.Length == 0)
            {
                MessageBox.Show("Por favor, selecciona un tipo de animal.", "Dato requerido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool VerificarRaza()
        {
            txtRaza.Focus();

            return true;
        }

        private bool VerificarPeso()
        {
            numPeso.Focus();

            if (numPeso.Value == 0)
            {
                MessageBox.Show("Por favor, ingresa un peso mayor a 0.", "Dato requerido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool VerificarColor()
        {
            txtColor.Focus();

            if (txtColor.Text.Length == 0)
            {
                MessageBox.Show("Por favor, ingresa el color, colores o patrones distintivos.", "Dato requerido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
            return VerificarNombre() && VerificarPropietario() && VerificarAnimal() && VerificarRaza() && VerificarPeso() && VerificarColor() && VerificarNotas();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (VerificarDatos())
            {
                if (IdMascota == -1)
                {
                    Mascotas.Crear(txtNombre.Text, Convert.ToInt32(txtPropietario.Text), Convert.ToString(cboAnimal.SelectedItem), txtRaza.Text, Convert.ToString(numPeso.Value).Replace(",", "."), txtColor.Text, txtNotas.Text);
                }
                else
                {
                    Mascotas.ActualizarPorId(IdMascota, txtNombre.Text, Convert.ToInt32(txtPropietario.Text), Convert.ToString(cboAnimal.SelectedItem), txtRaza.Text, Convert.ToString(numPeso.Value).Replace(",", "."), txtColor.Text, txtNotas.Text);
                }

                FormInicio.ActualizarMascotas();
                Close();
            }
        }

        
    }
}
