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

        List<int> patternColourComputer = new List<int>();
        List<int> patternGuessUser = new List<int>();

        bool playerMove = false;

        public GameScreen()
        {
            InitializeComponent();

            patternColourComputer.Clear();
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
            //generate a number for the pattern
            Random rand = new Random();
            int randNumPattern = rand.Next(0, 4);

            labelTurn.Text = Convert.ToString(randNumPattern);
            //add it to the list
            patternColourComputer.Add(randNumPattern);

            //read through the list
            {
                //checking what the number in the computer list is
            for (int x = 0; x < patternColourComputer.Count; x++)
                if (patternColourComputer[x] == 0)
                {
                    //light up red

                    buttonRed.BackColor = brightColours[0];
                    Refresh();
                    Thread.Sleep(500);
                    buttonRed.BackColor = darkColours[0];
                    Refresh();
                   
                }
                else if (patternColourComputer[x] == 1)
                {
                    //light up green

                    buttonGreen.BackColor = brightColours[1];
                    Refresh();
                    Thread.Sleep(500);
                        buttonGreen.BackColor = darkColours[1];
                    Refresh();

                }
                else if (patternColourComputer[x] == 2)
                {
                    //light up yellow

                    buttonYellow.BackColor = brightColours[2];
                    Refresh();
                    Thread.Sleep(500);
                    buttonYellow.BackColor = darkColours[2];
                    Refresh();

                }
                else if (patternColourComputer[x] == 3)
                {
                    //light up blue

                    buttonBlue.BackColor = brightColours[3];
                    Refresh();
                    Thread.Sleep(500);
                    buttonBlue.BackColor = darkColours[3];
                    Refresh();

                }
                
            }
        }
        public void playerTurn() // custom method declaration
        {
            //clear player's index list of guesses
            patternGuessUser.Clear();

            //check to see the button click is correct with the computer pattern
            for (int x = 0; x < patternGuessUser.Count; x++)
            {
                //if player guess is the same as computer pattern
                if(patternGuessUser[x] == patternColourComputer[x])
                {
                    
                }
                else if (patternGuessUser[x] != patternColourComputer[x])
                {

                }
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
            patternGuessUser.Add(0);

        }

        private void buttonGreen_Click(object sender, EventArgs e)
        {
            patternGuessUser.Add(1);
        }

        private void buttonYellow_Click(object sender, EventArgs e)
        {
            patternGuessUser.Add(2);
        }

        private void buttonBlue_Click(object sender, EventArgs e)
        {
            patternGuessUser.Add(3);
        }
    }
}
