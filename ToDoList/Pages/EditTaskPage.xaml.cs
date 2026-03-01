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
     public string TaskId 
    {
        set
        {
           task =  TaskRepository.GetTaskById(int.Parse(value));
           if(task != null)
            {
                taskTitleEdit.Text = task.Title;
                taskDetailEdit.Text = task.Detail;
            }
        }
    
    }

    private async void saveBtn_Clicked(object sender, EventArgs e)
    {
        task.Title = taskTitleEdit.Text;
        task.Detail = taskDetailEdit.Text;

        TaskRepository.UpdateTask(task.TaskId, task);

        await Shell.Current.GoToAsync("..");
    }
}