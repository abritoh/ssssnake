using System;
using System.Windows.Forms;

namespace ClusterBR
{
    /// <summary>
    /// SSSSSSnake v1.0
    /// </summary>
    /// <date>2025-01-11</date>    
    /// <author>ArBR | arcebrito@gmail.com</author>
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SSSnakeForm());
        }
    }

    enum Directions {
        Up,
        Down,
        Left,
        Right
    }

    class Settings {
        public static int
            TIMER_TIME = 320,
            GRID_DIMENSION_X = 30,
            GRID_DIMENSION_Y = 25,
            GRID_ITEM_SIZE = 25,
            BTN_BAR_AREA_HEIGHT = 60,
            GRID_POS_Y_OFFSET = 6,
            FORM_W = 800,
            FORM_H = 800,
            MAX_SCORE_LBL_X = 10
        ;
        public static string
            APP_NAME = "ssssssnake v1.0",
            ClusterBR = "ClusterBR",
            DEV_EMAIL = "arcebrito@gmail.com.com",
            SCREEN_SHOT_FILE_PATH = "ssssssnake-max-score.png",
            MSG_GAME_OVER = "Game Over!\n Press R to Restart!",
            MSG_MAX_SCORE_INFO = "No max score to show, play a round!"
        ;
    }
}
