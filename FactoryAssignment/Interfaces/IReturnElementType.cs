﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryAssignment.Interfaces
{
    public interface IReturnElementType
    {
        enum ElementType
        {
            button,
            textBox,
            image
        }
    }
}
