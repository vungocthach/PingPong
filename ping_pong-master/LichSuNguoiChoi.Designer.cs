
namespace pong
{
    partial class LichSuNguoiChoi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LichSuNguoiChoi));
            this.label1 = new System.Windows.Forms.Label();
            this.quaylai = new System.Windows.Forms.Button();
            this.lichsu = new System.Windows.Forms.Label();
            this.xoalichsu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Nueva-BoldExtended", 30F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(200, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lịch sử";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // quaylai
            // 
            this.quaylai.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.quaylai.Font = new System.Drawing.Font("Nueva-BoldExtended", 8.25F);
            this.quaylai.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.quaylai.Location = new System.Drawing.Point(461, 41);
            this.quaylai.Name = "quaylai";
            this.quaylai.Size = new System.Drawing.Size(107, 27);
            this.quaylai.TabIndex = 1;
            this.quaylai.Text = "Quay Lại";
            this.quaylai.UseVisualStyleBackColor = false;
            this.quaylai.Click += new System.EventHandler(this.button1_Click);
            // 
            // lichsu
            // 
            this.lichsu.BackColor = System.Drawing.Color.Transparent;
            this.lichsu.Font = new System.Drawing.Font("Nueva-BoldExtended", 25F, System.Drawing.FontStyle.Bold);
            this.lichsu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lichsu.Location = new System.Drawing.Point(58, 76);
            this.lichsu.Name = "lichsu";
            this.lichsu.Size = new System.Drawing.Size(497, 247);
            this.lichsu.TabIndex = 2;
            this.lichsu.Text = "Time: Point:";
            this.lichsu.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lichsu.UseCompatibleTextRendering = true;
            this.lichsu.UseWaitCursor = true;
            this.lichsu.Click += new System.EventHandler(this.lichsu_Click);
            // 
            // xoalichsu
            // 
            this.xoalichsu.Font = new System.Drawing.Font("Nueva-BoldExtended", 8.25F);
            this.xoalichsu.Location = new System.Drawing.Point(461, 12);
            this.xoalichsu.Name = "xoalichsu";
            this.xoalichsu.Size = new System.Drawing.Size(107, 23);
            this.xoalichsu.TabIndex = 3;
            this.xoalichsu.Text = "Xóa lịch sử";
            this.xoalichsu.UseVisualStyleBackColor = true;
            this.xoalichsu.Click += new System.EventHandler(this.xoalichsu_Click);
            // 
            // LichSuNguoiChoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(597, 349);
            this.Controls.Add(this.xoalichsu);
            this.Controls.Add(this.quaylai);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lichsu);
            this.DoubleBuffered = true;
            this.Name = "LichSuNguoiChoi";
            this.Text = "LichSuNguoiChoi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button quaylai;
        private System.Windows.Forms.Label lichsu;
        private System.Windows.Forms.Button xoalichsu;
    }
}