
double d, v, t;
Console.Write("Ingrese la velocidad constante: ");
v = double.Parse(Console.ReadLine());
Console.Write("Ingrese el tiempo: ");
t = double.Parse(Console.ReadLine());
d = v * t;
Console.WriteLine("La distancia es : " + d);


//promedio
double n1, n2, n3, p;
Console.Write("La primera nota parcial  : ");
n1 = double.Parse(Console.ReadLine());
Console.Write("La segunda nota parcial  : ");
n2 = double.Parse(Console.ReadLine());
Console.Write("La tercera nota parcial : ");
n3 = double.Parse(Console.ReadLine());
p = (n1 + n2 + n3) / 3;
Console.Write("El promedio final :{0}", p);
Console.ReadLine();


