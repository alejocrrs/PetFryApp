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
    public partial class FrmOrdenArticulo : Form
    {
        private FrmOrden _formOrden;

        public FrmOrden FormOrden { get => _formOrden; set => _formOrden = value; }

        public FrmOrdenArticulo(FrmOrden formOrden)
        {
            FormOrden = formOrden;
            InitializeComponent();
            ActualizarListaArticulos();
        }

        private void ActualizarListaArticulos()
        {
            dgvArticulos.Rows.Clear();
            List<List<string>> articulos = new List<List<string>>();

            switch (FormOrden.ObtenerTipo())
            {
                case "Productos":
                    Text = "Seleccionar producto";
                    articulos = Productos.Buscar();
                    break;
                case "Servicios":
                    Text = "Seleccionar servicios";
                    articulos = Servicios.Buscar();
                    break;
            }


            foreach (List<string> articulo in articulos)
            {
                dgvArticulos.Rows.Add(articulo.ToArray());
            }

            string idArticulo = FormOrden.ObtenerArticulo();
            if (idArticulo.Length > 0)
            {
                dgvArticulos.ClearSelection();

                foreach (DataGridViewRow row in dgvArticulos.Rows)
                {
                    if (row.Cells["IdArticulo"].Value.ToString() == idArticulo)
                    {
                        row.Selected = true;
                        dgvArticulos.CurrentCell = row.Cells[0];
                        break;
                    }
                }
            }
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dgvArticulos.SelectedRows.Count > 0)
            {
                string idArticulo = Convert.ToString(dgvArticulos.SelectedRows[0].Cells[0].Value);
                decimal valorArticulo = Convert.ToDecimal(dgvArticulos.SelectedRows[0].Cells[2].Value);
                FormOrden.SeleccionarArticulo(idArticulo, valorArticulo);
                Close();
            }
        }
    }
}
