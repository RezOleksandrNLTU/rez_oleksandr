using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace sqlkns_21_2_ro
{
    public partial class DataView : Form
    {
        public string table = "";

        public DataView(string table)
        {
            this.table = table;
            InitializeComponent();
            this.Text = this.table;
        }

        private void Species_Load(object sender, EventArgs e)
        {
            h.bs1 = new BindingSource();
            h.bs1.DataSource = h.myfunDT(string.Format("SELECT * FROM {0}", this.table));
            bindingNavigator1.BindingSource = h.bs1;
            dataGridView1.DataSource = h.bs1;

            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.White;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Black;

            dataGridView1.RowsDefaultCellStyle.BackColor = Color.LightGray;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Silver;
        }
        private void btSearch_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            label1.Visible = true;
            textBox1.Focus();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            label1.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Selected = false;
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    if (dataGridView1.Rows[i].Cells[j].Value != null)
                        if (dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(textBox1.Text))
                        {
                            dataGridView1.Rows[i].Selected = true;
                        }
                }
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
                if (Control.ModifierKeys == Keys.Control)
                {
                    for (int i = 0; i < dataGridView1.RowCount; i++)
                    {
                        dataGridView1.Rows[i].Selected = false;
                        for (int j = 0; j < dataGridView1.ColumnCount; j++)
                        {
                            if (dataGridView1.Rows[i].Cells[j].Value != null)
                                if (dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(textBox1.Text))
                                {
                                    dataGridView1.Rows[i].Selected = true;
                                }
                        }
                    }
                }
        }

        private void btFilter_Click(object sender, EventArgs e)
        {
            if (btFilter.Checked)
            {
                label2.Visible = true;
                label3.Visible = true;
                textBox2.Visible = true;
                textBox2.Focus();
            }
            else
            {
                label2.Visible = false;
                label3.Visible = false;
                textBox2.Visible = false;
                h.bs1.Filter = "";
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                h.bs1.Filter = textBox2.Text;
                label2.Visible = false;
                label3.Visible = false;
                textBox2.Visible = false;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            h.bs1.Filter = textBox2.Text;
            label2.Visible = false;
            label3.Visible = false;
            textBox2.Visible = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            h.bs1.Filter = textBox2.Text;
            label2.Visible = false;
            label3.Visible = false;
            textBox2.Visible = false;
        }

        private void AddNew_Click(object sender, EventArgs e)
        {
            if (table == "class")
            {
                SpeciesIns add_form = new SpeciesIns();
                add_form.ShowDialog();
            }
            else if (table == "subclass")
            {
                SpeciesIns add_form = new SpeciesIns();
                add_form.ShowDialog();
            }
            else if (table == "species")
            {
                SpeciesIns add_form = new SpeciesIns();
                add_form.ShowDialog();
            }
            else if (table == "diet")
            {
                SpeciesIns add_form = new SpeciesIns();
                add_form.ShowDialog();
            }
            else if (table == "distribution_area")
            {
                SpeciesIns add_form = new SpeciesIns();
                add_form.ShowDialog();
            }
            else if (table == "species_diet")
            {
                SpeciesIns add_form = new SpeciesIns();
                add_form.ShowDialog();
            }
            else if (table == "species_distribution_area")
            {
                SpeciesIns add_form = new SpeciesIns();
                add_form.ShowDialog();
            }
            h.bs1.DataSource = h.myfunDT(string.Format("SELECT * FROM {0}", this.table));
            dataGridView1.DataSource = h.bs1;
        }

        private void Del_Click(object sender, EventArgs e)
        {
            h.curVal0 = dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString();
            h.keyName = dataGridView1.Columns[0].Name;

            if (table == "class")
            {
                SpeciesDel del_form = new SpeciesDel();
                del_form.ShowDialog();
            }
            else if (table == "subclass")
            {
                SpeciesDel del_form = new SpeciesDel();
                del_form.ShowDialog();
            }
            else if (table == "species")
            {
                SpeciesDel del_form = new SpeciesDel();
                del_form.ShowDialog();
            }
            else if (table == "diet")
            {
                SpeciesDel del_form = new SpeciesDel();
                del_form.ShowDialog();
            }
            else if (table == "distribution_area")
            {
                SpeciesDel del_form = new SpeciesDel();
                del_form.ShowDialog();
            }
            else if (table == "species_diet")
            {
                SpeciesDel del_form = new SpeciesDel();
                del_form.ShowDialog();
            }
            else if (table == "species_distribution_area")
            {
                SpeciesDel del_form = new SpeciesDel();
                del_form.ShowDialog();
            }

            h.bs1.DataSource = h.myfunDT(string.Format("SELECT * FROM {0}", this.table));
            dataGridView1.DataSource = h.bs1;
        }

        private void dataGridView1_CellParsing(object sender, DataGridViewCellParsingEventArgs e)
        {
            int curColidx = dataGridView1.CurrentCellAddress.X;
            int curRowidx = dataGridView1.CurrentCellAddress.Y;
            string curColName0 = dataGridView1.Columns[0].Name;
            string curColName = dataGridView1.Columns[curColidx].Name;
            h.curVal0 = dataGridView1[0, curRowidx].Value.ToString();

            string newCurCellVal = e.Value.ToString();

            if (curColName == "species_name" || curColName == "sex_system")
            {
                newCurCellVal = "'" + newCurCellVal + "'";
            }
            string sql = "UPDATE " + this.table + " SET " + curColName + " = " + newCurCellVal + " WHERE " + curColName0 + " = " + h.curVal0;

            using (MySqlConnection con = new MySqlConnection(h.conStr))
            {
                MySqlCommand cmd = new MySqlCommand(sql, con);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            h.curVal0 = dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString();
            h.keyName = dataGridView1.Columns[0].Name;

            if (table == "class")
            {
                SpeciesEdit edit_form = new SpeciesEdit();
                edit_form.ShowDialog();
            }
            else if (table == "subclass")
            {
                SpeciesEdit edit_form = new SpeciesEdit();
                edit_form.ShowDialog();
            }
            else if (table == "species")
            {
                SpeciesEdit edit_form = new SpeciesEdit();
                edit_form.ShowDialog();
            }
            else if (table == "diet")
            {
                SpeciesEdit edit_form = new SpeciesEdit();
                edit_form.ShowDialog();
            }
            else if (table == "distribution_area")
            {
                SpeciesEdit edit_form = new SpeciesEdit();
                edit_form.ShowDialog();
            }
            else if (table == "species_diet")
            {
                SpeciesEdit edit_form = new SpeciesEdit();
                edit_form.ShowDialog();
            }
            else if (table == "species_distribution_area")
            {
                SpeciesEdit edit_form = new SpeciesEdit();
                edit_form.ShowDialog();
            }

            h.bs1.DataSource = h.myfunDT(string.Format("SELECT * FROM {0}", this.table));
            dataGridView1.DataSource = h.bs1;
        }
    }
}
