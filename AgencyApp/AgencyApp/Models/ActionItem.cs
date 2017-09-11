using System;
using System.Collections.Generic;
using System.Text;

namespace AgencyApp.Models 
{
    class ActionItem : BaseDataObject
    {
        string item = string.Empty;
        public string Item
        {
            get { return item; }
            set { SetProperty(ref item, value); }
        }
    }
}
