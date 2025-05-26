// See https://aka.ms/new-console-template for more information
Console.WriteLine("ESTOY EN ESTE ARCHIVO");

Console.WriteLine("Hello, World!");
int a;
int b;
int v = 10;
a = v;
b=a;
Console.WriteLine("valor de a:"+a);
Console.WriteLine("valor de b:" + b);

Console.WriteLine("ESTOY EN LALAALALAL");


//---- ejercicio 1 ----

Console.Write("Escriba un numero: ");
string textoIngresado = Console.ReadLine();

if (int.TryParse(textoIngresado, out int numero) && numero > 0)
{
    int invertido = InvertirNumero(numero);
    Console.WriteLine($"El numero es {numero} Y el numero invertido es: {invertido}");
}

Console.ReadLine(); // <-- Esto evita que la ventana se cierre automáticamente

static int InvertirNumero(int num)
{
    int invertido = 0;
    while (num > 0)
    {
        invertido = invertido * 10 + num % 10;
        num /= 10;
    }
    return invertido;
}