/*
    a.
    Brian Wu
    IS 350: Assignment 6
    Absolutely nothing, uhh (some card game)
*/

/* methods */
// c. Draw, which returns a random number between 1 and 13
static int draw(Random r) {
    return r.Next(1, 14);
}

// d. War, no returned data, but takes two string parameters
static void war(string player1Name, string player2Name) {
    int rounds = 0;
    Random cardValue = new Random();
    int player1Cards = 26, player2Cards = 26;   // dii

    Console.WriteLine("\n");

    // diii. while loop to play War until either player has 0 cards
    while(player1Cards > 0 && player2Cards > 0) {
        string roundWinner;
        
        rounds++;
        int player1Card = draw(cardValue), player2Card = draw(cardValue); // players draw cards
 
        // outputs values before comparing them to see who won the round.
        Console.WriteLine("Round {0}. {1}'s card: {2}. {3}'s card: {4}.", rounds, player1Name, player1Card, player2Name, player2Card);
        if(player1Card > player2Card) {
            player1Cards++;
            player2Cards--;
            roundWinner = player1Name + " wins.";
        }
        else if(player1Card < player2Card) {
            player1Cards--;
            player2Cards++;
            roundWinner = player2Name + " wins.";
        }
        else {
            roundWinner = "Tie.";
        }
        
        // outputs round results
        Console.WriteLine("{0} {1} has {2} cards. {3} has {4} cards.\n", roundWinner, player1Name, player1Cards, player2Name, player2Cards);
    }

    // div. congratulates winner and outputs rounds
    Console.WriteLine("Winner: {0}. Took {1} rounds.", (player1Cards > player2Cards) ? player1Name : player2Name, rounds);
}

/* main, asks for player names before playing War */
Console.WriteLine("Let's play War!");

Console.WriteLine("What is the name of the 1st player?");
string firstName = Console.ReadLine();
if(string.IsNullOrEmpty(firstName)) {
    firstName = "Name1";
    Console.WriteLine("No name entered. Using \"{0}\".", firstName);
}

Console.WriteLine("What is the name of the 2nd player?");
string secondName = Console.ReadLine();
if(string.IsNullOrEmpty(secondName)) {
    secondName = "Name2";
    Console.WriteLine("No name entered. Using \"{0}\".", secondName);
}

// e. function call
war(firstName, secondName);