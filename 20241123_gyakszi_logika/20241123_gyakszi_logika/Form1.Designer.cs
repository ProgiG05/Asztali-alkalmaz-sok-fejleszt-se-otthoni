
namespace _20241123_gyakszi_logika
{
    partial class Logika
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
            this.Értékek_lbl = new System.Windows.Forms.Label();
            this.A = new System.Windows.Forms.CheckBox();
            this.B = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.eredmeny_btn = new System.Windows.Forms.Button();
            this.kommutativitas = new System.Windows.Forms.RadioButton();
            this.asszociativitas = new System.Windows.Forms.RadioButton();
            this.disztributivitas = new System.Windows.Forms.RadioButton();
            this.logiakai_muveletek_box = new System.Windows.Forms.GroupBox();
            this.muveletek_dropdown = new System.Windows.Forms.ComboBox();
            this.müveletek_lbl = new System.Windows.Forms.Label();
            this.szabályok_box = new System.Windows.Forms.GroupBox();
            this.logiakai_muveletek_box.SuspendLayout();
            this.szabályok_box.SuspendLayout();
            this.SuspendLayout();
            // 
            // Értékek_lbl
            // 
            this.Értékek_lbl.AutoSize = true;
            this.Értékek_lbl.Location = new System.Drawing.Point(202, 44);
            this.Értékek_lbl.Name = "Értékek_lbl";
            this.Értékek_lbl.Size = new System.Drawing.Size(47, 13);
            this.Értékek_lbl.TabIndex = 1;
            this.Értékek_lbl.Text = "Értékek:";
            // 
            // A
            // 
            this.A.AutoSize = true;
            this.A.Location = new System.Drawing.Point(205, 64);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(33, 17);
            this.A.TabIndex = 2;
            this.A.Text = "A";
            this.A.UseVisualStyleBackColor = true;
            // 
            // B
            // 
            this.B.AutoSize = true;
            this.B.Location = new System.Drawing.Point(205, 87);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(33, 17);
            this.B.TabIndex = 3;
            this.B.Text = "B";
            this.B.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(138, 156);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(203, 20);
            this.textBox1.TabIndex = 4;
            // 
            // eredmeny_btn
            // 
            this.eredmeny_btn.Location = new System.Drawing.Point(12, 255);
            this.eredmeny_btn.Name = "eredmeny_btn";
            this.eredmeny_btn.Size = new System.Drawing.Size(325, 36);
            this.eredmeny_btn.TabIndex = 5;
            this.eredmeny_btn.Text = "Eredmény";
            this.eredmeny_btn.UseVisualStyleBackColor = true;
            // 
            // kommutativitas
            // 
            this.kommutativitas.AutoSize = true;
            this.kommutativitas.Location = new System.Drawing.Point(6, 19);
            this.kommutativitas.Name = "kommutativitas";
            this.kommutativitas.Size = new System.Drawing.Size(96, 17);
            this.kommutativitas.TabIndex = 6;
            this.kommutativitas.TabStop = true;
            this.kommutativitas.Text = "Kommutativitás";
            this.kommutativitas.UseVisualStyleBackColor = true;
            // 
            // asszociativitas
            // 
            this.asszociativitas.AutoSize = true;
            this.asszociativitas.Location = new System.Drawing.Point(6, 42);
            this.asszociativitas.Name = "asszociativitas";
            this.asszociativitas.Size = new System.Drawing.Size(94, 17);
            this.asszociativitas.TabIndex = 7;
            this.asszociativitas.TabStop = true;
            this.asszociativitas.Text = "Asszociativitás";
            this.asszociativitas.UseVisualStyleBackColor = true;
            // 
            // disztributivitas
            // 
            this.disztributivitas.AutoSize = true;
            this.disztributivitas.Location = new System.Drawing.Point(6, 65);
            this.disztributivitas.Name = "disztributivitas";
            this.disztributivitas.Size = new System.Drawing.Size(92, 17);
            this.disztributivitas.TabIndex = 8;
            this.disztributivitas.TabStop = true;
            this.disztributivitas.Text = "Disztributivitás";
            this.disztributivitas.UseVisualStyleBackColor = true;
            // 
            // logiakai_muveletek_box
            // 
            this.logiakai_muveletek_box.Controls.Add(this.muveletek_dropdown);
            this.logiakai_muveletek_box.Controls.Add(this.müveletek_lbl);
            this.logiakai_muveletek_box.Controls.Add(this.Értékek_lbl);
            this.logiakai_muveletek_box.Controls.Add(this.A);
            this.logiakai_muveletek_box.Controls.Add(this.B);
            this.logiakai_muveletek_box.Location = new System.Drawing.Point(12, 12);
            this.logiakai_muveletek_box.Name = "logiakai_muveletek_box";
            this.logiakai_muveletek_box.Size = new System.Drawing.Size(325, 131);
            this.logiakai_muveletek_box.TabIndex = 9;
            this.logiakai_muveletek_box.TabStop = false;
            this.logiakai_muveletek_box.Text = "Logikai Műveletek";
            // 
            // muveletek_dropdown
            // 
            this.muveletek_dropdown.FormattingEnabled = true;
            this.muveletek_dropdown.Location = new System.Drawing.Point(21, 64);
            this.muveletek_dropdown.Name = "muveletek_dropdown";
            this.muveletek_dropdown.Size = new System.Drawing.Size(121, 21);
            this.muveletek_dropdown.TabIndex = 1;
            // 
            // müveletek_lbl
            // 
            this.müveletek_lbl.AutoSize = true;
            this.müveletek_lbl.Location = new System.Drawing.Point(18, 44);
            this.müveletek_lbl.Name = "müveletek_lbl";
            this.müveletek_lbl.Size = new System.Drawing.Size(60, 13);
            this.müveletek_lbl.TabIndex = 0;
            this.müveletek_lbl.Text = "Műveletek:";
            // 
            // szabályok_box
            // 
            this.szabályok_box.Controls.Add(this.disztributivitas);
            this.szabályok_box.Controls.Add(this.kommutativitas);
            this.szabályok_box.Controls.Add(this.asszociativitas);
            this.szabályok_box.Location = new System.Drawing.Point(12, 149);
            this.szabályok_box.Name = "szabályok_box";
            this.szabályok_box.Size = new System.Drawing.Size(116, 100);
            this.szabályok_box.TabIndex = 10;
            this.szabályok_box.TabStop = false;
            this.szabályok_box.Text = "Szabályok:";
            // 
            // Logika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 307);
            this.Controls.Add(this.eredmeny_btn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.logiakai_muveletek_box);
            this.Controls.Add(this.szabályok_box);
            this.Name = "Logika";
            this.Text = "Logika";
            this.logiakai_muveletek_box.ResumeLayout(false);
            this.logiakai_muveletek_box.PerformLayout();
            this.szabályok_box.ResumeLayout(false);
            this.szabályok_box.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Értékek_lbl;
        private System.Windows.Forms.CheckBox A;
        private System.Windows.Forms.CheckBox B;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button eredmeny_btn;
        private System.Windows.Forms.RadioButton kommutativitas;
        private System.Windows.Forms.RadioButton asszociativitas;
        private System.Windows.Forms.RadioButton disztributivitas;
        private System.Windows.Forms.GroupBox logiakai_muveletek_box;
        private System.Windows.Forms.ComboBox muveletek_dropdown;
        private System.Windows.Forms.Label müveletek_lbl;
        private System.Windows.Forms.GroupBox szabályok_box;
    }
}

