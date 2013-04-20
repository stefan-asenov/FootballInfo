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

        private static int exitCode = 0;
        public static LoginFormView loginFormView { get; private set; }

        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            loginFormView = new LoginFormView();
            Application.Run(loginFormView);
        }

        public static void ExitApplication(int exitCode) {
            Application.Exit();
        }

    }
}
