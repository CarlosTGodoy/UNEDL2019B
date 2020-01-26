using System;
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
    public partial class Ayuda : Form
    {
        public Ayuda()
        {
            InitializeComponent();

            tbayuda.Text = "Para obtener ayuda y soporte sobre la APP de BinesRaices, cunsulta información relacionada o ponte en contacto con los desarrolladores\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n" +
            "Nombre: Pedro Rafael Montoya Leon    Nombre: William Ricardo Hernández Mercado       Nombre: Juan Pablo Garcia Benitez     Nombre: Carlos Emmanuel Torres Godoy\r\n" +
            "Correo: (pillin.10061@gmail.com)           Correo: (williamrhm10 @gmail.com)                         Correo: (badopokor @hotmail.com)      Correo: (ct_godoy @outlook.com)\r\n" +
            "Celular: 3328047235                              Celular: 3322014194                                              Celular: 3335768306                             Celular: 3311501594\r\n\r\n" +



            "\n\r\n\r\n\r\no visitar la institución (UNEDL), Av Enrique Díaz de León Nte 90, Col Ame.  (plantel Ingeniería).";


        }

        private void Ayuda_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            InitializeComponent();
        }
    }
}
