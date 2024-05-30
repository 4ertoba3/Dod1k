using System.Windows.Forms;
using System.Drawing;
using System;

public class BoostManager
{
    private PictureBox dodik;
    private PictureBox pipeTop, pipeBottom, scriptTop, scriptBottom, restartButton, heartBoost, speedBoost, ghostBoost, burgerBoost;
    private PictureBox pictureWin;
    private Timer gameTimer, sbTimer, gbTimer;
    private GameVariables vars;
    private CoinManager coinManager;

    public BoostManager(PictureBox dodik, PictureBox pipeTop, PictureBox pipeBottom, PictureBox scriptTop, PictureBox scriptBottom,
                    PictureBox restartButton, PictureBox pictureWin, Timer gameTimer, Timer sbTimer, Timer gbTimer,
                    PictureBox heartBoost, PictureBox speedBoost, PictureBox ghostBoost, PictureBox burgerBoost,
                    GameVariables vars, CoinManager coinManager)
    {
        this.dodik = dodik;
        this.pipeTop = pipeTop;
        this.pipeBottom = pipeBottom;
        this.scriptTop = scriptTop;
        this.scriptBottom = scriptBottom;
        this.restartButton = restartButton;
        this.pictureWin = pictureWin;
        this.gameTimer = gameTimer;
        this.sbTimer = sbTimer;
        this.gbTimer = gbTimer;
        this.heartBoost = heartBoost;
        this.speedBoost = speedBoost;
        this.ghostBoost = ghostBoost;
        this.burgerBoost = burgerBoost;
        this.vars = vars;
        this.coinManager = coinManager;
        this.sbTimer.Interval = 10000;
        this.sbTimer.Tick += SbTimer_Tick;
        this.gbTimer.Interval = 10000;
        this.gbTimer.Tick += GbTimer_Tick;
        InitializeTimers();
    }

    private void InitializeTimers()
    {
        if (this.sbTimer != null)
        {
            this.sbTimer.Interval = 10000;
            this.sbTimer.Tick += SbTimer_Tick;
        }

        if (this.gbTimer != null)
        {
            this.gbTimer.Interval = 10000;
            this.gbTimer.Tick += GbTimer_Tick;
        }
    }

    public void UpdateBoosts()
    {
        if (vars.Score >= 100)
        {
            vars.Burger = true;
        }

        if (vars.SB)
            vars.Speed = 50;
        else
            vars.Speed = 10;
    }

    public void HandleEndGame()
    {
        sbTimer.Stop();
        gbTimer.Stop();
        vars.SB = false;
        vars.GB = false;
        speedBoost.Enabled = false;
        ghostBoost.Enabled = false;
    }

    public void HeartBoost()
    {
        if (coinManager.CoinCount >= 3)
        {
            dodik.Location = new Point(41, 284);
            pipeTop.Left = 800;
            scriptTop.Left = 800;
            pipeBottom.Left = 1200;
            scriptBottom.Left = 1200;
            vars.Speed = 10;
            heartBoost.Enabled = false;
            heartBoost.Visible = false;
            coinManager.CoinCount -= 3;
            restartButton.Enabled = false;
            restartButton.Visible = false;
            gameTimer.Start();
        }
    }

    public void SpeedBoostClick()
    {
        if (coinManager.CoinCount >= 5)
        {
            coinManager.CoinCount -= 5;
            vars.SpeedCount += 1;
            gameTimer.Start();
        }
    }

    public void SpeedBoost()
    {
        vars.SB = true;
        vars.SpeedCount -= 1;
        sbTimer.Start();
    }

    private void SbTimer_Tick(object sender, EventArgs e)
    {
        vars.SB = false;
        sbTimer.Stop();
    }

    public void GhostBoostClick()
    {
        if (coinManager.CoinCount >= 4)
        {
            coinManager.CoinCount -= 4;
            vars.GhostCount += 1;
            gameTimer.Start();
        }
    }

    public void GhostBoost()
    {
        vars.GhostCount -= 1;
        vars.GB = true;
        gbTimer.Start();
    }

    private void GbTimer_Tick(object sender, EventArgs e)
    {
        vars.GB = false;
        gbTimer.Stop();
    }

    public void BurgerBoost()
    {
        if (coinManager.CoinCount >= 100)
        {
            coinManager.CoinCount -= 100;
            pictureWin.Visible = true;
            gameTimer.Stop();
        }
    }
}

