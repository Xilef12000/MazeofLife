﻿using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeGame
{
    public class Maze
    {
        private Room startRoom;

        // list for room objects
        List<Room> roomsList = new List<Room>();

        public Maze() {

            // create rooms
            roomsList.Add(new Room("Kitchen", 0, 1));
            Door door0 = new Door("Door", 'E');
            roomsList[0].addItem(door0);
            roomsList.Add(new Room("Living Room", 1, 1));
            roomsList[1].addItem(new Item("heavy", false));
            roomsList.Add(new winningRoom("Exit", 3, 1));
            roomsList.Add(new Room("Special Room", 2, 1));
            startRoom = new Room("Bathroom", 0, 0);
            startRoom.addItem(new Key("Key", door0));
            startRoom.addItem(new Key("Key2", new Door("Door2", 'E')));
            startRoom.addItem(new WoodenStick("cool wooden stick", true));
            roomsList.Add(startRoom);
            roomsList.Add(new Room("Bedroom", 1, 0));
            roomsList.Add(new loosingRoom("Torture Chamber", 1, -1));

            // link room object accoarding to room inition
            foreach (Room room in roomsList)
            {
                // find naboring room inition
                Room? north = roomsList.Find(r => (r.x == room.x) && (r.y == room.y + 1));
                Room? east = roomsList.Find(r => (r.x == room.x + 1) && (r.y == room.y));
                Room? south = roomsList.Find(r => (r.x == room.x) && (r.y == room.y - 1));
                Room? west = roomsList.Find(r => (r.x == room.x - 1) && (r.y == room.y));
                // connect room
                room.setConnectedRooms(north, east, south, west);
            }
            // link doors
            foreach (Room room in roomsList)
            {
                char[] directions = { 'N', 'E', 'S', 'W' };
                foreach (char direction in directions)
                {
                    char inverse = inverseDirection(direction);

                    Door? door = room.getDoorDumb(direction);
                    if (door != null)
                    {
                        room.getConnectedRoom(direction)?.addItem(door);
                        door.addConnection(room);
                        door.addConnection(room.getConnectedRoom(direction));
                        door.updateName();
                        door.removeDumbDirection();
                    }
                }
            }
        }

        public Room getStartRoom() { return startRoom; }

        public char inverseDirection(char direction)
        {
            char inverse = '0';
            switch (direction)
            {
                case 'N':
                    inverse = 'S';
                    break;
                case 'E':
                    inverse = 'W';
                    break;
                case 'S':
                    inverse = 'N';
                    break;
                case 'W':
                    inverse = 'E';
                    break;
            }
            return inverse;
        }
    }
}
