namespace ToDoList.Pages;

public partial class EditTaskPage : ContentPage
{
	public EditTaskPage()
	{
		InitializeComponent();
	}

    private async void saveBtn_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(MainPage));
    }
}