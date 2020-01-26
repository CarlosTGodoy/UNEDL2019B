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
    public partial class RegistroCliente : Form
    {
        string idVR;
        string respuesta;
        public RegistroCliente()
        {
            InitializeComponent();
        }

        private void RegistroCliente_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            InitializeComponent();
            MessageBox.Show("Datos cliente: " + usuario);
            //1 - RentaCasas, 2 - Renta Departamento, 3 - Venta Casas, 4 - Venta Departamento, 5 - NuevoRegistro
            ArrayList HistorialRegistros = new ArrayList();

            TrabajarArchivo TA = new TrabajarArchivo();
            HistorialRegistros = TA.LeerArchivo(movimiento);

            HistorialRegistros.Add(usuario); //Añadimos a la lista el nuevo registro

            respuesta = TA.EscribirArchivo(HistorialRegistros, movimiento); //Guardamos

            RealizarVenta rv = new RealizarVenta(); //Objeto paara comunicar la clase de Realizar Venta
            rv.GuardarVenta(usuario, movimiento, idVR, archivoBuscar); //usuario - es la informacion del cliente, movimiento - es el numero del archivo a leer, idVR - es el id de la localidad

            this.Close();
        }


        int movimiento;
        String usuario;
        String archivoBuscar;
        public void GenerarVenta(string id)
        {
            InitializeComponent();
            this.Show();
            idVR = id;


            String nom = tbxNombre.Text;
            String sgn = tbxNombreS.Text;
            String apell = tbxApellido.Text;
            String correo = tbxCorreo.Text;
            String cel = tbxCelular.Text;
            String tel = tbxTelefono.Text;
            String pais = tbxPais.Text;
            String estado = cbxEstado.Text;
            archivoBuscar = tbxMovimiento.Text;
            movimiento = 5;

            //Guardamoslos datos del cliente
            usuario = nom + "," + sgn + "," + apell + "," + correo + "," + cel + "," + tel + "," + pais + "," + estado;

        }

        private void tbxNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxNombreS_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxCorreo_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxCelular_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxPais_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbxEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbxMovimiento_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
