﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogBNB_Db.Entities
{
    public class Sitter
    {
        public int SitterId {get;set; }
        public int UserId { get; set; }
        public string Description { get; set; }

    }
}
