using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class GameOver : UserControl
    {
        public GameOver()
        {
            InitializeComponent();
            int rounds = Form1.patternColourComputer.Count() - 1;
            labelRounds.Text = "You completed " + Convert.ToString(rounds) + " Rounds.";
            
        }

     
        private void buttonAgain_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            GameScreen gs = new GameScreen();
            f.Controls.Add(gs);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
