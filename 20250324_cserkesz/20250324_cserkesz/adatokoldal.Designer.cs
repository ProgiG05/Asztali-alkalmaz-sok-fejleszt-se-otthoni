
namespace _20250324_cserkesz
{
    partial class adatokoldal
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
            this.cserkeszek_lista = new System.Windows.Forms.ListBox();
            this.beolvas_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.aziúj = new System.Windows.Forms.TextBox();
            this.szamitott_tagdíj = new System.Windows.Forms.TextBox();
            this.szülúj = new System.Windows.Forms.TextBox();
            this.nevúj = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Felvétel = new System.Windows.Forms.GroupBox();
            this.felvetel_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cserkeszek_lista
            // 
            this.cserkeszek_lista.FormattingEnabled = true;
            this.cserkeszek_lista.Location = new System.Drawing.Point(25, 12);
            this.cserkeszek_lista.Name = "cserkeszek_lista";
            this.cserkeszek_lista.Size = new System.Drawing.Size(430, 160);
            this.cserkeszek_lista.TabIndex = 0;
            this.cserkeszek_lista.SelectedIndexChanged += new System.EventHandler(this.cserkeszek_lista_SelectedIndexChanged);
            // 
            // beolvas_btn
            // 
            this.beolvas_btn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.beolvas_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.beolvas_btn.ForeColor = System.Drawing.Color.MidnightBlue;
            this.beolvas_btn.Location = new System.Drawing.Point(80, 188);
            this.beolvas_btn.Name = "beolvas_btn";
            this.beolvas_btn.Size = new System.Drawing.Size(325, 40);
            this.beolvas_btn.TabIndex = 1;
            this.beolvas_btn.Text = "ADATOK BEOLVASÁSA";
            this.beolvas_btn.UseVisualStyleBackColor = false;
            this.beolvas_btn.Click += new System.EventHandler(this.beolvas_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Lavender;
            this.label1.Location = new System.Drawing.Point(38, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(405, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "############################################";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.Lavender;
            this.label2.Location = new System.Drawing.Point(124, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Új cserkész felvétele:";
            // 
            // aziúj
            // 
            this.aziúj.Location = new System.Drawing.Point(295, 323);
            this.aziúj.Name = "aziúj";
            this.aziúj.Size = new System.Drawing.Size(142, 20);
            this.aziúj.TabIndex = 4;
            // 
            // szamitott_tagdíj
            // 
            this.szamitott_tagdíj.Enabled = false;
            this.szamitott_tagdíj.Location = new System.Drawing.Point(295, 425);
            this.szamitott_tagdíj.Name = "szamitott_tagdíj";
            this.szamitott_tagdíj.Size = new System.Drawing.Size(142, 20);
            this.szamitott_tagdíj.TabIndex = 5;
            // 
            // szülúj
            // 
            this.szülúj.Location = new System.Drawing.Point(295, 388);
            this.szülúj.Name = "szülúj";
            this.szülúj.Size = new System.Drawing.Size(142, 20);
            this.szülúj.TabIndex = 6;
            // 
            // nevúj
            // 
            this.nevúj.Location = new System.Drawing.Point(295, 357);
            this.nevúj.Name = "nevúj";
            this.nevúj.Size = new System.Drawing.Size(142, 20);
            this.nevúj.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.Lavender;
            this.label3.Location = new System.Drawing.Point(32, 324);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Új cserkész azonosítója:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.Lavender;
            this.label4.Location = new System.Drawing.Point(32, 356);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Új cserkész neve:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.Lavender;
            this.label5.Location = new System.Drawing.Point(34, 424);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(245, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Új cserkész számított tagdíja:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.Lavender;
            this.label6.Location = new System.Drawing.Point(32, 389);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(248, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Új cserkész születési dátuma:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.Color.Lavender;
            this.label7.Location = new System.Drawing.Point(38, 522);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(405, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "############################################";
            // 
            // Felvétel
            // 
            this.Felvétel.BackColor = System.Drawing.Color.MidnightBlue;
            this.Felvétel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Felvétel.ForeColor = System.Drawing.Color.Lavender;
            this.Felvétel.Location = new System.Drawing.Point(25, 300);
            this.Felvétel.Name = "Felvétel";
            this.Felvétel.Size = new System.Drawing.Size(443, 161);
            this.Felvétel.TabIndex = 13;
            this.Felvétel.TabStop = false;
            this.Felvétel.Text = "Felvétel";
            // 
            // felvetel_btn
            // 
            this.felvetel_btn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.felvetel_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.felvetel_btn.ForeColor = System.Drawing.Color.MidnightBlue;
            this.felvetel_btn.Location = new System.Drawing.Point(80, 471);
            this.felvetel_btn.Name = "felvetel_btn";
            this.felvetel_btn.Size = new System.Drawing.Size(325, 40);
            this.felvetel_btn.TabIndex = 14;
            this.felvetel_btn.Text = "FELVÉTEL";
            this.felvetel_btn.UseVisualStyleBackColor = false;
            this.felvetel_btn.Click += new System.EventHandler(this.felvetel_btn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button1.Location = new System.Drawing.Point(275, 562);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 40);
            this.button1.TabIndex = 15;
            this.button1.Text = "TOVÁBB";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button2.Location = new System.Drawing.Point(42, 562);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(168, 40);
            this.button2.TabIndex = 16;
            this.button2.Text = "VISSZA";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // adatokoldal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(484, 614);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.felvetel_btn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nevúj);
            this.Controls.Add(this.szülúj);
            this.Controls.Add(this.szamitott_tagdíj);
            this.Controls.Add(this.aziúj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.beolvas_btn);
            this.Controls.Add(this.cserkeszek_lista);
            this.Controls.Add(this.Felvétel);
            this.Name = "adatokoldal";
            this.Text = "adatokoldal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox cserkeszek_lista;
        private System.Windows.Forms.Button beolvas_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox aziúj;
        private System.Windows.Forms.TextBox szamitott_tagdíj;
        private System.Windows.Forms.TextBox szülúj;
        private System.Windows.Forms.TextBox nevúj;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox Felvétel;
        private System.Windows.Forms.Button felvetel_btn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}