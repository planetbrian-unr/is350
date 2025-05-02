// docx q1
static void generateNumbers(int count, string path) {
    Random num = new Random();

    using(StreamWriter file = new StreamWriter(path, false)) {
        for(int i = 0; i < count; i++) {
            file.WriteLine(num.Next(1, 101));
        }
    }
}

generateNumbers(15, @"../../../q1output.txt");


// docx q2
static int[] sorter(int num1, int num2, int num3) {
    int[] arr = [num1, num2, num3];
    Array.Sort(arr);
    return arr;
}

foreach(int number in sorter(4, 7, 1)) {
    Console.WriteLine(number);
}

// docx q3
using(StreamWriter file = new StreamWriter(@"../../../q2output.txt", false)) {
    for(int i = 0; i < 1000; i++) {
        if(i % 2 == 1) {
            file.WriteLine(i);
        }
    }
}


// docx q4
public class Rectangle {
    // variables
    double width;
    double length;

    // constructors
    public Rectangle() {
        width = 1.5;
        length = 1.5;
    }
    public Rectangle(double wid, double len) {
        width = wid;
        length = len;
    }

    // methods
    public double getArea() {
        return width * length;
    }
    public double getPerimeter() {
        return 2 * (width + length);
    }
}

// docx q5
Cookie c1 = new Cookie();
Cookie c2 = new Cookie();
Cookie[] cBox = new Cookie[] {c1, c2};

Cookie.EatLotsOfCookies(cBox);
public class Cookie {
    // variables
    double radius;
    bool isEaten;

    // constructors
    public Cookie() {
        radius = 1.5;
        isEaten = false;
    }

    // methods (instance)
    public void EatCookie() {
        radius = 0;
        isEaten = true;
    }
    public static void EatLotsOfCookies(Cookie[] arr) {
        foreach(Cookie c in arr) {
            c.EatCookie();
        }
    }
}

// docx q6
public class Student {
    // variables
    string name;
    string[] courses;

    // constructor
    public Student() {
        name = "default";
        courses = new string[3];
    }
    public Student(string nm, int courseCount) {
        name = nm;
        courses = new string[courseCount];        
    }

    // methods
    public void DisplayInfo() {
        Console.WriteLine("Student {0} is taking {1} classes", name, courses.Length);
        foreach(string course in courses) {
            Console.WriteLine(course);
        }
    }
}

// docx q7
static int rollDice(int rolls) {
    Random die = new Random();
    int sum = 0;
    
    for(int i = 0; i < rolls; i++) {
        int dieValue = die.Next(1, 7);
        sum += dieValue;
        Console.WriteLine("Rolled a {0}", dieValue);
    }

    return sum;
}

// docx q8
int[] weekSteps = new int[7];
for(int i = 0; i < 7; i++) {
    Console.WriteLine("How many steps did you walk on day {0}?", i + 1);
    weekSteps[i] = Convert.ToInt32(Console.ReadLine());
}

int mostSteps = weekSteps[0], leastSteps = weekSteps[0], totalSteps = 0;
for(int i = 0; i < weekSteps.Length; i++) {
    if(weekSteps[i] > mostSteps) {
        mostSteps = weekSteps[i];
    }
    if(weekSteps[i] < leastSteps) {
        leastSteps = weekSteps[i];
    }
    totalSteps += weekSteps[i];
}

Console.WriteLine("most: {0}, least: {1}, average: {2}", mostSteps, leastSteps, totalSteps / weekSteps.Length);

// docx q9
static double sumUp(string path) {
    double sum = 0;
    string line;

    using(StreamReader file = new StreamReader(path)) {
        while((line = file.ReadLine()) != null) {
            sum += Convert.ToDouble(line);
        }
    }

    return sum;
}

// docx q10
Pizza p1 = new Pizza();
p1.Customize(5);
public class Pizza {
    // variables
    List<string> toppings = new List<string>();

    // constructors
    public Pizza() {
        toppings.Add("cheese");
    }

    // methods
    public void Customize(int toppingCount) {
        for(int i = 0; i < toppingCount; i++) {
            Console.WriteLine("What is topping #{0}?", i + 2);
            toppings.Add(Console.ReadLine());
        }

        foreach(string topping in toppings) {
            Console.WriteLine(topping);
        }
    }
}