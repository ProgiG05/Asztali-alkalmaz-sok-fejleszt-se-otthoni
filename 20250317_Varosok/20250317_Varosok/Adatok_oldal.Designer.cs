
namespace _20250317_Varosok
{
    partial class Adatok_oldal
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
            this.megnyit = new System.Windows.Forms.Button();
            this.varosok_lista = new System.Windows.Forms.ListBox();
            this.varos_neve_show = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.orszag_neve_show = new System.Windows.Forms.TextBox();
            this.lakossag_show = new System.Windows.Forms.TextBox();
            this.felvetel = new System.Windows.Forms.Button();
            this.kilepes = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // megnyit
            // 
            this.megnyit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.megnyit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.megnyit.ForeColor = System.Drawing.Color.White;
            this.megnyit.Location = new System.Drawing.Point(12, 12);
            this.megnyit.Name = "megnyit";
            this.megnyit.Size = new System.Drawing.Size(404, 50);
            this.megnyit.TabIndex = 0;
            this.megnyit.Text = "Megnyitás";
            this.megnyit.UseVisualStyleBackColor = false;
            this.megnyit.Click += new System.EventHandler(this.megnyit_Click);
            // 
            // varosok_lista
            // 
            this.varosok_lista.FormattingEnabled = true;
            this.varosok_lista.Location = new System.Drawing.Point(13, 70);
            this.varosok_lista.Name = "varosok_lista";
            this.varosok_lista.Size = new System.Drawing.Size(145, 290);
            this.varosok_lista.TabIndex = 1;
            this.varosok_lista.SelectedIndexChanged += new System.EventHandler(this.varosok_lista_SelectedIndexChanged);
            // 
            // varos_neve_show
            // 
            this.varos_neve_show.Location = new System.Drawing.Point(286, 70);
            this.varos_neve_show.Name = "varos_neve_show";
            this.varos_neve_show.ReadOnly = true;
            this.varos_neve_show.Size = new System.Drawing.Size(130, 20);
            this.varos_neve_show.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(170, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Város neve:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(170, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ország:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(170, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Lakosság(millió fő):";
            // 
            // orszag_neve_show
            // 
            this.orszag_neve_show.Location = new System.Drawing.Point(286, 120);
            this.orszag_neve_show.Name = "orszag_neve_show";
            this.orszag_neve_show.ReadOnly = true;
            this.orszag_neve_show.Size = new System.Drawing.Size(130, 20);
            this.orszag_neve_show.TabIndex = 6;
            // 
            // lakossag_show
            // 
            this.lakossag_show.Location = new System.Drawing.Point(334, 170);
            this.lakossag_show.Name = "lakossag_show";
            this.lakossag_show.ReadOnly = true;
            this.lakossag_show.Size = new System.Drawing.Size(82, 20);
            this.lakossag_show.TabIndex = 7;
            // 
            // felvetel
            // 
            this.felvetel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.felvetel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.felvetel.ForeColor = System.Drawing.Color.White;
            this.felvetel.Location = new System.Drawing.Point(173, 225);
            this.felvetel.Name = "felvetel";
            this.felvetel.Size = new System.Drawing.Size(243, 60);
            this.felvetel.TabIndex = 8;
            this.felvetel.Text = "Új város felvétele";
            this.felvetel.UseVisualStyleBackColor = false;
            this.felvetel.Click += new System.EventHandler(this.felvetel_Click);
            // 
            // kilepes
            // 
            this.kilepes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.kilepes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kilepes.ForeColor = System.Drawing.Color.White;
            this.kilepes.Location = new System.Drawing.Point(173, 300);
            this.kilepes.Name = "kilepes";
            this.kilepes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.kilepes.Size = new System.Drawing.Size(243, 60);
            this.kilepes.TabIndex = 9;
            this.kilepes.Text = "Kilépés";
            this.kilepes.UseVisualStyleBackColor = false;
            this.kilepes.Click += new System.EventHandler(this.kilepes_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(175, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(238, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "----------------------------------------------";
            // 
            // Adatok_oldal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 387);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.kilepes);
            this.Controls.Add(this.felvetel);
            this.Controls.Add(this.lakossag_show);
            this.Controls.Add(this.orszag_neve_show);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.varos_neve_show);
            this.Controls.Add(this.varosok_lista);
            this.Controls.Add(this.megnyit);
            this.Name = "Adatok_oldal";
            this.Text = "Adatok_oldal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button megnyit;
        private System.Windows.Forms.ListBox varosok_lista;
        private System.Windows.Forms.TextBox varos_neve_show;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox orszag_neve_show;
        private System.Windows.Forms.TextBox lakossag_show;
        private System.Windows.Forms.Button felvetel;
        private System.Windows.Forms.Button kilepes;
        private System.Windows.Forms.Label label4;
    }
}