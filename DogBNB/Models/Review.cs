﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogBNB.Models
{
    public class Review
    {
        public int Id { get; set; }
        public int OwnerID { get; set; }
        public int SitterID { get; set; }
        public int Rating { get; set; }
        public string Text { get; set; }


    }
}
