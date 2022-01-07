namespace FlappyBird
{
    public partial class Form1 : Form
    {

        int pipeSpeed = 8;
        int gravity = 15;
        int score = 0;
        bool isJumpKeyDown = false;


        public Form1()
        {
            InitializeComponent();
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            flappyBirdCharacter.Top += gravity;
            obstaclePipeBottom.Left -= pipeSpeed;
            obstaclePipeTop.Left -= pipeSpeed;
            scoreBoard.Text = "Score : " + score.ToString();

            if(obstaclePipeBottom.Left < -150)
            {
                obstaclePipeBottom.Left = 1000;
                score++;
            }
            if (obstaclePipeTop.Left < -180)
            {
                obstaclePipeTop.Left = 1100;
                score++;
            }

            if (flappyBirdCharacter.Bounds.IntersectsWith(obstaclePipeBottom.Bounds) ||
               flappyBirdCharacter.Bounds.IntersectsWith(obstaclePipeTop.Bounds) ||
               flappyBirdCharacter.Bounds.IntersectsWith(ground.Bounds) || 
               flappyBirdCharacter.Top < -25
                )
            {
                endGame();
            }

            if(score > 5)
            {
                pipeSpeed = 15;
            }

        }

        private void gameKeyIsDown(object sender, KeyEventArgs e)
        {
            if(isJumpKeyDown)
            {
                return;
            }
            if(e.KeyCode == Keys.Space)
            {
                gravity = -15;
                isJumpKeyDown = true;
            }

        }

        private void gameKeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 15;
                isJumpKeyDown = false;
            }

        }

        private void endGame()
        {
            gameTimer.Stop();
            scoreBoard.Text += " Game Over !!!";
        }
    }
}