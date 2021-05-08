using Haunted.GameControl;
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
using System.Windows.Shapes;

namespace Haunted
{
    /// <summary>
    /// Interaction logic for ChooseCharacter.xaml.
    /// </summary>
    public partial class ChooseCharacter : Page
    {
        public ChooseCharacter()
        {
            InitializeComponent();
        }

        private void Back(object sender, RoutedEventArgs e)
        {
            System.Environment.Exit(1);
        }

        private void ToGame(object sender, RoutedEventArgs e)
        {
            if (this.playerName.Text != string.Empty)
            {
                Application.Current.MainWindow.Content = new TheGame();
            }
            else
            {
                MessageBox.Show("Enter Player Name!", "Warning", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }
    }
}
