using DLToolkit.PageFactory;

namespace SpaceLinx.Training.Core.Models
{
    public class ListHeavyItem : BaseModel
    {
        string _image1Url;
        public string Image1Url
        {
            get { return _image1Url; }
            set { SetField(ref _image1Url, value); }
        }

        string _image2Url;
        public string Image2Url
        {
            get { return _image2Url; }
            set { SetField(ref _image2Url, value); }
        }

        string _image3Url;
        public string Image3Url
        {
            get { return _image3Url; }
            set { SetField(ref _image3Url, value); }
        }

        string _image4Url;
        public string Image4Url
        {
            get { return _image4Url; }
            set { SetField(ref _image4Url, value); }
        }
    }
}
