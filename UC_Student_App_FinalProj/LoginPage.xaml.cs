using Microsoft.Maui.Controls;

namespace UCStudentApp
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private async void OnLoginClicked(object sender, EventArgs e)
        {
            string username = usernameEntry.Text;
            string password = passwordEntry.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                errorLabel.Text = "Username and password are required.";
                errorLabel.IsVisible = true;
                return;
            }

            if (password.Length < 6 || !password.Any(char.IsDigit) || !password.Any(char.IsUpper))
            {
                errorLabel.Text = "Password must be at least 6 characters long, include a number and an uppercase letter.";
                errorLabel.IsVisible = true;
                return;
            }

            // Simulating login (Replace with actual authentication logic)
            if (username == "test" && password == "Test123")
            {
                await Navigation.PushAsync(new MajorSelectionPage());
            }
            else
            {
                errorLabel.Text = "Invalid username or password.";
                errorLabel.IsVisible = true;
            }
        }
    }
}
