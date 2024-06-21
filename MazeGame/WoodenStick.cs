using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MazeGame
{
    public class WoodenStick : Item
    {
        public WoodenStick(string name, bool pickable) : base(name, pickable) { }

        public override void use(Player user)
        {
            user.addItem(this);
        }
    }
}