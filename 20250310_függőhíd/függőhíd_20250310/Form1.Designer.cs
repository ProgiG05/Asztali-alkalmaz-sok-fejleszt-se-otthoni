
namespace függőhíd_20250310
{
    partial class Főoldal
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
            this.bezaras_btn = new System.Windows.Forms.Button();
            this.egykiló_check = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.kereses_btn = new System.Windows.Forms.Button();
            this.orszag_lista = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.hidak_lista = new System.Windows.Forms.ListBox();
            this.megnyitas_btn = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bezaras_btn
            // 
            this.bezaras_btn.BackColor = System.Drawing.Color.Black;
            this.bezaras_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bezaras_btn.ForeColor = System.Drawing.Color.White;
            this.bezaras_btn.Location = new System.Drawing.Point(17, 148);
            this.bezaras_btn.Name = "bezaras_btn";
            this.bezaras_btn.Size = new System.Drawing.Size(346, 37);
            this.bezaras_btn.TabIndex = 5;
            this.bezaras_btn.Text = "BEZÁRÁS";
            this.bezaras_btn.UseVisualStyleBackColor = false;
            this.bezaras_btn.Click += new System.EventHandler(this.bezaras_btn_Click);
            // 
            // egykiló_check
            // 
            this.egykiló_check.AutoSize = true;
            this.egykiló_check.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.egykiló_check.Location = new System.Drawing.Point(17, 70);
            this.egykiló_check.Name = "egykiló_check";
            this.egykiló_check.Size = new System.Drawing.Size(177, 20);
            this.egykiló_check.TabIndex = 3;
            this.egykiló_check.Text = "1km - nél hosszabbak";
            this.egykiló_check.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.egykiló_check.UseVisualStyleBackColor = true;
            this.egykiló_check.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(14, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ország:";
            // 
            // kereses_btn
            // 
            this.kereses_btn.BackColor = System.Drawing.Color.Black;
            this.kereses_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kereses_btn.ForeColor = System.Drawing.Color.White;
            this.kereses_btn.Location = new System.Drawing.Point(17, 105);
            this.kereses_btn.Name = "kereses_btn";
            this.kereses_btn.Size = new System.Drawing.Size(346, 37);
            this.kereses_btn.TabIndex = 4;
            this.kereses_btn.Text = "KERESÉS";
            this.kereses_btn.UseVisualStyleBackColor = false;
            this.kereses_btn.Click += new System.EventHandler(this.kereses_btn_Click);
            // 
            // orszag_lista
            // 
            this.orszag_lista.AllowDrop = true;
            this.orszag_lista.DropDownHeight = 100;
            this.orszag_lista.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.orszag_lista.FormattingEnabled = true;
            this.orszag_lista.IntegralHeight = false;
            this.orszag_lista.Location = new System.Drawing.Point(99, 31);
            this.orszag_lista.Name = "orszag_lista";
            this.orszag_lista.Size = new System.Drawing.Size(260, 23);
            this.orszag_lista.TabIndex = 1;
            this.orszag_lista.SelectedIndexChanged += new System.EventHandler(this.orszag_lista_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bezaras_btn);
            this.groupBox2.Controls.Add(this.egykiló_check);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.kereses_btn);
            this.groupBox2.Controls.Add(this.orszag_lista);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox2.Location = new System.Drawing.Point(12, 213);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(400, 199);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Keresés";
            // 
            // hidak_lista
            // 
            this.hidak_lista.FormattingEnabled = true;
            this.hidak_lista.Location = new System.Drawing.Point(12, 12);
            this.hidak_lista.Name = "hidak_lista";
            this.hidak_lista.Size = new System.Drawing.Size(400, 147);
            this.hidak_lista.TabIndex = 0;
            // 
            // megnyitas_btn
            // 
            this.megnyitas_btn.BackColor = System.Drawing.Color.Black;
            this.megnyitas_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.megnyitas_btn.ForeColor = System.Drawing.Color.White;
            this.megnyitas_btn.Location = new System.Drawing.Point(12, 170);
            this.megnyitas_btn.Name = "megnyitas_btn";
            this.megnyitas_btn.Size = new System.Drawing.Size(400, 30);
            this.megnyitas_btn.TabIndex = 6;
            this.megnyitas_btn.Text = "MEGNYITÁS";
            this.megnyitas_btn.UseVisualStyleBackColor = false;
            this.megnyitas_btn.Click += new System.EventHandler(this.megnyitas_btn_Click);
            // 
            // Főoldal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 445);
            this.Controls.Add(this.megnyitas_btn);
            this.Controls.Add(this.hidak_lista);
            this.Controls.Add(this.groupBox2);
            this.Name = "Főoldal";
            this.Text = "Függőhidak";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button bezaras_btn;
        private System.Windows.Forms.CheckBox egykiló_check;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button kereses_btn;
        private System.Windows.Forms.ComboBox orszag_lista;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox hidak_lista;
        private System.Windows.Forms.Button megnyitas_btn;
    }
}

