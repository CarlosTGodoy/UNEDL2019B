namespace Bienes_Raices
{
    partial class DeptoDisponibleVenta
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
            this.btnVenta = new System.Windows.Forms.Button();
            this.rtbInfoDepto = new System.Windows.Forms.RichTextBox();
            this.lblDeptosVendidas = new System.Windows.Forms.Label();
            this.pbxDepto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDepto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVenta
            // 
            this.btnVenta.BackColor = System.Drawing.Color.GreenYellow;
            this.btnVenta.Location = new System.Drawing.Point(43, 215);
            this.btnVenta.Name = "btnVenta";
            this.btnVenta.Size = new System.Drawing.Size(176, 43);
            this.btnVenta.TabIndex = 46;
            this.btnVenta.Text = "Vender";
            this.btnVenta.UseVisualStyleBackColor = false;
            this.btnVenta.Click += new System.EventHandler(this.btnVenta_Click);
            // 
            // rtbInfoDepto
            // 
            this.rtbInfoDepto.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.rtbInfoDepto.Location = new System.Drawing.Point(242, 92);
            this.rtbInfoDepto.Name = "rtbInfoDepto";
            this.rtbInfoDepto.Size = new System.Drawing.Size(515, 329);
            this.rtbInfoDepto.TabIndex = 45;
            this.rtbInfoDepto.Text = "";
            this.rtbInfoDepto.TextChanged += new System.EventHandler(this.rtbInfoDepto_TextChanged);
            // 
            // lblDeptosVendidas
            // 
            this.lblDeptosVendidas.AutoSize = true;
            this.lblDeptosVendidas.Font = new System.Drawing.Font("Sitka Small", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeptosVendidas.Location = new System.Drawing.Point(220, 29);
            this.lblDeptosVendidas.Name = "lblDeptosVendidas";
            this.lblDeptosVendidas.Size = new System.Drawing.Size(411, 35);
            this.lblDeptosVendidas.TabIndex = 44;
            this.lblDeptosVendidas.Text = "Información del Departamento";
            // 
            // pbxDepto
            // 
            this.pbxDepto.Image = global::Bienes_Raices.Properties.Resources.LogoDepto;
            this.pbxDepto.Location = new System.Drawing.Point(43, 92);
            this.pbxDepto.Margin = new System.Windows.Forms.Padding(4);
            this.pbxDepto.Name = "pbxDepto";
            this.pbxDepto.Size = new System.Drawing.Size(176, 116);
            this.pbxDepto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxDepto.TabIndex = 48;
            this.pbxDepto.TabStop = false;
            this.pbxDepto.Click += new System.EventHandler(this.pbxDepto_Click);
            // 
            // DeptoDisponibleVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbxDepto);
            this.Controls.Add(this.btnVenta);
            this.Controls.Add(this.rtbInfoDepto);
            this.Controls.Add(this.lblDeptosVendidas);
            this.Name = "DeptoDisponibleVenta";
            this.Text = "Información Departamento";
            this.Load += new System.EventHandler(this.DeptoDisponibleVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxDepto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnVenta;
        private System.Windows.Forms.RichTextBox rtbInfoDepto;
        private System.Windows.Forms.Label lblDeptosVendidas;
        private System.Windows.Forms.PictureBox pbxDepto;
    }
}