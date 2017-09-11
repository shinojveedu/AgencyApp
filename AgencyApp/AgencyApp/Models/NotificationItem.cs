using System;
using System.Collections.Generic;
using System.Text;

namespace AgencyApp.Models
{
    class NotificationItem : BaseDataObject
    {
        string subject = string.Empty;
        public string Subject
        {
            get { return subject; }
            set { SetProperty(ref subject, value); }
        }

        string note = string.Empty;
        public string Note
        {
            get { return note; }
            set { SetProperty(ref note, value); }
        }

        string crt_dt = string.Empty;
        public string Crt_dt
        {
            get { return crt_dt; }
            set { SetProperty(ref crt_dt, value); }
        }
    }
}
