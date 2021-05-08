// <copyright file="GControl.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Haunted.GameControl
{
    using System;
    using System.Diagnostics;
    using System.Windows;
    using System.Windows.Input;
    using System.Windows.Media;
    using System.Windows.Threading;
    using Haunted.GameModel;

    /// <summary>
    /// The class.
    /// </summary>
    public class GControl : FrameworkElement
    {
        private Haunted.GameLogic.GameLogic logic;
        private Haunted.Renderer.Renderer renderer;
        private Haunted.GameModel.HauntedModel model;
        private Stopwatch stw;
        private Haunted.Repository.StorageRepository repo;
        private DispatcherTimer tickTimer;
        private string currentPlayerName;
        private string currentFileName;

        /// <summary>
        /// Initializes a new instance of the <see cref="GControl"/> class.
        /// </summary>
        public GControl()
        {
            this.Loaded += this.Control_Loaded;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GControl"/> class.
        /// </summary>
        /// <param name="playerName">A string.</param>
        public GControl(string playerName)
        {
            this.Loaded += this.Control_Loaded;
            this.currentPlayerName = playerName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GControl"/> class.
        /// </summary>
        /// <param name="playerName">A playername string.</param>
        /// <param name="fileName">A filename string.</param>
        public GControl(string playerName, string fileName)
        {
            this.currentPlayerName = playerName;
            this.currentFileName = fileName;
            this.Loaded += this.Control_LoadFile;
        }

        /// <summary>
        /// Save game method.
        /// </summary>
        /// <param name="gameName">A string.</param>
        public void SaveGame(string gameName)
        {
            this.repo.SaveGame(gameName, this.model);
        }

        /// <summary>
        /// Continue method.
        /// </summary>
        public void Continue()
        {
            this.tickTimer.IsEnabled = true;
        }

        /// <inheritdoc/>
        protected override void OnRender(DrawingContext drawingContext)
        {
            if (this.renderer != null)
            {
                drawingContext.DrawDrawing(this.renderer.BuildDrawing());
            }
        }

        private void Control_Loaded(object sender, RoutedEventArgs e)
        {
            this.stw = new Stopwatch();
            this.model = new GameModel.HauntedModel(this.ActualWidth, this.ActualHeight);
            this.repo = new Repository.StorageRepository();
            this.logic = new GameLogic.GameLogic(this.model, "Haunted.Haunted.map.lab.lvl", this.repo);
            this.renderer = new Renderer.Renderer(this.model);

            Window win = Window.GetWindow(this);
            if (win != null)
            {
                this.tickTimer = new DispatcherTimer();
                this.tickTimer.Interval = TimeSpan.FromMilliseconds(40);
                this.tickTimer.Tick += this.TickTimer_Tick;
                this.tickTimer.Start();
                win.KeyDown += this.Win_KeyDown;
                this.MouseDown += this.Control_MouseDown;
            }

            this.InvalidateVisual();
            this.stw.Start();
        }

        private void Control_LoadFile(object sender, RoutedEventArgs e)
        {
            this.stw = new Stopwatch();
            this.model = this.repo.LoadGame(this.currentFileName);
            this.repo = new Repository.StorageRepository();
            this.logic = new GameLogic.GameLogic(this.model, "Haunted.Haunted.map.L02.lvl", this.repo);
            this.renderer = new Renderer.Renderer(this.model);

            Window win = Window.GetWindow(this);
            if (win != null)
            {
                this.tickTimer = new DispatcherTimer();
                this.tickTimer.Interval = TimeSpan.FromMilliseconds(40);
                this.tickTimer.Tick += this.TickTimer_Tick;
                this.tickTimer.Start();
                win.KeyDown += this.Win_KeyDown;
                this.MouseDown += this.Control_MouseDown;
            }

            this.InvalidateVisual();
            this.stw.Start();
        }

        private void TickTimer_Tick(object sender, EventArgs e)
        {
            foreach (Ghost g in this.model.Ghosts)
            {
                 this.logic.MoveGhost(g);
            }
        }

        private void Control_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Point mousPos = e.GetPosition(this);
            Point tilePos = this.logic.GetTilePos(mousPos);
            MessageBox.Show(mousPos + "\n" + tilePos);
        }

        private void Win_KeyDown(object sender, KeyEventArgs e)
        {
            bool finished = false;
            switch (e.Key)
            {
                case System.Windows.Input.Key.W: finished = this.logic.Move(0, -1); break;
                case System.Windows.Input.Key.S: finished = this.logic.Move(0, 1); break;
                case System.Windows.Input.Key.A: finished = this.logic.Move(-1, 0); break;
                case System.Windows.Input.Key.D: finished = this.logic.Move(1, 0); break;
            }

            this.InvalidateVisual();
            if (finished)
            {
                this.tickTimer.Stop();
                this.stw.Stop();
                MessageBox.Show("YAY!" + this.stw.Elapsed.ToString(@"hh\:mm\:ss\.fff"));
            }
        }
    }
}
