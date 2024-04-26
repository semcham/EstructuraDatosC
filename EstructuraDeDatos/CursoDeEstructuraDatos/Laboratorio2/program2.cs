
public class Sumatoria
{

    public static void Main()
    {
        Console.WriteLine("Ingrese un numero entero : ");
        int numero =  Int32.Parse(Console.ReadLine());
        int Sumatoria = 0;
        for (int i = 0; i <= numero; i++)
        {
            Sumatoria +=i;
        }
        Console.WriteLine($"La sumatoria de los primeros {numero} numeros naturales es : {Sumatoria}");


    }
}
