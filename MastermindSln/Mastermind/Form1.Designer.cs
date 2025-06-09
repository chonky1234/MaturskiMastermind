namespace Mastermind
{
    partial class Form1
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
            this.btnIgracPogadja = new System.Windows.Forms.Button();
            this.btnKompjuterPogadja = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnIgracPogadja
            // 
            this.btnIgracPogadja.Location = new System.Drawing.Point(65, 118);
            this.btnIgracPogadja.Name = "btnIgracPogadja";
            this.btnIgracPogadja.Size = new System.Drawing.Size(295, 203);
            this.btnIgracPogadja.TabIndex = 0;
            this.btnIgracPogadja.TabStop = false;
            this.btnIgracPogadja.Text = "Kompjuter smisli, igrac pogadja";
            this.btnIgracPogadja.UseVisualStyleBackColor = true;
            this.btnIgracPogadja.Click += new System.EventHandler(this.btnIgracPogadja_Click);
            // 
            // btnKompjuterPogadja
            // 
            this.btnKompjuterPogadja.Location = new System.Drawing.Point(452, 118);
            this.btnKompjuterPogadja.Name = "btnKompjuterPogadja";
            this.btnKompjuterPogadja.Size = new System.Drawing.Size(295, 203);
            this.btnKompjuterPogadja.TabIndex = 1;
            this.btnKompjuterPogadja.TabStop = false;
            this.btnKompjuterPogadja.Text = "Igrac smisli, kompjuter pogadja";
            this.btnKompjuterPogadja.UseVisualStyleBackColor = true;
            this.btnKompjuterPogadja.Click += new System.EventHandler(this.btnKompjuterPogadja_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnKompjuterPogadja);
            this.Controls.Add(this.btnIgracPogadja);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIgracPogadja;
        private System.Windows.Forms.Button btnKompjuterPogadja;
    }
}

