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
            dgvProfesorji = new DataGridView();
            lblImeProf = new Label();
            lblPriimekProf = new Label();
            lblPredmetProf = new Label();
            lblTelefonProf = new Label();
            txtImeProf = new TextBox();
            txtPriimekProf = new TextBox();
            txtTelefonProf = new TextBox();
            btnDodajProf = new Button();
            cbPredmetProf = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvDijaki).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProfesorji).BeginInit();
            SuspendLayout();
            // 
            // txtIme
            // 
            txtIme.Location = new Point(124, 291);
            txtIme.Name = "txtIme";
            txtIme.Size = new Size(189, 23);
            txtIme.TabIndex = 0;
            // 
            // txtPriimek
            // 
            txtPriimek.Location = new Point(124, 345);
            txtPriimek.Name = "txtPriimek";
            txtPriimek.Size = new Size(189, 23);
            txtPriimek.TabIndex = 1;
            // 
            // txtNaslov
            // 
            txtNaslov.Location = new Point(124, 398);
            txtNaslov.Name = "txtNaslov";
            txtNaslov.Size = new Size(189, 23);
            txtNaslov.TabIndex = 2;
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(124, 449);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(189, 23);
            txtTelefon.TabIndex = 3;
            // 
            // cbRazredi
            // 
            cbRazredi.FormattingEnabled = true;
            cbRazredi.Location = new Point(358, 291);
            cbRazredi.Name = "cbRazredi";
            cbRazredi.Size = new Size(179, 23);
            cbRazredi.TabIndex = 4;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(358, 388);
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
            dgvDijaki.Size = new Size(573, 235);
            dgvDijaki.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(88, 299);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 7;
            label1.Text = "Ime:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(68, 353);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 8;
            label2.Text = "Priimek:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(72, 406);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 9;
            label3.Text = "Naslov:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(69, 457);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 10;
            label4.Text = "Telefon:";
            // 
            // dgvProfesorji
            // 
            dgvProfesorji.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProfesorji.Location = new Point(637, 28);
            dgvProfesorji.Name = "dgvProfesorji";
            dgvProfesorji.Size = new Size(447, 235);
            dgvProfesorji.TabIndex = 11;
            // 
            // lblImeProf
            // 
            lblImeProf.AutoSize = true;
            lblImeProf.Location = new Point(708, 294);
            lblImeProf.Name = "lblImeProf";
            lblImeProf.Size = new Size(30, 15);
            lblImeProf.TabIndex = 12;
            lblImeProf.Text = "Ime:";
            // 
            // lblPriimekProf
            // 
            lblPriimekProf.AutoSize = true;
            lblPriimekProf.Location = new Point(688, 353);
            lblPriimekProf.Name = "lblPriimekProf";
            lblPriimekProf.Size = new Size(50, 15);
            lblPriimekProf.TabIndex = 13;
            lblPriimekProf.Text = "Priimek:";
            // 
            // lblPredmetProf
            // 
            lblPredmetProf.AutoSize = true;
            lblPredmetProf.Location = new Point(683, 406);
            lblPredmetProf.Name = "lblPredmetProf";
            lblPredmetProf.Size = new Size(55, 15);
            lblPredmetProf.TabIndex = 14;
            lblPredmetProf.Text = "Predmet:";
            // 
            // lblTelefonProf
            // 
            lblTelefonProf.AutoSize = true;
            lblTelefonProf.Location = new Point(689, 457);
            lblTelefonProf.Name = "lblTelefonProf";
            lblTelefonProf.Size = new Size(49, 15);
            lblTelefonProf.TabIndex = 15;
            lblTelefonProf.Text = "Telefon:";
            // 
            // txtImeProf
            // 
            txtImeProf.Location = new Point(744, 291);
            txtImeProf.Name = "txtImeProf";
            txtImeProf.Size = new Size(189, 23);
            txtImeProf.TabIndex = 16;
            // 
            // txtPriimekProf
            // 
            txtPriimekProf.Location = new Point(744, 345);
            txtPriimekProf.Name = "txtPriimekProf";
            txtPriimekProf.Size = new Size(189, 23);
            txtPriimekProf.TabIndex = 17;
            // 
            // txtTelefonProf
            // 
            txtTelefonProf.Location = new Point(744, 449);
            txtTelefonProf.Name = "txtTelefonProf";
            txtTelefonProf.Size = new Size(189, 23);
            txtTelefonProf.TabIndex = 19;
            // 
            // btnDodajProf
            // 
            btnDodajProf.Location = new Point(964, 387);
            btnDodajProf.Name = "btnDodajProf";
            btnDodajProf.Size = new Size(118, 33);
            btnDodajProf.TabIndex = 20;
            btnDodajProf.Text = "Dodaj profesorja";
            btnDodajProf.UseVisualStyleBackColor = true;
            // 
            // cbPredmetProf
            // 
            cbPredmetProf.FormattingEnabled = true;
            cbPredmetProf.Location = new Point(744, 403);
            cbPredmetProf.Name = "cbPredmetProf";
            cbPredmetProf.Size = new Size(189, 23);
            cbPredmetProf.TabIndex = 21;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1133, 486);
            Controls.Add(cbPredmetProf);
            Controls.Add(btnDodajProf);
            Controls.Add(txtTelefonProf);
            Controls.Add(txtPriimekProf);
            Controls.Add(txtImeProf);
            Controls.Add(lblTelefonProf);
            Controls.Add(lblPredmetProf);
            Controls.Add(lblPriimekProf);
            Controls.Add(lblImeProf);
            Controls.Add(dgvProfesorji);
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
            Load += AdminForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDijaki).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProfesorji).EndInit();
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
        private DataGridView dgvProfesorji;
        private Label lblImeProf;
        private Label lblPriimekProf;
        private Label lblPredmetProf;
        private Label lblTelefonProf;
        private TextBox txtImeProf;
        private TextBox txtPriimekProf;
        private TextBox txtTelefonProf;
        private Button btnDodajProf;
        private ComboBox cbPredmetProf;
    }
}