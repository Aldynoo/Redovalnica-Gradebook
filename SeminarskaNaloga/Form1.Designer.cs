namespace SeminarskaNaloga
{
    partial class frmRedovalnica
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblRedovalnica = new Label();
            lblUporabniskoIme = new Label();
            lblGeslo = new Label();
            txtUporabniskoIme = new TextBox();
            txtGeslo = new TextBox();
            btnPrijava = new Button();
            lblPrijava = new Label();
            SuspendLayout();
            // 
            // lblRedovalnica
            // 
            lblRedovalnica.AutoSize = true;
            lblRedovalnica.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblRedovalnica.Location = new Point(250, 19);
            lblRedovalnica.Name = "lblRedovalnica";
            lblRedovalnica.Size = new Size(125, 25);
            lblRedovalnica.TabIndex = 0;
            lblRedovalnica.Text = "Redovalnica!";
            // 
            // lblUporabniskoIme
            // 
            lblUporabniskoIme.AutoSize = true;
            lblUporabniskoIme.Location = new Point(170, 110);
            lblUporabniskoIme.Name = "lblUporabniskoIme";
            lblUporabniskoIme.Size = new Size(100, 15);
            lblUporabniskoIme.TabIndex = 1;
            lblUporabniskoIme.Text = "Uporabniško ime:";
            // 
            // lblGeslo
            // 
            lblGeslo.AutoSize = true;
            lblGeslo.Location = new Point(231, 153);
            lblGeslo.Name = "lblGeslo";
            lblGeslo.Size = new Size(39, 15);
            lblGeslo.TabIndex = 2;
            lblGeslo.Text = "Geslo:";
            // 
            // txtUporabniskoIme
            // 
            txtUporabniskoIme.Location = new Point(276, 102);
            txtUporabniskoIme.Name = "txtUporabniskoIme";
            txtUporabniskoIme.Size = new Size(151, 23);
            txtUporabniskoIme.TabIndex = 3;
            // 
            // txtGeslo
            // 
            txtGeslo.Location = new Point(276, 145);
            txtGeslo.Name = "txtGeslo";
            txtGeslo.PasswordChar = '*';
            txtGeslo.Size = new Size(151, 23);
            txtGeslo.TabIndex = 4;
            // 
            // btnPrijava
            // 
            btnPrijava.Font = new Font("Segoe UI", 9F);
            btnPrijava.Location = new Point(250, 200);
            btnPrijava.Name = "btnPrijava";
            btnPrijava.Size = new Size(125, 26);
            btnPrijava.TabIndex = 5;
            btnPrijava.Text = "Prijava";
            btnPrijava.UseVisualStyleBackColor = true;
            btnPrijava.Click += btnPrijava_Click;
            // 
            // lblPrijava
            // 
            lblPrijava.AutoSize = true;
            lblPrijava.Location = new Point(297, 257);
            lblPrijava.Name = "lblPrijava";
            lblPrijava.Size = new Size(0, 15);
            lblPrijava.TabIndex = 6;
            // 
            // frmRedovalnica
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(638, 331);
            Controls.Add(lblPrijava);
            Controls.Add(btnPrijava);
            Controls.Add(txtGeslo);
            Controls.Add(txtUporabniskoIme);
            Controls.Add(lblGeslo);
            Controls.Add(lblUporabniskoIme);
            Controls.Add(lblRedovalnica);
            Name = "frmRedovalnica";
            Text = "Redovalnica";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRedovalnica;
        private Label lblUporabniskoIme;
        private Label lblGeslo;
        private TextBox txtUporabniskoIme;
        private TextBox txtGeslo;
        private Button btnPrijava;
        private Label lblPrijava;
    }
}
