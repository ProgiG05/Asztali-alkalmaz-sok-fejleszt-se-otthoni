
namespace _20241007_gyakorlas
{
    partial class Form1
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
            this.szorzas = new System.Windows.Forms.Button();
            this.plusz = new System.Windows.Forms.Button();
            this.minusz = new System.Windows.Forms.Button();
            this.osztas = new System.Windows.Forms.Button();
            this.main_title = new System.Windows.Forms.Label();
            this.szam1 = new System.Windows.Forms.Label();
            this.szam2 = new System.Windows.Forms.Label();
            this.eredmeny_lbl = new System.Windows.Forms.Label();
            this.elsoszam = new System.Windows.Forms.TextBox();
            this.masodikszam = new System.Windows.Forms.TextBox();
            this.bezár = new System.Windows.Forms.Button();
            this.eredmény = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // szorzas
            // 
            this.szorzas.BackColor = System.Drawing.Color.Gold;
            this.szorzas.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.szorzas.Location = new System.Drawing.Point(273, 362);
            this.szorzas.Name = "szorzas";
            this.szorzas.Size = new System.Drawing.Size(75, 75);
            this.szorzas.TabIndex = 0;
            this.szorzas.Text = "*";
            this.szorzas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.szorzas.UseVisualStyleBackColor = false;
            this.szorzas.Click += new System.EventHandler(this.szorzas_Click);
            // 
            // plusz
            // 
            this.plusz.BackColor = System.Drawing.Color.Gold;
            this.plusz.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.plusz.Location = new System.Drawing.Point(192, 281);
            this.plusz.Name = "plusz";
            this.plusz.Size = new System.Drawing.Size(75, 75);
            this.plusz.TabIndex = 1;
            this.plusz.Text = "+";
            this.plusz.UseVisualStyleBackColor = false;
            this.plusz.Click += new System.EventHandler(this.plusz_Click);
            // 
            // minusz
            // 
            this.minusz.BackColor = System.Drawing.Color.Gold;
            this.minusz.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.minusz.Location = new System.Drawing.Point(273, 281);
            this.minusz.Name = "minusz";
            this.minusz.Size = new System.Drawing.Size(75, 75);
            this.minusz.TabIndex = 2;
            this.minusz.Text = "-";
            this.minusz.UseVisualStyleBackColor = false;
            this.minusz.Click += new System.EventHandler(this.minusz_Click);
            // 
            // osztas
            // 
            this.osztas.BackColor = System.Drawing.Color.Gold;
            this.osztas.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.osztas.Location = new System.Drawing.Point(192, 362);
            this.osztas.Name = "osztas";
            this.osztas.Size = new System.Drawing.Size(75, 75);
            this.osztas.TabIndex = 3;
            this.osztas.Text = "/";
            this.osztas.UseVisualStyleBackColor = false;
            this.osztas.Click += new System.EventHandler(this.button1_Click);
            // 
            // main_title
            // 
            this.main_title.AutoSize = true;
            this.main_title.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.main_title.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.main_title.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.main_title.Location = new System.Drawing.Point(186, 25);
            this.main_title.Name = "main_title";
            this.main_title.Size = new System.Drawing.Size(181, 36);
            this.main_title.TabIndex = 4;
            this.main_title.Text = "Alapműveletek";
            // 
            // szam1
            // 
            this.szam1.AutoSize = true;
            this.szam1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.szam1.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.szam1.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.szam1.Location = new System.Drawing.Point(35, 122);
            this.szam1.Name = "szam1";
            this.szam1.Size = new System.Drawing.Size(76, 25);
            this.szam1.TabIndex = 5;
            this.szam1.Text = "1. szám";
            // 
            // szam2
            // 
            this.szam2.AutoSize = true;
            this.szam2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.szam2.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.szam2.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.szam2.Location = new System.Drawing.Point(35, 161);
            this.szam2.Name = "szam2";
            this.szam2.Size = new System.Drawing.Size(76, 25);
            this.szam2.TabIndex = 6;
            this.szam2.Text = "2. szám";
            // 
            // eredmeny_lbl
            // 
            this.eredmeny_lbl.AutoSize = true;
            this.eredmeny_lbl.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.eredmeny_lbl.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.eredmeny_lbl.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.eredmeny_lbl.Location = new System.Drawing.Point(35, 199);
            this.eredmeny_lbl.Name = "eredmeny_lbl";
            this.eredmeny_lbl.Size = new System.Drawing.Size(105, 25);
            this.eredmeny_lbl.TabIndex = 7;
            this.eredmeny_lbl.Text = "Eredmény: ";
            // 
            // elsoszam
            // 
            this.elsoszam.Location = new System.Drawing.Point(192, 122);
            this.elsoszam.Name = "elsoszam";
            this.elsoszam.Size = new System.Drawing.Size(156, 20);
            this.elsoszam.TabIndex = 8;
            // 
            // masodikszam
            // 
            this.masodikszam.Location = new System.Drawing.Point(192, 161);
            this.masodikszam.Name = "masodikszam";
            this.masodikszam.Size = new System.Drawing.Size(156, 20);
            this.masodikszam.TabIndex = 9;
            // 
            // bezár
            // 
            this.bezár.BackColor = System.Drawing.Color.Red;
            this.bezár.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bezár.ForeColor = System.Drawing.SystemColors.Control;
            this.bezár.Location = new System.Drawing.Point(506, 409);
            this.bezár.Name = "bezár";
            this.bezár.Size = new System.Drawing.Size(45, 45);
            this.bezár.TabIndex = 11;
            this.bezár.Text = "x";
            this.bezár.UseVisualStyleBackColor = false;
            this.bezár.Click += new System.EventHandler(this.bezár_Click);
            // 
            // eredmény
            // 
            this.eredmény.Location = new System.Drawing.Point(192, 203);
            this.eredmény.Name = "eredmény";
            this.eredmény.Size = new System.Drawing.Size(156, 20);
            this.eredmény.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(563, 466);
            this.Controls.Add(this.eredmény);
            this.Controls.Add(this.bezár);
            this.Controls.Add(this.masodikszam);
            this.Controls.Add(this.elsoszam);
            this.Controls.Add(this.eredmeny_lbl);
            this.Controls.Add(this.szam2);
            this.Controls.Add(this.szam1);
            this.Controls.Add(this.main_title);
            this.Controls.Add(this.osztas);
            this.Controls.Add(this.minusz);
            this.Controls.Add(this.plusz);
            this.Controls.Add(this.szorzas);
            this.Name = "Form1";
            this.Text = "Alapműveletek";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button szorzas;
        private System.Windows.Forms.Button plusz;
        private System.Windows.Forms.Button minusz;
        private System.Windows.Forms.Button osztas;
        private System.Windows.Forms.Label main_title;
        private System.Windows.Forms.Label szam1;
        private System.Windows.Forms.Label szam2;
        private System.Windows.Forms.Label eredmeny_lbl;
        private System.Windows.Forms.TextBox elsoszam;
        private System.Windows.Forms.TextBox masodikszam;
        private System.Windows.Forms.Button bezár;
        private System.Windows.Forms.TextBox eredmény;
    }
}

