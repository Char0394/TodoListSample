using Prism;
using Prism.Ioc;
using Prism.Unity;

namespace TodoList
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null) : base(initializer) { }

        protected override void OnInitialized()
        {
            InitializeComponent();

           // NavigationService.NavigateAsync(new System.Uri("", System.UriKind.Absolute));

        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }
    }
}
