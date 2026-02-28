namespace ToDoList.Pages;

public partial class CreateTaskPage : ContentPage
{
	public CreateTaskPage()
	{
		InitializeComponent();
	}

    private async void createBtn_Clicked(object sender, EventArgs e)
    {

        await Shell.Current.GoToAsync("..");
    }
}