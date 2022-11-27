using Quiz;

// tworzenie obiektu typu Gra
var game = new Game();

// tworzenie obiektu typu Message
var message = new Message();

// wyświetlanie powitania
message.DisplayWelcomeScreen();

// losowanie pytania
game.GetQuestion();

// wyświetlanie pytania
game.CurrentQuestion.Display();
