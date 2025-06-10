using Gestrix;
namespace Gestrix.Project.Views;

public partial class SignInScreen : ContentPage
{
	public SignInScreen()
	{
		InitializeComponent();
	}

	private async void TryLoginButton_Clicked(object sender, EventArgs events)
	{
		bool isUserEmailValid = false;
		bool isUserPasswordValid = false;

		CleanErrorMessages();
		isUserEmailValid = ValidateUserEmail();
		isUserPasswordValid = ValidateUserPassword();

		if(isUserEmailValid && isUserPasswordValid)
		{
			MainPage.isLogedUser = true;
			await Navigation.PushAsync(new MainPage());
			
		}

		CleanLoginFormEntries();
		

		
	}

	
	private bool ValidateUserEmail()
	{
		string userEmail = "";
		bool isUserEmailValid = false;

		userEmail = UserSignInEmail_Entry.Text;

		if(!userEmail.Contains("@") || !userEmail.Contains("."))
		{
			ValidateEmailEntry_Label.Text = "Insira um e-mail válido";
			return isUserEmailValid;
		} else
		{
			isUserEmailValid = true;
		}

        return isUserEmailValid;

    }

	private bool ValidateUserPassword()
	{
		bool isUserPasswordValid = false;
		string userPassword = "";

		userPassword = UserSignInPassword_Entry.Text;

		if(userPassword.Length < 6)
		{
			ValidatePasswordEntry_Label.Text = "A senha deve conter pelo menos 6 caracteres";
            return isUserPasswordValid;
        }
		if(userPassword == userPassword.ToLower())
		{
			ValidatePasswordEntry_Label.Text = "A senha deve conter pelo menos um caractere maiúsculo";
            return isUserPasswordValid;
        }

			isUserPasswordValid = true;
		


			return isUserPasswordValid;
	}

	private void CleanErrorMessages()
	{
		ValidateEmailEntry_Label.Text = "";
        ValidatePasswordEntry_Label.Text = "";

    }

	private void CleanLoginFormEntries()
	{
		UserSignInPassword_Entry.Text = "";
		UserSignInEmail_Entry.Text = "";

    }

}