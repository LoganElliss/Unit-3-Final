//Logan Ellis
//April 16th
//Unit 3 problem Building a hangman game 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Unit_3_Final
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool gameStarted = false;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnCheck_Click(object sender, RoutedEventArgs e)
        {
            BtnCheck.Content = "Guess a Letter";
            int lineToRead = 1;//replace with a random number
            int counter = 0;
            if (gameStarted)
            { //coding the guessing to make the program calculate the lenth for the word and make it check through those numbers
                String hw = Output.Length;
                    string  LetterImput = "";
                {
                    if (LetterImput = hw) 
                    hw(0);
                       Output = "_";
                    hw(1);
                    Output = "_ _";
                    hw(2);
                    Output = "_ _ _";
                    hw(3);
                    Output = "_ _ _ _";
                }
                //checks each letter for the guessed one and outputs ether the letter in its place or it outputs _*number of letters 
                string output = _ _ _ _;

                  
                //guess letter
            }
            else
            {
                gameStarted = true;

                //set up game
                if ((bool)Easy.IsChecked)
                {
                    int LineToRead = 1,2,3,4; // set to read a specific set of lines for its catagory ex easy button gets 1-4
                    System.IO.StreamReader reader =
                        new System.IO.StreamReader("Words.txt");
                    try
                    {
                        string output = "";
                        while (!reader.EndOfStream)
                        {
                            if (counter == lineToRead)
                            {
                                output += reader.ReadLine() + Environment.NewLine;
                            }
                            else
                            {
                                reader.ReadLine();
                            }

                            counter++;
                        }
                        output = output.Trim();
                        Output.Content = output;
                    }
                    catch (Exception ex) { }
                }

            }
        }
    }
}
