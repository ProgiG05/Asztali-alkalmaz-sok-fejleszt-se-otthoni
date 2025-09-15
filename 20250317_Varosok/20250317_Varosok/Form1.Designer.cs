
namespace _20250317_Varosok
{
    partial class Főablak
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
            this.belepes = new System.Windows.Forms.Button();
            this.kilepes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // belepes
            // 
            this.belepes.BackColor = System.Drawing.Color.White;
            this.belepes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.belepes.ForeColor = System.Drawing.Color.Black;
            this.belepes.Location = new System.Drawing.Point(12, 12);
            this.belepes.Name = "belepes";
            this.belepes.Size = new System.Drawing.Size(310, 140);
            this.belepes.TabIndex = 0;
            this.belepes.Text = "BELÉPÉS";
            this.belepes.UseVisualStyleBackColor = false;
            // 
            // kilepes
            // 
            this.kilepes.BackColor = System.Drawing.Color.Black;
            this.kilepes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kilepes.ForeColor = System.Drawing.Color.White;
            this.kilepes.Location = new System.Drawing.Point(12, 159);
            this.kilepes.Name = "kilepes";
            this.kilepes.Size = new System.Drawing.Size(310, 140);
            this.kilepes.TabIndex = 1;
            this.kilepes.Text = "KILÉPÉS";
            this.kilepes.UseVisualStyleBackColor = false;
            this.kilepes.Click += new System.EventHandler(this.kilepes_Click);
            // 
            // Főablak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 311);
            this.Controls.Add(this.kilepes);
            this.Controls.Add(this.belepes);
            this.Name = "Főablak";
            this.Text = "Főablak";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button belepes;
        private System.Windows.Forms.Button kilepes;
    }
}

