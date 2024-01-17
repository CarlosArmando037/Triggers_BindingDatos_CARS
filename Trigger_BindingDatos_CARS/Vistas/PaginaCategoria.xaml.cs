using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trigger_BindingDatos_CARS.Datos;
using Trigger_BindingDatos_CARS.Modelo;
using Trigger_BindingDatos_CARS.VistaModelo;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Trigger_BindingDatos_CARS.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PaginaCategoria : ContentPage
    {
        public PaginaCategoria()
        {
            InitializeComponent();
            BindingContext = new VMcategoria(Navigation);
        }
    }
}