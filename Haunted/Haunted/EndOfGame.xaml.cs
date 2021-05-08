// <copyright file="EndOfGame.xaml.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Haunted
{
    using System.Windows;

    /// <summary>
    /// Interaction logic for EndOfGame.xaml.
    /// </summary>
    public partial class EndOfGame : Window
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EndOfGame"/> class.
        /// </summary>
        public EndOfGame()
        {
            this.InitializeComponent();
        }

        private void Retry(object sender, RoutedEventArgs e)
        {
            MainWindow m = new MainWindow();
            m.Show();
            Window.GetWindow(this).Close();
        }

        private void ExitToMain(object sender, RoutedEventArgs e)
        {
            System.Environment.Exit(1);
        }
    }
}
