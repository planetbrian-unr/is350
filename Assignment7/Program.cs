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
    bool onOff;
    int volume;
    string channel;
    double size;

    // constructors, default and parameterized
    public Television() {
        onOff = false;
        volume = 5;
        channel = "KOLO-TV";
        size = 45;
    }
    public Television(bool pwr, int vol, string stn, double scn) {
        onOff = pwr;
        volume = vol;
        channel = stn;
        size = scn;
    }

    // methods
    public void displayTV() {
        // if true, output stats. otherwise, just have size.
        if(onOff) {
            Console.WriteLine("TV of size {0} has volume {1} and is on channel '{2}'.", size, volume, channel);
        }
        else {
            Console.WriteLine("TV of size {0} is off.", size);
        }
    }
}
