
namespace _20250127_karacsonyCLI
{
    partial class Angyalka
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
            this.hozzáad_btn = new System.Windows.Forms.Button();
            this.bezár = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.napszam_lista = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // hozzáad_btn
            // 
            this.hozzáad_btn.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.hozzáad_btn.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.hozzáad_btn.ForeColor = System.Drawing.Color.White;
            this.hozzáad_btn.Location = new System.Drawing.Point(695, 25);
            this.hozzáad_btn.Name = "hozzáad_btn";
            this.hozzáad_btn.Size = new System.Drawing.Size(136, 34);
            this.hozzáad_btn.TabIndex = 0;
            this.hozzáad_btn.Text = "HOZZÁAD";
            this.hozzáad_btn.UseVisualStyleBackColor = false;
            this.hozzáad_btn.Click += new System.EventHandler(this.hozzáad_btn_Click);
            // 
            // bezár
            // 
            this.bezár.BackColor = System.Drawing.Color.Red;
            this.bezár.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bezár.ForeColor = System.Drawing.Color.White;
            this.bezár.Location = new System.Drawing.Point(771, 302);
            this.bezár.Name = "bezár";
            this.bezár.Size = new System.Drawing.Size(60, 60);
            this.bezár.TabIndex = 1;
            this.bezár.Text = "X";
            this.bezár.UseVisualStyleBackColor = false;
            this.bezár.Click += new System.EventHandler(this.bezár_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(18, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nap száma:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(490, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Eladott:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(250, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Elkészített:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(356, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(582, 34);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 6;
            // 
            // napszam_lista
            // 
            this.napszam_lista.FormattingEnabled = true;
            this.napszam_lista.Location = new System.Drawing.Point(128, 34);
            this.napszam_lista.Name = "napszam_lista";
            this.napszam_lista.Size = new System.Drawing.Size(100, 21);
            this.napszam_lista.TabIndex = 7;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(21, 85);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(661, 277);
            this.listBox1.TabIndex = 8;
            // 
            // Angyalka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(843, 379);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.napszam_lista);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bezár);
            this.Controls.Add(this.hozzáad_btn);
            this.Name = "Angyalka";
            this.Text = "Angyalka";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button hozzáad_btn;
        private System.Windows.Forms.Button bezár;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox napszam_lista;
        private System.Windows.Forms.ListBox listBox1;
    }
}

