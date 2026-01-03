namespace SeminarskaNaloga.Forms
{
    partial class LoginForm
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
            txtUporabnik = new TextBox();
            lblUporabnik = new Label();
            txtGeslo = new TextBox();
            lblGeslo = new Label();
            btnPrijava = new Button();
            btnIzhod = new Button();
            lblSporocilo = new Label();
            SuspendLayout();
            // 
            // txtUporabnik
            // 
            txtUporabnik.Location = new Point(184, 90);
            txtUporabnik.Name = "txtUporabnik";
            txtUporabnik.Size = new Size(178, 23);
            txtUporabnik.TabIndex = 0;
            // 
            // lblUporabnik
            // 
            lblUporabnik.AutoSize = true;
            lblUporabnik.Location = new Point(78, 98);
            lblUporabnik.Name = "lblUporabnik";
            lblUporabnik.Size = new Size(100, 15);
            lblUporabnik.TabIndex = 1;
            lblUporabnik.Text = "Uporabniško ime:";
            // 
            // txtGeslo
            // 
            txtGeslo.Location = new Point(184, 141);
            txtGeslo.Name = "txtGeslo";
            txtGeslo.PasswordChar = '*';
            txtGeslo.Size = new Size(178, 23);
            txtGeslo.TabIndex = 2;
            // 
            // lblGeslo
            // 
            lblGeslo.AutoSize = true;
            lblGeslo.Location = new Point(139, 149);
            lblGeslo.Name = "lblGeslo";
            lblGeslo.Size = new Size(39, 15);
            lblGeslo.TabIndex = 3;
            lblGeslo.Text = "Geslo:";
            // 
            // btnPrijava
            // 
            btnPrijava.Location = new Point(78, 211);
            btnPrijava.Name = "btnPrijava";
            btnPrijava.Size = new Size(284, 28);
            btnPrijava.TabIndex = 4;
            btnPrijava.Text = "Prijava";
            btnPrijava.UseVisualStyleBackColor = true;
            btnPrijava.Click += btnPrijava_Click;
            // 
            // btnIzhod
            // 
            btnIzhod.Location = new Point(78, 257);
            btnIzhod.Name = "btnIzhod";
            btnIzhod.Size = new Size(284, 28);
            btnIzhod.TabIndex = 5;
            btnIzhod.Text = "Izhod";
            btnIzhod.UseVisualStyleBackColor = true;
            btnIzhod.Click += btnIzhod_Click;
            // 
            // lblSporocilo
            // 
            lblSporocilo.AutoSize = true;
            lblSporocilo.Location = new Point(203, 180);
            lblSporocilo.Name = "lblSporocilo";
            lblSporocilo.Size = new Size(0, 15);
            lblSporocilo.TabIndex = 6;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(446, 333);
            Controls.Add(lblSporocilo);
            Controls.Add(btnIzhod);
            Controls.Add(btnPrijava);
            Controls.Add(lblGeslo);
            Controls.Add(txtGeslo);
            Controls.Add(lblUporabnik);
            Controls.Add(txtUporabnik);
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUporabnik;
        private Label lblUporabnik;
        private TextBox txtGeslo;
        private Label lblGeslo;
        private Button btnPrijava;
        private Button btnIzhod;
        private Label lblSporocilo;
    }
}