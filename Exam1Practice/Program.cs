// ppt q1
try {
    Console.WriteLine("Enter a #");
    if(Convert.ToInt32(Console.ReadLine()) < 0) Console.WriteLine("Warning, negative #!");
}
catch {
    Console.WriteLine("Please enter a whole #!");
}

// ppt q2
Console.WriteLine("How many dounts?");
double donutTotalCost = 1.99 * Convert.ToInt32(Console.ReadLine());

Console.WriteLine("How many coffees?");
double coffeeTotalCost = 0.99 * Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Order cost: {0}", donutTotalCost + coffeeTotalCost);

// ppt q3
static int rollXDie(int sides, int rolls) {
    Random die = new Random();
    int sum = 0;
    
    for(int i = 0; i < rolls; i++) sum += die.Next(1, sides + 1);

    return sum;
}

Console.WriteLine(rollXDie(6, 10));

// ppt q4
Console.WriteLine("Enter #");
int q4intInput = Convert.ToInt32(Console.ReadLine());

for(int i = 2; i <= 50; i++) {
    if(q4intInput % i == 0) Console.WriteLine(i);
}

// ppt q5
static void survivalRate(int value) {
    if(value > 0) {
        for(int i = value; i >= 0; i--) Console.WriteLine(i);
    }
    else if(value < 0) {
        for(int i = value; i <= 0; i++) Console.WriteLine(i);      
    }
}

survivalRate(5);
survivalRate(-5);

// doc q1
for(int i = 0; i < 500; i++) Console.WriteLine("We Are Number One");

// doc q2
Console.WriteLine("Enter a double value");
double q2dblInput = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(Convert.ToInt32(q2dblInput));

// doc q3
int count = 8;

while(count > 0) Console.WriteLine(count--);

// doc q4
static int compareIntegers(int num1, int num2) {
    if(num1 > num2) return num1;
    else if(num2 > num1) return num2;
    else return -1;
}

Console.WriteLine(compareIntegers(2, 1));
Console.WriteLine(compareIntegers(1, 2));
Console.WriteLine(compareIntegers(1, 1));

// doc q5
try {
    Console.WriteLine("How much would you like to withdraw?");
    if(Convert.ToDouble(Console.ReadLine()) < 0) Console.WriteLine("Negative number!");
}
catch {
    Console.WriteLine("Non-numeric value!");
}

// doc q6
Random number = new Random();
int generatedNumber, userGuess;

while(true) {
    generatedNumber = number.Next(11);

    Console.WriteLine("Guess the #");
    userGuess = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("You guessed {0}", userGuess == generatedNumber ? "correctly" : "incorrectly");

    Console.WriteLine("Would you like to continue?");
    if(Console.ReadLine() == "no") break;
    else continue;
}

// doc q7
int sum = 0;

for(int i = 1; i <= 1000; i++) sum += i;

// doc q8
Console.WriteLine("Enter an integer");
int userInput = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Is {0} divisible by 5 and 6? {1}", userInput, (userInput % 5 == 0 && userInput % 6 == 0) ? "true" : "false");
Console.WriteLine("Is {0} divisible by 5 or 6? {1}", userInput, (userInput % 5 == 0 || userInput % 6 == 0) ? "true" : "false");

// doc q9
static void repeater(string text, int times) {
    for(int i = 0; i < times; i++) Console.WriteLine(text);
}

repeater("hi", 5);

// doc q10
string tallestName = "";
int tallestHeight = 0;

while(true) {
    Console.WriteLine("Name?");
    string name = Console.ReadLine();

    Console.WriteLine("Height?");
    int height = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Continue?");
    if(Console.ReadLine() == "False")  break;

    if(height > tallestHeight) {
        tallestName = name;
        tallestHeight = height;
    }
}

Console.WriteLine("{0} is the tallest at {1} inches", tallestName, tallestHeight);
