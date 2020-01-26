using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;
using System.Windows.Forms;
using System.Diagnostics;

namespace Bienes_Raices
{
    class TrabajarArchivo
    {
        //Método para Leer el archivo completo
        //Recibe un valor "archivo" para saber con que archivo trabajará
        //1 - Renta Casas, 2 - Renta Departamento, 3 - Venta Casas, 4 - Venta Departamento, 5- Registros
        public ArrayList LeerArchivo(int archivo)
        {
            //Variables
            String line;
            String lectura;
            String lineaLeida;
            ArrayList reg = new ArrayList();

            //Ubicación del archivo
            String archivoUtilizar = "";
            if (archivo == 1)
            {
                archivoUtilizar = (String)@"C:\txtbienesraices\Rentas\CasasR.txt";
            }
            else if (archivo == 2)
            {
                archivoUtilizar = (String)@"C:\txtbienesraices\Rentas\DepartamentosR.txt";
            }
            else if (archivo == 3)
            {
                archivoUtilizar = (String)@"C:\txtbienesraices\Ventas\Casas.txt";
            }
            else if (archivo == 4)
            {
                archivoUtilizar = (String)@"C:\txtbienesraices\Ventas\Departamentos.txt";
            }
            else if(archivo == 5)
            {
                archivoUtilizar = (string)@"C:\txtbienesraices\Registros\Registros.txt";
            }

            //Almacenamos valores en una lista
            using (StreamReader fileRead = new StreamReader(archivoUtilizar))
            {
                while (fileRead.Peek() > -1)
                {
                    reg.Add(fileRead.ReadLine());
                }
            }

            return reg;
        }

        private object ReadAllLines(StreamReader fileCount)
        {
            throw new NotImplementedException();
        }

        //Método para agregar información al archivo
        //Recibe un valor "archivo" para saber con que archivo trabajará
        //1 - RentaCasas, 2 - Renta Departamento, 3 - Venta Casas, 4 - Venta Departamento, 5 - NuevoRegistro
        public String EscribirArchivo(ArrayList lista, int archivo)
        {
            string Venta = "";
            int sx;
            for (int x = 0; x < lista.Count; x++)
            {
                if (x == lista.Count - 1)
                {
                    Venta += lista[x];
                }
                else
                {
                    Venta += lista[x] + "\n";
                }

                sx = x;
            }
            //Ubicación del archivo
            String archivoUtilizar = "";
            if (archivo == 1)
            {
                archivoUtilizar = (String)@"C:\txtbienesraices\Rentas\CasasR.txt";
            }
            else if (archivo == 2)
            {
                archivoUtilizar = (String)@"C:\txtbienesraices\Rentas\DepartamentosR.txt";
            }
            else if (archivo == 3)
            {
                archivoUtilizar = (String)@"C:\txtbienesraices\Ventas\Casas.txt";
            }
            else if (archivo == 4)
            {
                archivoUtilizar = (String)@"C:\txtbienesraices\Ventas\Departamentos.txt";
            }
            else if (archivo == 5)
            {
                archivoUtilizar = (String)@"C:\txtbienesraices\Registros\Registros.txt";
            }

            String result;
            StreamWriter Escribir = new StreamWriter(archivoUtilizar);
            try
            {
                Escribir.WriteLine(Venta);
                result = "Guarado con exito";
            }
            catch
            {
                result = "Error";

            }
            Escribir.Close();
            return result;
        }

        //Método para cambiar información ya existente del archivo
        //Recibe un valor "archivo" para saber con que archivo trabajará
        //1 - RentaCasas, 2 - Renta Departamento, 3 - Venta Casas, 4 - Venta Departamento
        public String ActualizarArchivo(String[,] actualizacion, int archivo)
        {
            //Ubicación del archivo
            String archivoUtilizar = "";
            if (archivo == 1)
            {
                archivoUtilizar = (String)@"C:\txtbienesraices\Rentas\CasasR.txt";
            }
            else if (archivo == 2)
            {
                archivoUtilizar = (String)@"C:\txtbienesraices\Rentas\DepartamentoR.txt";
            }
            else if (archivo == 3)
            {
                archivoUtilizar = (String)@"C:\txtbienesraices\Ventas\Casas.txt";
            }
            else if (archivo == 4)
            {
                archivoUtilizar = (String)@"C:\txtbienesraices\Ventas\Departamentos.txt";
            }
            else if (archivo == 5)
            {
                archivoUtilizar = (String)@"C:\txtbienesraices\Registros\Registros.txt";
            }

            ArrayList Buscar = new ArrayList();
            String nuevoDato = "";
            String result;
            Boolean aprobado = false;
            MessageBox.Show(nuevoDato);


            //Variable de escritura
            StreamWriter act = new StreamWriter(archivoUtilizar);
            act.Flush(); //Vaciamos el archivo

            using (StreamReader fileCount = new StreamReader(archivoUtilizar))
            {
                for (int i = 0; i < 7; i++)
                {
                    for (int j = 0; j < 7; j++)
                    {
                        nuevoDato += (String)(actualizacion[i, j] + ",");
                    }

                    try
                    {
                        act.WriteLine(nuevoDato);
                        aprobado = true;
                    }
                    catch
                    {
                        aprobado = false;
                        break;
                    }


                }
            }

            if (aprobado == true)
            {
                return "Actualización Exitosa";
            }
            else
            {
                return "Actualización Fallida";
            }

        }

        //Metodo para eliminar un registro
        //Recibe un valor "archivo" para saber con que archivo trabajará
        //1 - RentaCasas, 2 - Renta Departamento, 3 - Venta Casas, 4 - Venta Departamento
        public String Eliminar(String[,] registromodificado, int archivo)
        {
            //Ubicación del archivo
            String archivoUtilizar = "";
            if (archivo == 1)
            {
                archivoUtilizar = (String)@"C:\txtbienesraices\Rentas\CasasR.txt";
            }
            else if (archivo == 2)
            {
                archivoUtilizar = (String)@"C:\txtbienesraices\Rentas\DepartamentoR.txt";
            }
            else if (archivo == 3)
            {
                archivoUtilizar = (String)@"C:\txtbienesraices\Ventas\Casas.txt";
            }
            else if (archivo == 4)
            {
                archivoUtilizar = (String)@"C:\txtbienesraices\Ventas\Departamentos.txt";
            }
            else if (archivo == 5)
            {
                archivoUtilizar = (String)@"C:\txtbienesraices\Registros\Registros.txt";
            }

            ArrayList Buscar = new ArrayList();
            String nuevoDato = "";
            String result;
            Boolean aprobado = false;
            MessageBox.Show(nuevoDato);

            //Variable de escritura
            StreamWriter act = new StreamWriter(archivoUtilizar);
            act.Flush(); //Vaciamos el archivo

            using (StreamReader fileCount = new StreamReader(archivoUtilizar))
            {
                for (int i = 0; i < 7; i++)
                {
                    for (int j = 0; j < 7; j++)
                    {
                        nuevoDato += (String)(registromodificado[i, j] + ",");
                    }

                    try
                    {
                        act.WriteLine(nuevoDato);
                        aprobado = true;
                    }
                    catch
                    {
                        aprobado = false;
                        break;
                    }


                }
            }

            if (aprobado == true)
            {
                return "Se eliminó exitosamente";
            }
            else
            {
                return "Ocurrió un error a la hora de eliminar";
            }
        }
    }
}
