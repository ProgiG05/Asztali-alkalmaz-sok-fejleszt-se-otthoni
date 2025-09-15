
namespace _20250317_Varosok
{
    partial class Felvitel
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
            this.label1 = new System.Windows.Forms.Label();
            this.ujadatok_lista = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.varos_be = new System.Windows.Forms.TextBox();
            this.orszag_be = new System.Windows.Forms.TextBox();
            this.lakossag_be = new System.Windows.Forms.TextBox();
            this.rekordok_combo = new System.Windows.Forms.ComboBox();
            this.fájlbaírás_check = new System.Windows.Forms.CheckBox();
            this.kiir = new System.Windows.Forms.Button();
            this.hozzaad = new System.Windows.Forms.Button();
            this.vissza = new System.Windows.Forms.Button();
            this.fajlneve_be = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(25, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Az újonnan felvett város adatai:";
            // 
            // ujadatok_lista
            // 
            this.ujadatok_lista.FormattingEnabled = true;
            this.ujadatok_lista.Location = new System.Drawing.Point(25, 52);
            this.ujadatok_lista.Name = "ujadatok_lista";
            this.ujadatok_lista.Size = new System.Drawing.Size(258, 95);
            this.ujadatok_lista.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(25, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Város neve:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(25, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ország:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(25, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Lakosság (millió fő):";
            // 
            // varos_be
            // 
            this.varos_be.Location = new System.Drawing.Point(183, 172);
            this.varos_be.Name = "varos_be";
            this.varos_be.Size = new System.Drawing.Size(100, 20);
            this.varos_be.TabIndex = 5;
            // 
            // orszag_be
            // 
            this.orszag_be.Location = new System.Drawing.Point(183, 212);
            this.orszag_be.Name = "orszag_be";
            this.orszag_be.Size = new System.Drawing.Size(100, 20);
            this.orszag_be.TabIndex = 6;
            // 
            // lakossag_be
            // 
            this.lakossag_be.Location = new System.Drawing.Point(183, 252);
            this.lakossag_be.Name = "lakossag_be";
            this.lakossag_be.Size = new System.Drawing.Size(100, 20);
            this.lakossag_be.TabIndex = 7;
            // 
            // rekordok_combo
            // 
            this.rekordok_combo.FormattingEnabled = true;
            this.rekordok_combo.Location = new System.Drawing.Point(320, 209);
            this.rekordok_combo.Name = "rekordok_combo";
            this.rekordok_combo.Size = new System.Drawing.Size(217, 21);
            this.rekordok_combo.TabIndex = 8;
            this.rekordok_combo.SelectedIndexChanged += new System.EventHandler(this.rekordok_combo_SelectedIndexChanged);
            // 
            // fájlbaírás_check
            // 
            this.fájlbaírás_check.AutoSize = true;
            this.fájlbaírás_check.Location = new System.Drawing.Point(320, 81);
            this.fájlbaírás_check.Name = "fájlbaírás_check";
            this.fájlbaírás_check.Size = new System.Drawing.Size(72, 17);
            this.fájlbaírás_check.TabIndex = 9;
            this.fájlbaírás_check.Text = "Fájlbaírás";
            this.fájlbaírás_check.UseVisualStyleBackColor = true;
            this.fájlbaírás_check.CheckedChanged += new System.EventHandler(this.fájlbaírás_check_CheckedChanged);
            // 
            // kiir
            // 
            this.kiir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.kiir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kiir.ForeColor = System.Drawing.Color.White;
            this.kiir.Location = new System.Drawing.Point(406, 65);
            this.kiir.Name = "kiir";
            this.kiir.Size = new System.Drawing.Size(131, 45);
            this.kiir.TabIndex = 10;
            this.kiir.Text = "Adatok kiírása";
            this.kiir.UseVisualStyleBackColor = false;
            this.kiir.Click += new System.EventHandler(this.kiir_Click);
            // 
            // hozzaad
            // 
            this.hozzaad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.hozzaad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.hozzaad.ForeColor = System.Drawing.Color.White;
            this.hozzaad.Location = new System.Drawing.Point(25, 290);
            this.hozzaad.Name = "hozzaad";
            this.hozzaad.Size = new System.Drawing.Size(258, 40);
            this.hozzaad.TabIndex = 11;
            this.hozzaad.Text = "Hozzáad";
            this.hozzaad.UseVisualStyleBackColor = false;
            this.hozzaad.Click += new System.EventHandler(this.hozzaad_Click);
            // 
            // vissza
            // 
            this.vissza.BackColor = System.Drawing.Color.Black;
            this.vissza.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.vissza.ForeColor = System.Drawing.Color.White;
            this.vissza.Location = new System.Drawing.Point(369, 270);
            this.vissza.Name = "vissza";
            this.vissza.Size = new System.Drawing.Size(109, 45);
            this.vissza.TabIndex = 12;
            this.vissza.Text = "Vissza";
            this.vissza.UseVisualStyleBackColor = false;
            this.vissza.Click += new System.EventHandler(this.vissza_Click);
            // 
            // fajlneve_be
            // 
            this.fajlneve_be.Location = new System.Drawing.Point(320, 126);
            this.fajlneve_be.Name = "fajlneve_be";
            this.fajlneve_be.Size = new System.Drawing.Size(217, 20);
            this.fajlneve_be.TabIndex = 13;
            // 
            // Felvitel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 347);
            this.Controls.Add(this.fajlneve_be);
            this.Controls.Add(this.vissza);
            this.Controls.Add(this.hozzaad);
            this.Controls.Add(this.kiir);
            this.Controls.Add(this.fájlbaírás_check);
            this.Controls.Add(this.rekordok_combo);
            this.Controls.Add(this.lakossag_be);
            this.Controls.Add(this.orszag_be);
            this.Controls.Add(this.varos_be);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ujadatok_lista);
            this.Controls.Add(this.label1);
            this.Name = "Felvitel";
            this.Text = "Felvitel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox ujadatok_lista;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox varos_be;
        private System.Windows.Forms.TextBox orszag_be;
        private System.Windows.Forms.TextBox lakossag_be;
        private System.Windows.Forms.ComboBox rekordok_combo;
        private System.Windows.Forms.CheckBox fájlbaírás_check;
        private System.Windows.Forms.Button kiir;
        private System.Windows.Forms.Button hozzaad;
        private System.Windows.Forms.Button vissza;
        private System.Windows.Forms.TextBox fajlneve_be;
    }
}