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
    public partial class CasaDisponibleVenta : Form
    {
        string id;
        public CasaDisponibleVenta()
        {
            InitializeComponent();
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            this.Close();
            InitializeComponent();
            RegistroCliente regcli = new RegistroCliente();
            regcli.GenerarVenta(id);
        }

        private void CasaDisponibleVenta_Load(object sender, EventArgs e)
        {

        }

        public void MostrarInfoCasa(string Casa, string image, string idCasa)
        {
            this.Show();
            rtbInfoCasa.Text = Casa;
            pbxCasa.Image = Image.FromFile(@image);
            id = idCasa;
        }

        private void pbxCasa_Click(object sender, EventArgs e)
        {

        }

        private void rtbInfoCasa_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
