using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace sqlkns_21_2_ro
{
    public partial class SpeciesIns : Form
    {
        public SpeciesIns()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(h.conStr))
            {
                string sql = "INSERT INTO species (species_id, subclass_id, species_name, limbs_count, body_size, mass, sex_system) VALUES (@TK1, @TK2, @TK3, @TK4, @TK5, @TK6, @TK7)";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@TK1", int.Parse(textBox1.Text));
                cmd.Parameters.AddWithValue("@TK2", int.Parse(textBox2.Text));
                cmd.Parameters.AddWithValue("@TK3", textBox3.Text);
                cmd.Parameters.AddWithValue("@TK4", int.Parse(textBox4.Text));
                cmd.Parameters.AddWithValue("@TK5", int.Parse(textBox5.Text));
                cmd.Parameters.AddWithValue("@TK6", int.Parse(textBox6.Text));
                cmd.Parameters.AddWithValue("@TK7", textBox7.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            this.Close();
        }
    }
}
