namespace dust2dustpart3
{
    partial class AccountMenu : Form
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
            this.titlelbl = new System.Windows.Forms.Label();
            this.playbtn = new System.Windows.Forms.Button();
            this.editbtn = new System.Windows.Forms.Button();
            this.exitbtn = new System.Windows.Forms.Button();
            this.adminbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titlelbl
            // 
            this.titlelbl.AutoSize = true;
            this.titlelbl.Font = new System.Drawing.Font("Stencil", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titlelbl.Location = new System.Drawing.Point(116, 9);
            this.titlelbl.Name = "titlelbl";
            this.titlelbl.Size = new System.Drawing.Size(603, 119);
            this.titlelbl.TabIndex = 0;
            this.titlelbl.Text = "DUST2DUST";
            // 
            // playbtn
            // 
            this.playbtn.Font = new System.Drawing.Font("Playbill", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playbtn.Location = new System.Drawing.Point(331, 145);
            this.playbtn.Name = "playbtn";
            this.playbtn.Size = new System.Drawing.Size(146, 49);
            this.playbtn.TabIndex = 1;
            this.playbtn.Text = "Play";
            this.playbtn.UseVisualStyleBackColor = true;
            // 
            // editbtn
            // 
            this.editbtn.Font = new System.Drawing.Font("Playbill", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editbtn.Location = new System.Drawing.Point(331, 212);
            this.editbtn.Name = "editbtn";
            this.editbtn.Size = new System.Drawing.Size(146, 49);
            this.editbtn.TabIndex = 2;
            this.editbtn.Text = "Edit Account";
            this.editbtn.UseVisualStyleBackColor = true;
            this.editbtn.Click += new System.EventHandler(this.editbtn_Click);
            // 
            // exitbtn
            // 
            this.exitbtn.Font = new System.Drawing.Font("Playbill", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitbtn.Location = new System.Drawing.Point(331, 361);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(146, 49);
            this.exitbtn.TabIndex = 3;
            this.exitbtn.Text = "Logout";
            this.exitbtn.UseVisualStyleBackColor = true;
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // adminbtn
            // 
            this.adminbtn.Font = new System.Drawing.Font("Playbill", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminbtn.Location = new System.Drawing.Point(331, 288);
            this.adminbtn.Name = "adminbtn";
            this.adminbtn.Size = new System.Drawing.Size(146, 49);
            this.adminbtn.TabIndex = 4;
            this.adminbtn.Text = "Admin Settings";
            this.adminbtn.UseVisualStyleBackColor = true;
            this.adminbtn.Click += new System.EventHandler(this.adminbtn_Click);
            // 
            // AccountMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.adminbtn);
            this.Controls.Add(this.exitbtn);
            this.Controls.Add(this.editbtn);
            this.Controls.Add(this.playbtn);
            this.Controls.Add(this.titlelbl);
            this.Name = "AccountMenu";
            this.Text = "AccountMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titlelbl;
        private System.Windows.Forms.Button playbtn;
        private System.Windows.Forms.Button editbtn;
        private System.Windows.Forms.Button exitbtn;
        private System.Windows.Forms.Button adminbtn;
    }
}