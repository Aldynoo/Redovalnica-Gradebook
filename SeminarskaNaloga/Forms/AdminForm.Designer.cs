namespace SeminarskaNaloga.Forms
{
    partial class AdminForm
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
            txtIme = new TextBox();
            txtPriimek = new TextBox();
            txtNaslov = new TextBox();
            txtTelefon = new TextBox();
            cbRazredi = new ComboBox();
            btnDodaj = new Button();
            dgvDijaki = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDijaki).BeginInit();
            SuspendLayout();
            // 
            // txtIme
            // 
            txtIme.Location = new Point(85, 286);
            txtIme.Name = "txtIme";
            txtIme.Size = new Size(189, 23);
            txtIme.TabIndex = 0;
            // 
            // txtPriimek
            // 
            txtPriimek.Location = new Point(85, 340);
            txtPriimek.Name = "txtPriimek";
            txtPriimek.Size = new Size(189, 23);
            txtPriimek.TabIndex = 1;
            // 
            // txtNaslov
            // 
            txtNaslov.Location = new Point(85, 393);
            txtNaslov.Name = "txtNaslov";
            txtNaslov.Size = new Size(189, 23);
            txtNaslov.TabIndex = 2;
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(85, 444);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(189, 23);
            txtTelefon.TabIndex = 3;
            // 
            // cbRazredi
            // 
            cbRazredi.FormattingEnabled = true;
            cbRazredi.Location = new Point(319, 286);
            cbRazredi.Name = "cbRazredi";
            cbRazredi.Size = new Size(179, 23);
            cbRazredi.TabIndex = 4;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(319, 383);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(179, 33);
            btnDodaj.TabIndex = 5;
            btnDodaj.Text = "Dodaj dijaka";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // dgvDijaki
            // 
            dgvDijaki.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDijaki.Location = new Point(25, 28);
            dgvDijaki.Name = "dgvDijaki";
            dgvDijaki.Size = new Size(473, 235);
            dgvDijaki.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 294);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 7;
            label1.Text = "Ime:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 348);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 8;
            label2.Text = "Priimek:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 401);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 9;
            label3.Text = "Naslov:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 452);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 10;
            label4.Text = "Telefon:";
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(536, 486);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvDijaki);
            Controls.Add(btnDodaj);
            Controls.Add(cbRazredi);
            Controls.Add(txtTelefon);
            Controls.Add(txtNaslov);
            Controls.Add(txtPriimek);
            Controls.Add(txtIme);
            Name = "AdminForm";
            Text = "AdminForm";
            ((System.ComponentModel.ISupportInitialize)dgvDijaki).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtIme;
        private TextBox txtPriimek;
        private TextBox txtNaslov;
        private TextBox txtTelefon;
        private ComboBox cbRazredi;
        private Button btnDodaj;
        private DataGridView dgvDijaki;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}