namespace JOGÕES
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.jogosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jogoDaVelhaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jogoDaReciclagemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jogoDoCaçaNicãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jogosToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // jogosToolStripMenuItem
            // 
            this.jogosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jogoDaVelhaToolStripMenuItem,
            this.jogoDaReciclagemToolStripMenuItem,
            this.jogoDoCaçaNicãoToolStripMenuItem});
            this.jogosToolStripMenuItem.Name = "jogosToolStripMenuItem";
            this.jogosToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.jogosToolStripMenuItem.Text = "Jogos";
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            this.ajudaToolStripMenuItem.Click += new System.EventHandler(this.ajudaToolStripMenuItem_Click);
            // 
            // jogoDaVelhaToolStripMenuItem
            // 
            this.jogoDaVelhaToolStripMenuItem.Name = "jogoDaVelhaToolStripMenuItem";
            this.jogoDaVelhaToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.jogoDaVelhaToolStripMenuItem.Text = "Projetão da velha";
            this.jogoDaVelhaToolStripMenuItem.Click += new System.EventHandler(this.jogoDaVelhaToolStripMenuItem_Click);
            // 
            // jogoDaReciclagemToolStripMenuItem
            // 
            this.jogoDaReciclagemToolStripMenuItem.Name = "jogoDaReciclagemToolStripMenuItem";
            this.jogoDaReciclagemToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.jogoDaReciclagemToolStripMenuItem.Text = "Preservação da Naturezona";
            this.jogoDaReciclagemToolStripMenuItem.Click += new System.EventHandler(this.jogoDaReciclagemToolStripMenuItem_Click);
            // 
            // jogoDoCaçaNicãoToolStripMenuItem
            // 
            this.jogoDoCaçaNicãoToolStripMenuItem.Name = "jogoDoCaçaNicãoToolStripMenuItem";
            this.jogoDoCaçaNicãoToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.jogoDoCaçaNicãoToolStripMenuItem.Text = "Jogo do Caça-Nicão";
            this.jogoDoCaçaNicãoToolStripMenuItem.Click += new System.EventHandler(this.jogoDoCaçaNicãoToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::JOGÕES.Properties.Resources._10;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem jogosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jogoDaVelhaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jogoDaReciclagemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jogoDoCaçaNicãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

