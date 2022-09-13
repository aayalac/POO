namespace POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Circulo miCirculo; // Creacion de objeto de tipo Círculo. Variable / objeto de tipo círculo.

            miCirculo = new Circulo(); // Iniciación de variable / objeto de tipo circulo. Instanciar una clase (instanciacion, ejemplarizacion, creacion de ejemplar de clase).

            Console.WriteLine(miCirculo.calculoArea(5));

            Circulo miCirculo2 = new Circulo();

            Console.WriteLine(miCirculo2.calculoArea(9));
        }
    }
}