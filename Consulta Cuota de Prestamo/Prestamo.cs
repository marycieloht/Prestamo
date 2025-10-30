namespace SimuladorPrestamo
{
    public class Prestamo : IPrestamo
    {
        public double Monto { get; set; }
        public double Tasa { get; set; }
        public int Plazo { get; set; }

        public Prestamo(double monto, double tasa, int plazo)
        {
            Monto = monto;
            Tasa = tasa / 100.0; // convertir a porcentaje
            Plazo = plazo;
        }

        public double ObtenerCuota()
        {
            // Fórmula cuota mensual: M * (r / (1 - (1 + r)^-n))
            double r = Tasa / 12.0; // tasa mensual
            double cuota = Monto * (r / (1 - Math.Pow(1 + r, -Plazo)));
            return cuota;
        }

        public double ObtenerInteresAcumulado()
        {
            double cuota = ObtenerCuota();
            double totalPagado = cuota * Plazo;
            double interesTotal = totalPagado - Monto;
            return interesTotal;
        }
    }
}
