namespace Menu
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
            this.filmesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.açãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.romanticoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jogosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aventuraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infantilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filmesToolStripMenuItem,
            this.jogosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // filmesToolStripMenuItem
            // 
            this.filmesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.açãoToolStripMenuItem,
            this.romanticoToolStripMenuItem});
            this.filmesToolStripMenuItem.Name = "filmesToolStripMenuItem";
            this.filmesToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.filmesToolStripMenuItem.Text = "Filmes";
            // 
            // açãoToolStripMenuItem
            // 
            this.açãoToolStripMenuItem.Name = "açãoToolStripMenuItem";
            this.açãoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.açãoToolStripMenuItem.Text = "Ação";
            this.açãoToolStripMenuItem.Click += new System.EventHandler(this.açãoToolStripMenuItem_Click);
            // 
            // romanticoToolStripMenuItem
            // 
            this.romanticoToolStripMenuItem.Name = "romanticoToolStripMenuItem";
            this.romanticoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.romanticoToolStripMenuItem.Text = "Romantico";
            this.romanticoToolStripMenuItem.Click += new System.EventHandler(this.romanticoToolStripMenuItem_Click);
            // 
            // jogosToolStripMenuItem
            // 
            this.jogosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aventuraToolStripMenuItem,
            this.infantilToolStripMenuItem});
            this.jogosToolStripMenuItem.Name = "jogosToolStripMenuItem";
            this.jogosToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.jogosToolStripMenuItem.Text = "Jogos";
            // 
            // aventuraToolStripMenuItem
            // 
            this.aventuraToolStripMenuItem.Name = "aventuraToolStripMenuItem";
            this.aventuraToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aventuraToolStripMenuItem.Text = "Aventura";
            this.aventuraToolStripMenuItem.Click += new System.EventHandler(this.aventuraToolStripMenuItem_Click);
            // 
            // infantilToolStripMenuItem
            // 
            this.infantilToolStripMenuItem.Name = "infantilToolStripMenuItem";
            this.infantilToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.infantilToolStripMenuItem.Text = "Infantil";
            this.infantilToolStripMenuItem.Click += new System.EventHandler(this.infantilToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem filmesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem açãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem romanticoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jogosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aventuraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infantilToolStripMenuItem;
    }
}

