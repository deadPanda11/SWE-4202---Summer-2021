using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        bool turn = true;
        int count = 0;
        int count_player1_wins = 0;
        int count_player2_wins = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if(turn)
            {
                button.Text = "X";
            }
            else
            {
                button.Text = "O";
            }

            turn = !turn;

            button.Enabled = false;

            count++;

            Check();
        }

        private void Check()
        {
            bool win = false;

            if((r1c1.Text == r1c2.Text) && (r1c2.Text == r1c3.Text) && (!r1c1.Enabled))
            {
                win = true;
            }

            else if ((r2c1.Text == r2c2.Text) && (r2c2.Text == r2c3.Text) && (!r2c1.Enabled))
            {
                win = true;
            }

            else if ((r3c1.Text == r3c2.Text) && (r3c2.Text == r3c3.Text) && (!r3c1.Enabled))
            {
                win = true;
            }

            else if ((r1c1.Text == r2c1.Text) && (r2c1.Text == r3c1.Text) && (!r1c1.Enabled))
            {
                win = true;
            }

            else if ((r1c2.Text == r2c2.Text) && (r2c2.Text == r3c2.Text) && (!r1c2.Enabled))
            {
                win = true;
            }

            else if ((r1c3.Text == r2c3.Text) && (r2c3.Text == r3c3.Text) && (!r1c3.Enabled))
            {
                win = true;
            }

            else if ((r1c1.Text == r2c2.Text) && (r2c2.Text == r3c3.Text) && (!r1c1.Enabled))
            {
                win = true;
            }

            else if ((r1c3.Text == r2c2.Text) && (r2c2.Text == r3c1.Text) && (!r1c3.Enabled))
            {
                win = true;
            }

            if (win)
            {
                string winner = "";

                if (turn)
                {
                    winner = "Player 2";
                    count_player2_wins++;
                    label2.Text = "Player 2: O" + "\nScore:" + count_player2_wins;
                }
                else
                {
                    winner = "Player 1";
                    count_player1_wins++;
                    label1.Text = "Player 1: X" + "\nScore:" + count_player1_wins;
                }

                MessageBox.Show(winner + " wins!");
            }

            else if(count == 9)
            {
                MessageBox.Show("Draw!");
            }
        }

        private void newgamebutton_Click(object sender, EventArgs e)
        {
            r1c1.Text = String.Empty;
            r1c2.Text = String.Empty;
            r1c3.Text = String.Empty;
            r2c1.Text = String.Empty;
            r2c2.Text = String.Empty;
            r2c3.Text = String.Empty;
            r3c1.Text = String.Empty;
            r3c2.Text = String.Empty;
            r3c3.Text = String.Empty;

            r1c1.Enabled = true;
            r1c2.Enabled = true;
            r1c3.Enabled = true;
            r2c1.Enabled = true;
            r2c2.Enabled = true;
            r2c3.Enabled = true;
            r3c1.Enabled = true;
            r3c2.Enabled = true;
            r3c3.Enabled = true;

            count = 0;
        }
    }
}
