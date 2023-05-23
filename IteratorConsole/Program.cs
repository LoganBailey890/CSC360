using IteratorConsole.ConcreatAggergate;
using IteratorConsole.ConcreatIntergrator;
using IteratorConsole.Interface;
using IteratorConsole.QuizQuestions;


namespace IteratorConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int score= 0;
            IInventoryAgg questionPool = new QuizStorage();
            questionPool.AddQuestion(new Question("Starwars"));
            questionPool.AddQuestion(new Question("Who is Darth Vader", "A", new List<string> {"A: Lukes father","B: The empire" }));
            questionPool.AddQuestion(new Question("Where did Luke find Yoda", "C", new List<string> {"A: Tatione","B: The death star", "C: The degoba system" }));
            questionPool.AddQuestion(new Question("What color was Lukes first lightsaber", "B", new List<string> {"A: Red","B: Blue", "C: Green" }));
            questionPool.AddQuestion(new Question("What color was Mas window", "A", new List<string> {"A: Purpe","B: Blue", "C: Green","D: Red" }));
            IQuestionstorage _quizItorator = questionPool.GetIterator();
            while(_quizItorator.HasNext())
            {
                if(_quizItorator.Current().HasTitle())
                {
                    Console.WriteLine(_quizItorator.Current()?.Title());
                }
                if(_quizItorator.Current().HasQustion())
                {
                    Console.WriteLine(_quizItorator.Current()?.Question());
                    foreach (var item in _quizItorator.Current()?.answerOptions())  
                    {
                        Console.WriteLine(item);
                    }
                    if(Console.ReadLine() == _quizItorator.Current()?.CorrectAnswer())
                        score++;
                }
                _quizItorator.GetNext();
            }
            Console.WriteLine(score);
        }
    }
}
