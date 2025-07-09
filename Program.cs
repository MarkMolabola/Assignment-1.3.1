namespace Assignment_1._3._1
{
    internal class Program
    {
        static void CalculateTriangleArea()
        {
            Console.WriteLine("Enter the base of the triangle:");
            double baseLength = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the height of the triangle:");
            double height = Convert.ToDouble(Console.ReadLine());
            double area = 0.5 * baseLength * height;
            Console.WriteLine($"The area of the triangle is: {area}");
        }
        static void CalculateSquareArea()
        {
            Console.WriteLine("Enter the side length of the square:");
            double side = Convert.ToDouble(Console.ReadLine());
            double area = side * side;
            Console.WriteLine($"The area of the square is: {area}");
        }
        static void CalculateRectangleArea()
        {
            Console.WriteLine("Enter the length of the rectangle:");
            double length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the width of the rectangle:");
            double width = Convert.ToDouble(Console.ReadLine());
            double area = length * width;
            Console.WriteLine($"The area of the rectangle is: {area}");
        }
        static void Main(string[] args)
        {
            //Write a program in C# to calculate area of triangle, square and rectangle.
            //Write 3 different functions for each shape to take dimensions of figure and display the area. You may create menus.
            bool continueProgram = true;
            do
            {
                Console.Clear();
                Console.WriteLine("-----------------------------------");
                Console.WriteLine(" Pick a shape to calculate its area");
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("1) triangle ");
                Console.WriteLine("2) square ");
                Console.WriteLine("3) rectangle ");

                Console.WriteLine("-----------------------------------");
                Console.WriteLine("     Enter your choice (1-3) ");

                string firstChoice = Console.ReadLine();
                Console.Clear();
                switch (firstChoice)
                {
                    case "1":
                        CalculateTriangleArea();
                        break;
                    case "2":
                        CalculateSquareArea();
                        break;
                    case "3":
                        CalculateRectangleArea();
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please select 1, 2, or 3.");
                        break;
                }
                //Console.Clear();
                Console.WriteLine("Do you want to try again?");
                Console.WriteLine("1) Yes");
                Console.WriteLine("2) No");
                string secondChoice = Console.ReadLine();
                if (secondChoice == "2")
                {
                    continueProgram = false;
                }
            } while (continueProgram);




            
        }
    }

}
