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




        }

        private void Result_Load(object sender, EventArgs e)
        {

        }
    }
}
