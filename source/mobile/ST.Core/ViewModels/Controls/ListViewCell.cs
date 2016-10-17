using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FFImageLoading.Forms;
using SpaceLinx.Training.Core.Models;
using Xamarin.Forms;

namespace SpaceLinx.Training.Core.ViewModels.Controls
{
    public class ListViewCell : ViewCell
    {
        public ListViewCell()
        {
            var image = new CachedImage()
            {
                WidthRequest = 200,
                HeightRequest = 200,
                DownsampleHeight = 200,
                DownsampleUseDipUnits = true,
                TransparencyEnabled = false,
                Aspect = Aspect.AspectFill,
                CacheDuration = TimeSpan.FromDays(30),
                RetryCount = 3,
                RetryDelay = 500,
                LoadingPlaceholder = "loading.png",
            };
            image.SetBinding<ListExampleItem>(CachedImage.SourceProperty, v => v.ImageUrl);

            var fileName = new Label()
            {
                LineBreakMode = LineBreakMode.CharacterWrap,
                VerticalTextAlignment = TextAlignment.Center,
                HorizontalTextAlignment = TextAlignment.Center,
            };
            fileName.SetBinding<ListExampleItem>(Label.TextProperty, v => v.FileName);

            var root = new AbsoluteLayout()
            {
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.FillAndExpand,
                Padding = 5,
            };

            root.Children.Add(image, new Rectangle(0f, 0f, 200f, 200f));
            root.Children.Add(fileName, new Rectangle(200f, 0f, 150f, 200f));

            View = root;
        }
    }
}
