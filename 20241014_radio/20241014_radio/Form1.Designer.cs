
namespace _20241014_radio
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
            this.lbl_szín = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lbl_piros = new System.Windows.Forms.Label();
            this.hScrollBarRed = new System.Windows.Forms.HScrollBar();
            this.hScrollBarGreen = new System.Windows.Forms.HScrollBar();
            this.hScrollBarBlue = new System.Windows.Forms.HScrollBar();
            this.lbl_kék = new System.Windows.Forms.Label();
            this.lbl_zöld = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_szín
            // 
            this.lbl_szín.AutoSize = true;
            this.lbl_szín.Font = new System.Drawing.Font("Broadway", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_szín.Location = new System.Drawing.Point(21, 33);
            this.lbl_szín.Name = "lbl_szín";
            this.lbl_szín.Size = new System.Drawing.Size(430, 17);
            this.lbl_szín.TabIndex = 0;
            this.lbl_szín.Text = "Az ablak háttérszínének véletlenszerü változtatása";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(95, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(267, 43);
            this.button1.TabIndex = 1;
            this.button1.Text = "Megváltoztat";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(95, 143);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(267, 45);
            this.button2.TabIndex = 2;
            this.button2.Text = "Időzített színváltás";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbl_piros
            // 
            this.lbl_piros.AutoSize = true;
            this.lbl_piros.Location = new System.Drawing.Point(92, 220);
            this.lbl_piros.Name = "lbl_piros";
            this.lbl_piros.Size = new System.Drawing.Size(30, 13);
            this.lbl_piros.TabIndex = 3;
            this.lbl_piros.Text = "Piros";
            // 
            // hScrollBarRed
            // 
            this.hScrollBarRed.Location = new System.Drawing.Point(164, 220);
            this.hScrollBarRed.Name = "hScrollBarRed";
            this.hScrollBarRed.Size = new System.Drawing.Size(198, 23);
            this.hScrollBarRed.TabIndex = 4;
            this.hScrollBarRed.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBarRed_Scroll);
            // 
            // hScrollBarGreen
            // 
            this.hScrollBarGreen.Location = new System.Drawing.Point(164, 262);
            this.hScrollBarGreen.Name = "hScrollBarGreen";
            this.hScrollBarGreen.Size = new System.Drawing.Size(198, 23);
            this.hScrollBarGreen.TabIndex = 5;
            this.hScrollBarGreen.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBarGreen_Scroll);
            // 
            // hScrollBarBlue
            // 
            this.hScrollBarBlue.Location = new System.Drawing.Point(164, 308);
            this.hScrollBarBlue.Name = "hScrollBarBlue";
            this.hScrollBarBlue.Size = new System.Drawing.Size(198, 23);
            this.hScrollBarBlue.TabIndex = 6;
            this.hScrollBarBlue.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBarBlue_Scroll);
            // 
            // lbl_kék
            // 
            this.lbl_kék.AutoSize = true;
            this.lbl_kék.Location = new System.Drawing.Point(92, 308);
            this.lbl_kék.Name = "lbl_kék";
            this.lbl_kék.Size = new System.Drawing.Size(26, 13);
            this.lbl_kék.TabIndex = 7;
            this.lbl_kék.Text = "Kék";
            // 
            // lbl_zöld
            // 
            this.lbl_zöld.AutoSize = true;
            this.lbl_zöld.Location = new System.Drawing.Point(92, 262);
            this.lbl_zöld.Name = "lbl_zöld";
            this.lbl_zöld.Size = new System.Drawing.Size(28, 13);
            this.lbl_zöld.TabIndex = 8;
            this.lbl_zöld.Text = "Zöld";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 537);
            this.Controls.Add(this.lbl_zöld);
            this.Controls.Add(this.lbl_kék);
            this.Controls.Add(this.hScrollBarBlue);
            this.Controls.Add(this.hScrollBarGreen);
            this.Controls.Add(this.hScrollBarRed);
            this.Controls.Add(this.lbl_piros);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_szín);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_szín;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbl_piros;
        private System.Windows.Forms.HScrollBar hScrollBarRed;
        private System.Windows.Forms.HScrollBar hScrollBarGreen;
        private System.Windows.Forms.HScrollBar hScrollBarBlue;
        private System.Windows.Forms.Label lbl_kék;
        private System.Windows.Forms.Label lbl_zöld;
    }
}

