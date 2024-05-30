using System.Windows.Forms;
using System.Drawing;
using System;

public class CoinManager
{
    public int CoinCount { get; set; } = 0;
    private PictureBox coin;
    private Timer coinTimer = new Timer();
    private Random random = new Random();
    private GameVariables vars;
    private PictureBox dodik;

    public CoinManager(PictureBox coin, PictureBox dodik, GameVariables vars)
    {
        this.coin = coin;
        this.coin.Visible = false;
        this.dodik = dodik;
        this.vars = vars;

        coinTimer.Interval = 20;
        coinTimer.Tick += CoinTimer_Tick;
        coinTimer.Start();
    }

    public void MoveCoin()
    {
        coin.Left -= vars.Speed;
    }

    private void CoinTimer_Tick(object sender, EventArgs e)
    {
        if (coin.Left < -200)
        {
            coin.Visible = true;
            coin.Left = random.Next(750, 1300);
        }
    }

    public void CheckCollisionAndCollectCoin()
    {
        if (dodik.Bounds.IntersectsWith(coin.Bounds) && coin.Visible)
        {
            CollectCoin();
        }
    }

    public void CollectCoin()
    {
        CoinCount++;
        coin.Visible = false;
    }

    public void ResetCoins()
    {
        CoinCount = 0;
        coin.Left = random.Next(750, 1300);
        coin.Visible = false;
    }
}
