using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeGame
{
    internal class GolItem:Item
    {
        private Key key;

        public GolItem(string name, Key key) : base(name, true)
        {
            this.key = key;
        }
        public override void use(Player user)
        {
           user.addItem(key);
        }

    }
}
