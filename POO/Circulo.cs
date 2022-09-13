class Circulo
{
    private const double pi = 3.1416; // propiedad de la Clase Círculo. Campos de clase.

    public double CalculoArea(int radio) // método de clase. ¿que pueden hacer los objetos de tipo círculo?
    {
        return pi * radio * radio;
    }
}