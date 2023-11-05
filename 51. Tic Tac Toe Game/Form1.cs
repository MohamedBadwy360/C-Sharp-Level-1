using _51.Tic_Tac_Toe_Game.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _51.Tic_Tac_Toe_Game
{
    public partial class Form1 : Form
    {
        stGameStatus GameStatus;
        enum enWinner
        {
            Player1,
            Player2,
            Draw,
            GameInProgress
        }
        struct stGameStatus
        {
            public enWinner Winner;
            public byte PlayCount;
            public bool GameOver;
        }
        enum enPlayer { Player1, Player2};

        enPlayer PlayerTurn = enPlayer.Player1;

        public bool CheckValues(Button btn1, Button btn2, Button btn3)
        {
            if (btn1.Tag.ToString() != "?" && btn1.Tag.ToString() == btn2.Tag.ToString() && btn1.Tag.ToString() == btn3.Tag.ToString())
            {
                btn1.BackColor = Color.GreenYellow;
                btn2.BackColor = Color.GreenYellow;
                btn3.BackColor = Color.GreenYellow;

                if (btn1.Tag.ToString() == "X")
                {
                    GameStatus.Winner = enWinner.Player1;
                    GameStatus.GameOver = true;
                    EndGame();
                    return true;
                }
                else
                {
                    GameStatus.Winner = enWinner.Player2;
                    GameStatus.GameOver = true;
                    EndGame();
                    return true;
                }
            }

            GameStatus.GameOver = false;
            return false;
        }

        public void CheckWinner()
        {
            if (CheckValues(button1, button2, button3))
                return;

            //check Row2
            if (CheckValues(button4, button5, button6))
                return;

            //check Row3
            if (CheckValues(button7, button8, button9))
                return;

            //checked cols
            //check col1
            if (CheckValues(button3, button4, button7))
                return;

            //check col2
            if (CheckValues(button2, button5, button8))
                return;

            //check col3
            if (CheckValues(button1, button6, button9))
                return;

            //check Diagonal

            //check Diagonal1
            if (CheckValues(button1, button5, button7))
                return;

            //check Diagonal2
            if (CheckValues(button3, button5, button9))
                return;

        }
        void EndGame()
        {
            lblTurn.Text = "Game Over";

            switch (GameStatus.Winner)
            {
                case enWinner.Player1:
                    lblWinner.Text = "Player1";
                    break;

                case enWinner.Player2:
                    lblWinner.Text = "Player2";
                    break;

                default:
                    lblWinner.Text = "Draw";
                    break;
            }

            MessageBox.Show("Game Over", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void ChangeImage(Button btn)
        {
            if (btn.Tag.ToString() == "?")
            {
                switch(PlayerTurn)
                {
                    case enPlayer.Player1:
                        btn.Image = Resources.X;
                        btn.Tag = "X";
                        PlayerTurn = enPlayer.Player2;
                        lblTurn.Text = "Player2";
                        GameStatus.PlayCount++;
                        CheckWinner();
                        break;

                    case enPlayer.Player2:
                        btn.Image = Resources.O;
                        btn.Tag = "O";
                        PlayerTurn = enPlayer.Player1;
                        GameStatus.PlayCount++;
                        lblTurn.Text = "Player1";
                        CheckWinner();
                        break;
                }

            }
            else

            {
                MessageBox.Show("Wrong Choice", "Worng", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (GameStatus.PlayCount == 9)
            {
                GameStatus.GameOver = true;
                GameStatus.Winner = enWinner.Draw;
                EndGame();
            }
        }
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Paint_Form1(object sender, PaintEventArgs e)
        {
            Color White = Color.FromArgb(255, 255, 255, 255);
            Pen pen = new Pen(White);

            pen.Width = 10;

            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            // Vertical Lines
            e.Graphics.DrawLine(pen, 600, 140, 600, 580);
            e.Graphics.DrawLine(pen, 830, 140, 830, 580);

            // Horizontal Lines
            e.Graphics.DrawLine(pen, 380, 280, 1030, 280);
            e.Graphics.DrawLine(pen, 380, 440, 1030, 440);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChangeImage(button1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ChangeImage(button2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ChangeImage(button3);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ChangeImage(button6);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ChangeImage(button5);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ChangeImage(button4);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ChangeImage(button9);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ChangeImage(button8);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ChangeImage(button7);
        }

        private void ResetButton(Button btn)
        {
            btn.Image = Resources.question_mark_96;
            btn.Tag = "?";
            btn.BackColor = Color.Transparent;
        }

        private void Restart()
        {
            ResetButton(button1);
            ResetButton(button2);
            ResetButton(button3);
            ResetButton(button4);
            ResetButton(button5);
            ResetButton(button6);
            ResetButton(button7);
            ResetButton(button8);
            ResetButton(button9);

            lblTurn.Text = "Player1";
            lblWinner.Text = "In Progress";
            GameStatus.Winner = enWinner.GameInProgress;
            GameStatus.PlayCount = 0;
            GameStatus.GameOver = false;
            PlayerTurn = enPlayer.Player1;
        }
        private void btnRestart_Click(object sender, EventArgs e)
        {
            Restart();
        }
    }
}
