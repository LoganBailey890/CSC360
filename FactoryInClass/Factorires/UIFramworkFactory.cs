using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using FactoryInClass.Interfaces;
using FactoryInClass.UIElements;



namespace FactoryInClass.Factorires
{
    public class UIFramworkFactory : IReturnElementType
    {

        public static ICommonElement GetElement(IReturnElementType.ElementType elementType)
        {
            switch (elementType)
            {
                case IReturnElementType.ElementType.button:
                    return new ButtonElement();
                case IReturnElementType.ElementType.textBox:
                    return new TextElement();
                default:
                    return null;
            }
            return null;
        }

    }
}
