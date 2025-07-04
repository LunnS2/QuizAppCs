﻿namespace MyQuizApp;

internal class Question
{
    public string QuestionText { get; set; }
    public string[] Answers { get; set; }

    public int CorrectAnswerIndex { get; set; }

    public Question(string questionText, string[] answers, int correctAnswerIndex)
    {
        QuestionText = questionText;
        Answers = answers;
        CorrectAnswerIndex = correctAnswerIndex;
    }

    public bool IsCorrect(int answerIndex)
    {
        return answerIndex == CorrectAnswerIndex;
    }
}
