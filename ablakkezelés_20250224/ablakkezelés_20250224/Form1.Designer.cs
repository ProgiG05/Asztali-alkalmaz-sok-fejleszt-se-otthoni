
namespace ablakkezelés_20250224
{
    partial class frm_Főablak
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Főablak));
            this.btn_belépés = new System.Windows.Forms.Button();
            this.btn_kilépés = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_belépés
            // 
            this.btn_belépés.BackColor = System.Drawing.Color.White;
            this.btn_belépés.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_belépés.ForeColor = System.Drawing.Color.Black;
            this.btn_belépés.Location = new System.Drawing.Point(12, 261);
            this.btn_belépés.Name = "btn_belépés";
            this.btn_belépés.Size = new System.Drawing.Size(298, 47);
            this.btn_belépés.TabIndex = 0;
            this.btn_belépés.Text = "Belépés";
            this.btn_belépés.UseVisualStyleBackColor = false;
            this.btn_belépés.Click += new System.EventHandler(this.btn_belépés_Click);
            // 
            // btn_kilépés
            // 
            this.btn_kilépés.BackColor = System.Drawing.Color.Black;
            this.btn_kilépés.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_kilépés.ForeColor = System.Drawing.Color.White;
            this.btn_kilépés.Location = new System.Drawing.Point(12, 314);
            this.btn_kilépés.Name = "btn_kilépés";
            this.btn_kilépés.Size = new System.Drawing.Size(298, 47);
            this.btn_kilépés.TabIndex = 1;
            this.btn_kilépés.Text = "Kilépés";
            this.btn_kilépés.UseVisualStyleBackColor = false;
            this.btn_kilépés.Click += new System.EventHandler(this.btn_kilépés_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(298, 232);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // frm_Főablak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 386);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_kilépés);
            this.Controls.Add(this.btn_belépés);
            this.Name = "frm_Főablak";
            this.Text = "Főablak";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_belépés;
        private System.Windows.Forms.Button btn_kilépés;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

