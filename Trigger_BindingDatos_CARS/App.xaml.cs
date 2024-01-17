using System;
using Trigger_BindingDatos_CARS.Vistas;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Trigger_BindingDatos_CARS
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Categoria();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
