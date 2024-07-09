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
        private int[,] GoLGoal;

        public GolItem(string name, Key key, int[,] GoLGoal) : base(name, true)
        {
            this.key = key;
            this.GoLGoal = GoLGoal;
        }
        public override void use(Player user)
        {
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
