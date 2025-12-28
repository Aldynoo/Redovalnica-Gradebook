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
            ((System.ComponentModel.ISupportInitialize)dgvProfesor).BeginInit();
            SuspendLayout();
            // 
            // dgvProfesor
            // 
            dgvProfesor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProfesor.Location = new Point(12, 12);
            dgvProfesor.Name = "dgvProfesor";
            dgvProfesor.Size = new Size(354, 426);
            dgvProfesor.TabIndex = 0;
            // 
            // ProfesorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvProfesor);
            Name = "ProfesorForm";
            Text = "ProfesorForm";
            ((System.ComponentModel.ISupportInitialize)dgvProfesor).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvProfesor;
    }
}