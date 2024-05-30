using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dod1k
{
    public partial class Form1 : Form
    {
        private GameVariables vars = new GameVariables();
        private CoinManager coinManager;
        private PipeManager pipeManager;
        private BoostManager boostManager;
        private Timer gbTimer = new Timer();
        private Timer sbTimer = new Timer();

        public Form1()
        {
            InitializeComponent();
            InitializeManagers();
            SetupUI();
            LoadHighScore();
            RestartGame();
        }

        private void InitializeManagers()
        {
            coinManager = new CoinManager(coin, dodik, vars);
            pipeManager = new PipeManager(pipeTop, pipeBottom, scriptTop, scriptBottom, dodik, ground, vars);
            boostManager = new BoostManager(dodik, pipeTop, pipeBottom, scriptTop, scriptBottom,
                                           restartButton, pictureWin, gameTimer, sbTimer, gbTimer,
                                           heartBoost, speedBoost, ghostBoost, burgerBoost,
                                           vars, coinManager);
        }

        private void SetupUI()
        {
            scoreText.Left = 250;
            scoreText.Top = 30;
            coinText.Left = 25;
            coinText.Top = 30;
            recordText.Left = 525;
            recordText.Top = 30;
            ground.Controls.Add(scoreText);
            ground.Controls.Add(coinText);
            ground.Controls.Add(recordText);
        }

        public void gameTimerEvent(object sender, EventArgs e)
        {
            scoreText.Text = "Score: " + vars.Score;
            coinText.Text = "Coin: " + coinManager.CoinCount;
            recordText.Text = "Record: " + vars.HighScore;
            speedBoostText.Text = "SB: " + vars.SpeedCount;
            ghostBoostText.Text = "GB: " + vars.GhostCount;

            cost1.Visible = false;
            cost2.Visible = false;
            cost3.Visible = false;
            cost4.Visible = false;

            heartBoost.Visible = false;
            speedBoost.Visible = false;
            ghostBoost.Visible = false;
            burgerBoost.Visible = false;
            pictureWin.Visible = false;

            UpdateGame();
            UpdateBackgroundBasedOnScore();
            boostManager.UpdateBoosts();
            pipeManager.UpdateVibration();
            vars.Score = pipeManager.CheckForScore(vars.Score);

            // Рекорд
            if (vars.Score > vars.HighScore)
            {
                vars.HighScore = vars.Score;
                SaveHighScore();
            }
            //
        }

        private void UpdateGame()
        {
            vars.Gravity = dodik.Bounds.IntersectsWith(ground.Bounds) ? 0 : vars.Gravity;
            dodik.Top += vars.Gravity;
            pipeManager.MovePipes();
            coinManager.MoveCoin();
            coinManager.CheckCollisionAndCollectCoin();
            if (pipeManager.CheckCollisions() && !vars.GB) endGame();
        }

        private void UpdateBackgroundBasedOnScore()
        {
            this.BackColor = (vars.Score >= 15 && vars.Score < 25) || (vars.Score >= 50 && vars.Score < 60) ? Color.Red : SystemColors.Control;
        }

        // Управление
        private void gameKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
                vars.Gravity = -10;
        }

        private void gameKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
                vars.Gravity = 10;
            if (e.KeyCode == Keys.S && vars.SpeedCount >= 1)
                boostManager.SpeedBoost();
            if (e.KeyCode == Keys.G && vars.GhostCount >= 1)
                boostManager.GhostBoost();
        }
        //

        // Доп жизнь
        private void heartClick(object sender, EventArgs e)
        {
            boostManager.HeartBoost();
        }
        //

        // Ускорение
        private void speedClick(object sender, EventArgs e)
        {
            boostManager.SpeedBoostClick();
        }
        //

        // Призрачность
        private void ghostClick(object sender, EventArgs e)
        {
            boostManager.GhostBoostClick();
        }
        //

        // Бургер (победа)
        private void burgerClick(object sender, EventArgs e)
        {
            boostManager.BurgerBoost();
        }
        //

        // Рестарт
        private void restartClick(object sender, EventArgs e)
        {
            RestartGame();
        }

        private void RestartGame()
        {

            dodik.Location = new Point(41, 284);
            vars.Reset();
            pipeManager.ResetPipes();
            restartButton.Enabled = false;
            restartButton.Visible = false;
            heartBoost.Enabled = false;
            heartBoost.Visible = false;
            gameTimer.Start();
        }
        //

        // Запись рекорда
        private void LoadHighScore()
        {
            if (File.Exists("highscore.txt"))
            {
                vars.HighScore = int.Parse(File.ReadAllText("highscore.txt"));
            }
        }

        private void SaveHighScore()
        {
            File.WriteAllText("highscore.txt", vars.HighScore.ToString());
        }
        //

        // Поражение
        private void endGame()
        {
            gameTimer.Stop();
            boostManager.HandleEndGame();
            restartButton.Enabled = true;
            restartButton.Visible = true;
            heartBoost.Enabled = true;
            heartBoost.Visible = true;
            cost1.Visible = true;
            speedBoost.Visible = true;
            speedBoost.Enabled = true;
            cost2.Visible = true;
            ghostBoost.Visible = true;
            ghostBoost.Enabled = true;
            cost3.Visible = true;
            if (vars.Burger == true)
            {
                burgerBoost.Visible = true;
                cost4.Visible = true;
            }
        }
        //
    }
}
