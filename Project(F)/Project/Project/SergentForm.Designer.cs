
namespace Project
{
    partial class SergentForm
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
            this.checkRegistration = new System.Windows.Forms.Button();
            this.alloteFine = new System.Windows.Forms.Button();
            this.speedBreakList = new System.Windows.Forms.Button();
            this.logOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(271, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sergent DeshBoard";
            // 
            // checkRegistration
            // 
            this.checkRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkRegistration.Location = new System.Drawing.Point(217, 236);
            this.checkRegistration.Name = "checkRegistration";
            this.checkRegistration.Size = new System.Drawing.Size(165, 75);
            this.checkRegistration.TabIndex = 1;
            this.checkRegistration.Text = "Check Registration";
            this.checkRegistration.UseVisualStyleBackColor = true;
            this.checkRegistration.Click += new System.EventHandler(this.checkRegistration_Click);
            // 
            // alloteFine
            // 
            this.alloteFine.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alloteFine.Location = new System.Drawing.Point(402, 236);
            this.alloteFine.Name = "alloteFine";
            this.alloteFine.Size = new System.Drawing.Size(165, 75);
            this.alloteFine.TabIndex = 2;
            this.alloteFine.Text = "Allote Fine";
            this.alloteFine.UseVisualStyleBackColor = true;
            this.alloteFine.Click += new System.EventHandler(this.alloteFine_Click);
            // 
            // speedBreakList
            // 
            this.speedBreakList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speedBreakList.Location = new System.Drawing.Point(309, 335);
            this.speedBreakList.Name = "speedBreakList";
            this.speedBreakList.Size = new System.Drawing.Size(165, 75);
            this.speedBreakList.TabIndex = 3;
            this.speedBreakList.Text = "Speed Break List";
            this.speedBreakList.UseVisualStyleBackColor = true;
            this.speedBreakList.Click += new System.EventHandler(this.speedBreakList_Click);
            // 
            // logOut
            // 
            this.logOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOut.Location = new System.Drawing.Point(689, 462);
            this.logOut.Name = "logOut";
            this.logOut.Size = new System.Drawing.Size(165, 75);
            this.logOut.TabIndex = 4;
            this.logOut.Text = "Log Out";
            this.logOut.UseVisualStyleBackColor = true;
            // 
            // SergentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 549);
            this.Controls.Add(this.logOut);
            this.Controls.Add(this.speedBreakList);
            this.Controls.Add(this.alloteFine);
            this.Controls.Add(this.checkRegistration);
            this.Controls.Add(this.label1);
            this.Name = "SergentForm";
            this.Text = "SergentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button checkRegistration;
        private System.Windows.Forms.Button alloteFine;
        private System.Windows.Forms.Button speedBreakList;
        private System.Windows.Forms.Button logOut;
    }
}