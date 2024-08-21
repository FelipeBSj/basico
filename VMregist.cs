using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using ParxChaDos.Views;
namespace ParxChaDos.ViewModels
{
    public class VMregist : BaseViewModel
    {
        #region VARIABLES
        string _Texto;
        #endregion
        #region CONSTRUCTOR
        public VMregist(INavigation navigation)
        {
            Navigation = navigation;
        }
        #endregion
        #region OBJETOS
        public string Texto
        {
            get { return _Texto; }
            set { SetValue(ref _Texto, value); }
        }
        #endregion
        #region PROCESOS
        public async Task PGuardar()
        {
            await Navigation.PushAsync(new Verif());
        }
        public async Task PCancelar()
        {
            await Navigation.PopAsync();
        }
        public void ProcesoSimple()
        {

        }
        #endregion
        #region COMANDOS
        public ICommand ProcesoCancelar => new Command(async () => await PCancelar());
        public ICommand ProcesoGuardar => new Command(async () => await PGuardar());
        public ICommand PrcesoSimpcommand => new Command(ProcesoSimple);
        #endregion
    }
}
