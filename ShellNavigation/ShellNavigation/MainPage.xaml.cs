﻿namespace ShellNavigation;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync($"{nameof(HomePage)}?username={EntUserName.Text}");
    }
}

