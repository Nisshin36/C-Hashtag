/*Anh-Tu Ngoc Exercise 8 Rock Paper Scissors */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockPaperScissors
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void rockButton_Click(object sender, EventArgs e)
        {

            resultLabel.Visible = true;                                                  
            computerLabel.Visible = true;

            Random ranNumberGenerator = new Random();
            int randomNumber;
            randomNumber = ranNumberGenerator.Next(1, 4);

            if (randomNumber == 1)                                                        
            {
                resultLabel.Text = "It is a tie";
                computerLabel.Text = "Computer Chose Rock";
            }
            else
                if (randomNumber == 2)
            {
                resultLabel.Text = "You lose";
                computerLabel.Text = "Computer Chose Paper";
            }
            else
                    if (randomNumber == 3)
            {
                resultLabel.Text = "You Win";
                computerLabel.Text = "Computer Chose Scissors";
            }


        }

        private void paperButton_Click(object sender, EventArgs e)
        {

            resultLabel.Visible = true;
            computerLabel.Visible = true;

            Random ranNumberGenerator = new Random();
            int randomNumber;
            randomNumber = ranNumberGenerator.Next(1, 4);

            if (randomNumber == 1)
            {
                resultLabel.Text = "You Win";
                computerLabel.Text = "Computer chose Rock";
            }
            else
               if (randomNumber == 2)
            {
                resultLabel.Text = "It's a Draw";
                computerLabel.Text = "Computer chose paper";
            }
            else
                   if (randomNumber == 3)
            {
                resultLabel.Text = "You Lost";
                computerLabel.Text = "coputer Chose Scissors";
            }

        }

        private void scissorButton_Click(object sender, EventArgs e)
        {

            resultLabel.Visible = true;
            computerLabel.Visible = true;

            Random ranNumberGenerator = new Random();
            int randomNumber;
            randomNumber = ranNumberGenerator.Next(1, 4);

            if (randomNumber == 1)
            {
                resultLabel.Text = "You Lose";
                computerLabel.Text = "Computer Chose Rock";
            }
            else
               if (randomNumber == 2)
            {
                resultLabel.Text = "You Win";
                computerLabel.Text = "Computer chose paper";
            }
            else
                   if (randomNumber == 3)
            {
                resultLabel.Text = "Nobody Won";
                computerLabel.Text = "Computer chose scissors";
            }


        }
        
    }
}
