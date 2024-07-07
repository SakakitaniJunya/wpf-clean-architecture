using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Input;
using WPFCleanArchitecture.Application.UseCases;
using WPFCleanArchitecture.InterfaceAdapter.ViewModels;

namespace WPFCleanArchitecture.InterfaceAdapter.ViewModels
{
    public class UserViewModel : INotifyPropertyChanged
    {
        private readonly RegisterUserUseCase _registerUserUseCase;

        public UserViewModel(RegisterUserUseCase registerUserUseCase)
        {
            _registerUserUseCase = registerUserUseCase;
            GetDataCommand = new RelayCommand(RegisterUser);
            SendMailCommand = new RelayCommand(RegisterUser);
        }

        private string _name;
        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged();
            }
        }

        private string _email;
        public string Email
        {
            get => _email;
            set
            {
                _email = value;
                OnPropertyChanged();
            }
        }

        private string _status;
        public string Status
        {
            get => _status;
            set
            {
                _status = value;
                OnPropertyChanged();
            }
        }

        public ICommand GetDataCommand { get; }
        public ICommand SendMailCommand { get; }

        private void RegisterUser(object parameter)
        {
            try
            {
                var user = _registerUserUseCase.Execute(Name, Email);
                Status = $"User {user.Name} registered successfully";
            }
            catch (Exception ex)
            {
                Status = $"Registration failed: {ex.Message}";
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
