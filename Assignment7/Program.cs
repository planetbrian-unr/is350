/*
    Brian Wu
    IS 350: Assignment 7
    Intro to classes and objects. TV time!
*/

// create 2 television objcts at the top level and call them
Television tv1 = new Television();
Television tv2 = new Television(true, 10, "Animal Planet", 55);

tv1.displayTV();
tv2.displayTV();

// Television class with variables, constructors, and methods
public class Television {
    // variables
    private bool onOff;
    private int volume;
    private string channel;
    private double size;

    // constructors
    public Television() {
        onOff = false;
        volume = 5;
        channel = "KOLO-TV";
        size = 45;
    }
    public Television(bool powerStatus, int volumeLevel, string stationName, double screenSize) {
        onOff = powerStatus;
        volume = volumeLevel;
        channel = stationName;
        size = screenSize;
    }

    // methods
    public void displayTV() {
        if(onOff) {
            Console.WriteLine("TV of size {0} has volume {1} and is on channel '{2}'.", size, volume, channel);
        }
        else {
            Console.WriteLine("TV of size {0} is off.", size);
        }
    }
}

