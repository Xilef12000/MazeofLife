using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        public int[,] GoLNext;
        private CheckBox[,] GoLCheckBox;
        private int height;
        private int width;
        private bool signalExit;
        private bool simulationCancellationRequest = false;
        private int simulationDelay = 500;
        private int generationCounter = 0;
        private bool won = false;
        public GoLForm(int[,] GoLGoal)
        {
            InitializeComponent();
            this.FormClosing += GoLForm_FormClosing;
            trackBar1.Value = simulationDelay;
            this.GoLGoal = GoLGoal;
            this.height = this.GoLGoal.GetLength(0);
            this.width = this.GoLGoal.GetLength(1);
            GoLState = new int[this.height, this.width];
            GoLNext = new int[this.height, this.width];
            GoLCheckBox = new CheckBox[this.height, this.width];

            for (int i = 0; i < this.height; i++)
            {
                for (int j = 0; j < this.width; j++)
                {
                    CheckBox checkBox = new CheckBox();
                    checkBox.Appearance = Appearance.Button;
                    checkBox.Location = new Point(80 + 56 * j, 160 + 56 * i);
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
                    GoLCheckBox[i, j] = checkBox;
                }
            }
        }
        private void getCheckboxStates()
        {
            for (int i = 0; i < this.height; i++)
            {
                for (int j = 0; j < this.width; j++)
                {
                    GoLState[i, j] = GoLCheckBox[i, j].Checked ? 1 : 0;
                }
            }
        }
        private bool compareStates()
        {
            // ckecks if all 1 in goal are 1 in state
            for (int i = 0; i < this.height; i++)
            {
                for (int j = 0; j < this.width; j++)
                {
                    if (this.GoLGoal[i, j] == 1)
                    {
                        if (this.GoLState[i, j] == 0)
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }
        private delegate void voidDelegate();
        private void delayExec(int delay, voidDelegate exec)
        {
            Task.Delay(delay).ContinueWith(t =>
            {
                this.Invoke((MethodInvoker)delegate
                {
                    exec();
                });
            });
        }
        private void closeForm()
        {
            if (won == true)
            {
                this.DialogResult = DialogResult.OK;
            }
            this.Close();
        }
        private void nextGeneration()
        {
            if (simulationCancellationRequest)
            {
                simulationCancellationRequest = false;
                return;
            }
            generationCounter++;
            Debug.WriteLine($"Generation{generationCounter}");
            generationLabel.Text = $"Generation: {generationCounter}";
            if (compareStates())
            {
                this.DialogResult = DialogResult.OK;
                won = true;
                MessageBox.Show("You solved the Game of Life");
                this.Close();
            }
            else
            {
                for (int i = 0; i < this.height; i++)
                {
                    for (int j = 0; j < this.width; j++)
                    {
                        if (i == 0 || i == this.height - 1 || j == 0 || j == this.width - 1)
                        {
                            // skip
                        }
                        else
                        {
                            int neighbours = 0;
                            neighbours += GoLState[i - 1, j - 1];
                            neighbours += GoLState[i - 1, j + 0];
                            neighbours += GoLState[i - 1, j + 1];
                            neighbours += GoLState[i + 0, j - 1];
                            neighbours += GoLState[i + 0, j + 1];
                            neighbours += GoLState[i + 1, j - 1];
                            neighbours += GoLState[i + 1, j - 0];
                            neighbours += GoLState[i + 1, j + 1];
                            if (neighbours == 3)
                            {
                                GoLNext[i, j] = 1;
                            }
                            else
                            {
                                GoLNext[i, j] = 0;
                                if (GoLState[i, j] == 1 && neighbours == 2)
                                {
                                    GoLNext[i, j] = 1;
                                }
                            }
                        }
                    }
                }
                for (int i = 0; i < this.height; i++)
                {
                    for (int j = 0; j < this.width; j++)
                    {
                        if (i == 0 || i == this.height - 1 || j == 0 || j == this.width - 1)
                        {
                            // skip
                        }
                        else
                        {
                            GoLState[i, j] = GoLNext[i, j];
                            GoLCheckBox[i, j].Checked = GoLNext[i, j] == 1 ? true : false;
                        }
                    }
                }
                delayExec(simulationDelay, nextGeneration);
            }
        }
        private void startSimulation()
        {
            StartButton.Text = "Stop";
            getCheckboxStates();
            if (compareStates())
            {
                MessageBox.Show("You cant't tick all Goal Boxes");
                StartButton.Text = "Start";
                return;
            }
            generationCounter = 0;
            delayExec(simulationDelay, nextGeneration);
        }
        private void stopSimulation()
        {
            simulationCancellationRequest = true;
            StartButton.Text = "Start";
        }
        private void StartButton_Click(object sender, EventArgs e)
        {
            if (StartButton.Text == "Stop")
            {
                stopSimulation();
            }
            else if (StartButton.Text == "Start")
            {
                startSimulation();
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            simulationDelay = trackBar1.Value;
        }

        private void GoLForm_Load(object sender, EventArgs e)
        {

        }
        private void GoLForm_FormClosing(object sender, CancelEventArgs e)
        {
            if (StartButton.Text == "Stop")
            {
                e.Cancel = true;
                stopSimulation();
                delayExec(simulationDelay*2, closeForm);
            }
            if (won == true)
            {
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
