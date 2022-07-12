﻿using BookStore.Models.Viewmodels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Models.Models
{
   public class CetegoryModel
    {
        public CetegoryModel() { }
        public CetegoryModel(Category category)
        {

            Id = category.Id;
            Name = category.Name;
        }
            #nullable enable

        public int? Id { get; set; }

        public String Name { set; get; }
    }
}
