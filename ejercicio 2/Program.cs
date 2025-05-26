// See https://aka.ms/new-console-template for more information


using System.Windows.Markup;

int respuestaUsuario = 1;


do
{
    Console.WriteLine("Ingrese la opcion que quiera realizar: \n[1].Sumar\n[2].Restar\n[3].Multiplicar\n[4].Dividir\n[5].Valor Absoluto\n[6].El cuadrado de un numero\n[7].La raiz cuadrada\n[8].El seno\n[9].El coseno\n[10].La parte entera de un tipo float\n[11].El maximo y minimo entre dos numeros");
    string textoIngresado = Console.ReadLine();
    if (int.TryParse(textoIngresado, out int opcion) && opcion <= 11 && opcion >= 1)
    {
        switch (opcion)
        {
            case 1:
                int suma = funcionSumar();
                Console.WriteLine($"El resultado de la suma es: {suma}");
                break;
            case 2:
                int resta = funcionResta();
                Console.WriteLine($"El resultado de la resta es: {resta}");
                break;
            case 3:
                int Multiplicar = funcionMultiplicar();
                Console.WriteLine($"El resultado de la multiplicacion es: {Multiplicar}");
                break;
            case 4:
                int dividir = funcionDividir();
                Console.WriteLine($"El resultado de la división es: {dividir}");
                break;
            case 5:
                int abosluto = funcionValorAbsoluto();
                Console.WriteLine($"El valor absoluto es: {abosluto}");
                break;
            case 6:
                int cuadrado = funcionCuadrado();
                Console.WriteLine($"El cuadrado del numero ingresado es: {cuadrado}");
                break;
            case 7:
                double raiz = funcionRaizCuadrada();
                Console.WriteLine($"La raíz cuadrada es: {raiz}");
                break;
            case 8:
                double seno = funcionSeno();
                Console.WriteLine($"El seno es: {seno}");
                break;
            case 9:
                double coseno = funcionCoseno();
                Console.WriteLine($"El coseno es: {coseno}");
                break;
            case 10:
                double entero = funcionParteEntera();
                Console.WriteLine($"La parte entera es: {entero}");
                break;
            case 11: funcionMaxAndMin();
                break;
                
        }

        Console.WriteLine("Desea realizar otra operacion?\n[1].SI\n[2].NO");
        string respuesta = Console.ReadLine();
        if (int.TryParse(respuesta, out int resp))
        {
            respuestaUsuario = resp;
        }

    }
} while (respuestaUsuario != 2);




static int funcionSumar()
{
    int primerNumero = 0;
    int segundoNumero = 0;
    Console.Write("Ingrese el primer numero: ");
    string textoIngresado = Console.ReadLine();
    if (int.TryParse(textoIngresado, out int a))
    {
        primerNumero = a;
    }

    Console.WriteLine("Ingrese el segundo numero: ");
    string SegundoTexto = Console.ReadLine();
    if (int.TryParse(SegundoTexto, out int b))
    {
        segundoNumero = b;
    }

    return (primerNumero + segundoNumero);

}

static int funcionResta()
{
    int primerNumero = 0;
    int segundoNumero = 0;
    Console.Write("Ingrese el primer numero: ");
    string textoIngresado = Console.ReadLine();
    if (int.TryParse(textoIngresado, out int a))
    {
        primerNumero = a;
    }

    Console.WriteLine("Ingrese el segundo numero: ");
    string SegundoTexto = Console.ReadLine();
    if (int.TryParse(SegundoTexto, out int b))
    {
        segundoNumero = b;
    }

    return (primerNumero - segundoNumero);
}

static int funcionMultiplicar()
{
    int primerNumero = 0;
    int segundoNumero = 0;
    Console.Write("Ingrese el primer numero: ");
    string textoIngresado = Console.ReadLine();
    if (int.TryParse(textoIngresado, out int a))
    {
        primerNumero = a;
    }

    Console.WriteLine("Ingrese el segundo numero: ");
    string SegundoTexto = Console.ReadLine();
    if (int.TryParse(SegundoTexto, out int b))
    {
        segundoNumero = b;
    }

    return (primerNumero * segundoNumero);
}

static int funcionDividir()
{
    int primerNumero = 0;
    int segundoNumero = 0;
    Console.Write("Ingrese el primer numero: ");
    string textoIngresado = Console.ReadLine();
    if (int.TryParse(textoIngresado, out int a))
    {
        primerNumero = a;
    }

    Console.WriteLine("Ingrese el segundo numero: ");
    string SegundoTexto = Console.ReadLine();
    if (int.TryParse(SegundoTexto, out int b))
    {
        segundoNumero = b;
    }

    return (primerNumero / segundoNumero);
}

static int funcionValorAbsoluto()
{
    int absoluto = 0;
    Console.Write("Ingrese el primer numero: ");
    string textoIngresado = Console.ReadLine();
    if (int.TryParse(textoIngresado, out int a))
    {
        absoluto = Math.Abs(a);
    }

    return absoluto;
}

static int funcionCuadrado()
{
    int cuadrado = 0;
    Console.Write("Ingrese el primer numero: ");
    string textoIngresado = Console.ReadLine();
    if (int.TryParse(textoIngresado, out int a))
    {
        cuadrado = a * a;
    }

    return cuadrado;
}

static double funcionRaizCuadrada()
{
    double raiz = 0;
    Console.Write("Ingrese el primer numero: ");
    string textoIngresado = Console.ReadLine();
    if (double.TryParse(textoIngresado, out double a))
    {
        raiz = Math.Sqrt(a);
    }

    return raiz;
}

static double funcionSeno()
{
    double seno = 0;
    Console.Write("Ingrese el primer numero: ");
    string textoIngresado = Console.ReadLine();
    if (double.TryParse(textoIngresado, out double a))
    {
        seno = Math.Sin(a);
    }

    return seno;
}

static double funcionCoseno()
{
    double coseno = 0;
    Console.Write("Ingrese el primer numero: ");
    string textoIngresado = Console.ReadLine();
    if (double.TryParse(textoIngresado, out double a))
    {
        coseno = Math.Cos(a);
    }

    return coseno;
}

static double funcionParteEntera()
{
    double numero = 0;
    Console.Write("Ingrese el primer numero: ");
    string textoIngresado = Console.ReadLine();
    if (double.TryParse(textoIngresado, out double a))
    {
        numero = (int)numero;
    }

    return numero;
}

static void funcionMaxAndMin()
{
    Console.WriteLine("Ingrese el primer número:");
    int num1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese el segundo número:");
    int num2 = int.Parse(Console.ReadLine());

    // Máximo y mínimo
    int maximo = Math.Max(num1, num2);
    int minimo = Math.Min(num1, num2);

    Console.WriteLine($"El número mayor es: {maximo}");
    Console.WriteLine($"El número menor es: {minimo}");
}