using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Iterator.Interface;

namespace Iterator.Interface
{
    public interface IInventoryAgg
    {
        IQuestionstorage GetIterator();
        void AddQuestion(IQuestion question);
        void RemoveQuestion(IQuestion question);
    }
}
