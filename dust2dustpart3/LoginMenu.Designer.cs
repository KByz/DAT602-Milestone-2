namespace dust2dustpart3
{
    partial class LoginMenu : Form
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
            this.PageTitle = new System.Windows.Forms.Label();
            this.usernametb = new System.Windows.Forms.TextBox();
            this.passwordtb = new System.Windows.Forms.TextBox();
            this.usernamelbl = new System.Windows.Forms.Label();
            this.passwordlbl = new System.Windows.Forms.Label();
            this.Loginbtn = new System.Windows.Forms.Button();
            this.mainmenubtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PageTitle
            // 
            this.PageTitle.AutoSize = true;
            this.PageTitle.Font = new System.Drawing.Font("Stencil", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PageTitle.Location = new System.Drawing.Point(247, 9);
            this.PageTitle.Name = "PageTitle";
            this.PageTitle.Size = new System.Drawing.Size(335, 119);
            this.PageTitle.TabIndex = 0;
            this.PageTitle.Text = "LOGIN";
            // 
            // usernametb
            // 
            this.usernametb.Location = new System.Drawing.Point(368, 187);
            this.usernametb.Name = "usernametb";
            this.usernametb.Size = new System.Drawing.Size(197, 22);
            this.usernametb.TabIndex = 1;
            this.usernametb.TextChanged += new System.EventHandler(this.usernametb_TextChanged);
            // 
            // passwordtb
            // 
            this.passwordtb.Location = new System.Drawing.Point(368, 270);
            this.passwordtb.Name = "passwordtb";
            this.passwordtb.Size = new System.Drawing.Size(197, 22);
            this.passwordtb.TabIndex = 2;
            this.passwordtb.TextChanged += new System.EventHandler(this.password_TextChanged);
            // 
            // usernamelbl
            // 
            this.usernamelbl.AutoSize = true;
            this.usernamelbl.Font = new System.Drawing.Font("Playbill", 20F);
            this.usernamelbl.Location = new System.Drawing.Point(223, 176);
            this.usernamelbl.Name = "usernamelbl";
            this.usernamelbl.Size = new System.Drawing.Size(95, 34);
            this.usernamelbl.TabIndex = 3;
            this.usernamelbl.Text = "Username:";
            // 
            // passwordlbl
            // 
            this.passwordlbl.AutoSize = true;
            this.passwordlbl.Font = new System.Drawing.Font("Playbill", 20F);
            this.passwordlbl.Location = new System.Drawing.Point(223, 259);
            this.passwordlbl.Name = "passwordlbl";
            this.passwordlbl.Size = new System.Drawing.Size(94, 34);
            this.passwordlbl.TabIndex = 4;
            this.passwordlbl.Text = "Password:";
            // 
            // Loginbtn
            // 
            this.Loginbtn.Font = new System.Drawing.Font("Playbill", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loginbtn.Location = new System.Drawing.Point(368, 346);
            this.Loginbtn.Name = "Loginbtn";
            this.Loginbtn.Size = new System.Drawing.Size(122, 49);
            this.Loginbtn.TabIndex = 5;
            this.Loginbtn.Text = "Login";
            this.Loginbtn.UseVisualStyleBackColor = true;
            this.Loginbtn.Click += new System.EventHandler(this.Loginbtn_Click);
            // 
            // mainmenubtn
            // 
            this.mainmenubtn.Font = new System.Drawing.Font("Playbill", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainmenubtn.Location = new System.Drawing.Point(33, 346);
            this.mainmenubtn.Name = "mainmenubtn";
            this.mainmenubtn.Size = new System.Drawing.Size(124, 49);
            this.mainmenubtn.TabIndex = 6;
            this.mainmenubtn.Text = "Main Menu";
            this.mainmenubtn.UseVisualStyleBackColor = true;
            this.mainmenubtn.Click += new System.EventHandler(this.mainmenubtn_Click);
            // 
            // LoginMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainmenubtn);
            this.Controls.Add(this.Loginbtn);
            this.Controls.Add(this.passwordlbl);
            this.Controls.Add(this.usernamelbl);
            this.Controls.Add(this.passwordtb);
            this.Controls.Add(this.usernametb);
            this.Controls.Add(this.PageTitle);
            this.Name = "LoginMenu";
            this.Text = "LoginMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PageTitle;
        private System.Windows.Forms.TextBox usernametb;
        private System.Windows.Forms.TextBox passwordtb;
        private System.Windows.Forms.Label usernamelbl;
        private System.Windows.Forms.Label passwordlbl;
        private System.Windows.Forms.Button Loginbtn;
        private System.Windows.Forms.Button mainmenubtn;
    }
}