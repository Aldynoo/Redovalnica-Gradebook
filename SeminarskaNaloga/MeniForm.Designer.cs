namespace SeminarskaNaloga
{
    partial class MeniForm
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
            btnProfesorji = new Button();
            btnDijaki = new Button();
            btnRazredi = new Button();
            btnPredmeti = new Button();
            SuspendLayout();
            // 
            // btnProfesorji
            // 
            btnProfesorji.Location = new Point(56, 57);
            btnProfesorji.Name = "btnProfesorji";
            btnProfesorji.Size = new Size(176, 31);
            btnProfesorji.TabIndex = 0;
            btnProfesorji.Text = "Profesorji";
            btnProfesorji.UseVisualStyleBackColor = true;
            btnProfesorji.Click += btnProfesorji_Click;
            // 
            // btnDijaki
            // 
            btnDijaki.Location = new Point(56, 117);
            btnDijaki.Name = "btnDijaki";
            btnDijaki.Size = new Size(176, 32);
            btnDijaki.TabIndex = 1;
            btnDijaki.Text = "Dijaki";
            btnDijaki.UseVisualStyleBackColor = true;
            // 
            // btnRazredi
            // 
            btnRazredi.Location = new Point(56, 177);
            btnRazredi.Name = "btnRazredi";
            btnRazredi.Size = new Size(176, 32);
            btnRazredi.TabIndex = 2;
            btnRazredi.Text = "Razredi";
            btnRazredi.UseVisualStyleBackColor = true;
            // 
            // btnPredmeti
            // 
            btnPredmeti.Location = new Point(56, 239);
            btnPredmeti.Name = "btnPredmeti";
            btnPredmeti.Size = new Size(176, 31);
            btnPredmeti.TabIndex = 3;
            btnPredmeti.Text = "Predmeti";
            btnPredmeti.UseVisualStyleBackColor = true;
            // 
            // MeniForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(290, 328);
            Controls.Add(btnPredmeti);
            Controls.Add(btnRazredi);
            Controls.Add(btnDijaki);
            Controls.Add(btnProfesorji);
            Name = "MeniForm";
            Text = "MeniForm";
            ResumeLayout(false);
        }

        #endregion

        private Button btnProfesorji;
        private Button btnDijaki;
        private Button btnRazredi;
        private Button btnPredmeti;
    }
}