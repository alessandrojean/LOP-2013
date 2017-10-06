namespace nave
{
    partial class Form2
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
            this.stiker = new System.Windows.Forms.PictureBox();
            this.pergunta = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.stiker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pergunta)).BeginInit();
            this.SuspendLayout();
            // 
            // stiker
            // 
            this.stiker.Location = new System.Drawing.Point(0, 181);
            this.stiker.Name = "stiker";
            this.stiker.Size = new System.Drawing.Size(50, 80);
            this.stiker.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.stiker.TabIndex = 0;
            this.stiker.TabStop = false;
            this.stiker.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pergunta
            // 
            this.pergunta.Location = new System.Drawing.Point(281, 59);
            this.pergunta.Name = "pergunta";
            this.pergunta.Size = new System.Drawing.Size(100, 100);
            this.pergunta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pergunta.TabIndex = 1;
            this.pergunta.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 262);
            this.Controls.Add(this.pergunta);
            this.Controls.Add(this.stiker);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.Text = "GAME";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.stiker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pergunta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox stiker;
        private System.Windows.Forms.PictureBox pergunta;
    }
}