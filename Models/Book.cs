﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCRUDEntityFramework.Models
{
    public class Book
    {
    
        public int BookId { get; set; }

        public string Title { get; set; }
    

        public string Author { get; set; }
    }
}
