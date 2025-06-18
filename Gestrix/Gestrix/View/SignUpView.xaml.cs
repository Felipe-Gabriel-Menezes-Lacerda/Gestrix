using Gestrix.ViewModel;

namespace Gestrix.View;

public partial class SignUpView : ContentPage
{
	public SignUpView(SignUpViewModel viewModel)
	{
		InitializeComponent();

		BindingContext = viewModel;
	}
}