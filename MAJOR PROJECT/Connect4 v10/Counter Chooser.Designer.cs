namespace Connect4_v10
{
    partial class Counter_Chooser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Counter_Chooser));
            this.PlayerText = new System.Windows.Forms.Label();
            this.green = new System.Windows.Forms.Button();
            this.pink = new System.Windows.Forms.Button();
            this.purple = new System.Windows.Forms.Button();
            this.yellow = new System.Windows.Forms.Button();
            this.red = new System.Windows.Forms.Button();
            this.player = new System.Windows.Forms.Label();
            this.AIU = new System.Windows.Forms.Label();
            this.blue = new System.Windows.Forms.Button();
            this.home = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PlayerText
            // 
            this.PlayerText.AutoSize = true;
            this.PlayerText.BackColor = System.Drawing.Color.Transparent;
            this.PlayerText.Font = new System.Drawing.Font("Berlin Sans FB", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerText.ForeColor = System.Drawing.Color.White;
            this.PlayerText.Location = new System.Drawing.Point(121, 22);
            this.PlayerText.Name = "PlayerText";
            this.PlayerText.Size = new System.Drawing.Size(291, 41);
            this.PlayerText.TabIndex = 0;
            this.PlayerText.Text = "Choose A Counter";
            // 
            // green
            // 
            this.green.BackColor = System.Drawing.Color.White;
            this.green.Image = ((System.Drawing.Image)(resources.GetObject("green.Image")));
            this.green.Location = new System.Drawing.Point(488, 98);
            this.green.Name = "green";
            this.green.Size = new System.Drawing.Size(117, 121);
            this.green.TabIndex = 4;
            this.green.UseVisualStyleBackColor = false;
            this.green.Click += new System.EventHandler(this.green_Click);
            // 
            // pink
            // 
            this.pink.BackColor = System.Drawing.Color.White;
            this.pink.Image = ((System.Drawing.Image)(resources.GetObject("pink.Image")));
            this.pink.Location = new System.Drawing.Point(263, 247);
            this.pink.Name = "pink";
            this.pink.Size = new System.Drawing.Size(119, 121);
            this.pink.TabIndex = 5;
            this.pink.UseVisualStyleBackColor = false;
            this.pink.Click += new System.EventHandler(this.pink_Click);
            // 
            // purple
            // 
            this.purple.BackColor = System.Drawing.Color.White;
            this.purple.Image = ((System.Drawing.Image)(resources.GetObject("purple.Image")));
            this.purple.Location = new System.Drawing.Point(483, 247);
            this.purple.Name = "purple";
            this.purple.Size = new System.Drawing.Size(122, 121);
            this.purple.TabIndex = 6;
            this.purple.UseVisualStyleBackColor = false;
            this.purple.Click += new System.EventHandler(this.purple_Click);
            // 
            // yellow
            // 
            this.yellow.BackColor = System.Drawing.Color.White;
            this.yellow.Image = ((System.Drawing.Image)(resources.GetObject("yellow.Image")));
            this.yellow.Location = new System.Drawing.Point(43, 247);
            this.yellow.Name = "yellow";
            this.yellow.Size = new System.Drawing.Size(117, 117);
            this.yellow.TabIndex = 3;
            this.yellow.UseVisualStyleBackColor = false;
            this.yellow.Click += new System.EventHandler(this.yellow_Click);
            // 
            // red
            // 
            this.red.BackColor = System.Drawing.Color.White;
            this.red.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.red.Image = ((System.Drawing.Image)(resources.GetObject("red.Image")));
            this.red.Location = new System.Drawing.Point(43, 98);
            this.red.Margin = new System.Windows.Forms.Padding(0);
            this.red.Name = "red";
            this.red.Size = new System.Drawing.Size(117, 117);
            this.red.TabIndex = 1;
            this.red.UseVisualStyleBackColor = false;
            this.red.Click += new System.EventHandler(this.red_Click);
            // 
            // player
            // 
            this.player.AutoSize = true;
            this.player.Font = new System.Drawing.Font("Berlin Sans FB", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player.ForeColor = System.Drawing.Color.White;
            this.player.Location = new System.Drawing.Point(418, 22);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(137, 41);
            this.player.TabIndex = 7;
            this.player.Text = "Player 1";
            // 
            // AIU
            // 
            this.AIU.AutoSize = true;
            this.AIU.Font = new System.Drawing.Font("Berlin Sans FB", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AIU.ForeColor = System.Drawing.Color.White;
            this.AIU.Location = new System.Drawing.Point(97, 387);
            this.AIU.Name = "AIU";
            this.AIU.Size = new System.Drawing.Size(441, 41);
            this.AIU.TabIndex = 8;
            this.AIU.Text = "Already in use choose again";
            this.AIU.Visible = false;
            // 
            // blue
            // 
            this.blue.BackColor = System.Drawing.Color.White;
            this.blue.Image = ((System.Drawing.Image)(resources.GetObject("blue.Image")));
            this.blue.Location = new System.Drawing.Point(263, 98);
            this.blue.Name = "blue";
            this.blue.Size = new System.Drawing.Size(119, 117);
            this.blue.TabIndex = 2;
            this.blue.UseVisualStyleBackColor = false;
            this.blue.Click += new System.EventHandler(this.blue_Click);
            // 
            // home
            // 
            this.home.BackColor = System.Drawing.Color.White;
            this.home.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home.Location = new System.Drawing.Point(2, 3);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(77, 28);
            this.home.TabIndex = 9;
            this.home.Text = "Home";
            this.home.UseVisualStyleBackColor = false;
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // Counter_Chooser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(654, 459);
            this.Controls.Add(this.home);
            this.Controls.Add(this.AIU);
            this.Controls.Add(this.player);
            this.Controls.Add(this.purple);
            this.Controls.Add(this.pink);
            this.Controls.Add(this.green);
            this.Controls.Add(this.yellow);
            this.Controls.Add(this.blue);
            this.Controls.Add(this.red);
            this.Controls.Add(this.PlayerText);
            this.Name = "Counter_Chooser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connect 4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PlayerText;
        private System.Windows.Forms.Button green;
        private System.Windows.Forms.Button pink;
        private System.Windows.Forms.Button purple;
        private System.Windows.Forms.Button yellow;
        private System.Windows.Forms.Button red;
        private System.Windows.Forms.Label player;
        private System.Windows.Forms.Label AIU;
        private System.Windows.Forms.Button blue;
        private System.Windows.Forms.Button home;
    }
}