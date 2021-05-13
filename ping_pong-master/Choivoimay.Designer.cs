
namespace pong
{
    partial class Choivoimay
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
            this.thanhngang = new System.Windows.Forms.PictureBox();
            this.Ball = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.playground = new System.Windows.Forms.Panel();
            this.clickstart = new System.Windows.Forms.Label();
            this.pause_label = new System.Windows.Forms.Label();
            this.gameover = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.thanhngang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).BeginInit();
            this.playground.SuspendLayout();
            this.SuspendLayout();
            // 
            // thanhngang
            // 
            this.thanhngang.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.thanhngang.Location = new System.Drawing.Point(578, 484);
            this.thanhngang.Name = "thanhngang";
            this.thanhngang.Size = new System.Drawing.Size(200, 20);
            this.thanhngang.TabIndex = 0;
            this.thanhngang.TabStop = false;
            this.thanhngang.Click += new System.EventHandler(this.thanhngang_Click);
            // 
            // Ball
            // 
            this.Ball.BackColor = System.Drawing.Color.Blue;
            this.Ball.Location = new System.Drawing.Point(708, 313);
            this.Ball.Name = "Ball";
            this.Ball.Size = new System.Drawing.Size(20, 20);
            this.Ball.TabIndex = 1;
            this.Ball.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // playground
            // 
            this.playground.BackColor = System.Drawing.Color.Plum;
            this.playground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.playground.Controls.Add(this.clickstart);
            this.playground.Controls.Add(this.pause_label);
            this.playground.Controls.Add(this.gameover);
            this.playground.Controls.Add(this.label2);
            this.playground.Controls.Add(this.label1);
            this.playground.Controls.Add(this.thanhngang);
            this.playground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playground.Location = new System.Drawing.Point(0, 0);
            this.playground.Name = "playground";
            this.playground.Size = new System.Drawing.Size(938, 516);
            this.playground.TabIndex = 2;
            this.playground.Click += new System.EventHandler(this.playground_Click);
            this.playground.Paint += new System.Windows.Forms.PaintEventHandler(this.playground_Paint);
            // 
            // clickstart
            // 
            this.clickstart.AutoSize = true;
            this.clickstart.Font = new System.Drawing.Font("Nueva-BoldExtended", 30F, System.Drawing.FontStyle.Bold);
            this.clickstart.Location = new System.Drawing.Point(326, 241);
            this.clickstart.Name = "clickstart";
            this.clickstart.Size = new System.Drawing.Size(324, 52);
            this.clickstart.TabIndex = 6;
            this.clickstart.Text = "Click to Start";
            this.clickstart.Click += new System.EventHandler(this.clickstart_Click);
            // 
            // pause_label
            // 
            this.pause_label.AutoSize = true;
            this.pause_label.Font = new System.Drawing.Font("Nueva-BoldExtended", 30F, System.Drawing.FontStyle.Bold);
            this.pause_label.Location = new System.Drawing.Point(399, 241);
            this.pause_label.Name = "pause_label";
            this.pause_label.Size = new System.Drawing.Size(179, 52);
            this.pause_label.TabIndex = 5;
            this.pause_label.Text = "Pause !";
            this.pause_label.Click += new System.EventHandler(this.pause_Click);
            this.pause_label.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pause_label_MouseClick);
            // 
            // gameover
            // 
            this.gameover.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.gameover.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gameover.AutoSize = true;
            this.gameover.Font = new System.Drawing.Font("Nueva-BoldExtended", 30F, System.Drawing.FontStyle.Bold);
            this.gameover.Location = new System.Drawing.Point(347, 192);
            this.gameover.Name = "gameover";
            this.gameover.Size = new System.Drawing.Size(280, 208);
            this.gameover.TabIndex = 4;
            this.gameover.Text = "Game over \r\n\r\nF1 Restart\r\nESC Exit\r\n";
            this.gameover.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.gameover.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(85, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "0";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Score: ";
            // 
            // Choivoimay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(938, 516);
            this.Controls.Add(this.Ball);
            this.Controls.Add(this.playground);
            this.Name = "Choivoimay";
            this.Text = "Form1";
            this.Click += new System.EventHandler(this.Choivoimay_Click);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Choivoimay_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Choivoimay_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.thanhngang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).EndInit();
            this.playground.ResumeLayout(false);
            this.playground.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox thanhngang;
        private System.Windows.Forms.PictureBox Ball;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel playground;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label gameover;
        private System.Windows.Forms.Label pause_label;
        private System.Windows.Forms.Label clickstart;
    }
}