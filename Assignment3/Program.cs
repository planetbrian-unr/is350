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

Console.WriteLine("Is {0} is a writer (1) or an actor (2)?", writer1);  // asking the question, using a variable for the person's name
input = Convert.ToInt32(Console.ReadLine());    // getting user input to be used in the if/else statement

if(input == 1) {
    Console.WriteLine("Good job! {0} is a writer!", writer1);
}
else {
    Console.WriteLine("Incorrect! {0} is a writer!", writer1);
}

Console.WriteLine("Press enter to continue");
Console.ReadKey();


Console.WriteLine("Is {0} is a writer (1) or an actor (2)?", writer2);  // repeats for the others, changing if/else condition if needed
input = Convert.ToInt32(Console.ReadLine());

if(input == 1) {
    Console.WriteLine("Good job! {0} is a writer!", writer2);
}
else {
    Console.WriteLine("Incorrect! {0} is a writer!", writer2);
}

Console.WriteLine("Press enter to continue");
Console.ReadKey();


Console.WriteLine("Is {0} is a writer (1) or an actor (2)?", actor1);
input = Convert.ToInt32(Console.ReadLine());

if(input == 2) {
    Console.WriteLine("Good job! {0} is an actor!", actor1);
}
else {
    Console.WriteLine("Incorrect! {0} is an actor!", actor1);
}

Console.WriteLine("Press enter to continue");
Console.ReadKey();


Console.WriteLine("Is {0} is a writer (1) or an actor (2)?", actor2);
input = Convert.ToInt32(Console.ReadLine());

if(input == 2) {
    Console.WriteLine("Good job! {0} is an actor!", actor2);
}
else {
    Console.WriteLine("Incorrect! {0} is an actor!", actor2);
}

Console.WriteLine("Press enter to continue");
Console.ReadKey();