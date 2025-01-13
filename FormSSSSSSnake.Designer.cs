namespace ClusterBR
{
    partial class SSSnakeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SSSnakeForm));
            this.StatusStripBottom = new System.Windows.Forms.StatusStrip();
            this.LabelMaxScore = new System.Windows.Forms.ToolStripStatusLabel();
            this.LabelCurrentScore2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.LabelXY = new System.Windows.Forms.ToolStripStatusLabel();
            this.GroupBoxButtons = new System.Windows.Forms.GroupBox();
            this.ToolStripButtons = new System.Windows.Forms.ToolStrip();
            this.ButtonPlay = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.ButtonExit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.LabelCurrentScore1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.LabelMessage = new System.Windows.Forms.ToolStripLabel();
            this.ButtonShowInfo = new System.Windows.Forms.ToolStripButton();
            this.ButtonShowMaxScore = new System.Windows.Forms.ToolStripButton();
            this.StatusStripBottom.SuspendLayout();
            this.GroupBoxButtons.SuspendLayout();
            this.ToolStripButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // StatusStripBottom
            // 
            this.StatusStripBottom.BackColor = System.Drawing.Color.Black;
            this.StatusStripBottom.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LabelMaxScore,
            this.LabelCurrentScore2,
            this.LabelXY});
            this.StatusStripBottom.Location = new System.Drawing.Point(0, 442);
            this.StatusStripBottom.Name = "StatusStripBottom";
            this.StatusStripBottom.Size = new System.Drawing.Size(835, 32);
            this.StatusStripBottom.TabIndex = 1;
            this.StatusStripBottom.Text = "statusStrip1";
            // 
            // LabelMaxScore
            // 
            this.LabelMaxScore.Font = new System.Drawing.Font("Snap ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelMaxScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LabelMaxScore.Name = "LabelMaxScore";
            this.LabelMaxScore.Size = new System.Drawing.Size(162, 27);
            this.LabelMaxScore.Text = "Max Score: 0";
            // 
            // LabelCurrentScore2
            // 
            this.LabelCurrentScore2.Font = new System.Drawing.Font("Snap ITC", 15.75F);
            this.LabelCurrentScore2.ForeColor = System.Drawing.Color.Lime;
            this.LabelCurrentScore2.Name = "LabelCurrentScore2";
            this.LabelCurrentScore2.Size = new System.Drawing.Size(114, 27);
            this.LabelCurrentScore2.Text = "Score: 0";
            // 
            // LabelXY
            // 
            this.LabelXY.BackColor = System.Drawing.Color.Black;
            this.LabelXY.Font = new System.Drawing.Font("Snap ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelXY.ForeColor = System.Drawing.Color.LightCyan;
            this.LabelXY.Name = "LabelXY";
            this.LabelXY.Size = new System.Drawing.Size(125, 27);
            this.LabelXY.Text = "X,Y={0,0}";
            // 
            // GroupBoxButtons
            // 
            this.GroupBoxButtons.Controls.Add(this.ToolStripButtons);
            this.GroupBoxButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.GroupBoxButtons.Font = new System.Drawing.Font("Snap ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBoxButtons.Location = new System.Drawing.Point(0, 0);
            this.GroupBoxButtons.Name = "GroupBoxButtons";
            this.GroupBoxButtons.Size = new System.Drawing.Size(835, 78);
            this.GroupBoxButtons.TabIndex = 2;
            this.GroupBoxButtons.TabStop = false;
            // 
            // ToolStripButtons
            // 
            this.ToolStripButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(210)))), ((int)(((byte)(40)))));
            this.ToolStripButtons.ImageScalingSize = new System.Drawing.Size(64, 64);
            this.ToolStripButtons.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ButtonPlay,
            this.toolStripSeparator3,
            this.ButtonExit,
            this.toolStripSeparator1,
            this.LabelCurrentScore1,
            this.toolStripSeparator2,
            this.LabelMessage,
            this.ButtonShowInfo,
            this.ButtonShowMaxScore});
            this.ToolStripButtons.Location = new System.Drawing.Point(3, 19);
            this.ToolStripButtons.MaximumSize = new System.Drawing.Size(0, 50);
            this.ToolStripButtons.Name = "ToolStripButtons";
            this.ToolStripButtons.Size = new System.Drawing.Size(829, 50);
            this.ToolStripButtons.TabIndex = 0;
            this.ToolStripButtons.Text = "toolStrip1";
            // 
            // ButtonPlay
            // 
            this.ButtonPlay.BackColor = System.Drawing.Color.Lime;
            this.ButtonPlay.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ButtonPlay.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonPlay.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonPlay.Name = "ButtonPlay";
            this.ButtonPlay.Size = new System.Drawing.Size(95, 47);
            this.ButtonPlay.Text = "S T  A R T";
            this.ButtonPlay.ToolTipText = "Start/Restart the game [keyboard: r]";
            this.ButtonPlay.Click += new System.EventHandler(this.toolStripButtonPlay_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 50);
            // 
            // ButtonExit
            // 
            this.ButtonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ButtonExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ButtonExit.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonExit.Image = ((System.Drawing.Image)(resources.GetObject("ButtonExit.Image")));
            this.ButtonExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(75, 47);
            this.ButtonExit.Text = "E  X I T";
            this.ButtonExit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.ButtonExit.ToolTipText = "Exit the game";
            this.ButtonExit.Click += new System.EventHandler(this.toolStripButtonExit_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 50);
            // 
            // LabelCurrentScore1
            // 
            this.LabelCurrentScore1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.LabelCurrentScore1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.LabelCurrentScore1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.LabelCurrentScore1.Font = new System.Drawing.Font("Snap ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCurrentScore1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(10)))), ((int)(((byte)(246)))));
            this.LabelCurrentScore1.Name = "LabelCurrentScore1";
            this.LabelCurrentScore1.Size = new System.Drawing.Size(133, 47);
            this.LabelCurrentScore1.Text = "SCORE: 0";
            this.LabelCurrentScore1.ToolTipText = "Current score";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 50);
            // 
            // LabelMessage
            // 
            this.LabelMessage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.LabelMessage.Font = new System.Drawing.Font("Snap ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelMessage.Name = "LabelMessage";
            this.LabelMessage.Size = new System.Drawing.Size(36, 47);
            this.LabelMessage.Text = "...";
            // 
            // ButtonShowInfo
            // 
            this.ButtonShowInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ButtonShowInfo.Image = ((System.Drawing.Image)(resources.GetObject("ButtonShowInfo.Image")));
            this.ButtonShowInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonShowInfo.Name = "ButtonShowInfo";
            this.ButtonShowInfo.Size = new System.Drawing.Size(68, 47);
            this.ButtonShowInfo.Text = "toolStripButton1";
            this.ButtonShowInfo.ToolTipText = "Pause / About SSSSSSnake [SPACE]";
            this.ButtonShowInfo.Click += new System.EventHandler(this.toolStripButtonInfo_Click);
            // 
            // ButtonShowMaxScore
            // 
            this.ButtonShowMaxScore.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ButtonShowMaxScore.Image = ((System.Drawing.Image)(resources.GetObject("ButtonShowMaxScore.Image")));
            this.ButtonShowMaxScore.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonShowMaxScore.Name = "ButtonShowMaxScore";
            this.ButtonShowMaxScore.Size = new System.Drawing.Size(68, 47);
            this.ButtonShowMaxScore.Text = "toolStripButton1";
            this.ButtonShowMaxScore.ToolTipText = "Pause / Show max-score [keyboard: m]";
            this.ButtonShowMaxScore.Click += new System.EventHandler(this.toolStripButtonMaxScore_Click);
            // 
            // SSSnakeForm
            // 
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(835, 474);
            this.Controls.Add(this.GroupBoxButtons);
            this.Controls.Add(this.StatusStripBottom);
            this.Font = new System.Drawing.Font("Snap ITC", 20.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SSSnakeForm";
            this.Text = "ssssssnake v1.0";
            this.StatusStripBottom.ResumeLayout(false);
            this.StatusStripBottom.PerformLayout();
            this.GroupBoxButtons.ResumeLayout(false);
            this.GroupBoxButtons.PerformLayout();
            this.ToolStripButtons.ResumeLayout(false);
            this.ToolStripButtons.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip StatusStripBottom;
        private System.Windows.Forms.GroupBox GroupBoxButtons;
        private System.Windows.Forms.ToolStrip ToolStripButtons;
        private System.Windows.Forms.ToolStripButton ButtonPlay;
        private System.Windows.Forms.ToolStripButton ButtonExit;
        private System.Windows.Forms.ToolStripLabel LabelCurrentScore1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel LabelMessage;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripStatusLabel LabelXY;
        private System.Windows.Forms.ToolStripButton ButtonShowInfo;
        private System.Windows.Forms.ToolStripButton ButtonShowMaxScore;
        private System.Windows.Forms.ToolStripStatusLabel LabelMaxScore;
        private System.Windows.Forms.ToolStripStatusLabel LabelCurrentScore2;
    }
}