using MauiDemoDataBinding.Pages;

namespace MauiDemoDataBinding
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new NotifyBinding());
        }
    }
}