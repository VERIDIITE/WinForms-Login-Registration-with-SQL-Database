namespace LoginAndRegistrationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Signup));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Signup_password = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Signup_close = new System.Windows.Forms.Label();
            this.Signup_loginhere = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Signup_showpass = new System.Windows.Forms.CheckBox();
            this.Signup_btn = new System.Windows.Forms.Button();
            this.Signup_username = new System.Windows.Forms.TextBox();
            this.labelemail = new System.Windows.Forms.Label();
            this.Signup_email = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Signup_password);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Signup_close);
            this.panel1.Controls.Add(this.Signup_loginhere);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Signup_showpass);
            this.panel1.Controls.Add(this.Signup_btn);
            this.panel1.Controls.Add(this.Signup_username);
            this.panel1.Controls.Add(this.labelemail);
            this.panel1.Controls.Add(this.Signup_email);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-3, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 605);
            this.panel1.TabIndex = 1;
            // 
            // Signup_password
            // 
            this.Signup_password.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Signup_password.Location = new System.Drawing.Point(425, 298);
            this.Signup_password.Multiline = true;
            this.Signup_password.Name = "Signup_password";
            this.Signup_password.PasswordChar = '*';
            this.Signup_password.Size = new System.Drawing.Size(305, 30);
            this.Signup_password.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(425, 272);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 23);
            this.label8.TabIndex = 13;
            this.label8.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(424, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 28);
            this.label1.TabIndex = 12;
            this.label1.Text = "Get Started!";
            // 
            // Signup_close
            // 
            this.Signup_close.AutoSize = true;
            this.Signup_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Signup_close.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Signup_close.Location = new System.Drawing.Point(775, 0);
            this.Signup_close.Name = "Signup_close";
            this.Signup_close.Size = new System.Drawing.Size(18, 23);
            this.Signup_close.TabIndex = 11;
            this.Signup_close.Text = "X";
            this.Signup_close.Click += new System.EventHandler(this.Signup_close_Click);
            // 
            // Signup_loginhere
            // 
            this.Signup_loginhere.AutoSize = true;
            this.Signup_loginhere.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Signup_loginhere.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Signup_loginhere.ForeColor = System.Drawing.Color.Gray;
            this.Signup_loginhere.Location = new System.Drawing.Point(625, 530);
            this.Signup_loginhere.Name = "Signup_loginhere";
            this.Signup_loginhere.Size = new System.Drawing.Size(75, 22);
            this.Signup_loginhere.TabIndex = 10;
            this.Signup_loginhere.Text = "Login Here";
            this.Signup_loginhere.Click += new System.EventHandler(this.Signup_loginhere_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(453, 530);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 22);
            this.label4.TabIndex = 9;
            this.label4.Text = "Already have an Account?";
            // 
            // Signup_showpass
            // 
            this.Signup_showpass.AutoSize = true;
            this.Signup_showpass.BackColor = System.Drawing.Color.Transparent;
            this.Signup_showpass.ForeColor = System.Drawing.Color.Gray;
            this.Signup_showpass.Location = new System.Drawing.Point(629, 345);
            this.Signup_showpass.Name = "Signup_showpass";
            this.Signup_showpass.Size = new System.Drawing.Size(102, 17);
            this.Signup_showpass.TabIndex = 8;
            this.Signup_showpass.Text = "Show Password";
            this.Signup_showpass.UseVisualStyleBackColor = false;
            this.Signup_showpass.CheckedChanged += new System.EventHandler(this.Signup_showpass_CheckedChanged);
            // 
            // Signup_btn
            // 
            this.Signup_btn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Signup_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Signup_btn.FlatAppearance.BorderSize = 0;
            this.Signup_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Signup_btn.Location = new System.Drawing.Point(425, 377);
            this.Signup_btn.Name = "Signup_btn";
            this.Signup_btn.Size = new System.Drawing.Size(100, 35);
            this.Signup_btn.TabIndex = 7;
            this.Signup_btn.Text = "SIGNUP";
            this.Signup_btn.UseVisualStyleBackColor = false;
            this.Signup_btn.Click += new System.EventHandler(this.Signup_btn_Click);
            // 
            // Signup_username
            // 
            this.Signup_username.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Signup_username.Location = new System.Drawing.Point(426, 228);
            this.Signup_username.Multiline = true;
            this.Signup_username.Name = "Signup_username";
            this.Signup_username.Size = new System.Drawing.Size(305, 30);
            this.Signup_username.TabIndex = 6;
            // 
            // labelemail
            // 
            this.labelemail.AutoSize = true;
            this.labelemail.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelemail.Location = new System.Drawing.Point(428, 129);
            this.labelemail.Name = "labelemail";
            this.labelemail.Size = new System.Drawing.Size(105, 23);
            this.labelemail.TabIndex = 4;
            this.labelemail.Text = "Email Address:";
            // 
            // Signup_email
            // 
            this.Signup_email.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Signup_email.Location = new System.Drawing.Point(425, 155);
            this.Signup_email.Multiline = true;
            this.Signup_email.Name = "Signup_email";
            this.Signup_email.Size = new System.Drawing.Size(305, 30);
            this.Signup_email.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(425, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Username:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(3, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(392, 604);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(138, 155);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 117);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(139, 285);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 42);
            this.label6.TabIndex = 0;
            this.label6.Text = "VERIDIITE";
            // 
            // Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 602);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Signup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Signup";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Signup_close;
        private System.Windows.Forms.Label Signup_loginhere;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox Signup_showpass;
        private System.Windows.Forms.Button Signup_btn;
        private System.Windows.Forms.TextBox Signup_username;
        private System.Windows.Forms.Label labelemail;
        private System.Windows.Forms.TextBox Signup_email;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Signup_password;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
    }
}