namespace Breakout_Game
{
    partial class Breakout_Game
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
            components = new System.ComponentModel.Container();
            gameTimer = new System.Windows.Forms.Timer(components);
            txtScore = new Label();
            player = new PictureBox();
            ball = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)player).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ball).BeginInit();
            SuspendLayout();
            // 
            // gameTimer
            // 
            gameTimer.Interval = 20;
            gameTimer.Tick += mainGameTimerEvent;
            // 
            // txtScore
            // 
            txtScore.AutoSize = true;
            txtScore.BackColor = Color.Transparent;
            txtScore.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtScore.ForeColor = Color.White;
            txtScore.Location = new Point(7, 10);
            txtScore.Name = "txtScore";
            txtScore.Size = new Size(98, 23);
            txtScore.TabIndex = 0;
            txtScore.Text = "Score: 0";
            // 
            // player
            // 
            player.BackColor = Color.White;
            player.Location = new Point(349, 415);
            player.Name = "player";
            player.Size = new Size(100, 32);
            player.TabIndex = 1;
            player.TabStop = false;
            // 
            // ball
            // 
            ball.BackColor = Color.Yellow;
            ball.Location = new Point(389, 389);
            ball.Name = "ball";
            ball.Size = new Size(20, 20);
            ball.TabIndex = 2;
            ball.TabStop = false;
            // 
            // Breakout_Game
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(ball);
            Controls.Add(player);
            Controls.Add(txtScore);
            Name = "Breakout_Game";
            Text = "Breakout Game";
            KeyDown += keyisdown;
            KeyUp += keyisup;
            ((System.ComponentModel.ISupportInitialize)player).EndInit();
            ((System.ComponentModel.ISupportInitialize)ball).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer gameTimer;
        private Label txtScore;
        private PictureBox player;
        private PictureBox ball;
    }
}