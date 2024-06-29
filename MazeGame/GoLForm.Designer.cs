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
            StartButton = new Button();
            rules = new Label();
            trackBar1 = new TrackBar();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // StartButton
            // 
            StartButton.Font = new Font("Segoe UI", 18F);
            StartButton.Location = new Point(24, 24);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(150, 46);
            StartButton.TabIndex = 0;
            StartButton.Text = "Start";
            StartButton.UseVisualStyleBackColor = true;
            StartButton.Click += StartButton_Click;
            // 
            // rules
            // 
            rules.AutoSize = true;
            rules.Location = new Point(393, 25);
            rules.Name = "rules";
            rules.Size = new Size(68, 15);
            rules.TabIndex = 1;
            rules.Text = "GoL Rules...";
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(227, 25);
            trackBar1.Maximum = 1000;
            trackBar1.Minimum = 10;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(104, 45);
            trackBar1.TabIndex = 2;
            trackBar1.Value = 100;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // GoLForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(trackBar1);
            Controls.Add(rules);
            Controls.Add(StartButton);
            MinimizeBox = false;
            Name = "GoLForm";
            Text = "GoLForm";
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button StartButton;
        private Label rules;
        private TrackBar trackBar1;
    }
}