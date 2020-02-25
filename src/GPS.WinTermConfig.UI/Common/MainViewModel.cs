using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;

namespace GPS.WinTermConfig.UI.Common
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private string _filename = Helpers.GetFilename();

        public string Filename
        {
            get => _filename;
            set => Set(ref _filename, value);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void Set<TValue>(ref TValue original, TValue newValue, [CallerMemberName] string property = null)
        {
            if (original.Equals(newValue)) return;

            original = newValue;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }

    }
}
