namespace dust2dustpart3
{
    partial class SignUpMenu : Form
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
            titlelbl = new Label();
            usernametb = new TextBox();
            emailtb = new TextBox();
            passwordtb = new TextBox();
            firstnametb = new TextBox();
            usernamelbl = new Label();
            emaillbl = new Label();
            Passwordlbl = new Label();
            FirstNamelbl = new Label();
            signupbtn = new Button();
            mainmenubtn = new Button();
            SuspendLayout();
            // 
            // titlelbl
            // 
            titlelbl.AutoSize = true;
            titlelbl.Font = new Font("Stencil", 60F, FontStyle.Regular, GraphicsUnit.Point, 0);
            titlelbl.Location = new Point(188, 11);
            titlelbl.Name = "titlelbl";
            titlelbl.Size = new Size(432, 119);
            titlelbl.TabIndex = 0;
            titlelbl.Text = "SIGN UP";
            titlelbl.Click += label1_Click;
            // 
            // usernametb
            // 
            usernametb.Location = new Point(381, 192);
            usernametb.Margin = new Padding(3, 4, 3, 4);
            usernametb.Name = "usernametb";
            usernametb.Size = new Size(216, 27);
            usernametb.TabIndex = 1;
            // 
            // emailtb
            // 
            emailtb.Location = new Point(381, 258);
            emailtb.Margin = new Padding(3, 4, 3, 4);
            emailtb.Name = "emailtb";
            emailtb.Size = new Size(216, 27);
            emailtb.TabIndex = 2;
            // 
            // passwordtb
            // 
            passwordtb.Location = new Point(381, 332);
            passwordtb.Margin = new Padding(3, 4, 3, 4);
            passwordtb.Name = "passwordtb";
            passwordtb.Size = new Size(216, 27);
            passwordtb.TabIndex = 3;
            // 
            // firstnametb
            // 
            firstnametb.Location = new Point(381, 408);
            firstnametb.Margin = new Padding(3, 4, 3, 4);
            firstnametb.Name = "firstnametb";
            firstnametb.Size = new Size(216, 27);
            firstnametb.TabIndex = 4;
            firstnametb.TextChanged += firstnametb_TextChanged;
            // 
            // usernamelbl
            // 
            usernamelbl.AutoSize = true;
            usernamelbl.Font = new Font("Playbill", 19.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernamelbl.Location = new Point(191, 178);
            usernamelbl.Name = "usernamelbl";
            usernamelbl.Size = new Size(90, 33);
            usernamelbl.TabIndex = 5;
            usernamelbl.Text = "Username:";
            usernamelbl.Click += label2_Click;
            // 
            // emaillbl
            // 
            emaillbl.AutoSize = true;
            emaillbl.Font = new Font("Playbill", 19.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emaillbl.Location = new Point(192, 244);
            emaillbl.Name = "emaillbl";
            emaillbl.Size = new Size(127, 33);
            emaillbl.TabIndex = 6;
            emaillbl.Text = "Email Address:";
            // 
            // Passwordlbl
            // 
            Passwordlbl.AutoSize = true;
            Passwordlbl.Font = new Font("Playbill", 19.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Passwordlbl.Location = new Point(192, 319);
            Passwordlbl.Name = "Passwordlbl";
            Passwordlbl.Size = new Size(88, 33);
            Passwordlbl.TabIndex = 7;
            Passwordlbl.Text = "Password:";
            // 
            // FirstNamelbl
            // 
            FirstNamelbl.AutoSize = true;
            FirstNamelbl.Font = new Font("Playbill", 19.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FirstNamelbl.Location = new Point(192, 394);
            FirstNamelbl.Name = "FirstNamelbl";
            FirstNamelbl.Size = new Size(106, 33);
            FirstNamelbl.TabIndex = 8;
            FirstNamelbl.Text = "First Name:";
            FirstNamelbl.Click += label2_Click_1;
            // 
            // signupbtn
            // 
            signupbtn.Font = new Font("Playbill", 19.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signupbtn.Location = new Point(314, 495);
            signupbtn.Margin = new Padding(3, 4, 3, 4);
            signupbtn.Name = "signupbtn";
            signupbtn.Size = new Size(189, 52);
            signupbtn.TabIndex = 9;
            signupbtn.Text = "Create Account";
            signupbtn.UseVisualStyleBackColor = true;
            signupbtn.Click += signupbtn_Click;
            // 
            // mainmenubtn
            // 
            mainmenubtn.Font = new Font("Playbill", 19.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mainmenubtn.Location = new Point(21, 495);
            mainmenubtn.Margin = new Padding(3, 4, 3, 4);
            mainmenubtn.Name = "mainmenubtn";
            mainmenubtn.Size = new Size(189, 52);
            mainmenubtn.TabIndex = 10;
            mainmenubtn.Text = "Main Menu";
            mainmenubtn.UseVisualStyleBackColor = true;
            mainmenubtn.Click += mainmenubtn_Click;
            // 
            // SignUpMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 562);
            Controls.Add(mainmenubtn);
            Controls.Add(signupbtn);
            Controls.Add(FirstNamelbl);
            Controls.Add(Passwordlbl);
            Controls.Add(emaillbl);
            Controls.Add(usernamelbl);
            Controls.Add(firstnametb);
            Controls.Add(passwordtb);
            Controls.Add(emailtb);
            Controls.Add(usernametb);
            Controls.Add(titlelbl);
            Margin = new Padding(3, 4, 3, 4);
            Name = "SignUpMenu";
            Text = "SignUpMenu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label titlelbl;
        private System.Windows.Forms.TextBox usernametb;
        private System.Windows.Forms.TextBox emailtb;
        private System.Windows.Forms.TextBox passwordtb;
        private System.Windows.Forms.TextBox firstnametb;
        private System.Windows.Forms.Label usernamelbl;
        private System.Windows.Forms.Label emaillbl;
        private System.Windows.Forms.Label Passwordlbl;
        private System.Windows.Forms.Label FirstNamelbl;
        private System.Windows.Forms.Button signupbtn;
        private System.Windows.Forms.Button mainmenubtn;
    }
}