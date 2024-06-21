using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeGame
{
    public class loosingRoom : Room
    {
        public loosingRoom(string name, int x, int y) : base(name, x , y) { }

        public override bool whenEntered()
        {
            MessageBox.Show("You Loose!");
            return true;
        }
    }
}
