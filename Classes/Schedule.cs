﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinoprokat.Classes
{
    class Schedule
    {
        public int Id { get; set; }
        public int MovieId { get; set; }
        public DateTime Time { get; set; }
        public int Duration { get; set; }
        public string Description { get; set; }
    }
}
