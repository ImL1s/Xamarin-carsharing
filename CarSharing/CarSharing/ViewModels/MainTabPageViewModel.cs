using CarSharing.Models;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace CarSharing.ViewModels
{
    public class MainTabPageViewModel : BindableBase, INavigationAware
    {
        public MainTabPageViewModel()
        {
            _title = "a";
        }
        private string _title = "a";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        private ObservableCollection<CarInfoModel> _carInfos;
        public ObservableCollection<CarInfoModel> CarInfos
        {
            get
            {
                if(_carInfos == null)
                {
                    _carInfos = new ObservableCollection<CarInfoModel>(GetModel());
                }
                return _carInfos;
            }
            set
            {
                _carInfos = value;
            }
        }

        private IEnumerable<CarInfoModel> GetModel()
        {
            var model = new List<CarInfoModel>();

            for (int i = 0; i < 15; i++)
            {
                model.Add(new CarInfoModel()
                {
                    Brand = "Hello",
                    Model = "world!",
                    ProduceYear = "1991",
                    Type = "BMW",
                    Price = "2000,00"
                });
            }

            model.Add(new CarInfoModel()
            {
                Brand = "Hello",
                Model = "world!"
            });

            model.Add(new CarInfoModel()
            {
                Brand = "Hello",
                Model = "world!"
            });

            model.Add(new CarInfoModel()
            {
                Brand = "Hello",
                Model = "world!"
            });

            return model;
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {
            //throw new NotImplementedException();
        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            if (CarInfos == null)
            {
                initSource();
            }
            else
            {
                CarInfos.Clear();
                foreach (var item in GetModel())
                {
                    CarInfos.Add(item);
                }
            }
        }

        private void initSource()
        {
            CarInfos = new ObservableCollection<CarInfoModel>(GetModel());
        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {
            //throw new NotImplementedException();
        }

    }
}
