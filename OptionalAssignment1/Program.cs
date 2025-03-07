/*
    Brian Wu
    IS 350: Optional Assignment 1
    3 methods
*/

// 1. rickroll
static void rickRoll(string text, int count) {
    if(count > 0) {
        for(int i = 0; i < count; i++) {
            Console.WriteLine("Never gonna...{0}", text);
        }
    }
    else {
        Console.WriteLine("I gave you up");
    }
}

// 2. evenorodd
static string evenOrOdd() {
    Console.WriteLine("Enter a whole number");
    int number = Convert.ToInt32(Console.ReadLine());
    return number % 2 == 0 ? "Even" : "Odd";
}

// 3. sevenAteNine
static int sevenAteNine(int num1, int num2, int num3) {
    if(num1 >= num2 && num1 >= num3) {
        return num1;
    }
    else if(num2 >= num1 && num2 >= num3) {
        return num2;
    }
    else {
        return num3;
    }
}

// main
rickRoll("give you up", 5);
rickRoll("give you up", 0);

Console.WriteLine(evenOrOdd());

Console.WriteLine(sevenAteNine(7, 8, 9));
Console.WriteLine(sevenAteNine(10, 8, 10));
