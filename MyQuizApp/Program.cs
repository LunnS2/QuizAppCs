namespace MyQuizApp;

class Program
{
    static void Main(string[] args)
    {
        Question[] questions = new Question[]
         {
            new Question("What is the capital of France?", new string[] { "Berlin", "Madrid", "Paris", "Rome" }, 2),
            new Question("What is 2 + 2?", new string[] { "3", "4", "5", "6" }, 1),
            new Question("What is the largest planet in our solar system?", new string[] { "Earth", "Mars", "Jupiter", "Saturn" }, 2),
            new Question("What is the chemical symbol for gold?", new string[] { "Au", "Ag", "Fe", "Pb" }, 0),
            new Question("What is the speed of light?", new string[] { "300,000 km/s", "150,000 km/s", "1,000,000 km/s", "500,000 km/s" }, 0),
            new Question("Who wrote 'Romeo and Juliet'?", new string[] { "Charles Dickens", "William Shakespeare", "Mark Twain", "Jane Austen" }, 1),
            // Add more questions as needed
         };

        Quiz myQuiz = new Quiz(questions);
        myQuiz.StartQuiz();
    }
}
