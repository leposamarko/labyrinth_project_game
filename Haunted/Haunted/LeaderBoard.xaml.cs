// <copyright file="LeaderBoard.xaml.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Haunted
{
    using System.Windows;
    using System.Windows.Controls;
    using Haunted.Repository;

    /// <summary>
    /// Interaction logic for LeaderBoard.xaml.
    /// </summary>
    public partial class LeaderBoard : Page
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LeaderBoard"/> class.
        /// </summary>
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
