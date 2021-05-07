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
    /// Interaction logic for LeaderBoard.xaml.
    /// </summary>
    public partial class LeaderBoard : Page
    {
        public LeaderBoard()
        {
            this.InitializeComponent();
            var repo = new StorageRepository();
            this.scores.ItemsSource = repo.GetTime();
        }

        private void Back(object sender, RoutedEventArgs e)
        {
            MainWindow m = new MainWindow();
            m.Show();
            Window.GetWindow(this).Close();
        }
    }
}
