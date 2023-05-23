using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace IteratorConsole.Interface
{
    public interface IQuestion : IBaseItem
    {
        bool HasQustion();
        string Question();
        string CorrectAnswer();
        List<string> answerOptions();
    }
}
