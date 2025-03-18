namespace Ejemplo_Vectores4;

class Program
{
    static void Main(string[] args)
    {
        // CADENA DE CARACTERES

        // STRING -> no es lo mismo -> CADENA DE CARACTERES -> y esto no es lo mismo que -> VECTOR DE CHAR
        // CADENA DE CARACTERES termina con un \0
        // VECTOR termina con la ultima posicion del vector

        // TIPOS DE DATOS USADOS HASTA EL MOMENTO -> int, double, float, bool, char

        char[] nombre = new char[11];

        char letra;
        int indice = 0;

        Console.WriteLine("Ingrese su nombre letra por letra: .... (termina con un ( . ) punto)");
        letra = char.Parse(Console.ReadLine());


        while (letra != '.' && indice < 10)
        {
            nombre[indice] = letra;

            letra = char.Parse(Console.ReadLine());
            indice++;

        }

        nombre[indice] = '\0';      //                  \0  -> simbolo especial, le da fin a una cadena de caracteres

        Console.Write("Hola.. ");                       // WRITE LINE -> ESCRIBE UNA LINEA
        indice = 0;

        while (nombre[indice] != '\0')                  // este caso es hasta que la cadena de caracteres termine
        {
            Console.Write(nombre[indice]);              // WRITE -> SOLO ESCRIBE
            indice++;
        }

    }
}
