
MyApp/
├── Domain/
│   ├── Entities/
│   │   └── User.cs
│   ├── Interfaces/
│   │   └── IUserRepository.cs
├── Application/
│   ├── Interfaces/
│   │   └── IEmailService.cs
│   ├── UseCases/
│   │   └── RegisterUserUseCase.cs
│   └── ViewModels/
│       └── UserViewModel.cs
├── Infrastructure/
│   ├── Repositories/
│   │   └── UserRepository.cs
│   ├── Services/
│   │   └── EmailService.cs
│   ├── Database/
│   │   └── AppDbContext.cs
│   └── Gateways/
│       └── EmailGateway.cs
└── Presentation/
    └── Views/
        └── UserView.xaml
        └── UserView.xaml.cs