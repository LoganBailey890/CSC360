using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteratorLab.Interface
{
    public interface IQuestionstorage
    {
        bool hasNext();
        void Next();
        IQuestion? current();
    }
}
