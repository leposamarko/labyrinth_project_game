// <copyright file="Pause.xaml.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Haunted
{
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
    using Haunted.GameControl;

    /// <summary>
    /// Interaction logic for Pause.xaml.
    /// </summary>
    public partial class Pause : Window
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Pause"/> class.
        /// </summary>
        public Pause()
        {
            this.InitializeComponent();
        }

        private void SaveGame(object sender, RoutedEventArgs e)
        {
            (this.DataContext as GControl).SaveGame("name"/*valahogy a choose a characterből áthozni*/);
            MessageBox.Show("Game Saved!", "Saved", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void ContinueGame(object sender, RoutedEventArgs e)
        {
            (this.DataContext as GControl).Continue();
            Window.GetWindow(this).Close();
        }
    }
}
