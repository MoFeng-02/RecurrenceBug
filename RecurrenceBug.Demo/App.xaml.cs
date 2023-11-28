using RecurrenceBug.Demo.Routings;

namespace RecurrenceBug.Demo;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();
        RegisterRouting.Router();
        MainPage = new AppShell();
    }
}
