using System.Collections.ObjectModel;
using ToDoList.Models;
using ToDoList.Pages;

namespace ToDoList
{
    public partial class MainPage : ContentPage
    {
  

        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            loadTasks();
        }

        private async void goToCreateTaskPage_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(CreateTaskPage));
        }

        private async void taskView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            //logic here
            if (taskView.SelectedItem != null) {
                await Shell.Current.GoToAsync($"{nameof(EditTaskPage)}?id={((TaskItem)taskView.SelectedItem).TaskId}");

            } 
        }

        private void taskView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            taskView.SelectedItem = null; // Deselect the item after selection
        }

        private void Delete_Clicked(object sender, EventArgs e)
        {
            var menuItem = sender as MenuItem;
            var taskToDelete = menuItem.CommandParameter as TaskItem;

            TaskRepository.DeleteTask(taskToDelete.TaskId);
            loadTasks();
        }

        private void loadTasks()
        {
            var taskList = new ObservableCollection<TaskItem>(TaskRepository.GetTask());
            taskView.ItemsSource = taskList;
        }
    }
}
