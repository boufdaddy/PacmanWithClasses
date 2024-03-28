namespace FinalProjectPacmanWithClasses
{
    partial class WinningPhase
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
            this.lblloss = new System.Windows.Forms.Label();
            this.btnPlayagain = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblloss
            // 
            this.lblloss.AutoSize = true;
            this.lblloss.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblloss.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblloss.Location = new System.Drawing.Point(101, 137);
            this.lblloss.Name = "lblloss";
            this.lblloss.Size = new System.Drawing.Size(575, 55);
            this.lblloss.TabIndex = 1;
            this.lblloss.Text = "YOU WIN!! YOU ROCK!!";
            // 
            // btnPlayagain
            // 
            this.btnPlayagain.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayagain.Location = new System.Drawing.Point(120, 305);
            this.btnPlayagain.Name = "btnPlayagain";
            this.btnPlayagain.Size = new System.Drawing.Size(121, 36);
            this.btnPlayagain.TabIndex = 2;
            this.btnPlayagain.Text = "Play Again";
            this.btnPlayagain.UseVisualStyleBackColor = true;
            this.btnPlayagain.Click += new System.EventHandler(this.btnPlayagain_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(537, 305);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 36);
            this.button2.TabIndex = 3;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // WinningPhase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnPlayagain);
            this.Controls.Add(this.lblloss);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "WinningPhase";
            this.Text = "WinningPhase";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblloss;
        private System.Windows.Forms.Button btnPlayagain;
        private System.Windows.Forms.Button button2;
    }
}