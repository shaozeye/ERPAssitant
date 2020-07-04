using ERPAssitant.Model;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;

namespace ERPAssitant.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        public RelayCommand ChangePageCommand { get; set; }
        public MainModel mainModel { get; set; }
        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {
            ////if (IsInDesignMode)
            ////{
            ////    // Code runs in Blend --> create design time data.
            ////}
            ////else
            ////{
            ////    // Code runs "for real"
            ////}
            ChangePageCommand = new RelayCommand(ChangePage);
            mainModel = new MainModel() ;
        }
        private string frameSources;

        public string FrameSources
        {
            get { return frameSources; }
            set
            {
                frameSources = value;
                RaisePropertyChanged(nameof(FrameSources));
            }
        }

        private void ChangePage()
        {
           
        }

      

    }
}