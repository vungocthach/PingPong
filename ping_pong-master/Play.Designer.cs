namespace pong
{
    partial class Play
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Play));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.points1 = new System.Windows.Forms.Label();
            this.points2 = new System.Windows.Forms.Label();
            this.pause_txt = new System.Windows.Forms.Label();
            this.paddle = new System.Windows.Forms.PictureBox();
            this.paddle2 = new System.Windows.Forms.PictureBox();
            this.ball = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.paddle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paddle2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.moveBall);
            // 
            // points1
            // 
            this.points1.AutoSize = true;
            this.points1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.points1.ForeColor = System.Drawing.Color.Black;
            this.points1.Location = new System.Drawing.Point(16, 585);
            this.points1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.points1.Name = "points1";
            this.points1.Size = new System.Drawing.Size(84, 20);
            this.points1.TabIndex = 3;
            this.points1.Text = "Player: 0";
            this.points1.Click += new System.EventHandler(this.points1_Click);
            // 
            // points2
            // 
            this.points2.AutoSize = true;
            this.points2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.points2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.points2.Location = new System.Drawing.Point(16, 10);
            this.points2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.points2.Name = "points2";
            this.points2.Size = new System.Drawing.Size(69, 20);
            this.points2.TabIndex = 4;
            this.points2.Text = "CPU: 0";
            this.points2.Click += new System.EventHandler(this.points2_Click);
            // 
            // pause_txt
            // 
            this.pause_txt.AutoSize = true;
            this.pause_txt.ForeColor = System.Drawing.Color.White;
            this.pause_txt.Location = new System.Drawing.Point(168, 308);
            this.pause_txt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pause_txt.Name = "pause_txt";
            this.pause_txt.Size = new System.Drawing.Size(56, 17);
            this.pause_txt.TabIndex = 5;
            this.pause_txt.Text = "Paused";
            this.pause_txt.Click += new System.EventHandler(this.pause_txt_Click);
            // 
            // paddle
            // 
            this.paddle.BackColor = System.Drawing.Color.Black;
            this.paddle.Location = new System.Drawing.Point(16, 543);
            this.paddle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.paddle.Name = "paddle";
            this.paddle.Size = new System.Drawing.Size(267, 25);
            this.paddle.TabIndex = 6;
            this.paddle.TabStop = false;
            this.paddle.Click += new System.EventHandler(this.paddle_Click);
            // 
            // paddle2
            // 
            this.paddle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.paddle2.Location = new System.Drawing.Point(16, 34);
            this.paddle2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.paddle2.Name = "paddle2";
            this.paddle2.Size = new System.Drawing.Size(267, 25);
            this.paddle2.TabIndex = 7;
            this.paddle2.TabStop = false;
            this.paddle2.Click += new System.EventHandler(this.paddle2_Click);
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.Yellow;
            this.ball.Location = new System.Drawing.Point(108, 252);
            this.ball.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(31, 28);
            this.ball.TabIndex = 8;
            this.ball.TabStop = false;
            this.ball.Click += new System.EventHandler(this.ball_Click);
            // 
            // Play
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1283, 617);
            this.Controls.Add(this.paddle2);
            this.Controls.Add(this.paddle);
            this.Controls.Add(this.pause_txt);
            this.Controls.Add(this.points2);
            this.Controls.Add(this.points1);
            this.Controls.Add(this.ball);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Play";
            this.Text = "Playground";
            this.Load += new System.EventHandler(this.Play_Load);
            this.ResizeEnd += new System.EventHandler(this.movePaddles);
            this.Click += new System.EventHandler(this.pause);
            ((System.ComponentModel.ISupportInitialize)(this.paddle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paddle2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label points1;
        private System.Windows.Forms.Label points2;
        private System.Windows.Forms.Label pause_txt;
        private System.Windows.Forms.PictureBox paddle;
        private System.Windows.Forms.PictureBox paddle2;
        private System.Windows.Forms.PictureBox ball;
    }
}

