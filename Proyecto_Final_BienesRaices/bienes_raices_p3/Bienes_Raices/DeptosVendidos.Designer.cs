namespace Bienes_Raices
{
    partial class DeptosVendidos
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
            this.rtbInfoRentador = new System.Windows.Forms.RichTextBox();
            this.rtbInfoDepto = new System.Windows.Forms.RichTextBox();
            this.lblDeptosVendidas = new System.Windows.Forms.Label();
            this.lblInfoDepto = new System.Windows.Forms.Label();
            this.lblInfoRentador = new System.Windows.Forms.Label();
            this.pbxDepto = new System.Windows.Forms.PictureBox();
            this.pbxAdelante = new System.Windows.Forms.PictureBox();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDepto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAdelante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // rtbInfoRentador
            // 
            this.rtbInfoRentador.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.rtbInfoRentador.Location = new System.Drawing.Point(489, 103);
            this.rtbInfoRentador.Name = "rtbInfoRentador";
            this.rtbInfoRentador.Size = new System.Drawing.Size(236, 345);
            this.rtbInfoRentador.TabIndex = 32;
            this.rtbInfoRentador.Text = "";
            this.rtbInfoRentador.TextChanged += new System.EventHandler(this.rtbInfoRentador_TextChanged);
            // 
            // rtbInfoDepto
            // 
            this.rtbInfoDepto.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.rtbInfoDepto.Location = new System.Drawing.Point(247, 103);
            this.rtbInfoDepto.Name = "rtbInfoDepto";
            this.rtbInfoDepto.Size = new System.Drawing.Size(236, 331);
            this.rtbInfoDepto.TabIndex = 31;
            this.rtbInfoDepto.Text = "";
            this.rtbInfoDepto.TextChanged += new System.EventHandler(this.rtbInfoDepto_TextChanged);
            // 
            // lblDeptosVendidas
            // 
            this.lblDeptosVendidas.AutoSize = true;
            this.lblDeptosVendidas.Font = new System.Drawing.Font("Sitka Small", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeptosVendidas.Location = new System.Drawing.Point(264, 25);
            this.lblDeptosVendidas.Name = "lblDeptosVendidas";
            this.lblDeptosVendidas.Size = new System.Drawing.Size(335, 35);
            this.lblDeptosVendidas.TabIndex = 30;
            this.lblDeptosVendidas.Text = "Departamentos Vendidos";
            // 
            // lblInfoDepto
            // 
            this.lblInfoDepto.AutoSize = true;
            this.lblInfoDepto.Location = new System.Drawing.Point(247, 87);
            this.lblInfoDepto.Name = "lblInfoDepto";
            this.lblInfoDepto.Size = new System.Drawing.Size(111, 13);
            this.lblInfoDepto.TabIndex = 36;
            this.lblInfoDepto.Text = "Información del Depto";
            // 
            // lblInfoRentador
            // 
            this.lblInfoRentador.AutoSize = true;
            this.lblInfoRentador.Location = new System.Drawing.Point(491, 87);
            this.lblInfoRentador.Name = "lblInfoRentador";
            this.lblInfoRentador.Size = new System.Drawing.Size(118, 13);
            this.lblInfoRentador.TabIndex = 37;
            this.lblInfoRentador.Text = "Información del Usuario";
            // 
            // pbxDepto
            // 
            this.pbxDepto.Image = global::Bienes_Raices.Properties.Resources.LogoDepto;
            this.pbxDepto.Location = new System.Drawing.Point(65, 89);
            this.pbxDepto.Name = "pbxDepto";
            this.pbxDepto.Size = new System.Drawing.Size(176, 116);
            this.pbxDepto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxDepto.TabIndex = 35;
            this.pbxDepto.TabStop = false;
            this.pbxDepto.Click += new System.EventHandler(this.pbxDepto_Click);
            // 
            // pbxAdelante
            // 
            this.pbxAdelante.Image = global::Bienes_Raices.Properties.Resources.adelante;
            this.pbxAdelante.Location = new System.Drawing.Point(738, 213);
            this.pbxAdelante.Margin = new System.Windows.Forms.Padding(4);
            this.pbxAdelante.Name = "pbxAdelante";
            this.pbxAdelante.Size = new System.Drawing.Size(49, 39);
            this.pbxAdelante.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxAdelante.TabIndex = 34;
            this.pbxAdelante.TabStop = false;
            this.pbxAdelante.Click += new System.EventHandler(this.pbxAdelante_Click);
            // 
            // pbxLogo
            // 
            this.pbxLogo.Image = global::Bienes_Raices.Properties.Resources.LogoDepto;
            this.pbxLogo.Location = new System.Drawing.Point(227, 17);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(31, 52);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxLogo.TabIndex = 29;
            this.pbxLogo.TabStop = false;
            // 
            // DeptosVendidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblInfoRentador);
            this.Controls.Add(this.lblInfoDepto);
            this.Controls.Add(this.pbxDepto);
            this.Controls.Add(this.pbxAdelante);
            this.Controls.Add(this.rtbInfoRentador);
            this.Controls.Add(this.rtbInfoDepto);
            this.Controls.Add(this.lblDeptosVendidas);
            this.Controls.Add(this.pbxLogo);
            this.Name = "DeptosVendidos";
            this.Text = "Departamentos Vendidos";
            this.Load += new System.EventHandler(this.DeptosVendidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxDepto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAdelante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxDepto;
        private System.Windows.Forms.PictureBox pbxAdelante;
        private System.Windows.Forms.RichTextBox rtbInfoRentador;
        private System.Windows.Forms.RichTextBox rtbInfoDepto;
        private System.Windows.Forms.Label lblDeptosVendidas;
        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.Label lblInfoDepto;
        private System.Windows.Forms.Label lblInfoRentador;
    }
}