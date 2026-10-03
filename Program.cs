//Porter Rasmussen. 10/2/26 lab5Mastermind
Console.Clear();

//Greeting
Console.WriteLine("What is your name?");
string userName = Console.ReadLine();
Console.WriteLine($"Welcome {userName}!");

//Get random message.
string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
int index = Random.Shared.Next(alphabet.Length);
char randomLetter1 = alphabet[Random.Shared.Next(alphabet.Length)];
char randomLetter2 = alphabet[Random.Shared.Next(alphabet.Length)];
char randomLetter3 = alphabet[Random.Shared.Next(alphabet.Length)];
char randomLetter4 = alphabet[Random.Shared.Next(alphabet.Length)];

//Make sure there are no duplicate letters in the secret.
while (randomLetter1==randomLetter2)
{
    randomLetter2 = alphabet[Random.Shared.Next(alphabet.Length)];
}
while (randomLetter1==randomLetter3)
{
    randomLetter3 = alphabet[Random.Shared.Next(alphabet.Length)];
}
while (randomLetter1==randomLetter4)
{
    randomLetter4 = alphabet[Random.Shared.Next(alphabet.Length)];
}
while (randomLetter2==randomLetter3)
{
    randomLetter3 = alphabet[Random.Shared.Next(alphabet.Length)];
}
while (randomLetter2==randomLetter4)
{
    randomLetter4 = alphabet[Random.Shared.Next(alphabet.Length)];
}
while (randomLetter3==randomLetter4)
{
    randomLetter4 = alphabet[Random.Shared.Next(alphabet.Length)];
}

//explain the rules and build the secret combination
string secretMessage = "" + randomLetter1 + randomLetter2 + randomLetter3 + randomLetter4;
Console.WriteLine("I have picked a set of 4 random letters and arranged them in a random order. It is your job to guess the secret combination.");
Console.WriteLine("The secret combination will not always be a real word. In fact, it usually isn't a real word. It is different every time you play again. Letters should never repeat.");

//While loop for guessing
bool guessedRight = false;
int numberOfGuesses = 0;

while (guessedRight==false)
{
    Console.Write("Press any key to continue.");
    Console.ReadKey(true);
    Console.Clear();
    Console.WriteLine($"{userName}, please guess a combination of 4 letters");
    string userGuess = Console.ReadLine().ToUpper();
    char [] characters = userGuess.ToCharArray();

    //Checking the guess
    if (userGuess == secretMessage)
    {
        guessedRight = true;
    }
    else if (userGuess.Length > 4)
    {
        Console.WriteLine("That was too many letters! I won't count that guess against you.");
        numberOfGuesses --;
    }
    else if (userGuess.Length < 4)
    {
        Console.WriteLine("That wasn't enough letters! I won't count that guess against you.");
        numberOfGuesses --;
    }
    else
    {
        Console.WriteLine("Wrong!");

        //Is there a way to use a switch to do this? I wasn't sure how I could make different cases that were not just for ints.
        if (characters[0]==randomLetter1)
        {
            Console.WriteLine($"The letter {characters[0]} is the correct letter in the correct place.");
        }
        if (characters[0]==randomLetter2 || characters[0]==randomLetter3 || characters[0]==randomLetter4)
        {
            Console.WriteLine($"The letter {characters[0]} is a correct letter in the wrong place.");
        }
        //Check 2nd letter
        if (characters[1]==randomLetter2)
        {
            Console.WriteLine($"The letter {characters[1]} is the correct letter in the correct place.");
        }
        if (characters[1]==randomLetter1 || characters[1]==randomLetter3 || characters[1]==randomLetter4)
        {
            Console.WriteLine($"The letter {characters[1]} is a correct letter in the wrong place.");
        }
        //Check 3rd letter
        if (characters[2]==randomLetter3)
        {
            Console.WriteLine($"The letter {characters[2]} is the correct letter in the correct place.");
        }
        if (characters[2]==randomLetter1 || characters[2]==randomLetter2 || characters[2]==randomLetter4)
        {
            Console.WriteLine($"The letter {characters[2]} is a correct letter in the wrong place.");
        }
        //Check 4th letter
        if (characters[3]==randomLetter4)
        {
            Console.WriteLine($"The letter {characters[3]} is the correct letter in the correct place.");
        }
        if (characters[3]==randomLetter1 || characters[3]==randomLetter2 || characters[3]==randomLetter3)
        {
            Console.WriteLine($"The letter {characters[3]} is a correct letter in the wrong place.");
        }
    }
    numberOfGuesses ++;
}

//correct answer finishing screen.
Console.Clear();
Console.WriteLine($"{secretMessage} is the word. Good job! You guessed the word.");
Console.WriteLine($"It took you {numberOfGuesses} guesses to get it right.");