namespace POO
{
    internal class Coche
    {
        private int ruedas;

        private double largo;

        private double ancho;

        private bool climatizador;

        private string? tapiceria;

        public Coche() // constructor (estado inicial)
        {
            ruedas = 4;

            largo = 2300.5;

            ancho = 0.800;
        }

        public Coche(double largoCoche, double anchoCoche) // sobrecarga
        {
            ruedas = 4;

            largo = largoCoche;

            ancho = anchoCoche;
        }

        public string getInfoCoche()
        {
            return "Informacion del coche:\n" + "Ruedas: " + ruedas + " " + "Largo: " + ruedas + " " + "Ancho: " + ancho;
        }
    }
}
