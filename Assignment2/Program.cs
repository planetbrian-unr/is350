// a
/*
    Brian Wu
    IS 350: Assignment 2
    Name, rectangle/square math
*/

// b
Console.WriteLine("What is your name?");
string name = Console.ReadLine();

Console.WriteLine("Enter rectangle length");
double rectangleLength = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter rectangle width");
double rectangleWidth = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter square length");
int squareLength = Convert.ToInt32(Console.ReadLine());

// c
double rectangleArea = rectangleLength * rectangleWidth;
double rectanglePerimeter = (2 * rectangleLength) + (2 * rectangleWidth);
int squareArea = squareLength * squareLength;
int squarePerimeter = 4 * squareLength;

Console.WriteLine("Hello " + name);
Console.WriteLine("Rectangle area: " + rectangleArea);
Console.WriteLine("Rectangle perimeter: " + rectanglePerimeter);
Console.WriteLine("Square area: " + squareArea);
Console.WriteLine("Square perimeter: " + squarePerimeter);
Console.WriteLine("Sum: " + (rectangleArea + squareArea));
