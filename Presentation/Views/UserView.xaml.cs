using System.Windows;
using WPFCleanArchitecture.InterfaceAdapter.ViewModels;
using WPFCleanArchitecture.InterfaceAdapter.Repositories;
using WPFCleanArchitecture.Application.UseCases;
using WPFCleanArchitecture.Infrastructure.ExternalService;
using WPFCleanArchitecture.InterfaceAdapter.Gateways;

namespace WPFCleanArchitecture.Presentation.Views
{
    public partial class UserView : Window
    {
        public UserView()
        {
            InitializeComponent();

            // メモリ内リポジトリを使用
            var userRepository = new InMemoryUserRepository();
            var emailGateway = new EmailGateway();
            var emailService = new EmailService(emailGateway);
            var registerUserUseCase = new RegisterUserUseCase(userRepository, emailService);
            var viewModel = new UserViewModel(registerUserUseCase);

            DataContext = viewModel;
        }
    }

}