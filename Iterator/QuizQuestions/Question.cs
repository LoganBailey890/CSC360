using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Iterator.Interface;

namespace Iterator.QuizQuestions
{
    public class Question : IQuestion
    {
        private string question;
        private string correctAnswer;
        private string answerOptionA;
        private string answerOptionB;
        public Question(string question, string correctAnswer, string answerOptionA, string answerOptionB)
        {
            this.question = question;
            this.correctAnswer = correctAnswer;
            this.answerOptionA = answerOptionA;
            this.answerOptionB = answerOptionB;
        }
        public string Name()
        {
            throw new NotImplementedException();
        }
        public string AnswerOptionA()
        {
            return this.answerOptionA;
        }

        public string AnswerOptionB()
        {
            return this.answerOptionB;
        }
        public string CorrectAnswer()
        {
            return this.correctAnswer;
        }

        string IQuestion.Question()
        {
            return this.question;
        }
    }
}
