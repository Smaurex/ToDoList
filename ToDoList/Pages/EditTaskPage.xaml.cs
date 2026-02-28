using ToDoList.Models;

namespace ToDoList.Pages;

[QueryProperty(nameof(TaskId),"id")]
public partial class EditTaskPage : ContentPage
{
    private TaskItem task;
	public EditTaskPage()
	{
		InitializeComponent();
	}

    private async void saveBtn_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(MainPage));
    }

    public string TaskId 
    {
        set
        {
           task =  TaskRepository.GetTaskById(int.Parse(value));
           taskTitleEdit.Text = task.Title;
           taskDetailEdit.Text = task.Detail;
        }
    
    }
}