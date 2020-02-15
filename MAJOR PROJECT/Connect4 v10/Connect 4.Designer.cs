namespace Connect4_v10
{
    partial class Connect_4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Connect_4));
            this.exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.playerTurn = new System.Windows.Forms.Label();
            this.notWorked = new System.Windows.Forms.Label();
            this.Won = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            this.home = new System.Windows.Forms.Button();
            this.undo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.White;
            this.exit.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.exit.Location = new System.Drawing.Point(84, 394);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(104, 38);
            this.exit.TabIndex = 0;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB Demi", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(867, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "Player Turn:";
            // 
            // playerTurn
            // 
            this.playerTurn.AutoSize = true;
            this.playerTurn.BackColor = System.Drawing.Color.Transparent;
            this.playerTurn.Font = new System.Drawing.Font("Berlin Sans FB Demi", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerTurn.ForeColor = System.Drawing.Color.Transparent;
            this.playerTurn.Location = new System.Drawing.Point(1028, 25);
            this.playerTurn.Name = "playerTurn";
            this.playerTurn.Size = new System.Drawing.Size(0, 27);
            this.playerTurn.TabIndex = 4;
            // 
            // notWorked
            // 
            this.notWorked.AutoSize = true;
            this.notWorked.BackColor = System.Drawing.Color.Transparent;
            this.notWorked.Font = new System.Drawing.Font("Berlin Sans FB Demi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notWorked.ForeColor = System.Drawing.Color.Transparent;
            this.notWorked.Location = new System.Drawing.Point(48, 523);
            this.notWorked.Name = "notWorked";
            this.notWorked.Size = new System.Drawing.Size(191, 24);
            this.notWorked.TabIndex = 18;
            this.notWorked.Text = "That Column is Full";
            this.notWorked.Visible = false;
            // 
            // Won
            // 
            this.Won.AutoSize = true;
            this.Won.Font = new System.Drawing.Font("Berlin Sans FB Demi", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Won.ForeColor = System.Drawing.Color.White;
            this.Won.Location = new System.Drawing.Point(592, 854);
            this.Won.Name = "Won";
            this.Won.Size = new System.Drawing.Size(88, 31);
            this.Won.TabIndex = 26;
            this.Won.Text = "label2";
            this.Won.Visible = false;
            this.Won.Click += new System.EventHandler(this.Won_Click);
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.White;
            this.save.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.ForeColor = System.Drawing.Color.Black;
            this.save.Location = new System.Drawing.Point(84, 300);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(104, 38);
            this.save.TabIndex = 6;
            this.save.Text = "Save Game";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // home
            // 
            this.home.BackColor = System.Drawing.Color.White;
            this.home.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home.ForeColor = System.Drawing.Color.Black;
            this.home.Location = new System.Drawing.Point(84, 22);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(104, 38);
            this.home.TabIndex = 27;
            this.home.Text = "Home";
            this.home.UseVisualStyleBackColor = false;
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // undo
            // 
            this.undo.BackColor = System.Drawing.Color.White;
            this.undo.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.undo.ForeColor = System.Drawing.Color.Black;
            this.undo.Location = new System.Drawing.Point(84, 208);
            this.undo.Name = "undo";
            this.undo.Size = new System.Drawing.Size(104, 38);
            this.undo.TabIndex = 28;
            this.undo.Text = "Undo";
            this.undo.UseVisualStyleBackColor = false;
            this.undo.Click += new System.EventHandler(this.undo_Click);
            // 
            // Connect_4
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1233, 857);
            this.Controls.Add(this.undo);
            this.Controls.Add(this.home);
            this.Controls.Add(this.Won);
            this.Controls.Add(this.notWorked);
            this.Controls.Add(this.save);
            this.Controls.Add(this.playerTurn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exit);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Connect_4";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Connect_4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label playerTurn;
        private System.Windows.Forms.Label notWorked;
        private System.Windows.Forms.Label Won;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button home;
        private System.Windows.Forms.Button undo;

    }
}