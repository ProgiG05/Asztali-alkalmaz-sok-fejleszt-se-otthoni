
namespace _20250324_cserkesz
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
            this.belepes_btn = new System.Windows.Forms.Button();
            this.kilepes_btn = new System.Windows.Forms.Button();
            this.felh_input = new System.Windows.Forms.TextBox();
            this.jelszo_input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.hint_btn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.hibák_száma = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // belepes_btn
            // 
            this.belepes_btn.BackColor = System.Drawing.Color.MidnightBlue;
            this.belepes_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.belepes_btn.ForeColor = System.Drawing.Color.White;
            this.belepes_btn.Location = new System.Drawing.Point(30, 252);
            this.belepes_btn.Name = "belepes_btn";
            this.belepes_btn.Size = new System.Drawing.Size(300, 40);
            this.belepes_btn.TabIndex = 0;
            this.belepes_btn.Text = "BELÉPÉS";
            this.belepes_btn.UseVisualStyleBackColor = false;
            this.belepes_btn.Click += new System.EventHandler(this.belepes_btn_Click);
            // 
            // kilepes_btn
            // 
            this.kilepes_btn.BackColor = System.Drawing.Color.MidnightBlue;
            this.kilepes_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kilepes_btn.ForeColor = System.Drawing.Color.White;
            this.kilepes_btn.Location = new System.Drawing.Point(30, 304);
            this.kilepes_btn.Name = "kilepes_btn";
            this.kilepes_btn.Size = new System.Drawing.Size(300, 40);
            this.kilepes_btn.TabIndex = 1;
            this.kilepes_btn.Text = "KILÉPÉS";
            this.kilepes_btn.UseVisualStyleBackColor = false;
            this.kilepes_btn.Click += new System.EventHandler(this.kilepes_btn_Click);
            // 
            // felh_input
            // 
            this.felh_input.Location = new System.Drawing.Point(159, 105);
            this.felh_input.Name = "felh_input";
            this.felh_input.Size = new System.Drawing.Size(131, 20);
            this.felh_input.TabIndex = 2;
            // 
            // jelszo_input
            // 
            this.jelszo_input.Location = new System.Drawing.Point(159, 141);
            this.jelszo_input.Name = "jelszo_input";
            this.jelszo_input.Size = new System.Drawing.Size(131, 20);
            this.jelszo_input.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(26, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Felhasználónév:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(27, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Jelszó:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(32, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(296, 37);
            this.label3.TabIndex = 6;
            this.label3.Text = "BEJELENTKEZÉS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Location = new System.Drawing.Point(27, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(304, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "#####################################";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(27, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(304, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "#####################################";
            // 
            // hint_btn
            // 
            this.hint_btn.BackColor = System.Drawing.Color.MidnightBlue;
            this.hint_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.hint_btn.ForeColor = System.Drawing.Color.White;
            this.hint_btn.Location = new System.Drawing.Point(311, 115);
            this.hint_btn.Name = "hint_btn";
            this.hint_btn.Size = new System.Drawing.Size(36, 38);
            this.hint_btn.TabIndex = 10;
            this.hint_btn.Text = "?";
            this.hint_btn.UseVisualStyleBackColor = false;
            this.hint_btn.Click += new System.EventHandler(this.hint_btn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label6.Location = new System.Drawing.Point(77, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "Hibaszámláló: ";
            // 
            // hibák_száma
            // 
            this.hibák_száma.Enabled = false;
            this.hibák_száma.Location = new System.Drawing.Point(203, 179);
            this.hibák_száma.Name = "hibák_száma";
            this.hibák_száma.Size = new System.Drawing.Size(41, 20);
            this.hibák_száma.TabIndex = 12;
            this.hibák_száma.Text = "0";
            this.hibák_száma.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(359, 370);
            this.Controls.Add(this.hibák_száma);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.hint_btn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.jelszo_input);
            this.Controls.Add(this.felh_input);
            this.Controls.Add(this.kilepes_btn);
            this.Controls.Add(this.belepes_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button belepes_btn;
        private System.Windows.Forms.Button kilepes_btn;
        private System.Windows.Forms.TextBox felh_input;
        private System.Windows.Forms.TextBox jelszo_input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button hint_btn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox hibák_száma;
    }
}

