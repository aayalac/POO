namespace POO
{
    class Program
    {
        static void Main(string[] args)
        {
           /*ConversorEuroDolar obj = new ConversorEuroDolar(); // Instanciado.

            obj.CambiaValorEuro(1.5);

           Console.WriteLine(obj.Convierte(50));*/

        Coche coche1 = new Coche(); // Crear objeto / instancia de tipo coche.
            // Dar un estado inicial a nuestro coche

        Coche coche2 = new Coche();

        Console.WriteLine(coche1.getInfoCoche());

        Console.WriteLine(coche2.getInfoCoche());

        // llamado al metodo
        Coche coche3 = new Coche(4500.25, 1200.35);    
        Console.WriteLine(coche3.getInfoCoche()); 
        }
    }
}