namespace Funciones_Ejemplo_Parametros2;

class Program
{
    static void Main(string[] args)
    {
        int num1 = 0, num2 = 0, resultado;

        pedirDatos(ref num1, ref num2);                 // Argumentos con referencia

        resultado = sumar(num1, num2);                  // Argumentos                        

        Console.WriteLine("El resultado es: " + resultado);
    }

    static int sumar(int a, int b){                     // Parametros 
                  
        int r;
        r = a + b;
        return r;
    }


    static void pedirDatos(ref int N1, ref int N2){     // Parametros por REFERENCIA
        
        Console.WriteLine("Ingrese un numero: ");
        N1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese un numero: ");
        N2 = int.Parse(Console.ReadLine());
    }

    /*
        Parametros por referencia y parametros por valor

        REF
        Tanto la variable num1 como la variable N1 apuntan a la misma direccion de memoria, son 2 nombres distintos
        para la misma direccion de memoria. 

        VALOR
        En el caso del pasaje por valor son 2 variables completamente distintas, con direcciones de memoria
        completamente distintas. NUM1 tiene una direccion de memoria y N1 es la copia de NUM1 pero con otra direccion
        de memoria.
    */
}
