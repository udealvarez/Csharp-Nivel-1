namespace Ejercicio_3;

class Program
{
    static void Main(string[] args)
    {
        /*
            Hacer un programa que solicite una cadena de caracteres y dos caracteres sueltos (tres ingresos). 
            El programa deberá generar una cadena donde todas las ocurrencias del primer carácter dado hayan sido reemplazadas por el segundo. 
            Mostrar el resultado en pantalla. Ejemplo:

            CADENA FUENTE: “La mar estaba serena"
            CARÁCTER 1: ‘a’ CARÁCTER 2: ‘i’
            CADENA RESULTADO: “Li mir estibi sereni"
        */

        string cadena, nuevaCadena = "";
        char caracterA, caracterB;

        Console.WriteLine("Ingrese la cadena de caracteres: ");
        cadena = Console.ReadLine();

        Console.WriteLine("Ingrese el primer caracter para reemplazar: ");
        caracterA = char.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el segundo caracter para ser reemplazado: ");
        caracterB = char.Parse(Console.ReadLine());

        for (int i = 0; i < cadena.Length; i++)
        {
            if (cadena[i] == caracterA)
            {
                nuevaCadena += caracterB;     // reemplazo de caracter
            }else{
                nuevaCadena += cadena[i];
            }
        }

        Console.WriteLine("Resultado: " + nuevaCadena);

    }
}
