using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using Main;

namespace App
{
    public partial class FrmLogueo : Form
    {
        public FrmLogueo()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool ValidarDocumento()
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
            else if (Usuarios.BuscarIdPorDocumento(txtDocumento.Text) == -1)
            {
                MessageBox.Show("Ha ocurrido un error al buscar al usuario.", "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Usuarios.BuscarIdPorDocumento(txtDocumento.Text) == 0)
            {
                MessageBox.Show("El número de documento no está registrado.", "Dato inválido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else
            {
                return true;
            }
        }

        private string MD5(string str)
        {
            MD5 md5 = MD5CryptoServiceProvider.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] stream = null;
            StringBuilder sb = new StringBuilder();
            stream = md5.ComputeHash(encoding.GetBytes(str));
            for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
            return sb.ToString();
        }

        private bool ValidarClave()
        {
            txtClave.Focus();
            int idUsuario = Usuarios.BuscarIdPorDocumentoYClave(txtDocumento.Text, MD5(txtClave.Text));
            int bloqueoUsuario = Usuarios.BuscarBloqueoPorId(idUsuario.ToString());

            if (txtClave.Text.Length == 0)
            {
                MessageBox.Show("Por favor, ingresa la contraseña.", "Dato requerido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if (idUsuario == -1 && bloqueoUsuario == -1)
            {
                MessageBox.Show("Ha ocurrido un error al buscar al usuario.", "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (idUsuario == 0)
            {
                MessageBox.Show("La contraseña no es correcta.", "Dato inválido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if (bloqueoUsuario == 1)
            {
                MessageBox.Show("El usuario tiene el inicio de sesión bloqueado.", "Error de acceso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool ValidarDatos()
        {
            return ValidarDocumento() && ValidarClave();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                int idUsuario = Usuarios.BuscarIdPorDocumentoYClave(txtDocumento.Text, MD5(txtClave.Text));
                Hide();
                new FrmInicio(idUsuario).ShowDialog();
                Close();
            }
        }
    }
}
