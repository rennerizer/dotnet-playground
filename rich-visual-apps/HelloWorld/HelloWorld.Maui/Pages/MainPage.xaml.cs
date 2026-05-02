using HelloWorld.Maui.Models;
using HelloWorld.Maui.PageModels;

namespace HelloWorld.Maui.Pages
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void OnGreetButtonClicked(object sender, EventArgs e)
        {
            GreetingLabel.Text = $"Hello, {NameEntry.Text}!";
        }
    }
}