using System;
// Espacio de nombres
namespace CS5
{
   class Program
   {
        static void Main(string[] args)
        {
            // Unidad 1: Estructuras de control II
            // Unidad 2: Funciones II
            // Sesion 12: Instruccion while 30092026
            // Sintaxis: while
            // inicializacion;
            // while(expresion)
            // {
            //       Bloque de instrucciones
            //       iterador;
            // }
            // Iterar: repetir
            // Ejemplo 1: Ciclo ascendente (rango: 1-3)
            int m = 1; // Inicializacion
            while(m <= 3)
            {
                // Bloque de instrucciones
                m += 1;
                Console.WriteLine($"m: {m}");
                m += 1; // Iterador
            }

            {
                //definir un ciclo para imprimir tu nombre 5 veces
                //Nota: para la expresion, usar menor que <
                int n = 1; // Inicializacion
                while(n < 6) // Expresion
            }
            {
                Console.WriteLine($"Nombre: Diego");
                n +=1;
            }

            //b. Ciclo descendente
            int d = 3;
            while(d >=1)
            {
                Console.WriteLine($"i:{i}");
                d -= 1; //Iterador
            }

            // c. Incrementos
            //secuencia: 3, 6, 9, 12, 15, 18
            int i = 3;
            while(i <= 18)
            {
                Console.WriteLine($"i:{i}");
                i += 3; // Iterador
            }
            // d. Decrementos
            // Ejercitacion
            // 1. Definir un ciclo para imprimir "331" 8 veces
            // Nota: Para la solucion, definir un ciclo descendente con decrementos de 2 unidades
            int a = 64;


            while (a >= 8)
            {
                Console.WriteLine("331");
                a -= 8;
            }
            // Actividad 1 :Ciclo infinito
            // 1. Definir un ciclo infinito ascendente.
            int r = 50;
            while( r > 0)
            {
                Console.WriteLine($"r: {r}");
                r += 1;
            }
            // 2. Definir un ciclo infinito descendente.
            // Nota: Para la solucion, Utilizar el operador de diferencia.
            int h = 67;
            while(h != 0)
            {
                Console.WriteLine($"h: {h}");
                h -=2;
            }
        }
   }
}
