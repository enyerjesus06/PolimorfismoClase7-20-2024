using PolimorfismoClase;



public class Program
{
    static void Main(string[] args)
    {
        
        Figura rectangulo = new Rectangulo(100, 67);
        Console.WriteLine($"Área del rectángulo: { rectangulo.CalcularArea() } ");

        Figura circulo = new Circulo(52);
        Console.WriteLine($"Área del círculo: { circulo.CalcularArea() } ");

        Figura triangulo = new Triangulo(54, 98);
        Console.WriteLine($"Área del triángulo:  { triangulo.CalcularArea() }");

        Console.ReadLine();
    }
}