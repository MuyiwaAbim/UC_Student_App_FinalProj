using Microsoft.Maui.Controls;

namespace UC_Student_App_FinalProj;

public partial class ProfilePage : ContentPage
{
    public string UserName { get; set; } = "John Doe";
    public string UserMajor { get; set; } = "Computer Science";

    public ProfilePage()
    {
        InitializeComponent();
        BindingContext = this; 
    }
}
