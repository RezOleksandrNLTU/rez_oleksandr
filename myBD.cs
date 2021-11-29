using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace sqlkns_21_2_ro
{
    public partial class myBD : Form
    {
        public myBD()
        {
            InitializeComponent();
        }

        private void myBD_Load(object sender, EventArgs e)
        {
            MessageBox.Show("тип користувача" + h.typeuser);
        }

        private void myBD_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form f1 = new Form1();
            f1.Show();
        }

        private void ClassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataView c = new DataView("class");
            c.Show();
        }

        private void SubclassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataView sc = new DataView("subclass");
            sc.Show();
        }

        private void SpeciesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataView sp = new DataView("species");
            sp.Show();
        }

        private void DietToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataView d = new DataView("diet");
            d.Show();
        }

        private void DistributionAreaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataView da = new DataView("distribution_area");
            da.Show();
        }

        private void SpeciesDietToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataView spd = new DataView("species_diet");
            spd.Show();
        }

        private void SpeciesDistributionAreaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataView spda = new DataView("species_distribution_area");
            spda.Show();
        }

        private void CalculatorToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Calculator c = new Calculator();
            c.Show();

        }
    }
}
