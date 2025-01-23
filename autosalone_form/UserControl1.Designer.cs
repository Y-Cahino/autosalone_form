namespace autosalone_form
{
    partial class UserControl1
    {
        private System.ComponentModel.IContainer components = null;

        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxMarca = new System.Windows.Forms.TextBox();
            this.buttonAddMarca = new System.Windows.Forms.Button();
            this.buttonDeleteMarca = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.comboBoxMarca = new System.Windows.Forms.ComboBox();
            this.textBoxModello = new System.Windows.Forms.TextBox();
            this.buttonAddModello = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.comboBoxMarcaAutosalone = new System.Windows.Forms.ComboBox();
            this.comboBoxModelloAutosalone = new System.Windows.Forms.ComboBox();
            this.comboBoxAnno = new System.Windows.Forms.ComboBox();
            this.buttonAddAutosalone = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.SuspendLayout();

            // TabControl
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;

            // TabPage1 - Marche
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.textBoxMarca);
            this.tabPage1.Controls.Add(this.buttonAddMarca);
            this.tabPage1.Controls.Add(this.buttonDeleteMarca);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Marche";
            this.tabPage1.UseVisualStyleBackColor = true;

            // DataGridView1 (Marche)
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(780, 200);
            this.dataGridView1.TabIndex = 0;

            // TextBoxMarca (Marca)
            this.textBoxMarca.Location = new System.Drawing.Point(6, 212);
            this.textBoxMarca.Name = "textBoxMarca";
            this.textBoxMarca.Size = new System.Drawing.Size(200, 20);
            this.textBoxMarca.TabIndex = 1;

            // ButtonAddMarca
            this.buttonAddMarca.Location = new System.Drawing.Point(6, 238);
            this.buttonAddMarca.Name = "buttonAddMarca";
            this.buttonAddMarca.Size = new System.Drawing.Size(75, 23);
            this.buttonAddMarca.TabIndex = 2;
            this.buttonAddMarca.Text = "Aggiungi";
            this.buttonAddMarca.UseVisualStyleBackColor = true;

            // ButtonDeleteMarca
            this.buttonDeleteMarca.Location = new System.Drawing.Point(87, 238);
            this.buttonDeleteMarca.Name = "buttonDeleteMarca";
            this.buttonDeleteMarca.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteMarca.TabIndex = 3;
            this.buttonDeleteMarca.Text = "Elimina";
            this.buttonDeleteMarca.UseVisualStyleBackColor = true;

            // TabPage2 - Modelli
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.comboBoxMarca);
            this.tabPage2.Controls.Add(this.textBoxModello);
            this.tabPage2.Controls.Add(this.buttonAddModello);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Modelli";
            this.tabPage2.UseVisualStyleBackColor = true;

            // DataGridView2 (Modelli)
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 6);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(780, 200);
            this.dataGridView2.TabIndex = 0;

            // ComboBoxMarca (Marca per Modello)
            this.comboBoxMarca.FormattingEnabled = true;
            this.comboBoxMarca.Location = new System.Drawing.Point(6, 212);
            this.comboBoxMarca.Name = "comboBoxMarca";
            this.comboBoxMarca.Size = new System.Drawing.Size(200, 21);
            this.comboBoxMarca.TabIndex = 1;

            // TextBoxModello
            this.textBoxModello.Location = new System.Drawing.Point(6, 239);
            this.textBoxModello.Name = "textBoxModello";
            this.textBoxModello.Size = new System.Drawing.Size(200, 20);
            this.textBoxModello.TabIndex = 2;

            // ButtonAddModello
            this.buttonAddModello.Location = new System.Drawing.Point(6, 265);
            this.buttonAddModello.Name = "buttonAddModello";
            this.buttonAddModello.Size = new System.Drawing.Size(75, 23);
            this.buttonAddModello.TabIndex = 3;
            this.buttonAddModello.Text = "Aggiungi";
            this.buttonAddModello.UseVisualStyleBackColor = true;

            // TabPage3 - Autosalone
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Controls.Add(this.comboBoxMarcaAutosalone);
            this.tabPage3.Controls.Add(this.comboBoxModelloAutosalone);
            this.tabPage3.Controls.Add(this.comboBoxAnno);
            this.tabPage3.Controls.Add(this.buttonAddAutosalone);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(792, 424);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Autosalone";
            this.tabPage3.UseVisualStyleBackColor = true;

            // DataGridView3 (Autosalone)
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(6, 6);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(780, 200);
            this.dataGridView3.TabIndex = 0;

            // ComboBoxMarcaAutosalone
            this.comboBoxMarcaAutosalone.FormattingEnabled = true;
            this.comboBoxMarcaAutosalone.Location = new System.Drawing.Point(6, 212);
            this.comboBoxMarcaAutosalone.Name = "comboBoxMarcaAutosalone";
            this.comboBoxMarcaAutosalone.Size = new System.Drawing.Size(200, 21);
            this.comboBoxMarcaAutosalone.TabIndex = 1;

            // ComboBoxModelloAutosalone
            this.comboBoxModelloAutosalone.FormattingEnabled = true;
            this.comboBoxModelloAutosalone.Location = new System.Drawing.Point(6, 239);
            this.comboBoxModelloAutosalone.Name = "comboBoxModelloAutosalone";
            this.comboBoxModelloAutosalone.Size = new System.Drawing.Size(200, 21);
            this.comboBoxModelloAutosalone.TabIndex = 2;

            // ComboBoxAnno
            this.comboBoxAnno.FormattingEnabled = true;
            this.comboBoxAnno.Location = new System.Drawing.Point(6, 266);
            this.comboBoxAnno.Name = "comboBoxAnno";
            this.comboBoxAnno.Size = new System.Drawing.Size(200, 21);
            this.comboBoxAnno.TabIndex = 3;

            // ButtonAddAutosalone
            this.buttonAddAutosalone.Location = new System.Drawing.Point(6, 293);
            this.buttonAddAutosalone.Name = "buttonAddAutosalone";
            this.buttonAddAutosalone.Size = new System.Drawing.Size(75, 23);
            this.buttonAddAutosalone.TabIndex = 4;
            this.buttonAddAutosalone.Text = "Aggiungi";
            this.buttonAddAutosalone.UseVisualStyleBackColor = true;

            // TabPage4 - Anni
            this.tabPage4.Controls.Add(this.dataGridView4);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(792, 424);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Anni";
            this.tabPage4.UseVisualStyleBackColor = true;

            // DataGridView4 (Anni)
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(6, 6);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(780, 200);
            this.dataGridView4.TabIndex = 0;

            // UserControl1
            this.Controls.Add(this.tabControl1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxMarca;
        private System.Windows.Forms.Button buttonAddMarca;
        private System.Windows.Forms.Button buttonDeleteMarca;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ComboBox comboBoxMarca;
        private System.Windows.Forms.TextBox textBoxModello;
        private System.Windows.Forms.Button buttonAddModello;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.ComboBox comboBoxMarcaAutosalone;
        private System.Windows.Forms.ComboBox comboBoxModelloAutosalone;
        private System.Windows.Forms.ComboBox comboBoxAnno;
        private System.Windows.Forms.Button buttonAddAutosalone;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dataGridView4;
    }
}
