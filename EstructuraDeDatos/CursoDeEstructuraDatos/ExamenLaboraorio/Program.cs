//Generar una torre triangular de cualquier numero de 20 pisos


Console.Write("Ingrese el numero de pisos: ");
int n = int.Parse(Console.ReadLine());
for (int i = 1; i <= n; i++)
{
    string f = new String(' ', n-i); 
    for (int j = 1; j <= i; j++)
    {
        f += j + "    "; 
    }
    Console.WriteLine(f);
}


//2. crear y asignas valores a una matriz de 4 dimensiones
double[,,,] Matriz4D = new double[3, 3, 3, 3];
Random t = new Random();
Console.WriteLine("Matriz de 4 dimenciones ");
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        for (int k = 0; k < 3; k++)
        {
            for (int l = 0; l < 3; l++)
            {
                Matriz4D[i, j, k, l] = t.Next(1, 200);
            }
        }
    }
}

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        for (int k = 0; k < 3; k++)
        {
            for (int l = 0; l < 3; l++)
            {
                Console.WriteLine($"matriz4D[{i},{j},{k},{l}] = {Matriz4D[i, j, k, l]}");
            }
        }
    }
}

//3. Crear una matriz que guarde los 50 primeros números primos y
//luego mostrar en pantalla entre comas
int[] NumeroPrimos = new int[50];
int numero = 2;
int contador =0;
Console.Write("los 50 Primeros Primos son : "); 
bool esprimo(int numero)
{
    for (int i = 2; i < n; i++)
    {
        if (numero % i == 0)
        {
            return false;
        }
    }
    return true;
}

while (contador < 50)
{
    if (esprimo(numero))
    {
        NumeroPrimos[contador] = numero;
        contador++;
    }
    numero++;
}

foreach (int i in NumeroPrimos)
{
    Console.Write(i + ", ");
}


//4. ingresar el numero de inicio y fin de un rango de números, se pide
//calcular la cantidad de números pares e impares divisores en 3,5,7
Console.Write("Ingrese el número de inicio del rango: ");
int inicio = int.Parse(Console.ReadLine());

Console.Write("Ingrese el número de fin del rango: ");
int fin = int.Parse(Console.ReadLine());

int paresDivisibles = 0;
int imparesDivisibles = 0;

for (int i = inicio; i <= fin; i++)
{
    if (i % 2 == 0)
    {
        if (i % 3 == 0 || i % 5 == 0 || i % 7 == 0)
        {
            paresDivisibles++;
        }
    }
    else
    {
        if (i % 3 == 0 || i % 5 == 0 || i % 7 == 0)
        {
            imparesDivisibles++;
        }
    }
}

Console.WriteLine("Cantidad de números pares divisibles entre 3, 5 o 7: " + paresDivisibles);
Console.WriteLine("Cantidad de números impares divisibles entre 3, 5 o 7: " + imparesDivisibles);