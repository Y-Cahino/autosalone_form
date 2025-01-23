using System;
using System.Collections.Generic;
using System.Data;
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
            tabControl1.SelectedIndex = 0;

            // Carica i dati nelle griglie al caricamento del controllo
            LoadDataMarche();
            LoadDataModelli();
            LoadDataAutosalone();
            LoadDataAnni();
        }

        // Caricamento dei dati per le marche
        private void LoadDataMarche()
        {
            using (var conn = new MySqlConnection(ConnectionString))
            {
                try
                {
                    conn.Open();
                    string sql = "SELECT * FROM marche";
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
                    MessageBox.Show($"Errore durante il caricamento delle marche: {ex.Message}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Caricamento dei dati per i modelli
        private void LoadDataModelli()
        {
            using (var conn = new MySqlConnection(ConnectionString))
            {
                try
                {
                    conn.Open();
                    string sql = "SELECT * FROM modelli";
                    using (var cmd = new MySqlCommand(sql, conn))
                    using (var adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable dati = new DataTable();
                        adapter.Fill(dati);
                        dataGridView2.DataSource = dati;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Errore durante il caricamento dei modelli: {ex.Message}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Caricamento dei dati per l'autosalone
        private void LoadDataAutosalone()
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
                        dataGridView3.DataSource = dati;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Errore durante il caricamento degli autosaloni: {ex.Message}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Caricamento dei dati per gli anni
        private void LoadDataAnni()
        {
            using (var conn = new MySqlConnection(ConnectionString))
            {
                try
                {
                    conn.Open();
                    string sql = "SELECT * FROM anni";
                    using (var cmd = new MySqlCommand(sql, conn))
                    using (var adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable dati = new DataTable();
                        adapter.Fill(dati);
                        dataGridView4.DataSource = dati; // Assuming dataGridView4 for years
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Errore durante il caricamento degli anni: {ex.Message}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Aggiungi una nuova marca
        private void buttonAddMarca_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxMarca.Text))
            {
                AddMarca(textBoxMarca.Text);
                LoadDataMarche();
                textBoxMarca.Clear();
            }
            else
            {
                MessageBox.Show("Il campo Marca non può essere vuoto.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Funzione per aggiungere una marca
        private void AddMarca(string marca)
        {
            using (var conn = new MySqlConnection(ConnectionString))
            {
                try
                {
                    conn.Open();
                    string sql = "INSERT INTO marche (marca_n) VALUES (@marca)";
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

        // Aggiungi un nuovo modello
        private void buttonAddModello_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxModello.Text) && comboBoxMarca.SelectedItem != null)
            {
                int marcaId = ((KeyValuePair<int, string>)comboBoxMarca.SelectedItem).Key;
                AddModello(textBoxModello.Text, marcaId);
                LoadDataModelli();
                textBoxModello.Clear();
            }
            else
            {
                MessageBox.Show("Compila tutti i campi correttamente.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Funzione per aggiungere un modello
        private void AddModello(string modello, int marcaId)
        {
            using (var conn = new MySqlConnection(ConnectionString))
            {
                try
                {
                    conn.Open();
                    string sql = "INSERT INTO modelli (modello_n, marca_id) VALUES (@modello, @marcaId)";
                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@modello", modello);
                        cmd.Parameters.AddWithValue("@marcaId", marcaId);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Modello aggiunto con successo.", "Successo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Errore durante l'aggiunta del modello: {ex.Message}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Aggiungi un nuovo autosalone
        private void buttonAddAutosalone_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxModelloAutosalone.Text) && comboBoxAnno.SelectedItem != null && comboBoxMarcaAutosalone.SelectedItem != null)
            {
                int modelloId = ((KeyValuePair<int, string>)comboBoxModelloAutosalone.SelectedItem).Key;
                int annoId = ((KeyValuePair<int, string>)comboBoxAnno.SelectedItem).Key;
                int marcaId = ((KeyValuePair<int, string>)comboBoxMarcaAutosalone.SelectedItem).Key;
                AddAutosalone(modelloId, annoId, marcaId);
                LoadDataAutosalone();
                textBoxModelloAutosalone.Clear();
            }
            else
            {
                MessageBox.Show("Compila tutti i campi correttamente.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Funzione per aggiungere un autosalone
        private void AddAutosalone(int modelloId, int annoId, int marcaId)
        {
            using (var conn = new MySqlConnection(ConnectionString))
            {
                try
                {
                    conn.Open();
                    string sql = "INSERT INTO autosalone (modello_id, anno_produzione, marca_id) VALUES (@modelloId, @annoId, @marcaId)";
                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@modelloId", modelloId);
                        cmd.Parameters.AddWithValue("@annoId", annoId);
                        cmd.Parameters.AddWithValue("@marcaId", marcaId);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Autosalone aggiunto con successo.", "Successo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Errore durante l'aggiunta dell'autosalone: {ex.Message}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Elimina una marca
        private void buttonDeleteMarca_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int marcaId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                DeleteMarca(marcaId);
                LoadDataMarche();
            }
            else
            {
                MessageBox.Show("Seleziona una marca da eliminare.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Funzione per eliminare una marca
        private void DeleteMarca(int marcaId)
        {
            using (var conn = new MySqlConnection(ConnectionString))
            {
                try
                {
                    conn.Open();
                    string sql = "DELETE FROM marche WHERE id = @marcaId";
                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@marcaId", marcaId);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Marca eliminata con successo.", "Successo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Errore durante l'eliminazione della marca: {ex.Message}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
