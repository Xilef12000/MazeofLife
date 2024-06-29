using System.Diagnostics;

namespace MazeGame
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //Application.Run(new MainWindow());
            int[,] GoLGoal = {
                {0, 0, 0, 0, 0},
                {0, 1, 1, 1, 0},
                {0, 0, 0, 0, 0},
                {0, 0, 0, 1, 0},
                {0, 0, 0, 0, 0}
            };
            Form GoLForm = new GoLForm(GoLGoal);
            Application.Run(GoLForm);
            DialogResult result = GoLForm.DialogResult;
            if (result == DialogResult.OK)
            {
                Debug.WriteLine("OK");
            }
            else
            {
                Debug.WriteLine("Not OK");
            }
        }
    }
}