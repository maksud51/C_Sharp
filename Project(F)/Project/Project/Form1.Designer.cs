
namespace Project
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
            this.name = new System.Windows.Forms.TextBox();
            this.signUp = new System.Windows.Forms.Button();
            this.userName = new System.Windows.Forms.TextBox();
            this.pio = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.dob = new System.Windows.Forms.DateTimePicker();
            this.gender = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.number = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.userPictureButton = new System.Windows.Forms.Button();
            this.userPicture = new System.Windows.Forms.PictureBox();
            this.showPassword = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lkoginHere = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(347, 37);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(291, 22);
            this.name.TabIndex = 0;
            // 
            // signUp
            // 
            this.signUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUp.Location = new System.Drawing.Point(383, 544);
            this.signUp.Name = "signUp";
            this.signUp.Size = new System.Drawing.Size(209, 38);
            this.signUp.TabIndex = 9;
            this.signUp.Text = "Sign Up";
            this.signUp.UseVisualStyleBackColor = true;
            this.signUp.Click += new System.EventHandler(this.signUp_Click);
            // 
            // userName
            // 
            this.userName.Location = new System.Drawing.Point(347, 98);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(291, 22);
            this.userName.TabIndex = 1;
            // 
            // pio
            // 
            this.pio.Location = new System.Drawing.Point(347, 299);
            this.pio.Name = "pio";
            this.pio.Size = new System.Drawing.Size(291, 22);
            this.pio.TabIndex = 4;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(347, 369);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(291, 22);
            this.password.TabIndex = 5;
            this.password.UseSystemPasswordChar = true;
            // 
            // dob
            // 
            this.dob.Location = new System.Drawing.Point(347, 162);
            this.dob.Name = "dob";
            this.dob.Size = new System.Drawing.Size(291, 22);
            this.dob.TabIndex = 2;
            // 
            // gender
            // 
            this.gender.FormattingEnabled = true;
            this.gender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Others"});
            this.gender.Location = new System.Drawing.Point(347, 228);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(291, 24);
            this.gender.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(183, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Name: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(161, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "User Name: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(161, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Date Of Birth: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(161, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Gender: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(161, 299);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "PIO: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(161, 371);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Password: ";
            // 
            // number
            // 
            this.number.Location = new System.Drawing.Point(347, 430);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(291, 22);
            this.number.TabIndex = 6;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(347, 496);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(291, 22);
            this.email.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(161, 430);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Number: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(161, 496);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Email: ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.userPictureButton);
            this.panel1.Controls.Add(this.userPicture);
            this.panel1.Location = new System.Drawing.Point(654, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(359, 358);
            this.panel1.TabIndex = 8;
            // 
            // userPictureButton
            // 
            this.userPictureButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userPictureButton.Location = new System.Drawing.Point(96, 248);
            this.userPictureButton.Name = "userPictureButton";
            this.userPictureButton.Size = new System.Drawing.Size(150, 35);
            this.userPictureButton.TabIndex = 1;
            this.userPictureButton.Text = "Upload";
            this.userPictureButton.UseVisualStyleBackColor = true;
            this.userPictureButton.Click += new System.EventHandler(this.userPictureButton_Click);
            // 
            // userPicture
            // 
            this.userPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.userPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userPicture.Location = new System.Drawing.Point(77, 3);
            this.userPicture.Name = "userPicture";
            this.userPicture.Size = new System.Drawing.Size(185, 218);
            this.userPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userPicture.TabIndex = 0;
            this.userPicture.TabStop = false;
            // 
            // showPassword
            // 
            this.showPassword.AutoSize = true;
            this.showPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showPassword.Location = new System.Drawing.Point(496, 397);
            this.showPassword.Name = "showPassword";
            this.showPassword.Size = new System.Drawing.Size(142, 21);
            this.showPassword.TabIndex = 17;
            this.showPassword.Text = "Show Password";
            this.showPassword.UseVisualStyleBackColor = true;
            this.showPassword.CheckedChanged += new System.EventHandler(this.showPassword_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(310, 621);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(208, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "Have already an account ?";
            // 
            // lkoginHere
            // 
            this.lkoginHere.BackColor = System.Drawing.Color.SeaGreen;
            this.lkoginHere.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.lkoginHere.FlatAppearance.BorderSize = 0;
            this.lkoginHere.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkoginHere.Location = new System.Drawing.Point(545, 618);
            this.lkoginHere.Name = "lkoginHere";
            this.lkoginHere.Size = new System.Drawing.Size(120, 29);
            this.lkoginHere.TabIndex = 20;
            this.lkoginHere.Text = "Login Here";
            this.lkoginHere.UseVisualStyleBackColor = false;
            this.lkoginHere.Click += new System.EventHandler(this.lkoginHere_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.signUp;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(1025, 730);
            this.Controls.Add(this.lkoginHere);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.showPassword);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.email);
            this.Controls.Add(this.number);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.dob);
            this.Controls.Add(this.password);
            this.Controls.Add(this.pio);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.signUp);
            this.Controls.Add(this.name);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Button signUp;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.TextBox pio;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.DateTimePicker dob;
        private System.Windows.Forms.ComboBox gender;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox number;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button userPictureButton;
        private System.Windows.Forms.PictureBox userPicture;
        private System.Windows.Forms.CheckBox showPassword;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button lkoginHere;
    }
}

