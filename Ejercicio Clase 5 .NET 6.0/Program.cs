/*
 1) Borrar la pantalla.
2) Pedir el nombre de una persona.
3) Saludarlo con un texto que diga "¡Hola [NombreIngresado]!"
4) Preguntar si se quiere continuar.
5) Si la respuesta es "S" repetir desde el punto 1.
6) Si la respuesta es "N" finalizar el programa mostrando un mensaje que diga "Programa finalizado correctamente".
7) Si la respuesta no es ni "S" ni "N" que tambien finalice el programa, pero mostrando un mensaje que diga "Opcion no valida".
*/

string respuesta = "S";

while (respuesta.ToUpper() == "S") // 5
{
    Console.Clear(); // 1

    Console.WriteLine("Inserte su nombre completo aquí por favor");

    string nombre = Console.ReadLine(); // 2

    Console.WriteLine("Hola " + nombre); // 3

    Console.WriteLine("¿Desea continuar? (S/N)"); // 4

    respuesta = Console.ReadLine();
}

if (respuesta.ToUpper() == "N") // 6
{
    Console.WriteLine("Programa finalizado correctamente");
}

else { Console.WriteLine("Opción no válida"); }