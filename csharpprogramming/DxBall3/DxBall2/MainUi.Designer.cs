namespace DxBall2
{
    partial class MainUi
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
            this.newGame = new System.Windows.Forms.Button();
            this.highscore = new System.Windows.Forms.Button();
            this.instruction = new System.Windows.Forms.Button();
            this.about = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // newGame
            // 
            this.newGame.BackColor = System.Drawing.Color.MintCream;
            this.newGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newGame.FlatAppearance.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.newGame.FlatAppearance.BorderSize = 20;
            this.newGame.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.newGame.Font = new System.Drawing.Font("Monotype Corsiva", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newGame.ForeColor = System.Drawing.Color.DarkBlue;
            this.newGame.Location = new System.Drawing.Point(202, 105);
            this.newGame.Name = "newGame";
            this.newGame.Size = new System.Drawing.Size(180, 56);
            this.newGame.TabIndex = 0;
            this.newGame.Text = "New Game";
            this.newGame.UseVisualStyleBackColor = false;
            this.newGame.Click += new System.EventHandler(this.newGame_Click);
            // 
            // highscore
            // 
            this.highscore.BackColor = System.Drawing.Color.MintCream;
            this.highscore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.highscore.FlatAppearance.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.highscore.FlatAppearance.BorderSize = 20;
            this.highscore.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.highscore.Font = new System.Drawing.Font("Monotype Corsiva", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highscore.ForeColor = System.Drawing.Color.DarkBlue;
            this.highscore.Location = new System.Drawing.Point(202, 167);
            this.highscore.Name = "highscore";
            this.highscore.Size = new System.Drawing.Size(180, 56);
            this.highscore.TabIndex = 1;
            this.highscore.Text = "Highscore";
            this.highscore.UseVisualStyleBackColor = false;
            // 
            // instruction
            // 
            this.instruction.BackColor = System.Drawing.Color.MintCream;
            this.instruction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.instruction.FlatAppearance.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.instruction.FlatAppearance.BorderSize = 20;
            this.instruction.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.instruction.Font = new System.Drawing.Font("Monotype Corsiva", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instruction.ForeColor = System.Drawing.Color.DarkBlue;
            this.instruction.Location = new System.Drawing.Point(202, 229);
            this.instruction.Name = "instruction";
            this.instruction.Size = new System.Drawing.Size(180, 56);
            this.instruction.TabIndex = 2;
            this.instruction.Text = "Instruction";
            this.instruction.UseVisualStyleBackColor = false;
            this.instruction.Click += new System.EventHandler(this.instruction_Click);
            // 
            // about
            // 
            this.about.BackColor = System.Drawing.Color.MintCream;
            this.about.Cursor = System.Windows.Forms.Cursors.Hand;
            this.about.FlatAppearance.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.about.FlatAppearance.BorderSize = 20;
            this.about.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.about.Font = new System.Drawing.Font("Monotype Corsiva", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.about.ForeColor = System.Drawing.Color.DarkBlue;
            this.about.Location = new System.Drawing.Point(202, 291);
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(180, 56);
            this.about.TabIndex = 3;
            this.about.Text = "About";
            this.about.UseVisualStyleBackColor = false;
            this.about.Click += new System.EventHandler(this.about_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.MintCream;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.FlatAppearance.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.exit.FlatAppearance.BorderSize = 20;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exit.Font = new System.Drawing.Font("Monotype Corsiva", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.Color.DarkBlue;
            this.exit.Location = new System.Drawing.Point(202, 353);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(180, 56);
            this.exit.TabIndex = 4;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::DxBall2.Properties.Resources.DX_ball_logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(156, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(283, 76);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // MainUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.BackgroundImage = global::DxBall2.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(589, 511);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.about);
            this.Controls.Add(this.instruction);
            this.Controls.Add(this.highscore);
            this.Controls.Add(this.newGame);
            this.Name = "MainUi";
            this.Text = "Menu";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button newGame;
        private System.Windows.Forms.Button highscore;
        private System.Windows.Forms.Button instruction;
        private System.Windows.Forms.Button about;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}