using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;

namespace autosalone_form
{
    public partial class UserControl1: UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView3.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tabControl1.SelectedIndex = 2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Aggiungere controlli
            String ConnectionString = "server=127.0.0.1;uid=programma;pwd=12345;database=interrogazioni";
            MySqlConnection conn = new MySqlConnection(ConnectionString);
            conn.Open();
            String sql = "insert into materie (nome) values('" + textBox1.Text + "');";

            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();

            //Visualizza dati
            String sql1 = "select * from materie;";
            MySqlCommand cmd1 = new MySqlCommand(sql1, conn);
            cmd1.ExecuteNonQuery();
            MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
            MyAdapter.SelectCommand = cmd1;
            DataTable dati = new DataTable();
            MyAdapter.Fill(dati);
            dataGridView1.DataSource = dati;
            conn.Close();
        }
    }
}
