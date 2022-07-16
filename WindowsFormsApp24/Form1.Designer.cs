namespace WindowsFormsApp24
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
            this.unosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gorivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bojaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretragaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poProizvodjacuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poModeluToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.krajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izlazAltIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unosToolStripMenuItem,
            this.pretragaToolStripMenuItem,
            this.krajToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // unosToolStripMenuItem
            // 
            this.unosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gorivoToolStripMenuItem,
            this.bojaToolStripMenuItem});
            this.unosToolStripMenuItem.Name = "unosToolStripMenuItem";
            this.unosToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.unosToolStripMenuItem.Text = "Unos";
            // 
            // gorivoToolStripMenuItem
            // 
            this.gorivoToolStripMenuItem.Name = "gorivoToolStripMenuItem";
            this.gorivoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gorivoToolStripMenuItem.Text = "Gorivo";
            this.gorivoToolStripMenuItem.Click += new System.EventHandler(this.gorivoToolStripMenuItem_Click);
            // 
            // bojaToolStripMenuItem
            // 
            this.bojaToolStripMenuItem.Name = "bojaToolStripMenuItem";
            this.bojaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bojaToolStripMenuItem.Text = "Boja";
            // 
            // pretragaToolStripMenuItem
            // 
            this.pretragaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.poProizvodjacuToolStripMenuItem,
            this.poModeluToolStripMenuItem});
            this.pretragaToolStripMenuItem.Name = "pretragaToolStripMenuItem";
            this.pretragaToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.pretragaToolStripMenuItem.Text = "Pretraga";
            // 
            // poProizvodjacuToolStripMenuItem
            // 
            this.poProizvodjacuToolStripMenuItem.Name = "poProizvodjacuToolStripMenuItem";
            this.poProizvodjacuToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.poProizvodjacuToolStripMenuItem.Text = "Po Proizvodjacu";
            this.poProizvodjacuToolStripMenuItem.Click += new System.EventHandler(this.poProizvodjacuToolStripMenuItem_Click);
            // 
            // poModeluToolStripMenuItem
            // 
            this.poModeluToolStripMenuItem.Name = "poModeluToolStripMenuItem";
            this.poModeluToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.poModeluToolStripMenuItem.Text = "Po Modelu";
            // 
            // krajToolStripMenuItem
            // 
            this.krajToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.izlazAltIToolStripMenuItem});
            this.krajToolStripMenuItem.Name = "krajToolStripMenuItem";
            this.krajToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.krajToolStripMenuItem.Text = "Kraj";
            // 
            // izlazAltIToolStripMenuItem
            // 
            this.izlazAltIToolStripMenuItem.Name = "izlazAltIToolStripMenuItem";
            this.izlazAltIToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.izlazAltIToolStripMenuItem.Text = "Izlaz Alt+I";
            this.izlazAltIToolStripMenuItem.Click += new System.EventHandler(this.izlazAltIToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
        private System.Windows.Forms.ToolStripMenuItem unosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gorivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bojaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretragaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poProizvodjacuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poModeluToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem krajToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izlazAltIToolStripMenuItem;
    }
}

