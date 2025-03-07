/*
    Brian Wu
    IS 350: Assignment 3
    Writer or actor? Practicing if/switch statements and bools
*/

// declaring the writers/actors used later in this program
string writer1 = "George Orwell", writer2 = "John Steinbeck";
string actor1 = "Robert Downey Jr.", actor2 = "Scarlett Johansson";

// for user input, either 1 or 2
int input;
bool choice;

Console.WriteLine("Is {0} is a writer (1) or an actor (2)?", writer1);  // asking the question, using a variable for the person's name
input = Convert.ToInt32(Console.ReadLine());    // getting user input to be used in the if/else statement

choice = input == 1;

Console.WriteLine("{0} {1} is a writer!", choice ? "Good job!" : "Incorrect!", writer1);
Console.WriteLine("Press enter to continue");
Console.ReadKey();


Console.WriteLine("Is {0} is a writer (1) or an actor (2)?", writer2);  // repeats for the others, changing if/else condition if needed
input = Convert.ToInt32(Console.ReadLine());

choice = input == 1;

Console.WriteLine("{0} {1} is a writer!", choice ? "Good job!" : "Incorrect!", writer2);
Console.WriteLine("Press enter to continue");
Console.ReadKey();


Console.WriteLine("Is {0} is a writer (1) or an actor (2)?", actor1);
input = Convert.ToInt32(Console.ReadLine());

choice = input == 2;

Console.WriteLine("{0} {1} is an actor!", choice ? "Good job!" : "Incorrect!", actor1);
Console.WriteLine("Press enter to continue");
Console.ReadKey();


Console.WriteLine("Is {0} is a writer (1) or an actor (2)?", actor2);
input = Convert.ToInt32(Console.ReadLine());

choice = input == 2;

Console.WriteLine("{0} {1} is an actor!", choice ? "Good job!" : "Incorrect!", actor2);
Console.WriteLine("Press enter to continue");
Console.ReadKey();