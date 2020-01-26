namespace Bienes_Raices
{
    partial class CasaDisponibleRenta
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
            this.btnRentar = new System.Windows.Forms.Button();
            this.rtbInfoCasa = new System.Windows.Forms.RichTextBox();
            this.lblDeptosVendidas = new System.Windows.Forms.Label();
            this.pbxCasa = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCasa)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRentar
            // 
            this.btnRentar.BackColor = System.Drawing.Color.GreenYellow;
            this.btnRentar.Location = new System.Drawing.Point(43, 215);
            this.btnRentar.Name = "btnRentar";
            this.btnRentar.Size = new System.Drawing.Size(176, 43);
            this.btnRentar.TabIndex = 42;
            this.btnRentar.Text = "Rentar";
            this.btnRentar.UseVisualStyleBackColor = false;
            this.btnRentar.Click += new System.EventHandler(this.btnRentar_Click);
            // 
            // rtbInfoCasa
            // 
            this.rtbInfoCasa.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.rtbInfoCasa.Location = new System.Drawing.Point(242, 92);
            this.rtbInfoCasa.Name = "rtbInfoCasa";
            this.rtbInfoCasa.Size = new System.Drawing.Size(515, 329);
            this.rtbInfoCasa.TabIndex = 41;
            this.rtbInfoCasa.Text = "";
            // 
            // lblDeptosVendidas
            // 
            this.lblDeptosVendidas.AutoSize = true;
            this.lblDeptosVendidas.Font = new System.Drawing.Font("Sitka Small", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeptosVendidas.Location = new System.Drawing.Point(220, 29);
            this.lblDeptosVendidas.Name = "lblDeptosVendidas";
            this.lblDeptosVendidas.Size = new System.Drawing.Size(308, 35);
            this.lblDeptosVendidas.TabIndex = 40;
            this.lblDeptosVendidas.Text = "Información de la Casa";
            // 
            // pbxCasa
            // 
            this.pbxCasa.Image = global::Bienes_Raices.Properties.Resources.logoCasa;
            this.pbxCasa.Location = new System.Drawing.Point(43, 92);
            this.pbxCasa.Margin = new System.Windows.Forms.Padding(4);
            this.pbxCasa.Name = "pbxCasa";
            this.pbxCasa.Size = new System.Drawing.Size(176, 116);
            this.pbxCasa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxCasa.TabIndex = 43;
            this.pbxCasa.TabStop = false;
            // 
            // CasaDisponibleRenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbxCasa);
            this.Controls.Add(this.btnRentar);
            this.Controls.Add(this.rtbInfoCasa);
            this.Controls.Add(this.lblDeptosVendidas);
            this.Name = "CasaDisponibleRenta";
            this.Text = "Información de la Casa";
            this.Load += new System.EventHandler(this.CasaDisponibleRenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxCasa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxCasa;
        private System.Windows.Forms.Button btnRentar;
        private System.Windows.Forms.RichTextBox rtbInfoCasa;
        private System.Windows.Forms.Label lblDeptosVendidas;
    }
}