using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    public class Message
    {
        public void DisplayWelcomeScreen()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.WriteLine("WITAJ W QUIZIE WIEDZY GRUPY 5");
            Console.WriteLine("Spróbuj odpowiedzieć na 7 pytań");
            Console.WriteLine("POWODZDENIA!!!");
            Console.WriteLine();
            Console.WriteLine("Nacisnij ENTER, aby rozpocząć grę ...");
            Console.ReadLine();
        }

        internal void DisplayFailAndGameOver()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine();
            Console.WriteLine("NIESTETY, TO NIE JEST PRAWIDŁOWA ODPOWIEDŹ ...");
            Console.WriteLine("KONIEC GRY !!!");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void FinalScreen()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine("BRAWO, UKOŃCZYŁEŚ/AŚ QUIZ ...");
            Console.WriteLine("KONIEC GRY !!!");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void GoodAnswer()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine("Brawo, to był prawidłowa odpowiedź ...");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Naciśnij ENTER, aby zobaczyć następne pytanie ...");
            Console.ReadLine();
            Console.WriteLine();

        }
    }
}
