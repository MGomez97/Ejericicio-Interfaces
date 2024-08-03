public class OperacionesMatematicas : IOperaciones
{
    public double CalcularArea(double lado1, double lado2)
    {
        return lado1 * lado2;
    }

    public double CalcularLongitud(double medida)
    {
        return medida * 4;
    }

    public double CalcularVolumen(double largo, double ancho, double alto)
    {
        return largo * ancho * alto;
    }

    // Método para imprimir resultados
    public void Imprimir(double resultado)
    {
        Console.WriteLine($"El resultado es: {resultado}");
    }
}
