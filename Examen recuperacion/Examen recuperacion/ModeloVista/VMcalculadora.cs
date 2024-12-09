using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Examen_recuperacion.ModeloVista
{
    public class VMcalculadora : BaseViewModel
    {
        #region VARIABLES
        int _Latidos15seg;
        int _FrecuenciaCardiaca;
        string _Categoriadelafrecuencia;

        #endregion
        #region CONSTRUCTOR
        public VMcalculadora(INavigation navigation)
        {
            Navigation = navigation;

        }
        #endregion
        #region OBJETOS
        public int Latidos15seg
        {
            get { return _Latidos15seg; }
            set { SetValue(ref _Latidos15seg, value); }
        }

        public int FrecuenciaCardiaca
        {
            get { return _FrecuenciaCardiaca; }
            set { SetValue(ref _FrecuenciaCardiaca, value); }
        }

        public string CategoriaFrecuenciaCardiaca
        {
            get { return _Categoriadelafrecuencia; }
            set { SetValue(ref _Categoriadelafrecuencia, value); }
        }
        #endregion
        #region PROCESOS

        public void CalcularFrecuencia()
        {
            FrecuenciaCardiaca = Latidos15seg * 4;

            if (FrecuenciaCardiaca < 60)
                CategoriaFrecuenciaCardiaca = "Frecuencia cardíaca baja";
            else if (FrecuenciaCardiaca > 100)
                CategoriaFrecuenciaCardiaca = "Frecuencia cardíaca alta";
            else
                CategoriaFrecuenciaCardiaca = "Frecuencia cardíaca normal";
        }
        #endregion
        #region COMANDOS
        public ICommand CalcularFrecuenciaCommand => new Command(CalcularFrecuencia);
        #endregion
    }
}
