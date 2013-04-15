using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using FootballInfoSystem.View;

namespace FootballInfoSystem {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        static int exitCode = 0;

        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
	        Application.Run(new HomeView());
        }

        public static void ExitApplication(int exitCode) {
            Program.exitCode = exitCode;
            Application.Exit();
        }
    }
}
