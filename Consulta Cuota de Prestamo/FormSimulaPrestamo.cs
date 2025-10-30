using System;
using System.Windows.Forms;

namespace SimuladorPrestamo
{
    public partial class FormSimulaPrestamo : Form
    {
        public FormSimulaPrestamo()
        {
            InitializeComponent();
        }

        // --- EVENTO CARGA DEL FORM ---
        private void FormSimulaPrestamo_Load(object sender, EventArgs e)
        {
            txtCuota.ReadOnly = true;
        }

        // --- BOTÓN CONSULTAR ---
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            lblMensajes.Text = "";
            txtCuota.Text = "";

            try
            {
                // Validar Monto
                if (!ValidaDatos.EsRealPositivo(txtMonto.Text, out double monto))
                {
                    lblMensajes.Text = "Monto inválido. Ingrese un número mayor que 0.";
                    txtMonto.Focus();
                    return;
                }

                // Validar Tasa
                if (!ValidaDatos.EsRealPositivo(txtTasa.Text, out double tasa))
                {
                    lblMensajes.Text = "Tasa inválida. Ingrese un número positivo.";
                    txtTasa.Focus();
                    return;
                }

                // Validar Plazo
                if (!ValidaDatos.EsEntero(txtPlazo.Text, out int plazo))
                {
                    lblMensajes.Text = "Plazo inválido. Ingrese un número entero positivo.";
                    txtPlazo.Focus();
                    return;
                }

                // Crear préstamo y calcular
                Prestamo p = new Prestamo(monto, tasa, plazo);
                double cuota = p.ObtenerCuota();
                double interesTotal = p.ObtenerInteresAcumulado();

                txtCuota.Text = cuota.ToString("N2");
                lblMensajes.ForeColor = System.Drawing.Color.Green;
                lblMensajes.Text = $"Interés total: {interesTotal:N2}";
            }
            catch (Exception ex)
            {
                lblMensajes.ForeColor = System.Drawing.Color.Red;
                lblMensajes.Text = $"Error: {ex.Message}";
            }
        }

        // --- BOTÓN RESTABLECER ---
        private void btnRestablecer_Click(object sender, EventArgs e)
        {
            txtMonto.Text = "";
            txtTasa.Text = "";
            txtPlazo.Text = "";
            txtCuota.Text = "";
            lblMensajes.Text = "";
            txtMonto.Focus();
        }

        // --- BOTÓN CERRAR ---
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

