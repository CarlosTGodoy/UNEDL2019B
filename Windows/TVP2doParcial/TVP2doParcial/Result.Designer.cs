namespace TVP2doParcial
{
    partial class Result
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
            this.lblPT = new System.Windows.Forms.Label();
            this.lblPR = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPT
            // 
            this.lblPT.AutoSize = true;
            this.lblPT.Location = new System.Drawing.Point(67, 48);
            this.lblPT.Name = "lblPT";
            this.lblPT.Size = new System.Drawing.Size(92, 13);
            this.lblPT.TabIndex = 0;
            this.lblPT.Text = "Palabras Totales: ";
            // 
            // lblPR
            // 
            this.lblPR.AutoSize = true;
            this.lblPR.Location = new System.Drawing.Point(54, 205);
            this.lblPR.Name = "lblPR";
            this.lblPR.Size = new System.Drawing.Size(105, 13);
            this.lblPR.TabIndex = 1;
            this.lblPR.Text = "Palabras Repetidas: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 2;
            // 
            // Result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 411);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblPR);
            this.Controls.Add(this.lblPT);
            this.Name = "Result";
            this.Text = "Result";
            this.Load += new System.EventHandler(this.Result_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPT;
        private System.Windows.Forms.Label lblPR;
        private System.Windows.Forms.Label label3;
    }
}