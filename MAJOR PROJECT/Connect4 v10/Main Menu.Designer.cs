namespace Connect4_v10
{
    partial class Main_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Menu));
            this.Singleplayer = new System.Windows.Forms.Button();
            this.Multiplayer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.loadGame = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gameName = new System.Windows.Forms.Label();
            this.ld = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Singleplayer
            // 
            this.Singleplayer.BackColor = System.Drawing.Color.White;
            this.Singleplayer.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Singleplayer.ForeColor = System.Drawing.Color.Black;
            this.Singleplayer.Location = new System.Drawing.Point(26, 85);
            this.Singleplayer.Name = "Singleplayer";
            this.Singleplayer.Size = new System.Drawing.Size(232, 56);
            this.Singleplayer.TabIndex = 0;
            this.Singleplayer.Text = "Singleplayer";
            this.Singleplayer.UseVisualStyleBackColor = false;
            this.Singleplayer.Click += new System.EventHandler(this.Singleplayer_Click);
            // 
            // Multiplayer
            // 
            this.Multiplayer.BackColor = System.Drawing.Color.White;
            this.Multiplayer.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Multiplayer.ForeColor = System.Drawing.Color.Black;
            this.Multiplayer.Location = new System.Drawing.Point(26, 157);
            this.Multiplayer.Name = "Multiplayer";
            this.Multiplayer.Size = new System.Drawing.Size(232, 56);
            this.Multiplayer.TabIndex = 1;
            this.Multiplayer.Text = "Multiplayer";
            this.Multiplayer.UseVisualStyleBackColor = false;
            this.Multiplayer.Click += new System.EventHandler(this.Multiplayer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(69, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Connect 4";
            // 
            // loadGame
            // 
            this.loadGame.BackColor = System.Drawing.Color.White;
            this.loadGame.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadGame.ForeColor = System.Drawing.Color.Black;
            this.loadGame.Location = new System.Drawing.Point(26, 230);
            this.loadGame.Name = "loadGame";
            this.loadGame.Size = new System.Drawing.Size(232, 56);
            this.loadGame.TabIndex = 3;
            this.loadGame.Text = "Load Game";
            this.loadGame.UseVisualStyleBackColor = false;
            this.loadGame.Click += new System.EventHandler(this.loadGame_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(150, 311);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(108, 22);
            this.textBox1.TabIndex = 4;
            this.textBox1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(18, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Enter Game Name";
            this.label2.Visible = false;
            // 
            // gameName
            // 
            this.gameName.AutoSize = true;
            this.gameName.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameName.ForeColor = System.Drawing.Color.White;
            this.gameName.Location = new System.Drawing.Point(23, 349);
            this.gameName.Name = "gameName";
            this.gameName.Size = new System.Drawing.Size(140, 18);
            this.gameName.TabIndex = 7;
            this.gameName.Text = "Invalid Game Name";
            this.gameName.Visible = false;
            // 
            // ld
            // 
            this.ld.BackColor = System.Drawing.Color.White;
            this.ld.Font = new System.Drawing.Font("Berlin Sans FB Demi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ld.Location = new System.Drawing.Point(183, 348);
            this.ld.Name = "ld";
            this.ld.Size = new System.Drawing.Size(75, 23);
            this.ld.TabIndex = 8;
            this.ld.Text = "Load";
            this.ld.UseVisualStyleBackColor = false;
            this.ld.Visible = false;
            this.ld.Click += new System.EventHandler(this.ld_Click);
            // 
            // Main_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(283, 383);
            this.Controls.Add(this.ld);
            this.Controls.Add(this.gameName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.loadGame);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Multiplayer);
            this.Controls.Add(this.Singleplayer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connect 4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Singleplayer;
        private System.Windows.Forms.Button Multiplayer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button loadGame;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label gameName;
        private System.Windows.Forms.Button ld;
    }
}