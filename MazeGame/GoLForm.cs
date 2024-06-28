using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MazeGame
{
    public partial class GoLForm : Form
    {
        public GoLForm(int[,] GoLGoal)
        {
            InitializeComponent();
            int height = GoLGoal.GetLength(0);
            int width = GoLGoal.GetLength(1);

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    CheckBox checkBox = new CheckBox();
                    checkBox.Appearance = Appearance.Button;
                    checkBox.Location = new Point(80 + 56 * j, 80 + 56 * i);
                    checkBox.Name = $"checkBox{i}x{j}";
                    checkBox.Size = new Size(48, 48);
                    checkBox.TabIndex = 0;
                    checkBox.Text = $"{(GoLGoal[i, j] == 1 ? "X" : "  ")}";
                    checkBox.TextAlign = ContentAlignment.MiddleCenter;
                    checkBox.UseVisualStyleBackColor = true;

                    if (i == 0 || i == height - 1 || j == 0 || j == width - 1)
                    {
                        checkBox.Enabled = false;
                    }
                    this.Controls.Add(checkBox);
                }
            }
        }
    }
}
