namespace FlappyBird
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.flappyBirdCharacter = new System.Windows.Forms.PictureBox();
            this.obstaclePipeTop = new System.Windows.Forms.PictureBox();
            this.obstaclePipeBottom = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.scoreBoard = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.flappyBirdCharacter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstaclePipeTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstaclePipeBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            this.SuspendLayout();
            // 
            // flappyBirdCharacter
            // 
            this.flappyBirdCharacter.Image = global::FlappyBird.Properties.Resources.bird;
            this.flappyBirdCharacter.Location = new System.Drawing.Point(116, 276);
            this.flappyBirdCharacter.Name = "flappyBirdCharacter";
            this.flappyBirdCharacter.Size = new System.Drawing.Size(94, 76);
            this.flappyBirdCharacter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flappyBirdCharacter.TabIndex = 0;
            this.flappyBirdCharacter.TabStop = false;
            // 
            // obstaclePipeTop
            // 
            this.obstaclePipeTop.Image = global::FlappyBird.Properties.Resources.pipedown;
            this.obstaclePipeTop.Location = new System.Drawing.Point(716, -217);
            this.obstaclePipeTop.Name = "obstaclePipeTop";
            this.obstaclePipeTop.Size = new System.Drawing.Size(149, 445);
            this.obstaclePipeTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.obstaclePipeTop.TabIndex = 1;
            this.obstaclePipeTop.TabStop = false;
            // 
            // obstaclePipeBottom
            // 
            this.obstaclePipeBottom.Image = global::FlappyBird.Properties.Resources.pipe;
            this.obstaclePipeBottom.Location = new System.Drawing.Point(518, 465);
            this.obstaclePipeBottom.Name = "obstaclePipeBottom";
            this.obstaclePipeBottom.Size = new System.Drawing.Size(149, 299);
            this.obstaclePipeBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.obstaclePipeBottom.TabIndex = 2;
            this.obstaclePipeBottom.TabStop = false;
            // 
            // ground
            // 
            this.ground.Image = global::FlappyBird.Properties.Resources.ground;
            this.ground.Location = new System.Drawing.Point(-16, 697);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(905, 180);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 3;
            this.ground.TabStop = false;
            // 
            // scoreBoard
            // 
            this.scoreBoard.AutoSize = true;
            this.scoreBoard.BackColor = System.Drawing.Color.Moccasin;
            this.scoreBoard.Font = new System.Drawing.Font("Impact", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.scoreBoard.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.scoreBoard.Location = new System.Drawing.Point(287, 750);
            this.scoreBoard.Name = "scoreBoard";
            this.scoreBoard.Size = new System.Drawing.Size(143, 41);
            this.scoreBoard.TabIndex = 4;
            this.scoreBoard.Text = "Score : 0";
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(877, 800);
            this.Controls.Add(this.scoreBoard);
            this.Controls.Add(this.flappyBirdCharacter);
            this.Controls.Add(this.obstaclePipeTop);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.obstaclePipeBottom);
            this.Name = "Form1";
            this.Text = "FlyingBird - Own Version";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gameKeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gameKeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.flappyBirdCharacter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstaclePipeTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstaclePipeBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox flappyBirdCharacter;
        private PictureBox obstaclePipeTop;
        private PictureBox obstaclePipeBottom;
        private PictureBox ground;
        private Label scoreBoard;
        private System.Windows.Forms.Timer gameTimer;
    }
}