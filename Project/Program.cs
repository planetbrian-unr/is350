﻿/*
    Brian Wu
    IS 350: Project Stage 4
    Gym management
*/

// object creation
Gym planetfitness = new Gym("Planet Fitness", "Reno", "775-000-0000", true);
Member brian = new Member("Brian", 21, 5.75, 175);
Member john = new Member();
Exercise dash = new Exercise("200m dash", "cardio", 1.5, "hard", 150);
Exercise biceps = new Exercise("Bicep curls", "muscle building", 20, "medium", 100);
Exercise nothing = new Exercise();

// add members to gym and output info. 2 of 3 Gym's methods used so far
planetfitness.AddMember(brian);
planetfitness.AddMember(john);
planetfitness.OutputInformation();

// exercise objects methods demo. all 3 used
dash.OutputInformation();
Console.WriteLine("doing {0} burns {1} calories", biceps.OutputWorkoutName(), biceps.CalsBurned());

// member objects methods demo. all 4 used
brian.AddExercise(dash);
brian.AddExercise(biceps);
john.AddExercise(nothing);
john.outputInformation();
Console.WriteLine("{0} has burned {1} calories", brian.OutputName(), brian.CountTotalCalories());

// "close" gym. 3 of 3 Gym's methods used.
planetfitness.ChangeBusinessStatus();

// classes
public class Exercise {
    
    // variables
    static int counter = 1;
    int id;
    string name;
    string catagory;
    double duration;
    string intensity;
    int caloriesBurned;

    // constructors, default and parameterized
    public Exercise() {
        id = counter++;
        name = "Nothing";
        catagory = "being lazy";
        duration = 0.0;
        intensity = "low";
        caloriesBurned = 10;
    }
    public Exercise(string nm, string cat, double dur, string inten, int cal) {
        id = counter++;
        name = nm;
        catagory = cat;
        duration = dur;
        intensity = inten;
        caloriesBurned = cal;
    }

    // methods
    public void OutputInformation() {
        Console.WriteLine("{0} {1} ({2}) for {3} minutes at {4} intensity burns {5} calories", id, name, catagory, duration, intensity, caloriesBurned);
    }
    public int CalsBurned() {
        return caloriesBurned;
    }
    public string OutputWorkoutName() {
        return name;
    }
}

public class Member {
    // variables
    static int counter = 1;
    int id;
    string name ;
    int age;
    double height;
    double weight;
    List<Exercise> workoutLog;

    // constructors, default and parameterized
    public Member() {
        id = counter++;
        name = "John Doe";
        age = 25;
        height = 5.5;
        weight = 160;
        workoutLog = new List<Exercise>();
    }
    public Member(string nm, int ag, double ht, double wt) {
        id = counter++;
        name = nm;
        age = ag;
        height = ht;
        weight = wt;
        workoutLog = new List<Exercise>();
    }

    // methods
    public void outputInformation() {
        Console.WriteLine("{0} {1} is {2}, {3} feet tall, weighs {4} lbs., and has done these exercises:", id, name, age, height, weight);
        foreach(var exercise in workoutLog) {
            Console.WriteLine(exercise.OutputWorkoutName());
        }
    }
    public void AddExercise(Exercise exercise) {
        workoutLog.Add(exercise);
    }
    public int CountTotalCalories() {
        int calorieSum = 0;

        foreach(var exercise in workoutLog) {
            calorieSum += exercise.CalsBurned();
        }
        return calorieSum;
    }
    public string OutputName() {
        return name;
    }
}

public class Gym {
    // variables
    static int counter = 1;
    int id;
   string name;
    string location;
    string phonenumber;
    bool openForBusiness;
    List<Member> memberList;

    // constructors, default and parameterized
    public Gym() {
        id = counter++;
        name = "No name";
        location = "Nowhere";
        phonenumber = "0000000000";
        openForBusiness = false;
        memberList = new List<Member>();
    }
    public Gym(string nm, string loc, string pnum, bool status) {
        id = counter++;
        name = nm;
        location = loc;
        phonenumber = pnum;
        openForBusiness = status;
        memberList = new List<Member>();
    }

    // methods
    public void OutputInformation() {
        Console.WriteLine("{0} {1} is located at {2}. Their phone # is {3}, and they are {4}. Its members are:", id, name, location, phonenumber, openForBusiness ? "open" : "closed");
        foreach(var member in memberList) {
            Console.WriteLine(member.OutputName());
        }    
    }
    public void AddMember(Member member) {
        memberList.Add(member);
    }
    public void ChangeBusinessStatus() {
        openForBusiness = !openForBusiness;
        Console.WriteLine("We are now {0}", openForBusiness ? "open" : "closed");
    }
}