using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IteratorConsole.Interface;

namespace IteratorConsole.QuizQuestions
{
    public class Question : IQuestion
    {
        private string? question;
        private string? correctAnswer;
        private List<string>? options= new List<string>();
        private string? title;

        public Question(string title)
        {
            this.title = title;
        }
        public Question(string question, string correctAnswer, List<string> options)
        {
            this.question = question;
            this.correctAnswer = correctAnswer;
            this.options = options;
        }
        public Question(string question, string correctAnswer, List<string> options, string title)
        {
            this.question = question;
            this.correctAnswer = correctAnswer;
            this.options = options;
            this.title = title;
        }
        public string CorrectAnswer()
        {
            return this.correctAnswer;
        }

        string IQuestion.Question()
        {
            if (HasQustion())
                return this.question;
            else
                return "";
        }

        public List<string> answerOptions()
        {
            return this.options;
        }

        public string? Title()
        {
            if(HasTitle())
            {
                return title;
            }
            return "";
        }

        public bool HasQustion()
        {
            if (question != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool HasTitle()
        {
            if(title != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
