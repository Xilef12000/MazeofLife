using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeGame
{
    public class winningRoom : Room
    {
        public winningRoom(string name, int x, int y) : base(name, x, y) { }

        public override bool whenEntered()
        {
            MessageBox.Show("You Win!");
            return true;
        }
    }
}
