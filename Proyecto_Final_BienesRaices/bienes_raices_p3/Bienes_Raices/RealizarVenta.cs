using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;

namespace Bienes_Raices
{
    class RealizarVenta
    {
        //Variables
        ArrayList BuscarLocalidad = new ArrayList();
        string romperRegistro;
        string respuesta;

        public void GuardarVenta(string usuario, int movimiento, string idVR, string archivoBuscar)
        {
            //string usuario = (nom + "," + sgn + "," + apell + "," + "," + correo + "," + cel + "," + tel + "," + pais + "," + estado + "," + archivo + "," + idVR);

            TrabajarArchivo TA = new TrabajarArchivo();
            
            //1 - RentaCasas, 2 - Renta Departamento, 3 - Venta Casas, 4 - Venta Departamento
            if (archivoBuscar == "1")
            {
                BuscarLocalidad = TA.LeerArchivo(1);
                string[,] RRC = new string[BuscarLocalidad.Count, 20];

                //usuario - es la informacion del cliente, movimiento - es el numero del archivo a leer, idVR - es el id de la localidad

                for (int i = 0; i < BuscarLocalidad.Count; i++)
                {
                    romperRegistro = (String)BuscarLocalidad[i];
                    String[] datoRegistro = romperRegistro.Split(',');

                    for (int j = 0; j < datoRegistro.Length; j++)
                    {
                        RRC[i, j] = datoRegistro[j];

                    }

                }

                for (int i = 0; i < BuscarLocalidad.Count; i++)
                {
                    if (RRC[i, 0] == idVR)
                    {
                        if (RRC[i, 1] == "false")
                        {
                            RRC[i, 1] = "true";
                        }
                    }
                }

                respuesta = TA.EscribirArchivo(BuscarLocalidad, movimiento);
                MessageBox.Show("Compra realizada" + respuesta);

            }
            else if(archivoBuscar == "2")
            {
                BuscarLocalidad = TA.LeerArchivo(2);
                string[,] RRC = new string[BuscarLocalidad.Count, 22];

                //usuario - es la informacion del cliente, movimiento - es el numero del archivo a leer, idVR - es el id de la localidad

                for (int i = 0; i < BuscarLocalidad.Count; i++)
                {
                    romperRegistro = (String)BuscarLocalidad[i];
                    String[] datoRegistro = romperRegistro.Split(',');

                    for (int j = 0; j < datoRegistro.Length; j++)
                    {
                        RRC[i, j] = datoRegistro[j];

                    }

                }

                for (int i = 0; i < BuscarLocalidad.Count; i++)
                {
                    if (RRC[i, 0] == idVR)
                    {
                        if (RRC[i, 1] == "false")
                        {
                            RRC[i, 1] = "true";
                        }
                    }
                }

                respuesta = TA.EscribirArchivo(BuscarLocalidad, movimiento);
                MessageBox.Show("Compra realizada" + respuesta);
            }
            else if (archivoBuscar == "3")
            {
                BuscarLocalidad = TA.LeerArchivo(3);
                string[,] RRC = new string[BuscarLocalidad.Count, 20];

                //usuario - es la informacion del cliente, movimiento - es el numero del archivo a leer, idVR - es el id de la localidad

                for (int i = 0; i < BuscarLocalidad.Count; i++)
                {
                    romperRegistro = (String)BuscarLocalidad[i];
                    String[] datoRegistro = romperRegistro.Split(',');

                    for (int j = 0; j < datoRegistro.Length; j++)
                    {
                        RRC[i, j] = datoRegistro[j];

                    }

                }

                for (int i = 0; i < BuscarLocalidad.Count; i++)
                {
                    if (RRC[i, 0] == idVR)
                    {
                        if (RRC[i, 1] == "false")
                        {
                            RRC[i, 1] = "true";
                        }
                    }
                }

                respuesta = TA.EscribirArchivo(BuscarLocalidad, movimiento);
                MessageBox.Show("Compra realizada"+respuesta);
            }
            else if (archivoBuscar == "4")
            {
                BuscarLocalidad = TA.LeerArchivo(4);
                string[,] RRC = new string[BuscarLocalidad.Count, 22];

                //usuario - es la informacion del cliente, movimiento - es el numero del archivo a leer, idVR - es el id de la localidad

                for (int i = 0; i < BuscarLocalidad.Count; i++)
                {
                    romperRegistro = (String)BuscarLocalidad[i];
                    String[] datoRegistro = romperRegistro.Split(',');

                    for (int j = 0; j < datoRegistro.Length; j++)
                    {
                        RRC[i, j] = datoRegistro[j];

                    }

                }

                for (int i = 0; i < BuscarLocalidad.Count; i++)
                {
                    if (RRC[i, 0] == idVR)
                    {
                        if (RRC[i, 1] == "false")
                        {
                            RRC[i, 1] = "true";
                        }
                    }
                }

                respuesta = TA.EscribirArchivo(BuscarLocalidad, movimiento);
                MessageBox.Show("Compra realizada: "+respuesta);
            }

        }



    }
}
