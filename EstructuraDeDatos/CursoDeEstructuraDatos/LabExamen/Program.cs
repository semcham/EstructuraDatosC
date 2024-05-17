// pedir los lados de un rectangulo y dibujar en pantalla
using static System.Runtime.InteropServices.JavaScript.JSType;

Console.Write("Ingrese el lado menor del rectangulo:  ");
double ladoMenor = double.Parse(Console.ReadLine());
Console.Write("Ingrese el lado mayor del rectangulo: ");
double ladoMayor = double.Parse(Console.ReadLine());
Console.WriteLine("El rectangulo dibujado con las respectivas dimensiones es : ");
for (int i = 0; i < ladoMayor; i++)
{
    for (int j = 0; j < ladoMenor; j++)
    {
        // Si estamos en la primera o última fila, o en la primera o última columna, dibujamos "*"
        if (i == 0 || i == ladoMayor - 1 || j == 0 || j == ladoMenor - 1)
        {
            Console.Write("*");
        }
        else
        {
            Console.Write("*");
        }
    }
    Console.WriteLine(); 
}


// pedir un numero y contruir un exagono
Console.Write("Ingrese un numero : ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine($"El exagono de numero {n} en pantalla es: ");
for (int i = 0; i <n*2-1; i++)
{
    int NumCaracteresFilaActual = i < n ? i + n : n * 3 - 2 - i;
    int Espacios = (n*3-1-NumCaracteresFilaActual)/2;
    for (int j = 0;j < Espacios;j++)
    {
        Console.Write(" ");
    }
    for (int j = 0;j< NumCaracteresFilaActual; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine("");

}
//equivalencia de numeros romanos 
Console.WriteLine("Convertir un número  a una equivalencia romana");
Console.Write("Seleccione la opcion  (1 ): ");
int opcion = int.Parse(Console.ReadLine());

if (opcion == 1)
{
    Console.Write("Ingrese un numero entero : ");
    int numero = int.Parse(Console.ReadLine());
    string resultado = convertirNumeroRomano(numero);
    Console.WriteLine($"El número  {numero} es equivalente a {resultado} en romano.");
}
else
{
    Console.WriteLine("ERROR. Ingrese nuevamente un numero dentro del rango indicado....!!");
}
Dictionary<char, int> valoresRomanos = new Dictionary<char, int>()
{
     {'I', 1}, {'V', 5}, {'X', 10}, {'L', 50}, {'C', 100}, {'D', 500}, {'M', 1000}

};
string convertirNumeroRomano(int numero)
{

    string[] simbolosRomanos = { "I", "IV", "V", "IX", "X", "XL", "L", "XC", "C", "CD", "D", "CM", "M" };
    int[] valoresNmericos = { 1, 4, 5, 9, 10, 40, 50, 90, 100, 400, 500, 900, 1000 };

    string resultado = "";
    for (int i = simbolosRomanos.Length - 1; i >= 0; i--)
    {
        while (numero >= valoresNmericos[i])
        {
            resultado += simbolosRomanos[i];
            numero -= valoresNmericos[i];
        }
    }
    return resultado;

}
//Registrar una matriz y ordenar ,mostar el original y la ordenada 

Console.Write("Ingrese el numero de filas :");
int filas = int.Parse(Console.ReadLine());

Console.Write("Ingrese el numero de columnas :");
int columnas = int.Parse(Console.ReadLine());
double[,] matrizA= new double[filas, columnas];
for (int i = 0; i < filas; i++)
{
    for (int j = 0; j < columnas; j++)
    {
        Console.WriteLine($"Ingrese el elemento de la matrizA[{i}, {j}] : ");
        matrizA[i,j] = double.Parse(Console.ReadLine());
    }
}
Console.WriteLine("Mostra matriz original");



double MostraMatrizOriginal(double[,] matrizA)
{

    int filas = matrizA.GetLength(0);
    int columnas = matrizA.GetLength(1);

    for (int i = 0; i < filas; i++)
    {
        for (int j = 0; j < columnas; j++)
        {
            Console.Write(matrizA[i, j] + "\t");
        }
        Console.WriteLine();
    }
    return 0;


}
double ordenarMatriz(double[,] matrizA)
{
    int filas = matrizA.GetLength(0);
    int columnas = matrizA.GetLength(1);

    double[] elementos = new double[filas * columnas];
    int k = 0;

    for (int i = 0; i < filas; i++)
    {
        for (int j = 0; j < columnas; j++)
        {
            elementos[k++] = matrizA[i, j];
        }
    }

    // Ordenar el arreglo
    Array.Sort(elementos);

    k = 0;

    for (int i = 0; i < filas; i++)
    {
        for (int j = 0; j < columnas; j++)
        {
            matrizA[i, j] = elementos[k++];
            Console.Write(matrizA[i, j] + "\t");
            
        }Console.WriteLine();
    }
    return 0;

}
Console.WriteLine("Mostra matriz original");
MostraMatrizOriginal(matrizA);
Console.WriteLine("Mostra matriz ordenada");
ordenarMatriz(matrizA);



















