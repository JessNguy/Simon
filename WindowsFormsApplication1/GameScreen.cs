using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace WindowsFormsApplication1
{
    public partial class GameScreen : UserControl
    {
        Color[] brightColours = new Color[4];
        Color[] darkColours = new Color[4];

        

        bool playerMove = false;

        public GameScreen()
        {
            InitializeComponent();

            Form1.patternColourComputer.Clear();
            //Array

            brightColours[0] = Color.Red;
            brightColours[1] = Color.Lime;
            brightColours[2] = Color.Yellow;
            brightColours[3] = Color.Blue;

        
            darkColours[0] = Color.Maroon;
            darkColours[1] = Color.DarkGreen;
            darkColours[2] = Color.DarkGoldenrod;
            darkColours[3] = Color.MidnightBlue;

        }

        public void computerTurn() // custom method declaration
        {
            labelTurn.Text = "Computer's Turn";

            //generate a number for the pattern
            Random rand = new Random();
            int randNumPattern = rand.Next(0, 4);

            labelNumber.Text += Convert.ToString(randNumPattern);

            //add it to the list
            Form1.patternColourComputer.Add(randNumPattern);

            //read through the list
            for (int x = 0; x < Form1.patternColourComputer.Count; x++)
            {
                switch (Form1.patternColourComputer[x])
                {
                    case 0:
                        buttonRed.BackColor = brightColours[0];
                        buttonRed.Refresh();
                        Thread.Sleep(500);
                        buttonRed.BackColor = darkColours[0];
                        Refresh();

                        break;
                    case 1:
                        buttonGreen.BackColor = brightColours[1];
                        buttonGreen.Refresh();
                        Thread.Sleep(500);
                        buttonGreen.BackColor = darkColours[1];
                        Refresh();

                        break;
                    case 2:
                        buttonYellow.BackColor = brightColours[2];
                        buttonYellow.Refresh();
                        Thread.Sleep(500);
                        buttonYellow.BackColor = darkColours[2];
                        Refresh();

                        break;
                    case 3:
                        buttonBlue.BackColor = brightColours[3];
                        buttonBlue.Refresh();
                        Thread.Sleep(500);
                        buttonBlue.BackColor = darkColours[3];
                        Refresh();

                        break;

                    default:
                        break;
                   
                }

                //clear player's index list of guesses
                Form1.patternGuessUser.Clear();
                playerMove = true;

                labelTurn.Text = "Player's Turn";
            }
        }
        public void playerTurn() // custom method declaration
        {
            if (Form1.patternGuessUser.Count == Form1.patternColourComputer.Count)
            {
                //check to see the button click is correct with the computer pattern
                for (int x = 0; x < Form1.patternGuessUser.Count; x++)
                {
                    //if player guess is the same as computer pattern
                    if (Form1.patternGuessUser[x] == Form1.patternColourComputer[x])
                    {
                        labelMessage.Text = "Correct!";
                        Refresh();
                        Thread.Sleep(500);
                        labelMessage.Text = " ";
                    }
                    else if (Form1.patternGuessUser[x] != Form1.patternColourComputer[x])
                    {
                        labelMessage.Text = "Incorrect";
                        Refresh();
                        Thread.Sleep(500);
                        labelMessage.Text = " ";
                        Thread.Sleep(1500);

                        //change to gameover screen
                        Form f = this.FindForm();
                        f.Controls.Remove(this);

                        GameOver go = new GameOver();
                        f.Controls.Add(go);

                    }

                }

                playerMove = false;
                computerTurn();
            }
        }

      
        private void GameScreen_Load(object sender, EventArgs e)
        {
            Refresh();
            Thread.Sleep(1000);
            computerTurn();
        }

        private void buttonRed_Click(object sender, EventArgs e)
        {
            if (playerMove == true)
            {
                Form1.patternGuessUser.Add(0);

                //change colours
                buttonRed.BackColor = brightColours[0];
                Refresh();
                Thread.Sleep(500);
                buttonRed.BackColor = darkColours[0];
                Refresh();

                playerTurn();
            }

        }

        private void buttonGreen_Click(object sender, EventArgs e)
        {
            if (playerMove == true)
            {
                Form1.patternGuessUser.Add(1);

                //change colours
                buttonGreen.BackColor = brightColours[1];
                Refresh();
                Thread.Sleep(500);
                buttonGreen.BackColor = darkColours[1];
                Refresh();

                playerTurn();
            }
        }

        private void buttonYellow_Click(object sender, EventArgs e)
        {
            if (playerMove == true)
            {
                Form1.patternGuessUser.Add(2);

                //change colours
                buttonYellow.BackColor = brightColours[2];
                Refresh();
                Thread.Sleep(500);
                buttonYellow.BackColor = darkColours[2];
                Refresh();

                playerTurn();
            }
        }

        private void buttonBlue_Click(object sender, EventArgs e)
        {
            if (playerMove == true)
            {
                Form1.patternGuessUser.Add(3);

                //change colours
                buttonBlue.BackColor = brightColours[3];
                Refresh();
                Thread.Sleep(500);
                buttonBlue.BackColor = darkColours[3];
                Refresh();

                playerTurn();
            }
        }
    }
}
