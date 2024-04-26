
public class Contador_De_Vocales
{
    public static void Main()
    {
        Console.WriteLine("Ingrese un texto : ");
        string texto = Console.ReadLine();
        int contador = 0;
        int letra ;
        for (int i = 0; i < texto.Length; i++)

        {
            letra = texto[i];
            if ((letra =='a') || (letra == 'e') || (letra == 'i') || (letra == 'o') || (letra == 'u'))
            {
                contador ++;
            }
        }
        Console.WriteLine("EL numero de vocales es :" + contador);

    }

}