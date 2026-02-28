namespace ToDoList.Pages;

public partial class CreateTaskPage : ContentPage
{
	public CreateTaskPage()
	{
		InitializeComponent();
	}

    private async void CreateBtn_Clicked(object sender, EventArgs e)
    {

        await Shell.Current.GoToAsync(nameof(MainPage));
    }
}