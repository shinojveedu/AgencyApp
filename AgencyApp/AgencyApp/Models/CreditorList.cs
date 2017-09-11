using System;
using System.Collections.Generic;
using System.Text;

namespace AgencyApp.Models
{
    class CreditorList : BaseDataObject
    {
        string creditor_name = string.Empty;
        public string Creditor_Name
        {
            get { return creditor_name; }
            set { SetProperty(ref creditor_name, value); }
        }

        string current_balance = string.Empty;
        public string Current_Balance
        {
            get { return current_balance; }
            set { SetProperty(ref current_balance, value); }
        }

        string dmp_due_dt = string.Empty;
        public string DMP_Due_Dt
        {
            get { return dmp_due_dt; }
            set { SetProperty(ref dmp_due_dt, value); }
        }

        string disb_date = string.Empty;
        public string Disb_Date
        {
            get { return disb_date; }
            set { SetProperty(ref disb_date, value); }
        }

    }
}
