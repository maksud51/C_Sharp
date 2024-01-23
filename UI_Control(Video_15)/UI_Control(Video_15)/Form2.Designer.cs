
namespace UI_Control_Video_15_
{
    partial class Form2
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
            this.dptComboBox = new System.Windows.Forms.ComboBox();
            this.addButton = new System.Windows.Forms.Button();
            this.dptListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // dptComboBox
            // 
            this.dptComboBox.FormattingEnabled = true;
            this.dptComboBox.Location = new System.Drawing.Point(228, 45);
            this.dptComboBox.Name = "dptComboBox";
            this.dptComboBox.Size = new System.Drawing.Size(288, 24);
            this.dptComboBox.TabIndex = 1;
            this.dptComboBox.Text = "Choose DPT";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(441, 89);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // dptListBox
            // 
            this.dptListBox.FormattingEnabled = true;
            this.dptListBox.ItemHeight = 16;
            this.dptListBox.Location = new System.Drawing.Point(351, 139);
            this.dptListBox.Name = "dptListBox";
            this.dptListBox.Size = new System.Drawing.Size(165, 100);
            this.dptListBox.TabIndex = 3;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dptListBox);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.dptComboBox);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox dptComboBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ListBox dptListBox;
    }
}