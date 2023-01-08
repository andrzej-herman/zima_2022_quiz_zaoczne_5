using Quiz;
// tworzenie obiektu typu Gra
var game = new Game();

// tworzenie obiektu typu Message
var message = new Message();

// wyświetlanie powitania
message.DisplayWelcomeScreen();


while(true)
{
    // losowanie pytania
    game.GetQuestion();

    // wyświetlanie pytania i pobieranie odpowiedzi gracza
    int playerAnswer = game.CurrentQuestion.Display();


    // sprawdxamy czy odpowiedź gracza jest prawidłowa
    bool correctAnswer = game.CheckPlayerAnswer(playerAnswer);
    if (correctAnswer)
    {
        // sprawdzenie czy to było ostatnie pytanie
        // jeżeli nie => to podnosimy kategorię
        if (game.IsLastCategory())
        {
            message.FinalScreen();
            break;
        }
        else
        {
            message.GoodAnswer();
            // wyswietlamy nastepne pytanie
        }
    }
    else
    {
        message.DisplayFailAndGameOver();
        break;
    }

}

Console.ReadLine();
