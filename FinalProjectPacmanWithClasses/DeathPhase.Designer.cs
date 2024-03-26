namespace FinalProjectPacmanWithClasses
{
    partial class DeathPhase
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
            this.btnretry = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblretry = new System.Windows.Forms.Label();
            this.lblexit = new System.Windows.Forms.Label();
            this.lblChoice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblloss
            // 
            this.lblloss.AutoSize = true;
            this.lblloss.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblloss.ForeColor = System.Drawing.Color.Red;
            this.lblloss.Location = new System.Drawing.Point(111, 167);
            this.lblloss.Name = "lblloss";
            this.lblloss.Size = new System.Drawing.Size(597, 55);
            this.lblloss.TabIndex = 0;
            this.lblloss.Text = "YOU LOST!!  GET A LIFE";
            // 
            // btnretry
            // 
            this.btnretry.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnretry.Location = new System.Drawing.Point(161, 312);
            this.btnretry.Name = "btnretry";
            this.btnretry.Size = new System.Drawing.Size(119, 37);
            this.btnretry.TabIndex = 1;
            this.btnretry.Text = "Retry";
            this.btnretry.UseVisualStyleBackColor = true;
            this.btnretry.Click += new System.EventHandler(this.btnretry_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(492, 312);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(119, 37);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblretry
            // 
            this.lblretry.AutoSize = true;
            this.lblretry.Font = new System.Drawing.Font("Matura MT Script Capitals", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblretry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblretry.Location = new System.Drawing.Point(121, 373);
            this.lblretry.Name = "lblretry";
            this.lblretry.Size = new System.Drawing.Size(213, 20);
            this.lblretry.TabIndex = 3;
            this.lblretry.Text = "For People who have guts";
            // 
            // lblexit
            // 
            this.lblexit.AutoSize = true;
            this.lblexit.Font = new System.Drawing.Font("Matura MT Script Capitals", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblexit.ForeColor = System.Drawing.Color.Cyan;
            this.lblexit.Location = new System.Drawing.Point(448, 373);
            this.lblexit.Name = "lblexit";
            this.lblexit.Size = new System.Drawing.Size(235, 20);
            this.lblexit.TabIndex = 4;
            this.lblexit.Text = "For People who have no will";
            // 
            // lblChoice
            // 
            this.lblChoice.AutoSize = true;
            this.lblChoice.Font = new System.Drawing.Font("Lucida Calligraphy", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChoice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblChoice.Location = new System.Drawing.Point(270, 421);
            this.lblChoice.Name = "lblChoice";
            this.lblChoice.Size = new System.Drawing.Size(209, 20);
            this.lblChoice.TabIndex = 5;
            this.lblChoice.Text = "CHOOSE YOUR FATE!";
            // 
            // DeathPhase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblChoice);
            this.Controls.Add(this.lblexit);
            this.Controls.Add(this.lblretry);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnretry);
            this.Controls.Add(this.lblloss);
            this.Name = "DeathPhase";
            this.Text = "DeathPhase";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblloss;
        private System.Windows.Forms.Button btnretry;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblretry;
        private System.Windows.Forms.Label lblexit;
        private System.Windows.Forms.Label lblChoice;
    }
}