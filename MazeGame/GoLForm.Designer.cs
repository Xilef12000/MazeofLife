namespace MazeGame
{
    partial class GoLForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GoLForm));
            StartButton = new Button();
            rulesLabel = new Label();
            trackBar1 = new TrackBar();
            generationLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // StartButton
            // 
            StartButton.Font = new Font("Segoe UI", 18F);
            StartButton.Location = new Point(34, 40);
            StartButton.Margin = new Padding(4, 5, 4, 5);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(214, 77);
            StartButton.TabIndex = 0;
            StartButton.Text = "Start";
            StartButton.UseVisualStyleBackColor = true;
            StartButton.Click += StartButton_Click;
            // 
            // rulesLabel
            // 
            rulesLabel.AutoSize = true;
            rulesLabel.Location = new Point(725, 42);
            rulesLabel.Margin = new Padding(4, 0, 4, 0);
            rulesLabel.Name = "rulesLabel";
            rulesLabel.Size = new Size(542, 200);
            rulesLabel.TabIndex = 1;
            rulesLabel.Text = resources.GetString("rulesLabel.Text");
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(324, 42);
            trackBar1.Margin = new Padding(4, 5, 4, 5);
            trackBar1.Maximum = 1000;
            trackBar1.Minimum = 10;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(149, 69);
            trackBar1.TabIndex = 2;
            trackBar1.Value = 100;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // generationLabel
            // 
            generationLabel.AutoSize = true;
            generationLabel.Location = new Point(561, 40);
            generationLabel.Name = "generationLabel";
            generationLabel.Size = new Size(117, 25);
            generationLabel.TabIndex = 3;
            generationLabel.Text = "Generation: 0";
            // 
            // GoLForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1367, 750);
            Controls.Add(generationLabel);
            Controls.Add(trackBar1);
            Controls.Add(rulesLabel);
            Controls.Add(StartButton);
            Margin = new Padding(4, 5, 4, 5);
            MinimizeBox = false;
            Name = "GoLForm";
            Text = "GoLForm";
            Load += GoLForm_Load;
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button StartButton;
        private Label rulesLabel;
        private TrackBar trackBar1;
        private Label generationLabel;
    }
}