using System;
using System.IO;
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
    public partial class Rentas : Form
    {
        String que;
        String ID = "0";
        String Estado;
        String Costo;
        String Metros;
        String bañoC;
        String cuarto;
        String Ndepartamento;
        String Pdepartamento;
        String Direccion;
        String Pcasa;
        String Ncupos = "0";
        String Numero;
        String Colonia;
        String bañoM;
        String Imagen;
        String result;
        int x = 0, y = 0;
        TrabajarArchivo TA = new TrabajarArchivo();
        ArrayList Lista = new ArrayList();
        public Rentas()
        {
            InitializeComponent();
        }

        private void Rentas_Load(object sender, EventArgs e)
        {

        }
        private void Ventas_Load(object sender, EventArgs e)
        {

        }



        private void btnImagen_Click(object sender, EventArgs e)
        {
            String rutaArchivo = String.Empty;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                rutaArchivo = openFileDialog.FileName;
            }
            txtImagen.Text = rutaArchivo;
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {

            int indice = cbxTipo.SelectedIndex;

            if (txtCalle.Text == "" || cbxTipo.Text == "" || cbxEstado.Text == "" || cbxBañoC.Text == "" || cbxCuarto.Text == "" || txtMTS2.Text == "" || txtCosto.Text == "" || txtPiso.Text == "" || cbxBañoM.Text == "" || txtNumero.Text == "" || txtColonia.Text == "")
            {
                MessageBox.Show("no a llenado todos los campos");
            }
            else
            {
                que = cbxTipo.Text;
                Estado = cbxEstado.Text;
                bañoC = cbxBañoC.Text;
                Costo = txtCosto.Text;
                Metros = txtMTS2.Text;
                cuarto = cbxCuarto.Text;
                Direccion = txtCalle.Text;
                Pcasa = txtPiso.Text;
                Numero = txtNumero.Text;
                Colonia = txtColonia.Text;
                bañoM = cbxBañoM.Text;
                Imagen = txtImagen.Text;
                Ncupos = txtNcupos.Text;
                if (indice == 0)
                {
                    y = 2;
                    Ndepartamento = txtNDepartamento.Text;
                    Pdepartamento = textPDepartamento.Text;
                    String Venta = ID + ",false" + "," + que + "," + Costo + "," + Pdepartamento + "," + Ndepartamento + "," + Direccion + "," + Numero + "," + Colonia + "," + Estado + "," + Metros + "," + cuarto + "," + bañoC + "," + bañoM + "," + chbxCocina.Checked + "," + chbxSala.Checked + "," + chbxComedor.Checked + "," + chbxLavado.Checked + "," + Pcasa + "," + chbxCochera.Checked + "," + Ncupos + "," + Imagen;
                    MessageBox.Show(Venta);
                    Lista.Add(Venta);
                    result = TA.EscribirArchivo(Lista, y);
                    MessageBox.Show(result);
                    this.Close();
                }
                else
                {
                    y = 1;
                    String Venta = ID + ",false" + "," + que + "," + Costo + "," + Direccion + "," + Numero + "," + Colonia + "," + Estado + "," + Metros + "," + cuarto + "," + bañoC + "," + bañoM + "," + chbxCocina.Checked + "," + chbxSala.Checked + "," + chbxComedor.Checked + "," + chbxLavado.Checked + "," + Pcasa + "," + chbxCochera.Checked + "," + Ncupos + "," + Imagen;
                    MessageBox.Show(Venta);
                    Lista.Add(Venta);
                    result = TA.EscribirArchivo(Lista, y);
                    MessageBox.Show(result);
                    this.Close();
                }
            }
        }

        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
            int indice = cbxTipo.SelectedIndex;
            txtCalle.Enabled = true;
            cbxEstado.Enabled = true;
            txtCosto.Enabled = true;
            txtMTS2.Enabled = true;
            txtImagen.Enabled = true;
            btnImagen.Enabled = true;
            cbxBañoC.Enabled = true;
            cbxCuarto.Enabled = true;
            txtPiso.Enabled = true;
            chbxLavado.Enabled = true;
            chbxComedor.Enabled = true;
            chbxSala.Enabled = true;
            chbxCocina.Enabled = true;
            cbxBañoM.Enabled = true;
            txtNumero.Enabled = true;
            txtColonia.Enabled = true;
            btnGuardar.Enabled = true;
            if (chbxCochera.Checked == true)
            {
                txtNcupos.Enabled = true;
            }
            else
            {
                txtNcupos.Enabled = false;
            }
            if (indice == 0)
            {
                x = 2;
                lblNdepartamento.Visible = true;
                lblPdepartamento.Visible = true;
                txtNDepartamento.Visible = true;
                textPDepartamento.Visible = true;
                txtNDepartamento.Enabled = true;
                textPDepartamento.Enabled = true;
                Lista = TA.LeerArchivo(x);
            }
            else
            {
                x = 1;
                lblNdepartamento.Visible = false;
                lblPdepartamento.Visible = false;
                txtNDepartamento.Visible = false;
                textPDepartamento.Visible = false;
                txtNDepartamento.Enabled = false;
                textPDepartamento.Enabled = false;
                Lista = TA.LeerArchivo(x);
            }
        }

        private void Rentas_Load_1(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int indice = cbxTipo.SelectedIndex;
            txtCalle.Enabled = true;
            cbxEstado.Enabled = true;
            txtCosto.Enabled = true;
            txtMTS2.Enabled = true;
            txtImagen.Enabled = true;
            btnImagen.Enabled = true;
            cbxBañoC.Enabled = true;
            cbxCuarto.Enabled = true;
            txtPiso.Enabled = true;
            chbxLavado.Enabled = true;
            chbxComedor.Enabled = true;
            chbxSala.Enabled = true;
            chbxCocina.Enabled = true;
            cbxBañoM.Enabled = true;
            txtNumero.Enabled = true;
            txtColonia.Enabled = true;
            btnGuardar.Enabled = true;
            if (chbxCochera.Checked == true)
            {
                txtNcupos.Enabled = true;
            }
            else
            {
                txtNcupos.Enabled = false;
            }
            if (indice == 0)
            {
                x = 2;
                lblNdepartamento.Visible = true;
                lblPdepartamento.Visible = true;
                txtNDepartamento.Visible = true;
                textPDepartamento.Visible = true;
                txtNDepartamento.Enabled = true;
                textPDepartamento.Enabled = true;
                Lista = TA.LeerArchivo(x);
            }
            else
            {
                x = 1;
                lblNdepartamento.Visible = false;
                lblPdepartamento.Visible = false;
                txtNDepartamento.Visible = false;
                textPDepartamento.Visible = false;
                txtNDepartamento.Enabled = false;
                textPDepartamento.Enabled = false;
                Lista = TA.LeerArchivo(x);
            }
        }

        private void btnImagen_Click_2(object sender, EventArgs e)
        {
            String rutaArchivo = String.Empty;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                rutaArchivo = openFileDialog.FileName;
            }
            txtImagen.Text = rutaArchivo;
        }

        private void btnImagen_Click_1(object sender, EventArgs e)
        {

            String rutaArchivo = String.Empty;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                rutaArchivo = openFileDialog.FileName;
            }
            txtImagen.Text = rutaArchivo;
        }
    }
}
