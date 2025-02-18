/*
    a.
    Brian Wu
    IS 350: Assignment 4
    Math test
*/

// c. prompt for user name
Console.WriteLine("What is your name?");
string userName = Console.ReadLine();

// d. checks if userName variable has a value
if(string.IsNullOrEmpty(userName)) {
    Console.WriteLine("No name entered. Proceeding anyway...");
}

// f. create random object and generate two numbers with it. init variable
Random randNum = new Random();
int num1 = randNum.Next(10, 21), num2 = randNum.Next(10, 21);
int correctAnswer = 0;

// e. quiz system, getting user input for operation first
Console.WriteLine("What quiz (+, -, *, /) would you like?");
string operationInput = Console.ReadLine();
// switch to check if correct after verifying valid input
switch(operationInput) {
    case "+":
        correctAnswer = num1 + num2;
        break;

    case "-":
        correctAnswer = num1 - num2;
        break;

    case "*":
        correctAnswer = num1 * num2;
        break;

    case "/":   // giii. For division, use integer division
        correctAnswer = num1 / num2;
        break;

    default:
        Console.WriteLine("Improper input!");
        break;
}

// g. math question
Console.WriteLine("What is {0} {1} {2}?", num1, operationInput, num2);

// gi. check if answerinput is valid
if(!int.TryParse(Console.ReadLine(), out int answer)) {
    Console.WriteLine("Invalid input! Please enter a whole number.");
    return;
}

// gii. Check if the user's answer is correct
if(answer == correctAnswer) {
    Console.WriteLine("Congratulations, {0}! Your answer is correct.", userName);
}
else {
    Console.WriteLine("Sorry, {0}. The correct answer is {1}.", userName, correctAnswer);
}