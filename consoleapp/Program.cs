using Humanizer;

Console.Write("Por favor ingrese un nombre epico!!: ");
var nombre = Console.ReadLine();
Console.Write("Por favor ingrese su cargo en la empresa!!: ");
var cargo = Console.ReadLine();
Console.Write("Por favor ingrese tu edad!!: ");
var edad = int.Parse(Console.ReadLine());

Console.WriteLine($"Mi nombre es: {nombre} y mi cargo es: {cargo} y tengo: {edad.ToWords(new System.Globalization.CultureInfo("es"))} años");