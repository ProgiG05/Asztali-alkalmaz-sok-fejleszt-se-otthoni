
namespace _20241014_radiogomb2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.kerület = new System.Windows.Forms.RadioButton();
            this.terület = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.sugar = new System.Windows.Forms.TextBox();
            this.lbl_eredmény = new System.Windows.Forms.Label();
            this.eredmény = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.kerület);
            this.groupBox1.Controls.Add(this.terület);
            this.groupBox1.Location = new System.Drawing.Point(50, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(235, 77);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Terület/Kerület";
            // 
            // kerület
            // 
            this.kerület.AutoSize = true;
            this.kerület.Checked = true;
            this.kerület.Location = new System.Drawing.Point(17, 53);
            this.kerület.Name = "kerület";
            this.kerület.Size = new System.Drawing.Size(58, 17);
            this.kerület.TabIndex = 2;
            this.kerület.TabStop = true;
            this.kerület.Text = "Kerület";
            this.kerület.UseVisualStyleBackColor = true;
            this.kerület.CheckedChanged += new System.EventHandler(this.kerület_CheckedChanged);
            // 
            // terület
            // 
            this.terület.AutoSize = true;
            this.terület.Location = new System.Drawing.Point(17, 30);
            this.terület.Name = "terület";
            this.terület.Size = new System.Drawing.Size(58, 17);
            this.terület.TabIndex = 1;
            this.terület.Text = "Terület";
            this.terület.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sugár";
            // 
            // sugar
            // 
            this.sugar.Location = new System.Drawing.Point(169, 137);
            this.sugar.Name = "sugar";
            this.sugar.Size = new System.Drawing.Size(100, 20);
            this.sugar.TabIndex = 2;
            // 
            // lbl_eredmény
            // 
            this.lbl_eredmény.AutoSize = true;
            this.lbl_eredmény.Location = new System.Drawing.Point(47, 184);
            this.lbl_eredmény.Name = "lbl_eredmény";
            this.lbl_eredmény.Size = new System.Drawing.Size(60, 13);
            this.lbl_eredmény.TabIndex = 3;
            this.lbl_eredmény.Text = "Eredmény: ";
            // 
            // eredmény
            // 
            this.eredmény.Location = new System.Drawing.Point(169, 177);
            this.eredmény.Name = "eredmény";
            this.eredmény.Size = new System.Drawing.Size(100, 20);
            this.eredmény.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(314, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 161);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(50, 220);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(447, 26);
            this.button1.TabIndex = 6;
            this.button1.Text = "Számol";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 310);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.eredmény);
            this.Controls.Add(this.lbl_eredmény);
            this.Controls.Add(this.sugar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton kerület;
        private System.Windows.Forms.RadioButton terület;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sugar;
        private System.Windows.Forms.Label lbl_eredmény;
        private System.Windows.Forms.TextBox eredmény;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}

