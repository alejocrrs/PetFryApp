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
    public partial class FrmOrdenMascota : Form
    {
        private FrmOrden _formOrden;

        public FrmOrden FormOrden { get => _formOrden; set => _formOrden = value; }

        public FrmOrdenMascota(FrmOrden formOrden)
        {
            FormOrden = formOrden;
            InitializeComponent();
            ActualizarListaMascotas();
        }

        private void ActualizarListaMascotas()
        {
            dgvMascotas.Rows.Clear();

            foreach (List<string> mascotas in Mascotas.Buscar())
            {
                dgvMascotas.Rows.Add(mascotas.ToArray());
            }

            string idMascota = FormOrden.ObtenerMascota();
            if (idMascota.Length > 0)
            {
                dgvMascotas.ClearSelection();

                foreach (DataGridViewRow row in dgvMascotas.Rows)
                {
                    if (row.Cells["IdMascota"].Value.ToString() == idMascota)
                    {
                        row.Selected = true;
                        dgvMascotas.CurrentCell = row.Cells[0];
                        break;
                    }
                }
            }
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dgvMascotas.SelectedRows.Count > 0)
            {
                string idMascota = Convert.ToString(dgvMascotas.SelectedRows[0].Cells[0].Value);
                FormOrden.SeleccionarMascota(idMascota);
                Close();
            }
        }

        private void btnDeseleccionar_Click(object sender, EventArgs e)
        {
            FormOrden.DeseleccionarMascota();
            Close();
        }
    }
}
