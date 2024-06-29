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
        private int[,] GoLState;
        public int[,] GoLGoal;
        private CheckBox[,] GoLCheckBox;
        private int height;
        private int width;
        public GoLForm(int[,] GoLGoal)
        {
            this.GoLGoal = GoLGoal;
            InitializeComponent();
            this.height = this.GoLGoal.GetLength(0);
            this.width = this.GoLGoal.GetLength(1);
            GoLState = new int[this.height, this.width];
            GoLCheckBox = new CheckBox[this.height, this.width];

            for (int i = 0; i < this.height; i++)
            {
                for (int j = 0; j < this.width; j++)
                {
                    CheckBox checkBox = new CheckBox();
                    checkBox.Appearance = Appearance.Button;
                    checkBox.Location = new Point(80 + 56 * j, 80 + 56 * i);
                    checkBox.Name = $"checkBox{i}x{j}";
                    checkBox.Size = new Size(48, 48);
                    checkBox.TabIndex = 0;
                    checkBox.Text = $"{(this.GoLGoal[i, j] == 1 ? "X" : "  ")}";
                    checkBox.TextAlign = ContentAlignment.MiddleCenter;
                    checkBox.UseVisualStyleBackColor = true;

                    if (i == 0 || i == this.height - 1 || j == 0 || j == this.width - 1)
                    {
                        checkBox.Enabled = false;
                    }
                    this.Controls.Add(checkBox);
                    GoLCheckBox[i,j] = checkBox;
                }
            }
        }
        private void getCheckboxStates()
        {
            for (int i = 0; i < this.height; i++)
            {
                for (int j = 0; j < this.width; j++)
                {
                    GoLState[i,j] = GoLCheckBox[i,j].Checked ? 1 : 0;
                }
            }
        }
        private bool compareStates(int[,] goal, int[,] state)
        {
            // a and b must be of [height, width]
            // ckecks if all 1 in goal are 1 in state
            for (int i = 0; i < this.height; i++)
            {
                for (int j = 0; j < this.width; j++)
                {
                    if (goal[i,j] == 1)
                    {
                        if (state[i,j] == 0)
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }
        private void startSimulation()
        {
            int test = GoLGoal[0,0];
            getCheckboxStates();
            if (compareStates(GoLGoal, GoLState))
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                this.DialogResult = DialogResult.Cancel;
            }
            this.Close();
        }
        private void Start_Click(object sender, EventArgs e)
        {
            startSimulation();
        }
    }
}
