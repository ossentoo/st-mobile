
using DLToolkit.PageFactory;

namespace SpaceLinx.Training.Core.Models
{
    public class ListExampleItem : BaseModel
    {
        string _fileName;
        string _imageUrl;
        public string ImageUrl
        {
            get { return _imageUrl; }
            set { SetField(ref _imageUrl, value); }
        }

        public string FileName
        {
            get { return _fileName; }
            set { SetField(ref _fileName, value); }
        }
    }
}
