namespace Mastermind
{
    partial class Red
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.boja1 = new System.Windows.Forms.PictureBox();
            this.boja2 = new System.Windows.Forms.PictureBox();
            this.boja3 = new System.Windows.Forms.PictureBox();
            this.boja4 = new System.Windows.Forms.PictureBox();
            this.resenje = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.boja1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boja2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boja3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boja4)).BeginInit();
            this.SuspendLayout();
            // 
            // boja1
            // 
            this.boja1.Location = new System.Drawing.Point(0, 0);
            this.boja1.Name = "boja1";
            this.boja1.Size = new System.Drawing.Size(57, 48);
            this.boja1.TabIndex = 0;
            this.boja1.TabStop = false;
            this.boja1.Click += new System.EventHandler(this.boja1_Click);
            // 
            // boja2
            // 
            this.boja2.Location = new System.Drawing.Point(72, 0);
            this.boja2.Name = "boja2";
            this.boja2.Size = new System.Drawing.Size(55, 48);
            this.boja2.TabIndex = 1;
            this.boja2.TabStop = false;
            this.boja2.Click += new System.EventHandler(this.boja2_Click);
            // 
            // boja3
            // 
            this.boja3.Location = new System.Drawing.Point(142, 0);
            this.boja3.Name = "boja3";
            this.boja3.Size = new System.Drawing.Size(60, 48);
            this.boja3.TabIndex = 2;
            this.boja3.TabStop = false;
            this.boja3.Click += new System.EventHandler(this.boja3_Click);
            // 
            // boja4
            // 
            this.boja4.Location = new System.Drawing.Point(218, 0);
            this.boja4.Name = "boja4";
            this.boja4.Size = new System.Drawing.Size(55, 48);
            this.boja4.TabIndex = 3;
            this.boja4.TabStop = false;
            this.boja4.Click += new System.EventHandler(this.boja4_Click);
            // 
            // resenje
            // 
            this.resenje.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resenje.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resenje.Location = new System.Drawing.Point(297, -6);
            this.resenje.Name = "resenje";
            this.resenje.ReadOnly = true;
            this.resenje.Size = new System.Drawing.Size(100, 54);
            this.resenje.TabIndex = 5;
            // 
            // Red
            // 
            this.Controls.Add(this.resenje);
            this.Controls.Add(this.boja4);
            this.Controls.Add(this.boja3);
            this.Controls.Add(this.boja2);
            this.Controls.Add(this.boja1);
            this.Name = "Red";
            this.Size = new System.Drawing.Size(441, 48);
            this.Load += new System.EventHandler(this.Red_Load);
            ((System.ComponentModel.ISupportInitialize)(this.boja1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boja2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boja3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boja4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.PictureBox boja1;
        private System.Windows.Forms.PictureBox boja2;
        private System.Windows.Forms.PictureBox boja3;
        private System.Windows.Forms.PictureBox boja4;
        private System.Windows.Forms.TextBox resenje;
    }
}
