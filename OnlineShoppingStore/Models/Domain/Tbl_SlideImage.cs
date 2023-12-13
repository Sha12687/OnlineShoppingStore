﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineShoppingStore.Models.Domain
{
    public  class Tbl_SlideImage
    {
        [Key]
        public int SlideId { get; set; }
        public string SlideTitle { get; set; }
        public string SlideImage { get; set; }
    }
}