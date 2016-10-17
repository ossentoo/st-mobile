using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using DLToolkit.PageFactory;

namespace SpaceLinx.Training.Core.Models
{
    public class MenuItem : BaseModel
    {
        string _section;
        string _detail;
        string _title;
        ICommand _command;
        object _commandParameter;


        public string Section
        {
            get { return _section; }
            set { SetField(ref _section, value); }
        }

        public string Title
        {
            get { return _title; }
            set { SetField(ref _title, value); }
        }

        public string Detail
        {
            get { return _detail; }
            set { SetField(ref _detail, value); }
        }

        public ICommand Command
        {
            get { return _command; }
            set { SetField(ref _command, value); }
        }

        public object CommandParameter
        {
            get { return _commandParameter; }
            set { SetField(ref _commandParameter, value); }
        }
    }
}
