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
    public partial class DeptoDisponibleRenta : Form
    {
        string id;
        public DeptoDisponibleRenta()
        {
            InitializeComponent();
        }

        private void btnRenta_Click(object sender, EventArgs e)
        {
            this.Close();
            InitializeComponent();
            RegistroCliente regcli = new RegistroCliente();
            regcli.GenerarVenta(id);
        }

        private void DeptoDisponibleRenta_Load(object sender, EventArgs e)
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
