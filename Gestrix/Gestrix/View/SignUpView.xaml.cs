using Gestrix.ViewModel;

namespace Gestrix.View;

public partial class SignUpView : ContentPage
{
	public SignUpView(SignInViewModel viewModel)
	{
		InitializeComponent();

		BindingContext = viewModel;
	}
}