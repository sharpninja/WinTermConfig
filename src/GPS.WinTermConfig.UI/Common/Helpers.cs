using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace GPS.WinTermConfig.UI.Common
{
    public static class Helpers
    {
        public static string GetFilename()
            => Path.Join(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                @"Packages\Microsoft.WindowsTerminal_8wekyb3d8bbwe\LocalState\profiles.json");

    }
}
