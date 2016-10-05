using System;
using FFImageLoading.Forms;
using MvvmCross.Core.ViewModels;
using Plugin.Connectivity;
using Xamarin.Forms;

namespace SpaceLinx.Training.Core.ViewModels
{
    public class FirstViewModel : BaseViewModel
    {
        public string PageContent => "This is a Native Page, 1 of 3";

        public FirstViewModel()
        {
            MainText = "Hello";
        }

        public MvxCommand MoveToFront
        {
            get
            {
                return new MvxCommand(() => {
                    ChangePresentation(new MvxClosePresentationHint(this));
                });
            }
        }

        public bool IsConnected => CrossConnectivity.Current.IsConnected;

        public string MainText { get; set; }
    }
}
