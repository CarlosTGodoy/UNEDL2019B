namespace Bienes_Raices
{
    partial class CasasVendidas
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
            this.lblCasasVendidas = new System.Windows.Forms.Label();
            this.rtbInfoCasa = new System.Windows.Forms.RichTextBox();
            this.rtbInfoComprador = new System.Windows.Forms.RichTextBox();
            this.lblInfoRentador = new System.Windows.Forms.Label();
            this.lblInfoCasa = new System.Windows.Forms.Label();
            this.pbxAdelante = new System.Windows.Forms.PictureBox();
            this.pbxCasa = new System.Windows.Forms.PictureBox();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAdelante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCasa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCasasVendidas
            // 
            this.lblCasasVendidas.AutoSize = true;
            this.lblCasasVendidas.Font = new System.Drawing.Font("Sitka Small", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCasasVendidas.Location = new System.Drawing.Point(303, 0);
            this.lblCasasVendidas.Name = "lblCasasVendidas";
            this.lblCasasVendidas.Size = new System.Drawing.Size(210, 35);
            this.lblCasasVendidas.TabIndex = 1;
            this.lblCasasVendidas.Text = "Casas Vendidas";
            this.lblCasasVendidas.Click += new System.EventHandler(this.lblCasasVendidas_Click);
            // 
            // rtbInfoCasa
            // 
            this.rtbInfoCasa.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.rtbInfoCasa.Location = new System.Drawing.Point(279, 89);
            this.rtbInfoCasa.Name = "rtbInfoCasa";
            this.rtbInfoCasa.Size = new System.Drawing.Size(216, 332);
            this.rtbInfoCasa.TabIndex = 7;
            this.rtbInfoCasa.Text = "";
            // 
            // rtbInfoComprador
            // 
            this.rtbInfoComprador.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.rtbInfoComprador.Location = new System.Drawing.Point(498, 89);
            this.rtbInfoComprador.Name = "rtbInfoComprador";
            this.rtbInfoComprador.Size = new System.Drawing.Size(227, 332);
            this.rtbInfoComprador.TabIndex = 10;
            this.rtbInfoComprador.Text = "";
            this.rtbInfoComprador.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // lblInfoRentador
            // 
            this.lblInfoRentador.AutoSize = true;
            this.lblInfoRentador.Location = new System.Drawing.Point(501, 76);
            this.lblInfoRentador.Name = "lblInfoRentador";
            this.lblInfoRentador.Size = new System.Drawing.Size(118, 13);
            this.lblInfoRentador.TabIndex = 32;
            this.lblInfoRentador.Text = "Información del Usuario";
            // 
            // lblInfoCasa
            // 
            this.lblInfoCasa.AutoSize = true;
            this.lblInfoCasa.Location = new System.Drawing.Point(282, 76);
            this.lblInfoCasa.Name = "lblInfoCasa";
            this.lblInfoCasa.Size = new System.Drawing.Size(115, 13);
            this.lblInfoCasa.TabIndex = 31;
            this.lblInfoCasa.Text = "Información de la Casa";
            // 
            // pbxAdelante
            // 
            this.pbxAdelante.Image = global::Bienes_Raices.Properties.Resources.adelante;
            this.pbxAdelante.Location = new System.Drawing.Point(738, 200);
            this.pbxAdelante.Margin = new System.Windows.Forms.Padding(4);
            this.pbxAdelante.Name = "pbxAdelante";
            this.pbxAdelante.Size = new System.Drawing.Size(49, 39);
            this.pbxAdelante.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxAdelante.TabIndex = 12;
            this.pbxAdelante.TabStop = false;
            this.pbxAdelante.Click += new System.EventHandler(this.pbxAdelante_Click);
            // 
            // pbxCasa
            // 
            this.pbxCasa.Image = global::Bienes_Raices.Properties.Resources.logoCasa;
            this.pbxCasa.Location = new System.Drawing.Point(26, 76);
            this.pbxCasa.Margin = new System.Windows.Forms.Padding(4);
            this.pbxCasa.Name = "pbxCasa";
            this.pbxCasa.Size = new System.Drawing.Size(246, 154);
            this.pbxCasa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxCasa.TabIndex = 9;
            this.pbxCasa.TabStop = false;
            this.pbxCasa.Click += new System.EventHandler(this.pbxCasa_Click);
            // 
            // pbxLogo
            // 
            this.pbxLogo.Image = global::Bienes_Raices.Properties.Resources.logoCasa;
            this.pbxLogo.Location = new System.Drawing.Point(252, 0);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(35, 34);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxLogo.TabIndex = 8;
            this.pbxLogo.TabStop = false;
            this.pbxLogo.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // CasasVendidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblInfoRentador);
            this.Controls.Add(this.lblInfoCasa);
            this.Controls.Add(this.pbxAdelante);
            this.Controls.Add(this.rtbInfoComprador);
            this.Controls.Add(this.pbxCasa);
            this.Controls.Add(this.pbxLogo);
            this.Controls.Add(this.rtbInfoCasa);
            this.Controls.Add(this.lblCasasVendidas);
            this.Name = "CasasVendidas";
            this.Text = "Casas Vendidas";
            this.Load += new System.EventHandler(this.CasasVendidas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxAdelante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCasa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCasasVendidas;
        private System.Windows.Forms.RichTextBox rtbInfoCasa;
        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.PictureBox pbxCasa;
        private System.Windows.Forms.RichTextBox rtbInfoComprador;
        private System.Windows.Forms.PictureBox pbxAdelante;
        private System.Windows.Forms.Label lblInfoRentador;
        private System.Windows.Forms.Label lblInfoCasa;
    }
}