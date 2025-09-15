
namespace _20241118_gyakszi
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
            this.be = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lista_elemei = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.elemek_szama = new System.Windows.Forms.TextBox();
            this.kilép = new System.Windows.Forms.Button();
            this.a_oldal_be = new System.Windows.Forms.TextBox();
            this.b_oldal_be = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Számol = new System.Windows.Forms.Button();
            this.ker_ter_lista = new System.Windows.Forms.ListBox();
            this.adatbe = new System.Windows.Forms.TextBox();
            this.hozzáad = new System.Windows.Forms.Button();
            this.remdez = new System.Windows.Forms.Button();
            this.gyümi_lista = new System.Windows.Forms.ListBox();
            this.karakterszám_lista = new System.Windows.Forms.ListBox();
            this.start = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.szamok = new System.Windows.Forms.ListBox();
            this.eredmeny = new System.Windows.Forms.Button();
            this.paros = new System.Windows.Forms.ListBox();
            this.paratlan = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // be
            // 
            this.be.Location = new System.Drawing.Point(30, 14);
            this.be.Name = "be";
            this.be.Size = new System.Drawing.Size(357, 20);
            this.be.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(320, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 57);
            this.button1.TabIndex = 1;
            this.button1.Text = "Hozzáad";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(320, 102);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(67, 56);
            this.button2.TabIndex = 2;
            this.button2.Text = "Töröl";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(320, 164);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(67, 62);
            this.button3.TabIndex = 3;
            this.button3.Text = "Összes";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lista_elemei
            // 
            this.lista_elemei.FormattingEnabled = true;
            this.lista_elemei.Location = new System.Drawing.Point(30, 40);
            this.lista_elemei.Name = "lista_elemei";
            this.lista_elemei.Size = new System.Drawing.Size(284, 186);
            this.lista_elemei.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Elemek száma:";
            // 
            // elemek_szama
            // 
            this.elemek_szama.Location = new System.Drawing.Point(30, 250);
            this.elemek_szama.Name = "elemek_szama";
            this.elemek_szama.Size = new System.Drawing.Size(357, 20);
            this.elemek_szama.TabIndex = 6;
            // 
            // kilép
            // 
            this.kilép.BackColor = System.Drawing.Color.Red;
            this.kilép.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kilép.ForeColor = System.Drawing.Color.White;
            this.kilép.Location = new System.Drawing.Point(416, 450);
            this.kilép.Name = "kilép";
            this.kilép.Size = new System.Drawing.Size(375, 113);
            this.kilép.TabIndex = 7;
            this.kilép.Text = "X";
            this.kilép.UseVisualStyleBackColor = false;
            this.kilép.Click += new System.EventHandler(this.kilép_Click);
            // 
            // a_oldal_be
            // 
            this.a_oldal_be.Location = new System.Drawing.Point(416, 76);
            this.a_oldal_be.Name = "a_oldal_be";
            this.a_oldal_be.Size = new System.Drawing.Size(185, 20);
            this.a_oldal_be.TabIndex = 8;
            // 
            // b_oldal_be
            // 
            this.b_oldal_be.Location = new System.Drawing.Point(607, 76);
            this.b_oldal_be.Name = "b_oldal_be";
            this.b_oldal_be.Size = new System.Drawing.Size(185, 20);
            this.b_oldal_be.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(489, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "a oldal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(686, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "b oldal";
            // 
            // Számol
            // 
            this.Számol.Location = new System.Drawing.Point(416, 14);
            this.Számol.Name = "Számol";
            this.Számol.Size = new System.Drawing.Size(377, 31);
            this.Számol.TabIndex = 12;
            this.Számol.Text = "Számol";
            this.Számol.UseVisualStyleBackColor = true;
            this.Számol.Click += new System.EventHandler(this.Számol_Click);
            // 
            // ker_ter_lista
            // 
            this.ker_ter_lista.FormattingEnabled = true;
            this.ker_ter_lista.Location = new System.Drawing.Point(416, 102);
            this.ker_ter_lista.Name = "ker_ter_lista";
            this.ker_ter_lista.Size = new System.Drawing.Size(377, 82);
            this.ker_ter_lista.TabIndex = 13;
            // 
            // adatbe
            // 
            this.adatbe.Location = new System.Drawing.Point(416, 241);
            this.adatbe.Name = "adatbe";
            this.adatbe.Size = new System.Drawing.Size(377, 20);
            this.adatbe.TabIndex = 14;
            // 
            // hozzáad
            // 
            this.hozzáad.Location = new System.Drawing.Point(416, 212);
            this.hozzáad.Name = "hozzáad";
            this.hozzáad.Size = new System.Drawing.Size(185, 23);
            this.hozzáad.TabIndex = 15;
            this.hozzáad.Text = "Hozzáad";
            this.hozzáad.UseVisualStyleBackColor = true;
            this.hozzáad.Click += new System.EventHandler(this.hozzáad_Click);
            // 
            // remdez
            // 
            this.remdez.Location = new System.Drawing.Point(607, 212);
            this.remdez.Name = "remdez";
            this.remdez.Size = new System.Drawing.Size(185, 23);
            this.remdez.TabIndex = 16;
            this.remdez.Text = "Rendez";
            this.remdez.UseVisualStyleBackColor = true;
            this.remdez.Click += new System.EventHandler(this.remdez_Click);
            // 
            // gyümi_lista
            // 
            this.gyümi_lista.FormattingEnabled = true;
            this.gyümi_lista.Location = new System.Drawing.Point(416, 267);
            this.gyümi_lista.Name = "gyümi_lista";
            this.gyümi_lista.Size = new System.Drawing.Size(185, 160);
            this.gyümi_lista.TabIndex = 17;
            // 
            // karakterszám_lista
            // 
            this.karakterszám_lista.FormattingEnabled = true;
            this.karakterszám_lista.Location = new System.Drawing.Point(607, 267);
            this.karakterszám_lista.Name = "karakterszám_lista";
            this.karakterszám_lista.Size = new System.Drawing.Size(185, 160);
            this.karakterszám_lista.TabIndex = 18;
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(30, 295);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(357, 23);
            this.start.TabIndex = 19;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 330);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "A számok";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(187, 330);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Párosok";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(323, 330);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Páratlan";
            // 
            // szamok
            // 
            this.szamok.FormattingEnabled = true;
            this.szamok.Location = new System.Drawing.Point(31, 346);
            this.szamok.Name = "szamok";
            this.szamok.Size = new System.Drawing.Size(76, 173);
            this.szamok.TabIndex = 23;
            // 
            // eredmeny
            // 
            this.eredmeny.Location = new System.Drawing.Point(30, 529);
            this.eredmeny.Name = "eredmeny";
            this.eredmeny.Size = new System.Drawing.Size(357, 23);
            this.eredmeny.TabIndex = 24;
            this.eredmeny.Text = "Eredmény";
            this.eredmeny.UseVisualStyleBackColor = true;
            this.eredmeny.Click += new System.EventHandler(this.eredmeny_Click);
            // 
            // paros
            // 
            this.paros.ForeColor = System.Drawing.Color.Red;
            this.paros.FormattingEnabled = true;
            this.paros.Location = new System.Drawing.Point(170, 346);
            this.paros.Name = "paros";
            this.paros.Size = new System.Drawing.Size(76, 173);
            this.paros.TabIndex = 25;
            // 
            // paratlan
            // 
            this.paratlan.ForeColor = System.Drawing.Color.DodgerBlue;
            this.paratlan.FormattingEnabled = true;
            this.paratlan.Location = new System.Drawing.Point(309, 346);
            this.paratlan.Name = "paratlan";
            this.paratlan.Size = new System.Drawing.Size(76, 173);
            this.paratlan.TabIndex = 26;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 575);
            this.Controls.Add(this.paratlan);
            this.Controls.Add(this.paros);
            this.Controls.Add(this.eredmeny);
            this.Controls.Add(this.szamok);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.start);
            this.Controls.Add(this.karakterszám_lista);
            this.Controls.Add(this.gyümi_lista);
            this.Controls.Add(this.remdez);
            this.Controls.Add(this.hozzáad);
            this.Controls.Add(this.adatbe);
            this.Controls.Add(this.ker_ter_lista);
            this.Controls.Add(this.Számol);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.b_oldal_be);
            this.Controls.Add(this.a_oldal_be);
            this.Controls.Add(this.kilép);
            this.Controls.Add(this.elemek_szama);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lista_elemei);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.be);
            this.Name = "Form1";
            this.Text = "ListBox elemei:";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox be;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox lista_elemei;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox elemek_szama;
        private System.Windows.Forms.Button kilép;
        private System.Windows.Forms.TextBox a_oldal_be;
        private System.Windows.Forms.TextBox b_oldal_be;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Számol;
        private System.Windows.Forms.ListBox ker_ter_lista;
        private System.Windows.Forms.TextBox adatbe;
        private System.Windows.Forms.Button hozzáad;
        private System.Windows.Forms.Button remdez;
        private System.Windows.Forms.ListBox gyümi_lista;
        private System.Windows.Forms.ListBox karakterszám_lista;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox szamok;
        private System.Windows.Forms.Button eredmeny;
        private System.Windows.Forms.ListBox paros;
        private System.Windows.Forms.ListBox paratlan;
    }
}

