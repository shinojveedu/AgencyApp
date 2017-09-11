using System;
using System.Collections.Generic;
using System.Text;
using AgencyApp.Helpers;
using AgencyApp.Services;

namespace AgencyApp.Models
{
    public class VideosViewModel
    {
        public ObservableRangeCollection<Item> Items { get; set; }
        public string Title { get; set; }

        public VideosViewModel()
        {
            //Items = new ObservableRangeCollection<Item>
            //{
            //    new Item { Id = Guid.NewGuid().ToString(),
            //        Text = "CDC Asset Program",
            //        Description ="There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which don't look even slightly believable. If you are going to use a passage of Lorem Ipsum, you need to be sure there isn't anything embarrassing hidden in the middle of text.",
            //        Url = "https://buy.benefitalign.com/images/BE_video.mp4",
            //        ImageUrl = "http://icons.iconarchive.com/icons/paomedia/small-n-flat/1024/file-video-icon.png"
            //    },
            //    new Item { Id = Guid.NewGuid().ToString(),
            //        Text = "DMP Saving Plan",
            //        Description ="There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which don't look even slightly believable. If you are going to use a passage of Lorem Ipsum, you need to be sure there isn't anything embarrassing hidden in the middle of text.",
            //        Url= "https://buy.benefitalign.com/images/product_video.mp4",
            //        ImageUrl = "http://icons.iconarchive.com/icons/paomedia/small-n-flat/1024/file-video-icon.png"
            //    },
            //    new Item { Id = Guid.NewGuid().ToString(),
            //        Text = "Finance Setup",
            //        Description ="There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which don't look even slightly believable. If you are going to use a passage of Lorem Ipsum, you need to be sure there isn't anything embarrassing hidden in the middle of text.",
            //        Url = "https://buy.benefitalign.com/images/BE_video.mp4",
            //        ImageUrl = "http://icons.iconarchive.com/icons/paomedia/small-n-flat/1024/file-video-icon.png"
            //    },
            //    new Item { Id = Guid.NewGuid().ToString(),
            //        Text = "Complex Calculation",
            //        Description ="There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which don't look even slightly believable. If you are going to use a passage of Lorem Ipsum, you need to be sure there isn't anything embarrassing hidden in the middle of text.",
            //        Url= "https://buy.benefitalign.com/images/product_video.mp4",
            //        ImageUrl = "http://icons.iconarchive.com/icons/paomedia/small-n-flat/1024/file-video-icon.png"
            //    }
            //};
            GetVideo();

            
        }
        private async void GetVideo()
        {
            GeneralService objService = new GeneralService();
            List<Models.Video> actionItems = await objService.GetVideos("Admin");

            foreach(Video v in actionItems)
            {
                try {
                    Item itm = new Item();
                    itm.Text = v.Video_Name;
                    itm.Description = v.Description;
                    itm.Url = v.Video_FilePath;
                    itm.ImageUrl = "http://icons.iconarchive.com/icons/paomedia/small-n-flat/1024/file-video-icon.png";
                    Items.Add(itm);
                }
                catch(Exception ex)
                { }
                
            }
            
        }
    }
}
