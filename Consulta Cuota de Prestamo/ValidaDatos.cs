namespace SimuladorPrestamo
{
    public static class ValidaDatos
    {
        public static bool EsRealPositivo(string valor, out double numero)
        {
            if (double.TryParse(valor, out numero))
                return numero > 0;
            return false;
        }

        public static bool EsEntero(string valor, out int numero)
        {
            if (int.TryParse(valor, out numero))
                return numero > 0;
            return false;
        }
    }
}

