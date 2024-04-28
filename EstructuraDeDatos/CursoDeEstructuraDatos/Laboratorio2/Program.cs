
////Desarrollo y Actividades 
////Ejercicio parte 01: 
////Operaciones Básicas: 
////1) Realiza la suma, resta, multiplicación y división de dos números ingresados por el usuario. 

////declaracion 
//double n1, n2, suma, resta, multiplicacion, division;
//Console.Write("Ingrese el primer numero entero: ");
//n1 = double.Parse(Console.ReadLine());
//Console.Write("Ingrese el segundo numero entro: ");
//n2 = double.Parse(Console.ReadLine());
////Resolucion
//suma = n1 + n2;
//resta = n1 + n2;
//multiplicacion = n1* n2;
//if (n2 != 0)
//{
//    division = n1 / n2;
//}
//else
//{
//    Console.WriteLine("No se puede dividir entre cero.");
//}

////resultados
//Console.WriteLine($"La suma es : {suma}");
//Console.WriteLine($"La resta es : {resta}");
//Console.WriteLine($"La multiplicacion es : {multiplicacion}");
//Console.WriteLine($"La division es : {division}");




//
//Verificación de Número Par o Impar: 
//2) Solicita un número al usuario y determina si es par o impar. 
/*
Console.WriteLine("Ingrese un numero entero: ");
int n = Int32.Parse(Console.ReadLine());
if (n % 2 == 0)
{
    Console.WriteLine($"El numero {n} es par. ");
}
else
{

    Console.WriteLine($"El numero {n} es Impar. ");
}
*/
//Área de un Triángulo: 
//3) Pide la base y la altura de un triángulo al usuario y calcula su área. 
/*
Console.WriteLine("Ingrese la base: ");
double b = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese la altura: ");
double h = double.Parse(Console.ReadLine());
double area = (b * h) / 2;
Console.WriteLine($"El Area  es : {area} ");
*/







//Calculadora de Factorial: 
//4) Crea una función que calcule la factorial de un número. 

Console.Write("Ingrese un numero entero: ");
long n = long.Parse(Console.ReadLine());
int factorial = 1;
if (n == 0)
{
    factorial = 1;
}
else
{
    for (int i = 1; i <= n; i++)
    {
        factorial *= i;
    }
}
Console.WriteLine($"El facrorial del numero {n} es : {factorial}");
Console.ReadLine();


















//Número Primo: 
//5) Verifica si un número ingresado por el usuario es primo o no. 
/*
using System;
using System.Diagnostics.CodeAnalysis;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class esPrimo
{
    public static void Main()
    {
        Console.WriteLine("Ingrese un numero entero: ");
        int n = Int32.Parse(Console.ReadLine());
        bool esPrimo = true;
        for (int i = 2; i < n && esPrimo; i++)
        {
            if(n % i == 0)
            {
                esPrimo = false;
            }
            
        }
        Console.WriteLine($"{n} {(esPrimo ? "es un número primo" : "no es un número primo")}.");
    }

}
*/



//Inversión de Cadena: 
//6) Toma una cadena de texto y muestra su inversión and 12
/*
public class InvertirTexto
{
    public static void Main()
    {
        Console.WriteLine("Ingrese una cadena de  texto: ");
        string texto = Console.ReadLine();
        int n = texto.Length - 1;
        string TextoInvertido = "";
        while (n >= 0)
        {
            TextoInvertido = TextoInvertido + texto[n];
            n = n - 1;
        }
        Console.WriteLine($"El texto invertido es : {TextoInvertido}");
        if (texto == TextoInvertido)
        {
            Console.WriteLine($"La palabra '{texto}' es palindromo");
        }
        else
        {

            Console.WriteLine($"La palabra {texto} no es palindromo");
        }
    }   
}
*/

//Suma de Números Pares: 
//7) Calcula la suma de los números pares en un rango especificado por el usuario. 
/*
public class SumaPares
{
    public static void Main()
    {
        Console.WriteLine("Ingrese un numero entero: ");
        int n = Int32.Parse(Console.ReadLine());
        int suma = 0;
        for (int i = 1; i <= n; i++)
        {
            if (i % 2 == 0)
            {
                suma += i;
            }
            
        }
        Console.WriteLine($"La suma es : {suma}");
    }
}
*/


