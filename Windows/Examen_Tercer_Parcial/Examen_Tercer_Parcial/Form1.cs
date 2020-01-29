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

namespace Examen_Tercer_Parcial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //InitializeComponent();
        }

        private void gbxDatosPersonales_Enter(object sender, EventArgs e)
        {

        }

        private void gbxDatosBancarios_Enter(object sender, EventArgs e)
        {

        }

        private void btnEdicion_Click(object sender, EventArgs e)
        {
            
        }

        private void tbxNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxFN_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxDireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void rbtFemenino_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtMasculino_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbnOtro_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tbxCantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxSaldo_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void rbnDeposito_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbnRetiro_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbnConsulta_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            tbxNombre.Text = "";
            tbxApellido.Text = "";
            tbxFN.Text = "";
            tbxDireccion.Text = "";
            rbtFemenino.Checked = false;
            rbtMasculino.Checked = false;
            rbnOtro.Checked = false;

            //Datos bancarios
            tbxCantidad.Text = "";
            tbxSaldo.Text = "";
            rbnDeposito.Checked = false;
            rbnRetiro.Checked = false;
            rbnConsulta.Checked = false;
            dateTimePicker1.Text = "";

            //Desactivamos
            this.gbxDatosPersonales.Enabled = false;
            this.gbxDatosBancarios.Enabled = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.gbxDatosPersonales.Enabled = true;
            this.gbxDatosBancarios.Enabled = true;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            tbxNombre.Text = "";
            tbxApellido.Text = "";
            tbxFN.Text = "";
            tbxDireccion.Text = "";
            rbnDeposito.Checked = false;
            rbnRetiro.Checked = false;
            rbnConsulta.Checked = false;

            //Datos bancarios
            tbxCantidad.Text = "";
            tbxSaldo.Text = "";
            rbnDeposito.Checked = false;
            rbnRetiro.Checked = false;
            rbnConsulta.Checked = false;
            dateTimePicker1.Text = "";
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            String Nombre = tbxNombre.Text;
            String Apellido = tbxApellido.Text;
            String FN = tbxFN.Text;
            String Direccion = tbxDireccion.Text;
            String Sexo = "";
            if (rbtFemenino.Checked == true)
            {
                Sexo = "Femenino";
            }
            else if (rbtMasculino.Checked == true)
            {
                Sexo = "Masculino";
            }
            else if (rbnOtro.Checked == true)
            {
                Sexo = "Otro";
            }

            String Cantidad = tbxCantidad.Text;
            String Movimiento = "";
            if (rbnDeposito.Checked == true)
            {
                Movimiento = "Deposito";
            }
            else if(rbnRetiro.Checked == true)
            {
                Movimiento = "Retiro";
            }
            else if (rbnConsulta.Checked == true)
            {
                Movimiento = "Consulta";
            }
            
            
            


            String registro = Nombre + ","+ Apellido + "," + FN + "," + Direccion + "," + Sexo + "," + Cantidad + "," +Movimiento;

            using (System.IO.StreamWriter escribir = new System.IO.StreamWriter(@"C:\ExamenFinal\Guardado.txt"))
            {
                escribir.WriteLine(registro);
            }
        }
    }
}
