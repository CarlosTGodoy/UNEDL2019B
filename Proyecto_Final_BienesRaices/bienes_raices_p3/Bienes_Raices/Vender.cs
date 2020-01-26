using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bienes_Raices
{
    public partial class Vender : Form
    {
        public Vender()
        {
            InitializeComponent();
        }


        //Variables Casa
        int a = 0;
        String[,] registrosDisp;
        String[,] lecturaInfoDepto;
        String[,] lecturaInfoUsuario;
        int var = 0;
        int clickAdelante1;

        //Variables Depto
        int b = 0;
        String[,] registrosDisp2;
        String[,] lecturaInfoDepto2;
        String[,] lecturaInfoUsuario2;
        int var2 = 0;
        int clickAdelante2;

        //Lista
        ArrayList registros = new ArrayList();
        ArrayList registros2 = new ArrayList();

        private void Vender_Load(object sender, EventArgs e)
        {
            //Damos los valores de inicio
            pbxCasa.Image = Image.FromFile(@"C:\img\LOGO.png");
            pbxDepto.Image = Image.FromFile(@"C:\img\LOGO.png");
            //Objetoque conecta nuestros archivos
            TrabajarArchivo metodos = new TrabajarArchivo();
            a = 0;
            b = 0;

            //CASA VENTAS
                //Traemos nuestra lista
                //1 - Renta Casas, 2 - Renta Departamento, 3 - Venta Casas, 4 - Venta Departamento
                registros = metodos.LeerArchivo(3);

                //Pasamos todos los registros a una matriz
                String[,] registrosALeer = new String[registros.Count, 20];

                //lecturaInfoUsuario = new String[registros.Count, 5];
                String romperRegistro;
                String CantCampos;

                //Cantidad de registros en true
                for (int i = 0; i < registros.Count; i++)
                {
                    romperRegistro = (String)registros[i];
                    String[] datoRegistro = romperRegistro.Split(',');

                    for (int j = 0; j < datoRegistro.Length; j++)
                    {
                        registrosALeer[i, j] = datoRegistro[j];

                    }

                    if (datoRegistro[1] == "false")
                    {
                        var++;
                    }
                }

                registrosDisp = new String[var, 20];
                //lecturaInfoCasa = new String[var, 20];

                //Pasamos los registros con status "false" a una matriz (El status es la posicion 1)
                for (int i = 0; i < registros.Count; i++)
                {
                    for (int j = 0; j < 20; j++)
                    {
                        if (registrosALeer[i, 1].Equals("false"))
                        {
                            if(var == 1)
                            {
                                registrosDisp[0, j] = registrosALeer[i, j]; //j == false en la posicion 1
                            }
                            else
                            {
                                registrosDisp[i, j] = registrosALeer[i, j]; //j == false en la posicion 1
                            }
                            
                        }
                    }
                }
                clickAdelante1 = var-1;


            //DEPTOS VENTAS
                //Traemos nuestra lista
                //1 - Renta Casas, 2 - Renta Departamento, 3 - Venta Casas, 4 - Venta Departamento
                registros2 = metodos.LeerArchivo(4);

                //Pasamos todos los registros a una matriz
                String[,] registrosALeer2 = new String[registros2.Count, 22];

                //lecturaInfoUsuario = new String[registros.Count, 5];
                String romperRegistro2;
                String CantCampos2;

                //Cantidad de registros en true
                for (int i = 0; i < registros2.Count; i++)
                {
                    romperRegistro2 = (String)registros2[i];
                    String[] datoRegistro2 = romperRegistro2.Split(',');

                    for (int j = 0; j < datoRegistro2.Length; j++)
                    {
                        registrosALeer2[i, j] = datoRegistro2[j];

                    }

                    if (datoRegistro2[1] == "false")
                    {
                        var2++;
                    }
                }

                registrosDisp2 = new String[var2, 22];
                //lecturaInfoCasa = new String[var, 20];

                //Pasamos los registros con status "false" a una matriz (El status es la posicion 1)
                for (int i = 0; i < registros2.Count; i++)
                {
                    for (int j = 0; j < 22; j++)
                    {
                        if (registrosALeer2[i, 1].Equals("false"))
                        {
                            if (var2 == 1)
                            {
                                registrosDisp2[0, j] = registrosALeer2[i, j]; //j == false en la posicion 1
                            }
                            else
                            {
                                registrosDisp2[i, j] = registrosALeer2[i, j]; //j == false en la posicion 1
                            }
                            
                        }
                    }
                }
                clickAdelante2 = var2 - 1;
        }

        String Casa = "";
        String image = "";
        int clickposicion1 = 0;
        string idCasa;
        private void btnAdelante1_Click(object sender, EventArgs e)
        { 
            if (var == 0)
            {
                MessageBox.Show("No existen registros");
            }
            else
            {
                //La variable var contine el registro de las casas en false = disponibles
                if (clickposicion1 <= clickAdelante1)
                {
                    Casa = "";
                    Casa += "ID: " + registrosDisp[clickposicion1, 0] + "\n";
                    idCasa = registrosDisp[clickposicion1, 0]; //Variable para enviar en caso de venta
                    Casa += "Status: " + registrosDisp[clickposicion1, 1] + "\n";
                    Casa += "Tipo: " + registrosDisp[clickposicion1, 2] + "\n";
                    Casa += "Costo: " + registrosDisp[clickposicion1, 3] + "\n";
                    Casa += "Dirección: " + registrosDisp[clickposicion1, 4] + "\n";
                    Casa += "Número: " + registrosDisp[clickposicion1, 5] + "\n";
                    Casa += "Colonia: " + registrosDisp[clickposicion1, 6] + "\n";
                    Casa += "Estado: " + registrosDisp[clickposicion1, 7] + "\n";
                    Casa += "Metros cuadrados: " + registrosDisp[clickposicion1, 8] + "\n";
                    Casa += "Cuartos: " + registrosDisp[clickposicion1, 9] + "\n";
                    Casa += "Baños completos: " + registrosDisp[clickposicion1, 10] + "\n";
                    Casa += "Baños medios: " + registrosDisp[clickposicion1, 11] + "\n";
                    Casa += "Cocina: " + registrosDisp[clickposicion1, 12] + "\n";
                    Casa += "Sala: " + registrosDisp[clickposicion1, 13] + "\n";
                    Casa += "Comedor: " + registrosDisp[clickposicion1, 14] + "\n";
                    Casa += "C. lavado: " + registrosDisp[clickposicion1, 15] + "\n";
                    Casa += "Pisos: " + registrosDisp[clickposicion1, 16] + "\n";
                    Casa += "Cochera: " + registrosDisp[clickposicion1, 17] + "\n";
                    Casa += "Cupos de cochera: " + registrosDisp[clickposicion1, 18] + "\n";
                    image = registrosDisp[clickposicion1, 19];

                    pbxCasa.Image = Image.FromFile(@image);

                    if (clickposicion1 < clickAdelante1)
                    {
                        clickposicion1++;
                    }
                    else if (clickposicion1 == clickAdelante1)
                    {
                        clickposicion1 = 0;
                    }
                }
            }
               
        }

        String Depto = "";
        String image2 = "";
        int clickposicion2 = 0;
        string idDepto;
        private void btnAdelante2_Click(object sender, EventArgs e)
        {
            if (var2 == 0)
            {
                MessageBox.Show("No existen registros");
            }
            else
            {
                //La variable var contine el registro de las casas en false = disponibles
                if (clickposicion2 <= clickAdelante2)
                {
                    Depto = "";
                    Depto += "ID: " + registrosDisp2[clickposicion2, 0] + "\n";
                    idDepto = registrosDisp2[clickposicion2, 0]; //Variable para enviarla en caso de venta
                    Depto += "Status: " + registrosDisp2[clickposicion2, 1] + "\n";
                    Depto += "Tipo: " + registrosDisp2[clickposicion2, 2] + "\n";
                    Depto += "Costo: " + registrosDisp2[clickposicion2, 3] + "\n";
                    Depto += "Piso Depto: " + registrosDisp2[clickposicion2, 4] + "\n";
                    Depto += "Num. Depto: " + registrosDisp2[clickposicion2, 5] + "\n";
                    Depto += "Dirección: " + registrosDisp2[clickposicion2, 6] + "\n";
                    Depto += "Num. ext.: " + registrosDisp2[clickposicion2, 7] + "\n";
                    Depto += "Colonia: " + registrosDisp2[clickposicion2, 8] + "\n";
                    Depto += "Estado: " + registrosDisp2[clickposicion2, 9] + "\n";
                    Depto += "Metros 2: " + registrosDisp2[clickposicion2, 10] + "\n";
                    Depto += "Cuartos: " + registrosDisp2[clickposicion2, 11] + "\n";
                    Depto += "Baños completos: " + registrosDisp2[clickposicion2, 12] + "\n";
                    Depto += "Baños medios: " + registrosDisp2[clickposicion2, 13] + "\n";
                    Depto += "Cocina: " + registrosDisp2[clickposicion2, 14] + "\n";
                    Depto += "Sala: " + registrosDisp2[clickposicion2, 15] + "\n";
                    Depto += "Comedor: " + registrosDisp2[clickposicion2, 16] + "\n";
                    Depto += "C. lavado: " + registrosDisp2[clickposicion2, 17] + "\n";
                    Depto += "P. Casa: " + registrosDisp2[clickposicion2, 18] + "\n";
                    Depto += "Cochera: " + registrosDisp2[clickposicion2, 19] + "\n";
                    Depto += "Cupos: " + registrosDisp2[clickposicion2, 20] + "\n";
                    image2 = registrosDisp2[clickposicion2, 21];

                    pbxDepto.Image = Image.FromFile(@image2);

                    if (clickposicion2 < clickAdelante2)
                    {
                        clickposicion2++;
                    }
                    else if (clickposicion2 == clickAdelante2)
                    {
                        clickposicion2 = 0;
                    }
                }
            }
        }

        private void pbxDepto_Click(object sender, EventArgs e)
        {
            this.Close();
            InitializeComponent();
            DeptoDisponibleVenta ddv = new DeptoDisponibleVenta();
            ddv.MostrarInfoDepto(Depto, image2, idDepto);
        }

        private void pbxCasa_Click(object sender, EventArgs e)
        {
            this.Close();
            InitializeComponent();
            CasaDisponibleVenta cdv = new CasaDisponibleVenta();
            cdv.MostrarInfoCasa(Casa, image, idCasa);
        }
    }
}
