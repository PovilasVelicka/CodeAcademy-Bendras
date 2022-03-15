using System;
using System.Collections.Generic;
using System.Text;

namespace Academy_NamuDarbai
{
    //sealed class - neleidzia implementuoti sios klases 
    public  class ConsoleReader
    {
        private static int      _oldConsoleLeftPosition;
        private static string[] _questions;
        private static int[]    _ansvers_int;
        private static double[] _answers_dobule;
        private static string[] _answers_string;
        private static int[]    _leftPositions;
        private static int[]    _topPositions;
        public static void ReadInt(string Question,out int Result)
        {
            _questions              = new string[1];
            _questions[0]           = Question;
            _ansvers_int            = new int[1];
            _leftPositions          = new int[1];
            _topPositions           = new int[1];
            _oldConsoleLeftPosition = Console.CursorLeft;
            writeQuestions();
            getAnswers_int();
            Result                  = _ansvers_int[0];
         
        }
        public static void ReadDouble(string Question, out double Result)
        {
            _questions = new string[1];
            _questions[0] = Question;
            _answers_dobule = new double[1];
            _leftPositions = new int[1];
            _topPositions = new int[1];
            _oldConsoleLeftPosition = Console.CursorLeft;
            writeQuestions();
            getAnswers_double();
            Result = _answers_dobule[0];
        }
        public static void ReadString(string Question, out string Result)
        {
            _questions = new string[1];
            _questions[0] = Question;
            _answers_string = new string[1];
            _leftPositions = new int[1];
            _topPositions = new int[1];
            _oldConsoleLeftPosition = Console.CursorLeft;
            writeQuestions();
            getAnswers_string();
            Result = _answers_string[0];
        }
        public static void ReadInt(string[] Questions, out int[] Results)
        {
            _questions = Questions;
            _leftPositions = new int[Questions.Length];
            _topPositions = new int[Questions.Length];
            _ansvers_int = new int[Questions.Length];

            _oldConsoleLeftPosition = Console.CursorLeft;
            writeQuestions();
            getAnswers_int();
            Results = _ansvers_int;
        }
        public static void ReadDouble(string[] Questions, out double[] Results)
        {
            _questions = Questions;
            _leftPositions = new int[Questions.Length];
            _topPositions = new int[Questions.Length];
            _answers_dobule = new double[Questions.Length];

            _oldConsoleLeftPosition = Console.CursorLeft;
            writeQuestions();
            getAnswers_double();
            Results = _answers_dobule;
        }
        public static void ReadString(string[] Questions, out string[] Results)
        {
            _questions = Questions;
            _leftPositions = new int[Questions.Length];
            _topPositions = new int[Questions.Length];
            _answers_string = new string[Questions.Length];

            _oldConsoleLeftPosition = Console.CursorLeft;
            writeQuestions();
            getAnswers_string();
            Results = _answers_string;
        }
        private static void writeQuestions()
        {
           for (int i = 0;i<_questions.Length;i++)
            {
                Console.CursorLeft = _oldConsoleLeftPosition;
                Console.Write(_questions[i]);
                _leftPositions[i] = Console.CursorLeft;
                _topPositions[i] = Console.CursorTop;                
                Console.CursorTop++;
                Console.CursorTop++;
            }
        }
        private static void getAnswers_int()
        {
            for (int i = 0; i < _questions.Length; i++)
            {
                string oldInput = "";
                do
                {
                    Console.CursorLeft = _leftPositions[i];
                    Console.CursorTop = _topPositions[i];
                    Console.Write(new string(' ', oldInput.Length));
                    Console.CursorLeft = _leftPositions[i];
                    oldInput = Console.ReadLine();
                } while (!int.TryParse(oldInput,out _ansvers_int[i]));
            }
        }
        private static void getAnswers_double()
        {
            for (int i = 0; i < _questions.Length; i++)
            {
                string oldInput = "";
                do
                {
                    Console.CursorLeft = _leftPositions[i];
                    Console.CursorTop = _topPositions[i];
                    Console.Write(new string(' ', oldInput.Length));
                    Console.CursorLeft = _leftPositions[i];
                    oldInput = Console.ReadLine();
                } while (!double.TryParse(oldInput, out  _answers_dobule[i]));
            }
        }
        private static void getAnswers_string()
        {
            for (int i = 0; i < _questions.Length; i++)
            {
                string oldInput = "";
                do
                {
                    Console.CursorLeft = _leftPositions[i];
                    Console.CursorTop = _topPositions[i];
                    Console.Write(new string(' ', oldInput.Length));
                    Console.CursorLeft = _leftPositions[i];
                    oldInput = Console.ReadLine();
                } while (string.IsNullOrWhiteSpace(oldInput ));
                 _answers_string[i] = oldInput;
            }
        }

    }
}
