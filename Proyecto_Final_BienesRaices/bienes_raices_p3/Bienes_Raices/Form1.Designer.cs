namespace Bienes_Raices
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.MenuPrincipal = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarCasaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.rentaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.stockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.casasVendidasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.casasEnRentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deptosVendidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deptosRentadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.descripciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuPrincipal
            // 
            this.MenuPrincipal.BackgroundImage = global::Bienes_Raices.Properties.Resources.Fondo_boton_menu1;
            this.MenuPrincipal.Dock = System.Windows.Forms.DockStyle.None;
            this.MenuPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuPrincipal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.operationToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.MenuPrincipal.Location = new System.Drawing.Point(622, 32);
            this.MenuPrincipal.Name = "MenuPrincipal";
            this.MenuPrincipal.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.MenuPrincipal.Size = new System.Drawing.Size(291, 37);
            this.MenuPrincipal.TabIndex = 12;
            this.MenuPrincipal.Text = "MenuPrincipal";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarCasaToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(66, 33);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // registrarCasaToolStripMenuItem
            // 
            this.registrarCasaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ventaToolStripMenuItem,
            this.rentaToolStripMenuItem});
            this.registrarCasaToolStripMenuItem.Name = "registrarCasaToolStripMenuItem";
            this.registrarCasaToolStripMenuItem.Size = new System.Drawing.Size(184, 34);
            this.registrarCasaToolStripMenuItem.Text = "Registrar";
            this.registrarCasaToolStripMenuItem.Click += new System.EventHandler(this.registrarCasaToolStripMenuItem_Click);
            // 
            // ventaToolStripMenuItem
            // 
            this.ventaToolStripMenuItem.Name = "ventaToolStripMenuItem";
            this.ventaToolStripMenuItem.Size = new System.Drawing.Size(149, 34);
            this.ventaToolStripMenuItem.Text = "Venta";
            this.ventaToolStripMenuItem.Click += new System.EventHandler(this.ventaToolStripMenuItem_Click);
            // 
            // rentaToolStripMenuItem
            // 
            this.rentaToolStripMenuItem.Name = "rentaToolStripMenuItem";
            this.rentaToolStripMenuItem.Size = new System.Drawing.Size(149, 34);
            this.rentaToolStripMenuItem.Text = "Renta";
            this.rentaToolStripMenuItem.Click += new System.EventHandler(this.rentaToolStripMenuItem_Click);
            // 
            // operationToolStripMenuItem
            // 
            this.operationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ventaToolStripMenuItem1,
            this.rentaToolStripMenuItem1,
            this.stockToolStripMenuItem,
            this.casasVendidasToolStripMenuItem,
            this.casasEnRentaToolStripMenuItem,
            this.deptosVendidosToolStripMenuItem,
            this.deptosRentadosToolStripMenuItem});
            this.operationToolStripMenuItem.Name = "operationToolStripMenuItem";
            this.operationToolStripMenuItem.Size = new System.Drawing.Size(132, 33);
            this.operationToolStripMenuItem.Text = "Operation";
            // 
            // ventaToolStripMenuItem1
            // 
            this.ventaToolStripMenuItem1.Name = "ventaToolStripMenuItem1";
            this.ventaToolStripMenuItem1.Size = new System.Drawing.Size(272, 34);
            this.ventaToolStripMenuItem1.Text = "Venta";
            this.ventaToolStripMenuItem1.Click += new System.EventHandler(this.ventaToolStripMenuItem1_Click);
            // 
            // rentaToolStripMenuItem1
            // 
            this.rentaToolStripMenuItem1.Name = "rentaToolStripMenuItem1";
            this.rentaToolStripMenuItem1.Size = new System.Drawing.Size(272, 34);
            this.rentaToolStripMenuItem1.Text = "Renta";
            this.rentaToolStripMenuItem1.Click += new System.EventHandler(this.rentaToolStripMenuItem1_Click);
            // 
            // stockToolStripMenuItem
            // 
            this.stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            this.stockToolStripMenuItem.Size = new System.Drawing.Size(272, 34);
            this.stockToolStripMenuItem.Text = "Stock";
            this.stockToolStripMenuItem.Click += new System.EventHandler(this.stockToolStripMenuItem_Click);
            // 
            // casasVendidasToolStripMenuItem
            // 
            this.casasVendidasToolStripMenuItem.Name = "casasVendidasToolStripMenuItem";
            this.casasVendidasToolStripMenuItem.Size = new System.Drawing.Size(272, 34);
            this.casasVendidasToolStripMenuItem.Text = "Casas Vendidas";
            this.casasVendidasToolStripMenuItem.Click += new System.EventHandler(this.casasVendidasToolStripMenuItem_Click);
            // 
            // casasEnRentaToolStripMenuItem
            // 
            this.casasEnRentaToolStripMenuItem.Name = "casasEnRentaToolStripMenuItem";
            this.casasEnRentaToolStripMenuItem.Size = new System.Drawing.Size(272, 34);
            this.casasEnRentaToolStripMenuItem.Text = "Casas en Renta";
            this.casasEnRentaToolStripMenuItem.Click += new System.EventHandler(this.casasEnRentaToolStripMenuItem_Click);
            // 
            // deptosVendidosToolStripMenuItem
            // 
            this.deptosVendidosToolStripMenuItem.Name = "deptosVendidosToolStripMenuItem";
            this.deptosVendidosToolStripMenuItem.Size = new System.Drawing.Size(272, 34);
            this.deptosVendidosToolStripMenuItem.Text = "Deptos Vendidos";
            this.deptosVendidosToolStripMenuItem.Click += new System.EventHandler(this.deptosVendidosToolStripMenuItem_Click);
            // 
            // deptosRentadosToolStripMenuItem
            // 
            this.deptosRentadosToolStripMenuItem.Name = "deptosRentadosToolStripMenuItem";
            this.deptosRentadosToolStripMenuItem.Size = new System.Drawing.Size(272, 34);
            this.deptosRentadosToolStripMenuItem.Text = "Deptos Rentados";
            this.deptosRentadosToolStripMenuItem.Click += new System.EventHandler(this.deptosRentadosToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ayudaToolStripMenuItem,
            this.descripciónToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(87, 33);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(214, 34);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            this.ayudaToolStripMenuItem.Click += new System.EventHandler(this.ayudaToolStripMenuItem_Click);
            // 
            // descripciónToolStripMenuItem
            // 
            this.descripciónToolStripMenuItem.Name = "descripciónToolStripMenuItem";
            this.descripciónToolStripMenuItem.Size = new System.Drawing.Size(214, 34);
            this.descripciónToolStripMenuItem.Text = "Descripción";
            this.descripciónToolStripMenuItem.Click += new System.EventHandler(this.descripciónToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 541);
            this.Controls.Add(this.MenuPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuPrincipal;
            this.Name = "Form1";
            this.Text = "Bienes Raíces";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MenuPrincipal.ResumeLayout(false);
            this.MenuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.MenuStrip MenuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarCasaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem rentaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem stockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem casasVendidasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem casasEnRentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem descripciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deptosVendidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deptosRentadosToolStripMenuItem;
    }
}

