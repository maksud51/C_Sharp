
namespace Project
{
    partial class AlloteFineForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.alloteButton = new System.Windows.Forms.Button();
            this.caseReason = new System.Windows.Forms.TextBox();
            this.amount = new System.Windows.Forms.TextBox();
            this.signalPoint = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(454, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 32);
            this.label1.TabIndex = 8;
            this.label1.Text = "Allote Fine";
            // 
            // userName
            // 
            this.userName.Location = new System.Drawing.Point(512, 142);
            this.userName.Multiline = true;
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(242, 32);
            this.userName.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(371, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "User Name:";
            // 
            // alloteButton
            // 
            this.alloteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alloteButton.Location = new System.Drawing.Point(543, 560);
            this.alloteButton.Name = "alloteButton";
            this.alloteButton.Size = new System.Drawing.Size(184, 56);
            this.alloteButton.TabIndex = 5;
            this.alloteButton.Text = "Allote";
            this.alloteButton.UseVisualStyleBackColor = true;
            this.alloteButton.Click += new System.EventHandler(this.alloteButton_Click);
            // 
            // caseReason
            // 
            this.caseReason.Location = new System.Drawing.Point(512, 217);
            this.caseReason.Multiline = true;
            this.caseReason.Name = "caseReason";
            this.caseReason.Size = new System.Drawing.Size(242, 34);
            this.caseReason.TabIndex = 1;
            // 
            // amount
            // 
            this.amount.Location = new System.Drawing.Point(512, 301);
            this.amount.Multiline = true;
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(242, 38);
            this.amount.TabIndex = 2;
            // 
            // signalPoint
            // 
            this.signalPoint.Location = new System.Drawing.Point(512, 392);
            this.signalPoint.Multiline = true;
            this.signalPoint.Name = "signalPoint";
            this.signalPoint.Size = new System.Drawing.Size(242, 39);
            this.signalPoint.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(353, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Case Reason:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(402, 319);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Amount:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(364, 401);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Signal Point:";
            // 
            // Date
            // 
            this.Date.Location = new System.Drawing.Point(512, 469);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(242, 22);
            this.Date.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(364, 471);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Date:";
            // 
            // AlloteFineForm
            // 
            this.AcceptButton = this.alloteButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 628);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.signalPoint);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.caseReason);
            this.Controls.Add(this.alloteButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.label1);
            this.Name = "AlloteFineForm";
            this.Text = "AlloteFineForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button alloteButton;
        private System.Windows.Forms.TextBox caseReason;
        private System.Windows.Forms.TextBox amount;
        private System.Windows.Forms.TextBox signalPoint;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker Date;
        private System.Windows.Forms.Label label6;
    }
}