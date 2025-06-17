using Firebase.Auth;
using Firebase.Auth.Providers;
using Microsoft.Extensions.Logging;
using Gestrix.View;
using Gestrix.ViewModel;

namespace Gestrix
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif
            builder.Services.AddSingleton(new FirebaseAuthClient(new FirebaseAuthConfig()
            {
                ApiKey = "AIzaSyB-BwENhaHgwXcRLC2fj0aBpf0IASIHp28",
                AuthDomain = "gestrix-58333.firebaseapp.com",
                Providers = new FirebaseAuthProvider[]
                {
                    new EmailProvider()
                },
            }));

            builder.Services.AddSingleton<SignInView>();
            builder.Services.AddSingleton<SignInViewModel>();
            builder.Services.AddSingleton<SignUpView>();
            builder.Services.AddSingleton<SignUpViewModel>();

            return builder.Build();
        }
    }
}
