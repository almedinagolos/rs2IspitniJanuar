//using eProdaja.Mobile.Services;
//using eProdaja.Mobile.ViewModels;
//using eProdaja.Model;
//using eProdaja.Model.Requests;
//using System;
//using System.Collections.Generic;
//using System.Collections.ObjectModel;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Input;
//using Xamarin.Forms;

//namespace eProdaja.Mobile.ViewModels
//{
//    public class PregledKupcaViewModel : BaseViewModel
//    {
//        private readonly APIService _kupacService = new APIService("Kupci");
//        private readonly APIService _pregledNarudzbiService = new APIService("PregledNarudzbi");


//        //public PregledKupcaViewModel()
//        //{
//        //    InitCommand = new Command(async () => await Init());
//        //}

//        public ObservableCollection<Kupci> KupciList { get; set; } = new ObservableCollection<Kupci>();
//        public ObservableCollection<PregledNarudzbi> PregledNarudzbiList { get; set; } = new ObservableCollection<PregledNarudzbi>();
//        Kupci _selectedKupci = null;
//        public async Task Init()
//        {
//            PregledNarudzbiList.Clear();
//                var kupci = await _kupacService.Get<List<Kupci>>();
//            KupciList.Clear();
//            foreach (var item in kupci)
//            {
//                KupciList.Add(item);
//            }

//        }
//        public Kupci SelectedKupci
//        {
//            get { return _selectedKupci; }
//            set
//            {
//                SetProperty(ref _selectedKupci, value);
//                if (value != null)
//                {
//                    UcitajPregled();
//                }
//            }
//        }

//        private async void UcitajPregled()
//        {
//            var request = new Model.Requests.PregledNarudzbiSearchRequest
//            {
//                KupacId = _selectedKupci.KupacId
//            };
//            var list = await _pregledNarudzbiService.Get<List<Model.PregledNarudzbi>>(request);
//            PregledNarudzbiList.Clear();
//            foreach (var item in list)
//            {
//                PregledNarudzbiList.Add(item);
//            }
//        }

//        //public ICommand InitCommand { get; set; }


//    }
//}
using eProdaja.Mobile.Services;
using eProdaja.Mobile.ViewModels;
using eProdaja.Model;
using eProdaja.Model.Requests;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eProdaja.Mobile.ViewModels
{
    public class PregledKupcaViewModel : BaseViewModel
    {
        private readonly APIService _kupciService = new APIService("Kupci");
        private readonly APIService _pregledNarudzbiService = new APIService("PregledNarudzbi");


        //public PregledKupacaViewModel()
        //{
        //    InitCommand = new Command(async () => await Init());
        //}
        public async Task Init()
        {
            PregledNarudzbiList.Clear();
            var kupci = await _kupciService.Get<List<Model.Kupci>>();
            KupciList.Clear();
            foreach (var item in kupci)
            {
                KupciList.Add(item);
            }

        }
        public ObservableCollection<Kupci> KupciList { get; set; } = new ObservableCollection<Kupci>();
        public ObservableCollection<PregledNarudzbi> PregledNarudzbiList { get; set; } = new ObservableCollection<PregledNarudzbi>();
        Kupci _selectedKupci = null;

        public Kupci SelectedKupci
        {
            get { return _selectedKupci; }
            set
            {
                SetProperty(ref _selectedKupci, value);
                if (value != null)
                {
                    UcitajPregledNarudzbi();
                }

            }
        }

        private async void UcitajPregledNarudzbi()
        {
            var request = new Model.Requests.PregledNarudzbiSearchRequest
            {
                KupacId = _selectedKupci.KupacId
            };

            var list = await _pregledNarudzbiService.Get<List<Model.PregledNarudzbi>>(request);

            PregledNarudzbiList.Clear();
            foreach (var item in list)
            {
                PregledNarudzbiList.Add(item);
            }
        }

        //public ICommand InitCommand { get; set; }



    }
}

