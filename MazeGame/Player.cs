using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace MazeGame
{
    public class Player
    {
        private Room currentRoom;
        private List<Item> bag = new List<Item>();

        public Player(Room currentRoom)
        {
            this.currentRoom = currentRoom;
        }
        public Room getCurrentRoom() { return currentRoom; }
        public bool move(char direction)
        {
            if (currentRoom.isDoorClosed(direction))
            {
                return false;
            }
            Room? next = getCurrentRoom().getConnectedRoom(direction);
            if (next != null)
            {
                currentRoom = next;
                return true;
            }
            return false;
        }
        public List<Item> getBag()
        {
            return bag;
        }

        public void pickUp(Item? item)
        {
            if (item == null)
            {
                MessageBox.Show("No item selected!");
                return;
            }
            if ( item.isPickable() == false)
            {
                MessageBox.Show($"{item.ToString()} is to heavy to be picked up!");
                return;
            }
            addItem(item);
            getCurrentRoom().removeItem(item);
        }
        public void drop(Item? item)
        {
            if (item == null)
            {
                MessageBox.Show("No item selected!");
                return;
            }
            removeItem(item);
            getCurrentRoom().addItem(item);
        }
        public void use(Item? item)
        {
            if (item == null)
            {
                MessageBox.Show("No item selected!");
                return;
            }
            item.use(this);
        }
        public void addItem(Item item)
        {
            bag.Add(item);
        }
        public void removeItem(Item item)
        {
            bag.Remove(item);
        }
    }
}
