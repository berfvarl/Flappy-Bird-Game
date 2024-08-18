namespace FlappyBirdGame
{
    public partial class Form1 : Form

    {

        int boruHızı = 8;
        int gravity = 10;
        int score = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void GameTimerEvent(object sender, EventArgs e)
        {
            Flappy.Top += gravity;
            BoruAlt.Left -= boruHızı;
            BoruUst.Left -= boruHızı;
            ScoreTxt.Text = "Score:" + score;
            if(BoruAlt.Left <- 150)
            {
                BoruAlt.Left = 800;
                score++;

            }
            if(BoruUst.Left <-180)
            {
                BoruUst.Left = 950;
                score++;
            }
            if (Flappy.Bounds.IntersectsWith(BoruAlt.Bounds) || Flappy.Bounds.IntersectsWith(BoruUst.Bounds) || Flappy.Bounds.IntersectsWith(Zemin.Bounds))
            {
                endGame();
            }

            if(score>5)
            {
                boruHızı = 15;
            }

            if (score > 20)
            {
                boruHızı = 18;
            }
            
        }

        //private void GameTimer(object sender, EventArgs e)
        //{
            
        //}

        private void gamekeyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -10;
            }
        }

        private void gamekeyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 10;
                    
            }
        }

        private void endGame ()
        {
            timer1.Stop();
            ScoreTxt.Text = "Game Over";                    
        }
    }
}
