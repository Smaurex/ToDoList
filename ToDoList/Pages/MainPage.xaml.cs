using ToDoList.Models;
using ToDoList.Pages;

namespace ToDoList
{
    public partial class MainPage : ContentPage
    {
  

        public MainPage()
        {
            InitializeComponent();

            var items = new List<TaskItem> {
                new TaskItem { Title = "Buy groceries", Detail = "Milk, Bread, Eggs" },
                new TaskItem { Title = "Call Mom", Detail = "Her birthday is coming up" },
                new TaskItem { Title = "Finish project", Detail = "Due next week" }
            };

            taskView.ItemsSource = items;
        }


        private async void goToCreateTaskPage_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(CreateTask));
        }

        private async void taskView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            //logic here
            if (taskView.SelectedItem != null) {
                await Shell.Current.GoToAsync(nameof(EditTaskPage));

            } 
        }

        private void taskView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            taskView.SelectedItem = null; // Deselect the item after selection
        }
    }
}
