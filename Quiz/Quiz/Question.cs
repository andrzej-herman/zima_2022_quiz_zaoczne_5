using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    public class Question
    {
        public int Id { get; set; }
        public int Category { get; set; }
        public string Content { get; set; }
        public List<Answer> Answers { get; set; } = new List<Answer>();


        void ShowQuestion()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine($"Pytanie za {Category} pkt");
            Console.WriteLine();
            Console.WriteLine(Content);
            Console.WriteLine();
            foreach (var a in Answers)
            {
                Console.WriteLine($"{a.Order}. {a.Content}");
            }
            Console.WriteLine();
            Console.Write("Wybierz numer poprawnej odpowiedzi: 1, 2, 3 lub 4 => ");
        }


        public int Display()
        {
            ShowQuestion();
            var playerAnswer = Console.ReadLine();
            bool correctKey = IsGoodKey(playerAnswer);
            while (correctKey == false)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("Nacisnąłeś nieprawidłowy klawisz ...");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
                ShowQuestion();
                playerAnswer = Console.ReadLine();
                correctKey = IsGoodKey(playerAnswer);
            }

            return int.Parse(playerAnswer);
        }

        bool IsGoodKey(string key)
        {
            int.TryParse(key, out int number);
            if (number > 0 && number < 5)
            {
                return true;
            }

            return false;
        }



    }
}
