﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace EquationApp
{
    public class NegativeEntry : Entry
    {
        public NegativeEntry()
        {
            this.Keyboard = Keyboard.Numeric;
        }
    }
}
