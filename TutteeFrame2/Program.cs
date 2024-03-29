﻿using System;
using System.Windows.Forms;
using TutteeFrame2.View;
namespace TutteeFrame2
{
    static class Program
    {
        // Support forced run one instance of app only
        //const UInt32 SWP_NOSIZE = 0x0001;
        //const UInt32 SWP_NOMOVE = 0x0002;
        //const UInt32 SWP_SHOWWINDOW = 0x0040;
        //private static bool isNew;
        //[DllImport("user32.dll")]
        //public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);
        //[DllImport("user32.dll")]
        //private static extern bool SetForegroundWindow(IntPtr hWnd);
        //[DllImport("user32.dll")]
        //[return: MarshalAs(UnmanagedType.Bool)]

        //static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
        ///// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            HomeView homeView = new HomeView();
            LoginView loginView = new LoginView(homeView);
            SplashView splashView = new SplashView();
            splashView.ShowDialog();
            loginView.ShowDialog();
            if (loginView.DialogResult == DialogResult.OK)
                Application.Run(homeView);
            else
                Application.Exit();
            return;
            // Forced run one instance of app only
            //using (var m = new Mutex(true, "TutteeFrame", out isNew))
            //{
            //    //If application owns the mutex, continue the execution
            //    if (isNew)
            //    {
            //        Application.EnableVisualStyles();
            //        Application.SetCompatibleTextRenderingDefault(false);
            //        Application.Run(new HomeView());
            //    }
            //    //else show user message that application is running and set focus to that application window
            //    else
            //    {
            //        MessageBox.Show("Phần mềm đã đang chạy.");
            //        Process current = Process.GetCurrentProcess();
            //        foreach (Process process in Process.GetProcessesByName(current.ProcessName))
            //        {
            //            if (process.Id != current.Id)
            //            {
            //                ShowWindow(process.MainWindowHandle, 9);
            //                SetForegroundWindow(process.MainWindowHandle);
            //                break;
            //            }
            //        }
            //    }
            //}
        }
    }
}
