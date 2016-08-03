using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Speed_UWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Instructions : Page
    {
        public Instructions()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Prints the first set of instructions onto the TextBlock called instructionsBlock
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InstructionsButton_Page1(object sender, RoutedEventArgs e)
        {
            instructionsBlock.Text = "You hold five cards in your hand at a time. Once you get rid of a card, a new card will appear from your deck. If the player and computer gets stuck, click on the side deck to \"Flip\" the next card. Clicking it will put new cards on the two discard piles. Remember the name of the game is \"Speed\" so move quickly.";
        }

        /// <summary>
        /// Prints the second set of instructions onto the TextBlock called instructionsBlock
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InstructionsButton_Page2(object sender, RoutedEventArgs e)
        {
            instructionsBlock.Text = "The order of the cards is: \nA - 2 - 3 - 4 - 5 - 6 - 7 - 8 - 9 - 10 - J - Q - K - A";
        }

        /// <summary>
        /// Prints the third set of instructions onto the TextBlock called instructionsBlock
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InstructionsButton_Page3(object sender, RoutedEventArgs e)
        {
            instructionsBlock.Text = "Try to get rid of all of your cards before the computer does.Click one card at a time from your hand at the bottom of the screen to move it to one of the two discard piles in  the middle of the screen if possible.The value of the card you click must be one greater or one less than any card displayed.The card's suits do not matter.";
        }

        /// <summary>
        /// Returns to the MainPage, otherwise known as the main menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InstructionsButton_ReturnHome(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }
    }
}
