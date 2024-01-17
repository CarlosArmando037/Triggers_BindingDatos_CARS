using MvvmGuia.VistaModelo;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Trigger_BindingDatos_CARS.Datos;
using Trigger_BindingDatos_CARS.Modelo;
using Xamarin.Forms;

namespace Trigger_BindingDatos_CARS.VistaModelo
{
    public class VMcategoria : BaseViewModel
    {

        #region Variables
        string _Texto;
        ObservableCollection<Mcategorias> _listaCategorias;
        #endregion

        #region Constructor
        public VMcategoria(INavigation navigation)
        {
            Navigation = navigation;
            MostrarCategorias();
        }
        #endregion

        #region Objetos
        public ObservableCollection<Mcategorias> ListaCategorias
        {
            get { return _listaCategorias; }
            set { SetProperty(ref _listaCategorias, value);}
        }
        #endregion

        #region Procesos
        public void MostrarCategorias()
        {
            ListaCategorias = new ObservableCollection<Mcategorias>(Datos.Dcategorias.MostrarCategorias());
        }
        #endregion

        #region Comandos
        public ICommand ProcesoSimpcomand => new Command(MostrarCategorias);
        #endregion
    }
}
