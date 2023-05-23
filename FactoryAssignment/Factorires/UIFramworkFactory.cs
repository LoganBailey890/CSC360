using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using FactoryAssignment.Interfaces;
using FactoryAssignment.UIElements;



namespace FactoryAssignment.Factorires
{
    public class UIFramworkFactory : IReturnElementType
    {

        public static ICommonElement GetElemntType(IReturnElementType.ElementType elementType)
        {
            switch (elementType)
            {
                case IReturnElementType.ElementType.button:
                    return new TextElement();
                case IReturnElementType.ElementType.textBox:
                    return new TextElement();
                case IReturnElementType.ElementType.image:
                    return new TextElement();
                default:
                    return null;
            }
            return null;
        }

    }
}
