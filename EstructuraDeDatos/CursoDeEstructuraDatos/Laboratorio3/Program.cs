
Console.WriteLine("=====calcular si el numero es par o impar=====");
Console.Write("INGRESE UN NUMERO ENTERO: ");
var numeroRecibido = Console.ReadLine();
var numero = int.Parse(numeroRecibido);
var esPar = false;
if (numero%2 == 0)
{
    esPar = true;
}
Console.WriteLine(esPar?"ES PAR":"ES IMPAR");
Console.ReadLine();















/*

//Calcular la distancia
double d, v, t;
Console.Write("Ingrese la velocidad constante: ");
v = double.Parse(Console.ReadLine());
Console.Write("Ingrese el tiempo: ");
t = double.Parse(Console.ReadLine());
d = v * t;
Console.WriteLine("La distancia es : " + d);

Console.WriteLine("======calcular si un numero es par o impar=====");





//promedio final
double n1, n2, n3, p;
Console.Write("La primera nota parcial  : ");
n1 = double.Parse(Console.ReadLine());
Console.Write("La segunda nota parcial  : ");
n2 = double.Parse(Console.ReadLine());
Console.Write("La tercera nota parcial : ");
n3 = double.Parse(Console.ReadLine());
p = (n1 + n2 + n3) / 3;
Console.Write("El promedio final :{0}", p);
if (p >= 10.5)
{
    Console.WriteLine("Estas aprobado del curso..");
}
else
{
    Console.WriteLine("Estas desaprobado del curso..");

}
Console.ReadLine();

*/
