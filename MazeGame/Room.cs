using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace MazeGame
{
    public class Room
    {
        private string name;
        public int x { get; }
        public int y { get; }
        private Room? north;
        private Room? east;
        private Room? south;
        private Room? west;
        private List<Item> content = new List<Item>();

        public Room(string name, int x, int y)
        {
            this.name = name;
            this.x = x;
            this.y = y;
        }

        public void setConnectedRooms(Room? north = null, Room? east = null, Room? south = null, Room? west = null)
        {
            this.north = north;
            this.east = east;
            this.south = south;
            this.west = west;
        }

        public string getName() { return name; }

        public Room? getConnectedRoom(char direction)
        {
            switch (direction)
            {
                case 'N':
                    return north;
                case 'E':
                    return east;
                case 'S':
                    return south;
                case 'W':
                    return west;
                default:
                    return null;
            }
        }
        public void printAllConnected()
        {
            Debug.WriteLine($"{getName()}:");
            List<char> directions = new List<char> { 'N', 'E', 'S', 'W' };
            foreach (char direction in directions)
            {
                Room? next = getConnectedRoom(direction);
                Debug.Write($"{direction}: ");
                if (next != null)
                {
                    Debug.WriteLine(next.getName());
                }
                else
                {
                    Debug.WriteLine("null");
                }
            }
        }
        public virtual bool whenEntered()
        {
            return false;
        }
        public List<Item> getContent()
        {
            return content; 
        }

        public void addItem(Item item)
        {
            content.Add(item);
        }
        public void removeItem(Item item)
        {
            content.Remove(item);
        }

        public Door? getDoor(char direction)
        {
            foreach (Item item in content)
            {
                if (item is Door)
                {
                    Door door = (Door)item;
                    Room? nextRoom = getConnectedRoom(direction);
                    if (nextRoom != null)
                    {
                        if (door.isConnected(nextRoom))
                        {
                            return door;
                        }
                    }
                }
            }
            return null;
        }
        public Door? getDoorDumb(char direction)
        {
            foreach (Item item in content)
            {
                if (item is Door)
                {
                    Door door = (Door)item;
                    if (door.getDirection() == direction)
                    {
                        return door;
                    }
                }
            }
            return null;
        }
        public bool isDoorClosed(char direction)
        {
            return getDoor(direction)?.isLocked() == true ? true : false;
        }
    }
}