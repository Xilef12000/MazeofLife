namespace MazeGame
{
    public partial class MainWindow : Form
    {

        private Maze maze;
        private Player player;
        private void updateRoom()
        {
            this.roomLabel.Text = this.player.getCurrentRoom().getName();
            this.roomContainsList.Items.Clear();
            this.youHaveList.Items.Clear();
            foreach (Item item in player.getCurrentRoom().getContent())
            {
                this.roomContainsList.Items.Add(item);
            }
            foreach (Item item in player.getBag())
            {
                this.youHaveList.Items.Add(item);
            }
        }
        private void movePlayer(char direction)
        {
            if (player.move(direction))
            {
                updateRoom();
                bool exit = this.player.getCurrentRoom().whenEntered();
                if (exit) { Close(); }
            }
            else
            {
                MessageBox.Show("Can't move in this direction.");
            }
            updateRoom();
        }
        public MainWindow()
        {
            InitializeComponent();
            this.maze = new Maze();
            this.player = new Player(maze.getStartRoom());
            updateRoom();
        }

        private void nButton_Click(object sender, EventArgs e)
        {
            movePlayer('N');
        }

        private void sButton_Click(object sender, EventArgs e)
        {
            movePlayer('E');
        }

        private void eButton_Click(object sender, EventArgs e)
        {
            movePlayer('S');
        }

        private void wButton_Click(object sender, EventArgs e)
        {
            movePlayer('W');
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void pickUpButton_Click(object sender, EventArgs e)
        {
            player.pickUp((Item?)this.roomContainsList.SelectedItem);
            updateRoom();
        }

        private void dropButton_Click(object sender, EventArgs e)
        {
            player.drop((Item?)this.youHaveList.SelectedItem);
            updateRoom();
        }

        private void useButton_Click(object sender, EventArgs e)
        {
            player.use((Item?)this.youHaveList.SelectedItem);
            updateRoom();
        }
    }
}
