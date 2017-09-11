using System;
using System.Collections.Generic;
using System.Text;
using AgencyApp.Helpers;

namespace AgencyApp.Models
{
    public class VideosViewModel
    {
        public ObservableRangeCollection<Item> Items { get; set; }
        public string Title { get; set; }

        public VideosViewModel()
        {
            Items = new ObservableRangeCollection<Item>
            {
                new Item { Id = Guid.NewGuid().ToString(),
                    Text = "Broker Engage",
                    Description ="Insurance",
                    Url = "https://buy.benefitalign.com/images/BE_video.mp4"
                },
                new Item { Id = Guid.NewGuid().ToString(),
                    Text = "Customer Engage",
                    Description ="Insurance",
                    Url= "https://buy.benefitalign.com/images/product_video.mp4"
                }
            };
        }
    }
}
