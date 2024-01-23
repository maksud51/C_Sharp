
namespace Projeect
{
    partial class UserPendingForm
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
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.send = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label1 = new System.Windows.Forms.Label();
            this.userName = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2GradientPanel2 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2ImageButton2 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.welcomTex = new Guna.UI2.WinForms.Guna2TextBox();
            this.text_Effect3 = new Projeect.Text_Effect();
            this.text_Effect1 = new Projeect.Text_Effect();
            this.message = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2GradientPanel1.SuspendLayout();
            this.guna2ShadowPanel1.SuspendLayout();
            this.guna2GradientPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.Controls.Add(this.guna2ShadowPanel1);
            this.guna2GradientPanel1.Controls.Add(this.text_Effect3);
            this.guna2GradientPanel1.Controls.Add(this.text_Effect1);
            this.guna2GradientPanel1.Controls.Add(this.guna2GradientPanel2);
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.MediumSeaGreen;
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.DarkSlateGray;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(-48, 1);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(1111, 645);
            this.guna2GradientPanel1.TabIndex = 1;
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.label2);
            this.guna2ShadowPanel1.Controls.Add(this.message);
            this.guna2ShadowPanel1.Controls.Add(this.send);
            this.guna2ShadowPanel1.Controls.Add(this.label1);
            this.guna2ShadowPanel1.Controls.Add(this.userName);
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(393, 184);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(57)))), ((int)(((byte)(77)))));
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(644, 389);
            this.guna2ShadowPanel1.TabIndex = 42;
            // 
            // send
            // 
            this.send.Animated = true;
            this.send.BorderColor = System.Drawing.Color.Transparent;
            this.send.BorderRadius = 20;
            this.send.BorderThickness = 3;
            this.send.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.send.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.send.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.send.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.send.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.send.FillColor = System.Drawing.Color.Navy;
            this.send.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.send.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.send.ForeColor = System.Drawing.Color.YellowGreen;
            this.send.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.send.IndicateFocus = true;
            this.send.Location = new System.Drawing.Point(256, 284);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(295, 55);
            this.send.TabIndex = 43;
            this.send.Text = "Send";
            this.send.UseTransparentBackground = true;
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(111, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 25);
            this.label1.TabIndex = 21;
            this.label1.Text = "Name:";
            // 
            // userName
            // 
            this.userName.Animated = true;
            this.userName.BorderRadius = 10;
            this.userName.BorderThickness = 3;
            this.userName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.userName.DefaultText = "";
            this.userName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.userName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.userName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.userName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.userName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.userName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.userName.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.userName.ForeColor = System.Drawing.Color.Black;
            this.userName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.userName.Location = new System.Drawing.Point(247, 66);
            this.userName.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.userName.Name = "userName";
            this.userName.PasswordChar = '\0';
            this.userName.PlaceholderForeColor = System.Drawing.Color.Gainsboro;
            this.userName.PlaceholderText = "User Name";
            this.userName.SelectedText = "";
            this.userName.Size = new System.Drawing.Size(315, 41);
            this.userName.TabIndex = 0;
            // 
            // guna2GradientPanel2
            // 
            this.guna2GradientPanel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientPanel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.guna2GradientPanel2.BorderRadius = 20;
            this.guna2GradientPanel2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.guna2GradientPanel2.BorderThickness = 8;
            this.guna2GradientPanel2.Controls.Add(this.guna2ImageButton2);
            this.guna2GradientPanel2.Controls.Add(this.welcomTex);
            this.guna2GradientPanel2.CustomBorderColor = System.Drawing.Color.Gray;
            this.guna2GradientPanel2.FillColor = System.Drawing.Color.SeaGreen;
            this.guna2GradientPanel2.FillColor2 = System.Drawing.Color.SlateBlue;
            this.guna2GradientPanel2.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.guna2GradientPanel2.Location = new System.Drawing.Point(0, 3);
            this.guna2GradientPanel2.Name = "guna2GradientPanel2";
            this.guna2GradientPanel2.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.guna2GradientPanel2.Size = new System.Drawing.Size(340, 642);
            this.guna2GradientPanel2.TabIndex = 10;
            // 
            // guna2ImageButton2
            // 
            this.guna2ImageButton2.AnimatedGIF = true;
            this.guna2ImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ImageButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.guna2ImageButton2.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton2.HoverState.ImageSize = new System.Drawing.Size(128, 128);
            this.guna2ImageButton2.Image = global::Projeect.Properties.Resources.CountDownTrafficLight;
            this.guna2ImageButton2.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton2.ImageRotate = 0F;
            this.guna2ImageButton2.ImageSize = new System.Drawing.Size(200, 200);
            this.guna2ImageButton2.IndicateFocus = true;
            this.guna2ImageButton2.Location = new System.Drawing.Point(57, 432);
            this.guna2ImageButton2.Margin = new System.Windows.Forms.Padding(0);
            this.guna2ImageButton2.Name = "guna2ImageButton2";
            this.guna2ImageButton2.Padding = new System.Windows.Forms.Padding(100);
            this.guna2ImageButton2.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton2.Size = new System.Drawing.Size(232, 210);
            this.guna2ImageButton2.TabIndex = 4;
            this.guna2ImageButton2.UseTransparentBackground = true;
            // 
            // welcomTex
            // 
            this.welcomTex.Animated = true;
            this.welcomTex.AutoRoundedCorners = true;
            this.welcomTex.BackColor = System.Drawing.Color.Transparent;
            this.welcomTex.BorderRadius = 45;
            this.welcomTex.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.welcomTex.BorderThickness = 3;
            this.welcomTex.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.welcomTex.DefaultText = "Welcom to ITCS";
            this.welcomTex.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.welcomTex.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.welcomTex.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.welcomTex.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.welcomTex.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.welcomTex.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.welcomTex.Font = new System.Drawing.Font("Bernard MT Condensed", 19.8F, System.Drawing.FontStyle.Bold);
            this.welcomTex.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.welcomTex.Location = new System.Drawing.Point(61, 27);
            this.welcomTex.Margin = new System.Windows.Forms.Padding(4);
            this.welcomTex.Name = "welcomTex";
            this.welcomTex.PasswordChar = '\0';
            this.welcomTex.PlaceholderText = "";
            this.welcomTex.ReadOnly = true;
            this.welcomTex.SelectedText = "";
            this.welcomTex.Size = new System.Drawing.Size(237, 92);
            this.welcomTex.TabIndex = 3;
            // 
            // text_Effect3
            // 
            this.text_Effect3.AutoSize = true;
            this.text_Effect3.BackColor = System.Drawing.Color.Transparent;
            this.text_Effect3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text_Effect3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_Effect3.ForeColor = System.Drawing.Color.Indigo;
            this.text_Effect3.Location = new System.Drawing.Point(360, 615);
            this.text_Effect3.Name = "text_Effect3";
            this.text_Effect3.Set_Speed = 5;
            this.text_Effect3.Size = new System.Drawing.Size(724, 30);
            this.text_Effect3.TabIndex = 41;
            this.text_Effect3.Text = "Develop By ITCS Team.Thank You For Use ITCS Application.Hotline: 0111-1221.";
            this.text_Effect3.UseCompatibleTextRendering = true;
            // 
            // text_Effect1
            // 
            this.text_Effect1.AutoSize = true;
            this.text_Effect1.BackColor = System.Drawing.Color.Transparent;
            this.text_Effect1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.text_Effect1.Font = new System.Drawing.Font("Elephant", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_Effect1.ForeColor = System.Drawing.Color.Navy;
            this.text_Effect1.Location = new System.Drawing.Point(360, 10);
            this.text_Effect1.Name = "text_Effect1";
            this.text_Effect1.Set_Speed = 5;
            this.text_Effect1.Size = new System.Drawing.Size(677, 53);
            this.text_Effect1.TabIndex = 3;
            this.text_Effect1.Text = "Intelligent Transport Contron System";
            this.text_Effect1.UseCompatibleTextRendering = true;
            // 
            // message
            // 
            this.message.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.message.Location = new System.Drawing.Point(247, 140);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(306, 96);
            this.message.TabIndex = 44;
            this.message.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(79, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 25);
            this.label2.TabIndex = 45;
            this.label2.Text = "Message:";
            // 
            // UserPendingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 655);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Name = "UserPendingForm";
            this.Text = "UserPendingForm";
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.guna2ShadowPanel1.PerformLayout();
            this.guna2GradientPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2GradientButton send;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox userName;
        private Text_Effect text_Effect3;
        private Text_Effect text_Effect1;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel2;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton2;
        private Guna.UI2.WinForms.Guna2TextBox welcomTex;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox message;
    }
}