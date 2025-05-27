// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ingrese una cadena de texto: ");
string cadenaIngresada = Console.ReadLine();
int longitudCadena = cadenaIngresada.Length;
Console.WriteLine($"La longitud de la cadena ingresada es {longitudCadena}");

Console.WriteLine("Ingrese una segunda cadena: ");
string segundaCadena = Console.ReadLine();
string concatenadas = string.Concat(cadenaIngresada, " ", segundaCadena);
Console.WriteLine($"La cadena concatenada es: {concatenadas}");

string subCadena = concatenadas.Substring(1, 5); //-- sub indice --
Console.WriteLine($"Sub cadena obtenida: {subCadena}");

// ejercicio calculadora: convertir int a string

int a = 1;
int b = 2;
int resultado = a + b;
Console.WriteLine($"La suma de {a.ToString()} y {b.ToString()} es {resultado.ToString()}");

foreach (char elemento in concatenadas)
{
    Console.WriteLine(elemento);
}