using RecurrenceBug.Demo.Pages;
using RecurrenceBug.Demo.Views;

namespace RecurrenceBug.Demo.Routings;
/// <summary>
/// Register Route
/// </summary>
public class RegisterRouting
{
    public static void Router()
    {
        Routing.RegisterRoute("home", typeof(HomePage));
        Routing.RegisterRoute("user-info", typeof(UserInfoPage));
        Routing.RegisterRoute("settings", typeof(SettingsPage));
        Routing.RegisterRoute("login", typeof(LoginView));
    }
}
