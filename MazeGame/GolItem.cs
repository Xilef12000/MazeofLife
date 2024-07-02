using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            int[,] GoLGoal = {
                {0, 0, 0, 0, 0},
                {0, 0, 1, 0, 0},
                {0, 0, 0, 0, 0},
                {0, 0, 0, 1, 0},
                {0, 0, 0, 0, 0}
            };
            Form GoLForm = new GoLForm(GoLGoal);
            GoLForm.ShowDialog();
            DialogResult result = GoLForm.DialogResult;
            if (result == DialogResult.OK)
            {
                Debug.WriteLine("OK");
                user.addItem(key);
                user.removeItem(this);
            }
            else
            {
                Debug.WriteLine("Not OK");
            }
        }

    }
}
