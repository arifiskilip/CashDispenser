﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Log
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string LogType { get; set; }
    }
}
