﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoApplication.Data
{
    public class BookGallery
    {
        public int ID { get; set; }

        public int BookID { get; set; }

        public string Name { get; set; }

        public string URL { get; set; }

        public Books Book { get; set; }
    }
}
    