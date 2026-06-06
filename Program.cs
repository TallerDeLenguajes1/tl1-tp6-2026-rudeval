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
//-----------Ejercicio 1----------------

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

//----------Ejercicio 2--------
using System.Diagnostics.Contracts;
using System.Net;

Console.WriteLine("--MENU--");
Console.WriteLine(
    "-1 Calculadora basica\n" +
    "-2 Funciones matematicas\n" +
    "-3 Maximo y minimo de 2 numeros\n" +
    "-0 Salir"
);

int eleccionMenu = PedirNumeroInt();
do
{
    switch (eleccionMenu)
    {
        case 0:
            Console.WriteLine("Programa finalizado");
            break;
        case 1: 
            CalculadoraV1();
            break;
        case 2: 
            FuncionesMatematicas();
            break;
        case 3: 
            MaxMin();
            break;
        default: 
            Console.WriteLine("Opción no válida. Intente de nuevo.");
            break;
    }
    
} while (eleccionMenu != 0);


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

static void CalculadoraV1()
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
        switch (eleccion)
        {
            case 1: 
                resultado = Sumar(a, b);
                break;
            case 2: 
                resultado = Restar(a, b);
                break;
            case 3: 
                resultado = Multiplicar(a, b);
                break;
            case 4: 
                if (b != 0) resultado = Dividir(a, b);
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

        Console.WriteLine("...Continuar? 0-no, 1-si");
            continuar = PedirNumeroInt();
        
    } while (continuar == 1);

}

static void FuncionesMatematicas()
{
    //--------------V2
    Console.WriteLine("--CALCULADORA V2--");

    int continuar = 0;
    do
    {

        Console.WriteLine("Ingrese un numero para operar: ");
            double num = PedirNumeroDouble();

        Console.WriteLine($"Valor absoluto: {Math.Abs(num)}");
        Console.WriteLine($"Cuadrado: {num * num}");
        Console.WriteLine($"Raíz cuadrada: {Math.Sqrt(num)}");
        Console.WriteLine($"Seno: {Math.Sin(num)}");
        Console.WriteLine($"Coseno: {Math.Cos(num)}");
        Console.WriteLine($"Parte entera: {Math.Truncate(num)}");
        
        Console.WriteLine("...Continuar? 0-no, 1-si");
            continuar = PedirNumeroInt();

    } while (continuar == 1);
}

static void MaxMin()
{
    // -----------max y min
    Console.WriteLine("--MAXIMO y MINIMO--");
    int continuar = 0;
    do
    {
        Console.WriteLine("Ingrese el primer numero: ");
        double a = PedirNumeroDouble();

        Console.WriteLine("Ingrese el segundo numero: ");
        double b = PedirNumeroDouble();

        Console.WriteLine($"Maximo: {Math.Max(a,b)}");
        Console.WriteLine($"Minimo: {Math.Min(a,b)}");

        
        Console.WriteLine("...Continuar? 0-no, 1-si");
            continuar = PedirNumeroInt();
        
    } while (continuar == 1);
        
}

