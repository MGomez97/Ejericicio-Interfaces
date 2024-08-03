class Program
{
    static void Main(string[] args)
    {
        OperacionesMatematicas operaciones = new OperacionesMatematicas();

        // Ejemplo de uso
        Console.WriteLine("Ingrese el largo y el ancho para calcular el área:");
        double largo = double.Parse(Console.ReadLine());
        double ancho = double.Parse(Console.ReadLine());
        double area = operaciones.CalcularArea(largo, ancho);
        operaciones.Imprimir(area);

        // Aquí puedes seguir pidiendo datos y calculando otras operaciones según lo definido en la interfaz
    }
}
