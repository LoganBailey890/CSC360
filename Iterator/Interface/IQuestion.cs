using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.Interface
{
    public interface IQuestion : INameInterface
    {
        string Question();
        string CorrectAnswer();
        string AnswerOptionA();
        string AnswerOptionB();
    }
}
