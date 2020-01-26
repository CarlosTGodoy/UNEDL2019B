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
    public partial class CasasRenta : Form
    {
        public CasasRenta()
        {
            InitializeComponent();
        }

        //Variables
        int a = 0;
        String[,] registrosDisp;
        String[,] lecturaInfoCasa;
        String[,] lecturaInfoUsuario;
        int var = 0;
        int cont = 0;
        //Lista
        ArrayList registros = new ArrayList();

        private void CasasRenta_Load(object sender, EventArgs e)
        {
            //Damos los valores de inicio
            rtbInfoCasa.Text = "BIENVENIDO \nHaga Click en la flecha para ver nuestrasCasas";
            rtbInfoRentador.Text = "Aún no existe información";
            pbxCasa.Image = Image.FromFile(@"C:\img\LOGO.png");
            a = 0;

            //Objetoque conecta nuestros archivos
            TrabajarArchivo metodos = new TrabajarArchivo();

            //Traemos nuestra lista
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

                if (datoRegistro[1] == "true")
                {
                    var++;
                }
            }

            registrosDisp = new String[var, 20];
            //lecturaInfoCasa = new String[var, 20];

            //Pasamos los registros con status "vendida" a una matriz (El status es la posicion 1)
            for (int i = 0; i < var; i++)
            {
                for (int j = 0; j < 20; j++)
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
                        for (int i = 0; i < 20; i++)
                        {
                            if (i == 19)
                            {
                                image = registrosDisp[0, i];
                            }
                            if (i != 19)
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
                                    usuario += "Dirección: " + registrosDisp[0, i] + "\n";
                                }
                                if (i == 5)
                                {
                                    usuario += "Número: " + registrosDisp[0, i] + "\n";
                                }
                                if (i == 6)

                                {
                                    usuario += "Colonia: " + registrosDisp[0, i] + "\n";
                                }
                                if (i == 7)
                                {
                                    usuario += "Estado: " + registrosDisp[0, i] + "\n";
                                }
                                if (i == 8)
                                {
                                    usuario += "Metros cuadrados: " + registrosDisp[0, i] + "\n";
                                }
                                if (i == 9)
                                {
                                    usuario += "Cuartos: " + registrosDisp[0, i] + "\n";
                                }
                                if (i == 10)
                                {
                                    usuario += "Baños completos: " + registrosDisp[0, i] + "\n";
                                }
                                if (i == 11)
                                {
                                    usuario += "Baños medios: " + registrosDisp[0, i] + "\n";
                                }
                                if (i == 12)
                                {
                                    usuario += "Cocina: " + registrosDisp[0, i] + "\n";
                                }
                                if (i == 13)
                                {
                                    usuario += "Sala: " + registrosDisp[0, i] + "\n";
                                }
                                if (i == 14)
                                {
                                    usuario += "Comedor: " + registrosDisp[0, i] + "\n";
                                }
                                if (i == 15)
                                {
                                    usuario += "C. lavado: " + registrosDisp[0, i] + "\n";
                                }
                                if (i == 16)
                                {
                                    usuario += "Pisos: " + registrosDisp[0, i] + "\n";
                                }
                                if (i == 17)
                                {
                                    usuario += "Cochera: " + registrosDisp[0, i] + "\n";
                                }
                                if (i == 18)
                                {
                                    usuario += "Cupos de cochera: " + registrosDisp[0, i] + "\n";
                                }

                            }

                        }

                        pbxCasa.Image = Image.FromFile(@image);
                        rtbInfoCasa.Text = usuario;

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
                        for (int i = 0; i < 20; i++)
                        {
                            if (i == 19)
                            {
                                image = registrosDisp[1, i];
                            }
                            if (i != 19)
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
                                    usuario += "Dirección: " + registrosDisp[1, i] + "\n";
                                }
                                if (i == 5)
                                {
                                    usuario += "Número: " + registrosDisp[1, i] + "\n";
                                }
                                if (i == 6)

                                {
                                    usuario += "Colonia: " + registrosDisp[1, i] + "\n";
                                }
                                if (i == 7)
                                {
                                    usuario += "Estado: " + registrosDisp[1, i] + "\n";
                                }
                                if (i == 8)
                                {
                                    usuario += "Metros cuadrados: " + registrosDisp[1, i] + "\n";
                                }
                                if (i == 9)
                                {
                                    usuario += "Cuartos: " + registrosDisp[1, i] + "\n";
                                }
                                if (i == 10)
                                {
                                    usuario += "Baños completos: " + registrosDisp[1, i] + "\n";
                                }
                                if (i == 11)
                                {
                                    usuario += "Baños medios: " + registrosDisp[1, i] + "\n";
                                }
                                if (i == 12)
                                {
                                    usuario += "Cocina: " + registrosDisp[1, i] + "\n";
                                }
                                if (i == 13)
                                {
                                    usuario += "Sala: " + registrosDisp[1, i] + "\n";
                                }
                                if (i == 14)
                                {
                                    usuario += "Comedor: " + registrosDisp[1, i] + "\n";
                                }
                                if (i == 15)
                                {
                                    usuario += "C. lavado: " + registrosDisp[1, i] + "\n";
                                }
                                if (i == 16)
                                {
                                    usuario += "Pisos: " + registrosDisp[1, i] + "\n";
                                }
                                if (i == 17)
                                {
                                    usuario += "Cochera: " + registrosDisp[1, i] + "\n";
                                }
                                if (i == 18)
                                {
                                    usuario += "Cupos de cochera: " + registrosDisp[1, i] + "\n";
                                }

                            }

                        }

                        pbxCasa.Image = Image.FromFile(@image);
                        rtbInfoCasa.Text = usuario;

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
                        for (int i = 0; i < 20; i++)
                        {
                            if (i == 19)
                            {
                                image = registrosDisp[2, i];
                            }
                            if (i != 19)
                            {
                                if (i == 0)
                                {
                                    usuario += "ID: " + registrosDisp[2, i] + "\n";
                                }
                                if (i == 1)
                                {
                                    usuario += "Status: " + registrosDisp[2, i] + "\n";
                                }
                                if (i == 2)
                                {
                                    usuario += "Tipo: " + registrosDisp[2, i] + "\n";
                                }
                                if (i == 3)
                                {
                                    usuario += "Costo: " + registrosDisp[2, i] + "\n";
                                }
                                if (i == 4)
                                {
                                    usuario += "Dirección: " + registrosDisp[2, i] + "\n";
                                }
                                if (i == 5)
                                {
                                    usuario += "Número: " + registrosDisp[2, i] + "\n";
                                }
                                if (i == 6)

                                {
                                    usuario += "Colonia: " + registrosDisp[2, i] + "\n";
                                }
                                if (i == 7)
                                {
                                    usuario += "Estado: " + registrosDisp[2, i] + "\n";
                                }
                                if (i == 8)
                                {
                                    usuario += "Metros cuadrados: " + registrosDisp[2, i] + "\n";
                                }
                                if (i == 9)
                                {
                                    usuario += "Cuartos: " + registrosDisp[2, i] + "\n";
                                }
                                if (i == 10)
                                {
                                    usuario += "Baños completos: " + registrosDisp[2, i] + "\n";
                                }
                                if (i == 11)
                                {
                                    usuario += "Baños medios: " + registrosDisp[2, i] + "\n";
                                }
                                if (i == 12)
                                {
                                    usuario += "Cocina: " + registrosDisp[2, i] + "\n";
                                }
                                if (i == 13)
                                {
                                    usuario += "Sala: " + registrosDisp[2, i] + "\n";
                                }
                                if (i == 14)
                                {
                                    usuario += "Comedor: " + registrosDisp[2, i] + "\n";
                                }
                                if (i == 15)
                                {
                                    usuario += "C. lavado: " + registrosDisp[2, i] + "\n";
                                }
                                if (i == 16)
                                {
                                    usuario += "Pisos: " + registrosDisp[2, i] + "\n";
                                }
                                if (i == 17)
                                {
                                    usuario += "Cochera: " + registrosDisp[2, i] + "\n";
                                }
                                if (i == 18)
                                {
                                    usuario += "Cupos de cochera: " + registrosDisp[2, i] + "\n";
                                }

                            }

                        }

                        pbxCasa.Image = Image.FromFile(@image);
                        rtbInfoCasa.Text = usuario;

                        a = 0;
                        break;
                }
            }

        }

        private void rtbInfoCasa_TextChanged(object sender, EventArgs e)
        {

        }

        private void rtbInfoRentador_TextChanged(object sender, EventArgs e)
        {

        }

        private void pbxCasa_Click(object sender, EventArgs e)
        {

        }

        
    }
}
