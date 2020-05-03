namespace TuneSourceFinal
{
    partial class Signin
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
            this.components = new System.ComponentModel.Container();
            this.jDragControl1 = new JDragControl.JDragControl(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.login_username = new JMetroTextBox.JMetroTextBox();
            this.login_password = new JMetroTextBox.JMetroTextBox();
            this.sub_signin = new JThinButton.JThinButton();
            this.label11 = new System.Windows.Forms.Label();
            this.label112 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // jDragControl1
            // 
            this.jDragControl1.GetForm = this;
            this.jDragControl1.TargetControl = this.panel1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(417, 79);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(158, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "SIGN IN";
            // 
            // login_username
            // 
            this.login_username.BackColor = System.Drawing.Color.Transparent;
            this.login_username.BorderColor = System.Drawing.Color.DimGray;
            this.login_username.BorderRadius = 13;
            this.login_username.FillColor = System.Drawing.Color.White;
            this.login_username.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_username.Font_Size = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_username.ForeColors = System.Drawing.Color.Gray;
            this.login_username.IsPassword = false;
            this.login_username.LineThickness = 2;
            this.login_username.Location = new System.Drawing.Point(78, 153);
            this.login_username.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.login_username.MaxLength = 32767;
            this.login_username.MouseOnHover = System.Drawing.Color.Empty;
            this.login_username.Name = "login_username";
            this.login_username.OnCursor = System.Windows.Forms.Cursors.IBeam;
            this.login_username.OnFocusColor = System.Drawing.Color.Empty;
            this.login_username.OnFocusFontColor = System.Drawing.Color.Empty;
            this.login_username.ReadOnly = false;
            this.login_username.Size = new System.Drawing.Size(280, 45);
            this.login_username.TabIndex = 1;
            this.login_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.login_username.TextName = "";
            // 
            // login_password
            // 
            this.login_password.BackColor = System.Drawing.Color.Transparent;
            this.login_password.BorderColor = System.Drawing.Color.DimGray;
            this.login_password.BorderRadius = 13;
            this.login_password.FillColor = System.Drawing.Color.White;
            this.login_password.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_password.Font_Size = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_password.ForeColors = System.Drawing.Color.Gray;
            this.login_password.IsPassword = true;
            this.login_password.LineThickness = 2;
            this.login_password.Location = new System.Drawing.Point(78, 242);
            this.login_password.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.login_password.MaxLength = 32767;
            this.login_password.MouseOnHover = System.Drawing.Color.Empty;
            this.login_password.Name = "login_password";
            this.login_password.OnCursor = System.Windows.Forms.Cursors.IBeam;
            this.login_password.OnFocusColor = System.Drawing.Color.Empty;
            this.login_password.OnFocusFontColor = System.Drawing.Color.Empty;
            this.login_password.ReadOnly = false;
            this.login_password.Size = new System.Drawing.Size(280, 45);
            this.login_password.TabIndex = 2;
            this.login_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.login_password.TextName = "";
            // 
            // sub_signin
            // 
            this.sub_signin.BackColor = System.Drawing.Color.Transparent;
            this.sub_signin.BackgroundColor = System.Drawing.SystemColors.Highlight;
            this.sub_signin.BorderColor = System.Drawing.SystemColors.Highlight;
            this.sub_signin.BorderRadius = 20;
            this.sub_signin.ButtonText = "Submit";
            this.sub_signin.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sub_signin.Font_Size = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sub_signin.ForeColors = System.Drawing.Color.White;
            this.sub_signin.HoverBackground = System.Drawing.Color.White;
            this.sub_signin.HoverBorder = System.Drawing.Color.Empty;
            this.sub_signin.HoverFontColor = System.Drawing.SystemColors.Highlight;
            this.sub_signin.LineThickness = 2;
            this.sub_signin.Location = new System.Drawing.Point(152, 323);
            this.sub_signin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sub_signin.Name = "sub_signin";
            this.sub_signin.Size = new System.Drawing.Size(125, 43);
            this.sub_signin.TabIndex = 3;
            this.sub_signin.Click += new System.EventHandler(this.sub_signin_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DimGray;
            this.label11.Location = new System.Drawing.Point(84, 128);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 21);
            this.label11.TabIndex = 4;
            this.label11.Text = "Username";
            // 
            // label112
            // 
            this.label112.AutoSize = true;
            this.label112.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label112.ForeColor = System.Drawing.Color.DimGray;
            this.label112.Location = new System.Drawing.Point(84, 217);
            this.label112.Name = "label112";
            this.label112.Size = new System.Drawing.Size(77, 21);
            this.label112.TabIndex = 5;
            this.label112.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(151, 388);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Forget Password?";
            // 
            // Signin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(417, 418);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label112);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.sub_signin);
            this.Controls.Add(this.login_password);
            this.Controls.Add(this.login_username);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Signin";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private JDragControl.JDragControl jDragControl1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label112;
        private System.Windows.Forms.Label label11;
        private JThinButton.JThinButton sub_signin;
        private JMetroTextBox.JMetroTextBox login_password;
        private JMetroTextBox.JMetroTextBox login_username;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}

