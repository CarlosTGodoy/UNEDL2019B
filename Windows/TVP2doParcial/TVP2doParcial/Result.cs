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

namespace TVP2doParcial
{
    public partial class Result : Form
    {
        public Result()
        {
            InitializeComponent();
        }

        public Result(ArrayList palabras)
        {
            int contP=0;
            for(int i=0; i < palabras.Count;i++)
            {
                contP++;
            }
            string p = contP.ToString();

            InitializeComponent();
            lblPT.Text = "La cantidad total de palabras es de: "+p;

            //Obtener las palabras repetidas y sus ocurrencias
            //ArrayList para almacenar las palabras repetidas
            ArrayList palabrasRepetidas = new ArrayList();
            string comprobar = "";

            //Guardamos valores en un array para poder trabajarlos
            String[] pal = new string[palabras.Count];
            
            for(int i = 0; i < palabras.Count; i++)
            {
                pal[i] = palabras[i].ToString();
            }

            //Obtener las palabras repetidas
            int contPR=0;
            Boolean repetido = false;
            for (int i = 0; i < palabras.Count;i++) //Inicamos un ciclo para recorrer la cadena
            {
                contPR = 0; //Contador
                repetido = false; //Bandera para comprobar que se repite
                comprobar = pal[i]; //Comprobamos
                for(int j = i+1; j<pal.Length ; j++) //Iniciamos un segundo ciclo para comprar los valores
                {
                    if (comprobar.Equals(pal[j])) //Comporbacion si son igual
                    {
                        contPR++; ///contador para contar el nuemro de repeticiones
                        pal[j] = ""; //Si se repite lo dejamos como conjunto vacio para que nos cause conflicto
                        repetido = true;
                    }

                }

                if (comprobar != "") //Si no es conjunto vacio
                {
                    if (repetido == true) //Si nuestra bandera es positiva imprimirmos
                    {
                        lbPR.Items.Add(" La palabra " + pal[i] + " se repite: " + contPR.ToString() + " veces"); //Impresion

                    }
                }

            }

        }

        private void Result_Load(object sender, EventArgs e)
        {

        }
    }
}
