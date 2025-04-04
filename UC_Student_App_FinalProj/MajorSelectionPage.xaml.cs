using Microsoft.Maui.Controls;
using UC_Student_App_FinalProj;

namespace UC_Student_App_FinalProj
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
