﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoraBagpackIterator.Interface
{
    public interface Iinventoryitoratetor
    {
        bool hasNext();
        void Next();
        Iitem? current();
    }
}
