using Examen_recuperacion.Vista;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Examen_recuperacion
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new LatidosDetectados();
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
