
namespace sqlkns_21_2_ro
{
    partial class myBD
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
            this.TablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClassToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SubclassToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SpeciesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DietToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DistributionAreaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SpeciesDietToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SpeciesDistributionAreaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CalculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TablesToolStripMenuItem,
            this.CalculatorToolStripMenuItem,
            this.AboutProgramToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(501, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // TablesToolStripMenuItem
            // 
            this.TablesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ClassToolStripMenuItem,
            this.SubclassToolStripMenuItem,
            this.SpeciesToolStripMenuItem,
            this.DietToolStripMenuItem,
            this.DistributionAreaToolStripMenuItem,
            this.SpeciesDietToolStripMenuItem,
            this.SpeciesDistributionAreaToolStripMenuItem});
            this.TablesToolStripMenuItem.Name = "TablesToolStripMenuItem";
            this.TablesToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.TablesToolStripMenuItem.Text = "Таблиці БД";
            // 
            // ClassToolStripMenuItem
            // 
            this.ClassToolStripMenuItem.Name = "ClassToolStripMenuItem";
            this.ClassToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1)));
            this.ClassToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
            this.ClassToolStripMenuItem.Text = "Клас";
            this.ClassToolStripMenuItem.Click += new System.EventHandler(this.ClassToolStripMenuItem_Click);
            // 
            // SubclassToolStripMenuItem
            // 
            this.SubclassToolStripMenuItem.Name = "SubclassToolStripMenuItem";
            this.SubclassToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D2)));
            this.SubclassToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
            this.SubclassToolStripMenuItem.Text = "Підклас";
            this.SubclassToolStripMenuItem.Click += new System.EventHandler(this.SubclassToolStripMenuItem_Click);
            // 
            // SpeciesToolStripMenuItem
            // 
            this.SpeciesToolStripMenuItem.Name = "SpeciesToolStripMenuItem";
            this.SpeciesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D3)));
            this.SpeciesToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
            this.SpeciesToolStripMenuItem.Text = "Вид";
            this.SpeciesToolStripMenuItem.Click += new System.EventHandler(this.SpeciesToolStripMenuItem_Click);
            // 
            // DietToolStripMenuItem
            // 
            this.DietToolStripMenuItem.Name = "DietToolStripMenuItem";
            this.DietToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D4)));
            this.DietToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
            this.DietToolStripMenuItem.Text = "Дієта";
            this.DietToolStripMenuItem.Click += new System.EventHandler(this.DietToolStripMenuItem_Click);
            // 
            // DistributionAreaToolStripMenuItem
            // 
            this.DistributionAreaToolStripMenuItem.Name = "DistributionAreaToolStripMenuItem";
            this.DistributionAreaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D5)));
            this.DistributionAreaToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
            this.DistributionAreaToolStripMenuItem.Text = "Ареол розповсюдження";
            this.DistributionAreaToolStripMenuItem.Click += new System.EventHandler(this.DistributionAreaToolStripMenuItem_Click);
            // 
            // SpeciesDietToolStripMenuItem
            // 
            this.SpeciesDietToolStripMenuItem.Name = "SpeciesDietToolStripMenuItem";
            this.SpeciesDietToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D6)));
            this.SpeciesDietToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
            this.SpeciesDietToolStripMenuItem.Text = "Дієта видів";
            this.SpeciesDietToolStripMenuItem.Click += new System.EventHandler(this.SpeciesDietToolStripMenuItem_Click);
            // 
            // SpeciesDistributionAreaToolStripMenuItem
            // 
            this.SpeciesDistributionAreaToolStripMenuItem.Name = "SpeciesDistributionAreaToolStripMenuItem";
            this.SpeciesDistributionAreaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D7)));
            this.SpeciesDistributionAreaToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
            this.SpeciesDistributionAreaToolStripMenuItem.Text = "Ареол видів";
            this.SpeciesDistributionAreaToolStripMenuItem.Click += new System.EventHandler(this.SpeciesDistributionAreaToolStripMenuItem_Click);
            // 
            // CalculatorToolStripMenuItem
            // 
            this.CalculatorToolStripMenuItem.Name = "CalculatorToolStripMenuItem";
            this.CalculatorToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.CalculatorToolStripMenuItem.Text = "Калькулятор";
            this.CalculatorToolStripMenuItem.Click += new System.EventHandler(this.CalculatorToolStripMenuItem_Click_1);
            // 
            // AboutProgramToolStripMenuItem
            // 
            this.AboutProgramToolStripMenuItem.Name = "AboutProgramToolStripMenuItem";
            this.AboutProgramToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.AboutProgramToolStripMenuItem.Text = "Про програму";
            // 
            // myBD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "myBD";
            this.Text = "myBD";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.myBD_FormClosed);
            this.Load += new System.EventHandler(this.myBD_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TablesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ClassToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SubclassToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SpeciesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DietToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DistributionAreaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SpeciesDietToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SpeciesDistributionAreaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CalculatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutProgramToolStripMenuItem;
    }
}