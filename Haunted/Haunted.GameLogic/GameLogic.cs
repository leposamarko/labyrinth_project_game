using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Haunted.GameModel;

namespace Haunted.GameLogic
{
    class GameLogic : IGameLogic
    {
        IGameModel model;


        public GameLogic(HauntedModel model, string fname)
        {
            this.model = model;
            initmodel(fname);

        }
        public Point GetTilePos(Point mousePos)
        {
            return new Point((int)(mousePos.X / model.TileSize), (int)(mousePos.Y / model.TileSize));
        }

        public void initmodel(string fname)
        {
            Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(fname);
            StreamReader sr = new StreamReader(stream);
            string[] lines = sr.ReadToEnd().Replace("\r", "").Split('\n');

            int width = int.Parse(lines[0]);
            int heigth = int.Parse(lines[1]);
            model.Walls = new bool[width, heigth];
            model.TileSize = Math.Min(model.GameWidth / width, model.GameHeight / heigth);
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < heigth; y++)
                {
                    char current = lines[y+2][x];
                    model.Walls[x, y] = (current == 'w'); //w like wall
                    if (current == 's') model.Player = new Point(x, y); //s like start 
                    if (current == 'e') model.Exit = new Point(x, y); // e like exit
                }
            }

        }

        public bool move(int dx, int dy)
        {
            throw new NotImplementedException();
        }
    }
}
