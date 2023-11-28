namespace RecurrenceBug.Demo.Pages;

public partial class UserInfoPage : ContentPage
{
    public UserInfoPage()
    {
        InitializeComponent();
    }
    protected override async void OnAppearing()
    {
        //base.OnAppearing();
        var token = Preferences.Default.Get("token", string.Empty, "login");
        if (string.IsNullOrEmpty(token))
        {
            await Shell.Current.GoToAsync("login");
            return;
        }
    }
    /// <summary>
    /// Reset Token
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private async void Button_Clicked(object sender, EventArgs e)
    {
        Preferences.Default.Clear("login");
        await Shell.Current.GoToAsync("login");
    }
}