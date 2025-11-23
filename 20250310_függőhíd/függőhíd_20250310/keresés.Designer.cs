
namespace függőhíd_20250310
{
    partial class keresés_form
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
            this.utána_radio = new System.Windows.Forms.RadioButton();
            this.előtte_radio = new System.Windows.Forms.RadioButton();
            this.darab_lbl = new System.Windows.Forms.Label();
            this.darab_show = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bezaras_btn = new System.Windows.Forms.Button();
            this.hidak_lista2 = new System.Windows.Forms.ListBox();
            this.hely_lbl = new System.Windows.Forms.Label();
            this.hely_show = new System.Windows.Forms.TextBox();
            this.orszag_show = new System.Windows.Forms.TextBox();
            this.hossz_show = new System.Windows.Forms.TextBox();
            this.ev_show = new System.Windows.Forms.TextBox();
            this.orszag_lbl = new System.Windows.Forms.Label();
            this.hossz_lbl = new System.Windows.Forms.Label();
            this.ev_lbl = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // utána_radio
            // 
            this.utána_radio.AutoSize = true;
            this.utána_radio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.utána_radio.ForeColor = System.Drawing.Color.White;
            this.utána_radio.Location = new System.Drawing.Point(29, 70);
            this.utána_radio.Name = "utána_radio";
            this.utána_radio.Size = new System.Drawing.Size(180, 22);
            this.utána_radio.TabIndex = 3;
            this.utána_radio.TabStop = true;
            this.utána_radio.Text = "2000-ben vagy utána";
            this.utána_radio.UseVisualStyleBackColor = true;
            this.utána_radio.CheckedChanged += new System.EventHandler(this.utána_radio_CheckedChanged);
            // 
            // előtte_radio
            // 
            this.előtte_radio.AutoSize = true;
            this.előtte_radio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.előtte_radio.ForeColor = System.Drawing.Color.White;
            this.előtte_radio.Location = new System.Drawing.Point(29, 33);
            this.előtte_radio.Name = "előtte_radio";
            this.előtte_radio.Size = new System.Drawing.Size(141, 22);
            this.előtte_radio.TabIndex = 2;
            this.előtte_radio.TabStop = true;
            this.előtte_radio.Text = "2000 előtt épült";
            this.előtte_radio.UseVisualStyleBackColor = true;
            this.előtte_radio.CheckedChanged += new System.EventHandler(this.előtte_radio_CheckedChanged);
            // 
            // darab_lbl
            // 
            this.darab_lbl.AutoSize = true;
            this.darab_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.darab_lbl.ForeColor = System.Drawing.Color.White;
            this.darab_lbl.Location = new System.Drawing.Point(135, 103);
            this.darab_lbl.Name = "darab_lbl";
            this.darab_lbl.Size = new System.Drawing.Size(50, 18);
            this.darab_lbl.TabIndex = 1;
            this.darab_lbl.Text = "darab";
            // 
            // darab_show
            // 
            this.darab_show.Location = new System.Drawing.Point(29, 100);
            this.darab_show.Name = "darab_show";
            this.darab_show.Size = new System.Drawing.Size(100, 24);
            this.darab_show.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bezaras_btn);
            this.groupBox1.Controls.Add(this.utána_radio);
            this.groupBox1.Controls.Add(this.előtte_radio);
            this.groupBox1.Controls.Add(this.darab_lbl);
            this.groupBox1.Controls.Add(this.darab_show);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(17, 201);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 146);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hidak száma";
            // 
            // bezaras_btn
            // 
            this.bezaras_btn.BackColor = System.Drawing.Color.Red;
            this.bezaras_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bezaras_btn.ForeColor = System.Drawing.Color.White;
            this.bezaras_btn.Location = new System.Drawing.Point(283, 50);
            this.bezaras_btn.Name = "bezaras_btn";
            this.bezaras_btn.Size = new System.Drawing.Size(59, 52);
            this.bezaras_btn.TabIndex = 10;
            this.bezaras_btn.Text = "X";
            this.bezaras_btn.UseVisualStyleBackColor = false;
            this.bezaras_btn.Click += new System.EventHandler(this.bezaras_btn_Click);
            // 
            // hidak_lista2
            // 
            this.hidak_lista2.FormattingEnabled = true;
            this.hidak_lista2.Location = new System.Drawing.Point(15, 21);
            this.hidak_lista2.Name = "hidak_lista2";
            this.hidak_lista2.Size = new System.Drawing.Size(182, 160);
            this.hidak_lista2.TabIndex = 9;
            this.hidak_lista2.SelectedIndexChanged += new System.EventHandler(this.hidak_lista2_SelectedIndexChanged);
            // 
            // hely_lbl
            // 
            this.hely_lbl.AutoSize = true;
            this.hely_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.hely_lbl.ForeColor = System.Drawing.Color.White;
            this.hely_lbl.Location = new System.Drawing.Point(213, 21);
            this.hely_lbl.Name = "hely_lbl";
            this.hely_lbl.Size = new System.Drawing.Size(46, 18);
            this.hely_lbl.TabIndex = 5;
            this.hely_lbl.Text = "Hely:";
            this.hely_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hely_show
            // 
            this.hely_show.Location = new System.Drawing.Point(287, 22);
            this.hely_show.Name = "hely_show";
            this.hely_show.Size = new System.Drawing.Size(127, 20);
            this.hely_show.TabIndex = 0;
            // 
            // orszag_show
            // 
            this.orszag_show.Location = new System.Drawing.Point(287, 67);
            this.orszag_show.Name = "orszag_show";
            this.orszag_show.Size = new System.Drawing.Size(127, 20);
            this.orszag_show.TabIndex = 1;
            // 
            // hossz_show
            // 
            this.hossz_show.Location = new System.Drawing.Point(287, 111);
            this.hossz_show.Name = "hossz_show";
            this.hossz_show.Size = new System.Drawing.Size(127, 20);
            this.hossz_show.TabIndex = 2;
            // 
            // ev_show
            // 
            this.ev_show.Location = new System.Drawing.Point(287, 156);
            this.ev_show.Name = "ev_show";
            this.ev_show.Size = new System.Drawing.Size(127, 20);
            this.ev_show.TabIndex = 3;
            // 
            // orszag_lbl
            // 
            this.orszag_lbl.AutoSize = true;
            this.orszag_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.orszag_lbl.ForeColor = System.Drawing.Color.White;
            this.orszag_lbl.Location = new System.Drawing.Point(213, 66);
            this.orszag_lbl.Name = "orszag_lbl";
            this.orszag_lbl.Size = new System.Drawing.Size(68, 18);
            this.orszag_lbl.TabIndex = 6;
            this.orszag_lbl.Text = "Ország:";
            this.orszag_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hossz_lbl
            // 
            this.hossz_lbl.AutoSize = true;
            this.hossz_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.hossz_lbl.ForeColor = System.Drawing.Color.White;
            this.hossz_lbl.Location = new System.Drawing.Point(213, 110);
            this.hossz_lbl.Name = "hossz_lbl";
            this.hossz_lbl.Size = new System.Drawing.Size(62, 18);
            this.hossz_lbl.TabIndex = 7;
            this.hossz_lbl.Text = "Hossz:";
            this.hossz_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ev_lbl
            // 
            this.ev_lbl.AutoSize = true;
            this.ev_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ev_lbl.ForeColor = System.Drawing.Color.White;
            this.ev_lbl.Location = new System.Drawing.Point(213, 155);
            this.ev_lbl.Name = "ev_lbl";
            this.ev_lbl.Size = new System.Drawing.Size(32, 18);
            this.ev_lbl.TabIndex = 8;
            this.ev_lbl.Text = "Év:";
            this.ev_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // keresés_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(424, 377);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ev_lbl);
            this.Controls.Add(this.hidak_lista2);
            this.Controls.Add(this.hossz_lbl);
            this.Controls.Add(this.orszag_lbl);
            this.Controls.Add(this.hely_lbl);
            this.Controls.Add(this.hely_show);
            this.Controls.Add(this.ev_show);
            this.Controls.Add(this.orszag_show);
            this.Controls.Add(this.hossz_show);
            this.Name = "keresés_form";
            this.Text = "Keresés";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton utána_radio;
        private System.Windows.Forms.RadioButton előtte_radio;
        private System.Windows.Forms.Label darab_lbl;
        private System.Windows.Forms.TextBox darab_show;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bezaras_btn;
        private System.Windows.Forms.ListBox hidak_lista2;
        private System.Windows.Forms.Label hely_lbl;
        private System.Windows.Forms.TextBox hely_show;
        private System.Windows.Forms.TextBox orszag_show;
        private System.Windows.Forms.TextBox hossz_show;
        private System.Windows.Forms.TextBox ev_show;
        private System.Windows.Forms.Label orszag_lbl;
        private System.Windows.Forms.Label hossz_lbl;
        private System.Windows.Forms.Label ev_lbl;
    }
}