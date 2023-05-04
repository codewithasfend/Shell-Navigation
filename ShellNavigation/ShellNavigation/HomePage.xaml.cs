namespace ShellNavigation;

[QueryProperty(nameof(User_Name), "username")]
public partial class HomePage : ContentPage
{
    public HomePage()
    {
        InitializeComponent();
    }
    private string user_name;

    public string User_Name
    {
        get { return user_name; }
        set
        {
            user_name = value;
            LblUserName.Text = user_name;
        }
    }


}