﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GitGrub.GetUsGrub.Models
{
    public class BusinessHours
    {
        private string Day { get; set; }

        private int OpenTime { get; set; }

        private int CloseTime { get; set; }

        // Constructor 
        public BusinessHours(string day, int openTime, int closeTime)
        {
            Day = day;
            OpenTime = openTime;
            CloseTime = closeTime;
        }
    }
}