using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MazeGame
{
    public class Key : Item
    {
        private Door door;
        public Key(string name, Door door) : base(name, true)
        {
            this.door = door;
        }

        public override void use(Player user)
        {
            char[] directions = { 'N', 'E', 'S', 'W' };
            foreach (char direction in directions) {
                Door? doorCandidate = user.getCurrentRoom().getDoor(direction);
                if (doorCandidate == door)
                {
                    doorCandidate.toggleLock();
                    return;
                }
            }
            MessageBox.Show($"Can't use {base.ToString()}");
        }
    }
}