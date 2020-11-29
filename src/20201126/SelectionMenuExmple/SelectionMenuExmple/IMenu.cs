﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionMenuExample
{
    public interface IMenu
    {
        int Count { get; }

        void Add(IMenuItem menuItem);
        void Remove(IMenuItem menuItem);
        void Display(int width);

        IMenuItem SelectItem(string inputPrompt);
    }
}