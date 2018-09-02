using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomNumberGame
{
    public partial class numberGameForm : Form
    {

        public numberGameForm()
        {
            InitializeComponent();
        }

        // Create variable to store random
        int number;

        // Variables to store user guess and count
        int guess = 0;
        int count = 0;
              
              
        private void numberGameForm_Load(object sender, EventArgs e)
        {

            // Create random object
            Random rand = new Random();

            // Get a random integer and assign it to number
            number = rand.Next(100);

        }

        private void guessButton_Click(object sender, EventArgs e)
        {

            // Count increases with each guess
            count++;

            // Read user input
            guess = int.Parse(guessTextBox.Text);

            // Determine if guess is smaller than random number
            if (guess < number)
            {
                outputListBox.Items.Add("Too low! Try again");
            }

            // Determine if guess is larger than random number
            if (guess > number)
            {
                outputListBox.Items.Add("Too high! Try again");
            }

            // Determine if guess is equal to random number
            if (guess == number)
            {
                // Output to listbox
                outputListBox.Items.Add("Well done! You've guessed correctly!"
                    + " Amount of guesses: " + count + ".");

                // Set a new random number
                Random rand = new Random();
                number = rand.Next(100);

                // Clear count
                count = 0;

                // Alert player that new round has started
                outputListBox.Items.Add("New round! Enter a number between 1 and 100");

                // Clear textbox and set focus
                guessTextBox.Text = "";
                guessTextBox.Focus();

            }

          
        }

        private void newGameButton_Click(object sender, EventArgs e)
        {
            // Clear the item box and text box
            outputListBox.Items.Clear();
            guessTextBox.Text = "";

            // Set focus to text box
            guessTextBox.Focus();

            // Set a new random number
            Random rand = new Random();
            number = rand.Next(100);

            // Clear count
            count = 0;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
