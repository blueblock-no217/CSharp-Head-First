using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PickACardUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // Runs when the button is pressed
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // created an array of strings using the card picker class member
            string[] pickedCards = CardPicker.PickSomeCards((int)numberOfCards.Value);
            // Ensure the list is empty
            listOfCards.Items.Clear();

            // Add the cards to the list box 
            foreach(string card in pickedCards)
            {
                listOfCards.Items.Add(card);
            }
        }
    }
}