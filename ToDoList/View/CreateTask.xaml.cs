namespace ToDoList.Pages;

public partial class CreateTask : ContentPage
{
	public CreateTask()
	{
		InitializeComponent();
	}

    private void createBtn_Clicked(object sender, EventArgs e)
    {
        Navigation.PushModalAsync(new MainPage());
    }
}