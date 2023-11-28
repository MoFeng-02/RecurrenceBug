namespace RecurrenceBug.Demo.Views;

public partial class LoginView : ContentPage
{
    public LoginView()
    {
        InitializeComponent();
    }
    /// <summary>
    /// Login clicked event.
    /// <para>
    /// Used to simulate my recurring bug
    /// </para>
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private async void Button_Clicked(object sender, EventArgs e)
    {
        Preferences.Default.Set("token", "1", "login");
        await Shell.Current.GoToAsync("..");
    }
}