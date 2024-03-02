﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Domain.Entities.Models
{
    public class Book
    {
        public int ID { get; set; }
        public string BookName { get; set; }
        public string AuthorName { get; set; }
        public string Category { get; set; }
        public string BookShelfSector { get; set; }
        public int PublishedYear { get; set; }
    }
}
