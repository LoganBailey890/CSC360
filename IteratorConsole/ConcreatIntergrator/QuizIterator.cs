using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IteratorConsole.Interface;
using IteratorConsole.ConcreatAggergate;

namespace IteratorConsole.ConcreatIntergrator
{
    public class QuizIterator : IQuestionstorage
    {
        QuizStorage storage;
        private int index = 0;
        public QuizIterator(QuizStorage storage)
        {
            this.storage = storage;
        }

        public IQuestion Current()
        {
            return this.storage.qustionList[index];
        }

        public bool HasNext()
        {
            return this.index < this.storage.qustionList.Count;
        }

        public void GetNext()
        {
            this.index++;
        }
    }
}
