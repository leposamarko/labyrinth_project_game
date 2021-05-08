// <copyright file="GameLogic.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Haunted.GameLogic
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Reflection;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows;
    using Haunted.GameModel;
    using Haunted.Repository;

    /// <summary>
    /// Game logic.
    /// </summary>
    public class GameLogic : IGameLogic
    {
        private IGameModel model;
        private StorageRepository repo;

        /// <summary>
        /// Initializes a new instance of the <see cref="GameLogic"/> class.
        /// </summary>
        /// <param name="model">modle.</param>
        /// <param name="fname">fname.</param>
        /// <param name="rep">repository.</param>
        public GameLogic(HauntedModel model, string fname, StorageRepository rep)
        {
            this.model = model;
            this.Initmodel(fname);
            this.repo = rep;
        }

        /// <summary>
        /// RefreshScreen event.
        /// </summary>
        public event EventHandler RefreshScreen;

        /// <summary>
        /// GameOver event.
        /// </summary>
        public event EventHandler GameOver;

        /// <summary>
        /// Pause event.
        /// </summary>
        public event EventHandler Pause;

        /// <summary>
        /// GetTilePos.
        /// </summary>
        /// <param name="mousePos">mousepos.</param>
        /// <returns>point.</returns>
        public Point GetTilePos(Point mousePos)
        {
            return new Point((int)(mousePos.X / this.model.TileSize), (int)(mousePos.Y / this.model.TileSize));
        }

        /// <summary>
        /// initmodel.
        /// </summary>
        /// <param name="fname">file name of map.</param>
        public void Initmodel(string fname)
        {
            Stream stream = Assembly.GetEntryAssembly().GetManifestResourceStream(fname);
            StreamReader sr = new StreamReader(stream);
            string[] lines = sr.ReadToEnd().Replace("\r", string.Empty).Split('\n');

            int width = int.Parse(lines[0]);
            int heigth = int.Parse(lines[1]);
            this.model.Walls = new bool[width, heigth];
            this.model.TileSize = Math.Min(this.model.GameWidth / width, this.model.GameHeight / heigth);
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < heigth; y++)
                {
                    char current = lines[y + 2][x];
                    this.model.Walls[x, y] = current == 'w'; // w like wall
                    if (current == 'S')
                    {
                        this.model.Player = new GirlPlayer(x, y); // s like start
                    }

                    if (current == 'E')
                    {
                        this.model.Exit = new Point(x, y); // e like exit
                    }

                    if (current == 'G')
                    {
                        this.model.Ghosts.Add(new Ghost(x, y)); // g like gost
                    }

                    if (current == 'K')
                    {
                        this.model.Keys.Add(new Key(x, y)); // k like key
                    }
                }
            }
        }

        /// <summary>
        /// move character method.
        /// </summary>
        /// <param name="dx">dx.</param>
        /// <param name="dy">dy.</param>
        /// <returns>is end.</returns>
        public bool Move(int dx, int dy)
        {
            int newx = (int)(this.model.Player.Area.X + dx);
            int newy = (int)(this.model.Player.Area.Y + dy);

            if (newx >= 0 && newy > 0 && newx < this.model.Walls.GetLength(0) && newy < this.model.Walls.GetLength(1) && !this.model.Walls[newx, newy])
            {
                this.model.Player = new GirlPlayer(newx, newy);
                if (this.model.Keys != null)
                {
                    foreach (Key k in this.model.Keys)
                    {
                        if (this.model.Player.Area.IntersectsWith(k.Area))
                        {
                            this.model.Player.NumbKeys++;
                            this.model.Keys.Remove(k);
                            break;
                        }
                    }
                }
            }

            return this.model.Player.Equals(this.model.Exit) && this.model.Player.NumbKeys == 3;
        }

        /// <summary>
        /// ghost move mehod.
        /// </summary>
        /// <param name="g">ghost to move.</param>
        public void MoveGhost(Ghost g)
        {
            if (g.WhichMove.Equals(string.Empty))
            {
                if (this.model.Walls[(int)g.Area.X, (int)g.Area.Y - 1] && this.model.Walls[(int)g.Area.X, (int)g.Area.Y + 1])
                {
                    g.WhichMove = "x";
                    this.MoveXGhost(g);
                }
                else if (this.model.Walls[(int)g.Area.X + 1, (int)g.Area.Y] && this.model.Walls[(int)g.Area.X - 1, (int)g.Area.Y])
                {
                    g.WhichMove = "y";
                    this.MoveYGhost(g);
                }
            }
            else if (g.WhichMove.Equals("x"))
            {
                this.MoveXGhost(g);
            }
            else
            {
                this.MoveYGhost(g);
            }
        }

        /// <summary>
        /// Score listing method.
        /// </summary>
        /// <returns>A list.</returns>
        public List<TimeToXML> ListTime()
        {
            return this.repo.GetTime();
        }

        /// <summary>
        /// New score adding method.
        /// </summary>
        /// <param name="name">Name.</param>
        /// <param name="time">Score.</param>
        public void NewTime(string name, TimeSpan time)
        {
            this.repo.NewTime(name, time);
        }

        private void MoveXGhost(Ghost g)
        {
            if (this.model.Walls[(int)g.Area.X + (int)g.Movex, (int)g.Area.Y] == false)
            {
                g.ChangeX(g.Movex);
                if (g.Area.IntersectsWith(this.model.Player.Area))
                {
                    this.model.Player.Life--;

                    // this.MoveXGhost(g);
                }
            }
            else
            {
                g.Movex = -g.Movex;
                g.ChangeX(g.Movex);
                if (g.Area.IntersectsWith(this.model.Player.Area))
                {
                    this.model.Player.Life--;

                    // this.MoveXGhost(g);
                }
            }
        }

        private void MoveYGhost(Ghost g)
        {
            if (this.model.Walls[(int)g.Area.X, (int)g.Area.Y + (int)g.Movey] == false)
            {
                g.ChangeY(g.Movey);
                if (g.Area.IntersectsWith(this.model.Player.Area))
                {
                    this.model.Player.Life--;
                    this.MoveYGhost(g);
                }
            }
            else
            {
                g.Movey = -g.Movey;
                g.ChangeX(g.Movey);
                if (g.Area.IntersectsWith(this.model.Player.Area))
                {
                    this.model.Player.Life--;
                    this.MoveYGhost(g);
                }
            }
        }
    }
}
