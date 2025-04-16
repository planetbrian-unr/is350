/*
    Brian Wu
    IS 350: Assignment 8
    Celebrity followers generator
*/

// while the loop is true, repeatedly ask the user for a number. then it'll "break" out
int numCelebrities;

while(true) {
    Console.WriteLine("Enter the number of celebrities: ");

    // validate if the value is an integer and positive. if so, change bool
    if(int.TryParse(Console.ReadLine(), out numCelebrities) && numCelebrities > 0) break;
    else Console.WriteLine("Please enter a positive integer value");
}

// create a string array with the provided number, looping through for names
string[] celebrityNames = new string[numCelebrities];

for(int i = 0; i < numCelebrities; i++) {
    while(true) {
        // using "i + 1" because otherise it would ask for name #0
        Console.WriteLine("Enter the name of celebrity #{0}:", i + 1);
        string name = Console.ReadLine();

        if(!string.IsNullOrEmpty(name)) {
            celebrityNames[i] = name;
            break;
        }
        else {
            Console.WriteLine("Please enter something");
        }
    }
}

// followers generator, outputting the content
Random followerCount = new Random();

foreach(string celebrity in celebrityNames) Console.WriteLine("{0} has {1} followers", celebrity, followerCount.Next(5000, 500001));