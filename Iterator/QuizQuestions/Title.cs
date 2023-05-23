using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Iterator.Interface;

namespace Iterator.QuizQuestions
{
    public class Title : INameInterface
    {
        private string titleName;

        public Title(string titleName)
        {
            this.titleName = titleName;
        }

        public string Name()
        {
            return titleName;
        }
    }
}
