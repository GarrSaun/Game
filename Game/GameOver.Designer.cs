namespace Game
{
    partial class GameOver
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.restartButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.gameoverLabel = new System.Windows.Forms.Label();
            this.newHighScoreLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.recordLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // restartButton
            // 
            this.restartButton.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restartButton.Location = new System.Drawing.Point(239, 486);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(111, 52);
            this.restartButton.TabIndex = 1;
            this.restartButton.Text = "Play Again";
            this.restartButton.UseVisualStyleBackColor = true;
            this.restartButton.Click += new System.EventHandler(this.restartButton_Click);
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(239, 557);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(111, 52);
            this.backButton.TabIndex = 2;
            this.backButton.Text = "Back to Menu";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // gameoverLabel
            // 
            this.gameoverLabel.AutoSize = true;
            this.gameoverLabel.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameoverLabel.Location = new System.Drawing.Point(234, 264);
            this.gameoverLabel.Name = "gameoverLabel";
            this.gameoverLabel.Size = new System.Drawing.Size(148, 29);
            this.gameoverLabel.TabIndex = 2;
            this.gameoverLabel.Text = "Game Over";
            // 
            // newHighScoreLabel
            // 
            this.newHighScoreLabel.AutoSize = true;
            this.newHighScoreLabel.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newHighScoreLabel.Location = new System.Drawing.Point(236, 325);
            this.newHighScoreLabel.Name = "newHighScoreLabel";
            this.newHighScoreLabel.Size = new System.Drawing.Size(135, 16);
            this.newHighScoreLabel.TabIndex = 3;
            this.newHighScoreLabel.Text = "New High Score!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(300, 392);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 4;
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.Location = new System.Drawing.Point(248, 393);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(96, 16);
            this.scoreLabel.TabIndex = 5;
            this.scoreLabel.Text = "Your Score:";
            // 
            // recordLabel
            // 
            this.recordLabel.AutoSize = true;
            this.recordLabel.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recordLabel.Location = new System.Drawing.Point(248, 362);
            this.recordLabel.Name = "recordLabel";
            this.recordLabel.Size = new System.Drawing.Size(95, 16);
            this.recordLabel.TabIndex = 6;
            this.recordLabel.Text = "High Score:";
            // 
            // GameOver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.Controls.Add(this.recordLabel);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newHighScoreLabel);
            this.Controls.Add(this.gameoverLabel);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.restartButton);
            this.Name = "GameOver";
            this.Size = new System.Drawing.Size(600, 1000);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button restartButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label gameoverLabel;
        private System.Windows.Forms.Label newHighScoreLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label recordLabel;
    }
}
