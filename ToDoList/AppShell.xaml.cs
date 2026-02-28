using ToDoList.Pages;
namespace ToDoList
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(CreateTaskPage), typeof(CreateTaskPage));
            Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));
            Routing.RegisterRoute(nameof(EditTaskPage), typeof(EditTaskPage));
        }
    }
}