using eProdaja.Mobile.ViewModels;
using eProdaja.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eProdaja.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PregledKupcaPage : ContentPage
    {
        PregledKupcaViewModel model = null;
        public PregledKupcaPage()
        {
            InitializeComponent();
            BindingContext = model = new PregledKupcaViewModel();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }

       
    }
}