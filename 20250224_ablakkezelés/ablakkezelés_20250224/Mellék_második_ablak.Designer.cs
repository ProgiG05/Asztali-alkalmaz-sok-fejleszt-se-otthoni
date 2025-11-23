
namespace ablakkezelés_20250224
{
    partial class Mellék_második_ablak
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
            this.username = new System.Windows.Forms.Label();
            this.username_input = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.Label();
            this.btn_belépés = new System.Windows.Forms.Button();
            this.email_input = new System.Windows.Forms.TextBox();
            this.bezárás2 = new System.Windows.Forms.Button();
            this.ell = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.username.Location = new System.Drawing.Point(33, 37);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(125, 25);
            this.username.TabIndex = 0;
            this.username.Text = "Username:";
            // 
            // username_input
            // 
            this.username_input.Location = new System.Drawing.Point(38, 79);
            this.username_input.Name = "username_input";
            this.username_input.Size = new System.Drawing.Size(216, 20);
            this.username_input.TabIndex = 1;
            this.username_input.TextChanged += new System.EventHandler(this.username_input_TextChanged);
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.email.Location = new System.Drawing.Point(33, 127);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(77, 25);
            this.email.TabIndex = 2;
            this.email.Text = "Email:";
            // 
            // btn_belépés
            // 
            this.btn_belépés.BackColor = System.Drawing.Color.White;
            this.btn_belépés.Enabled = false;
            this.btn_belépés.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_belépés.Location = new System.Drawing.Point(38, 306);
            this.btn_belépés.Name = "btn_belépés";
            this.btn_belépés.Size = new System.Drawing.Size(216, 40);
            this.btn_belépés.TabIndex = 3;
            this.btn_belépés.Text = "Belépés";
            this.btn_belépés.UseVisualStyleBackColor = false;
            this.btn_belépés.Click += new System.EventHandler(this.belépés2_Click);
            // 
            // email_input
            // 
            this.email_input.Location = new System.Drawing.Point(38, 168);
            this.email_input.Name = "email_input";
            this.email_input.Size = new System.Drawing.Size(216, 20);
            this.email_input.TabIndex = 4;
            this.email_input.TextChanged += new System.EventHandler(this.email_input_TextChanged);
            // 
            // bezárás2
            // 
            this.bezárás2.BackColor = System.Drawing.Color.Black;
            this.bezárás2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bezárás2.ForeColor = System.Drawing.Color.White;
            this.bezárás2.Location = new System.Drawing.Point(38, 352);
            this.bezárás2.Name = "bezárás2";
            this.bezárás2.Size = new System.Drawing.Size(216, 40);
            this.bezárás2.TabIndex = 5;
            this.bezárás2.Text = "Bezár";
            this.bezárás2.UseVisualStyleBackColor = false;
            this.bezárás2.Click += new System.EventHandler(this.bezárás2_Click);
            // 
            // ell
            // 
            this.ell.BackColor = System.Drawing.Color.White;
            this.ell.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ell.Location = new System.Drawing.Point(38, 260);
            this.ell.Name = "ell";
            this.ell.Size = new System.Drawing.Size(216, 40);
            this.ell.TabIndex = 6;
            this.ell.Text = "Ellenőrzés";
            this.ell.UseVisualStyleBackColor = false;
            this.ell.Click += new System.EventHandler(this.ell_Click);
            // 
            // Mellék_második_ablak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 414);
            this.Controls.Add(this.ell);
            this.Controls.Add(this.bezárás2);
            this.Controls.Add(this.email_input);
            this.Controls.Add(this.btn_belépés);
            this.Controls.Add(this.email);
            this.Controls.Add(this.username_input);
            this.Controls.Add(this.username);
            this.Name = "Mellék_második_ablak";
            this.Text = "Mellék_második_ablak";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label username;
        private System.Windows.Forms.TextBox username_input;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Button btn_belépés;
        private System.Windows.Forms.TextBox email_input;
        private System.Windows.Forms.Button bezárás2;
        private System.Windows.Forms.Button ell;
    }
}