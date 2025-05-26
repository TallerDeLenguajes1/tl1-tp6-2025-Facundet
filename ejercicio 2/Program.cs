// See https://aka.ms/new-console-template for more information


int respuestaUsuario = 1;


do
{
    Console.WriteLine("Ingrese la opcion que quiera realizar: \n[1].Sumar\n[2].Restar\n[3].Multiplicar\n[4].Dividir");
    string textoIngresado = Console.ReadLine();
    if (int.TryParse(textoIngresado, out int opcion) && opcion <= 4 && opcion >= 1)
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