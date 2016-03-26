﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NergizQuiz.Logic
{
    public class Person
    {
        public Person()
        {
            Name = "";
            Time = 0;
            Age = 18;
            IsMale = true;
        }

        public string Name { get; set; }
        public float Accuracy { get; set; }
        public int Rank { get; set; }
        public int Time { get; set; }
        public int Age { get; set; }
        public bool IsMale { get; set; }
        public string TimeForHumans
        {
            get
            {
                return HelperMethods.GetTimeInHumanLanguage(Time);
            }
        }
    }
}
