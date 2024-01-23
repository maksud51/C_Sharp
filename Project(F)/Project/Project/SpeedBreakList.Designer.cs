
namespace Project
{
    partial class SpeedBreakList
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
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.takeAction = new System.Windows.Forms.Button();
            this.userName = new System.Windows.Forms.TextBox();
            this.signal = new System.Windows.Forms.TextBox();
            this.date = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(21, 43);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowHeadersWidth = 51;
            this.dataGrid.RowTemplate.Height = 24;
            this.dataGrid.Size = new System.Drawing.Size(474, 438);
            this.dataGrid.TabIndex = 0;
            this.dataGrid.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGrid_CellMouseDoubleClick);
            // 
            // takeAction
            // 
            this.takeAction.BackColor = System.Drawing.Color.Red;
            this.takeAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.takeAction.ForeColor = System.Drawing.Color.Black;
            this.takeAction.Location = new System.Drawing.Point(589, 286);
            this.takeAction.Name = "takeAction";
            this.takeAction.Size = new System.Drawing.Size(141, 35);
            this.takeAction.TabIndex = 4;
            this.takeAction.Text = "Take Action";
            this.takeAction.UseVisualStyleBackColor = false;
            this.takeAction.Click += new System.EventHandler(this.takeAction_Click);
            // 
            // userName
            // 
            this.userName.Location = new System.Drawing.Point(560, 226);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(203, 22);
            this.userName.TabIndex = 2;
            // 
            // signal
            // 
            this.signal.Location = new System.Drawing.Point(579, 131);
            this.signal.Name = "signal";
            this.signal.Size = new System.Drawing.Size(163, 22);
            this.signal.TabIndex = 1;
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(563, 73);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(200, 22);
            this.date.TabIndex = 5;
            // 
            // SpeedBreakList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 612);
            this.Controls.Add(this.date);
            this.Controls.Add(this.takeAction);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.signal);
            this.Controls.Add(this.dataGrid);
            this.Name = "SpeedBreakList";
            this.Text = "SpeedBreakList";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Button takeAction;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.TextBox signal;
        private System.Windows.Forms.DateTimePicker date;
    }
}