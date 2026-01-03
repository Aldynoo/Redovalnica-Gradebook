namespace SeminarskaNaloga.Forms
{
    partial class ProfesorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblPozdrav = new Label();
            cbRazredi = new ComboBox();
            cbPredmeti = new ComboBox();
            dgvDijaki = new DataGridView();
            nudOcena = new NumericUpDown();
            btnDodajOceno = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDijaki).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudOcena).BeginInit();
            SuspendLayout();
            // 
            // lblPozdrav
            // 
            lblPozdrav.AutoSize = true;
            lblPozdrav.Location = new Point(283, 65);
            lblPozdrav.Name = "lblPozdrav";
            lblPozdrav.Size = new Size(0, 15);
            lblPozdrav.TabIndex = 0;
            // 
            // cbRazredi
            // 
            cbRazredi.FormattingEnabled = true;
            cbRazredi.Location = new Point(34, 12);
            cbRazredi.Name = "cbRazredi";
            cbRazredi.Size = new Size(121, 23);
            cbRazredi.TabIndex = 1;
            cbRazredi.SelectedIndexChanged += cbRazredi_SelectedIndexChanged;
            // 
            // cbPredmeti
            // 
            cbPredmeti.FormattingEnabled = true;
            cbPredmeti.Location = new Point(195, 12);
            cbPredmeti.Name = "cbPredmeti";
            cbPredmeti.Size = new Size(121, 23);
            cbPredmeti.TabIndex = 2;
            // 
            // dgvDijaki
            // 
            dgvDijaki.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDijaki.Location = new Point(12, 111);
            dgvDijaki.Name = "dgvDijaki";
            dgvDijaki.Size = new Size(476, 250);
            dgvDijaki.TabIndex = 3;
            // 
            // nudOcena
            // 
            nudOcena.Location = new Point(351, 13);
            nudOcena.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            nudOcena.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudOcena.Name = "nudOcena";
            nudOcena.Size = new Size(120, 23);
            nudOcena.TabIndex = 4;
            nudOcena.TextAlign = HorizontalAlignment.Center;
            nudOcena.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnDodajOceno
            // 
            btnDodajOceno.Location = new Point(34, 58);
            btnDodajOceno.Name = "btnDodajOceno";
            btnDodajOceno.Size = new Size(437, 32);
            btnDodajOceno.TabIndex = 5;
            btnDodajOceno.Text = "Dodaj oceno:";
            btnDodajOceno.UseVisualStyleBackColor = true;
            btnDodajOceno.Click += btnDodajOceno_Click;
            // 
            // ProfesorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 373);
            Controls.Add(btnDodajOceno);
            Controls.Add(nudOcena);
            Controls.Add(dgvDijaki);
            Controls.Add(cbPredmeti);
            Controls.Add(cbRazredi);
            Controls.Add(lblPozdrav);
            Name = "ProfesorForm";
            Text = "ProfesorForm";
            ((System.ComponentModel.ISupportInitialize)dgvDijaki).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudOcena).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPozdrav;
        private ComboBox cbRazredi;
        private ComboBox cbPredmeti;
        private DataGridView dgvDijaki;
        private NumericUpDown nudOcena;
        private Button btnDodajOceno;
    }
}