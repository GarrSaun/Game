namespace Game
{
    partial class TutorialScreen
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.playButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.blackBox = new System.Windows.Forms.PictureBox();
            this.greenBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.blackBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenBox)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Mongolian Baiti", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(219, 259);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(159, 30);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "How to Play";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(195, 310);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Press         repeatedly to run";
            // 
            // playButton
            // 
            this.playButton.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playButton.Location = new System.Drawing.Point(235, 383);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(122, 49);
            this.playButton.TabIndex = 2;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(235, 453);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(122, 49);
            this.backButton.TabIndex = 3;
            this.backButton.Text = "Back to Menu";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(195, 345);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Press         to forfeit";
            // 
            // blackBox
            // 
            this.blackBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.blackBox.ErrorImage = global::Game.Properties.Resources.black;
            this.blackBox.Image = global::Game.Properties.Resources.black;
            this.blackBox.InitialImage = global::Game.Properties.Resources.black;
            this.blackBox.Location = new System.Drawing.Point(235, 339);
            this.blackBox.Name = "blackBox";
            this.blackBox.Size = new System.Drawing.Size(26, 28);
            this.blackBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.blackBox.TabIndex = 6;
            this.blackBox.TabStop = false;
            // 
            // greenBox
            // 
            this.greenBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.greenBox.ErrorImage = global::Game.Properties.Resources.green;
            this.greenBox.Image = global::Game.Properties.Resources.green;
            this.greenBox.InitialImage = global::Game.Properties.Resources.green;
            this.greenBox.Location = new System.Drawing.Point(235, 305);
            this.greenBox.Name = "greenBox";
            this.greenBox.Size = new System.Drawing.Size(26, 28);
            this.greenBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.greenBox.TabIndex = 4;
            this.greenBox.TabStop = false;
            // 
            // TutorialScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.Controls.Add(this.blackBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.greenBox);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.titleLabel);
            this.Name = "TutorialScreen";
            this.Size = new System.Drawing.Size(600, 1000);
            ((System.ComponentModel.ISupportInitialize)(this.blackBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.PictureBox greenBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox blackBox;
    }
}
