using Arregloa_Biblioteca; // O el namespace que tenga definido Arreglo1.cs
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("Operaciones de pila");
        Console.WriteLine("Arreglo de linea");

        // 1. Declarar la variable (miArreglo) e instanciarla
        Arreglo1 miArreglo = new Arreglo1(100);

        // 2. Usar la variable 'miArreglo' para invocar sus métodos
        miArreglo.Llenar(1, 20);

        Console.WriteLine("Arreglo desordenado\n");
        Console.WriteLine(miArreglo);

        Console.WriteLine("Arreglo ordenado ascendente\n");
        miArreglo.Ordenar();
        Console.WriteLine(miArreglo);
        

    }
}
//MiArreglo oMyArreglo = new(100);
//try
//{
// Console.WriteLine(_"\nArreglo\n");
// oMyArreglo.Llenar();
//Console.WriteLine(oMyArreglo);
//Console.Readkey();

//Console.WriteLine(_"\nPares\n");
//ver Pares = oMyArreglo.ObtenerPares();
//Console.WriteLine(verPares);
//Console.Readkey();


Console.WriteLine($"\nTiempo transcurrido\n");
var tiempo1 = DateTime.Now;
miArreglo.Llenar(1, 9999);
var tiempo2 = DateTime.Now;
var RestarTiempo = tiempo2 - tiempo1;
Console.WriteLine($"Tiempo transcurrido: {RestarTiempo.TotalMilliseconds} ms");