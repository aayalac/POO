namespace POO
{
    class ConversorEuroDolar
    {
        private double euro = 1.253;

        public double Convierte(double cantidad)
        {
            return cantidad * euro;
        }

        public void CambiaValorEuro (double nuevoValor)
        {
            if (nuevoValor < 0) 
                euro = 1.253;
            else
                euro = nuevoValor;
        }
    }
}
