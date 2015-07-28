﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace live.asp.net.ViewModels
{
    public class AdminViewModel
    {
        [Display(Name = "Streaming Embed URL", Description = "URL for embedding the live show")]
        [DataType(DataType.Url)]
        public string LiveShowEmbedUrl { get; set; }

        [Display(Name = "Next Show Date/time", Description = "Exact date and time of the next live show")]
        public DateTime? NextShowDate { get; set; }

        [Display(Name = "Admin Message", Description = "Message to show on home page in case of delay in starting live show, etc.")]
        public string AdminMessage { get; set; }

        public string SuccessMessage { get; set; }

        public bool ShowSucessMessage => !string.IsNullOrEmpty(SuccessMessage);
    }
}