using Prism;
using Prism.Ioc;
using Prism.Unity;
using TodoList.Constants;
using TodoList.Services;
using TodoList.ViewModels;
using TodoList.Views;
using Xamarin.Forms;

namespace TodoList
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null) : base(initializer) { }

        protected override void OnInitialized()
        {
            InitializeComponent();

            NavigationService.NavigateAsync(new System.Uri(NavConstants.TodoView, System.UriKind.Absolute));

        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<TodoPage, TodoPageViewModel>();
            containerRegistry.Register<ITodoDB, TodoDB>();
        }
    }
}
