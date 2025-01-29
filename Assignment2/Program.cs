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
double areaSum = rectangleArea + squareArea;

Console.WriteLine("Hello {0}", name);
Console.WriteLine("Rectangle area: {0}", rectangleArea);
Console.WriteLine("Rectangle perimeter: {0}", rectanglePerimeter);
Console.WriteLine("Square area: {0}", squareArea);
Console.WriteLine("Square perimeter: {0}", squarePerimeter);
Console.WriteLine("Sum: {0}", areaSum);
