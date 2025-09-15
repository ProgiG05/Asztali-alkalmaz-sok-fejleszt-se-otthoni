
namespace _20241014_forms_gyak_haromszog
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
            this.alfa_input = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.főcím = new System.Windows.Forms.Label();
            this.béta_input = new System.Windows.Forms.TextBox();
            this.gamma_input = new System.Windows.Forms.TextBox();
            this.alfa = new System.Windows.Forms.Label();
            this.béta = new System.Windows.Forms.Label();
            this.gamma = new System.Windows.Forms.Label();
            this.fok = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.szögek = new System.Windows.Forms.Button();
            this.kérdések = new System.Windows.Forms.Button();
            this.kilépés = new System.Windows.Forms.Button();
            this.kérdés1 = new System.Windows.Forms.Label();
            this.válasz1 = new System.Windows.Forms.Label();
            this.kérdés2 = new System.Windows.Forms.Label();
            this.kérdés3 = new System.Windows.Forms.Label();
            this.válasz2 = new System.Windows.Forms.Label();
            this.válasz3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // alfa_input
            // 
            this.alfa_input.Location = new System.Drawing.Point(375, 89);
            this.alfa_input.Name = "alfa_input";
            this.alfa_input.Size = new System.Drawing.Size(100, 20);
            this.alfa_input.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(32, 89);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 149);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // főcím
            // 
            this.főcím.AutoSize = true;
            this.főcím.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.főcím.Location = new System.Drawing.Point(178, 28);
            this.főcím.Name = "főcím";
            this.főcím.Size = new System.Drawing.Size(153, 31);
            this.főcím.TabIndex = 2;
            this.főcím.Text = "Háromszög";
            // 
            // béta_input
            // 
            this.béta_input.Location = new System.Drawing.Point(374, 142);
            this.béta_input.Name = "béta_input";
            this.béta_input.Size = new System.Drawing.Size(100, 20);
            this.béta_input.TabIndex = 3;
            // 
            // gamma_input
            // 
            this.gamma_input.Enabled = false;
            this.gamma_input.HideSelection = false;
            this.gamma_input.Location = new System.Drawing.Point(374, 197);
            this.gamma_input.Name = "gamma_input";
            this.gamma_input.Size = new System.Drawing.Size(100, 20);
            this.gamma_input.TabIndex = 4;
            // 
            // alfa
            // 
            this.alfa.AutoSize = true;
            this.alfa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.alfa.Location = new System.Drawing.Point(335, 91);
            this.alfa.Name = "alfa";
            this.alfa.Size = new System.Drawing.Size(34, 18);
            this.alfa.TabIndex = 5;
            this.alfa.Text = "α = ";
            // 
            // béta
            // 
            this.béta.AutoSize = true;
            this.béta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.béta.Location = new System.Drawing.Point(335, 141);
            this.béta.Name = "béta";
            this.béta.Size = new System.Drawing.Size(33, 18);
            this.béta.TabIndex = 6;
            this.béta.Text = "β = ";
            // 
            // gamma
            // 
            this.gamma.AutoSize = true;
            this.gamma.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gamma.Location = new System.Drawing.Point(335, 196);
            this.gamma.Name = "gamma";
            this.gamma.Size = new System.Drawing.Size(28, 18);
            this.gamma.TabIndex = 7;
            this.gamma.Text = "γ =";
            // 
            // fok
            // 
            this.fok.AutoSize = true;
            this.fok.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fok.Location = new System.Drawing.Point(480, 197);
            this.fok.Name = "fok";
            this.fok.Size = new System.Drawing.Size(14, 18);
            this.fok.TabIndex = 8;
            this.fok.Text = "°";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(480, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "°";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(481, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "°";
            // 
            // szögek
            // 
            this.szögek.Location = new System.Drawing.Point(357, 252);
            this.szögek.Name = "szögek";
            this.szögek.Size = new System.Drawing.Size(137, 42);
            this.szögek.TabIndex = 11;
            this.szögek.Text = "Szögek";
            this.szögek.UseVisualStyleBackColor = true;
            this.szögek.Click += new System.EventHandler(this.szögek_Click);
            // 
            // kérdések
            // 
            this.kérdések.Location = new System.Drawing.Point(357, 300);
            this.kérdések.Name = "kérdések";
            this.kérdések.Size = new System.Drawing.Size(138, 42);
            this.kérdések.TabIndex = 12;
            this.kérdések.Text = "Kérdések";
            this.kérdések.UseVisualStyleBackColor = true;
            this.kérdések.Click += new System.EventHandler(this.kérdések_Click);
            // 
            // kilépés
            // 
            this.kilépés.Location = new System.Drawing.Point(357, 348);
            this.kilépés.Name = "kilépés";
            this.kilépés.Size = new System.Drawing.Size(137, 42);
            this.kilépés.TabIndex = 13;
            this.kilépés.Text = "Kilépés";
            this.kilépés.UseVisualStyleBackColor = true;
            this.kilépés.Click += new System.EventHandler(this.kilépés_Click);
            // 
            // kérdés1
            // 
            this.kérdés1.AutoSize = true;
            this.kérdés1.Location = new System.Drawing.Point(32, 281);
            this.kérdés1.Name = "kérdés1";
            this.kérdés1.Size = new System.Drawing.Size(133, 13);
            this.kérdés1.TabIndex = 14;
            this.kérdés1.Text = "Derékszögű a háromszög?";
            // 
            // válasz1
            // 
            this.válasz1.AutoSize = true;
            this.válasz1.Location = new System.Drawing.Point(202, 281);
            this.válasz1.Name = "válasz1";
            this.válasz1.Size = new System.Drawing.Size(55, 13);
            this.válasz1.TabIndex = 15;
            this.válasz1.Text = "Igen/Nem";
            // 
            // kérdés2
            // 
            this.kérdés2.AutoSize = true;
            this.kérdés2.Location = new System.Drawing.Point(32, 314);
            this.kérdés2.Name = "kérdés2";
            this.kérdés2.Size = new System.Drawing.Size(142, 13);
            this.kérdés2.TabIndex = 16;
            this.kérdés2.Text = "Egyenlő szárú a háromszög?";
            // 
            // kérdés3
            // 
            this.kérdés3.AutoSize = true;
            this.kérdés3.Location = new System.Drawing.Point(32, 348);
            this.kérdés3.Name = "kérdés3";
            this.kérdés3.Size = new System.Drawing.Size(148, 13);
            this.kérdés3.TabIndex = 17;
            this.kérdés3.Text = "Egyenlő oldalú a háromszög? ";
            // 
            // válasz2
            // 
            this.válasz2.AutoSize = true;
            this.válasz2.Location = new System.Drawing.Point(202, 314);
            this.válasz2.Name = "válasz2";
            this.válasz2.Size = new System.Drawing.Size(55, 13);
            this.válasz2.TabIndex = 18;
            this.válasz2.Text = "Igen/Nem";
            // 
            // válasz3
            // 
            this.válasz3.AutoSize = true;
            this.válasz3.Location = new System.Drawing.Point(202, 348);
            this.válasz3.Name = "válasz3";
            this.válasz3.Size = new System.Drawing.Size(55, 13);
            this.válasz3.TabIndex = 19;
            this.válasz3.Text = "Igen/Nem";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(525, 409);
            this.Controls.Add(this.válasz3);
            this.Controls.Add(this.válasz2);
            this.Controls.Add(this.kérdés3);
            this.Controls.Add(this.kérdés2);
            this.Controls.Add(this.válasz1);
            this.Controls.Add(this.kérdés1);
            this.Controls.Add(this.kilépés);
            this.Controls.Add(this.kérdések);
            this.Controls.Add(this.szögek);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fok);
            this.Controls.Add(this.gamma);
            this.Controls.Add(this.béta);
            this.Controls.Add(this.alfa);
            this.Controls.Add(this.gamma_input);
            this.Controls.Add(this.béta_input);
            this.Controls.Add(this.főcím);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.alfa_input);
            this.Name = "Form1";
            this.Text = "Háromszög";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox alfa_input;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label főcím;
        private System.Windows.Forms.TextBox béta_input;
        private System.Windows.Forms.TextBox gamma_input;
        private System.Windows.Forms.Label alfa;
        private System.Windows.Forms.Label béta;
        private System.Windows.Forms.Label gamma;
        private System.Windows.Forms.Label fok;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button szögek;
        private System.Windows.Forms.Button kérdések;
        private System.Windows.Forms.Button kilépés;
        private System.Windows.Forms.Label kérdés1;
        private System.Windows.Forms.Label válasz1;
        private System.Windows.Forms.Label kérdés2;
        private System.Windows.Forms.Label kérdés3;
        private System.Windows.Forms.Label válasz2;
        private System.Windows.Forms.Label válasz3;
    }
}

