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
    public partial class CasaDisponibleRenta : Form
    {
        string id;
        public CasaDisponibleRenta()
        {
            InitializeComponent();
        }

        private void btnRentar_Click(object sender, EventArgs e)
        {
            this.Close();
            InitializeComponent();
            RegistroCliente regcli = new RegistroCliente();
            regcli.GenerarVenta(id);
        }

        public void MostrarInfoCasa(string Casa, string image, string idCasa)
        {
            this.Show();
            rtbInfoCasa.Text = Casa;
            pbxCasa.Image = Image.FromFile(@image);
            id = idCasa;
        }

        private void CasaDisponibleRenta_Load(object sender, EventArgs e)
        {

        }
    }
}
