using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using MySql.Data.MySqlClient;

namespace sqlkns_21_2_ro
{
    public partial class Form1 : Form
    {
        public string[,] matrix;

        public Form1()
        {
            InitializeComponent();
            h.conStr = "server = 193.93.216.145; CharacterSet = cp1251;" +
                "user = sqlkns21_2_ro; database = sqlkns21_2_ro; password = kns20_ro";

            DataTable dt = h.myfunDT("SELECT * from my_user");

            int count = dt.Rows.Count;

            Console.WriteLine(count);

            matrix = new string[count, 4];
            for (int i = 0; i < count; i++)
            {
                matrix[i, 0] = dt.Rows[i].Field<int>("user_id").ToString();
                matrix[i, 1] = dt.Rows[i].Field<string>("user_name");
                matrix[i, 2] = dt.Rows[i].Field<int>("type").ToString();
                matrix[i, 3] = dt.Rows[i].Field<string>("password");
                comboBox1.Items.Add(matrix[i, 1]);
            }
            comboBox1.Text = matrix[0, 1];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*textBox2.Text = h.EncryptedPassword(textBox1.Text);*/
            for (int i = 0; i < matrix.GetLength(0); i++)
                if (String.Equals(comboBox1.Text, matrix[i, 1]))
                    if (String.Equals(h.EncryptedPassword(textBox1.Text), matrix[i, 3]))
                    {
                        h.typeuser = matrix[i, 2];
                        this.Hide();
                        myBD f0 = new myBD();
                        f0.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Введіть правильний пароль");
                    }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

    static class h
    {
        public static BindingSource bs1 { get; set; }
        public static string conStr { get; set; }
        public static string curVal0 { get; set; }
        public static string keyName { get; set; }
        public static string typeuser { get; set; }

        public static DataTable myfunDT(string sqlStr)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection con = new MySqlConnection(h.conStr))
            {
                MySqlCommand com = new MySqlCommand(sqlStr, con);
                try
                {
                    con.Open();
                    using (MySqlDataReader dr = com.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            dt.Load(dr);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return dt;
        }

        public static string EncryptedPassword(string s)
        {
            if (string.Compare(s, "null", true) == 0)
                return "NULL";

            byte[] bytes = Encoding.Unicode.GetBytes(s);

            MD5CryptoServiceProvider CSP = new MD5CryptoServiceProvider();

            byte[] byteHash = CSP.ComputeHash(bytes);

            string hash = string.Empty;

            foreach (byte b in byteHash)
                hash += string.Format("{0:x2}", b);

            return hash;
        }

    }
}
