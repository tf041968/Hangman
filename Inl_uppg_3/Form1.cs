//Johan Persson
//tf041968 - Malmö Högskola
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Inl_uppg_3
{
    public partial class Hangman : Form
    {
        private Hang myHangMan;
        public Hangman()
        {
            InitializeComponent();
            myHangMan = new Hang();
            UpdateGUI();
        }

        private void UpdateGUI()
        {
            lblHiddenWord.Text = myHangMan.Resultat;
            lblGuessedChars.Text = myHangMan.GissadeBokstäver;
            updatePicture();
            CompletedGame();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
			tbGuess.Enabled = true;
            btnGuess.Enabled = true;
			myHangMan.NyttSpel();
			UpdateGUI();
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            string gissning = tbGuess.Text;
            InputUtility m_inputUtility = new InputUtility();
            if (m_inputUtility.kollaInput(gissning)) //Kollar så att gissningen är en bokstav
            {
                if (myHangMan.isCharNotGuessed(gissning))//Kollar om den gissade bokstaven finns i ordet. 
                {
                    UpdateGUI();
                }
                else
                {
                    MessageBox.Show("Du har redan gissat på den bokstaven");
                }
            }

            else
            {
                MessageBox.Show("Man kan bara gissa på bokstäver!");
            }
        }


        /// <summary>
        /// Byter bild beroende på antalet felgissningar. 
        /// </summary>
        public void updatePicture()
        {
            int fel = myHangMan.AntalFel;
            if (fel == 0)
            { pb.Image = Properties.Resources.hangman0; }

            else if (fel == 1)
            { pb.Image = Properties.Resources.hangman1; }

            else if (fel == 2)
            { pb.Image = Properties.Resources.hangman2; }

            else if (fel == 3)
            { pb.Image = Properties.Resources.hangman3; }

            else if (fel == 4)
            { pb.Image = Properties.Resources.hangman4; }

            else if (fel == 5)
            { pb.Image = Properties.Resources.hangman5; }

            else if (fel == 6)
            { pb.Image = Properties.Resources.hangman6; }

            else if (fel == 7)
            { pb.Image = Properties.Resources.hangman7; }
        }

        public void CompletedGame()
        {
            if (myHangMan.AntalFel > 7)
            {
                MessageBox.Show("Tyvärr du hängdes");
            }

            else if (myHangMan.KlaratSpel())
            {
                StängSpel();
                MessageBox.Show("Grattis! Du klarade det på " + myHangMan.AntalGissningar + " gissningar");
            }
        }

        public void StängSpel()
        {
             tbGuess.Enabled = false;
            btnGuess.Enabled = false;
        }

        public void NyttSpel()
        {
            
            lblHiddenWord.Text = myHangMan.Resultat;
            myHangMan.GissadeBokstäver = " ";
			
        }
    }
}
