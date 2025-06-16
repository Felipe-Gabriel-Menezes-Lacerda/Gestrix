using Gestrix.ViewModel;

namespace Gestrix.View;

public partial class AuthPage : ContentPage
{
	public AuthPage(AuthViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}