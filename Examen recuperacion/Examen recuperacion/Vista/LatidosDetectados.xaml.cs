using Examen_recuperacion.ModeloVista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Examen_recuperacion.Vista
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LatidosDetectados : ContentPage
    {
        public LatidosDetectados()
        {
            InitializeComponent();
            BindingContext = new VMcalculadora(Navigation);
        }
    }
}