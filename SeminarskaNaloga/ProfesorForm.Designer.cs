namespace SeminarskaNaloga
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
            dgvProfesor = new DataGridView();
            btnDodajProfesorja = new Button();
            btnUrediProfesorja = new Button();
            btnIzbrisiProfesorja = new Button();
            lblProfesorji = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProfesor).BeginInit();
            SuspendLayout();
            // 
            // dgvProfesor
            // 
            dgvProfesor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProfesor.Location = new Point(12, 36);
            dgvProfesor.Name = "dgvProfesor";
            dgvProfesor.Size = new Size(354, 402);
            dgvProfesor.TabIndex = 0;
            dgvProfesor.CellContentClick += dgvProfesor_CellContentClick;
            // 
            // btnDodajProfesorja
            // 
            btnDodajProfesorja.Location = new Point(393, 125);
            btnDodajProfesorja.Name = "btnDodajProfesorja";
            btnDodajProfesorja.Size = new Size(295, 36);
            btnDodajProfesorja.TabIndex = 1;
            btnDodajProfesorja.Text = "Dodaj profesorja";
            btnDodajProfesorja.UseVisualStyleBackColor = true;
            btnDodajProfesorja.Click += btnDodajProfesorja_Click;
            // 
            // btnUrediProfesorja
            // 
            btnUrediProfesorja.Location = new Point(393, 198);
            btnUrediProfesorja.Name = "btnUrediProfesorja";
            btnUrediProfesorja.Size = new Size(295, 36);
            btnUrediProfesorja.TabIndex = 2;
            btnUrediProfesorja.Text = "Uredi profesorja";
            btnUrediProfesorja.UseVisualStyleBackColor = true;
            // 
            // btnIzbrisiProfesorja
            // 
            btnIzbrisiProfesorja.Location = new Point(393, 277);
            btnIzbrisiProfesorja.Name = "btnIzbrisiProfesorja";
            btnIzbrisiProfesorja.Size = new Size(295, 36);
            btnIzbrisiProfesorja.TabIndex = 3;
            btnIzbrisiProfesorja.Text = "Izbriši profesorja";
            btnIzbrisiProfesorja.UseVisualStyleBackColor = true;
            // 
            // lblProfesorji
            // 
            lblProfesorji.AutoSize = true;
            lblProfesorji.Font = new Font("Segoe UI", 10F);
            lblProfesorji.Location = new Point(12, 9);
            lblProfesorji.Name = "lblProfesorji";
            lblProfesorji.Size = new Size(69, 19);
            lblProfesorji.TabIndex = 4;
            lblProfesorji.Text = "Profesorji:";
            // 
            // ProfesorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(704, 450);
            Controls.Add(lblProfesorji);
            Controls.Add(btnIzbrisiProfesorja);
            Controls.Add(btnUrediProfesorja);
            Controls.Add(btnDodajProfesorja);
            Controls.Add(dgvProfesor);
            Name = "ProfesorForm";
            Text = "ProfesorForm";
            Load += ProfesorForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProfesor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvProfesor;
        private Button btnDodajProfesorja;
        private Button btnUrediProfesorja;
        private Button btnIzbrisiProfesorja;
        private Label lblProfesorji;
    }
}