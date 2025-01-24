using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double areaSizeTotal;
            string shapeType;
            Console.WriteLine("Please Enter which type of shape you want calculate the area of? R for rectangular and" +
                "and any other key for Circle");
            shapeType = Console.ReadLine();
            AreaCalculation areaCalculation = new AreaCalculation();
            if (shapeType == "r")
            {
                Console.WriteLine("Please enter the value of 1 side of the rectangular");
                double oneSide = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please enter the value of other side of the rectangular");
                double twoSide = Convert.ToDouble(Console.ReadLine());

                areaSizeTotal = areaCalculation.rectangularCalculation(oneSide, twoSide);
                Console.WriteLine("Size of area is" + areaSizeTotal);
            }
            else 
            {
                Console.WriteLine("Please enter the radius of the circle");
                double radius = Convert.ToDouble(Console.ReadLine());
                areaSizeTotal = areaCalculation.circleCalculation(radius);
                Console.WriteLine("Size of area is" + areaSizeTotal);
            }
        }
    }
}