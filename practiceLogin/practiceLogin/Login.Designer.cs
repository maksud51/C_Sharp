
namespace practiceLogin
{
    partial class Login
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
            this.nameLogin = new System.Windows.Forms.TextBox();
            this.passTextBox1 = new System.Windows.Forms.TextBox();
            this.LogInProfile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameLogin
            // 
            this.nameLogin.Location = new System.Drawing.Point(228, 44);
            this.nameLogin.Name = "nameLogin";
            this.nameLogin.Size = new System.Drawing.Size(301, 22);
            this.nameLogin.TabIndex = 2;
            // 
            // passTextBox1
            // 
            this.passTextBox1.Location = new System.Drawing.Point(228, 110);
            this.passTextBox1.Name = "passTextBox1";
            this.passTextBox1.Size = new System.Drawing.Size(301, 22);
            this.passTextBox1.TabIndex = 3;
            // 
            // LogInProfile
            // 
            this.LogInProfile.Location = new System.Drawing.Point(356, 183);
            this.LogInProfile.Name = "LogInProfile";
            this.LogInProfile.Size = new System.Drawing.Size(75, 23);
            this.LogInProfile.TabIndex = 4;
            this.LogInProfile.Text = "Login";
            this.LogInProfile.UseVisualStyleBackColor = true;
            this.LogInProfile.Click += new System.EventHandler(this.LogInProfile_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LogInProfile);
            this.Controls.Add(this.passTextBox1);
            this.Controls.Add(this.nameLogin);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameLogin;
        private System.Windows.Forms.TextBox passTextBox1;
        private System.Windows.Forms.Button LogInProfile;
    }
}