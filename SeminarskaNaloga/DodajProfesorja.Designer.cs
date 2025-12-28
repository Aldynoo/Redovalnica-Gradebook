namespace SeminarskaNaloga
{
    partial class DodajProfesorja
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
            label1 = new Label();
            txtID = new TextBox();
            txtPriIme = new TextBox();
            txtPredmet = new TextBox();
            txtRazred = new TextBox();
            btnDodaj = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(211, 62);
            label1.Name = "label1";
            label1.Size = new Size(21, 15);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // txtID
            // 
            txtID.Location = new Point(238, 59);
            txtID.Name = "txtID";
            txtID.Size = new Size(149, 23);
            txtID.TabIndex = 1;
            // 
            // txtPriIme
            // 
            txtPriIme.Location = new Point(238, 110);
            txtPriIme.Name = "txtPriIme";
            txtPriIme.Size = new Size(149, 23);
            txtPriIme.TabIndex = 2;
            // 
            // txtPredmet
            // 
            txtPredmet.Location = new Point(238, 166);
            txtPredmet.Name = "txtPredmet";
            txtPredmet.Size = new Size(149, 23);
            txtPredmet.TabIndex = 3;
            // 
            // txtRazred
            // 
            txtRazred.Location = new Point(238, 226);
            txtRazred.Name = "txtRazred";
            txtRazred.Size = new Size(149, 23);
            txtRazred.TabIndex = 4;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(241, 305);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(146, 23);
            btnDodaj.TabIndex = 5;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // DodajProfesorja
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(474, 450);
            Controls.Add(btnDodaj);
            Controls.Add(txtRazred);
            Controls.Add(txtPredmet);
            Controls.Add(txtPriIme);
            Controls.Add(txtID);
            Controls.Add(label1);
            Name = "DodajProfesorja";
            Text = "DodajProfesorja";
            Load += DodajProfesorja_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtID;
        private TextBox txtPriIme;
        private TextBox txtPredmet;
        private TextBox txtRazred;
        private Button btnDodaj;
    }
}