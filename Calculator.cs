using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace sqlkns_21_2_ro
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(textBox1.Text);
            int num2 = Convert.ToInt32(textBox2.Text);
            string op = this.comboBox1.SelectedItem.ToString();

            if (op == "Add")
                textBox3.Text = (num1 + num2).ToString();
            else if (op == "Substract")
                textBox3.Text = (num1 - num2).ToString();
            else if (op == "Divide")
                textBox3.Text = (num1 / num2).ToString();
            else if (op == "Multiply")
                textBox3.Text = (num1 * num2).ToString();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }
    }
}
