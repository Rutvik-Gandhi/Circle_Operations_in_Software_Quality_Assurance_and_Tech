using Assignment_2;

namespace Assignment_2
{

    class Program
    {
        static void Main(string[] args)
        {
            int circleRadius;
            Circle circle;

            Console.WriteLine("Enter Raduis of the circle: ");
            while (!int.TryParse(Console.ReadLine(), out circleRadius) || circleRadius <= 0)
            {
                Console.WriteLine("It's a Wrong Input!! Enter valid Radius ");
            }

            circle = new Circle(circleRadius);

            int select;
            do
            {
                Console.WriteLine("1) Get Circle Radius");
                Console.WriteLine("2) Change Circle Radius");
                Console.WriteLine("3) Get Circle Circumference");
                Console.WriteLine("4) Get Circle Area");
                Console.WriteLine("5) Exit");
                while (!int.TryParse(Console.ReadLine(), out select) || select < 1 || select > 5)
                {
                    Console.WriteLine("You have entered an wrong input !! please select again ");
                }
                switch (select)
                {
                    case 1:
                        Console.WriteLine("Radius of circle is " + circle.GetRadius());
                        break;
                    case 2:
                        Console.WriteLine("Enter new Radius ");
                        while (!int.TryParse(Console.ReadLine(), out circleRadius) || circleRadius <= 0)
                        {
                            Console.WriteLine("You have entered an wrong input !!");
                        }
                        circle.SetRadius(circleRadius);
                        Console.WriteLine("The new Radius is  " + circle.GetRadius());
                        break;
                    case 3:
                        Console.WriteLine("The Circumference is " + circle.GetCircumference());
                        break;
                    case 4:
                        Console.WriteLine("The Area is " + circle.GetArea());
                        break;
                    case 5:
                        Console.WriteLine("The Application is ended.");
                        break;
                }
            } while (select != 5);
        }
    }
}