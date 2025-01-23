using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace autosalone_form
{
    public partial class UserControl1 : UserControl
    {
        private const string ConnectionString = "server=127.0.0.1;uid=root;pwd=;database=autosaloni";

        public UserControl1()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            // Imposta il modo di selezione per le DataGridView
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView3.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Imposta la scheda inizialmente selezionata
            tabControl1.SelectedIndex = 2;

            // Carica i dati nella griglia al caricamento del controllo
            LoadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Aggiungere una marca all'inventario
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                AddMarca(textBox1.Text);
                LoadData();
                textBox1.Clear();
            }
            else
            {
                MessageBox.Show("Il campo Marca non può essere vuoto.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void AddMarca(string marca)
        {
            using (var conn = new MySqlConnection(ConnectionString))
            {
                try
                {
                    conn.Open();
                    string sql = "INSERT INTO marche (marca) VALUES (@marca)";
                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@marca", marca);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Marca aggiunta con successo.", "Successo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Errore durante l'aggiunta della marca: {ex.Message}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoadData()
        {
            using (var conn = new MySqlConnection(ConnectionString))
            {
                try
                {
                    conn.Open();
                    string sql = "SELECT * FROM autosalone";
                    using (var cmd = new MySqlCommand(sql, conn))
                    using (var adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable dati = new DataTable();
                        adapter.Fill(dati);
                        dataGridView1.DataSource = dati;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Errore durante il caricamento dei dati: {ex.Message}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {
        
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
         
        }
    }
}
