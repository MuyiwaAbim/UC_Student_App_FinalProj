using Microsoft.Maui.Controls;

namespace UCStudentApp
{
    public partial class MajorSelectionPage : ContentPage
    {
        public MajorSelectionPage()
        {
            InitializeComponent();
        }

        private async void OnContinueClicked(object sender, EventArgs e)
        {
            if (majorPicker.SelectedItem != null)
            {
                await Navigation.PushAsync(new PostsPage());
            }
        }
    }
}
