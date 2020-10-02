#region Using Statements
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
#endregion

namespace Yahtzeespel2
{
    public partial class Form1 : Form
    {
        #region Declaration

        Image[] diceImages;
        Player player1, player2;


        #endregion

        #region Initialization

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            player1 = new Player("Speler1");
            player2 = new Player("Speler2");

            lbl_p1Name.Text = player1.Name;
            lbl_p2Name.Text = player2.Name;

            diceImages = new Image[7];
            diceImages[0] = Properties.Resources.blank;
            diceImages[1] = Properties.Resources._1;
            diceImages[2] = Properties.Resources._2;
            diceImages[3] = Properties.Resources._3;
            diceImages[4] = Properties.Resources._4;
            diceImages[5] = Properties.Resources._5;
            diceImages[6] = Properties.Resources._6;

        }

        #endregion

        #region Private Methods

        private void Rollen1_Click(object sender, EventArgs e)
        {
            if (!player1.Played)
            {
                player1.RollDice();

                P1dobbel_1.Image = diceImages[player1.Dice[0]];
                P1dobbel_2.Image = diceImages[player1.Dice[0]];
                P1dobbel_3.Image = diceImages[player1.Dice[0]];
                P1dobbel_4.Image = diceImages[player1.Dice[0]];
                P1dobbel_5.Image = diceImages[player1.Dice[0]];
                lblP1_displayResults.Text = player1.Result;

                player1.Played = true;

                CheckWinner();

            }
        }

        private void Rollen2_Click(object sender, EventArgs e)
        {
            if (!player2.Played)
            {
                player2.RollDice();

                P2dobbel_1.Image = diceImages[player2.Dice[0]];
                P2dobbel_2.Image = diceImages[player2.Dice[0]];
                P2dobbel_3.Image = diceImages[player2.Dice[0]];
                P2dobbel_4.Image = diceImages[player2.Dice[0]];
                P2dobbel_5.Image = diceImages[player2.Dice[0]];
                lblP2_displayResults.Text = player2.Result;

                player2.Played = true;

                CheckWinner();

            }
        }

        private void CheckWinner()
        {
            if (player1.Played && player2.Played)
            {
                if (player1.HandRank > player2.HandRank)
                {
                    lbl_winnerResult.Text = player1.Name + "Wins!";

                }
                else if (player2.HandRank > player1.HandRank)
                {
                    lbl_winnerResult.Text = player1.Name + "Wins!";
                }
                else if (player1.HandRank == 8 && player2.HandRank == 8)
                {
                    if (player1.Mod1 > player2.Mod1 &&
                        player1.Mod1 > player2.Mod2)
                    {
                        lbl_winnerResult.Text = player1.Name + "Wins!";
                    }
                    else if (player1.Mod2 > player2.Mod1 &&
                        player1.Mod2 > player2.Mod2)
                    {
                        lbl_winnerResult.Text = player1.Name + "Wins!";
                    }
                    else if (player1.Mod1 == player2.Mod1 &&
                        player1.Mod2 == player2.Mod2 ||
                        player1.Mod2 == player2.Mod1 &&
                        player1.Mod1 == player2.Mod2)
                    {
                        lbl_winnerResult.Text = player1.Name + "Wins!";
                    }
                    if (player1.Mod3 > player2.Mod3)
                    {
                        lbl_winnerResult.Text = player1.Name + "Wins!";
                    }
                    else if (player2.Mod3 > player1.Mod3)
                    {
                        lbl_winnerResult.Text = player2.Name + "Wins!";
                    }
                    else
                    {
                        lbl_winnerResult.Text = player1.Name + " Ties " + player2.Name;
                    }


                }
            }
            else if (player1.HandRank == player2.HandRank)
            {
                if (player1.Mod1 > player2.Mod1)
                    lbl_winnerResult.Text = player1.Name + "Wins!";
                else if (player2.Mod1 > player1.HandRank)
                    lbl_winnerResult.Text = player2.Name + "Wins!";
                else if (player1.Mod1 == player2.Mod1)
                {
                    if (player1.Mod2 > player2.Mod2)
                        lbl_winnerResult.Text = player1.Name + "Wins!";
                    else if (player1.Mod2 > player2.Mod2)
                        lbl_winnerResult.Text = player2.Name + "Wins!";
                    else if (player1.Mod2 > player2.Mod2)
                    {
                        if (player1.Mod3 > player2.Mod3)
                            lbl_winnerResult.Text = player1.Name + "Wins!";
                        else if (player1.Mod3 > player2.Mod3)
                            lbl_winnerResult.Text = player2.Name + "Wins!";
                        else if (player1.Mod3 > player2.Mod3)
                            lbl_winnerResult.Text = player1.Name + " Ties " + player2.Name;
                    }
                }
            }
            player1.ResetPlayer();
            player2.ResetPlayer();

        }
        else if (player1.Played && !player2.Played)
            lbl_winnerResult.Text = player1.Name + " waiting for " + player2.Name + " to roll: ";
        else if (player2.Played && !player1.Played)
            lbl_winnerResult.Text = player1.Name + " waiting for " + player2.Name + " to roll: ";
     

        #endregion

    }
}

