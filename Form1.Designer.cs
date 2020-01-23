namespace Calc
{
    partial class MyForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonCalc = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.textBoxLaufzeit = new System.Windows.Forms.TextBox();
            this.textBoxTilgungssatz = new System.Windows.Forms.TextBox();
            this.textBoxZinsatz = new System.Windows.Forms.TextBox();
            this.textBoxKreditbetrag = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.colYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKreditbetrag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colZins = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTilgung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAnnuitaet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRestschuld = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-144, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Kreditbetrag:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(528, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Zinsbindungsfrist (Laufzeit)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(315, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "anfänglicher Tilgungssatz:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Zinssatz:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Kreditbetrag:";
            // 
            // buttonCalc
            // 
            this.buttonCalc.Location = new System.Drawing.Point(699, 42);
            this.buttonCalc.Name = "buttonCalc";
            this.buttonCalc.Size = new System.Drawing.Size(147, 23);
            this.buttonCalc.TabIndex = 23;
            this.buttonCalc.Text = "Berechnen";
            this.buttonCalc.UseVisualStyleBackColor = true;
            this.buttonCalc.Click += new System.EventHandler(this.buttonCalc_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colYear,
            this.colKreditbetrag,
            this.colZins,
            this.colTilgung,
            this.colAnnuitaet,
            this.colRestschuld});
            this.dataGridView.Location = new System.Drawing.Point(12, 89);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(1047, 360);
            this.dataGridView.TabIndex = 22;
            // 
            // textBoxLaufzeit
            // 
            this.textBoxLaufzeit.Location = new System.Drawing.Point(533, 42);
            this.textBoxLaufzeit.Name = "textBoxLaufzeit";
            this.textBoxLaufzeit.Size = new System.Drawing.Size(100, 20);
            this.textBoxLaufzeit.TabIndex = 20;
            // 
            // textBoxTilgungssatz
            // 
            this.textBoxTilgungssatz.Location = new System.Drawing.Point(318, 41);
            this.textBoxTilgungssatz.Name = "textBoxTilgungssatz";
            this.textBoxTilgungssatz.Size = new System.Drawing.Size(100, 20);
            this.textBoxTilgungssatz.TabIndex = 21;
            // 
            // textBoxZinsatz
            // 
            this.textBoxZinsatz.Location = new System.Drawing.Point(186, 41);
            this.textBoxZinsatz.Name = "textBoxZinsatz";
            this.textBoxZinsatz.Size = new System.Drawing.Size(100, 20);
            this.textBoxZinsatz.TabIndex = 19;
            // 
            // textBoxKreditbetrag
            // 
            this.textBoxKreditbetrag.Location = new System.Drawing.Point(36, 42);
            this.textBoxKreditbetrag.Name = "textBoxKreditbetrag";
            this.textBoxKreditbetrag.Size = new System.Drawing.Size(100, 20);
            this.textBoxKreditbetrag.TabIndex = 18;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(862, 42);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(95, 20);
            this.dateTimePicker.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(862, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Datumsauswahl";
            // 
            // colYear
            // 
            this.colYear.HeaderText = "Jahr";
            this.colYear.Name = "colYear";
            this.colYear.ReadOnly = true;
            this.colYear.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colKreditbetrag
            // 
            this.colKreditbetrag.HeaderText = "Kreditbetrag";
            this.colKreditbetrag.Name = "colKreditbetrag";
            this.colKreditbetrag.ReadOnly = true;
            this.colKreditbetrag.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colZins
            // 
            this.colZins.HeaderText = "Zins";
            this.colZins.Name = "colZins";
            this.colZins.ReadOnly = true;
            this.colZins.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colTilgung
            // 
            this.colTilgung.HeaderText = "Tilgung";
            this.colTilgung.Name = "colTilgung";
            this.colTilgung.ReadOnly = true;
            this.colTilgung.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colAnnuitaet
            // 
            this.colAnnuitaet.HeaderText = "Annuität";
            this.colAnnuitaet.Name = "colAnnuitaet";
            this.colAnnuitaet.ReadOnly = true;
            this.colAnnuitaet.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colRestschuld
            // 
            this.colRestschuld.HeaderText = "Restschuld";
            this.colRestschuld.Name = "colRestschuld";
            this.colRestschuld.ReadOnly = true;
            this.colRestschuld.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // MyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 495);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonCalc);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.textBoxLaufzeit);
            this.Controls.Add(this.textBoxTilgungssatz);
            this.Controls.Add(this.textBoxZinsatz);
            this.Controls.Add(this.textBoxKreditbetrag);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "MyForm";
            this.Text = "Kreditrechner";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonCalc;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox textBoxLaufzeit;
        private System.Windows.Forms.TextBox textBoxTilgungssatz;
        private System.Windows.Forms.TextBox textBoxZinsatz;
        private System.Windows.Forms.TextBox textBoxKreditbetrag;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn colYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKreditbetrag;
        private System.Windows.Forms.DataGridViewTextBoxColumn colZins;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTilgung;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAnnuitaet;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRestschuld;
    }
}

