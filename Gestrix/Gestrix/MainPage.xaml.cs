using Gestrix.Project.Views;

namespace Gestrix
{
    public partial class MainPage : ContentPage
    {
        public static bool isLogedUser = false;

        public MainPage()
        {
            InitializeComponent();
            
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            SecureStorage.Default.RemoveAll();

            HandleUserOpenApp();

        } 

        public async void HandleUserOpenApp()
        {
            if (isLogedUser)
            {
                return;
            } else
            {
                
            }


        }

    
    }
}
