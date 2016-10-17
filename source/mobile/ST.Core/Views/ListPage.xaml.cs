using System;
using System.Diagnostics;
using SpaceLinx.Training.Core.ViewModels;
using SpaceLinx.Training.Core.ViewModels.Controls;
using Xamarin.Forms;

namespace SpaceLinx.Training.Core.Views
{
    public partial class ListPage : ContentPage
    {
        public ListPage()
        {
            Title = "List Demo";

            try
            {
                // ListView.ItemTemplate = new DataTemplate(typeof(ListViewCell));
                //ListView.HasUnevenRows = false;
                // ListView.RowHeight = 210;
                // ListView.SetBinding<ListViewModel>(ListView.ItemsSourceProperty, v => v.Items);

                //if (Device.OS == TargetPlatform.Android || Device.OS == TargetPlatform.iOS)
                //    ListView.ItemSelected += (sender, e) => { ListView.SelectedItem = null; };

                //var button = new Button()
                //{
                //    HorizontalOptions = LayoutOptions.FillAndExpand,
                //    Text = "Duplicate list items",
                //};

                // button.SetBinding<ListViewModel>(Button.CommandProperty, v => v.DuplicateListItemsCommand);

                //Content = new StackLayout()
                //{
                //    HorizontalOptions = LayoutOptions.FillAndExpand,
                //    VerticalOptions = LayoutOptions.FillAndExpand,
                //    Children =
                //    {
                //        ListView,
                //        button,
                //    }
                //};
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            InitializeComponent();
        }
    }
}
