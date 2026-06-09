/*
Console.WriteLine("Hello, World!");

int a;

int b;

a = 10;

b = a;

Console.WriteLine("valor de a:" + a);
Console.WriteLine("valor de b:" + b);
*/

/*
//-----------Ejercicio 1------------

Console.WriteLine("Ingrese un numero: ");
    string texto = Console.ReadLine();

bool valido = int.TryParse(texto, out int numero); //verificamos que sea un num valido
if(!valido) Console.WriteLine("No ingresó un número");
else if(numero <= 0) Console.WriteLine("El número debe ser mayor que 0"); //verifica num>0
else {
    Console.WriteLine("Numero valido");
    int aux = numero;
    int invertido = 0;

    while(aux>0)
    {
        invertido = (invertido * 10) + (aux % 10);
        aux = aux / 10; 
    }

    Console.WriteLine($"Numero invertido: {invertido}");
}
*/

//-----------Ejercicio 4-------------
Console.WriteLine("Ingrese la primera cadena: ");
    string Cadena1 = Console.ReadLine();

Console.WriteLine($"Longitud de la cadena: {Cadena1.Length}");

Console.WriteLine("Ingrese la segunda cadena: ");
    string Cadena2 = Console.ReadLine();

string Concatenadas = string.Concat(Cadena1, " " ,Cadena2);
Console.WriteLine($"-> Cadenas concatenadas: {Concatenadas}");

Console.WriteLine("--Extraer subcadena de la cadena igresada--");
Console.WriteLine("Ingrese la posición inicial:");
    int inicio = PedirNumeroInt();
Console.WriteLine("Ingrese la longitud:");
    int longitud = PedirNumeroInt();
string subcadena = Cadena1.Substring(inicio, longitud);
Console.WriteLine($"-> Subcadena extraída: {subcadena}");

//--CALCULADORA CON SALIDA STRING--
CalculadoraV1Ejercicio4();

//--Recorrer con Foreach--


static int PedirNumeroInt()
{
    int numero;
    bool valido;

    do
    {
        string entrada = Console.ReadLine();

        valido = int.TryParse(entrada, out numero);

        if (!valido)
        {
            Console.WriteLine("Numero no valido, ingrese otro");
        }

    } while (!valido);

    return numero;
}

static double PedirNumeroDouble()
{
    double numero;
    bool valido;

    do
    {
        string entrada = Console.ReadLine();

        valido = double.TryParse(entrada, out numero);

        if (!valido)
        {
            Console.WriteLine("Numero no valido, ingrese otro");
        }

    } while (!valido);

    return numero;
}

static double Sumar(double n1, double n2)
{
    double resultado = n1+n2;
    return resultado;
}

static double Restar(double n1, double n2)
{
    double resultado = n1-n2;
    return resultado;
}

static double Multiplicar(double n1, double n2)
{
    double resultado = n1*n2;
    return resultado;
}

static double Dividir(double n1, double n2)
{
    double resultado = n1/n2;
    return resultado;
}

static void CalculadoraV1Ejercicio4()
{
    
    Console.WriteLine("--CALCULADORAV1--");
    Console.WriteLine(
        "-1 Sumar\n" +
        "-2 Restar\n" +
        "-3 Multiplicar\n" +
        "-4 Dividir\n" +
        "-0 Salir"
    );

    int continuar = 0;
    do
    {
        Console.WriteLine("Ingrese el primer numero: ");
        double a = PedirNumeroDouble();

        Console.WriteLine("Ingrese el segundo numero: ");
        double b = PedirNumeroDouble();

        Console.WriteLine("Ingrese el numero de operacion: ");
        int eleccion = PedirNumeroInt();

        double resultado = 0;
        string operacion = "";
        switch (eleccion)
        {
            case 1: 
                resultado = Sumar(a, b);
                operacion = "suma";
                break;
            case 2: 
                resultado = Restar(a, b);
                operacion = "resta";
                break;
            case 3: 
                resultado = Multiplicar(a, b);
                operacion = "multiplicacion";
                break;
            case 4: 
                if (b != 0) resultado = Dividir(a, b);
                operacion = "division";
                break;
            default: 
                Console.WriteLine("Opción no válida. Intente de nuevo.");
                break;
        }

        if (eleccion == 4 && b== 0)
        {
            Console.WriteLine("Error");
        }
        else
        {
            Console.WriteLine($"Resultado: {resultado}");
        }

        //-----(Ejercicio 4)-----
        Console.WriteLine(
        "La " + operacion + " de " + a.ToString() +
        " y de " + b.ToString() +
        " es igual a: " + resultado.ToString()
        );
        //---------------------

        Console.WriteLine("...Continuar? 0-no, 1-si");
            continuar = PedirNumeroInt();
        
    } while (continuar == 1);

}







