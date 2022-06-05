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
    public partial class FrmOrdenCliente : Form
    {
        private FrmOrden _formOrden;

        public FrmOrden FormOrden { get => _formOrden; set => _formOrden = value; }

        public FrmOrdenCliente(FrmOrden formOrden)
        {
            FormOrden = formOrden;
            InitializeComponent();
            ActualizarListaClientes();
        }

        private void ActualizarListaClientes()
        {
            dgvClientes.Rows.Clear();

            foreach (List<string> cliente in Clientes.Buscar())
            {
                dgvClientes.Rows.Add(cliente.ToArray());
            }

            string idCliente = FormOrden.ObtenerCliente();
            if (idCliente.Length > 0)
            {
                dgvClientes.ClearSelection();

                foreach (DataGridViewRow row in dgvClientes.Rows)
                {
                    if (row.Cells["IdCliente"].Value.ToString() == idCliente)
                    {
                        row.Selected = true;
                        dgvClientes.CurrentCell = row.Cells[0];
                        break;
                    }
                }
            }
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count > 0)
            {
                string idCliente = Convert.ToString(dgvClientes.SelectedRows[0].Cells[0].Value);
                FormOrden.SeleccionarCliente(idCliente);
                Close();
            }
        }
    }
}
