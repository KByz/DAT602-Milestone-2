namespace dust2dustpart3
{
    partial class PlayerAccounts
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
            backbtn = new Button();
            removebtn = new Button();
            banbtn = new Button();
            deletebtn = new Button();
            accountsDGV = new DataGridView();
            editaccountbtn = new Button();
            unbanbtn = new Button();
            ((System.ComponentModel.ISupportInitialize)accountsDGV).BeginInit();
            SuspendLayout();
            // 
            // titlelbl
            // 
            titlelbl.AutoSize = true;
            titlelbl.Font = new Font("Stencil", 40.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            titlelbl.Location = new Point(89, 9);
            titlelbl.Name = "titlelbl";
            titlelbl.Size = new Size(626, 80);
            titlelbl.TabIndex = 0;
            titlelbl.Text = "PLAYER ACCOUNTS";
            // 
            // backbtn
            // 
            backbtn.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            backbtn.Location = new Point(599, 387);
            backbtn.Name = "backbtn";
            backbtn.Size = new Size(161, 29);
            backbtn.TabIndex = 1;
            backbtn.Text = "Back";
            backbtn.UseVisualStyleBackColor = true;
            backbtn.Click += backbtn_Click;
            // 
            // removebtn
            // 
            removebtn.Location = new Point(599, 156);
            removebtn.Name = "removebtn";
            removebtn.Size = new Size(161, 30);
            removebtn.TabIndex = 2;
            removebtn.Text = "Remove from game";
            removebtn.UseVisualStyleBackColor = true;
            // 
            // banbtn
            // 
            banbtn.Location = new Point(599, 258);
            banbtn.Name = "banbtn";
            banbtn.Size = new Size(161, 29);
            banbtn.TabIndex = 3;
            banbtn.Text = "Ban Account";
            banbtn.UseVisualStyleBackColor = true;
            banbtn.Click += banbtn_Click;
            // 
            // deletebtn
            // 
            deletebtn.Location = new Point(599, 209);
            deletebtn.Name = "deletebtn";
            deletebtn.Size = new Size(161, 29);
            deletebtn.TabIndex = 4;
            deletebtn.Text = "Delete Account";
            deletebtn.UseVisualStyleBackColor = true;
            deletebtn.Click += deletebtn_Click;
            // 
            // accountsDGV
            // 
            accountsDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            accountsDGV.Location = new Point(29, 92);
            accountsDGV.Name = "accountsDGV";
            accountsDGV.RowHeadersWidth = 51;
            accountsDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            accountsDGV.Size = new Size(542, 335);
            accountsDGV.TabIndex = 5;
            accountsDGV.CellContentClick += accountsDGV_CellContentClick;
            // 
            // editaccountbtn
            // 
            editaccountbtn.Location = new Point(599, 109);
            editaccountbtn.Name = "editaccountbtn";
            editaccountbtn.Size = new Size(161, 29);
            editaccountbtn.TabIndex = 6;
            editaccountbtn.Text = "Edit Account";
            editaccountbtn.UseVisualStyleBackColor = true;
            editaccountbtn.Click += editaccountbtn_Click;
            // 
            // unbanbtn
            // 
            unbanbtn.Location = new Point(603, 304);
            unbanbtn.Name = "unbanbtn";
            unbanbtn.Size = new Size(157, 29);
            unbanbtn.TabIndex = 7;
            unbanbtn.Text = "Unban Account";
            unbanbtn.UseVisualStyleBackColor = true;
            unbanbtn.Click += unbanbtn_Click;
            // 
            // PlayerAccounts
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(unbanbtn);
            Controls.Add(editaccountbtn);
            Controls.Add(accountsDGV);
            Controls.Add(deletebtn);
            Controls.Add(banbtn);
            Controls.Add(removebtn);
            Controls.Add(backbtn);
            Controls.Add(titlelbl);
            Name = "PlayerAccounts";
            Text = "PlayerAccounts";
            Load += PlayerAccounts_Load;
            ((System.ComponentModel.ISupportInitialize)accountsDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titlelbl;
        private Button backbtn;
        private Button removebtn;
        private Button banbtn;
        private Button deletebtn;
        private DataGridView accountsDGV;
        private Button editaccountbtn;
        private Button unbanbtn;
    }
}