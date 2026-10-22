using System;
using System.Globalization;
using System.Windows.Forms;

namespace pryBar
{
    public partial class Form1 : Form
    {
        private readonly string[] mozos = { "Julio", "Esteban", "Javier", "Gonzalo", "Alberto" };
        private readonly string[] categorias = { "Comidas", "Bebidas sin alcohol", "Bebidas con alcohol", "Postres" };
        private float[,] ventas;

        public Form1()
        {
            InitializeComponent();
            ventas = new float[5, 4];
            InicializarFormulario();
        }

        private void InicializarFormulario()
        {
            btnMozoDia.Enabled = false;
            btnTotales.Enabled = false;
            LimpiarResultados();
            ConfigurarGrid();
        }

        private void ConfigurarGrid()
        {
            gridVentas.Rows.Clear();
            gridVentas.Rows.Add(5);

            for (int fila = 0; fila < mozos.Length; fila++)
            {
                gridVentas.Rows[fila].HeaderCell.Value = mozos[fila];
            }

            for (int columna = 0; columna < categorias.Length; columna++)
            {
                gridVentas.Columns[columna].HeaderText = categorias[columna];
            }
        }

        private void LimpiarResultados()
        {
            lblMozoDiaNombre.Text = string.Empty;
            lblMozoDiaMonto.Text = string.Empty;
            lblTotalGeneral.Text = string.Empty;
            lblTotalComidas.Text = string.Empty;
            lblTotalSinAlcohol.Text = string.Empty;
            lblTotalConAlcohol.Text = string.Empty;
            lblTotalPostres.Text = string.Empty;
        }

        private bool ValidarDatos()
        {
            for (int fila = 0; fila < 5; fila++)
            {
                for (int columna = 0; columna < 4; columna++)
                {
                    var valor = gridVentas.Rows[fila].Cells[columna].Value;

                    if (valor == null || string.IsNullOrWhiteSpace(valor.ToString()))
                    {
                        return false;
                    }

                    float importe;
                    if (!float.TryParse(valor.ToString(), NumberStyles.Float, CultureInfo.CurrentCulture, out importe))
                    {
                        return false;
                    }

                    if (importe < 0)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        private void CargarArreglo()
        {
            for (int fila = 0; fila < 5; fila++)
            {
                for (int columna = 0; columna < 4; columna++)
                {
                    ventas[fila, columna] = float.Parse(gridVentas.Rows[fila].Cells[columna].Value.ToString(), CultureInfo.CurrentCulture);
                }
            }
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            if (!ValidarDatos())
            {
                btnMozoDia.Enabled = false;
                btnTotales.Enabled = false;
                LimpiarResultados();
                MessageBox.Show("Debe completar todas las celdas con valores numéricos válidos. El cero es válido, pero no se admiten valores vacíos ni negativos.",
                    "Error de validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            CargarArreglo();
            btnMozoDia.Enabled = true;
            btnTotales.Enabled = true;
            MessageBox.Show("Los datos fueron validados correctamente.",
                "Validación exitosa",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnMozoDia_Click(object sender, EventArgs e)
        {
            if (!ValidarDatos())
            {
                return;
            }

            CargarArreglo();

            int mozoGanador = 0;
            float mayorTotal = float.MinValue;

            for (int fila = 0; fila < 5; fila++)
            {
                float totalMozo = 0f;

                for (int columna = 0; columna < 4; columna++)
                {
                    totalMozo += ventas[fila, columna];
                }

                if (totalMozo > mayorTotal)
                {
                    mayorTotal = totalMozo;
                    mozoGanador = fila;
                }
            }

            lblMozoDiaNombre.Text = mozos[mozoGanador];
            lblMozoDiaMonto.Text = mayorTotal.ToString("C", CultureInfo.CurrentCulture);
        }

        private void btnTotales_Click(object sender, EventArgs e)
        {
            if (!ValidarDatos())
            {
                return;
            }

            CargarArreglo();

            float totalGeneral = 0f;
            float[] totalCategorias = new float[4];

            for (int fila = 0; fila < 5; fila++)
            {
                for (int columna = 0; columna < 4; columna++)
                {
                    totalGeneral += ventas[fila, columna];
                    totalCategorias[columna] += ventas[fila, columna];
                }
            }

            lblTotalGeneral.Text = totalGeneral.ToString("C", CultureInfo.CurrentCulture);
            lblTotalComidas.Text = totalCategorias[0].ToString("C", CultureInfo.CurrentCulture);
            lblTotalSinAlcohol.Text = totalCategorias[1].ToString("C", CultureInfo.CurrentCulture);
            lblTotalConAlcohol.Text = totalCategorias[2].ToString("C", CultureInfo.CurrentCulture);
            lblTotalPostres.Text = totalCategorias[3].ToString("C", CultureInfo.CurrentCulture);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
