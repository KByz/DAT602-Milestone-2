namespace dust2dustpart3
{
    partial class ActiveGames
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
            gamesDGV = new DataGridView();
            titlelbl = new Label();
            killbtn = new Button();
            backbtn = new Button();
            removeplayerbtn = new Button();
            ((System.ComponentModel.ISupportInitialize)gamesDGV).BeginInit();
            SuspendLayout();
            // 
            // gamesDGV
            // 
            gamesDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gamesDGV.Location = new Point(25, 111);
            gamesDGV.Name = "gamesDGV";
            gamesDGV.RowHeadersWidth = 51;
            gamesDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gamesDGV.Size = new Size(562, 311);
            gamesDGV.TabIndex = 0;
            gamesDGV.CellContentClick += gamesDGV_CellContentClick;
            // 
            // titlelbl
            // 
            titlelbl.AutoSize = true;
            titlelbl.Font = new Font("Stencil", 49.8000031F, FontStyle.Regular, GraphicsUnit.Point, 0);
            titlelbl.Location = new Point(92, 9);
            titlelbl.Name = "titlelbl";
            titlelbl.Size = new Size(613, 99);
            titlelbl.TabIndex = 1;
            titlelbl.Text = "ACTIVE GAMES";
            // 
            // killbtn
            // 
            killbtn.Location = new Point(611, 147);
            killbtn.Name = "killbtn";
            killbtn.Size = new Size(135, 29);
            killbtn.TabIndex = 2;
            killbtn.Text = "Kill game";
            killbtn.UseVisualStyleBackColor = true;
            killbtn.Click += this.killbtn_Click;
            // 
            // backbtn
            // 
            backbtn.Location = new Point(611, 283);
            backbtn.Name = "backbtn";
            backbtn.Size = new Size(135, 29);
            backbtn.TabIndex = 3;
            backbtn.Text = "Back";
            backbtn.UseVisualStyleBackColor = true;
            backbtn.Click += backbtn_Click;
            // 
            // removeplayerbtn
            // 
            removeplayerbtn.Location = new Point(611, 214);
            removeplayerbtn.Name = "removeplayerbtn";
            removeplayerbtn.Size = new Size(135, 29);
            removeplayerbtn.TabIndex = 4;
            removeplayerbtn.Text = "Remove player";
            removeplayerbtn.UseVisualStyleBackColor = true;
            // 
            // ActiveGames
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(removeplayerbtn);
            Controls.Add(backbtn);
            Controls.Add(killbtn);
            Controls.Add(titlelbl);
            Controls.Add(gamesDGV);
            Name = "ActiveGames";
            Text = "ActiveGamescs";
            ((System.ComponentModel.ISupportInitialize)gamesDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView gamesDGV;
        private Label titlelbl;
        private Button killbtn;
        private Button backbtn;
        private Button removeplayerbtn;
    }
}