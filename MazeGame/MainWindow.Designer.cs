namespace MazeGame
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            missionLabel = new Label();
            youAreLabel = new Label();
            roomLabel = new Label();
            navigationLabel = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            nButton = new Button();
            eButton = new Button();
            sButton = new Button();
            wButton = new Button();
            youHaveList = new ListBox();
            roomContainsList = new ListBox();
            youHaveLabel = new Label();
            roomContainsLabel = new Label();
            dropButton = new Button();
            pickUpButton = new Button();
            useButton = new Button();
            saveFileDialog1 = new SaveFileDialog();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // missionLabel
            // 
            missionLabel.AutoSize = true;
            missionLabel.Location = new Point(17, 15);
            missionLabel.Margin = new Padding(4, 0, 4, 0);
            missionLabel.Name = "missionLabel";
            missionLabel.Size = new Size(118, 50);
            missionLabel.TabIndex = 0;
            missionLabel.Text = "Your Mission:\r\ntest this code\r\n";
            // 
            // youAreLabel
            // 
            youAreLabel.AutoSize = true;
            youAreLabel.Location = new Point(17, 222);
            youAreLabel.Margin = new Padding(4, 0, 4, 0);
            youAreLabel.Name = "youAreLabel";
            youAreLabel.Size = new Size(166, 25);
            youAreLabel.TabIndex = 1;
            youAreLabel.Text = "You are currently in:";
            // 
            // roomLabel
            // 
            roomLabel.AutoSize = true;
            roomLabel.Font = new Font("Comic Sans MS", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            roomLabel.ForeColor = SystemColors.MenuHighlight;
            roomLabel.Location = new Point(17, 247);
            roomLabel.Margin = new Padding(4, 0, 4, 0);
            roomLabel.Name = "roomLabel";
            roomLabel.Size = new Size(197, 67);
            roomLabel.TabIndex = 2;
            roomLabel.Text = "Room 0";
            // 
            // navigationLabel
            // 
            navigationLabel.AutoSize = true;
            navigationLabel.Location = new Point(759, 247);
            navigationLabel.Margin = new Padding(4, 0, 4, 0);
            navigationLabel.Name = "navigationLabel";
            navigationLabel.Size = new Size(98, 25);
            navigationLabel.TabIndex = 3;
            navigationLabel.Text = "Navigation";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(nButton, 1, 0);
            tableLayoutPanel1.Controls.Add(eButton, 2, 1);
            tableLayoutPanel1.Controls.Add(sButton, 1, 2);
            tableLayoutPanel1.Controls.Add(wButton, 0, 1);
            tableLayoutPanel1.Location = new Point(759, 277);
            tableLayoutPanel1.Margin = new Padding(4, 5, 4, 5);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(243, 283);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // nButton
            // 
            nButton.Location = new Point(84, 5);
            nButton.Margin = new Padding(4, 5, 4, 5);
            nButton.Name = "nButton";
            nButton.Size = new Size(71, 83);
            nButton.TabIndex = 0;
            nButton.Text = "N";
            nButton.UseVisualStyleBackColor = true;
            nButton.Click += nButton_Click;
            // 
            // eButton
            // 
            eButton.Location = new Point(164, 99);
            eButton.Margin = new Padding(4, 5, 4, 5);
            eButton.Name = "eButton";
            eButton.Size = new Size(74, 83);
            eButton.TabIndex = 1;
            eButton.Text = "E";
            eButton.UseVisualStyleBackColor = true;
            eButton.Click += sButton_Click;
            // 
            // sButton
            // 
            sButton.Location = new Point(84, 193);
            sButton.Margin = new Padding(4, 5, 4, 5);
            sButton.Name = "sButton";
            sButton.Size = new Size(71, 85);
            sButton.TabIndex = 2;
            sButton.Text = "S";
            sButton.UseVisualStyleBackColor = true;
            sButton.Click += eButton_Click;
            // 
            // wButton
            // 
            wButton.Location = new Point(4, 99);
            wButton.Margin = new Padding(4, 5, 4, 5);
            wButton.Name = "wButton";
            wButton.Size = new Size(71, 83);
            wButton.TabIndex = 3;
            wButton.Text = "W";
            wButton.UseVisualStyleBackColor = true;
            wButton.Click += wButton_Click;
            // 
            // youHaveList
            // 
            youHaveList.FormattingEnabled = true;
            youHaveList.ItemHeight = 25;
            youHaveList.Location = new Point(73, 418);
            youHaveList.Margin = new Padding(4, 5, 4, 5);
            youHaveList.Name = "youHaveList";
            youHaveList.Size = new Size(170, 204);
            youHaveList.TabIndex = 5;
            // 
            // roomContainsList
            // 
            roomContainsList.FormattingEnabled = true;
            roomContainsList.ItemHeight = 25;
            roomContainsList.Location = new Point(369, 418);
            roomContainsList.Margin = new Padding(4, 5, 4, 5);
            roomContainsList.Name = "roomContainsList";
            roomContainsList.Size = new Size(380, 204);
            roomContainsList.TabIndex = 6;
            // 
            // youHaveLabel
            // 
            youHaveLabel.AutoSize = true;
            youHaveLabel.Location = new Point(73, 388);
            youHaveLabel.Margin = new Padding(4, 0, 4, 0);
            youHaveLabel.Name = "youHaveLabel";
            youHaveLabel.Size = new Size(87, 25);
            youHaveLabel.TabIndex = 7;
            youHaveLabel.Text = "You have:";
            // 
            // roomContainsLabel
            // 
            roomContainsLabel.AutoSize = true;
            roomContainsLabel.Location = new Point(369, 388);
            roomContainsLabel.Margin = new Padding(4, 0, 4, 0);
            roomContainsLabel.Name = "roomContainsLabel";
            roomContainsLabel.Size = new Size(164, 25);
            roomContainsLabel.TabIndex = 8;
            roomContainsLabel.Text = "The room contains:";
            // 
            // dropButton
            // 
            dropButton.Location = new Point(253, 440);
            dropButton.Margin = new Padding(4, 5, 4, 5);
            dropButton.Name = "dropButton";
            dropButton.Size = new Size(107, 38);
            dropButton.TabIndex = 9;
            dropButton.Text = "Drop >";
            dropButton.UseVisualStyleBackColor = true;
            dropButton.Click += dropButton_Click;
            // 
            // pickUpButton
            // 
            pickUpButton.Location = new Point(253, 488);
            pickUpButton.Margin = new Padding(4, 5, 4, 5);
            pickUpButton.Name = "pickUpButton";
            pickUpButton.Size = new Size(107, 38);
            pickUpButton.TabIndex = 10;
            pickUpButton.Text = "< Pick up";
            pickUpButton.UseVisualStyleBackColor = true;
            pickUpButton.Click += pickUpButton_Click;
            // 
            // useButton
            // 
            useButton.Location = new Point(73, 635);
            useButton.Margin = new Padding(4, 5, 4, 5);
            useButton.Name = "useButton";
            useButton.Size = new Size(107, 38);
            useButton.TabIndex = 11;
            useButton.Text = "Use";
            useButton.UseVisualStyleBackColor = true;
            useButton.Click += useButton_Click;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
            Controls.Add(useButton);
            Controls.Add(pickUpButton);
            Controls.Add(dropButton);
            Controls.Add(roomContainsLabel);
            Controls.Add(youHaveLabel);
            Controls.Add(roomContainsList);
            Controls.Add(youHaveList);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(navigationLabel);
            Controls.Add(roomLabel);
            Controls.Add(youAreLabel);
            Controls.Add(missionLabel);
            Margin = new Padding(4, 5, 4, 5);
            Name = "MainWindow";
            Text = "Maze Game";
            Load += MainWindow_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label missionLabel;
        private Label youAreLabel;
        private Label roomLabel;
        private Label navigationLabel;
        private TableLayoutPanel tableLayoutPanel1;
        private Button nButton;
        private Button eButton;
        private Button sButton;
        private Button wButton;
        private ListBox youHaveList;
        private ListBox roomContainsList;
        private Label youHaveLabel;
        private Label roomContainsLabel;
        private Button dropButton;
        private Button pickUpButton;
        private Button useButton;
        private SaveFileDialog saveFileDialog1;
    }
}
