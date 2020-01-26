using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Bienes_Raices
{
    public partial class Descripción : Form
    {

        public Descripción()
        {
            InitializeComponent();
            tbDes.Text = "                                                                                                                  Bienes Raices\r\n\r\nBienes Raices, aplicacion que permite vender, rentar, transpasar o adquirir un patrimonio, donde puedes participar en está aplicación, donde es una forma de negocio y que" +
"facilita tanto al usuario en modo dependiente el publicar y buscar dichas propiedades con el fin de que llegue a miles de usuarios de forma" + 
"instantanea que a su vez, están en busca de adquirir una propiedad apropiada con un presupuesto adecuado." +

            "\r\n\r\nLos beneficios que maneja Bienes Raices son la facilitación de venta y compra de patrimonios de una forma segura y rapida, donde los usuarios pueden publicar y" +
" buscar algun departamento, casa, habitación, etc. que este a la venta o en renta, esta es una manera sencilla y fácil para quien decea navegar por la aplicación sin tener" +
" conflicto alguno, esta basada para cualquier persona que dece ingresar." +

"\r\n\r\nLos requisitos de Bienes Raices es contar con informacion segura al momento de ingresarla, asi al momento de ser publicada no tener problemas con informacion invalida, " +
"además de contar con su registro completo y adecuado." +

"\r\n\r\nEstá aplicación, maneja información de miles de usuarios por lo cual está implementado un tope de acceso, esto reduce al usuario el ingresar información que sobrepase" +
"a su limite especifico, de tal manera ya no podra introducir de mas sus publicaciones." +

"\r\n\r\nInicio Bienes Raices(aplicación), creado 1 de Diciembre del 2019, por: " +
"Juan Benitez(badopokor@hotmail.com), Pedro Montoya(pillin.10061@gmail.com), Carlos Godoy(ct_godoy @outlook.com) y William Hernández(williamrhm10@gmail.com), estudiantes de Ingeniería en" +
"software de la Universidad Enrique Díaz de León(UNEDL)." ;
        }

     

        private void Descripción_Load(object sender, EventArgs e)
        {
          
            InitializeComponent();
        }

        private void tbDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbDes_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
