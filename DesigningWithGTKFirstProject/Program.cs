using System;
using Gtk;

namespace DesigningWithGTKFirstProject
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Application.Init();
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Application.Run();
        }
    }
}
