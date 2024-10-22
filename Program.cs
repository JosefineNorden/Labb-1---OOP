namespace Labb_1___Intro_till_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a circle with the radius 5.
            Circle circle1 = new Circle(5);
            Console.WriteLine($"Arean för en cirkel med radie 5: {circle1.GetArea()}");

            // Create a circle with the radius 6.
            Circle circle2 = new Circle(6);
            Console.WriteLine($"Arean för en cirkel med radie 6: {circle2.GetArea()}");

            // Create a circle were the user sets the radius. 
            Console.WriteLine("Skriv in Radien på den cirkeln du vill räkna ut: ");
            int userInput = Convert.ToInt32(Console.ReadLine());
            Circle circle3 = new Circle(userInput);
            Console.WriteLine($"Arean på din cirkel med radien {userInput} är {circle3.GetArea()}");
        }
        public class Circle
        {
            // Variable for pi.
            float _pi = 3.141f;

            public int Radius { get; set; }

            // Constructor that gets the radius as parameter.
            public Circle(int radius)
            {
                Radius = radius;
            }
            //Method for getting the area of the circle.
            public float GetArea()
            {
                return Radius * Radius * _pi;
            }
        }
    }
}
