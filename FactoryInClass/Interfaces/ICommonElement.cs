using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryInClass.Interfaces
{
    public interface ICommonElement
    {
        void Write(string fileName);
        string GetContext();
        void SetContext(string context);
        int GetWidth();
        void SetWidth(int width);
        int GetHeight();
        void SetHeight(int height);
        int GetTop();
        void SetTop(int top);
        int GetLeft();
        void SetLeft(int left);

    }
}
