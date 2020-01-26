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
    public partial class Stock : Form
    {
        public Stock()
        {
            InitializeComponent();
        }

        //Variables para trabajar nuestros archivos
        ArrayList CV = new ArrayList();
        ArrayList CR = new ArrayList();
        ArrayList DV = new ArrayList();
        ArrayList DR = new ArrayList();

        private void Stock_Load(object sender, EventArgs e)
        {
            //1 - Renta Casas, 2 - Renta Departamento, 3 - Venta Casas, 4 - Venta Departamento

            //Primero hacemos lectura de todas nuestros archivos
            TrabajarArchivo ta = new TrabajarArchivo(); //Objeto

            //Lectura
            CR = ta.LeerArchivo(1); //Renta Casas
            DR = ta.LeerArchivo(2); //Renta Deptos
            CV = ta.LeerArchivo(3); //Venta Casas
            DV = ta.LeerArchivo(4); //Venta Deptos

            //Contamos los registros de cada archivo
            int regCR = CR.Count;
            int regDR = DR.Count;
            int regCV = CV.Count;
            int regDV = DV.Count;

            //Variables
            string[,] registros;
            string romperRegistro;

            //Variables de datos
            string status;
            string image;

            //Depende de los registros que contenga es loque enviamos al Stock
            //Casa Renta
            registros = new string[regCR, 20];
            for (int i=0;i<regCR;i++)
            {
                romperRegistro = (string) CR[i];
                string[] datoRegistro = romperRegistro.Split(',');

                for (int j = 0; j < datoRegistro.Length; j++)
                {
                    registros[i, j] = datoRegistro[j];

                }

            }

            if (regCR == 1)
            {
                lblSCR1.Text = registros[0, 1];
                pbxCR1.Image = Image.FromFile(@registros[0, 19]);
            }
            else if (regCR == 2)
            {
                lblSCR1.Text = registros[0, 1];
                pbxCR1.Image = Image.FromFile(@registros[0, 19]);
                lblSCR2.Text = registros[1, 1];
                pbxCR2.Image = Image.FromFile(@registros[1, 19]);
            }
            else if (regCR == 3)
            {
                lblSCR1.Text = registros[0, 1];
                pbxCR1.Image = Image.FromFile(@registros[0, 19]);
                lblSCR2.Text = registros[1, 1];
                pbxCR2.Image = Image.FromFile(@registros[1, 19]);
                lblSCR3.Text = registros[2, 1];
                pbxCR3.Image = Image.FromFile(@registros[2, 19]);
            }

            //Casa Venta
            registros = new string[regCV, 20];
            for (int i = 0; i < regCV; i++)
            {
                romperRegistro = (string)CV[i];
                string[] datoRegistro = romperRegistro.Split(',');

                for (int j = 0; j < datoRegistro.Length; j++)
                {
                    registros[i, j] = datoRegistro[j];

                }

            }

            if (regCV == 1)
            {
                lblSCV1.Text = registros[0, 1];
                pbxCV1.Image = Image.FromFile(@registros[0, 19]);
            }
            else if (regCV == 2)
            {
                lblSCV1.Text = registros[0, 1];
                pbxCV1.Image = Image.FromFile(@registros[0, 19]);
                lblSCV2.Text = registros[1, 1];
                pbxCV2.Image = Image.FromFile(@registros[1, 19]);
            }
            else if (regCV == 3)
            {
                lblSCV1.Text = registros[0, 1];
                pbxCV1.Image = Image.FromFile(@registros[0, 19]);
                lblSCV2.Text = registros[1, 1];
                pbxCV2.Image = Image.FromFile(@registros[1, 19]);
                lblSCV3.Text = registros[2, 1];
                pbxCV3.Image = Image.FromFile(@registros[2, 19]);
            }

            //Depto Venta
            registros = new string[regDV, 22];
            for (int i = 0; i < regDV; i++)
            {
                romperRegistro = (string)DV[i];
                string[] datoRegistro = romperRegistro.Split(',');

                for (int j = 0; j < datoRegistro.Length; j++)
                {
                    registros[i, j] = datoRegistro[j];

                }

            }

            if (regDV == 1)
            {
                lblSDV1.Text = registros[0, 1];
                pbxDV1.Image = Image.FromFile(@registros[0, 21]);
            }
            else if (regDV == 2)
            {
                lblSDV1.Text = registros[0, 1];
                pbxDV1.Image = Image.FromFile(@registros[0, 21]);
                lblSDV2.Text = registros[1, 1];
                pbxDV2.Image = Image.FromFile(@registros[1, 21]);
            }
            else if (regDV == 3)
            {
                lblSDV1.Text = registros[0, 1];
                pbxDV1.Image = Image.FromFile(@registros[0, 21]);
                lblSDV2.Text = registros[1, 1];
                pbxDV2.Image = Image.FromFile(@registros[1, 21]);
                lblSDV3.Text = registros[2, 1];
                pbxDV3.Image = Image.FromFile(@registros[2, 21]);
            }

            //Depto Renta
            registros = new string[regDR, 22];
            for (int i = 0; i < regDR; i++)
            {
                romperRegistro = (string)DR[i];
                string[] datoRegistro = romperRegistro.Split(',');

                for (int j = 0; j < datoRegistro.Length; j++)
                {
                    registros[i, j] = datoRegistro[j];

                }

            }

            if (regDR == 1)
            {
                lblSDR1.Text = registros[0, 1];
                pbxDR1.Image = Image.FromFile(@registros[0, 21]);
            }
            else if (regDR == 2)
            {
                lblSDR1.Text = registros[0, 1];
                pbxDR1.Image = Image.FromFile(@registros[0, 21]);
                lblSDR2.Text = registros[1, 1];
                pbxDR2.Image = Image.FromFile(@registros[1, 21]);
            }
            else if (regDR == 3)
            {
                lblSDR1.Text = registros[0, 1];
                pbxDR1.Image = Image.FromFile(@registros[0, 21]);
                lblSDR2.Text = registros[1, 1];
                pbxDR2.Image = Image.FromFile(@registros[1, 21]);
                lblSDR3.Text = registros[2, 1];
                pbxDR3.Image = Image.FromFile(@registros[2, 21]);
            }
        }


        private void rtbCasas_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblCasas_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pbxCV1_Click(object sender, EventArgs e)
        {

        }

        private void lblSCV1_Click(object sender, EventArgs e)
        {

        }

        private void pbxCV2_Click(object sender, EventArgs e)
        {

        }

        private void pbxCV3_Click(object sender, EventArgs e)
        {

        }

        private void lblSCV3_Click(object sender, EventArgs e)
        {

        }

        private void pbxCR1_Click(object sender, EventArgs e)
        {

        }

        private void lblSCR1_Click(object sender, EventArgs e)
        {

        }

        private void pbxCR2_Click(object sender, EventArgs e)
        {

        }

        private void lblSCR2_Click(object sender, EventArgs e)
        {

        }

        private void pbxCR3_Click(object sender, EventArgs e)
        {

        }

        private void CR3_Click(object sender, EventArgs e)
        {

        }

        private void pbxDV1_Click(object sender, EventArgs e)
        {

        }

        private void lblSDV1_Click(object sender, EventArgs e)
        {

        }

        private void pbxDV2_Click(object sender, EventArgs e)
        {

        }

        private void lblSDV2_Click(object sender, EventArgs e)
        {

        }

        private void pbxDV3_Click(object sender, EventArgs e)
        {

        }

        private void lblSDV3_Click(object sender, EventArgs e)
        {

        }

        private void pbxDR1_Click(object sender, EventArgs e)
        {

        }

        private void lblSDR1_Click(object sender, EventArgs e)
        {

        }

        private void pbxDR2_Click(object sender, EventArgs e)
        {

        }

        private void lblSDR2_Click(object sender, EventArgs e)
        {

        }

        private void pbxDR3_Click(object sender, EventArgs e)
        {

        }

        private void lblSDR3_Click(object sender, EventArgs e)
        {

        }
    }
}
