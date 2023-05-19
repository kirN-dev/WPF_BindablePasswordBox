using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WPF_BindablePasswordBox.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private string? _password;

        public string? Password 
        { 
            get => _password; 
            set => SetProperty(value, ref _password);
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        public bool SetProperty<T>(T value, ref T field, [CallerMemberName] string? propertyName = null)
        {
            if (Equals(value, field))
            {
                return false;
            }

            field = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            return true;
        }
    }
}
