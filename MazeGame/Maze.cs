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
            Room kitchen = new Room("Kitchen", 0, 1);
            Door door0 = new Door("Door", 'E');
            kitchen.addItem(door0);
            roomsList.Add(kitchen);
            Room livingroom = new Room("Living Room", 1, 1);
            //livingroom.addItem(new Item("heavy", false));
            roomsList.Add(livingroom);
            roomsList.Add(new winningRoom("Exit", 4, 1));
            Room specialRoom = new Room("Special Room", 2, 1);
            Door door1 = new Door("GoLDoor", 'E');   
            specialRoom.addItem(door1);
            roomsList.Add(specialRoom);
            Key key1 = new Key("GoLKey", door1);
            int[,] GoLGoal = {
                {0, 0, 0, 0, 0},
                {0, 0, 1, 0, 0},
                {0, 0, 0, 0, 0},
                {0, 0, 0, 1, 0},
                {0, 0, 0, 0, 0}
            };
            GolItem gol = new GolItem("Gol", key1, GoLGoal);
            specialRoom.addItem(gol);
            Room specialRoom2 = new Room("Special Room2", 3, 1);
            Door door2 = new Door("GoLDoor", 'E');
            specialRoom2.addItem(door2);
            roomsList.Add(specialRoom2);
            Key key2 = new Key("GoLKey2", door2);
            int[,] GoLGoal2 = {
                {0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0},
                {0, 1, 1, 1, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 1, 0},
                {0, 0, 0, 0, 0, 1, 1, 0},
                {0, 0, 0, 0, 0, 0, 0, 0}
            };
            GolItem gol2 = new GolItem("Gol2", key2, GoLGoal2);
            specialRoom2.addItem(gol2);
            Room bathroom = new Room("Bathroom", 0, 0);
            bathroom.addItem(new Key("Key", door0));
            bathroom.addItem(new Key("Key2", new Door("Door2", 'E')));
            bathroom.addItem(new WoodenStick("cool wooden stick", true));
            roomsList.Add(bathroom);
            startRoom = bathroom;
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
                //room.printAllConnected();
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
