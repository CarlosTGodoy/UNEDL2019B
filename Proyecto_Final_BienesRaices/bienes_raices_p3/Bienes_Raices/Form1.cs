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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Bitmap img = new Bitmap(Application.StartupPath + @"\img\interfaz.png");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Transparent;


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            //Damos transparencia al color
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //Damos transparencia al color
            this.BackColor = Color.Transparent;
        }

        private void btnOperations_Click(object sender, EventArgs e)
        {
            //Damos transparencia al color
            this.BackColor = Color.Transparent;
        }

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InitializeComponent();
            Stock stock = new Stock();
            stock.Show();
        }

        private void casasVendidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InitializeComponent();
            CasasVendidas cv = new CasasVendidas();
            cv.Show();
        }

        private void casasEnRentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InitializeComponent();
            CasasRenta cr = new CasasRenta();
            cr.Show();
        }

        private void descripciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InitializeComponent();
            Descripción des = new Descripción();
            des.Show();
        }

        private void ventaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            InitializeComponent();
            Vender v = new Vender();
            v.Show();
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InitializeComponent();
            Ayuda ayu = new Ayuda();
            ayu.Show();
        }

        private void ventaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InitializeComponent();
            Ventas ve = new Ventas();
            ve.Show();
        }

        private void registrarCasaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void rentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InitializeComponent();
            Rentas Re = new Rentas();
            Re.Show();
        }

        private void deptosVendidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InitializeComponent();
            DeptosVendidos dv = new DeptosVendidos();
            dv.Show();
        }

        private void deptosRentadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InitializeComponent();
            DeptosRenta dr = new DeptosRenta();
            dr.Show();
        }

        private void rentaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            InitializeComponent();
            Rentar r = new Rentar();
            r.Show();
        }
    }
}
