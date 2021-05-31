﻿using finalYearProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace finalYearProject.ViewModel
{
    public class PUCITShowViewModel
    {
        public IEnumerable<PUCITProducts> productlist { get; set; }
        public IEnumerable<PUCITCafeCategory> Category { get; set; }

        public string title { get; set; }
    }
}
