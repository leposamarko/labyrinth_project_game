// <copyright file="ChooseCharacter.xaml.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Haunted
{
    using System.Windows;
    using System.Windows.Controls;

    /// <summary>
    /// Interaction logic for ChooseCharacter.xaml.
    /// </summary>
    public partial class ChooseCharacter : Page
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChooseCharacter"/> class.
        /// </summary>
        public ChooseCharacter()
        {
            this.InitializeComponent();
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
