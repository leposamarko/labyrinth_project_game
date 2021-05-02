// <copyright file="MainWindow.xaml.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Haunted
{
    using System.Windows;

    /// <summary>
    /// Interaction logic for MainWindow.xaml.
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MainWindow"/> class.
        /// </summary>
        public MainWindow()
        {
            this.InitializeComponent();
        }

        private void LBoard(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.Content = new LeaderBoard();
        }

        private void NewGame(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.Content = new ChooseCharacter();
        }

        private void LoadGame(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.Content = new LoadGame();
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.Close();
        }
    }
}
