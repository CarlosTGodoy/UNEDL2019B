using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Bienes_Raices
{
    public partial class CasasVendidas : Form
    {
        public CasasVendidas()
        {
            InitializeComponent();
        }

        //Variables
        int a = 0;
        String[,] registrosDisp;
        String[,] lecturaInfoCasa;
        String[,] lecturaInfoUsuario;
        int var = 0;

        //Lista
        ArrayList registros = new ArrayList();

        private void CasasVendidas_Load(object sender, EventArgs e)
        {
            //Damos los valores de inicio
            rtbInfoCasa.Text = "BIENVENIDO \nHaga Click en la flecha para ver nuestrasCasas";
            rtbInfoComprador.Text = "Aún no existe información";
            pbxCasa.Image = Image.FromFile(@"C:\img\LOGO.png");
            a = 0;

            //Objetoque conecta nuestros archivos
            TrabajarArchivo metodos = new TrabajarArchivo();

            //Traemos nuestra lista
            registros = metodos.LeerArchivo(3);

            //Pasamos todos los registros a una matriz
            String[,] registrosALeer = new String[registros.Count,20];
            
            //lecturaInfoUsuario = new String[registros.Count, 5];
            String romperRegistro;
            String CantCampos;

            //Cantidad de registros en true
            for (int i = 0;i < registros.Count; i++)
            {
                romperRegistro = (String) registros[i];
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
                        registrosDisp[i, j] = registrosALeer[i, j];
                    }
                }

            }

            
        }

        //String usuario;
        String Casa;
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
                        Casa = "";
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
                                    Casa += "ID: " + registrosDisp[0, i] + "\n";
                                }
                                if (i == 1)
                                {
                                    Casa += "Status: " + registrosDisp[0, i] + "\n";
                                }
                                if (i == 2)
                                {
                                    Casa += "Tipo: " + registrosDisp[0, i] + "\n";
                                }
                                if (i == 3)
                                {
                                    Casa += "Costo: " + registrosDisp[0, i] + "\n";
                                }
                                if (i == 4)
                                {
                                    Casa += "Dirección: " + registrosDisp[0, i] + "\n";
                                }
                                if (i == 5)
                                {
                                    Casa += "Número: " + registrosDisp[0, i] + "\n";
                                }
                                if (i == 6)

                                {
                                    Casa += "Colonia: " + registrosDisp[0, i] + "\n";
                                }
                                if (i == 7)
                                {
                                    Casa += "Estado: " + registrosDisp[0, i] + "\n";
                                }
                                if (i == 8)
                                {
                                    Casa += "Metros cuadrados: " + registrosDisp[0, i] + "\n";
                                }
                                if (i == 9)
                                {
                                    Casa += "Cuartos: " + registrosDisp[0, i] + "\n";
                                }
                                if (i == 10)
                                {
                                    Casa += "Baños completos: " + registrosDisp[0, i] + "\n";
                                }
                                if (i == 11)
                                {
                                    Casa += "Baños medios: " + registrosDisp[0, i] + "\n";
                                }
                                if (i == 12)
                                {
                                    Casa += "Cocina: " + registrosDisp[0, i] + "\n";
                                }
                                if (i == 13)
                                {
                                    Casa += "Sala: " + registrosDisp[0, i] + "\n";
                                }
                                if (i == 14)
                                {
                                    Casa += "Comedor: " + registrosDisp[0, i] + "\n";
                                }
                                if (i == 15)
                                {
                                    Casa += "C. lavado: " + registrosDisp[0, i] + "\n";
                                }
                                if (i == 16)
                                {
                                    Casa += "Pisos: " + registrosDisp[0, i] + "\n";
                                }
                                if (i == 17)
                                {
                                    Casa += "Cochera: " + registrosDisp[0, i] + "\n";
                                }
                                if (i == 18)
                                {
                                    Casa += "Cupos de cochera: " + registrosDisp[0, i] + "\n";
                                }

                            }
                            
                        }

                        pbxCasa.Image = Image.FromFile(@image);
                        rtbInfoCasa.Text = Casa;

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
                        Casa = "";
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
                                    Casa += "ID: " + registrosDisp[1, i] + "\n";
                                }
                                if (i == 1)
                                {
                                    Casa += "Status: " + registrosDisp[1, i] + "\n";
                                }
                                if (i == 2)
                                {
                                    Casa += "Tipo: " + registrosDisp[1, i] + "\n";
                                }
                                if (i == 3)
                                {
                                    Casa += "Costo: " + registrosDisp[1, i] + "\n";
                                }
                                if (i == 4)
                                {
                                    Casa += "Dirección: " + registrosDisp[1, i] + "\n";
                                }
                                if (i == 5)
                                {
                                    Casa += "Número: " + registrosDisp[1, i] + "\n";
                                }
                                if (i == 6)

                                {
                                    Casa += "Colonia: " + registrosDisp[1, i] + "\n";
                                }
                                if (i == 7)
                                {
                                    Casa += "Estado: " + registrosDisp[1, i] + "\n";
                                }
                                if (i == 8)
                                {
                                    Casa += "Metros cuadrados: " + registrosDisp[1, i] + "\n";
                                }
                                if (i == 9)
                                {
                                    Casa += "Cuartos: " + registrosDisp[1, i] + "\n";
                                }
                                if (i == 10)
                                {
                                    Casa += "Baños completos: " + registrosDisp[1, i] + "\n";
                                }
                                if (i == 11)
                                {
                                    Casa += "Baños medios: " + registrosDisp[1, i] + "\n";
                                }
                                if (i == 12)
                                {
                                    Casa += "Cocina: " + registrosDisp[1, i] + "\n";
                                }
                                if (i == 13)
                                {
                                    Casa += "Sala: " + registrosDisp[1, i] + "\n";
                                }
                                if (i == 14)
                                {
                                    Casa += "Comedor: " + registrosDisp[1, i] + "\n";
                                }
                                if (i == 15)
                                {
                                    Casa += "C. lavado: " + registrosDisp[1, i] + "\n";
                                }
                                if (i == 16)
                                {
                                    Casa += "Pisos: " + registrosDisp[1, i] + "\n";
                                }
                                if (i == 17)
                                {
                                    Casa += "Cochera: " + registrosDisp[1, i] + "\n";
                                }
                                if (i == 18)
                                {
                                    Casa += "Cupos de cochera: " + registrosDisp[1, i] + "\n";
                                }

                            }

                        }

                        pbxCasa.Image = Image.FromFile(@image);
                        rtbInfoCasa.Text = Casa;

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
                        Casa = "";
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
                                    Casa += "ID: " + registrosDisp[2, i] + "\n";
                                }
                                if (i == 1)
                                {
                                    Casa += "Status: " + registrosDisp[2, i] + "\n";
                                }
                                if (i == 2)
                                {
                                    Casa += "Tipo: " + registrosDisp[2, i] + "\n";
                                }
                                if (i == 3)
                                {
                                    Casa += "Costo: " + registrosDisp[2, i] + "\n";
                                }
                                if (i == 4)
                                {
                                    Casa += "Dirección: " + registrosDisp[2, i] + "\n";
                                }
                                if (i == 5)
                                {
                                    Casa += "Número: " + registrosDisp[2, i] + "\n";
                                }
                                if (i == 6)

                                {
                                    Casa += "Colonia: " + registrosDisp[2, i] + "\n";
                                }
                                if (i == 7)
                                {
                                    Casa += "Estado: " + registrosDisp[2, i] + "\n";
                                }
                                if (i == 8)
                                {
                                    Casa += "Metros cuadrados: " + registrosDisp[2, i] + "\n";
                                }
                                if (i == 9)
                                {
                                    Casa += "Cuartos: " + registrosDisp[2, i] + "\n";
                                }
                                if (i == 10)
                                {
                                    Casa += "Baños completos: " + registrosDisp[2, i] + "\n";
                                }
                                if (i == 11)
                                {
                                    Casa += "Baños medios: " + registrosDisp[2, i] + "\n";
                                }
                                if (i == 12)
                                {
                                    Casa += "Cocina: " + registrosDisp[2, i] + "\n";
                                }
                                if (i == 13)
                                {
                                    Casa += "Sala: " + registrosDisp[2, i] + "\n";
                                }
                                if (i == 14)
                                {
                                    Casa += "Comedor: " + registrosDisp[2, i] + "\n";
                                }
                                if (i == 15)
                                {
                                    Casa += "C. lavado: " + registrosDisp[2, i] + "\n";
                                }
                                if (i == 16)
                                {
                                    Casa += "Pisos: " + registrosDisp[2, i] + "\n";
                                }
                                if (i == 17)
                                {
                                    Casa += "Cochera: " + registrosDisp[2, i] + "\n";
                                }
                                if (i == 18)
                                {
                                    Casa += "Cupos de cochera: " + registrosDisp[2, i] + "\n";
                                }

                            }

                        }

                        pbxCasa.Image = Image.FromFile(@image);
                        rtbInfoCasa.Text = Casa;

                        a = 0;
                        break;
                }
            }
            
        }


        private void lblCasasVendidas_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pbxCasa_Click(object sender, EventArgs e)
        {

        }

        
    }
}
