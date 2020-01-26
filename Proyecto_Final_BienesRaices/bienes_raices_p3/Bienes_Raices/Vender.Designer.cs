namespace Bienes_Raices
{
    partial class Vender
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblVentas = new System.Windows.Forms.Label();
            this.lblCasasDisponibles = new System.Windows.Forms.Label();
            this.lblDeptosDisponibles = new System.Windows.Forms.Label();
            this.btnAdelante1 = new System.Windows.Forms.PictureBox();
            this.btnAdelante2 = new System.Windows.Forms.PictureBox();
            this.pbxCasa = new System.Windows.Forms.PictureBox();
            this.pbxDepto = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdelante1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdelante2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCasa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDepto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblVentas
            // 
            this.lblVentas.AutoSize = true;
            this.lblVentas.Font = new System.Drawing.Font("Sitka Small", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVentas.Location = new System.Drawing.Point(281, 30);
            this.lblVentas.Name = "lblVentas";
            this.lblVentas.Size = new System.Drawing.Size(200, 35);
            this.lblVentas.TabIndex = 24;
            this.lblVentas.Text = "Generar Venta";
            // 
            // lblCasasDisponibles
            // 
            this.lblCasasDisponibles.AutoSize = true;
            this.lblCasasDisponibles.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCasasDisponibles.Location = new System.Drawing.Point(48, 95);
            this.lblCasasDisponibles.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCasasDisponibles.Name = "lblCasasDisponibles";
            this.lblCasasDisponibles.Size = new System.Drawing.Size(199, 28);
            this.lblCasasDisponibles.TabIndex = 25;
            this.lblCasasDisponibles.Text = "Casas Disponibles";
            // 
            // lblDeptosDisponibles
            // 
            this.lblDeptosDisponibles.AutoSize = true;
            this.lblDeptosDisponibles.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeptosDisponibles.Location = new System.Drawing.Point(460, 95);
            this.lblDeptosDisponibles.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDeptosDisponibles.Name = "lblDeptosDisponibles";
            this.lblDeptosDisponibles.Size = new System.Drawing.Size(217, 28);
            this.lblDeptosDisponibles.TabIndex = 26;
            this.lblDeptosDisponibles.Text = "Deptos Disponibles";
            // 
            // btnAdelante1
            // 
            this.btnAdelante1.Image = global::Bienes_Raices.Properties.Resources.adelante;
            this.btnAdelante1.Location = new System.Drawing.Point(301, 248);
            this.btnAdelante1.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdelante1.Name = "btnAdelante1";
            this.btnAdelante1.Size = new System.Drawing.Size(49, 39);
            this.btnAdelante1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAdelante1.TabIndex = 38;
            this.btnAdelante1.TabStop = false;
            this.btnAdelante1.Click += new System.EventHandler(this.btnAdelante1_Click);
            // 
            // btnAdelante2
            // 
            this.btnAdelante2.Image = global::Bienes_Raices.Properties.Resources.adelante;
            this.btnAdelante2.Location = new System.Drawing.Point(702, 248);
            this.btnAdelante2.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdelante2.Name = "btnAdelante2";
            this.btnAdelante2.Size = new System.Drawing.Size(49, 39);
            this.btnAdelante2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAdelante2.TabIndex = 36;
            this.btnAdelante2.TabStop = false;
            this.btnAdelante2.Click += new System.EventHandler(this.btnAdelante2_Click);
            // 
            // pbxCasa
            // 
            this.pbxCasa.Image = global::Bienes_Raices.Properties.Resources.logoCasa;
            this.pbxCasa.Location = new System.Drawing.Point(96, 213);
            this.pbxCasa.Margin = new System.Windows.Forms.Padding(4);
            this.pbxCasa.Name = "pbxCasa";
            this.pbxCasa.Size = new System.Drawing.Size(196, 122);
            this.pbxCasa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxCasa.TabIndex = 30;
            this.pbxCasa.TabStop = false;
            this.pbxCasa.Click += new System.EventHandler(this.pbxCasa_Click);
            // 
            // pbxDepto
            // 
            this.pbxDepto.Image = global::Bienes_Raices.Properties.Resources.LogoDepto;
            this.pbxDepto.Location = new System.Drawing.Point(499, 213);
            this.pbxDepto.Name = "pbxDepto";
            this.pbxDepto.Size = new System.Drawing.Size(196, 122);
            this.pbxDepto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxDepto.TabIndex = 29;
            this.pbxDepto.TabStop = false;
            this.pbxDepto.Click += new System.EventHandler(this.pbxDepto_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Bienes_Raices.Properties.Resources.logoCasa;
            this.pictureBox1.Location = new System.Drawing.Point(264, 83);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(58, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // pbxLogo
            // 
            this.pbxLogo.Image = global::Bienes_Raices.Properties.Resources.LogoDepto;
            this.pbxLogo.Location = new System.Drawing.Point(698, 83);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(31, 52);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxLogo.TabIndex = 23;
            this.pbxLogo.TabStop = false;
            // 
            // Vender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAdelante1);
            this.Controls.Add(this.btnAdelante2);
            this.Controls.Add(this.pbxCasa);
            this.Controls.Add(this.pbxDepto);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblDeptosDisponibles);
            this.Controls.Add(this.lblCasasDisponibles);
            this.Controls.Add(this.lblVentas);
            this.Controls.Add(this.pbxLogo);
            this.Name = "Vender";
            this.Text = "Vender";
            this.Load += new System.EventHandler(this.Vender_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnAdelante1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdelante2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCasa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDepto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVentas;
        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.Label lblCasasDisponibles;
        private System.Windows.Forms.Label lblDeptosDisponibles;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbxDepto;
        private System.Windows.Forms.PictureBox pbxCasa;
        private System.Windows.Forms.PictureBox btnAdelante2;
        private System.Windows.Forms.PictureBox btnAdelante1;
    }
}