using System;

namespace Examen_ecuaciones

{
    using System.Collections;
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese ");
            String ecuacion = Console.ReadLine();

            Stack evaluarEcuacion = new Stack();

            for (int i = 0; i < ecuacion.Length; ++i)
            {
                if ((ecuacion[i] == '(') || (ecuacion[i] == '{') || (ecuacion[i] == '['))
                {
                    evaluarEcuacion.Push(ecuacion[i]);
                }
                else if (evaluarEcuacion.Count > 0)
                {
                    switch (ecuacion[i])
                    {
                        case ']':   evaluarEcuacion.Pop();
                                    break;
                        case '}':   evaluarEcuacion.Pop();
                            break;
                        case ')':   evaluarEcuacion.Pop();
                            break;
                    }
                }
            }
            if (evaluarEcuacion.Count == 0)
            {
                Console.WriteLine("Ecuacion equilibrada");
            }
            else
            {
                Console.WriteLine("Ecuacion no equilibrada");
            }
        }
    }
}
