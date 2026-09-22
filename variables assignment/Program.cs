namespace variables_assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string room, price, learning, name, gradyear, circleradius, circlearea, rectanglelength, rectanglewidth, rectanglearea;
            const double pi = 3.14;
            room = "29";
            price = "$2.99";
            learning = "Computer Science";
            gradyear = "2029";
            circleradius = "6";
            circlearea = (pi * Math.Pow(double.Parse(circleradius), 2)).ToString();
            name = "Damien Klassen";
            rectanglelength = "19";
            rectanglewidth = "7";
            rectanglearea = (double.Parse(rectanglelength) * double.Parse(rectanglewidth)).ToString();
            Console.WriteLine("this is room " + room);
            Console.WriteLine("The price is " + price);
            Console.WriteLine("I am learning a bit about " + learning);
            Console.WriteLine("My name is " + name + " and I'll graduate in " + gradyear);
            Console.WriteLine("The area of a circle with a radius of " + circleradius + " is " + circlearea);
            Console.WriteLine("The area of a rectangle with a length of " + rectanglelength + " and a width of " + rectanglewidth + " is " + rectanglearea);

        }
    }
}
