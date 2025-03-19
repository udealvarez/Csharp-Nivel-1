namespace Funciones_Intro;

class Program
{
    static void Main(string[] args)     // FUNCION PRINCIPAL  - >  MAIN
    {
        // FUNCIONES -> ES UN BLOQUE DE CODIGO, MINI PROGRAMA

        // Partes de la funcion
            // CABECERA
                // 1. Tipo de dato
                // 2. Nombre
                // 3. Opcional: Parametros (datos que le podemos dar o no a la funcion para que trabaje)
            
            // CUERPO
                // 1. Definicion / logica de la funcion (que hace la funcion, el algoritmo)
                // 2. Opcional: Retorno de valor / resultado
        
        
        int Resultado = devolverUno();        
        Console.WriteLine(Resultado);
        
        //    Console.WriteLine(devolverUno()); -> esta es otra forma de escribir lo mismo de las lineas 20 y 21
    
    }


    static int devolverUno(){       // CABECERA DE LA FUNCION

        int nro = 1;

        return nro;

    }
}
