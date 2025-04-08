/*
    Brian Wu
    IS 350: Assignment 9
    fast food menu manager
*/

// 1
static string[] defaultMenu() {
    // returns string array
    return new string[] { "Cheeseburger", "Chicken Sandwich", "Salad" };
}

// 2
static string[] customMenu(int itemCount) {
    // create string array
    string[] customMenu = new string[itemCount];

    // loop through and get input
    for(int i = 0; i < itemCount; i++) {
        Console.WriteLine("Enter item #{0}:", i + 1);
        customMenu[i] = Console.ReadLine();
    }

    // returns array
    return customMenu;
}

// 3
static void printMenu(string[] menu) {
    // outputs length and contents
    Console.WriteLine("This menu has {0} items", menu.Length);
    foreach(string item in menu) {
        Console.WriteLine(item);
    }
}

// 4a
string[] menu1 = defaultMenu();
string[] menu2 = customMenu(3);

// 4b
printMenu(menu1);
printMenu(menu2);
