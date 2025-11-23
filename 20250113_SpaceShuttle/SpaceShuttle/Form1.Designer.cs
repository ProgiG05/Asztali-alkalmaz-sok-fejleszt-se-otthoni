
namespace SpaceShuttle
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
            this.megnyitas = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.főcím = new System.Windows.Forms.Label();
            this.adatok_lista = new System.Windows.Forms.ListBox();
            this.Megszámlálás = new System.Windows.Forms.GroupBox();
            this.szamlalo = new System.Windows.Forms.TextBox();
            this.max_ot_utas = new System.Windows.Forms.RadioButton();
            this.kuldetesek_szama = new System.Windows.Forms.RadioButton();
            this.utasok_szama = new System.Windows.Forms.RadioButton();
            this.d_feladat_lbl = new System.Windows.Forms.Label();
            this.columbia = new System.Windows.Forms.TextBox();
            this.show = new System.Windows.Forms.Button();
            this.e_feladat_lbl = new System.Windows.Forms.Label();
            this.f_feladat_lbl1 = new System.Windows.Forms.Label();
            this.küld_szam = new System.Windows.Forms.TextBox();
            this.f_feladat_lbl2 = new System.Windows.Forms.Label();
            this.legtöbb_lista = new System.Windows.Forms.ListBox();
            this.nincs = new System.Windows.Forms.TextBox();
            this.év_be = new System.Windows.Forms.TextBox();
            this.százalék = new System.Windows.Forms.TextBox();
            this.g_feladat_lbl3 = new System.Windows.Forms.Label();
            this.fajlneve = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.írás = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.állomásnév_selected = new System.Windows.Forms.ComboBox();
            this.g_feladat_lbl1 = new System.Windows.Forms.Label();
            this.g_feladat_lbl2 = new System.Windows.Forms.Label();
            this.órába = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.kód_show = new System.Windows.Forms.TextBox();
            this.hajónév_show = new System.Windows.Forms.TextBox();
            this.támasznév_show = new System.Windows.Forms.TextBox();
            this.kilövésdátum_show = new System.Windows.Forms.TextBox();
            this.nap_show = new System.Windows.Forms.TextBox();
            this.óra_show = new System.Windows.Forms.TextBox();
            this.legénység_show = new System.Windows.Forms.TextBox();
            this.Megszámlálás.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // megnyitas
            // 
            this.megnyitas.BackColor = System.Drawing.Color.DarkSlateGray;
            this.megnyitas.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.megnyitas.ForeColor = System.Drawing.Color.White;
            this.megnyitas.Location = new System.Drawing.Point(134, 61);
            this.megnyitas.Name = "megnyitas";
            this.megnyitas.Size = new System.Drawing.Size(275, 40);
            this.megnyitas.TabIndex = 0;
            this.megnyitas.Text = "Megnyitás";
            this.megnyitas.UseVisualStyleBackColor = false;
            this.megnyitas.Click += new System.EventHandler(this.megnyitas_Click);
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.Red;
            this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.close.ForeColor = System.Drawing.SystemColors.Control;
            this.close.Location = new System.Drawing.Point(29, 61);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(40, 40);
            this.close.TabIndex = 1;
            this.close.Text = "X";
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // főcím
            // 
            this.főcím.AutoSize = true;
            this.főcím.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.főcím.Location = new System.Drawing.Point(106, 1);
            this.főcím.Name = "főcím";
            this.főcím.Size = new System.Drawing.Size(336, 55);
            this.főcím.TabIndex = 2;
            this.főcím.Text = "Space Shuttle";
            // 
            // adatok_lista
            // 
            this.adatok_lista.BackColor = System.Drawing.Color.MintCream;
            this.adatok_lista.FormattingEnabled = true;
            this.adatok_lista.Location = new System.Drawing.Point(29, 109);
            this.adatok_lista.Name = "adatok_lista";
            this.adatok_lista.Size = new System.Drawing.Size(506, 121);
            this.adatok_lista.TabIndex = 3;
            // 
            // Megszámlálás
            // 
            this.Megszámlálás.Controls.Add(this.szamlalo);
            this.Megszámlálás.Controls.Add(this.max_ot_utas);
            this.Megszámlálás.Controls.Add(this.kuldetesek_szama);
            this.Megszámlálás.Controls.Add(this.utasok_szama);
            this.Megszámlálás.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Megszámlálás.ForeColor = System.Drawing.Color.White;
            this.Megszámlálás.Location = new System.Drawing.Point(29, 236);
            this.Megszámlálás.Name = "Megszámlálás";
            this.Megszámlálás.Size = new System.Drawing.Size(506, 92);
            this.Megszámlálás.TabIndex = 4;
            this.Megszámlálás.TabStop = false;
            this.Megszámlálás.Text = "Megszámlálás";
            // 
            // szamlalo
            // 
            this.szamlalo.Enabled = false;
            this.szamlalo.Location = new System.Drawing.Point(262, 39);
            this.szamlalo.Name = "szamlalo";
            this.szamlalo.ReadOnly = true;
            this.szamlalo.Size = new System.Drawing.Size(144, 22);
            this.szamlalo.TabIndex = 8;
            // 
            // max_ot_utas
            // 
            this.max_ot_utas.AutoSize = true;
            this.max_ot_utas.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.max_ot_utas.Location = new System.Drawing.Point(6, 67);
            this.max_ot_utas.Name = "max_ot_utas";
            this.max_ot_utas.Size = new System.Drawing.Size(226, 17);
            this.max_ot_utas.TabIndex = 7;
            this.max_ot_utas.TabStop = true;
            this.max_ot_utas.Text = "Összes küldetés max 5 utassal";
            this.max_ot_utas.UseVisualStyleBackColor = true;
            this.max_ot_utas.CheckedChanged += new System.EventHandler(this.max_ot_utas_CheckedChanged);
            // 
            // kuldetesek_szama
            // 
            this.kuldetesek_szama.AutoSize = true;
            this.kuldetesek_szama.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kuldetesek_szama.Location = new System.Drawing.Point(6, 21);
            this.kuldetesek_szama.Name = "kuldetesek_szama";
            this.kuldetesek_szama.Size = new System.Drawing.Size(177, 17);
            this.kuldetesek_szama.TabIndex = 5;
            this.kuldetesek_szama.TabStop = true;
            this.kuldetesek_szama.Text = "Összes küldetés száma";
            this.kuldetesek_szama.UseVisualStyleBackColor = true;
            this.kuldetesek_szama.CheckedChanged += new System.EventHandler(this.kuldetesek_szama_CheckedChanged);
            // 
            // utasok_szama
            // 
            this.utasok_szama.AutoSize = true;
            this.utasok_szama.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.utasok_szama.Location = new System.Drawing.Point(6, 44);
            this.utasok_szama.Name = "utasok_szama";
            this.utasok_szama.Size = new System.Drawing.Size(148, 17);
            this.utasok_szama.TabIndex = 6;
            this.utasok_szama.TabStop = true;
            this.utasok_szama.Text = "Összes utas száma";
            this.utasok_szama.UseVisualStyleBackColor = true;
            this.utasok_szama.CheckedChanged += new System.EventHandler(this.utasok_szama_CheckedChanged);
            // 
            // d_feladat_lbl
            // 
            this.d_feladat_lbl.AutoSize = true;
            this.d_feladat_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d_feladat_lbl.ForeColor = System.Drawing.Color.White;
            this.d_feladat_lbl.Location = new System.Drawing.Point(16, 23);
            this.d_feladat_lbl.Name = "d_feladat_lbl";
            this.d_feladat_lbl.Size = new System.Drawing.Size(404, 16);
            this.d_feladat_lbl.TabIndex = 5;
            this.d_feladat_lbl.Text = "A Columbia űrsikló utolsó küldetésének utasainak száma:";
            // 
            // columbia
            // 
            this.columbia.Enabled = false;
            this.columbia.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.columbia.Location = new System.Drawing.Point(435, 21);
            this.columbia.Name = "columbia";
            this.columbia.ReadOnly = true;
            this.columbia.Size = new System.Drawing.Size(60, 22);
            this.columbia.TabIndex = 6;
            this.columbia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // show
            // 
            this.show.BackColor = System.Drawing.Color.DarkSlateGray;
            this.show.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show.ForeColor = System.Drawing.Color.White;
            this.show.Location = new System.Drawing.Point(105, 184);
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(275, 30);
            this.show.TabIndex = 9;
            this.show.Text = "Megoldások";
            this.show.UseVisualStyleBackColor = false;
            this.show.Click += new System.EventHandler(this.show_Click);
            // 
            // e_feladat_lbl
            // 
            this.e_feladat_lbl.AutoSize = true;
            this.e_feladat_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.e_feladat_lbl.ForeColor = System.Drawing.Color.White;
            this.e_feladat_lbl.Location = new System.Drawing.Point(16, 52);
            this.e_feladat_lbl.Name = "e_feladat_lbl";
            this.e_feladat_lbl.Size = new System.Drawing.Size(214, 16);
            this.e_feladat_lbl.TabIndex = 7;
            this.e_feladat_lbl.Text = "A legtöbb időt eltöltött űrsikló:";
            // 
            // f_feladat_lbl1
            // 
            this.f_feladat_lbl1.AutoSize = true;
            this.f_feladat_lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f_feladat_lbl1.ForeColor = System.Drawing.Color.White;
            this.f_feladat_lbl1.Location = new System.Drawing.Point(16, 87);
            this.f_feladat_lbl1.Name = "f_feladat_lbl1";
            this.f_feladat_lbl1.Size = new System.Drawing.Size(133, 16);
            this.f_feladat_lbl1.TabIndex = 10;
            this.f_feladat_lbl1.Text = "Adj meg egy évet:";
            // 
            // küld_szam
            // 
            this.küld_szam.Enabled = false;
            this.küld_szam.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.küld_szam.Location = new System.Drawing.Point(173, 117);
            this.küld_szam.Name = "küld_szam";
            this.küld_szam.ReadOnly = true;
            this.küld_szam.Size = new System.Drawing.Size(69, 22);
            this.küld_szam.TabIndex = 12;
            this.küld_szam.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // f_feladat_lbl2
            // 
            this.f_feladat_lbl2.AutoSize = true;
            this.f_feladat_lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f_feladat_lbl2.ForeColor = System.Drawing.Color.White;
            this.f_feladat_lbl2.Location = new System.Drawing.Point(16, 120);
            this.f_feladat_lbl2.Name = "f_feladat_lbl2";
            this.f_feladat_lbl2.Size = new System.Drawing.Size(138, 16);
            this.f_feladat_lbl2.TabIndex = 13;
            this.f_feladat_lbl2.Text = "Küldetések száma:";
            // 
            // legtöbb_lista
            // 
            this.legtöbb_lista.Enabled = false;
            this.legtöbb_lista.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.legtöbb_lista.FormattingEnabled = true;
            this.legtöbb_lista.ItemHeight = 15;
            this.legtöbb_lista.Location = new System.Drawing.Point(261, 52);
            this.legtöbb_lista.Name = "legtöbb_lista";
            this.legtöbb_lista.Size = new System.Drawing.Size(233, 49);
            this.legtöbb_lista.TabIndex = 14;
            // 
            // nincs
            // 
            this.nincs.Enabled = false;
            this.nincs.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nincs.Location = new System.Drawing.Point(262, 117);
            this.nincs.Name = "nincs";
            this.nincs.ReadOnly = true;
            this.nincs.Size = new System.Drawing.Size(233, 20);
            this.nincs.TabIndex = 15;
            // 
            // év_be
            // 
            this.év_be.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.év_be.Location = new System.Drawing.Point(173, 84);
            this.év_be.Name = "év_be";
            this.év_be.Size = new System.Drawing.Size(69, 22);
            this.év_be.TabIndex = 17;
            // 
            // százalék
            // 
            this.százalék.Enabled = false;
            this.százalék.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.százalék.Location = new System.Drawing.Point(434, 155);
            this.százalék.Name = "százalék";
            this.százalék.Size = new System.Drawing.Size(37, 20);
            this.százalék.TabIndex = 19;
            this.százalék.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // g_feladat_lbl3
            // 
            this.g_feladat_lbl3.AutoSize = true;
            this.g_feladat_lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.g_feladat_lbl3.ForeColor = System.Drawing.Color.White;
            this.g_feladat_lbl3.Location = new System.Drawing.Point(473, 157);
            this.g_feladat_lbl3.Name = "g_feladat_lbl3";
            this.g_feladat_lbl3.Size = new System.Drawing.Size(21, 16);
            this.g_feladat_lbl3.TabIndex = 20;
            this.g_feladat_lbl3.Text = "%";
            // 
            // fajlneve
            // 
            this.fajlneve.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fajlneve.Location = new System.Drawing.Point(178, 55);
            this.fajlneve.Name = "fajlneve";
            this.fajlneve.Size = new System.Drawing.Size(196, 22);
            this.fajlneve.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(13, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(270, 16);
            this.label8.TabIndex = 24;
            this.label8.Text = "Űrsiklók neve + űrbeli idejük (napban)";
            // 
            // írás
            // 
            this.írás.BackColor = System.Drawing.Color.DarkSlateGray;
            this.írás.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.írás.ForeColor = System.Drawing.Color.White;
            this.írás.Location = new System.Drawing.Point(383, 50);
            this.írás.Name = "írás";
            this.írás.Size = new System.Drawing.Size(111, 33);
            this.írás.TabIndex = 25;
            this.írás.Text = "Írás";
            this.írás.UseVisualStyleBackColor = false;
            this.írás.Click += new System.EventHandler(this.írás_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(13, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 30);
            this.label7.TabIndex = 26;
            this.label7.Text = "Adj meg egy fájlnevet:\r\n\r\n";
            // 
            // állomásnév_selected
            // 
            this.állomásnév_selected.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.állomásnév_selected.FormattingEnabled = true;
            this.állomásnév_selected.Location = new System.Drawing.Point(66, 154);
            this.állomásnév_selected.Name = "állomásnév_selected";
            this.állomásnév_selected.Size = new System.Drawing.Size(121, 23);
            this.állomásnév_selected.TabIndex = 27;
            // 
            // g_feladat_lbl1
            // 
            this.g_feladat_lbl1.AutoSize = true;
            this.g_feladat_lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.g_feladat_lbl1.ForeColor = System.Drawing.Color.White;
            this.g_feladat_lbl1.Location = new System.Drawing.Point(16, 157);
            this.g_feladat_lbl1.Name = "g_feladat_lbl1";
            this.g_feladat_lbl1.Size = new System.Drawing.Size(35, 16);
            this.g_feladat_lbl1.TabIndex = 28;
            this.g_feladat_lbl1.Text = "A(z)";
            // 
            // g_feladat_lbl2
            // 
            this.g_feladat_lbl2.AutoSize = true;
            this.g_feladat_lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.g_feladat_lbl2.ForeColor = System.Drawing.Color.White;
            this.g_feladat_lbl2.Location = new System.Drawing.Point(200, 157);
            this.g_feladat_lbl2.Name = "g_feladat_lbl2";
            this.g_feladat_lbl2.Size = new System.Drawing.Size(232, 16);
            this.g_feladat_lbl2.TabIndex = 29;
            this.g_feladat_lbl2.Text = "támaszponton történt landolások";
            // 
            // órába
            // 
            this.órába.AutoSize = true;
            this.órába.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.órába.ForeColor = System.Drawing.Color.White;
            this.órába.Location = new System.Drawing.Point(283, 27);
            this.órába.Name = "órába";
            this.órába.Size = new System.Drawing.Size(217, 20);
            this.órába.TabIndex = 35;
            this.órába.Text = "Órába átváltva hozzáadása";
            this.órába.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.d_feladat_lbl);
            this.groupBox1.Controls.Add(this.columbia);
            this.groupBox1.Controls.Add(this.g_feladat_lbl2);
            this.groupBox1.Controls.Add(this.e_feladat_lbl);
            this.groupBox1.Controls.Add(this.g_feladat_lbl1);
            this.groupBox1.Controls.Add(this.f_feladat_lbl1);
            this.groupBox1.Controls.Add(this.show);
            this.groupBox1.Controls.Add(this.állomásnév_selected);
            this.groupBox1.Controls.Add(this.küld_szam);
            this.groupBox1.Controls.Add(this.f_feladat_lbl2);
            this.groupBox1.Controls.Add(this.legtöbb_lista);
            this.groupBox1.Controls.Add(this.nincs);
            this.groupBox1.Controls.Add(this.év_be);
            this.groupBox1.Controls.Add(this.g_feladat_lbl3);
            this.groupBox1.Controls.Add(this.százalék);
            this.groupBox1.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(29, 343);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(506, 228);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lekérdezések";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.órába);
            this.groupBox2.Controls.Add(this.fajlneve);
            this.groupBox2.Controls.Add(this.írás);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(29, 586);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(506, 97);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fájlbaírás";
            // 
            // kód_show
            // 
            this.kód_show.Location = new System.Drawing.Point(576, 109);
            this.kód_show.Name = "kód_show";
            this.kód_show.Size = new System.Drawing.Size(164, 20);
            this.kód_show.TabIndex = 10;
            // 
            // hajónév_show
            // 
            this.hajónév_show.Location = new System.Drawing.Point(576, 135);
            this.hajónév_show.Name = "hajónév_show";
            this.hajónév_show.Size = new System.Drawing.Size(164, 20);
            this.hajónév_show.TabIndex = 11;
            // 
            // támasznév_show
            // 
            this.támasznév_show.Location = new System.Drawing.Point(576, 161);
            this.támasznév_show.Name = "támasznév_show";
            this.támasznév_show.Size = new System.Drawing.Size(164, 20);
            this.támasznév_show.TabIndex = 12;
            // 
            // kilövésdátum_show
            // 
            this.kilövésdátum_show.Location = new System.Drawing.Point(576, 187);
            this.kilövésdátum_show.Name = "kilövésdátum_show";
            this.kilövésdátum_show.Size = new System.Drawing.Size(164, 20);
            this.kilövésdátum_show.TabIndex = 13;
            // 
            // nap_show
            // 
            this.nap_show.Location = new System.Drawing.Point(576, 213);
            this.nap_show.Name = "nap_show";
            this.nap_show.Size = new System.Drawing.Size(51, 20);
            this.nap_show.TabIndex = 14;
            // 
            // óra_show
            // 
            this.óra_show.Location = new System.Drawing.Point(633, 213);
            this.óra_show.Name = "óra_show";
            this.óra_show.Size = new System.Drawing.Size(51, 20);
            this.óra_show.TabIndex = 15;
            // 
            // legénység_show
            // 
            this.legénység_show.Location = new System.Drawing.Point(689, 213);
            this.legénység_show.Name = "legénység_show";
            this.legénység_show.Size = new System.Drawing.Size(51, 20);
            this.legénység_show.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(783, 706);
            this.Controls.Add(this.legénység_show);
            this.Controls.Add(this.óra_show);
            this.Controls.Add(this.nap_show);
            this.Controls.Add(this.kilövésdátum_show);
            this.Controls.Add(this.támasznév_show);
            this.Controls.Add(this.hajónév_show);
            this.Controls.Add(this.kód_show);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Megszámlálás);
            this.Controls.Add(this.adatok_lista);
            this.Controls.Add(this.főcím);
            this.Controls.Add(this.close);
            this.Controls.Add(this.megnyitas);
            this.Name = "Form1";
            this.Text = "SpaceShuttle";
            this.Megszámlálás.ResumeLayout(false);
            this.Megszámlálás.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button megnyitas;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Label főcím;
        private System.Windows.Forms.ListBox adatok_lista;
        private System.Windows.Forms.GroupBox Megszámlálás;
        private System.Windows.Forms.TextBox szamlalo;
        private System.Windows.Forms.RadioButton max_ot_utas;
        private System.Windows.Forms.RadioButton kuldetesek_szama;
        private System.Windows.Forms.RadioButton utasok_szama;
        private System.Windows.Forms.Label d_feladat_lbl;
        private System.Windows.Forms.TextBox columbia;
        private System.Windows.Forms.Button show;
        private System.Windows.Forms.Label e_feladat_lbl;
        private System.Windows.Forms.Label f_feladat_lbl1;
        private System.Windows.Forms.TextBox küld_szam;
        private System.Windows.Forms.Label f_feladat_lbl2;
        private System.Windows.Forms.ListBox legtöbb_lista;
        private System.Windows.Forms.TextBox nincs;
        private System.Windows.Forms.TextBox év_be;
        private System.Windows.Forms.TextBox százalék;
        private System.Windows.Forms.Label g_feladat_lbl3;
        private System.Windows.Forms.TextBox fajlneve;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button írás;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox állomásnév_selected;
        private System.Windows.Forms.Label g_feladat_lbl1;
        private System.Windows.Forms.Label g_feladat_lbl2;
        private System.Windows.Forms.CheckBox órába;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox kód_show;
        private System.Windows.Forms.TextBox hajónév_show;
        private System.Windows.Forms.TextBox támasznév_show;
        private System.Windows.Forms.TextBox kilövésdátum_show;
        private System.Windows.Forms.TextBox nap_show;
        private System.Windows.Forms.TextBox óra_show;
        private System.Windows.Forms.TextBox legénység_show;
    }
}

