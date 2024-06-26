﻿using System;
using System.Windows;

namespace GeoOvwSample
{
    /// <summary>
    /// Interaction logic for MyApp.xaml
    /// </summary>

    public partial class MyApp : Application
    {
        public static void Main() { }

        public MyApp()
        {
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);
        }

        void AppStartingUp(object sender, StartupEventArgs e)
        {
            Window myWindow = new Window();
            myWindow.Content = new SampleViewer();
            myWindow.Show();
        }

        private void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs args)
        {
            MessageBox.Show("Unhandled exception: " + args.ExceptionObject.ToString());
        }
    }
}
