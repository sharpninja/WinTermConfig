using WebWindows.Blazor;
using System;

namespace GPS.WinTermConfig.UI
{
    public class Program
    {
        private static void Main(string[] args)
        {
            ComponentsDesktop.Run<Startup>(
                "Windows Terminal Settings Manager",
                "wwwroot/index.html");
        }
    }
}
