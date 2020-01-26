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
    public partial class DeptosVendidos : Form
    {
        public DeptosVendidos()
        {
            InitializeComponent();
        }


        //Variables
        int a = 0;
        String[,] registrosDisp;
        String[,] lecturaInfoDepto;
        String[,] lecturaInfoUsuario;
        int var = 0;

        //Lista
        ArrayList registros = new ArrayList();


        private void DeptosVendidos_Load(object sender, EventArgs e)
        {
            //Damos los valores de inicio
            rtbInfoDepto.Text = "BIENVENIDO \nHaga Click en la flecha para ver nuestrasCasas";
            rtbInfoRentador.Text = "Aún no existe información";
            pbxDepto.Image = Image.FromFile(@"C:\img\LOGO.png");
            a = 0;

            //Objetoque conecta nuestros archivos
            TrabajarArchivo metodos = new TrabajarArchivo();

            //Traemos nuestra lista
            registros = metodos.LeerArchivo(4);

            //Pasamos todos los registros a una matriz
            String[,] registrosALeer = new String[registros.Count, 22];

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

                if (datoRegistro[1] == "true")
                {
                    var++;
                }
            }

            registrosDisp = new String[var, 22];
            //lecturaInfoCasa = new String[var, 20];

            //Pasamos los registros con status "vendida" a una matriz (El status es la posicion 1)
            for (int i = 0; i < var; i++)
            {
                for (int j = 0; j < 22; j++)
                {
                    if (registrosALeer[i, 1] == "true")
                    {
                        registrosDisp[i, j] = registrosALeer[i, j]; //Me pide que j sea igual a los registros que estan en true
                    }
                }

            }
        }

        String usuario;
        String image;
        private void pbxAdelante_Click(object sender, EventArgs e)
        {
            if (var == 0)
            {
                MessageBox.Show("No existen registros");
            }
            else
            {
                int cantReg = var;
                switch (a)
                {
                    case 0:
                        usuario = "";
                        for (int i = 0; i < 22; i++)
                        {
                            if (i == 21)
                            {
                                image = registrosDisp[0, i];
                            }
                            if (i != 21)
                            {
                                if (i == 0)
                                {
                                    usuario += "ID: " + registrosDisp[0, i] + "\n";
                                }
                                if (i == 1)
                                {
                                    usuario += "Status: " + registrosDisp[0, i] + "\n";
                                }
                                if (i == 2)
                                {
                                    usuario += "Tipo: " + registrosDisp[0, i] + "\n";
                                }
                                if (i == 3)
                                {
                                    usuario += "Costo: " + registrosDisp[0, i] + "\n";
                                }
                                if (i == 4)
                                {
                                    usuario += "P. Depto: " + registrosDisp[0, i] + "\n";
                                }
                                if (i == 5)
                                {
                                    usuario += "N. Depto: " + registrosDisp[0, i] + "\n";
                                }
                                if (i == 6)

                                {
                                    usuario += "Dirección: " + registrosDisp[0, i] + "\n";
                                }
                                if (i == 7)
                                {
                                    usuario += "Número ext.: " + registrosDisp[0, i] + "\n";
                                }
                                if (i == 8)
                                {
                                    usuario += "Colonia: " + registrosDisp[0, i] + "\n";
                                }
                                if (i == 9)
                                {
                                    usuario += "Estado: " + registrosDisp[0, i] + "\n";
                                }
                                if (i == 10)
                                {
                                    usuario += "Metros 2: " + registrosDisp[0, i] + "\n";
                                }
                                if (i == 11)
                                {
                                    usuario += "Cuartos: " + registrosDisp[0, i] + "\n";
                                }
                                if (i == 12)
                                {
                                    usuario += "Baños completos: " + registrosDisp[0, i] + "\n";
                                }
                                if (i == 13)
                                {
                                    usuario += "Baños medios: " + registrosDisp[0, i] + "\n";
                                }
                                if (i == 14)
                                {
                                    usuario += "Cocina: " + registrosDisp[0, i] + "\n";
                                }
                                if (i == 15)
                                {
                                    usuario += "Sala: " + registrosDisp[0, i] + "\n";
                                }
                                if (i == 16)
                                {
                                    usuario += "Comedor: " + registrosDisp[0, i] + "\n";
                                }
                                if (i == 17)
                                {
                                    usuario += "C. Lavado: " + registrosDisp[0, i] + "\n";
                                }
                                if (i == 18)
                                {
                                    usuario += "P Casa: " + registrosDisp[0, i] + "\n";
                                }
                                if (i == 19)
                                {
                                    usuario += "Cochera: " + registrosDisp[0, i] + "\n";
                                }
                                if (i == 20)
                                {
                                    usuario += "Cupos: " + registrosDisp[0, i] + "\n";
                                }

                            }

                        }

                        pbxDepto.Image = Image.FromFile(@image);
                        rtbInfoDepto.Text = usuario;

                        if (cantReg == 1)
                        {
                            a = 0;
                        }
                        else
                        {
                            a++;
                        }
                        break;
                    case 1:
                        usuario = "";
                        for (int i = 0; i < 22; i++)
                        {
                            if (i == 21)
                            {
                                image = registrosDisp[1, i];
                            }
                            if (i != 21)
                            {
                                if (i == 0)
                                {
                                    usuario += "ID: " + registrosDisp[1, i] + "\n";
                                }
                                if (i == 1)
                                {
                                    usuario += "Status: " + registrosDisp[1, i] + "\n";
                                }
                                if (i == 2)
                                {
                                    usuario += "Tipo: " + registrosDisp[1, i] + "\n";
                                }
                                if (i == 3)
                                {
                                    usuario += "Costo: " + registrosDisp[1, i] + "\n";
                                }
                                if (i == 4)
                                {
                                    usuario += "P. Depto: " + registrosDisp[1, i] + "\n";
                                }
                                if (i == 5)
                                {
                                    usuario += "N. Depto: " + registrosDisp[1, i] + "\n";
                                }
                                if (i == 6)

                                {
                                    usuario += "Dirección: " + registrosDisp[1, i] + "\n";
                                }
                                if (i == 7)
                                {
                                    usuario += "Número ext.: " + registrosDisp[1, i] + "\n";
                                }
                                if (i == 8)
                                {
                                    usuario += "Colonia: " + registrosDisp[1, i] + "\n";
                                }
                                if (i == 9)
                                {
                                    usuario += "Estado: " + registrosDisp[1, i] + "\n";
                                }
                                if (i == 10)
                                {
                                    usuario += "Metros 2: " + registrosDisp[1, i] + "\n";
                                }
                                if (i == 11)
                                {
                                    usuario += "Cuartos: " + registrosDisp[1, i] + "\n";
                                }
                                if (i == 12)
                                {
                                    usuario += "Baños completos: " + registrosDisp[1, i] + "\n";
                                }
                                if (i == 13)
                                {
                                    usuario += "Baños medios: " + registrosDisp[1, i] + "\n";
                                }
                                if (i == 14)
                                {
                                    usuario += "Cocina: " + registrosDisp[1, i] + "\n";
                                }
                                if (i == 15)
                                {
                                    usuario += "Sala: " + registrosDisp[1, i] + "\n";
                                }
                                if (i == 16)
                                {
                                    usuario += "Comedor: " + registrosDisp[1, i] + "\n";
                                }
                                if (i == 17)
                                {
                                    usuario += "C. Lavado: " + registrosDisp[1, i] + "\n";
                                }
                                if (i == 18)
                                {
                                    usuario += "P Casa: " + registrosDisp[1, i] + "\n";
                                }
                                if (i == 19)
                                {
                                    usuario += "Cochera: " + registrosDisp[1, i] + "\n";
                                }
                                if (i == 20)
                                {
                                    usuario += "Cupos: " + registrosDisp[1, i] + "\n";
                                }

                            }

                        }
                        pbxDepto.Image = Image.FromFile(@image);
                        rtbInfoDepto.Text = usuario;

                        if (cantReg == 2)
                        {
                            a = 0;
                        }
                        else
                        {
                            a++;
                        }
                        break;
                    case 2:
                        usuario = "";
                        for (int i = 0; i < 22; i++)
                        {
                            if (i == 21)
                            {
                                image = registrosDisp[1, i];
                            }
                            if (i != 21)
                            {
                                if (i == 0)
                                {
                                    usuario += "ID: " + registrosDisp[1, i] + "\n";
                                }
                                if (i == 1)
                                {
                                    usuario += "Status: " + registrosDisp[1, i] + "\n";
                                }
                                if (i == 2)
                                {
                                    usuario += "Tipo: " + registrosDisp[1, i] + "\n";
                                }
                                if (i == 3)
                                {
                                    usuario += "Costo: " + registrosDisp[1, i] + "\n";
                                }
                                if (i == 4)
                                {
                                    usuario += "P. Depto: " + registrosDisp[1, i] + "\n";
                                }
                                if (i == 5)
                                {
                                    usuario += "N. Depto: " + registrosDisp[1, i] + "\n";
                                }
                                if (i == 6)

                                {
                                    usuario += "Dirección: " + registrosDisp[1, i] + "\n";
                                }
                                if (i == 7)
                                {
                                    usuario += "Número ext.: " + registrosDisp[1, i] + "\n";
                                }
                                if (i == 8)
                                {
                                    usuario += "Colonia: " + registrosDisp[1, i] + "\n";
                                }
                                if (i == 9)
                                {
                                    usuario += "Estado: " + registrosDisp[1, i] + "\n";
                                }
                                if (i == 10)
                                {
                                    usuario += "Metros 2: " + registrosDisp[1, i] + "\n";
                                }
                                if (i == 11)
                                {
                                    usuario += "Cuartos: " + registrosDisp[1, i] + "\n";
                                }
                                if (i == 12)
                                {
                                    usuario += "Baños completos: " + registrosDisp[1, i] + "\n";
                                }
                                if (i == 13)
                                {
                                    usuario += "Baños medios: " + registrosDisp[1, i] + "\n";
                                }
                                if (i == 14)
                                {
                                    usuario += "Cocina: " + registrosDisp[1, i] + "\n";
                                }
                                if (i == 15)
                                {
                                    usuario += "Sala: " + registrosDisp[1, i] + "\n";
                                }
                                if (i == 16)
                                {
                                    usuario += "Comedor: " + registrosDisp[1, i] + "\n";
                                }
                                if (i == 17)
                                {
                                    usuario += "C. Lavado: " + registrosDisp[1, i] + "\n";
                                }
                                if (i == 18)
                                {
                                    usuario += "P Casa: " + registrosDisp[1, i] + "\n";
                                }
                                if (i == 19)
                                {
                                    usuario += "Cochera: " + registrosDisp[1, i] + "\n";
                                }
                                if (i == 20)
                                {
                                    usuario += "Cupos: " + registrosDisp[1, i] + "\n";
                                }

                            }

                        }

                        pbxDepto.Image = Image.FromFile(@image);
                        rtbInfoDepto.Text = usuario;

                        a = 0;
                        break;
                }
            }
        }

        private void pbxDepto_Click(object sender, EventArgs e)
        {

        }

        private void rtbInfoDepto_TextChanged(object sender, EventArgs e)
        {

        }

        private void rtbInfoRentador_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
