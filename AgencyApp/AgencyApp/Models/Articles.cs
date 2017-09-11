using System;
using System.Collections.Generic;
using System.Text;

namespace AgencyApp.Models
{
    class Articles : BaseDataObject
    {
        string article_Id = string.Empty;
        public string Article_Id
        {
            get { return article_Id; }
            set { SetProperty(ref article_Id, value); }
        }

        string article_Header = string.Empty;
        public string Article_Header
        {
            get { return article_Header; }
            set { SetProperty(ref article_Header, value); }
        }

        string body = string.Empty;
        public string Body
        {
            get { return body; }
            set { SetProperty(ref body, value); }
        }

        string isActive = string.Empty;
        public string IsActive
        {
            get { return isActive; }
            set { SetProperty(ref isActive, value); }
        }

        string crt_Dt = string.Empty;
        public string Crt_Dt
        {
            get { return crt_Dt; }
            set { SetProperty(ref crt_Dt, value); }
        }

        string crt_by = string.Empty;
        public string Crt_by
        {
            get { return crt_by; }
            set { SetProperty(ref crt_by, value); }
        }

    }
}
