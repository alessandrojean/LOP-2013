namespace Exemplo___Radio_Button
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
            this.label1 = new System.Windows.Forms.Label();
            this.textnome = new System.Windows.Forms.TextBox();
            this.radioacao = new System.Windows.Forms.RadioButton();
            this.radioromance = new System.Windows.Forms.RadioButton();
            this.radiooutros = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textacao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textromance = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textoutros = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.progresso = new System.Windows.Forms.ProgressBar();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // textnome
            // 
            this.textnome.Location = new System.Drawing.Point(158, 12);
            this.textnome.Name = "textnome";
            this.textnome.Size = new System.Drawing.Size(215, 20);
            this.textnome.TabIndex = 1;
            // 
            // radioacao
            // 
            this.radioacao.AutoSize = true;
            this.radioacao.Location = new System.Drawing.Point(9, 19);
            this.radioacao.Name = "radioacao";
            this.radioacao.Size = new System.Drawing.Size(50, 17);
            this.radioacao.TabIndex = 3;
            this.radioacao.TabStop = true;
            this.radioacao.Text = "Ação";
            this.radioacao.UseVisualStyleBackColor = true;
            this.radioacao.CheckedChanged += new System.EventHandler(this.radioacao_CheckedChanged);
            // 
            // radioromance
            // 
            this.radioromance.AutoSize = true;
            this.radioromance.Location = new System.Drawing.Point(9, 42);
            this.radioromance.Name = "radioromance";
            this.radioromance.Size = new System.Drawing.Size(71, 17);
            this.radioromance.TabIndex = 4;
            this.radioromance.TabStop = true;
            this.radioromance.Text = "Romance";
            this.radioromance.UseVisualStyleBackColor = true;
            this.radioromance.CheckedChanged += new System.EventHandler(this.radioromance_CheckedChanged);
            // 
            // radiooutros
            // 
            this.radiooutros.AutoSize = true;
            this.radiooutros.Location = new System.Drawing.Point(9, 65);
            this.radiooutros.Name = "radiooutros";
            this.radiooutros.Size = new System.Drawing.Size(56, 17);
            this.radiooutros.TabIndex = 5;
            this.radiooutros.TabStop = true;
            this.radiooutros.Text = "Outros";
            this.radiooutros.UseVisualStyleBackColor = true;
            this.radiooutros.CheckedChanged += new System.EventHandler(this.radiooutros_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(158, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 26);
            this.button1.TabIndex = 6;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Total de Ação";
            // 
            // textacao
            // 
            this.textacao.Enabled = false;
            this.textacao.Location = new System.Drawing.Point(109, 23);
            this.textacao.Name = "textacao";
            this.textacao.Size = new System.Drawing.Size(46, 20);
            this.textacao.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Total de Romance";
            // 
            // textromance
            // 
            this.textromance.Enabled = false;
            this.textromance.Location = new System.Drawing.Point(109, 46);
            this.textromance.Name = "textromance";
            this.textromance.Size = new System.Drawing.Size(46, 20);
            this.textromance.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Total de Outros";
            // 
            // textoutros
            // 
            this.textoutros.Enabled = false;
            this.textoutros.Location = new System.Drawing.Point(109, 67);
            this.textoutros.Name = "textoutros";
            this.textoutros.Size = new System.Drawing.Size(46, 20);
            this.textoutros.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioacao);
            this.groupBox1.Controls.Add(this.radioromance);
            this.groupBox1.Controls.Add(this.radiooutros);
            this.groupBox1.Location = new System.Drawing.Point(16, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(91, 89);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de filme:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textacao);
            this.groupBox2.Controls.Add(this.textoutros);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textromance);
            this.groupBox2.Location = new System.Drawing.Point(57, 145);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(170, 100);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Totais: ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(6, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Location = new System.Drawing.Point(268, 60);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 143);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Imagem de Preview";
            // 
            // progresso
            // 
            this.progresso.Location = new System.Drawing.Point(268, 215);
            this.progresso.Name = "progresso";
            this.progresso.Size = new System.Drawing.Size(199, 23);
            this.progresso.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progresso.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 257);
            this.Controls.Add(this.progresso);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textnome);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Servieca 2.0";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textnome;
        private System.Windows.Forms.RadioButton radioacao;
        private System.Windows.Forms.RadioButton radioromance;
        private System.Windows.Forms.RadioButton radiooutros;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textacao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textromance;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textoutros;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ProgressBar progresso;
    }
}

