using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Windows.Forms;

namespace ClusterBR
{
    /// <summary>
    /// SSSSSSnake v1.0
    /// </summary>
    /// <date>2025-01-11</date>    
    /// <author>ArBR | arcebrito@gmail.com</author>
    public partial class SSSnakeForm : Form {

        #region Properties
        private Point pointFood;
        private Image snakeHeadImage;
        private List<Point> snake = new List<Point>();
        private Directions currentDirection = Directions.Right;
        private Directions nextDirection = Directions.Right;        

        private Timer timerSnake;
        private int currentScore = 0;
        private int maxScore = 0;
        private bool gameOver = false;
        #endregion

        #region Contructor
        public SSSnakeForm() {

            InitializeComponent();

            this.DoubleBuffered = true;

            Settings.BTN_BAR_AREA_HEIGHT = GroupBoxButtons.Height + Settings.GRID_POS_Y_OFFSET;
            this.ClientSize = new Size(Settings.GRID_DIMENSION_X * Settings.GRID_ITEM_SIZE, 
                Settings.GRID_DIMENSION_Y * Settings.GRID_ITEM_SIZE + Settings.BTN_BAR_AREA_HEIGHT);            
            this.Size = new Size(Settings.FORM_W, Settings.FORM_H);
            snakeHeadImage = Properties.Resources.snake_head2;

            this.KeyDown += new KeyEventHandler(Form_OnKeyDown);            
            timerSnake = new Timer();
            timerSnake.Interval = Settings.TIMER_TIME;
            timerSnake.Tick += new EventHandler(GameTimer_Tick);
            timerSnake.Start();           

            snake.Add(new Point(5, 5));

            GenerateMoreFood();
            UpdateScore();
            
            this.TabIndex = 0;
            this.Focus();
            this.Shown += (sender, e) => this.Focus();
        }
        #endregion

        #region Methods
        private void DisplaySnakeCoordinates() {
            Point snakeHead = snake[0];
            UpdateScoreLabel(false);
            LabelXY.Text = string.Format("X,Y: {0},{1}", snakeHead.X, snakeHead.Y);            
        }

        private void GenerateMoreFood() {
            Random rand = new Random();
            pointFood = new Point(rand.Next(0, Settings.GRID_DIMENSION_X), rand.Next(0, Settings.GRID_DIMENSION_Y));
        }

        private void RestartTheGame() {
            currentScore = 0;
            gameOver = false;
            snake.Clear();
            
            LabelXY.Text = "...";
            UpdateScoreLabel(true);
            LabelMessage.ForeColor = Color.Black;
            LabelMessage.Text = "...";

            snake.Add(new Point(5, 5));            
            currentDirection = Directions.Right;
            nextDirection = Directions.Right;

            timerSnake.Start();
            GenerateMoreFood();

            Invalidate();
        }

        private void ShowAppInfo() {
            timerSnake.Stop();
            StringBuilder info = new StringBuilder();
            info.Append(Settings.APP_NAME + "\n\n");
            info.Append(Settings.ClusterBR + " 2025-0111\n\n");
            info.Append( Settings.DEV_EMAIL + "\n\n");
            info.Append("─0 bake the snake in the lake" + "\n\n\n");
            MessageBox.Show(info.ToString(), "About " + Settings.APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
            timerSnake.Start();
        }

        private void UpdateScore() {
            maxScore = Properties.Settings.Default.MaxScore;

            bool saveScreen = false;
            if (currentScore > maxScore) {
                maxScore = currentScore;
                Properties.Settings.Default.MaxScore = maxScore;
                Properties.Settings.Default.MaxScoreDT = DateTime.Now;
                Properties.Settings.Default.Save();
                saveScreen = true;
            }

            UpdateScoreLabel(false);

            if (saveScreen) {
                SaveMaxScoreAsScreenshot();
            }
        }

        private void UpdateScoreLabel(bool restart) {
            if (restart) {                
                LabelCurrentScore1.Text = "";
                LabelCurrentScore2.Text = "";
                maxScore = Properties.Settings.Default.MaxScore;
                LabelMaxScore.Text = string.Format("Max Score: {0}", maxScore);
            }
            else {
                LabelCurrentScore1.Text = string.Format("Score: {0}", currentScore);
                LabelCurrentScore2.Text = string.Format("Score: {0}", currentScore);
                LabelMaxScore.Text = string.Format("Max Score: {0}", maxScore);
            }
        }

        private void SaveMaxScoreAsScreenshot() {
            using (Bitmap bitmap = new Bitmap(this.ClientSize.Width + 20, this.ClientSize.Height)) {

                using (Graphics g = Graphics.FromImage(bitmap)) {                    
                    g.CopyFromScreen(this.Location.X + this.ClientRectangle.Left, this.Location.Y + this.ClientRectangle.Top, 
                        0, 0, new Size(this.ClientSize.Width + 20, this.ClientSize.Height));

                    Font newFont = new Font(this.Font.FontFamily, 16);

                    String textScore = string.Format("{0} | Max Score: {1}", Settings.APP_NAME, maxScore);
                    SizeF textScoreSize = g.MeasureString(textScore, this.Font);
                    PointF scorePosition = new PointF(Settings.MAX_SCORE_LBL_X, this.ClientSize.Height - textScoreSize.Height * 2 - 25);
                    g.DrawString(textScore, this.Font, Brushes.White, scorePosition);
                    
                    string isoDate = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss");
                    isoDate += " | " + Settings.ClusterBR;
                    SizeF dateSize = g.MeasureString(isoDate, this.Font);
                    PointF datePosition = new PointF(Settings.MAX_SCORE_LBL_X, this.ClientSize.Height - dateSize.Height - 15);
                    g.DrawString(isoDate, this.Font, Brushes.White, datePosition);
                }

                try {
                    bitmap.Save(Settings.SCREEN_SHOT_FILE_PATH, System.Drawing.Imaging.ImageFormat.Png);
                    Debug.WriteLine("(SaveMaxScoreAsScreenshot) Screenshot saved successfully at: " + Settings.SCREEN_SHOT_FILE_PATH);
                } catch(Exception ex){
                    Debug.WriteLine("[Exception] (SaveMaxScoreAsScreenshot) " + ex.ToString() );
                }
            }
        }

        private void ShowMaxScoreInfo() {

            timerSnake.Stop();

            FormScore formMaxScore = new FormScore();
            formMaxScore.ShowDialog();

            timerSnake.Start();
            this.Focus();
        }

        private void MoveTheSnake() {
            Point newHead = new Point(snake.First().X, snake.First().Y);

            switch (currentDirection) {
                case Directions.Up: newHead.Y--; break;
                case Directions.Down: newHead.Y++; break;
                case Directions.Left: newHead.X--; break;
                case Directions.Right: newHead.X++; break;
            }

            snake.Insert(0, newHead);

            //-- eat
            if (newHead == pointFood) {
                currentScore++;
                SystemSounds.Asterisk.Play();
                GenerateMoreFood();
                UpdateScore();
            }
            else {
                snake.RemoveAt(snake.Count - 1);
            }            

            currentDirection = nextDirection;
        }

        private bool CheckForCollision() {
            var head = snake.First();
            //-- snake hits the wall?
            if (head.X < 0 || head.X >= Settings.GRID_DIMENSION_X || head.Y < 0 || head.Y >= Settings.GRID_DIMENSION_Y) return true;
            //-- snake hits itself?
            if (snake.Skip(1).Any(s => s.Equals(head))) return true;
            return false;
        }
        #endregion

        #region Events
        private void Form_OnKeyDown(object sender, KeyEventArgs e) {

            if (gameOver && e.KeyCode == Keys.R) { RestartTheGame(); return; }

            if (e.KeyCode == Keys.M) { ShowMaxScoreInfo(); return; }
            if (e.KeyCode == Keys.Space) { ShowAppInfo(); return; }

            if (e.KeyCode == Keys.Up && currentDirection != Directions.Down) { nextDirection = Directions.Up; return; }
            if (e.KeyCode == Keys.Down && currentDirection != Directions.Up) { nextDirection = Directions.Down; return; }
            if (e.KeyCode == Keys.Left && currentDirection != Directions.Right) { nextDirection = Directions.Left; return; }
            if (e.KeyCode == Keys.Right && currentDirection != Directions.Left) { nextDirection = Directions.Right; return; }
        }

        protected override void OnPaint(PaintEventArgs e) {

            base.OnPaint(e);
            Graphics g = e.Graphics;

            //-- grid
            for (int y = 0; y < Settings.GRID_DIMENSION_Y; y++) {
                for (int x = 0; x < Settings.GRID_DIMENSION_X; x++) {
                    g.DrawRectangle(Pens.Green, x * Settings.GRID_ITEM_SIZE, y * Settings.GRID_ITEM_SIZE + Settings.BTN_BAR_AREA_HEIGHT, 
                        Settings.GRID_ITEM_SIZE, Settings.GRID_ITEM_SIZE);
                }
            }

            //-- snake
            for (int i = 0; i < snake.Count; i++) {
                var segment = snake[i];
                if (i == 0) {
                    PointF center = new PointF(segment.X * Settings.GRID_ITEM_SIZE + Settings.GRID_ITEM_SIZE / 2, 
                        segment.Y * Settings.GRID_ITEM_SIZE + Settings.GRID_ITEM_SIZE / 2 + Settings.BTN_BAR_AREA_HEIGHT);
                    g.TranslateTransform(center.X, center.Y);
                    switch (currentDirection) {
                        case Directions.Up: g.RotateTransform(270); break;
                        case Directions.Down: g.RotateTransform(90); break;
                        case Directions.Left: g.RotateTransform(180); break;
                        case Directions.Right: g.RotateTransform(0); break;
                    }
                    g.DrawImage(snakeHeadImage, -Settings.GRID_ITEM_SIZE / 2, -Settings.GRID_ITEM_SIZE / 2, Settings.GRID_ITEM_SIZE, Settings.GRID_ITEM_SIZE);
                    g.ResetTransform();
                }
                else {
                    g.FillRectangle(Brushes.Green, segment.X * Settings.GRID_ITEM_SIZE, segment.Y * Settings.GRID_ITEM_SIZE + Settings.BTN_BAR_AREA_HEIGHT, 
                        Settings.GRID_ITEM_SIZE, Settings.GRID_ITEM_SIZE);
                }
            }

            //-- food
            g.FillRectangle(Brushes.Red, pointFood.X * Settings.GRID_ITEM_SIZE, pointFood.Y * Settings.GRID_ITEM_SIZE + Settings.BTN_BAR_AREA_HEIGHT, 
                Settings.GRID_ITEM_SIZE, Settings.GRID_ITEM_SIZE);

            if (gameOver) {                
                LabelMessage.ForeColor = Color.Red;
                LabelMessage.Text = Settings.MSG_GAME_OVER;
            }
        }

        private void GameTimer_Tick(object sender, EventArgs e) {
            if (gameOver) return;

            MoveTheSnake();

            if (CheckForCollision()) {
                gameOver = true;
                SystemSounds.Hand.Play();
                timerSnake.Stop();
            }

            DisplaySnakeCoordinates();
            Invalidate();
        }

        private void toolStripButtonPlay_Click(object sender, EventArgs e) {
            RestartTheGame();
        }

        private void toolStripButtonExit_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void toolStripButtonInfo_Click(object sender, EventArgs e) { ShowAppInfo(); }

        private void toolStripButtonMaxScore_Click(object sender, EventArgs e) {
            ShowMaxScoreInfo();
        }        
        #endregion
    }
}


