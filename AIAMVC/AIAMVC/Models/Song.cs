﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AIAMVC.Models
{
    public class Song
    {
       public int Id { get; set; }
       public string Name { get; set; }
       public string Artist { get; set; }
       public string Genre { get; set; }
    }
}