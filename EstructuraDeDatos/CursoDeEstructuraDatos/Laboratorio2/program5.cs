// lista de cuadrados
List<int> listaCuadrados = new List<int>();

for (int i = 1; i < 11; i++) listaCuadrados.Add(i * i);

foreach (var dato in listaCuadrados) Console.WriteLine($"Elemento de lista: {dato}");