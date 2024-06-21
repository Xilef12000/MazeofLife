using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeGame
{
    public class Item
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
        public virtual void use(Player user)
        {
            MessageBox.Show("This Item cant be used.");
        }
        protected void updateName (string name) { this.name = name; }
    }
}
