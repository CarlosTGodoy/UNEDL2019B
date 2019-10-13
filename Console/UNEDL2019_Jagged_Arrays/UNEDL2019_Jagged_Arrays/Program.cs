using System;

namespace UNEDL2019_Jagged_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,,] alumnosUnedl = new int[8, 20, 6];
            int suma=0;
            float promedio;
            int semestre, alumno;
            int[] calificaciones = { 5, 6, 7, 8, 9, 10 };
            String[] materias = { "Español", "Matemáticas", "Programación", "Taller", "Inglés", "Bases de datos" };
            Random random = new Random();

            //Ingresamos valores
            for(int i = 0; i < 8; i++)
            {
                for(int j = 0; j < 20; j++)
                {
                    for(int k = 0; k < 6; k++)
                    {
                        alumnosUnedl[i,j,k] = calificaciones[random.Next(0, 5)];
                    }
                }
            }

            //Inicio para ingreso de valores
            Console.WriteLine(" ------------- Lista de alumnos UNEDL 2019 ------------------ ");
            Console.WriteLine("Son 8 semestres, 7 Materias y cada salon cuenta con 20 alumos");
            do
            {
                Console.WriteLine("Ingresa el semestre del alumno: ");
                semestre = int.Parse(Console.ReadLine());
            } while (semestre < 1 || semestre > 8);
            do
            {
                Console.WriteLine("Ingresa el número del alumno: ");
                alumno = int.Parse(Console.ReadLine());
            } while (alumno < 1 || alumno > 20);

            //Imprimimos los valores dados
            Console.WriteLine("Alumno: " + alumno + " - Semestre: " + semestre);

            //Cambiamos los valores ingresadops a los aocmodos de nuestra matriz
            int cont = 0;
            for(int i = 1; i <= 8; i++)
            {
                if (semestre == i)
                {
                    semestre = cont;
                    break;
                }
                cont++;
            }
            cont = 0;
            for(int i = 1; i <= 20; i++)
            {
                if (alumno == i)
                {
                    alumno = cont;
                    cont++;
                }
                cont++;
                
            }

            //Imprimimos las materias con sus respectivas calificaciones y el promedio
            for (int k = 0; k < 6; k++)
            {
                Console.WriteLine(materias[k] + ": " + alumnosUnedl[semestre, alumno, k]);
                suma += alumnosUnedl[semestre, alumno, k];

            }
            Console.WriteLine("Promedio: " + suma / 6);
        }
    }
}
