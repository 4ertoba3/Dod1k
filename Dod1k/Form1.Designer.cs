namespace Dod1k
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dodik = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.pipeBottom = new System.Windows.Forms.PictureBox();
            this.pipeTop = new System.Windows.Forms.PictureBox();
            this.scoreText = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.coinText = new System.Windows.Forms.Label();
            this.coin = new System.Windows.Forms.PictureBox();
            this.scriptTop = new System.Windows.Forms.PictureBox();
            this.scriptBottom = new System.Windows.Forms.PictureBox();
            this.restartButton = new System.Windows.Forms.PictureBox();
            this.heartBoost = new System.Windows.Forms.PictureBox();
            this.speedBoost = new System.Windows.Forms.PictureBox();
            this.ghostBoost = new System.Windows.Forms.PictureBox();
            this.burgerBoost = new System.Windows.Forms.PictureBox();
            this.cost1 = new System.Windows.Forms.Label();
            this.cost2 = new System.Windows.Forms.Label();
            this.cost3 = new System.Windows.Forms.Label();
            this.cost4 = new System.Windows.Forms.Label();
            this.speedBoostText = new System.Windows.Forms.Label();
            this.ghostBoostText = new System.Windows.Forms.Label();
            this.pictureWin = new System.Windows.Forms.PictureBox();
            this.recordText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dodik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scriptTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scriptBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restartButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heartBoost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedBoost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghostBoost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.burgerBoost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureWin)).BeginInit();
            this.SuspendLayout();
            // 
            // dodik
            // 
            this.dodik.Image = ((System.Drawing.Image)(resources.GetObject("dodik.Image")));
            this.dodik.Location = new System.Drawing.Point(41, 284);
            this.dodik.Name = "dodik";
            this.dodik.Size = new System.Drawing.Size(64, 53);
            this.dodik.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dodik.TabIndex = 0;
            this.dodik.TabStop = false;
            // 
            // ground
            // 
            this.ground.BackColor = System.Drawing.Color.Transparent;
            this.ground.BackgroundImage = global::Dod1k.Properties.Resources.ground;
            this.ground.Location = new System.Drawing.Point(-17, 648);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(661, 90);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 1;
            this.ground.TabStop = false;
            // 
            // pipeBottom
            // 
            this.pipeBottom.Image = global::Dod1k.Properties.Resources.pipe;
            this.pipeBottom.Location = new System.Drawing.Point(470, 387);
            this.pipeBottom.Name = "pipeBottom";
            this.pipeBottom.Size = new System.Drawing.Size(142, 299);
            this.pipeBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeBottom.TabIndex = 2;
            this.pipeBottom.TabStop = false;
            // 
            // pipeTop
            // 
            this.pipeTop.Image = global::Dod1k.Properties.Resources.pipedown;
            this.pipeTop.Location = new System.Drawing.Point(275, -78);
            this.pipeTop.Name = "pipeTop";
            this.pipeTop.Size = new System.Drawing.Size(142, 283);
            this.pipeTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeTop.TabIndex = 3;
            this.pipeTop.TabStop = false;
            // 
            // scoreText
            // 
            this.scoreText.AutoSize = true;
            this.scoreText.BackColor = System.Drawing.Color.Transparent;
            this.scoreText.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scoreText.Location = new System.Drawing.Point(250, 682);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(91, 29);
            this.scoreText.TabIndex = 4;
            this.scoreText.Text = "Score: 0";
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // coinText
            // 
            this.coinText.AutoSize = true;
            this.coinText.BackColor = System.Drawing.Color.Transparent;
            this.coinText.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.coinText.Location = new System.Drawing.Point(3, 682);
            this.coinText.Name = "coinText";
            this.coinText.Size = new System.Drawing.Size(79, 29);
            this.coinText.TabIndex = 5;
            this.coinText.Text = "Coin: 0";
            // 
            // coin
            // 
            this.coin.Image = ((System.Drawing.Image)(resources.GetObject("coin.Image")));
            this.coin.Location = new System.Drawing.Point(480, 284);
            this.coin.Name = "coin";
            this.coin.Size = new System.Drawing.Size(35, 38);
            this.coin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coin.TabIndex = 6;
            this.coin.TabStop = false;
            // 
            // scriptTop
            // 
            this.scriptTop.Location = new System.Drawing.Point(275, 180);
            this.scriptTop.Name = "scriptTop";
            this.scriptTop.Size = new System.Drawing.Size(142, 477);
            this.scriptTop.TabIndex = 8;
            this.scriptTop.TabStop = false;
            // 
            // scriptBottom
            // 
            this.scriptBottom.Location = new System.Drawing.Point(470, -33);
            this.scriptBottom.Name = "scriptBottom";
            this.scriptBottom.Size = new System.Drawing.Size(142, 477);
            this.scriptBottom.TabIndex = 9;
            this.scriptBottom.TabStop = false;
            // 
            // restartButton
            // 
            this.restartButton.Image = ((System.Drawing.Image)(resources.GetObject("restartButton.Image")));
            this.restartButton.Location = new System.Drawing.Point(137, 223);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(378, 158);
            this.restartButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.restartButton.TabIndex = 10;
            this.restartButton.TabStop = false;
            this.restartButton.Click += new System.EventHandler(this.restartClick);
            // 
            // heartBoost
            // 
            this.heartBoost.BackColor = System.Drawing.Color.Transparent;
            this.heartBoost.Image = ((System.Drawing.Image)(resources.GetObject("heartBoost.Image")));
            this.heartBoost.Location = new System.Drawing.Point(137, 394);
            this.heartBoost.Name = "heartBoost";
            this.heartBoost.Size = new System.Drawing.Size(55, 50);
            this.heartBoost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.heartBoost.TabIndex = 11;
            this.heartBoost.TabStop = false;
            this.heartBoost.Click += new System.EventHandler(this.heartClick);
            // 
            // speedBoost
            // 
            this.speedBoost.BackColor = System.Drawing.Color.Transparent;
            this.speedBoost.Image = ((System.Drawing.Image)(resources.GetObject("speedBoost.Image")));
            this.speedBoost.Location = new System.Drawing.Point(128, 450);
            this.speedBoost.Name = "speedBoost";
            this.speedBoost.Size = new System.Drawing.Size(74, 60);
            this.speedBoost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.speedBoost.TabIndex = 12;
            this.speedBoost.TabStop = false;
            this.speedBoost.Click += new System.EventHandler(this.speedClick);
            // 
            // ghostBoost
            // 
            this.ghostBoost.BackColor = System.Drawing.Color.Transparent;
            this.ghostBoost.Image = ((System.Drawing.Image)(resources.GetObject("ghostBoost.Image")));
            this.ghostBoost.Location = new System.Drawing.Point(117, 498);
            this.ghostBoost.Name = "ghostBoost";
            this.ghostBoost.Size = new System.Drawing.Size(96, 94);
            this.ghostBoost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ghostBoost.TabIndex = 13;
            this.ghostBoost.TabStop = false;
            this.ghostBoost.Click += new System.EventHandler(this.ghostClick);
            // 
            // burgerBoost
            // 
            this.burgerBoost.Image = ((System.Drawing.Image)(resources.GetObject("burgerBoost.Image")));
            this.burgerBoost.Location = new System.Drawing.Point(321, 450);
            this.burgerBoost.Name = "burgerBoost";
            this.burgerBoost.Size = new System.Drawing.Size(96, 90);
            this.burgerBoost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.burgerBoost.TabIndex = 14;
            this.burgerBoost.TabStop = false;
            this.burgerBoost.Click += new System.EventHandler(this.burgerClick);
            // 
            // cost1
            // 
            this.cost1.AutoSize = true;
            this.cost1.BackColor = System.Drawing.Color.Transparent;
            this.cost1.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold);
            this.cost1.Location = new System.Drawing.Point(198, 404);
            this.cost1.Name = "cost1";
            this.cost1.Size = new System.Drawing.Size(24, 29);
            this.cost1.TabIndex = 15;
            this.cost1.Text = "3";
            // 
            // cost2
            // 
            this.cost2.AutoSize = true;
            this.cost2.BackColor = System.Drawing.Color.Transparent;
            this.cost2.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold);
            this.cost2.Location = new System.Drawing.Point(198, 466);
            this.cost2.Name = "cost2";
            this.cost2.Size = new System.Drawing.Size(24, 29);
            this.cost2.TabIndex = 16;
            this.cost2.Text = "5";
            // 
            // cost3
            // 
            this.cost3.AutoSize = true;
            this.cost3.BackColor = System.Drawing.Color.Transparent;
            this.cost3.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold);
            this.cost3.Location = new System.Drawing.Point(198, 525);
            this.cost3.Name = "cost3";
            this.cost3.Size = new System.Drawing.Size(24, 29);
            this.cost3.TabIndex = 17;
            this.cost3.Text = "4";
            // 
            // cost4
            // 
            this.cost4.AutoSize = true;
            this.cost4.BackColor = System.Drawing.Color.Transparent;
            this.cost4.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold);
            this.cost4.Location = new System.Drawing.Point(418, 481);
            this.cost4.Name = "cost4";
            this.cost4.Size = new System.Drawing.Size(46, 29);
            this.cost4.TabIndex = 18;
            this.cost4.Text = "100";
            // 
            // speedBoostText
            // 
            this.speedBoostText.AutoSize = true;
            this.speedBoostText.BackColor = System.Drawing.Color.Transparent;
            this.speedBoostText.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold);
            this.speedBoostText.Location = new System.Drawing.Point(3, 9);
            this.speedBoostText.Name = "speedBoostText";
            this.speedBoostText.Size = new System.Drawing.Size(63, 29);
            this.speedBoostText.TabIndex = 19;
            this.speedBoostText.Text = "SB: 0";
            // 
            // ghostBoostText
            // 
            this.ghostBoostText.AutoSize = true;
            this.ghostBoostText.BackColor = System.Drawing.Color.Transparent;
            this.ghostBoostText.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold);
            this.ghostBoostText.Location = new System.Drawing.Point(1, 38);
            this.ghostBoostText.Name = "ghostBoostText";
            this.ghostBoostText.Size = new System.Drawing.Size(65, 29);
            this.ghostBoostText.TabIndex = 20;
            this.ghostBoostText.Text = "GB: 0";
            // 
            // pictureWin
            // 
            this.pictureWin.Image = ((System.Drawing.Image)(resources.GetObject("pictureWin.Image")));
            this.pictureWin.Location = new System.Drawing.Point(453, -33);
            this.pictureWin.Name = "pictureWin";
            this.pictureWin.Size = new System.Drawing.Size(359, 322);
            this.pictureWin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureWin.TabIndex = 21;
            this.pictureWin.TabStop = false;
            // 
            // recordText
            // 
            this.recordText.AutoSize = true;
            this.recordText.BackColor = System.Drawing.Color.Transparent;
            this.recordText.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold);
            this.recordText.Location = new System.Drawing.Point(508, 682);
            this.recordText.Name = "recordText";
            this.recordText.Size = new System.Drawing.Size(104, 29);
            this.recordText.TabIndex = 22;
            this.recordText.Text = "Record: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(624, 720);
            this.Controls.Add(this.recordText);
            this.Controls.Add(this.speedBoost);
            this.Controls.Add(this.cost3);
            this.Controls.Add(this.ghostBoost);
            this.Controls.Add(this.cost4);
            this.Controls.Add(this.burgerBoost);
            this.Controls.Add(this.cost1);
            this.Controls.Add(this.cost2);
            this.Controls.Add(this.heartBoost);
            this.Controls.Add(this.coinText);
            this.Controls.Add(this.scoreText);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.pipeBottom);
            this.Controls.Add(this.pipeTop);
            this.Controls.Add(this.dodik);
            this.Controls.Add(this.pictureWin);
            this.Controls.Add(this.ghostBoostText);
            this.Controls.Add(this.speedBoostText);
            this.Controls.Add(this.restartButton);
            this.Controls.Add(this.coin);
            this.Controls.Add(this.scriptTop);
            this.Controls.Add(this.scriptBottom);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gameKeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gameKeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.dodik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scriptTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scriptBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restartButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heartBoost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedBoost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghostBoost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.burgerBoost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureWin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox dodik;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.PictureBox pipeBottom;
        private System.Windows.Forms.PictureBox pipeTop;
        private System.Windows.Forms.Label scoreText;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label coinText;
        private System.Windows.Forms.PictureBox coin;
        private System.Windows.Forms.PictureBox scriptTop;
        private System.Windows.Forms.PictureBox scriptBottom;
        private System.Windows.Forms.PictureBox restartButton;
        private System.Windows.Forms.PictureBox heartBoost;
        private System.Windows.Forms.PictureBox speedBoost;
        private System.Windows.Forms.PictureBox ghostBoost;
        private System.Windows.Forms.PictureBox burgerBoost;
        private System.Windows.Forms.Label cost1;
        private System.Windows.Forms.Label cost2;
        private System.Windows.Forms.Label cost3;
        private System.Windows.Forms.Label cost4;
        private System.Windows.Forms.Label speedBoostText;
        private System.Windows.Forms.Label ghostBoostText;
        private System.Windows.Forms.PictureBox pictureWin;
        private System.Windows.Forms.Label recordText;
    }
}

