using System;
using System.Collections.Generic;
using System.Text;

namespace AgencyApp.Models
{
    public class Video : BaseDataObject
    {
        string video_Details_Id = string.Empty;
        public string Video_Details_Id
        {
            get { return video_Details_Id; }
            set { SetProperty(ref video_Details_Id, value); }
        }

        string video_Name = string.Empty;
        public string Video_Name
        {
            get { return video_Name; }
            set { SetProperty(ref video_Name, value); }
        }

        string description = string.Empty;
        public string Description
        {
            get { return description; }
            set { SetProperty(ref description, value); }
        }

        string video_FilePath = string.Empty;
        public string Video_FilePath
        {
            get { return video_FilePath; }
            set { SetProperty(ref video_FilePath, value); }
        }

        string thumbnails = string.Empty;
        public string thumbnail
        {
            get { return thumbnails; }
            set { SetProperty(ref thumbnails, value); }
        }
        
    }
    }
