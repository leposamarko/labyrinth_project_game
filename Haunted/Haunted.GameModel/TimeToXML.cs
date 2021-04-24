using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haunted.GameModel
{
    public class TimeToXML
    {
        public string Name { get; set; }
        public TimeSpan Time { get; set; }
        public TimeToXML(string name, TimeSpan time)
        {
            this.Name = name;
            this.Time = time;
        }
        public override string ToString()
        {
            return $"Player name: {this.Name}\nTime: {this.Time}";
        }
    }
}
