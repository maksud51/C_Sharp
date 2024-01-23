
namespace WindowsFormsApp1
{
    partial class HelloUI
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
            this.ShowButton = new System.Windows.Forms.Button();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.FirstNamelabel = new System.Windows.Forms.Label();
            this.MiddleNameLebel = new System.Windows.Forms.Label();
            this.middleNameTextBox = new System.Windows.Forms.TextBox();
            this.LastNameLebel = new System.Windows.Forms.Label();
            this.lastNametextBox = new System.Windows.Forms.TextBox();
            this.fullNameTextBox = new System.Windows.Forms.TextBox();
            this.fullNameLebel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ShowButton
            // 
            this.ShowButton.Location = new System.Drawing.Point(363, 289);
            this.ShowButton.Name = "ShowButton";
            this.ShowButton.Size = new System.Drawing.Size(75, 23);
            this.ShowButton.TabIndex = 3;
            this.ShowButton.Text = "Show Full Name";
            this.ShowButton.UseVisualStyleBackColor = true;
            this.ShowButton.Click += new System.EventHandler(this.ShowButton_Click);
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(205, 130);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(233, 22);
            this.firstNameTextBox.TabIndex = 0;
            // 
            // FirstNamelabel
            // 
            this.FirstNamelabel.AutoSize = true;
            this.FirstNamelabel.Location = new System.Drawing.Point(92, 134);
            this.FirstNamelabel.Name = "FirstNamelabel";
            this.FirstNamelabel.Size = new System.Drawing.Size(72, 17);
            this.FirstNamelabel.TabIndex = 2;
            this.FirstNamelabel.Text = "FirstName";
            // 
            // MiddleNameLebel
            // 
            this.MiddleNameLebel.AutoSize = true;
            this.MiddleNameLebel.Location = new System.Drawing.Point(83, 186);
            this.MiddleNameLebel.Name = "MiddleNameLebel";
            this.MiddleNameLebel.Size = new System.Drawing.Size(90, 17);
            this.MiddleNameLebel.TabIndex = 2;
            this.MiddleNameLebel.Text = "Middle Name";
            // 
            // middleNameTextBox
            // 
            this.middleNameTextBox.Location = new System.Drawing.Point(205, 186);
            this.middleNameTextBox.Name = "middleNameTextBox";
            this.middleNameTextBox.Size = new System.Drawing.Size(233, 22);
            this.middleNameTextBox.TabIndex = 1;
            // 
            // LastNameLebel
            // 
            this.LastNameLebel.AutoSize = true;
            this.LastNameLebel.Location = new System.Drawing.Point(83, 244);
            this.LastNameLebel.Name = "LastNameLebel";
            this.LastNameLebel.Size = new System.Drawing.Size(76, 17);
            this.LastNameLebel.TabIndex = 2;
            this.LastNameLebel.Text = "Last Name";
            // 
            // lastNametextBox
            // 
            this.lastNametextBox.Location = new System.Drawing.Point(205, 244);
            this.lastNametextBox.Name = "lastNametextBox";
            this.lastNametextBox.Size = new System.Drawing.Size(233, 22);
            this.lastNametextBox.TabIndex = 2;
            // 
            // fullNameTextBox
            // 
            this.fullNameTextBox.Location = new System.Drawing.Point(205, 333);
            this.fullNameTextBox.Name = "fullNameTextBox";
            this.fullNameTextBox.ReadOnly = true;
            this.fullNameTextBox.Size = new System.Drawing.Size(233, 22);
            this.fullNameTextBox.TabIndex = 4;
            // 
            // fullNameLebel
            // 
            this.fullNameLebel.AutoSize = true;
            this.fullNameLebel.Location = new System.Drawing.Point(83, 333);
            this.fullNameLebel.Name = "fullNameLebel";
            this.fullNameLebel.Size = new System.Drawing.Size(71, 17);
            this.fullNameLebel.TabIndex = 0;
            this.fullNameLebel.Text = "Full Name";
            // 
            // HelloUI
            // 
            this.AcceptButton = this.ShowButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 450);
            this.Controls.Add(this.fullNameLebel);
            this.Controls.Add(this.fullNameTextBox);
            this.Controls.Add(this.LastNameLebel);
            this.Controls.Add(this.lastNametextBox);
            this.Controls.Add(this.MiddleNameLebel);
            this.Controls.Add(this.middleNameTextBox);
            this.Controls.Add(this.FirstNamelabel);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.ShowButton);
            this.Name = "HelloUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ShowButton;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label FirstNamelabel;
        private System.Windows.Forms.Label MiddleNameLebel;
        private System.Windows.Forms.TextBox middleNameTextBox;
        private System.Windows.Forms.Label LastNameLebel;
        private System.Windows.Forms.TextBox lastNametextBox;
        private System.Windows.Forms.TextBox fullNameTextBox;
        private System.Windows.Forms.Label fullNameLebel;
    }
}

