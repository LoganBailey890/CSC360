using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IteratorConsole.Interface;
using IteratorConsole.ConcreatIntergrator;

namespace IteratorConsole.ConcreatAggergate
{
    public class QuizStorage : IInventoryAgg
    {
        public List<IQuestion> qustionList;
        public QuizStorage()
        {
            qustionList = new List<IQuestion>();
        }

        public void AddQuestion(IQuestion question)
        {
            qustionList.Add(question);
        }

        public IQuestionstorage GetIterator()
        {
            return new QuizIterator(this);
        }

        public void RemoveQuestion(IQuestion question)
        {
            qustionList.Remove(question);
        }
    }
}
