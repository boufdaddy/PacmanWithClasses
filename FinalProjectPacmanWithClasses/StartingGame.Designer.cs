namespace FinalProjectPacmanWithClasses
{
    partial class StartingGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartingGame));
            this.picPacMan = new System.Windows.Forms.PictureBox();
            this.StartGame = new System.Windows.Forms.Label();
            this.HowToPlay = new System.Windows.Forms.Label();
            this.ShowCredits = new System.Windows.Forms.Label();
            this.ExitGame = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picPacMan)).BeginInit();
            this.SuspendLayout();
            // 
            // picPacMan
            // 
            this.picPacMan.Image = ((System.Drawing.Image)(resources.GetObject("picPacMan.Image")));
            this.picPacMan.Location = new System.Drawing.Point(12, 12);
            this.picPacMan.Name = "picPacMan";
            this.picPacMan.Size = new System.Drawing.Size(415, 177);
            this.picPacMan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPacMan.TabIndex = 2;
            this.picPacMan.TabStop = false;
            // 
            // StartGame
            // 
            this.StartGame.AutoSize = true;
            this.StartGame.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.StartGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartGame.ForeColor = System.Drawing.SystemColors.Control;
            this.StartGame.Location = new System.Drawing.Point(106, 220);
            this.StartGame.Name = "StartGame";
            this.StartGame.Size = new System.Drawing.Size(223, 46);
            this.StartGame.TabIndex = 3;
            this.StartGame.Text = "Start Game";
            this.StartGame.Click += new System.EventHandler(this.StartGame_Click);
            // 
            // HowToPlay
            // 
            this.HowToPlay.AutoSize = true;
            this.HowToPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HowToPlay.ForeColor = System.Drawing.SystemColors.Control;
            this.HowToPlay.Location = new System.Drawing.Point(133, 286);
            this.HowToPlay.Name = "HowToPlay";
            this.HowToPlay.Size = new System.Drawing.Size(168, 31);
            this.HowToPlay.TabIndex = 5;
            this.HowToPlay.Text = "How To Play";
            this.HowToPlay.Click += new System.EventHandler(this.label3_Click);
            // 
            // ShowCredits
            // 
            this.ShowCredits.AutoSize = true;
            this.ShowCredits.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowCredits.ForeColor = System.Drawing.SystemColors.Control;
            this.ShowCredits.Location = new System.Drawing.Point(166, 346);
            this.ShowCredits.Name = "ShowCredits";
            this.ShowCredits.Size = new System.Drawing.Size(101, 31);
            this.ShowCredits.TabIndex = 6;
            this.ShowCredits.Text = "Credits";
            // 
            // ExitGame
            // 
            this.ExitGame.AutoSize = true;
            this.ExitGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitGame.ForeColor = System.Drawing.SystemColors.Control;
            this.ExitGame.Location = new System.Drawing.Point(185, 417);
            this.ExitGame.Name = "ExitGame";
            this.ExitGame.Size = new System.Drawing.Size(59, 31);
            this.ExitGame.TabIndex = 7;
            this.ExitGame.Text = "Exit";
            // 
            // StartingGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(439, 552);
            this.Controls.Add(this.ExitGame);
            this.Controls.Add(this.ShowCredits);
            this.Controls.Add(this.HowToPlay);
            this.Controls.Add(this.StartGame);
            this.Controls.Add(this.picPacMan);
            this.Name = "StartingGame";
            this.Text = "StartingGame";
            ((System.ComponentModel.ISupportInitialize)(this.picPacMan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picPacMan;
        private System.Windows.Forms.Label StartGame;
        private System.Windows.Forms.Label HowToPlay;
        private System.Windows.Forms.Label ShowCredits;
        private System.Windows.Forms.Label ExitGame;
    }
}