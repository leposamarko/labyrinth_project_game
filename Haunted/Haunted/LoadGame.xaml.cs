// <copyright file="LoadGame.xaml.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Haunted
{
    using System.Windows;
    using System.Windows.Controls;
    using Haunted.Repository;

    /// <summary>
    /// Interaction logic for LoadGame.xaml.
    /// </summary>
    public partial class LoadGame : Page
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LoadGame"/> class.
        /// </summary>
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
