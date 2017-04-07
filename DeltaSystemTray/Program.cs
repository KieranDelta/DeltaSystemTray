using DeltaSystemTray.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeltaSystemTray
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MyCustomApplicationContext());
        }
    }


    public class MyCustomApplicationContext : ApplicationContext
    {
        private NotifyIcon trayIcon;

        public MyCustomApplicationContext()
        {
            // Initialize Tray Icon
            trayIcon = new NotifyIcon()
            {
                Icon = Resources.AppIcon,
                ContextMenu = new ContextMenu(new MenuItem[] {
                new MenuItem("Settings", Settings),
                new MenuItem("Exit", Exit),
            }),
                Visible = true
            };
        }

        void Settings(object sender, EventArgs e)
        {
            // Show tray icon
            trayIcon.Visible = true;

            // Find settings window
            Settings settingsWindow = new Settings();

            // Launch settings window
            settingsWindow.Show();
        }

        void Exit(object sender, EventArgs e)
        {
            // Hide tray icon, otherwise it will remain shown until user mouses over it
            trayIcon.Visible = false;

            //Close app
            Application.Exit();
        }
    }
}