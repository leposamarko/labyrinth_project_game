using Haunted.Repository;
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
    /// Interaction logic for LoadGame.xaml.
    /// </summary>
    public partial class LoadGame : Page
    {
        public LoadGame()
        {
            this.InitializeComponent();
            var repo = new StorageRepository();
            this.games.ItemsSource = repo.GetFiles();
        }

        private void Back(object sender, RoutedEventArgs e)
        {
            MainWindow m = new MainWindow();
            m.Show();
            Window.GetWindow(this).Close();
        }

        private void Load(object sender, RoutedEventArgs e)
        {
            if (this.games.SelectedItem != null)
            {
                if (this.playerName.Text != string.Empty)
                {
                    Application.Current.MainWindow.Content = new Control();
                }
                else
                {
                    MessageBox.Show("Enter Player Name!", "Warning", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Select a game to load!", "Warning", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }
    }
}
