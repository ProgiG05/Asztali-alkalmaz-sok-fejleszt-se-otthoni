
namespace Pizza_20241021
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.főcím = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.szamolas = new System.Windows.Forms.Button();
            this.töröl = new System.Windows.Forms.Button();
            this.kilép = new System.Windows.Forms.Button();
            this.vega = new System.Windows.Forms.CheckBox();
            this.magyar = new System.Windows.Forms.CheckBox();
            this.negysajt = new System.Windows.Forms.CheckBox();
            this.sonkagomba = new System.Windows.Forms.CheckBox();
            this.lbl_kicsi = new System.Windows.Forms.Label();
            this.lbl_nagy = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.vega_kicsi = new System.Windows.Forms.RadioButton();
            this.magyar_kicsi = new System.Windows.Forms.RadioButton();
            this.negysajt_kicsi = new System.Windows.Forms.RadioButton();
            this.sonkagomba_kicsi = new System.Windows.Forms.RadioButton();
            this.vega_nagy = new System.Windows.Forms.RadioButton();
            this.magyar_nagy = new System.Windows.Forms.RadioButton();
            this.negysajt_nagy = new System.Windows.Forms.RadioButton();
            this.sonkagomba_nagy = new System.Windows.Forms.RadioButton();
            this.lbl_fizet = new System.Windows.Forms.Label();
            this.fizetendo_txt = new System.Windows.Forms.TextBox();
            this.össz_mennyiség = new System.Windows.Forms.TextBox();
            this.vega_group = new System.Windows.Forms.GroupBox();
            this.magyar_group = new System.Windows.Forms.GroupBox();
            this.négysajt_group = new System.Windows.Forms.GroupBox();
            this.sonkagomba_group = new System.Windows.Forms.GroupBox();
            this.ft = new System.Windows.Forms.Label();
            this.fajták = new System.Windows.Forms.GroupBox();
            this.vega_txt = new System.Windows.Forms.NumericUpDown();
            this.negysajt_txt = new System.Windows.Forms.NumericUpDown();
            this.sonkagomba_txt = new System.Windows.Forms.NumericUpDown();
            this.magyar_txt = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.vega_group.SuspendLayout();
            this.magyar_group.SuspendLayout();
            this.négysajt_group.SuspendLayout();
            this.sonkagomba_group.SuspendLayout();
            this.fajták.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vega_txt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.negysajt_txt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sonkagomba_txt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.magyar_txt)).BeginInit();
            this.SuspendLayout();
            // 
            // főcím
            // 
            this.főcím.AutoSize = true;
            this.főcím.Font = new System.Drawing.Font("Lucida Calligraphy", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.főcím.Location = new System.Drawing.Point(365, 9);
            this.főcím.Name = "főcím";
            this.főcím.Size = new System.Drawing.Size(327, 36);
            this.főcím.TabIndex = 0;
            this.főcím.Text = "MENÜVÁLASZTÉK";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 213);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // szamolas
            // 
            this.szamolas.BackColor = System.Drawing.Color.Red;
            this.szamolas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.szamolas.ForeColor = System.Drawing.Color.White;
            this.szamolas.Location = new System.Drawing.Point(12, 260);
            this.szamolas.Name = "szamolas";
            this.szamolas.Size = new System.Drawing.Size(70, 100);
            this.szamolas.TabIndex = 2;
            this.szamolas.Text = "SZÁMOL";
            this.szamolas.UseVisualStyleBackColor = false;
            this.szamolas.Click += new System.EventHandler(this.szamolas_Click);
            // 
            // töröl
            // 
            this.töröl.BackColor = System.Drawing.Color.White;
            this.töröl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.töröl.Location = new System.Drawing.Point(88, 260);
            this.töröl.Name = "töröl";
            this.töröl.Size = new System.Drawing.Size(70, 100);
            this.töröl.TabIndex = 3;
            this.töröl.Text = "TÖRÖL";
            this.töröl.UseVisualStyleBackColor = false;
            this.töröl.Click += new System.EventHandler(this.töröl_Click);
            // 
            // kilép
            // 
            this.kilép.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.kilép.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kilép.ForeColor = System.Drawing.Color.White;
            this.kilép.Location = new System.Drawing.Point(164, 260);
            this.kilép.Name = "kilép";
            this.kilép.Size = new System.Drawing.Size(70, 100);
            this.kilép.TabIndex = 4;
            this.kilép.Text = "KILÉP";
            this.kilép.UseVisualStyleBackColor = false;
            this.kilép.Click += new System.EventHandler(this.kilép_Click);
            // 
            // vega
            // 
            this.vega.AutoSize = true;
            this.vega.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vega.Location = new System.Drawing.Point(6, 19);
            this.vega.Name = "vega";
            this.vega.Size = new System.Drawing.Size(121, 21);
            this.vega.TabIndex = 5;
            this.vega.Text = "Vegetáriánus";
            this.vega.UseVisualStyleBackColor = true;
            this.vega.CheckStateChanged += new System.EventHandler(this.vega_CheckStateChanged);
            // 
            // magyar
            // 
            this.magyar.AutoSize = true;
            this.magyar.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.magyar.Location = new System.Drawing.Point(6, 62);
            this.magyar.Name = "magyar";
            this.magyar.Size = new System.Drawing.Size(98, 21);
            this.magyar.TabIndex = 6;
            this.magyar.Text = "Magyaros";
            this.magyar.UseVisualStyleBackColor = true;
            this.magyar.CheckStateChanged += new System.EventHandler(this.magyar_CheckStateChanged);
            // 
            // negysajt
            // 
            this.negysajt.AutoSize = true;
            this.negysajt.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.negysajt.Location = new System.Drawing.Point(6, 105);
            this.negysajt.Name = "negysajt";
            this.negysajt.Size = new System.Drawing.Size(103, 21);
            this.negysajt.TabIndex = 7;
            this.negysajt.Text = "Négysajtos";
            this.negysajt.UseVisualStyleBackColor = true;
            this.negysajt.CheckStateChanged += new System.EventHandler(this.negysajt_CheckStateChanged);
            // 
            // sonkagomba
            // 
            this.sonkagomba.AutoSize = true;
            this.sonkagomba.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sonkagomba.Location = new System.Drawing.Point(6, 149);
            this.sonkagomba.Name = "sonkagomba";
            this.sonkagomba.Size = new System.Drawing.Size(133, 21);
            this.sonkagomba.TabIndex = 8;
            this.sonkagomba.Text = "Sonkás-Gombás";
            this.sonkagomba.UseVisualStyleBackColor = true;
            this.sonkagomba.CheckStateChanged += new System.EventHandler(this.sonkagomba_CheckStateChanged);
            // 
            // lbl_kicsi
            // 
            this.lbl_kicsi.AutoSize = true;
            this.lbl_kicsi.Font = new System.Drawing.Font("Lucida Calligraphy", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_kicsi.Location = new System.Drawing.Point(427, 62);
            this.lbl_kicsi.Name = "lbl_kicsi";
            this.lbl_kicsi.Size = new System.Drawing.Size(87, 15);
            this.lbl_kicsi.TabIndex = 9;
            this.lbl_kicsi.Text = "Kicsi ( 30 cm)";
            // 
            // lbl_nagy
            // 
            this.lbl_nagy.AutoSize = true;
            this.lbl_nagy.Font = new System.Drawing.Font("Lucida Calligraphy", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nagy.Location = new System.Drawing.Point(543, 62);
            this.lbl_nagy.Name = "lbl_nagy";
            this.lbl_nagy.Size = new System.Drawing.Size(90, 15);
            this.lbl_nagy.TabIndex = 10;
            this.lbl_nagy.Text = "Nagy ( 45 cm)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Calligraphy", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(654, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Mennyiség (db)";
            // 
            // vega_kicsi
            // 
            this.vega_kicsi.AutoSize = true;
            this.vega_kicsi.Location = new System.Drawing.Point(6, 19);
            this.vega_kicsi.Name = "vega_kicsi";
            this.vega_kicsi.Size = new System.Drawing.Size(61, 17);
            this.vega_kicsi.TabIndex = 12;
            this.vega_kicsi.TabStop = true;
            this.vega_kicsi.Text = "2690 Ft";
            this.vega_kicsi.UseVisualStyleBackColor = true;
            // 
            // magyar_kicsi
            // 
            this.magyar_kicsi.AutoSize = true;
            this.magyar_kicsi.Location = new System.Drawing.Point(5, 19);
            this.magyar_kicsi.Name = "magyar_kicsi";
            this.magyar_kicsi.Size = new System.Drawing.Size(61, 17);
            this.magyar_kicsi.TabIndex = 13;
            this.magyar_kicsi.TabStop = true;
            this.magyar_kicsi.Text = "2895 Ft";
            this.magyar_kicsi.UseVisualStyleBackColor = true;
            // 
            // negysajt_kicsi
            // 
            this.negysajt_kicsi.AutoSize = true;
            this.negysajt_kicsi.Location = new System.Drawing.Point(6, 18);
            this.negysajt_kicsi.Name = "negysajt_kicsi";
            this.negysajt_kicsi.Size = new System.Drawing.Size(61, 17);
            this.negysajt_kicsi.TabIndex = 14;
            this.negysajt_kicsi.TabStop = true;
            this.negysajt_kicsi.Text = "2790 Ft";
            this.negysajt_kicsi.UseVisualStyleBackColor = true;
            // 
            // sonkagomba_kicsi
            // 
            this.sonkagomba_kicsi.AutoSize = true;
            this.sonkagomba_kicsi.Location = new System.Drawing.Point(6, 19);
            this.sonkagomba_kicsi.Name = "sonkagomba_kicsi";
            this.sonkagomba_kicsi.Size = new System.Drawing.Size(61, 17);
            this.sonkagomba_kicsi.TabIndex = 15;
            this.sonkagomba_kicsi.TabStop = true;
            this.sonkagomba_kicsi.Text = "2540 Ft";
            this.sonkagomba_kicsi.UseVisualStyleBackColor = true;
            // 
            // vega_nagy
            // 
            this.vega_nagy.AutoSize = true;
            this.vega_nagy.Location = new System.Drawing.Point(124, 19);
            this.vega_nagy.Name = "vega_nagy";
            this.vega_nagy.Size = new System.Drawing.Size(61, 17);
            this.vega_nagy.TabIndex = 16;
            this.vega_nagy.TabStop = true;
            this.vega_nagy.Text = "3650 Ft";
            this.vega_nagy.UseVisualStyleBackColor = true;
            // 
            // magyar_nagy
            // 
            this.magyar_nagy.AutoSize = true;
            this.magyar_nagy.Location = new System.Drawing.Point(124, 19);
            this.magyar_nagy.Name = "magyar_nagy";
            this.magyar_nagy.Size = new System.Drawing.Size(61, 17);
            this.magyar_nagy.TabIndex = 17;
            this.magyar_nagy.TabStop = true;
            this.magyar_nagy.Text = "4890 Ft";
            this.magyar_nagy.UseVisualStyleBackColor = true;
            // 
            // negysajt_nagy
            // 
            this.negysajt_nagy.AutoSize = true;
            this.negysajt_nagy.Location = new System.Drawing.Point(124, 18);
            this.negysajt_nagy.Name = "negysajt_nagy";
            this.negysajt_nagy.Size = new System.Drawing.Size(61, 17);
            this.negysajt_nagy.TabIndex = 18;
            this.negysajt_nagy.TabStop = true;
            this.negysajt_nagy.Text = "4790 Ft";
            this.negysajt_nagy.UseVisualStyleBackColor = true;
            // 
            // sonkagomba_nagy
            // 
            this.sonkagomba_nagy.AutoSize = true;
            this.sonkagomba_nagy.Location = new System.Drawing.Point(124, 19);
            this.sonkagomba_nagy.Name = "sonkagomba_nagy";
            this.sonkagomba_nagy.Size = new System.Drawing.Size(61, 17);
            this.sonkagomba_nagy.TabIndex = 19;
            this.sonkagomba_nagy.TabStop = true;
            this.sonkagomba_nagy.Text = "3990 Ft";
            this.sonkagomba_nagy.UseVisualStyleBackColor = true;
            // 
            // lbl_fizet
            // 
            this.lbl_fizet.AutoSize = true;
            this.lbl_fizet.Font = new System.Drawing.Font("Rockwell", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_fizet.Location = new System.Drawing.Point(318, 301);
            this.lbl_fizet.Name = "lbl_fizet";
            this.lbl_fizet.Size = new System.Drawing.Size(74, 18);
            this.lbl_fizet.TabIndex = 24;
            this.lbl_fizet.Text = "Fizetendő: ";
            // 
            // fizetendo_txt
            // 
            this.fizetendo_txt.Location = new System.Drawing.Point(407, 300);
            this.fizetendo_txt.Name = "fizetendo_txt";
            this.fizetendo_txt.ReadOnly = true;
            this.fizetendo_txt.Size = new System.Drawing.Size(204, 20);
            this.fizetendo_txt.TabIndex = 25;
            this.fizetendo_txt.Text = "0";
            this.fizetendo_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // össz_mennyiség
            // 
            this.össz_mennyiség.Enabled = false;
            this.össz_mennyiség.Location = new System.Drawing.Point(671, 299);
            this.össz_mennyiség.Name = "össz_mennyiség";
            this.össz_mennyiség.Size = new System.Drawing.Size(64, 20);
            this.össz_mennyiség.TabIndex = 26;
            this.össz_mennyiség.Text = "0";
            this.össz_mennyiség.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // vega_group
            // 
            this.vega_group.Controls.Add(this.vega_kicsi);
            this.vega_group.Controls.Add(this.vega_nagy);
            this.vega_group.Location = new System.Drawing.Point(414, 100);
            this.vega_group.Name = "vega_group";
            this.vega_group.Size = new System.Drawing.Size(245, 50);
            this.vega_group.TabIndex = 27;
            this.vega_group.TabStop = false;
            // 
            // magyar_group
            // 
            this.magyar_group.Controls.Add(this.magyar_kicsi);
            this.magyar_group.Controls.Add(this.magyar_nagy);
            this.magyar_group.Location = new System.Drawing.Point(414, 142);
            this.magyar_group.Name = "magyar_group";
            this.magyar_group.Size = new System.Drawing.Size(245, 50);
            this.magyar_group.TabIndex = 28;
            this.magyar_group.TabStop = false;
            // 
            // négysajt_group
            // 
            this.négysajt_group.Controls.Add(this.negysajt_kicsi);
            this.négysajt_group.Controls.Add(this.negysajt_nagy);
            this.négysajt_group.Location = new System.Drawing.Point(414, 186);
            this.négysajt_group.Name = "négysajt_group";
            this.négysajt_group.Size = new System.Drawing.Size(245, 50);
            this.négysajt_group.TabIndex = 30;
            this.négysajt_group.TabStop = false;
            // 
            // sonkagomba_group
            // 
            this.sonkagomba_group.Controls.Add(this.sonkagomba_kicsi);
            this.sonkagomba_group.Controls.Add(this.sonkagomba_nagy);
            this.sonkagomba_group.Location = new System.Drawing.Point(414, 227);
            this.sonkagomba_group.Name = "sonkagomba_group";
            this.sonkagomba_group.Size = new System.Drawing.Size(245, 50);
            this.sonkagomba_group.TabIndex = 31;
            this.sonkagomba_group.TabStop = false;
            // 
            // ft
            // 
            this.ft.AutoSize = true;
            this.ft.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ft.Location = new System.Drawing.Point(617, 304);
            this.ft.Name = "ft";
            this.ft.Size = new System.Drawing.Size(19, 16);
            this.ft.TabIndex = 32;
            this.ft.Text = "Ft";
            // 
            // fajták
            // 
            this.fajták.Controls.Add(this.vega);
            this.fajták.Controls.Add(this.magyar);
            this.fajták.Controls.Add(this.negysajt);
            this.fajták.Controls.Add(this.sonkagomba);
            this.fajták.Location = new System.Drawing.Point(263, 100);
            this.fajták.Name = "fajták";
            this.fajták.Size = new System.Drawing.Size(145, 179);
            this.fajták.TabIndex = 33;
            this.fajták.TabStop = false;
            // 
            // vega_txt
            // 
            this.vega_txt.Location = new System.Drawing.Point(671, 116);
            this.vega_txt.Name = "vega_txt";
            this.vega_txt.Size = new System.Drawing.Size(75, 20);
            this.vega_txt.TabIndex = 34;
            this.vega_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // negysajt_txt
            // 
            this.negysajt_txt.Location = new System.Drawing.Point(671, 201);
            this.negysajt_txt.Name = "negysajt_txt";
            this.negysajt_txt.Size = new System.Drawing.Size(75, 20);
            this.negysajt_txt.TabIndex = 35;
            this.negysajt_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // sonkagomba_txt
            // 
            this.sonkagomba_txt.Location = new System.Drawing.Point(671, 243);
            this.sonkagomba_txt.Name = "sonkagomba_txt";
            this.sonkagomba_txt.Size = new System.Drawing.Size(75, 20);
            this.sonkagomba_txt.TabIndex = 36;
            this.sonkagomba_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // magyar_txt
            // 
            this.magyar_txt.Location = new System.Drawing.Point(671, 158);
            this.magyar_txt.Name = "magyar_txt";
            this.magyar_txt.Size = new System.Drawing.Size(75, 20);
            this.magyar_txt.TabIndex = 37;
            this.magyar_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(808, 399);
            this.Controls.Add(this.magyar_txt);
            this.Controls.Add(this.sonkagomba_txt);
            this.Controls.Add(this.negysajt_txt);
            this.Controls.Add(this.vega_txt);
            this.Controls.Add(this.fajták);
            this.Controls.Add(this.vega_group);
            this.Controls.Add(this.magyar_group);
            this.Controls.Add(this.sonkagomba_group);
            this.Controls.Add(this.ft);
            this.Controls.Add(this.négysajt_group);
            this.Controls.Add(this.össz_mennyiség);
            this.Controls.Add(this.fizetendo_txt);
            this.Controls.Add(this.lbl_fizet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_nagy);
            this.Controls.Add(this.lbl_kicsi);
            this.Controls.Add(this.kilép);
            this.Controls.Add(this.töröl);
            this.Controls.Add(this.szamolas);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.főcím);
            this.Name = "Form1";
            this.Text = "Pizzéria";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.vega_group.ResumeLayout(false);
            this.vega_group.PerformLayout();
            this.magyar_group.ResumeLayout(false);
            this.magyar_group.PerformLayout();
            this.négysajt_group.ResumeLayout(false);
            this.négysajt_group.PerformLayout();
            this.sonkagomba_group.ResumeLayout(false);
            this.sonkagomba_group.PerformLayout();
            this.fajták.ResumeLayout(false);
            this.fajták.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vega_txt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.negysajt_txt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sonkagomba_txt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.magyar_txt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label főcím;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button szamolas;
        private System.Windows.Forms.Button töröl;
        private System.Windows.Forms.Button kilép;
        private System.Windows.Forms.CheckBox vega;
        private System.Windows.Forms.CheckBox magyar;
        private System.Windows.Forms.CheckBox negysajt;
        private System.Windows.Forms.CheckBox sonkagomba;
        private System.Windows.Forms.Label lbl_kicsi;
        private System.Windows.Forms.Label lbl_nagy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton vega_kicsi;
        private System.Windows.Forms.RadioButton magyar_kicsi;
        private System.Windows.Forms.RadioButton negysajt_kicsi;
        private System.Windows.Forms.RadioButton sonkagomba_kicsi;
        private System.Windows.Forms.RadioButton vega_nagy;
        private System.Windows.Forms.RadioButton magyar_nagy;
        private System.Windows.Forms.RadioButton negysajt_nagy;
        private System.Windows.Forms.RadioButton sonkagomba_nagy;
        private System.Windows.Forms.Label lbl_fizet;
        private System.Windows.Forms.TextBox fizetendo_txt;
        private System.Windows.Forms.TextBox össz_mennyiség;
        private System.Windows.Forms.GroupBox vega_group;
        private System.Windows.Forms.GroupBox magyar_group;
        private System.Windows.Forms.GroupBox négysajt_group;
        private System.Windows.Forms.GroupBox sonkagomba_group;
        private System.Windows.Forms.Label ft;
        private System.Windows.Forms.GroupBox fajták;
        private System.Windows.Forms.NumericUpDown vega_txt;
        private System.Windows.Forms.NumericUpDown negysajt_txt;
        private System.Windows.Forms.NumericUpDown sonkagomba_txt;
        private System.Windows.Forms.NumericUpDown magyar_txt;
    }
}

