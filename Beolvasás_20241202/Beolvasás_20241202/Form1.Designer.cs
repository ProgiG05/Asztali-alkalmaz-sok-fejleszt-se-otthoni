
namespace Beolvasás_20241202
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
            this.forrasfajl_neve = new System.Windows.Forms.TextBox();
            this.betölt_btn = new System.Windows.Forms.Button();
            this.ter_átl_btn = new System.Windows.Forms.Button();
            this.megszamol_btn = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.keres_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.kijelöl = new System.Windows.Forms.CheckBox();
            this.minmax = new System.Windows.Forms.ComboBox();
            this.eredmeny_fajlnev = new System.Windows.Forms.TextBox();
            this.keresettorszag = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nagyobb_radio = new System.Windows.Forms.RadioButton();
            this.legfeljebb_radio = new System.Windows.Forms.RadioButton();
            this.lista = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.kilep_btn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // forrasfajl_neve
            // 
            this.forrasfajl_neve.Location = new System.Drawing.Point(25, 52);
            this.forrasfajl_neve.Name = "forrasfajl_neve";
            this.forrasfajl_neve.Size = new System.Drawing.Size(177, 20);
            this.forrasfajl_neve.TabIndex = 0;
            // 
            // betölt_btn
            // 
            this.betölt_btn.Location = new System.Drawing.Point(25, 92);
            this.betölt_btn.Name = "betölt_btn";
            this.betölt_btn.Size = new System.Drawing.Size(177, 30);
            this.betölt_btn.TabIndex = 1;
            this.betölt_btn.Text = "Adatok betöltése";
            this.betölt_btn.UseVisualStyleBackColor = true;
            this.betölt_btn.Click += new System.EventHandler(this.betölt_btn_Click);
            // 
            // ter_átl_btn
            // 
            this.ter_átl_btn.Location = new System.Drawing.Point(25, 442);
            this.ter_átl_btn.Name = "ter_átl_btn";
            this.ter_átl_btn.Size = new System.Drawing.Size(177, 30);
            this.ter_átl_btn.TabIndex = 2;
            this.ter_átl_btn.Text = "Területek átlaga";
            this.ter_átl_btn.UseVisualStyleBackColor = true;
            this.ter_átl_btn.Click += new System.EventHandler(this.ter_átl_btn_Click);
            // 
            // megszamol_btn
            // 
            this.megszamol_btn.Location = new System.Drawing.Point(239, 134);
            this.megszamol_btn.Name = "megszamol_btn";
            this.megszamol_btn.Size = new System.Drawing.Size(200, 23);
            this.megszamol_btn.TabIndex = 3;
            this.megszamol_btn.Text = "Megszámolás";
            this.megszamol_btn.UseVisualStyleBackColor = true;
            this.megszamol_btn.Click += new System.EventHandler(this.megszamol_btn_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(239, 217);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(200, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Kiírás";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(239, 300);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(200, 23);
            this.button5.TabIndex = 5;
            this.button5.Text = "Minimum/Maximum kiválasztása";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // keres_btn
            // 
            this.keres_btn.Location = new System.Drawing.Point(239, 442);
            this.keres_btn.Name = "keres_btn";
            this.keres_btn.Size = new System.Drawing.Size(200, 30);
            this.keres_btn.TabIndex = 6;
            this.keres_btn.Text = "Keresés";
            this.keres_btn.UseVisualStyleBackColor = true;
            this.keres_btn.Click += new System.EventHandler(this.keres_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Forrásfájl neve:";
            // 
            // kijelöl
            // 
            this.kijelöl.AutoSize = true;
            this.kijelöl.Location = new System.Drawing.Point(239, 401);
            this.kijelöl.Name = "kijelöl";
            this.kijelöl.Size = new System.Drawing.Size(164, 17);
            this.kijelöl.TabIndex = 8;
            this.kijelöl.Text = "Találatok kijelölése a listában";
            this.kijelöl.UseVisualStyleBackColor = true;
            // 
            // minmax
            // 
            this.minmax.FormattingEnabled = true;
            this.minmax.Location = new System.Drawing.Point(239, 273);
            this.minmax.Name = "minmax";
            this.minmax.Size = new System.Drawing.Size(200, 21);
            this.minmax.TabIndex = 9;
            // 
            // eredmeny_fajlnev
            // 
            this.eredmeny_fajlnev.Location = new System.Drawing.Point(239, 191);
            this.eredmeny_fajlnev.Name = "eredmeny_fajlnev";
            this.eredmeny_fajlnev.Size = new System.Drawing.Size(200, 20);
            this.eredmeny_fajlnev.TabIndex = 10;
            // 
            // keresettorszag
            // 
            this.keresettorszag.Location = new System.Drawing.Point(239, 360);
            this.keresettorszag.Name = "keresettorszag";
            this.keresettorszag.Size = new System.Drawing.Size(200, 20);
            this.keresettorszag.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nagyobb_radio);
            this.groupBox1.Controls.Add(this.legfeljebb_radio);
            this.groupBox1.Location = new System.Drawing.Point(239, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 70);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mit számoljunk?";
            // 
            // nagyobb_radio
            // 
            this.nagyobb_radio.AutoSize = true;
            this.nagyobb_radio.Location = new System.Drawing.Point(13, 19);
            this.nagyobb_radio.Name = "nagyobb_radio";
            this.nagyobb_radio.Size = new System.Drawing.Size(186, 17);
            this.nagyobb_radio.TabIndex = 13;
            this.nagyobb_radio.TabStop = true;
            this.nagyobb_radio.Text = "100 000 km2-nél nagyobb területű";
            this.nagyobb_radio.UseVisualStyleBackColor = true;
            // 
            // legfeljebb_radio
            // 
            this.legfeljebb_radio.AutoSize = true;
            this.legfeljebb_radio.Location = new System.Drawing.Point(13, 40);
            this.legfeljebb_radio.Name = "legfeljebb_radio";
            this.legfeljebb_radio.Size = new System.Drawing.Size(173, 17);
            this.legfeljebb_radio.TabIndex = 14;
            this.legfeljebb_radio.TabStop = true;
            this.legfeljebb_radio.Text = "legfeljebb 100 000 km2 területű";
            this.legfeljebb_radio.UseVisualStyleBackColor = true;
            // 
            // lista
            // 
            this.lista.FormattingEnabled = true;
            this.lista.Location = new System.Drawing.Point(25, 134);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(177, 290);
            this.lista.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(236, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Eredmény fájl neve:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(239, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Minimum vagy Maximum ?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(239, 330);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Ország keresése";
            // 
            // kilep_btn
            // 
            this.kilep_btn.Location = new System.Drawing.Point(25, 493);
            this.kilep_btn.Name = "kilep_btn";
            this.kilep_btn.Size = new System.Drawing.Size(424, 23);
            this.kilep_btn.TabIndex = 17;
            this.kilep_btn.Text = "Kilép";
            this.kilep_btn.UseVisualStyleBackColor = true;
            this.kilep_btn.Click += new System.EventHandler(this.kilep_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 534);
            this.Controls.Add(this.kilep_btn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lista);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ter_átl_btn);
            this.Controls.Add(this.keresettorszag);
            this.Controls.Add(this.eredmeny_fajlnev);
            this.Controls.Add(this.minmax);
            this.Controls.Add(this.kijelöl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.keres_btn);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.megszamol_btn);
            this.Controls.Add(this.betölt_btn);
            this.Controls.Add(this.forrasfajl_neve);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox forrasfajl_neve;
        private System.Windows.Forms.Button betölt_btn;
        private System.Windows.Forms.Button ter_átl_btn;
        private System.Windows.Forms.Button megszamol_btn;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button keres_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox kijelöl;
        private System.Windows.Forms.ComboBox minmax;
        private System.Windows.Forms.TextBox eredmeny_fajlnev;
        private System.Windows.Forms.TextBox keresettorszag;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton nagyobb_radio;
        private System.Windows.Forms.RadioButton legfeljebb_radio;
        private System.Windows.Forms.ListBox lista;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button kilep_btn;
    }
}

