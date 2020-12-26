﻿using LawyerWebSite.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LawyerWebSite.WebUI.Areas.Admin.Models
{
    public class CategoryAllListViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Article> Articles { get; set; }
    }
}