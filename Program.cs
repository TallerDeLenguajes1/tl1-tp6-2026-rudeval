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

Console.WriteLine("CALCULADORA");
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
    int a = PedirNumero();

    Console.WriteLine("Ingrese el segundo numero: ");
    int b = PedirNumero();

    Console.WriteLine("Ingrese el numero de operacion: ");
    int eleccion = PedirNumero();

    int resultado = 0;
    switch (eleccion)
    {
        case 1: 
            resultado = sumar(a, b);
            break;
        case 2: 
            resultado = restar(a, b);
            break;
        case 3: 
            resultado = multiplicar(a, b);
            break;
        case 4: 
            if (b != 0) resultado = dividir(a, b);
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
        continuar = PedirNumero();
    
} while (continuar == 1);

static int PedirNumero()
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

static int sumar(int n1, int n2)
{
    int resultado = n1+n2;
    return resultado;
}

static int restar(int n1, int n2)
{
    int resultado = n1-n2;
    return resultado;
}

static int multiplicar(int n1, int n2)
{
    int resultado = n1*n2;
    return resultado;
}

static int dividir(int n1, int n2)
{
    int resultado = n1/n2;
    return resultado;
}




