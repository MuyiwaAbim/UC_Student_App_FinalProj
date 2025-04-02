using System;
using Microsoft.Maui;
using Microsoft.Maui.Hosting;

namespace UC_Student_App_FinalProj
{
    internal class Program : MauiApplication
    {
        protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();

        static void Main(string[] args)
        {
            var app = new Program();
            app.Run(args);
        }
    }
}
