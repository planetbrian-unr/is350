/*
    Brian Wu
    IS 350: Assignment 9
    fast food menu manager
*/

// 4a
string[] menu1 = MenuCreator.DefaultMenu();
string[] menu2 = MenuCreator.CustomMenu(3);

// 4b
MenuCreator.PrintMenu(menu1);
MenuCreator.PrintMenu(menu2);

public class MenuCreator {
    // methods
    // 1
    public static string[] DefaultMenu() {
        // returns string array
        return ["Cheeseburger", "Chicken Sandwich", "Salad"];
    }

    // 2
    public static string[] CustomMenu(int itemCount) {
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
    public static void PrintMenu(string[] menu) {
        // outputs length and contents
        Console.WriteLine("This menu has {0} items", menu.Length);
        foreach(string item in menu) {
            Console.WriteLine(item);
        }
    }
}