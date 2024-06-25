using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeGame
{
    abstract public class Item
    {
        private string name;
        private bool pickable;
        public Item(string name, bool pickable)
        {
            this.name = name;
            this.pickable = pickable;
        }
        public bool isPickable() { return pickable; }
        public override string ToString() { return this.name; }
        abstract public void use(Player user);
        protected void updateName (string name) { this.name = name; }
    }
}
