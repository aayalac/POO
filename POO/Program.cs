namespace POO
{
    class Program
    {
        static void Main(string[] args)
        {
           ConversorEuroDolar obj = new ConversorEuroDolar();

            obj.CambiaValorEuro(1.5);

           Console.WriteLine(obj.Convierte(50));

        }
    }
}