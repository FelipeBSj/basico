using ParxChaDos.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace ParxChaDos.ViewModels
{
    public class VMinSesion : BaseViewModel
    {
        #region VARIABLES
        string _Texto;
        #endregion
        #region CONSTRUCTOR
        public VMinSesion(INavigation navigation)
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

        public async Task Iniciar()
        {
            await Navigation.PushAsync(new MainPage());
        }
        public async Task Nuevousuario()
        {
            await Navigation.PushAsync(new Regist());
        }
        public void ProcesoSimple()
        {

        }
        #endregion
        #region COMANDOS
        public ICommand ProcesoIniciarS => new Command(async () => await Iniciar());
        public ICommand ProcesoNuevoU => new Command(async () => await Nuevousuario());
        public ICommand PrcesoSimpcommand => new Command(ProcesoSimple);
        #endregion
    }

}
