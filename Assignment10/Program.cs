/*
    Brian Wu
    IS 350: Assignment 10
    Franchise Manager
*/

// object creation
Store store1 = new Store();
Store store2 = new Store(4, true);
Store store3 = new Store(3, false);

// set inventory
store1.SetInventoryEasy();
store2.SetInventory();
store3.SetInventoryEasy();

// output information
store1.StoreDetails();
store2.StoreDetails();
store3.StoreDetails();

// classes
public class Store {
    // variables
    static int storeCounter = 1;
    int storeID;
    string[] inventory;
    bool isOpen;

    // constructors, default and parameterized
    public Store() {
        storeID = storeCounter++;
        inventory = new string[3];
        isOpen = true;
    }
    public Store(int size, bool status) {
        storeID = storeCounter++;
        inventory = new string[size];
        isOpen = status;
    }

    // methods
    public void SetInventory() {
        for(int i = 0; i < inventory.Length; i++) {
            Console.WriteLine("Enter item #{0}:", i + 1);
            string entry = Console.ReadLine();

            if(string.IsNullOrEmpty(entry)) {
                entry = "item " + (i + 1);
            }

            inventory[i] = entry;
        }
    }
    public void SetInventoryEasy() {
        if(inventory.Length >= 3) {
            inventory[0] = "Shoes";
            inventory[1] = "Shirts";
            inventory[2] = "Pants";
        }
        else {
            Console.WriteLine("Inventory size is too small for easy setup.");
        }
    }
    public void StoreDetails() {
        Console.WriteLine("Store ID: {0}", storeID);
        Console.WriteLine("Inventory:");
        foreach(string item in inventory) {
            Console.WriteLine(item);
        }
        Console.WriteLine("The store is {0}", isOpen ? "open" : "closed");
    }
}