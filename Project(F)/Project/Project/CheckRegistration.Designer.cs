
namespace Project
{
    partial class CheckRegistration
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
            this.dataShow = new System.Windows.Forms.DataGridView();
            this.userName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataShow)).BeginInit();
            this.SuspendLayout();
            // 
            // dataShow
            // 
            this.dataShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataShow.Location = new System.Drawing.Point(26, 54);
            this.dataShow.Name = "dataShow";
            this.dataShow.RowHeadersWidth = 51;
            this.dataShow.RowTemplate.Height = 24;
            this.dataShow.Size = new System.Drawing.Size(437, 363);
            this.dataShow.TabIndex = 0;
            // 
            // userName
            // 
            this.userName.Location = new System.Drawing.Point(485, 122);
            this.userName.Multiline = true;
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(217, 38);
            this.userName.TabIndex = 1;

            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(482, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "User Name";
            // 
            // checkButton
            // 
            this.checkButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkButton.Location = new System.Drawing.Point(538, 166);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(108, 31);
            this.checkButton.TabIndex = 3;
            this.checkButton.Text = "Check";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // CheckRegistration
            // 
            this.AcceptButton = this.checkButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.dataShow);
            this.Name = "CheckRegistration";
            this.Text = "CheckRegistration";
            ((System.ComponentModel.ISupportInitialize)(this.dataShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataShow;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button checkButton;
    }
}