
namespace _20241124_gyakszi_probadoga
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
            this.label1 = new System.Windows.Forms.Label();
            this.változó_lbl = new System.Windows.Forms.Label();
            this.show_lbl = new System.Windows.Forms.Label();
            this.nev_input = new System.Windows.Forms.TextBox();
            this.show = new System.Windows.Forms.TextBox();
            this.haromjegy_list = new System.Windows.Forms.ListBox();
            this.oszthatok_lista = new System.Windows.Forms.ListBox();
            this.masolas_btn = new System.Windows.Forms.Button();
            this.feltolto_btn = new System.Windows.Forms.Button();
            this.megjelenit_btn = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.kilep_btn = new System.Windows.Forms.Button();
            this.kombo = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.paros_radio = new System.Windows.Forms.RadioButton();
            this.paratlan_radio = new System.Windows.Forms.RadioButton();
            this.harommal_check = new System.Windows.Forms.CheckBox();
            this.ottel_check = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Írd be a neved:";
            // 
            // változó_lbl
            // 
            this.változó_lbl.AutoSize = true;
            this.változó_lbl.BackColor = System.Drawing.Color.LemonChiffon;
            this.változó_lbl.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.változó_lbl.ForeColor = System.Drawing.Color.Red;
            this.változó_lbl.Location = new System.Drawing.Point(196, 9);
            this.változó_lbl.Name = "változó_lbl";
            this.változó_lbl.Size = new System.Drawing.Size(62, 25);
            this.változó_lbl.TabIndex = 1;
            this.változó_lbl.Text = "label2";
            // 
            // show_lbl
            // 
            this.show_lbl.AutoSize = true;
            this.show_lbl.Location = new System.Drawing.Point(245, 191);
            this.show_lbl.Name = "show_lbl";
            this.show_lbl.Size = new System.Drawing.Size(35, 13);
            this.show_lbl.TabIndex = 2;
            this.show_lbl.Text = "label3";
            // 
            // nev_input
            // 
            this.nev_input.Location = new System.Drawing.Point(26, 43);
            this.nev_input.Name = "nev_input";
            this.nev_input.Size = new System.Drawing.Size(141, 20);
            this.nev_input.TabIndex = 3;
            // 
            // show
            // 
            this.show.Enabled = false;
            this.show.Location = new System.Drawing.Point(194, 188);
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(45, 20);
            this.show.TabIndex = 4;
            // 
            // haromjegy_list
            // 
            this.haromjegy_list.FormattingEnabled = true;
            this.haromjegy_list.Location = new System.Drawing.Point(26, 100);
            this.haromjegy_list.Name = "haromjegy_list";
            this.haromjegy_list.Size = new System.Drawing.Size(141, 342);
            this.haromjegy_list.TabIndex = 5;
            // 
            // oszthatok_lista
            // 
            this.oszthatok_lista.FormattingEnabled = true;
            this.oszthatok_lista.Location = new System.Drawing.Point(194, 311);
            this.oszthatok_lista.Name = "oszthatok_lista";
            this.oszthatok_lista.Size = new System.Drawing.Size(139, 121);
            this.oszthatok_lista.TabIndex = 6;
            // 
            // masolas_btn
            // 
            this.masolas_btn.Location = new System.Drawing.Point(26, 69);
            this.masolas_btn.Name = "masolas_btn";
            this.masolas_btn.Size = new System.Drawing.Size(141, 23);
            this.masolas_btn.TabIndex = 7;
            this.masolas_btn.Text = "Másolás";
            this.masolas_btn.UseVisualStyleBackColor = true;
            this.masolas_btn.Click += new System.EventHandler(this.masolas_btn_Click);
            // 
            // feltolto_btn
            // 
            this.feltolto_btn.Location = new System.Drawing.Point(26, 448);
            this.feltolto_btn.Name = "feltolto_btn";
            this.feltolto_btn.Size = new System.Drawing.Size(141, 39);
            this.feltolto_btn.TabIndex = 8;
            this.feltolto_btn.Text = "Feltöltés hárromjegyű számokkal";
            this.feltolto_btn.UseVisualStyleBackColor = true;
            this.feltolto_btn.Click += new System.EventHandler(this.feltolto_btn_Click);
            // 
            // megjelenit_btn
            // 
            this.megjelenit_btn.Location = new System.Drawing.Point(194, 69);
            this.megjelenit_btn.Name = "megjelenit_btn";
            this.megjelenit_btn.Size = new System.Drawing.Size(142, 23);
            this.megjelenit_btn.TabIndex = 9;
            this.megjelenit_btn.Text = "Megjelenít";
            this.megjelenit_btn.UseVisualStyleBackColor = true;
            this.megjelenit_btn.Click += new System.EventHandler(this.megjelenit_btn_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(194, 282);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(142, 23);
            this.button4.TabIndex = 10;
            this.button4.Text = "Oszthatóság vizsgálata";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // kilep_btn
            // 
            this.kilep_btn.Location = new System.Drawing.Point(194, 448);
            this.kilep_btn.Name = "kilep_btn";
            this.kilep_btn.Size = new System.Drawing.Size(139, 39);
            this.kilep_btn.TabIndex = 11;
            this.kilep_btn.Text = "Kilépés";
            this.kilep_btn.UseVisualStyleBackColor = true;
            this.kilep_btn.Click += new System.EventHandler(this.kilep_btn_Click);
            // 
            // kombo
            // 
            this.kombo.FormattingEnabled = true;
            this.kombo.Location = new System.Drawing.Point(195, 42);
            this.kombo.Name = "kombo";
            this.kombo.Size = new System.Drawing.Size(141, 21);
            this.kombo.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.paratlan_radio);
            this.groupBox1.Controls.Add(this.paros_radio);
            this.groupBox1.Location = new System.Drawing.Point(195, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(141, 72);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Megszámlálás";
            // 
            // paros_radio
            // 
            this.paros_radio.AutoSize = true;
            this.paros_radio.Location = new System.Drawing.Point(6, 19);
            this.paros_radio.Name = "paros_radio";
            this.paros_radio.Size = new System.Drawing.Size(52, 17);
            this.paros_radio.TabIndex = 14;
            this.paros_radio.TabStop = true;
            this.paros_radio.Text = "Páros";
            this.paros_radio.UseVisualStyleBackColor = true;
            this.paros_radio.CheckedChanged += new System.EventHandler(this.paros_radio_CheckedChanged);
            // 
            // paratlan_radio
            // 
            this.paratlan_radio.AutoSize = true;
            this.paratlan_radio.Location = new System.Drawing.Point(6, 42);
            this.paratlan_radio.Name = "paratlan_radio";
            this.paratlan_radio.Size = new System.Drawing.Size(64, 17);
            this.paratlan_radio.TabIndex = 15;
            this.paratlan_radio.TabStop = true;
            this.paratlan_radio.Text = "Páratlan";
            this.paratlan_radio.UseVisualStyleBackColor = true;
            this.paratlan_radio.CheckedChanged += new System.EventHandler(this.paratlan_radio_CheckedChanged);
            // 
            // harommal_check
            // 
            this.harommal_check.AutoSize = true;
            this.harommal_check.Location = new System.Drawing.Point(194, 227);
            this.harommal_check.Name = "harommal_check";
            this.harommal_check.Size = new System.Drawing.Size(100, 17);
            this.harommal_check.TabIndex = 14;
            this.harommal_check.Text = "3-mal oszthatók";
            this.harommal_check.UseVisualStyleBackColor = true;
            // 
            // ottel_check
            // 
            this.ottel_check.AutoSize = true;
            this.ottel_check.Location = new System.Drawing.Point(194, 250);
            this.ottel_check.Name = "ottel_check";
            this.ottel_check.Size = new System.Drawing.Size(98, 17);
            this.ottel_check.TabIndex = 15;
            this.ottel_check.Text = "5-terl oszthatók";
            this.ottel_check.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 510);
            this.Controls.Add(this.ottel_check);
            this.Controls.Add(this.harommal_check);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.kombo);
            this.Controls.Add(this.kilep_btn);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.megjelenit_btn);
            this.Controls.Add(this.feltolto_btn);
            this.Controls.Add(this.masolas_btn);
            this.Controls.Add(this.oszthatok_lista);
            this.Controls.Add(this.haromjegy_list);
            this.Controls.Add(this.show);
            this.Controls.Add(this.nev_input);
            this.Controls.Add(this.show_lbl);
            this.Controls.Add(this.változó_lbl);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "WinForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label változó_lbl;
        private System.Windows.Forms.Label show_lbl;
        private System.Windows.Forms.TextBox nev_input;
        private System.Windows.Forms.TextBox show;
        private System.Windows.Forms.ListBox haromjegy_list;
        private System.Windows.Forms.ListBox oszthatok_lista;
        private System.Windows.Forms.Button masolas_btn;
        private System.Windows.Forms.Button feltolto_btn;
        private System.Windows.Forms.Button megjelenit_btn;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button kilep_btn;
        private System.Windows.Forms.ComboBox kombo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton paratlan_radio;
        private System.Windows.Forms.RadioButton paros_radio;
        private System.Windows.Forms.CheckBox harommal_check;
        private System.Windows.Forms.CheckBox ottel_check;
    }
}

