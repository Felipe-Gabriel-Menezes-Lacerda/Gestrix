using Gestrix.ViewModel;

namespace Gestrix.View;

public partial class SignInView : ContentPage
{
	public SignInView(SignInViewModel viewModel)
	{
		InitializeComponent();

		BindingContext = viewModel;
	}
}