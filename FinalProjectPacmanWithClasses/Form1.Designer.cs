namespace FinalProjectPacmanWithClasses
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.PacTimer = new System.Windows.Forms.Timer(this.components);
            this.lblscore = new System.Windows.Forms.Label();
            this.lblscorecount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PacTimer
            // 
            this.PacTimer.Interval = 25;
            this.PacTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblscore
            // 
            this.lblscore.AutoSize = true;
            this.lblscore.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblscore.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblscore.Location = new System.Drawing.Point(13, 13);
            this.lblscore.Name = "lblscore";
            this.lblscore.Size = new System.Drawing.Size(58, 15);
            this.lblscore.TabIndex = 0;
            this.lblscore.Text = "SCORE :";
            // 
            // lblscorecount
            // 
            this.lblscorecount.AutoSize = true;
            this.lblscorecount.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblscorecount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblscorecount.Location = new System.Drawing.Point(77, 13);
            this.lblscorecount.Name = "lblscorecount";
            this.lblscorecount.Size = new System.Drawing.Size(0, 15);
            this.lblscorecount.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1071, 537);
            this.Controls.Add(this.lblscorecount);
            this.Controls.Add(this.lblscore);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer PacTimer;
        private System.Windows.Forms.Label lblscore;
        private System.Windows.Forms.Label lblscorecount;
    }
}

