using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.ApplicationServices;

namespace ERPAssitant.Model
{
    public class MainModel:ObservableObject
    {
        public MainModel()
        {
            frameSource = "View/EncodingPage.xaml"; 
        }
        private string frameSource;

        public string FrameSources
        {
            get { return frameSource; }
            set
            {
                frameSource = value;
                RaisePropertyChanged(nameof(FrameSources));
            }
        }


    }
}
