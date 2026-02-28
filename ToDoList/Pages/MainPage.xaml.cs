using ToDoList.Models;
using ToDoList.Pages;

namespace ToDoList
{
    public partial class MainPage : ContentPage
    {
  

        public MainPage()
        {
            InitializeComponent();

            List <TaskItem> task = TaskRepository.GetTask();

            taskView.ItemsSource = task;
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
    }
}
