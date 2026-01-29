namespace Blackjack
{
    partial class Form2_startingpage
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
            this.loginBtn = new System.Windows.Forms.Button();
            this.checkAge = new System.Windows.Forms.CheckBox();
            this.betAmount = new System.Windows.Forms.NumericUpDown();
            this.bet = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.betAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // loginBtn
            // 
            this.loginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.loginBtn.Location = new System.Drawing.Point(59, 206);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(250, 82);
            this.loginBtn.TabIndex = 0;
            this.loginBtn.Text = "Start";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // checkAge
            // 
            this.checkAge.AutoSize = true;
            this.checkAge.Location = new System.Drawing.Point(138, 306);
            this.checkAge.Name = "checkAge";
            this.checkAge.Size = new System.Drawing.Size(78, 24);
            this.checkAge.TabIndex = 1;
            this.checkAge.Text = "I\'m 18";
            this.checkAge.UseVisualStyleBackColor = true;
            // 
            // betAmount
            // 
            this.betAmount.Location = new System.Drawing.Point(221, 146);
            this.betAmount.Name = "betAmount";
            this.betAmount.Size = new System.Drawing.Size(88, 26);
            this.betAmount.TabIndex = 2;
            // 
            // bet
            // 
            this.bet.AutoSize = true;
            this.bet.Location = new System.Drawing.Point(65, 149);
            this.bet.Name = "bet";
            this.bet.Size = new System.Drawing.Size(132, 20);
            this.bet.TabIndex = 3;
            this.bet.Text = "Your bet amount:";
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.title.Location = new System.Drawing.Point(34, 61);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(314, 55);
            this.title.TabIndex = 4;
            this.title.Text = "BLACKJACK";
            // 
            // Form2_startingpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 391);
            this.Controls.Add(this.title);
            this.Controls.Add(this.bet);
            this.Controls.Add(this.betAmount);
            this.Controls.Add(this.checkAge);
            this.Controls.Add(this.loginBtn);
            this.Name = "Form2_startingpage";
            this.Text = "Form2_startingpage";
            ((System.ComponentModel.ISupportInitialize)(this.betAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.CheckBox checkAge;
        private System.Windows.Forms.NumericUpDown betAmount;
        private System.Windows.Forms.Label bet;
        private System.Windows.Forms.Label title;
    }
}