namespace MyQuizApp;

internal class Quiz
{
    private Question[] _questions;

    private int _score;

    public Quiz(Question[] questions)
    {
        _questions = questions;
        _score = 0;
    }

    public void StartQuiz()
    {
        Console.Clear();
        Console.WriteLine("Welcome to the Quiz!");
        Console.WriteLine("Press any key to start...");
        Console.ReadKey();
        Console.Clear();

        foreach (var question in _questions)
        {
            DisplayQuestion(question);
            Console.WriteLine();
        }

        DisplayResults();
    }

    private void DisplayQuestion(Question question)
    {
        Console.WriteLine(question.QuestionText);

        for (int i = 0; i < question.Answers.Length; i++)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"{i + 1}. {question.Answers[i]}");
        }

        if (question.IsCorrect(GetUserAnswer()))
        {
            _score++;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Correct!");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Incorrect.");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"The correct answer is: {question.Answers[question.CorrectAnswerIndex]}");
        }
        // Telling the user the correct answer


        Console.ResetColor();
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
        Console.Clear();
    }

    private int GetUserAnswer()
    {
        Console.ResetColor();
        Console.Write("Please enter the number of your answer: ");
        string input = Console.ReadLine();
        int answerIndex;

        if (int.TryParse(input, out answerIndex) && answerIndex > 0 && answerIndex <= _questions[0].Answers.Length)
        {
            return answerIndex - 1; // Adjust for zero-based index
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
            return GetUserAnswer(); // Recursive call for valid input
        }
    }

    private void DisplayResults()
    {
        Console.WriteLine("Quiz completed! Thank you for participating.");
        Console.WriteLine($"Your score: {_score}/{_questions.Length}");
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
        Console.Clear();
    }
}
