using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Threading;

/// <summary>
/// A rock, paper, scissors game that utilizes basic methods
/// for repetitive tasks.
/// </summary>

namespace RockPaperScissors
{
    public partial class Form1 : Form
    {
        string playerChoice, cpuChoice;

        int wins = 0;
        int losses = 0;
        int ties = 0;
        int choicePause = 1000;
        int outcomePause = 3000;

        Random randGen = new Random();

        SoundPlayer jabPlayer = new SoundPlayer(Properties.Resources.jabSound);
        SoundPlayer gongPlayer = new SoundPlayer(Properties.Resources.gong);

        Image rockImage = Properties.Resources.rock168x280;
        Image paperImage = Properties.Resources.paper168x280;
        Image scissorImage = Properties.Resources.scissors168x280;
        Image winImage = Properties.Resources.winTrans;
        Image loseImage = Properties.Resources.loseTrans;
        Image tieImage = Properties.Resources.tieTrans;

        public Form1()
        {
            InitializeComponent();
        }

        private void rockButton_Click(object sender, EventArgs e)
        {
            /// TODO Set the playerchoice value, show the appropriate image,
            /// play a sound, wait for a second; repeat for the computer turn
            int value = randGen.Next(1, 4);

            playerChoice = "Rock";
            playerImage.BackgroundImage = rockImage;

            if (value == 1)
            {
                cpuChoice = "Rock";
                cpuImage.BackgroundImage = rockImage;
            }
            else if (value == 2)
            {
                cpuImage.BackgroundImage = paperImage;
                cpuChoice = "Paper";
            }
            else if (value == 3)
            {
                cpuImage.BackgroundImage = scissorImage;
                cpuChoice = "Scissors";
            }

            jabPlayer.Play();
            Refresh();
            Thread.Sleep(choicePause);

            if (playerChoice == cpuChoice)
            {
                resultImage.BackgroundImage = tieImage;
                ties++;
                tiesLabel.Text = $"Ties: {ties}";
            }
            else if (cpuChoice == "scissors") 
            {
                resultImage.BackgroundImage = winImage;
                wins++;
                winsLabel.Text = $"Wins: {wins}";
            }
            else
            {
                resultImage.BackgroundImage = loseImage;
                losses++;
                lossesLabel.Text = $"Losses: {losses}";
            }

            gongPlayer.Play();
            Refresh();
            Thread.Sleep(outcomePause);

            playerImage.BackgroundImage = null;
            cpuImage.BackgroundImage = null;
            resultImage.BackgroundImage = null;
        }

        private void paperButton_Click(object sender, EventArgs e)
        {
            int value = randGen.Next(1, 4);

            playerChoice = "Paper";
            playerImage.BackgroundImage = paperImage;

            if (value == 1)
            {
                cpuChoice = "Rock";
                cpuImage.BackgroundImage = rockImage;
            }
            else if (value == 2)
            {
                cpuImage.BackgroundImage = paperImage;
                cpuChoice = "Paper";
            }
            else if (value == 3)
            {
                cpuImage.BackgroundImage = scissorImage;
                cpuChoice = "Scissors";
            }

            jabPlayer.Play();
            Refresh();
            Thread.Sleep(choicePause);

            if (playerChoice == cpuChoice)
            {
                resultImage.BackgroundImage = tieImage;
                ties++;
                tiesLabel.Text = $"Ties: {ties}";
            }
            else if (cpuChoice == "Rock")
            {
                resultImage.BackgroundImage = winImage;
                wins++;
                winsLabel.Text = $"Wins: {wins}";
            }
            else
            {
                resultImage.BackgroundImage = loseImage;
                losses++;
                lossesLabel.Text = $"Losses: {losses}";
            }

            gongPlayer.Play();
            Refresh();
            Thread.Sleep(outcomePause);

            playerImage.BackgroundImage = null;
            cpuImage.BackgroundImage = null;
            resultImage.BackgroundImage = null;
        }

        private void resultImage_Click(object sender, EventArgs e)
        {

        }

        private void scissorsButton_Click(object sender, EventArgs e)
        {
            int value = randGen.Next(1, 4);

            playerChoice = "Scissors";
            playerImage.BackgroundImage = scissorImage;

            if (value == 1)
            {
                cpuChoice = "Rock";
                cpuImage.BackgroundImage = rockImage;
            }
            else if (value == 2)
            {
                cpuImage.BackgroundImage = paperImage;
                cpuChoice = "Paper";
            }
            else if (value == 3)
            {
                cpuImage.BackgroundImage = scissorImage;
                cpuChoice = "Scissors";
            }

            jabPlayer.Play();
            Refresh();
            Thread.Sleep(choicePause);

            if (playerChoice == cpuChoice)
            {
                resultImage.BackgroundImage = tieImage;
                ties++;
                tiesLabel.Text = $"Ties: {ties}";
            }
            else if (cpuChoice == "Paper")
            {
                resultImage.BackgroundImage = winImage;
                wins++;
                winsLabel.Text = $"Wins: {wins}";
            }
            else
            {
                resultImage.BackgroundImage = loseImage;
                losses++;
                lossesLabel.Text = $"Losses: {losses}";
            }

            gongPlayer.Play();
            Refresh();
            Thread.Sleep(outcomePause);

            playerImage.BackgroundImage = null;
            cpuImage.BackgroundImage = null;
            resultImage.BackgroundImage = null;
        }
    }
}