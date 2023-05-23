using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryInClass.Interfaces;
using FactoryInClass.UIElements;

namespace FactoryInClass.Factorires
{
    public class HTMLFactory : IReturnElementType
    {
        public static ICommonElement GetElement(IReturnElementType.ElementType elementType)
        {
            switch (elementType)
            {
                case IReturnElementType.ElementType.button:
                    return new HTMLImageElement();
                case IReturnElementType.ElementType.textBox:
                    return new HTMLTextElement();
                default:
                    return null;
            }
            return null;
        }
    }
}

