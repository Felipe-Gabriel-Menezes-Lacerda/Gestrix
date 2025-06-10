using Gestrix.Project.Views;

namespace Gestrix
{
    public partial class MainPage : ContentPage
    {
        public bool isLogedUser = false;

        public MainPage()
        {
            InitializeComponent();
            
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            SecureStorage.Default.RemoveAll();

        } 

        public async void HandleUserOpenApp()
        {
            if (isLogedUser)
            {
                return;
            } else
            {
                await Navigation.PushAsync(new SignInScreen());
            }


        }

    
    }
}
