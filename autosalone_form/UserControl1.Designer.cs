namespace autosalone_form
{
    partial class UserControl1
    {
        /// <summary>
        /// Variabile necessaria per il supporto della finestra di progettazione.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulisce tutte le risorse in uso.
        /// </summary>
        /// <param name="disposing">Indica se le risorse gestite devono essere eliminate.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato dal designer Windows Forms

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione.
        /// Non modificarlo con l'editor del codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonAddMarca = new System.Windows.Forms.Button();
            this.buttonDeleteMarca = new System.Windows.Forms.Button();
            this.textBoxMarca = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonAddModello = new System.Windows.Forms.Button();
            this.textBoxModello = new System.Windows.Forms.TextBox();
            this.comboBoxMarca = new System.Windows.Forms.ComboBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.buttonAddAutosalone = new System.Windows.Forms.Button();
            this.textBoxModelloAutosalone = new System.Windows.Forms.TextBox();
            this.comboBoxMarcaAutosalone = new System.Windows.Forms.ComboBox();
            this.comboBoxModelloAutosalone = new System.Windows.Forms.ComboBox();
            this.comboBoxAnno = new System.Windows.Forms.ComboBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
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
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(794, 444);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonAddMarca);
            this.tabPage1.Controls.Add(this.buttonDeleteMarca);
            this.tabPage1.Controls.Add(this.textBoxMarca);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(786, 418);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Marche";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonAddMarca
            // 
            this.buttonAddMarca.Location = new System.Drawing.Point(6, 57);
            this.buttonAddMarca.Name = "buttonAddMarca";
            this.buttonAddMarca.Size = new System.Drawing.Size(75, 23);
            this.buttonAddMarca.TabIndex = 1;
            this.buttonAddMarca.Text = "Aggiungi";
            this.buttonAddMarca.UseVisualStyleBackColor = true;
            this.buttonAddMarca.Click += new System.EventHandler(this.buttonAddMarca_Click);
            // 
            // buttonDeleteMarca
            // 
            this.buttonDeleteMarca.Location = new System.Drawing.Point(87, 57);
            this.buttonDeleteMarca.Name = "buttonDeleteMarca";
            this.buttonDeleteMarca.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteMarca.TabIndex = 2;
            this.buttonDeleteMarca.Text = "Elimina";
            this.buttonDeleteMarca.UseVisualStyleBackColor = true;
            this.buttonDeleteMarca.Click += new System.EventHandler(this.buttonDeleteMarca_Click);
            // 
            // textBoxMarca
            // 
            this.textBoxMarca.Location = new System.Drawing.Point(6, 31);
            this.textBoxMarca.Name = "textBoxMarca";
            this.textBoxMarca.Size = new System.Drawing.Size(156, 20);
            this.textBoxMarca.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 86);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(774, 326);
            this.dataGridView1.TabIndex = 3;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buttonAddModello);
            this.tabPage2.Controls.Add(this.textBoxModello);
            this.tabPage2.Controls.Add(this.comboBoxMarca);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(786, 418);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Modelli";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonAddModello
            // 
            this.buttonAddModello.Location = new System.Drawing.Point(6, 57);
            this.buttonAddModello.Name = "buttonAddModello";
            this.buttonAddModello.Size = new System.Drawing.Size(75, 23);
            this.buttonAddModello.TabIndex = 1;
            this.buttonAddModello.Text = "Aggiungi";
            this.buttonAddModello.UseVisualStyleBackColor = true;
            this.buttonAddModello.Click += new System.EventHandler(this.buttonAddModello_Click);
            // 
            // textBoxModello
            // 
            this.textBoxModello.Location = new System.Drawing.Point(6, 31);
            this.textBoxModello.Name = "textBoxModello";
            this.textBoxModello.Size = new System.Drawing.Size(156, 20);
            this.textBoxModello.TabIndex = 0;
            // 
            // comboBoxMarca
            // 
            this.comboBoxMarca.FormattingEnabled = true;
            this.comboBoxMarca.Location = new System.Drawing.Point(168, 31);
            this.comboBoxMarca.Name = "comboBoxMarca";
            this.comboBoxMarca.Size = new System.Drawing.Size(156, 21);
            this.comboBoxMarca.TabIndex = 2;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 86);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(774, 326);
            this.dataGridView2.TabIndex = 3;
            // textBoxModelloAutosalone
            // 
            this.textBoxModelloAutosalone.Location = new System.Drawing.Point(6, 31);
            this.textBoxModelloAutosalone.Name = "textBoxModelloAutosalone";
            this.textBoxModelloAutosalone.Size = new System.Drawing.Size(156, 20);
            this.textBoxModelloAutosalone.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.buttonAddAutosalone);
            this.tabPage3.Controls.Add(this.textBoxModelloAutosalone);
            this.tabPage3.Controls.Add(this.comboBoxMarcaAutosalone);
            this.tabPage3.Controls.Add(this.comboBoxModelloAutosalone);
            this.tabPage3.Controls.Add(this.comboBoxAnno);
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(786, 418);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Autosalone";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // buttonAddAutosalone
            // 
            this.buttonAddAutosalone.Location = new System.Drawing.Point(6, 93);
            this.buttonAddAutosalone.Name = "buttonAddAutosalone";
            this.buttonAddAutosalone.Size = new System.Drawing.Size(75, 23);
            this.buttonAddAutosalone.TabIndex = 5;
            this.buttonAddAutosalone.Text = "Aggiungi";
            this.buttonAddAutosalone.UseVisualStyleBackColor = true;
            this.buttonAddAutosalone.Click += new System.EventHandler(this.buttonAddAutosalone_Click);
            // 
           
            // 
            // comboBoxMarcaAutosalone
            // 
            this.comboBoxMarcaAutosalone.FormattingEnabled = true;
            this.comboBoxMarcaAutosalone.Location = new System.Drawing.Point(168, 31);
            this.comboBoxMarcaAutosalone.Name = "comboBoxMarcaAutosalone";
            this.comboBoxMarcaAutosalone.Size = new System.Drawing.Size(156, 21);
            this.comboBoxMarcaAutosalone.TabIndex = 1;
            // 
            // comboBoxModelloAutosalone
            // 
            this.comboBoxModelloAutosalone.FormattingEnabled = true;
            this.comboBoxModelloAutosalone.Location = new System.Drawing.Point(330, 31);
            this.comboBoxModelloAutosalone.Name = "comboBoxModelloAutosalone";
            this.comboBoxModelloAutosalone.Size = new System.Drawing.Size(156, 21);
            this.comboBoxModelloAutosalone.TabIndex = 2;
            // 
            // comboBoxAnno
            // 
            this.comboBoxAnno.FormattingEnabled = true;
            this.comboBoxAnno.Location = new System.Drawing.Point(492, 31);
            this.comboBoxAnno.Name = "comboBoxAnno";
            this.comboBoxAnno.Size = new System.Drawing.Size(156, 21);
            this.comboBoxAnno.TabIndex = 3;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(6, 122);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(774, 290);
            this.dataGridView3.TabIndex = 4;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dataGridView4);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(786, 418);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Report";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(6, 6);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(774, 406);
            this.dataGridView4.TabIndex = 0;
            // 
            // UserControl1
            // 
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

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.TextBox textBoxMarca;
        private System.Windows.Forms.Button buttonAddMarca;
        private System.Windows.Forms.Button buttonDeleteMarca;
        private System.Windows.Forms.ComboBox comboBoxMarca;
        private System.Windows.Forms.TextBox textBoxModello;
        private System.Windows.Forms.TextBox textBoxModelloAutosalone;
        private System.Windows.Forms.Button buttonAddModello;
        private System.Windows.Forms.ComboBox comboBoxMarcaAutosalone;
        private System.Windows.Forms.ComboBox comboBoxModelloAutosalone;
        private System.Windows.Forms.ComboBox comboBoxAnno;
        private System.Windows.Forms.Button buttonAddAutosalone;
    }
}
