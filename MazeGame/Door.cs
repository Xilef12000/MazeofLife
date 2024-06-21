using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace MazeGame
{
    public class Door: Item
    {
        private bool locked = true;
        private char direction;
        private string basename;
        private List<Room> connections = new List<Room>();
        public Door(string name, char direction) : base(name, false)
        {
            this.direction = direction;
            this.basename = name;
            updateName();
        }

        public void toggleLock()
        {
            locked = !locked;
            updateName();
        }

        public void updateName()
        {
            string connectedNames = "";
            foreach (Room room in connections)
            {
                connectedNames += room.getName() + " ";
            }
            base.updateName($"{basename} {connectedNames}{(locked ? "locked" : "open")}");
        }

        public bool isLocked()
        {
            return locked;
        }
        public char getDirection()
        {
            return direction;
        }

        public void addConnection(Room? room)
        {
            if (room != null)
            {
                connections.Add(room);
            }
        }
        public bool isConnected(Room nextRoom)
        {
            foreach (Room room in connections)
            {
                if (room.getName() == nextRoom.getName()) return true;
            }
            return false;
        }

        public void removeDumbDirection()
        {
            direction = '0';
        }
    }
}