namespace POO
{
    class Coche
    {
        public void setExtras(bool climatizador, string tapiceria) // metodo para establecer los campos climatizador y tapiceria
        {
            this.climatizador = climatizador;

            this.tapiceria = tapiceria;
        }

        public string getExtras()
        {
            return "Extras del cocche:\n" + "Tapiceria: " + tapiceria + " Climatizador: " + climatizador;
        }

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

            tapiceria = "Tela";
        }

        public Coche(double largoCoche, double anchoCoche) // sobrecarga de constructores
        {
            ruedas = 4;

            largo = largoCoche;

            ancho = anchoCoche;

            tapiceria = "Tela";
        }        

        public string getInfoCoche() // metodo para cambiar los valores de ruedas, largo y ancho
        {
            return "Informacion del coche:\n" + "Ruedas: " + ruedas + " " + "Largo: " + largo + " " + "Ancho: " + ancho;
        }        
    }
}
