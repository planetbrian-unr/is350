/*
    a.
    Brian Wu
    IS 350: Assignment 5
    Pirate accounting
*/

// c. prompt for initial amount of money
Console.WriteLine("Enter your starting amount of gold pieces in your treasure");

// g. input and check for non-numeric user input expection
if(!int.TryParse(Console.ReadLine(), out int money)) {
    Console.WriteLine("Please enter a numeric value");
    return;
}

// d. simulation prompt
Console.WriteLine("The treasure will have an equal chance to increase/decrease by 25 pieces/month");
Console.WriteLine("What simulation type do you want to run?");
Console.WriteLine("(1) Run until treasure amount is 0≤x≤1000");
Console.WriteLine("(2) Run for a specified # of months");

// g. input and check for non-numeric user input expection
if(!int.TryParse(Console.ReadLine(), out int simulationSelection)) {
    Console.WriteLine("Please enter a numeric value");
    return;
}

// e. simulation logic
Random randomChance = new Random();
switch(simulationSelection) {
    case 1:     // di. run sim
                int currentMonthCase1 = 1;
                do {
                    // e. equal chance to increase/decrease
                    money += randomChance.Next(2) == 0 ? 25 : -25;

                    // f. output year/amount
                    Console.WriteLine("Year {0}: {1} gold pieces", currentMonthCase1++, money);
                } while(money >= 0 && money <= 1000);
                break;

    case 2:     // dii. prompt
                Console.WriteLine("How many years do you want to run for?");

                // g. non-numeric user input expection
                if(!int.TryParse(Console.ReadLine(), out int years)) {
                    Console.WriteLine("Please enter a numeric value");
                    return;
                }
                
                // run sim
                for(int currentMonthCase2 = 1; currentMonthCase2 <= years; currentMonthCase2++) {
                    // e. equal chance to increase/decrease
                    money += randomChance.Next(2) == 0 ? 25 : -25;

                    // f. output year/amount
                    Console.WriteLine("Year {0}: {1} gold pieces", currentMonthCase2, money);
                }
                break;

    default:    Console.WriteLine("Please enter either 1 or 2");
                return;
}
