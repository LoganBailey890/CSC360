using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.Interface
{
    public interface IQuestionstorage
    {
        bool HasNext();
        void GetNext();
        IQuestion? Current();
    }
}
