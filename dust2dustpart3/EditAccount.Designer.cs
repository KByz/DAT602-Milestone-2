namespace dust2dustpart3
{
    partial class EditAccount : Form
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
            oldusernametb = new TextBox();
            newusernametb = new TextBox();
            newemailtb = new TextBox();
            newpasswordtb = new TextBox();
            Savebtn = new Button();
            oldusernamelbl = new Label();
            newfirstnametb = new TextBox();
            newusernamelbl = new Label();
            newemaillbl = new Label();
            newpasswordlbl = new Label();
            newnamelbl = new Label();
            accountmenubtn = new Button();
            SuspendLayout();
            // 
            // titlelbl
            // 
            titlelbl.AutoSize = true;
            titlelbl.Font = new Font("Stencil", 40.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            titlelbl.Location = new Point(163, 11);
            titlelbl.Name = "titlelbl";
            titlelbl.Size = new Size(491, 80);
            titlelbl.TabIndex = 0;
            titlelbl.Text = "EDIT ACCOUNT";
            // 
            // oldusernametb
            // 
            oldusernametb.Location = new Point(349, 158);
            oldusernametb.Margin = new Padding(3, 4, 3, 4);
            oldusernametb.Name = "oldusernametb";
            oldusernametb.Size = new Size(211, 27);
            oldusernametb.TabIndex = 1;
            oldusernametb.TextChanged += oldusernametb_TextChanged;
            // 
            // newusernametb
            // 
            newusernametb.Location = new Point(349, 230);
            newusernametb.Margin = new Padding(3, 4, 3, 4);
            newusernametb.Name = "newusernametb";
            newusernametb.Size = new Size(211, 27);
            newusernametb.TabIndex = 2;
            // 
            // newemailtb
            // 
            newemailtb.Location = new Point(349, 301);
            newemailtb.Margin = new Padding(3, 4, 3, 4);
            newemailtb.Name = "newemailtb";
            newemailtb.Size = new Size(211, 27);
            newemailtb.TabIndex = 3;
            // 
            // newpasswordtb
            // 
            newpasswordtb.Location = new Point(349, 364);
            newpasswordtb.Margin = new Padding(3, 4, 3, 4);
            newpasswordtb.Name = "newpasswordtb";
            newpasswordtb.Size = new Size(211, 27);
            newpasswordtb.TabIndex = 4;
            // 
            // Savebtn
            // 
            Savebtn.Font = new Font("Playbill", 19.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Savebtn.Location = new Point(358, 496);
            Savebtn.Margin = new Padding(3, 4, 3, 4);
            Savebtn.Name = "Savebtn";
            Savebtn.Size = new Size(107, 51);
            Savebtn.TabIndex = 5;
            Savebtn.Text = "Save";
            Savebtn.UseVisualStyleBackColor = true;
            Savebtn.Click += Savebtn_Click;
            // 
            // oldusernamelbl
            // 
            oldusernamelbl.AutoSize = true;
            oldusernamelbl.Font = new Font("Playbill", 19.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            oldusernamelbl.Location = new Point(150, 142);
            oldusernamelbl.Name = "oldusernamelbl";
            oldusernamelbl.Size = new Size(123, 33);
            oldusernamelbl.TabIndex = 6;
            oldusernamelbl.Text = "Old Username:";
            oldusernamelbl.Click += oldusernamelbl_Click;
            // 
            // newfirstnametb
            // 
            newfirstnametb.Location = new Point(349, 438);
            newfirstnametb.Margin = new Padding(3, 4, 3, 4);
            newfirstnametb.Name = "newfirstnametb";
            newfirstnametb.Size = new Size(211, 27);
            newfirstnametb.TabIndex = 7;
            // 
            // newusernamelbl
            // 
            newusernamelbl.AutoSize = true;
            newusernamelbl.Font = new Font("Playbill", 19.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            newusernamelbl.Location = new Point(149, 216);
            newusernamelbl.Name = "newusernamelbl";
            newusernamelbl.Size = new Size(133, 33);
            newusernamelbl.TabIndex = 8;
            newusernamelbl.Text = "New Username:";
            // 
            // newemaillbl
            // 
            newemaillbl.AutoSize = true;
            newemaillbl.Font = new Font("Playbill", 19.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            newemaillbl.Location = new Point(150, 288);
            newemaillbl.Name = "newemaillbl";
            newemaillbl.Size = new Size(104, 33);
            newemaillbl.TabIndex = 9;
            newemaillbl.Text = "New Email:";
            // 
            // newpasswordlbl
            // 
            newpasswordlbl.AutoSize = true;
            newpasswordlbl.Font = new Font("Playbill", 19.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            newpasswordlbl.Location = new Point(150, 350);
            newpasswordlbl.Name = "newpasswordlbl";
            newpasswordlbl.Size = new Size(131, 33);
            newpasswordlbl.TabIndex = 10;
            newpasswordlbl.Text = "New Password:";
            // 
            // newnamelbl
            // 
            newnamelbl.AutoSize = true;
            newnamelbl.Font = new Font("Playbill", 19.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            newnamelbl.Location = new Point(149, 424);
            newnamelbl.Name = "newnamelbl";
            newnamelbl.Size = new Size(149, 33);
            newnamelbl.TabIndex = 11;
            newnamelbl.Text = "New First Name:";
            // 
            // accountmenubtn
            // 
            accountmenubtn.Font = new Font("Playbill", 19.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            accountmenubtn.Location = new Point(24, 496);
            accountmenubtn.Margin = new Padding(3, 4, 3, 4);
            accountmenubtn.Name = "accountmenubtn";
            accountmenubtn.Size = new Size(107, 51);
            accountmenubtn.TabIndex = 12;
            accountmenubtn.Text = "Back";
            accountmenubtn.UseVisualStyleBackColor = true;
            accountmenubtn.Click += button1_Click;
            // 
            // EditAccount
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 562);
            Controls.Add(accountmenubtn);
            Controls.Add(newnamelbl);
            Controls.Add(newpasswordlbl);
            Controls.Add(newemaillbl);
            Controls.Add(newusernamelbl);
            Controls.Add(newfirstnametb);
            Controls.Add(oldusernamelbl);
            Controls.Add(Savebtn);
            Controls.Add(newpasswordtb);
            Controls.Add(newemailtb);
            Controls.Add(newusernametb);
            Controls.Add(oldusernametb);
            Controls.Add(titlelbl);
            Margin = new Padding(3, 4, 3, 4);
            Name = "EditAccount";
            Text = "EditAccount";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label titlelbl;
        private System.Windows.Forms.TextBox oldusernametb;
        private System.Windows.Forms.TextBox newusernametb;
        private System.Windows.Forms.TextBox newemailtb;
        private System.Windows.Forms.TextBox newpasswordtb;
        private System.Windows.Forms.Button Savebtn;
        private System.Windows.Forms.Label oldusernamelbl;
        private System.Windows.Forms.TextBox newfirstnametb;
        private System.Windows.Forms.Label newusernamelbl;
        private System.Windows.Forms.Label newemaillbl;
        private System.Windows.Forms.Label newpasswordlbl;
        private System.Windows.Forms.Label newnamelbl;
        private System.Windows.Forms.Button accountmenubtn;
    }
}