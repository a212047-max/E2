
using System;
namespace E2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 1.
            tipo_dato identificador_funcion(parametros)
            {
                Bloque de instrucciones
            }
            */

            // 2.
            int numero = 2;
            int incremento = 2;

            Console.WriteLine($"numero: {numero}");

            for (int i = 1; i <= 8; i++)
            {
                numero += incremento;
                Console.WriteLine($"numero: {numero}");

                if (i == 2 || i == 5)
                {
                    incremento++;
                }
            }

            Console.WriteLine();

            // 3.
            int inicio = 2;
            int limite = 1;

            if (inicio * limite < 8 && inicio > limite)
            {
                int contador = inicio;

                for (int i = 1; i <= 9; i++)
                {
                    Console.WriteLine($"{contador}");
                    contador--;
                }
            }
            else
            {
                Console.WriteLine("Condicion falsa.");
            }

            // 4. Definicion
            bool EsMultiploDe5(int numero)
            {
                return numero % 5 == 0;
            }

            // Invocacion
            bool devolucion;
            devolucion = EsMultiploDe5(10);

            Console.WriteLine($"Devolucion: {devolucion}");

            // 5. Definicion
            void Examen(string materia)
            {
                Console.WriteLine($"Examen: {materia}");
            }
            Examen("Programación III");
        }
    }
}
