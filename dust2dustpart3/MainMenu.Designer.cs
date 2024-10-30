namespace dust2dustpart3
{
    partial class MainMenu : Form
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
            loginbtn = new Button();
            signupbtn = new Button();
            contactbtn = new Button();
            exitbtn = new Button();
            SuspendLayout();
            // 
            // titlelbl
            // 
            titlelbl.AutoSize = true;
            titlelbl.Font = new Font("Stencil", 60F);
            titlelbl.Location = new Point(110, 11);
            titlelbl.Name = "titlelbl";
            titlelbl.Size = new Size(603, 119);
            titlelbl.TabIndex = 0;
            titlelbl.Text = "DUST2DUST";
            // 
            // loginbtn
            // 
            loginbtn.Font = new Font("Playbill", 20F);
            loginbtn.Location = new Point(311, 198);
            loginbtn.Margin = new Padding(3, 4, 3, 4);
            loginbtn.Name = "loginbtn";
            loginbtn.Size = new Size(168, 68);
            loginbtn.TabIndex = 1;
            loginbtn.Text = "Login";
            loginbtn.UseVisualStyleBackColor = true;
            loginbtn.Click += loginbtn_Click;
            // 
            // signupbtn
            // 
            signupbtn.Font = new Font("Playbill", 20F);
            signupbtn.Location = new Point(311, 272);
            signupbtn.Margin = new Padding(3, 4, 3, 4);
            signupbtn.Name = "signupbtn";
            signupbtn.Size = new Size(168, 68);
            signupbtn.TabIndex = 2;
            signupbtn.Text = "Sign up";
            signupbtn.UseVisualStyleBackColor = true;
            signupbtn.Click += signupbtn_Click;
            // 
            // contactbtn
            // 
            contactbtn.Font = new Font("Playbill", 20F);
            contactbtn.Location = new Point(311, 348);
            contactbtn.Margin = new Padding(3, 4, 3, 4);
            contactbtn.Name = "contactbtn";
            contactbtn.Size = new Size(168, 68);
            contactbtn.TabIndex = 3;
            contactbtn.Text = "Contact Admin";
            contactbtn.UseVisualStyleBackColor = true;
            contactbtn.Click += contactbtn_Click;
            // 
            // exitbtn
            // 
            exitbtn.Font = new Font("Playbill", 20F);
            exitbtn.Location = new Point(311, 422);
            exitbtn.Margin = new Padding(3, 4, 3, 4);
            exitbtn.Name = "exitbtn";
            exitbtn.Size = new Size(168, 68);
            exitbtn.TabIndex = 4;
            exitbtn.Text = "Exit";
            exitbtn.UseVisualStyleBackColor = true;
            exitbtn.Click += exitbtn_Click_1;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 562);
            Controls.Add(exitbtn);
            Controls.Add(contactbtn);
            Controls.Add(signupbtn);
            Controls.Add(loginbtn);
            Controls.Add(titlelbl);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainMenu";
            Text = "MainMenu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label titlelbl;
        private System.Windows.Forms.Button loginbtn;
        private System.Windows.Forms.Button signupbtn;
        private System.Windows.Forms.Button contactbtn;
        private System.Windows.Forms.Button exitbtn;
    }
}