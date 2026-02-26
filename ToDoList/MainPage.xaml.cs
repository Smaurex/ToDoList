using ToDoList.Pages;

namespace ToDoList
{
    public partial class MainPage : ContentPage
    {
  

        public MainPage()
        {
            InitializeComponent();
        }


        private void goToCreateTaskPage_Clicked(object sender, EventArgs e)
        {
           // Navigation.PopModalAsync(new CreateTask());
        }
    }
}
