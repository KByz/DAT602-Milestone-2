namespace dust2dustpart3
{
    partial class AdminWindow : Form
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
            label1 = new Label();
            gamesbtn = new Button();
            allaccountsbtn = new Button();
            signupbtn = new Button();
            exitbtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 60F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(224, 11);
            label1.Name = "label1";
            label1.Size = new Size(362, 119);
            label1.TabIndex = 0;
            label1.Text = "ADMIN";
            // 
            // gamesbtn
            // 
            gamesbtn.Font = new Font("Playbill", 19.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gamesbtn.Location = new Point(317, 181);
            gamesbtn.Margin = new Padding(3, 4, 3, 4);
            gamesbtn.Name = "gamesbtn";
            gamesbtn.Size = new Size(166, 58);
            gamesbtn.TabIndex = 1;
            gamesbtn.Text = "Active Games";
            gamesbtn.UseVisualStyleBackColor = true;
            gamesbtn.Click += gamesbtn_Click;
            // 
            // allaccountsbtn
            // 
            allaccountsbtn.Font = new Font("Playbill", 19.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            allaccountsbtn.Location = new Point(317, 266);
            allaccountsbtn.Margin = new Padding(3, 4, 3, 4);
            allaccountsbtn.Name = "allaccountsbtn";
            allaccountsbtn.Size = new Size(166, 58);
            allaccountsbtn.TabIndex = 2;
            allaccountsbtn.Text = "Player Accounts";
            allaccountsbtn.UseVisualStyleBackColor = true;
            allaccountsbtn.Click += allaccountsbtn_Click;
            // 
            // signupbtn
            // 
            signupbtn.Font = new Font("Playbill", 19.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signupbtn.Location = new Point(317, 350);
            signupbtn.Margin = new Padding(3, 4, 3, 4);
            signupbtn.Name = "signupbtn";
            signupbtn.Size = new Size(166, 58);
            signupbtn.TabIndex = 3;
            signupbtn.Text = "Create Account";
            signupbtn.UseVisualStyleBackColor = true;
            signupbtn.Click += signupbtn_Click;
            // 
            // exitbtn
            // 
            exitbtn.Font = new Font("Playbill", 19.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            exitbtn.Location = new Point(317, 435);
            exitbtn.Margin = new Padding(3, 4, 3, 4);
            exitbtn.Name = "exitbtn";
            exitbtn.Size = new Size(166, 58);
            exitbtn.TabIndex = 4;
            exitbtn.Text = "Exit";
            exitbtn.UseVisualStyleBackColor = true;
            exitbtn.Click += exitbtn_Click;
            // 
            // AdminWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 562);
            Controls.Add(exitbtn);
            Controls.Add(signupbtn);
            Controls.Add(allaccountsbtn);
            Controls.Add(gamesbtn);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AdminWindow";
            Text = "AdminWindow";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button gamesbtn;
        private System.Windows.Forms.Button allaccountsbtn;
        private System.Windows.Forms.Button signupbtn;
        private System.Windows.Forms.Button exitbtn;
    }
}