/*
 * Author {D}
 * 
 * 
 Escribir un programa que haga lo siguiente:

1) Borrar la pantalla.
2) Pedir el nombre de una persona.
3) Saludarlo con un texto que diga "¡Hola [NombreIngresado]!"
4) Preguntar si se quiere continuar.
5) Si la respuesta es "S" repetir desde el punto 1.
6) Si la respuesta es "N" finalizar el programa mostrando un mensaje que diga "Programa finalizado correctamente".
7) Si la respuesta no es ni "S" ni "N" que tambien finalice el programa, pero mostrando un mensaje que diga "Opcion no valida"
 * */

Console.Clear();
Console.WriteLine("\n Ingresa tu nombre: ");
string nombre = Console.ReadLine();
Console.WriteLine($"¡Hola {nombre}!");
Console.WriteLine("¿Deseas continuar? {S/N}");
string respuesta=Console.ReadLine();
while (respuesta=="S")
{
    Console.Clear();
    Console.WriteLine("\n Ingresa tu nombre: ");
    nombre = Console.ReadLine();
    Console.WriteLine($"¡Hola {nombre}!");

    Console.WriteLine("¿Deseas continuar? {S/N}");
    respuesta = Console.ReadLine();
}
if (respuesta == "N")
{
    Console.WriteLine("\n Programa finalizado correctamente");
}
else
{
    Console.WriteLine("\n Opcion no válida");
}