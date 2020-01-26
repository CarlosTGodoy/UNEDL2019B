namespace Bienes_Raices
{
    partial class Rentar
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
            this.lblDeptosDisponibles = new System.Windows.Forms.Label();
            this.lblCasasDisponibles = new System.Windows.Forms.Label();
            this.lblRenta = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pbxAdelante = new System.Windows.Forms.PictureBox();
            this.pbxCasa = new System.Windows.Forms.PictureBox();
            this.pbxDepto = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAdelante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCasa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDepto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDeptosDisponibles
            // 
            this.lblDeptosDisponibles.AutoSize = true;
            this.lblDeptosDisponibles.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeptosDisponibles.Location = new System.Drawing.Point(461, 87);
            this.lblDeptosDisponibles.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDeptosDisponibles.Name = "lblDeptosDisponibles";
            this.lblDeptosDisponibles.Size = new System.Drawing.Size(217, 28);
            this.lblDeptosDisponibles.TabIndex = 42;
            this.lblDeptosDisponibles.Text = "Deptos Disponibles";
            // 
            // lblCasasDisponibles
            // 
            this.lblCasasDisponibles.AutoSize = true;
            this.lblCasasDisponibles.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCasasDisponibles.Location = new System.Drawing.Point(49, 87);
            this.lblCasasDisponibles.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCasasDisponibles.Name = "lblCasasDisponibles";
            this.lblCasasDisponibles.Size = new System.Drawing.Size(199, 28);
            this.lblCasasDisponibles.TabIndex = 41;
            this.lblCasasDisponibles.Text = "Casas Disponibles";
            // 
            // lblRenta
            // 
            this.lblRenta.AutoSize = true;
            this.lblRenta.Font = new System.Drawing.Font("Sitka Small", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRenta.Location = new System.Drawing.Point(282, 22);
            this.lblRenta.Name = "lblRenta";
            this.lblRenta.Size = new System.Drawing.Size(202, 35);
            this.lblRenta.TabIndex = 40;
            this.lblRenta.Text = "Generar Renta";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Bienes_Raices.Properties.Resources.adelante;
            this.pictureBox2.Location = new System.Drawing.Point(302, 240);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(49, 39);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 49;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pbxAdelante
            // 
            this.pbxAdelante.Image = global::Bienes_Raices.Properties.Resources.adelante;
            this.pbxAdelante.Location = new System.Drawing.Point(703, 240);
            this.pbxAdelante.Margin = new System.Windows.Forms.Padding(4);
            this.pbxAdelante.Name = "pbxAdelante";
            this.pbxAdelante.Size = new System.Drawing.Size(49, 39);
            this.pbxAdelante.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxAdelante.TabIndex = 47;
            this.pbxAdelante.TabStop = false;
            this.pbxAdelante.Click += new System.EventHandler(this.pbxAdelante_Click);
            // 
            // pbxCasa
            // 
            this.pbxCasa.Image = global::Bienes_Raices.Properties.Resources.logoCasa;
            this.pbxCasa.Location = new System.Drawing.Point(97, 205);
            this.pbxCasa.Margin = new System.Windows.Forms.Padding(4);
            this.pbxCasa.Name = "pbxCasa";
            this.pbxCasa.Size = new System.Drawing.Size(196, 122);
            this.pbxCasa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxCasa.TabIndex = 45;
            this.pbxCasa.TabStop = false;
            this.pbxCasa.Click += new System.EventHandler(this.pbxCasa_Click);
            // 
            // pbxDepto
            // 
            this.pbxDepto.Image = global::Bienes_Raices.Properties.Resources.LogoDepto;
            this.pbxDepto.Location = new System.Drawing.Point(500, 205);
            this.pbxDepto.Name = "pbxDepto";
            this.pbxDepto.Size = new System.Drawing.Size(196, 122);
            this.pbxDepto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxDepto.TabIndex = 44;
            this.pbxDepto.TabStop = false;
            this.pbxDepto.Click += new System.EventHandler(this.pbxDepto_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Bienes_Raices.Properties.Resources.logoCasa;
            this.pictureBox1.Location = new System.Drawing.Point(265, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(58, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            // 
            // pbxLogo
            // 
            this.pbxLogo.Image = global::Bienes_Raices.Properties.Resources.LogoDepto;
            this.pbxLogo.Location = new System.Drawing.Point(699, 75);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(31, 52);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxLogo.TabIndex = 39;
            this.pbxLogo.TabStop = false;
            // 
            // Rentar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pbxAdelante);
            this.Controls.Add(this.pbxCasa);
            this.Controls.Add(this.pbxDepto);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblDeptosDisponibles);
            this.Controls.Add(this.lblCasasDisponibles);
            this.Controls.Add(this.lblRenta);
            this.Controls.Add(this.pbxLogo);
            this.Name = "Rentar";
            this.Text = "Rentar";
            this.Load += new System.EventHandler(this.Rentar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAdelante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCasa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDepto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pbxAdelante;
        private System.Windows.Forms.PictureBox pbxCasa;
        private System.Windows.Forms.PictureBox pbxDepto;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblDeptosDisponibles;
        private System.Windows.Forms.Label lblCasasDisponibles;
        private System.Windows.Forms.Label lblRenta;
        private System.Windows.Forms.PictureBox pbxLogo;
    }
}