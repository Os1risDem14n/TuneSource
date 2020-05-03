namespace TuneSourceFinal
{
    partial class Signup
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label888 = new System.Windows.Forms.Label();
            this.label999 = new System.Windows.Forms.Label();
            this.sub_reg = new JThinButton.JThinButton();
            this.reg_pass = new JMetroTextBox.JMetroTextBox();
            this.reg_username = new JMetroTextBox.JMetroTextBox();
            this.label777 = new System.Windows.Forms.Label();
            this.reg_confpass = new JMetroTextBox.JMetroTextBox();
            this.label111 = new System.Windows.Forms.Label();
            this.reg_email = new JMetroTextBox.JMetroTextBox();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(483, 96);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(183, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "REGISTER";
            // 
            // label888
            // 
            this.label888.AutoSize = true;
            this.label888.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label888.ForeColor = System.Drawing.Color.DimGray;
            this.label888.Location = new System.Drawing.Point(107, 203);
            this.label888.Name = "label888";
            this.label888.Size = new System.Drawing.Size(77, 21);
            this.label888.TabIndex = 10;
            this.label888.Text = "Password";
            // 
            // label999
            // 
            this.label999.AutoSize = true;
            this.label999.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label999.ForeColor = System.Drawing.Color.DimGray;
            this.label999.Location = new System.Drawing.Point(107, 114);
            this.label999.Name = "label999";
            this.label999.Size = new System.Drawing.Size(81, 21);
            this.label999.TabIndex = 9;
            this.label999.Text = "Username";
            // 
            // sub_reg
            // 
            this.sub_reg.BackColor = System.Drawing.Color.Transparent;
            this.sub_reg.BackgroundColor = System.Drawing.SystemColors.Highlight;
            this.sub_reg.BorderColor = System.Drawing.SystemColors.Highlight;
            this.sub_reg.BorderRadius = 20;
            this.sub_reg.ButtonText = "Submit";
            this.sub_reg.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sub_reg.Font_Size = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sub_reg.ForeColors = System.Drawing.Color.White;
            this.sub_reg.HoverBackground = System.Drawing.Color.White;
            this.sub_reg.HoverBorder = System.Drawing.Color.Empty;
            this.sub_reg.HoverFontColor = System.Drawing.SystemColors.Highlight;
            this.sub_reg.LineThickness = 2;
            this.sub_reg.Location = new System.Drawing.Point(177, 520);
            this.sub_reg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sub_reg.Name = "sub_reg";
            this.sub_reg.Size = new System.Drawing.Size(125, 43);
            this.sub_reg.TabIndex = 8;
            this.sub_reg.Click += new System.EventHandler(this.jThinButton1_Click);
            // 
            // reg_pass
            // 
            this.reg_pass.BackColor = System.Drawing.Color.Transparent;
            this.reg_pass.BorderColor = System.Drawing.Color.DimGray;
            this.reg_pass.BorderRadius = 13;
            this.reg_pass.FillColor = System.Drawing.Color.White;
            this.reg_pass.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_pass.Font_Size = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_pass.ForeColors = System.Drawing.Color.Gray;
            this.reg_pass.IsPassword = true;
            this.reg_pass.LineThickness = 2;
            this.reg_pass.Location = new System.Drawing.Point(101, 228);
            this.reg_pass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.reg_pass.MaxLength = 32767;
            this.reg_pass.MouseOnHover = System.Drawing.Color.Empty;
            this.reg_pass.Name = "reg_pass";
            this.reg_pass.OnCursor = System.Windows.Forms.Cursors.IBeam;
            this.reg_pass.OnFocusColor = System.Drawing.Color.Empty;
            this.reg_pass.OnFocusFontColor = System.Drawing.Color.Empty;
            this.reg_pass.ReadOnly = false;
            this.reg_pass.Size = new System.Drawing.Size(280, 45);
            this.reg_pass.TabIndex = 7;
            this.reg_pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.reg_pass.TextName = "";
            // 
            // reg_username
            // 
            this.reg_username.BackColor = System.Drawing.Color.Transparent;
            this.reg_username.BorderColor = System.Drawing.Color.DimGray;
            this.reg_username.BorderRadius = 13;
            this.reg_username.FillColor = System.Drawing.Color.White;
            this.reg_username.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_username.Font_Size = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_username.ForeColors = System.Drawing.Color.Gray;
            this.reg_username.IsPassword = false;
            this.reg_username.LineThickness = 2;
            this.reg_username.Location = new System.Drawing.Point(101, 139);
            this.reg_username.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.reg_username.MaxLength = 32767;
            this.reg_username.MouseOnHover = System.Drawing.Color.Empty;
            this.reg_username.Name = "reg_username";
            this.reg_username.OnCursor = System.Windows.Forms.Cursors.IBeam;
            this.reg_username.OnFocusColor = System.Drawing.Color.Empty;
            this.reg_username.OnFocusFontColor = System.Drawing.Color.Empty;
            this.reg_username.ReadOnly = false;
            this.reg_username.Size = new System.Drawing.Size(280, 45);
            this.reg_username.TabIndex = 6;
            this.reg_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.reg_username.TextName = "";
            // 
            // label777
            // 
            this.label777.AutoSize = true;
            this.label777.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label777.ForeColor = System.Drawing.Color.DimGray;
            this.label777.Location = new System.Drawing.Point(107, 293);
            this.label777.Name = "label777";
            this.label777.Size = new System.Drawing.Size(138, 21);
            this.label777.TabIndex = 12;
            this.label777.Text = "Confirm Password";
            // 
            // reg_confpass
            // 
            this.reg_confpass.BackColor = System.Drawing.Color.Transparent;
            this.reg_confpass.BorderColor = System.Drawing.Color.DimGray;
            this.reg_confpass.BorderRadius = 13;
            this.reg_confpass.FillColor = System.Drawing.Color.White;
            this.reg_confpass.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_confpass.Font_Size = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_confpass.ForeColors = System.Drawing.Color.Gray;
            this.reg_confpass.IsPassword = true;
            this.reg_confpass.LineThickness = 2;
            this.reg_confpass.Location = new System.Drawing.Point(101, 318);
            this.reg_confpass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.reg_confpass.MaxLength = 32767;
            this.reg_confpass.MouseOnHover = System.Drawing.Color.Empty;
            this.reg_confpass.Name = "reg_confpass";
            this.reg_confpass.OnCursor = System.Windows.Forms.Cursors.IBeam;
            this.reg_confpass.OnFocusColor = System.Drawing.Color.Empty;
            this.reg_confpass.OnFocusFontColor = System.Drawing.Color.Empty;
            this.reg_confpass.ReadOnly = false;
            this.reg_confpass.Size = new System.Drawing.Size(280, 45);
            this.reg_confpass.TabIndex = 11;
            this.reg_confpass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.reg_confpass.TextName = "";
            // 
            // label111
            // 
            this.label111.AutoSize = true;
            this.label111.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label111.ForeColor = System.Drawing.Color.DimGray;
            this.label111.Location = new System.Drawing.Point(107, 382);
            this.label111.Name = "label111";
            this.label111.Size = new System.Drawing.Size(48, 21);
            this.label111.TabIndex = 14;
            this.label111.Text = "Email";
            // 
            // reg_email
            // 
            this.reg_email.BackColor = System.Drawing.Color.Transparent;
            this.reg_email.BorderColor = System.Drawing.Color.DimGray;
            this.reg_email.BorderRadius = 13;
            this.reg_email.FillColor = System.Drawing.Color.White;
            this.reg_email.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_email.Font_Size = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_email.ForeColors = System.Drawing.Color.Gray;
            this.reg_email.IsPassword = true;
            this.reg_email.LineThickness = 2;
            this.reg_email.Location = new System.Drawing.Point(101, 407);
            this.reg_email.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.reg_email.MaxLength = 32767;
            this.reg_email.MouseOnHover = System.Drawing.Color.Empty;
            this.reg_email.Name = "reg_email";
            this.reg_email.OnCursor = System.Windows.Forms.Cursors.IBeam;
            this.reg_email.OnFocusColor = System.Drawing.Color.Empty;
            this.reg_email.OnFocusFontColor = System.Drawing.Color.Empty;
            this.reg_email.ReadOnly = false;
            this.reg_email.Size = new System.Drawing.Size(280, 45);
            this.reg_email.TabIndex = 13;
            this.reg_email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.reg_email.TextName = "";
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox.ForeColor = System.Drawing.Color.DimGray;
            this.checkBox.Location = new System.Drawing.Point(71, 480);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(346, 20);
            this.checkBox.TabIndex = 15;
            this.checkBox.Text = "I agree with Tune Source Agreement and Privacy Policy";
            this.checkBox.UseVisualStyleBackColor = true;
            this.checkBox.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(483, 600);
            this.Controls.Add(this.checkBox);
            this.Controls.Add(this.label111);
            this.Controls.Add(this.reg_email);
            this.Controls.Add(this.label777);
            this.Controls.Add(this.reg_confpass);
            this.Controls.Add(this.label888);
            this.Controls.Add(this.label999);
            this.Controls.Add(this.sub_reg);
            this.Controls.Add(this.reg_pass);
            this.Controls.Add(this.reg_username);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Signup";
            this.Text = "Signup";
            this.Load += new System.EventHandler(this.Signup_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label888;
        private System.Windows.Forms.Label label999;
        private JThinButton.JThinButton sub_reg;
        private JMetroTextBox.JMetroTextBox reg_pass;
        private JMetroTextBox.JMetroTextBox reg_username;
        private System.Windows.Forms.Label label777;
        private JMetroTextBox.JMetroTextBox reg_confpass;
        private System.Windows.Forms.Label label111;
        private JMetroTextBox.JMetroTextBox reg_email;
        private System.Windows.Forms.CheckBox checkBox;
    }
}