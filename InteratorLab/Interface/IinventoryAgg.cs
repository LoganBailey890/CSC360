using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteratorLab.Interface
{
    public interface IinventoryAgg
    {
        IQuestionstorage GetIterator();
        void AddQuestion(IQuestion question);
        void RemoveQuestion(IQuestion question);
    }
}
