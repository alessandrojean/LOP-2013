namespace Keygen
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
            this.components = new System.ComponentModel.Container();
            this.foto4 = new System.Windows.Forms.PictureBox();
            this.foto3 = new System.Windows.Forms.PictureBox();
            this.foto2 = new System.Windows.Forms.PictureBox();
            this.jill = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txtpontos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txttempo = new System.Windows.Forms.TextBox();
            this.timertempo = new System.Windows.Forms.Timer(this.components);
            this.txtvezes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.foto4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foto3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foto2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jill)).BeginInit();
            this.SuspendLayout();
            // 
            // foto4
            // 
            this.foto4.Image = global::Keygen.Properties.Resources._305078_484351238255436_308507655_n;
            this.foto4.Location = new System.Drawing.Point(26, 42);
            this.foto4.Name = "foto4";
            this.foto4.Size = new System.Drawing.Size(76, 62);
            this.foto4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.foto4.TabIndex = 3;
            this.foto4.TabStop = false;
            this.foto4.Click += new System.EventHandler(this.foto4_Click);
            // 
            // foto3
            // 
            this.foto3.Image = global::Keygen.Properties.Resources.Sem_título;
            this.foto3.Location = new System.Drawing.Point(46, 172);
            this.foto3.Name = "foto3";
            this.foto3.Size = new System.Drawing.Size(56, 58);
            this.foto3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.foto3.TabIndex = 2;
            this.foto3.TabStop = false;
            this.foto3.Visible = false;
            // 
            // foto2
            // 
            this.foto2.Image = global::Keygen.Properties.Resources.Koala;
            this.foto2.Location = new System.Drawing.Point(190, 180);
            this.foto2.Name = "foto2";
            this.foto2.Size = new System.Drawing.Size(75, 50);
            this.foto2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.foto2.TabIndex = 1;
            this.foto2.TabStop = false;
            this.foto2.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // jill
            // 
            this.jill.Image = global::Keygen.Properties.Resources._306129_482786311770312_346361208_n;
            this.jill.Location = new System.Drawing.Point(190, 52);
            this.jill.Name = "jill";
            this.jill.Size = new System.Drawing.Size(52, 52);
            this.jill.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.jill.TabIndex = 0;
            this.jill.TabStop = false;
            this.jill.Click += new System.EventHandler(this.jill_Click);
            this.jill.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.jill_PreviewKeyDown);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 250;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mistral", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "PLACAR";
            // 
            // txtpontos
            // 
            this.txtpontos.Enabled = false;
            this.txtpontos.Location = new System.Drawing.Point(68, 8);
            this.txtpontos.Name = "txtpontos";
            this.txtpontos.Size = new System.Drawing.Size(56, 20);
            this.txtpontos.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mistral", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(130, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "TEMPO";
            // 
            // txttempo
            // 
            this.txttempo.Enabled = false;
            this.txttempo.Location = new System.Drawing.Point(181, 7);
            this.txttempo.Name = "txttempo";
            this.txttempo.Size = new System.Drawing.Size(56, 20);
            this.txttempo.TabIndex = 7;
            // 
            // timertempo
            // 
            this.timertempo.Interval = 850;
            this.timertempo.Tick += new System.EventHandler(this.timertempo_Tick_1);
            // 
            // txtvezes
            // 
            this.txtvezes.Enabled = false;
            this.txtvezes.Location = new System.Drawing.Point(243, 7);
            this.txtvezes.Name = "txtvezes";
            this.txtvezes.Size = new System.Drawing.Size(29, 20);
            this.txtvezes.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(266, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "O jogo começa quando você pressionar qualquer tecla";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtvezes);
            this.Controls.Add(this.txttempo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtpontos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.foto3);
            this.Controls.Add(this.foto2);
            this.Controls.Add(this.jill);
            this.Controls.Add(this.foto4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Keygen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.foto4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foto3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foto2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jill)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox jill;
        private System.Windows.Forms.PictureBox foto2;
        private System.Windows.Forms.PictureBox foto3;
        private System.Windows.Forms.PictureBox foto4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtpontos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttempo;
        private System.Windows.Forms.Timer timertempo;
        private System.Windows.Forms.TextBox txtvezes;
        private System.Windows.Forms.Label label3;
    }
}

