using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ClusterBR
{
    /// <summary>
    /// SSSSSSnake v1.0
    /// </summary>
    /// <date>2025-01-11</date>    
    /// <author>ArBR | arcebrito@gmail.com</author>
    public partial class FormScore : Form
    {
        #region Constructor
        public FormScore() {
            InitializeComponent();
            this.Width = Settings.FORM_W;
            this.Height = Settings.FORM_H;
        }
        #endregion

        #region Events
        private void FormMaxScore_Load(object sender, EventArgs e) {

            FileInfo fileInfo = new FileInfo(Settings.SCREEN_SHOT_FILE_PATH);

            if (File.Exists(Settings.SCREEN_SHOT_FILE_PATH))
            {
                LabelMaxScoreInfo.Visible = false;
                this.BackgroundImage = Image.FromFile(Settings.SCREEN_SHOT_FILE_PATH);
                this.BackgroundImageLayout = ImageLayout.Stretch;
                Invalidate();
            }
            else {
                LabelMaxScoreInfo.Visible = true;
                LabelMaxScoreInfo.Text = Settings.MSG_MAX_SCORE_INFO;
                LabelMaxScoreInfo.Left = (this.Width - LabelMaxScoreInfo.Width) / 2;
                LabelMaxScoreInfo.Top = (this.Height - LabelMaxScoreInfo.Height) / 2;
            }
        }

        private void LabelCloseMaxScore_Click(object sender, EventArgs e) {
            this.Close();
        }
        #endregion
    }
}
