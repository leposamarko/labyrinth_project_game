// <copyright file="Renderer.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Haunted.Renderer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows;
    using System.Windows.Media;
    using System.Windows.Media.Imaging;
    using Haunted.GameModel;

    /// <summary>
    /// renderer.
    /// </summary>
    public class Renderer // To display the game
    {
        private HauntedModel model;
        private Drawing oldBackgraund;
        private Drawing oldWalls;
        private Drawing oldExit;
        private Drawing oldPlayer;
        private Drawing oldKey;
        private Drawing oldGhsot;
        private Drawing oldHeart;
        private Ghost oldGhostPos;
        private GirlPlayer oldPlayerPosition;
        private Dictionary<string, Brush> brushes = new Dictionary<string, Brush>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Renderer"/> class.
        /// ctor.
        /// </summary>
        /// <param name="model">model.</param>
        public Renderer(HauntedModel model)
        {
            this.model = model;
        }

        private Brush HeartBrush
        {
            get { return this.GetBrush("Haunted.Images.life_heart.png", false); }
        }

        private Brush KeyBursh
        {
            get { return this.GetBrush("Haunted.Images.gold_key.png", false); }
        }

        private Brush GhostBrush
        {
            get { return this.GetBrush("Haunted.Images.ghost.png", false); }
        }

        /// <summary>
        /// Gets player brush.
        /// </summary>
        private Brush PlayerBrush
        {
            get { return this.GetBrush("Haunted.Haunted.Images.girl_char.png", false); }
        }

        /// <summary>
        /// Gets exitbrush.
        /// </summary>
        private Brush ExitBrush
        {
            get { return this.GetBrush("Haunted.Haunted.Images.exit.png", false); }
        }

        /// <summary>
        /// Gets wall brush.
        /// </summary>
        private Brush WallBrush
        {
            get { return this.GetBrush("Haunted.Haunted.Images.sidewalk_base.png", true); }
        }

        /// <summary>
        /// reset method.
        /// </summary>
        public void Reset()
        {
            this.oldKey = null;
            this.oldBackgraund = null;
            this.oldWalls = null;
            this.oldExit = null;
            this.oldPlayer = null;
            this.brushes.Clear();
        }

        /// <summary>
        /// GetBrush method.
        /// </summary>
        /// <param name="fname">image file name.</param>
        /// <param name="isTiled">filed showing.</param>
        /// <returns>burhes.</returns>
        private Brush GetBrush(string fname, bool isTiled)
        {
            if (!this.brushes.ContainsKey(fname))
            {
                BitmapImage bmp = new BitmapImage();
                bmp.BeginInit();
                bmp.StreamSource = Assembly.GetExecutingAssembly().GetManifestResourceStream(fname);
                bmp.EndInit();
                ImageBrush ib = new ImageBrush(bmp);

                if (isTiled)
                {
                    ib.TileMode = TileMode.Tile;
                    ib.Viewport = new Rect(0, 0, this.model.TileSize, this.model.TileSize);
                    ib.ViewportUnits = BrushMappingMode.Absolute;
                }

                this.brushes.Add(fname, ib);
            }

            return this.brushes[fname];
        }

        /// <summary>
        /// Building Drawing method.
        /// </summary>
        /// <returns>drawing.</returns>
        public Drawing BuildDrawing()
        {
            DrawingGroup dg = new DrawingGroup();
            dg.Children.Add(this.GetBackgroung());
            dg.Children.Add(this.GetWalls());
            dg.Children.Add(this.GetExit());
            dg.Children.Add(this.GetPlayer());
            dg.Children.Add(this.GetKeys());
            dg.Children.Add(this.GetGhosts());
            dg.Children.Add(this.GetHeart());
            return dg;
        }

        private Drawing GetHeart()
        {
            if (this.oldHeart == null)
            {
                Geometry g = new RectangleGeometry(new Rect(0, this.model.GameWidth - 40, this.model.TileSize, this.model.TileSize));
                this.oldHeart = new GeometryDrawing(this.HeartBrush, null, g);
            }

            return this.oldHeart;
        }

        private Drawing GetGhosts()
        {
            if (this.oldGhsot == null)
            {
                GeometryGroup g = new GeometryGroup();
                foreach (Ghost gh in this.model.Ghosts)
                {
                    Geometry k = new RectangleGeometry(new Rect(gh.Area.X * this.model.TileSize, gh.Area.Y * this.model.TileSize, this.model.TileSize, this.model.TileSize));
                    g.Children.Add(k);
                }

                this.oldGhsot = new GeometryDrawing(this.GhostBrush, null, g);
            }

            return this.oldGhsot;
        }

        private Drawing GetKeys()
        {
            if (this.oldKey == null)
            {
                GeometryGroup g = new GeometryGroup();
                foreach (Key item in this.model.Keys)
                {
                    Geometry k = new RectangleGeometry(new Rect(item.Area.X * this.model.TileSize, item.Area.Y * this.model.TileSize, this.model.TileSize, this.model.TileSize));
                    g.Children.Add(k);
                }

                this.oldKey = new GeometryDrawing(this.KeyBursh, null, g);
            }

            return this.oldKey;
        }

        private Drawing GetPlayer()
        {
            if (this.oldPlayer == null || this.oldPlayerPosition.Area != this.model.Player.Area)
            {
                Geometry g = new RectangleGeometry(new Rect(this.model.Player.Area.X * this.model.TileSize, this.model.Player.Area.Y * this.model.TileSize, this.model.TileSize, this.model.TileSize));
                this.oldPlayer = new GeometryDrawing(this.PlayerBrush, null, g);
                this.oldPlayerPosition.ChangeX((int)this.model.Player.Area.X);
                this.oldPlayerPosition.ChangeY((int)this.model.Player.Area.Y);
            }

            return this.oldPlayer;
        }

        private Drawing GetExit()
        {
            if (this.oldExit == null)
            {
                Geometry g = new RectangleGeometry(new Rect(this.model.Exit.X * this.model.TileSize, this.model.Exit.Y * this.model.TileSize, this.model.TileSize, this.model.TileSize));
                this.oldExit = new GeometryDrawing(this.ExitBrush, null, g);
            }

            return this.oldExit;
        }

        private Drawing GetWalls()
        {
            if (this.oldWalls == null)
            {
                GeometryGroup g = new GeometryGroup();
                for (int x = 0; x < this.model.Walls.GetLength(0); x++)
                {
                    for (int y = 0; y < this.model.Walls.GetLength(1); y++)
                    {
                        if (this.model.Walls[x, y])
                        {
                            Geometry box = new RectangleGeometry(new Rect(x * this.model.TileSize, y * this.model.TileSize, this.model.TileSize, this.model.TileSize));
                            g.Children.Add(box);
                        }
                    }
                }

                this.oldWalls = new GeometryDrawing(this.WallBrush, null, g);
            }

            return this.oldWalls;
        }

        private Drawing GetBackgroung()
        {
            if (this.oldBackgraund == null)
            {
                Geometry g = new RectangleGeometry(new Rect(0, 0, this.model.GameWidth, this.model.GameWidth));
                this.oldBackgraund = new GeometryDrawing(Brushes.Black, null, g);
            }

            return this.oldBackgraund;
        }
    }
}
