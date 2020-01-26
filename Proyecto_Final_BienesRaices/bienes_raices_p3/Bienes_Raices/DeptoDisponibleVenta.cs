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
    public partial class DeptoDisponibleVenta : Form
    {
        string id = "";
        public DeptoDisponibleVenta()
        {
            InitializeComponent();
        }

        private void btnVenta_Click(object sender, EventArgs e)
        {
            this.Close();
            InitializeComponent();
            RegistroCliente regcli = new RegistroCliente();
            regcli.GenerarVenta(id);
        }

        private void DeptoDisponibleVenta_Load(object sender, EventArgs e)
        {

        }

        private void pbxDepto_Click(object sender, EventArgs e)
        {

        }

        private void rtbInfoDepto_TextChanged(object sender, EventArgs e)
        {

        }

        public void MostrarInfoDepto(string Depto, string image2, string idDepto)
        {
            this.Show();
            rtbInfoDepto.Text = Depto;
            pbxDepto.Image = Image.FromFile(@image2);
            id = idDepto;
        }
    }
}
