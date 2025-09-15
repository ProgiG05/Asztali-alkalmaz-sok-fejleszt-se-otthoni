
namespace _20241007_innovácio
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
            this.lbl_geri = new System.Windows.Forms.Label();
            this.lbl_osztaly = new System.Windows.Forms.Label();
            this.btn_kilép = new System.Windows.Forms.Button();
            this.btn_vmi = new System.Windows.Forms.Button();
            this.txt_box = new System.Windows.Forms.TextBox();
            this.minden_látszik = new System.Windows.Forms.Button();
            this.elso_szam = new System.Windows.Forms.Label();
            this.masodik_szam = new System.Windows.Forms.Label();
            this.elso_input = new System.Windows.Forms.TextBox();
            this.masodik_input = new System.Windows.Forms.TextBox();
            this.eredmény = new System.Windows.Forms.Label();
            this.plusz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_geri
            // 
            this.lbl_geri.AutoSize = true;
            this.lbl_geri.BackColor = System.Drawing.Color.PaleGreen;
            this.lbl_geri.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_geri.Location = new System.Drawing.Point(173, 38);
            this.lbl_geri.Name = "lbl_geri";
            this.lbl_geri.Size = new System.Drawing.Size(54, 29);
            this.lbl_geri.TabIndex = 0;
            this.lbl_geri.Text = "geri";
            // 
            // lbl_osztaly
            // 
            this.lbl_osztaly.AutoSize = true;
            this.lbl_osztaly.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_osztaly.Location = new System.Drawing.Point(32, 149);
            this.lbl_osztaly.Name = "lbl_osztaly";
            this.lbl_osztaly.Size = new System.Drawing.Size(75, 25);
            this.lbl_osztaly.TabIndex = 1;
            this.lbl_osztaly.Text = "piroska";
            this.lbl_osztaly.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_kilép
            // 
            this.btn_kilép.Location = new System.Drawing.Point(167, 530);
            this.btn_kilép.Name = "btn_kilép";
            this.btn_kilép.Size = new System.Drawing.Size(75, 27);
            this.btn_kilép.TabIndex = 2;
            this.btn_kilép.Text = "Bezárás";
            this.btn_kilép.UseVisualStyleBackColor = true;
            this.btn_kilép.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_vmi
            // 
            this.btn_vmi.Location = new System.Drawing.Point(143, 145);
            this.btn_vmi.Name = "btn_vmi";
            this.btn_vmi.Size = new System.Drawing.Size(120, 29);
            this.btn_vmi.TabIndex = 3;
            this.btn_vmi.Text = "Sárga";
            this.btn_vmi.UseVisualStyleBackColor = true;
            this.btn_vmi.Click += new System.EventHandler(this.btn_vmi_Click);
            // 
            // txt_box
            // 
            this.txt_box.Location = new System.Drawing.Point(143, 109);
            this.txt_box.Name = "txt_box";
            this.txt_box.Size = new System.Drawing.Size(120, 20);
            this.txt_box.TabIndex = 4;
            this.txt_box.Text = "semmi";
            this.txt_box.TextChanged += new System.EventHandler(this.txt_box_TextChanged);
            // 
            // minden_látszik
            // 
            this.minden_látszik.Location = new System.Drawing.Point(143, 194);
            this.minden_látszik.Name = "minden_látszik";
            this.minden_látszik.Size = new System.Drawing.Size(120, 29);
            this.minden_látszik.TabIndex = 5;
            this.minden_látszik.Text = "Minden Látszik";
            this.minden_látszik.UseVisualStyleBackColor = true;
            this.minden_látszik.Click += new System.EventHandler(this.minden_látszik_Click);
            // 
            // elso_szam
            // 
            this.elso_szam.AutoSize = true;
            this.elso_szam.Location = new System.Drawing.Point(61, 272);
            this.elso_szam.Name = "elso_szam";
            this.elso_szam.Size = new System.Drawing.Size(56, 13);
            this.elso_szam.TabIndex = 6;
            this.elso_szam.Text = "Első Szám";
            // 
            // masodik_szam
            // 
            this.masodik_szam.AutoSize = true;
            this.masodik_szam.Location = new System.Drawing.Point(61, 319);
            this.masodik_szam.Name = "masodik_szam";
            this.masodik_szam.Size = new System.Drawing.Size(76, 13);
            this.masodik_szam.TabIndex = 7;
            this.masodik_szam.Text = "Második Szám";
            // 
            // elso_input
            // 
            this.elso_input.Location = new System.Drawing.Point(143, 269);
            this.elso_input.Name = "elso_input";
            this.elso_input.Size = new System.Drawing.Size(120, 20);
            this.elso_input.TabIndex = 8;
            // 
            // masodik_input
            // 
            this.masodik_input.Location = new System.Drawing.Point(143, 312);
            this.masodik_input.Name = "masodik_input";
            this.masodik_input.Size = new System.Drawing.Size(120, 20);
            this.masodik_input.TabIndex = 9;
            // 
            // eredmény
            // 
            this.eredmény.AutoSize = true;
            this.eredmény.Location = new System.Drawing.Point(164, 363);
            this.eredmény.Name = "eredmény";
            this.eredmény.Size = new System.Drawing.Size(63, 13);
            this.eredmény.TabIndex = 10;
            this.eredmény.Text = "Eredmény:  ";
            // 
            // plusz
            // 
            this.plusz.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.plusz.Location = new System.Drawing.Point(289, 269);
            this.plusz.Name = "plusz";
            this.plusz.Size = new System.Drawing.Size(29, 63);
            this.plusz.TabIndex = 11;
            this.plusz.Text = "+";
            this.plusz.UseVisualStyleBackColor = true;
            this.plusz.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(425, 591);
            this.Controls.Add(this.plusz);
            this.Controls.Add(this.eredmény);
            this.Controls.Add(this.masodik_input);
            this.Controls.Add(this.elso_input);
            this.Controls.Add(this.masodik_szam);
            this.Controls.Add(this.elso_szam);
            this.Controls.Add(this.minden_látszik);
            this.Controls.Add(this.txt_box);
            this.Controls.Add(this.btn_vmi);
            this.Controls.Add(this.btn_kilép);
            this.Controls.Add(this.lbl_osztaly);
            this.Controls.Add(this.lbl_geri);
            this.Name = "Form1";
            this.Text = "proba";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_geri;
        private System.Windows.Forms.Label lbl_osztaly;
        private System.Windows.Forms.Button btn_kilép;
        private System.Windows.Forms.Button btn_vmi;
        private System.Windows.Forms.TextBox txt_box;
        private System.Windows.Forms.Button minden_látszik;
        private System.Windows.Forms.Label elso_szam;
        private System.Windows.Forms.Label masodik_szam;
        private System.Windows.Forms.TextBox elso_input;
        private System.Windows.Forms.TextBox masodik_input;
        private System.Windows.Forms.Label eredmény;
        private System.Windows.Forms.Button plusz;
    }
}

