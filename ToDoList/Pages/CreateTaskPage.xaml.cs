
using ToDoList.Models;

namespace ToDoList.Pages;

public partial class CreateTaskPage : ContentPage
{
	public CreateTaskPage()
	{
		InitializeComponent();
	}

    private async void CreateBtn_Clicked(object sender, EventArgs e)
    {
        TaskRepository.AddTask(new TaskItem
        {
            TaskId = TaskRepository.NewId(),
            Title = taskTitleEntry.Text,
            Detail = taskDetailEntry.Text
        });

        await Shell.Current.GoToAsync("..");
    }
}