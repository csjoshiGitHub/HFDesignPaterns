﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChapterThree
{
    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            description = "House Blend Coffee";
        }

        public override double Cost()
        {
            return .89;
        }
    }
}
