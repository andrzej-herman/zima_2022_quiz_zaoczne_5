using Quiz;




// tworzenie obiektu typu Gra
var game = new Game();

// tworzenie obiektu typu Message
var message = new Message();

// wyświetlanie powitania
message.DisplayWelcomeScreen();

// losowanie pytania
game.GetQuestion();

// wyświetlanie pytania i pobieranie odpowiedzi gracza
int playerAnswer = game.CurrentQuestion.Display();


// sprawdxamy czy odpowiedź gracza jest prawidłowa
bool correctAnswer = game.CheckPlayerAnswer(playerAnswer);
if (correctAnswer)
{
    Console.WriteLine("HURRA");
}
else
{
    message.DisplayFailAndGameOver();
}







Console.ReadLine();
