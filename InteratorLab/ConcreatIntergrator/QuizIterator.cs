using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InteratorLab.Interface;
using InteratorLab.ConcreatAggergate;

namespace InteratorLab.ConcreatIntergrator
{
    public class QuizIterator : IQuestionstorage
    {
        QuizStorage storage;
        private int index = 0;
        public QuizIterator(QuizStorage storage)
        {
            this.storage = storage;
        }

        public IQuestion current()
        {
            return this.storage.qustionList[index];
        }

        public bool hasNext()
        {
            return this.index < this.storage.qustionList.Count;
        }

        public void Next()
        {
            this.index++;
        }
    }
}
