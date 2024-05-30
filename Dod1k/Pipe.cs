using System;
using System.Windows.Forms;
using System.Drawing;

public class PipeManager
{
    private PictureBox pipeTop;
    private PictureBox pipeBottom;
    private PictureBox scriptTop;
    private PictureBox scriptBottom;
    private PictureBox dodik;
    private PictureBox ground;
    private Timer vibrationTimer;
    private GameVariables vars;
    private Random random = new Random();

    public PipeManager(PictureBox pipeTop, PictureBox pipeBottom, PictureBox scriptTop, PictureBox scriptBottom, PictureBox dodik, PictureBox ground, GameVariables vars)
    {
        this.pipeTop = pipeTop;
        this.pipeBottom = pipeBottom;
        this.scriptTop = scriptTop;
        this.scriptBottom = scriptBottom;
        this.dodik = dodik;
        this.ground = ground;
        vibrationTimer = new Timer { Interval = 20 };
        vibrationTimer.Tick += VibrationTimer_Tick;
        this.vars = vars;
    }

    private void VibrationTimer_Tick(object sender, EventArgs e)
    {
        pipeTop.Left += random.Next(-3, 8);
        pipeBottom.Left += random.Next(-3, 8);
    }

    public void UpdateVibration()
    {
        if (vars.Score >= 15 && vars.Score < 25 || vars.Score >= 50 && vars.Score < 60)
        {
            vibrationTimer.Start();
        }
        else
        {
            vibrationTimer.Stop();
        }
    }

    public void ResetPipes()
    {
        pipeTop.Left = 800;
        pipeBottom.Left = 1200;
        scriptTop.Left = 800;
        scriptBottom.Left = 1200;
    }

    public void MovePipes()
    {
        pipeTop.Left -= vars.Speed;
        pipeBottom.Left -= vars.Speed;
        scriptTop.Left -= vars.Speed;
        scriptBottom.Left -= vars.Speed;

        if (pipeBottom.Left < -150)
        {
            pipeBottom.Left = random.Next(750, 1300);
        }

        if (pipeTop.Left < -180)
        {
            pipeTop.Left = random.Next(850, 1500);
        }

        if (scriptBottom.Left < -150)
        {
            scriptBottom.Visible = true;
            scriptBottom.Left = pipeBottom.Left;
        }

        if (scriptTop.Left < -180)
        {
            scriptTop.Visible = true;
            scriptTop.Left = pipeTop.Left;
        }
    }

    public int CheckForScore(int score)
    {
        if (dodik.Bounds.IntersectsWith(scriptBottom.Bounds) && scriptBottom.Visible)
        {
            scriptBottom.Visible = false;
            score++;
        }

        if (dodik.Bounds.IntersectsWith(scriptTop.Bounds) && scriptTop.Visible)
        {
            scriptTop.Visible = false;
            score++;
        }

        return score;
    }

    public bool CheckCollisions()
    {
        if ((dodik.Bounds.IntersectsWith(pipeBottom.Bounds) ||
            dodik.Bounds.IntersectsWith(pipeTop.Bounds) ||
            dodik.Bounds.IntersectsWith(ground.Bounds) || dodik.Top < -25))
        {
            return true;
        }
        return false;
    }
}

