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
            this.btnIgrajSam = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnIgrajSam
            // 
            this.btnIgrajSam.Location = new System.Drawing.Point(65, 118);
            this.btnIgrajSam.Name = "btnIgrajSam";
            this.btnIgrajSam.Size = new System.Drawing.Size(295, 203);
            this.btnIgrajSam.TabIndex = 0;
            this.btnIgrajSam.Text = "Kompjuter smisli, igrac pogadja";
            this.btnIgrajSam.UseVisualStyleBackColor = true;
            this.btnIgrajSam.Click += new System.EventHandler(this.btnIgrajSam_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(452, 118);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(295, 203);
            this.button2.TabIndex = 1;
            this.button2.Text = "Igrac smisli, kompjuter pogadja";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnIgrajSam);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIgrajSam;
        private System.Windows.Forms.Button button2;
    }
}

