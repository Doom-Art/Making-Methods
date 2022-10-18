using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Making_Methods
{
    static internal class MyMethods
    {
        /// <summary>
        /// Gives the hypotenuse of a right angle triangle with 2 provided legs.
        /// </summary>
        /// <param name="a"> First leg of the triangle. </param>
        /// <param name="b"> Other leg of the triangle. </param>
        /// <returns>The hypotenuse. </returns>
        public static double GetHypotenuse(double a, double b)
        {
            return Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
        }
        /// <summary>
        /// Gives the missing leg of a right angle triangle with the hypotenuse and one leg.
        /// </summary>
        /// <param name="a"> The Hypotenuse of a right angle triangle. </param>
        /// <param name="b"> One leg of a right angle triangle. </param>
        /// <returns> The missing leg of a right angle triangle. </returns>
        public static double GetLeg(double a, double b)
        {
            return Math.Sqrt((a*a) - (b*b));
        }
        /// <summary>
        /// Get the rise (y1-y2) of two y values provided.
        /// </summary>
        /// <param name="y1"> A double value representing the first y coordinate. </param>
        /// <param name="y2"> A double value representing the second y coordinate. </param>
        /// <returns> The rise (y1-y2) of two provided y coordinates. </returns>
        public static double GetRise(double y1, double y2)
        {
            return y2- y1;
        }
        ///<summary>
        ///This method returns the rise (y2-y1) of two coordinates provided.
        ///</summary>
        ///<param name="p1"> A Point value representing the first y coordinate.</param>
        ///<param name="p2"> A Point value representing the second y coordinate.</param>
        ///<returns>A double value representing the rise (y2-y1) of two coordinates provided.</returns>
        public static double GetRise(Point p1, Point p2)
        {
            return GetRise(p1.Y, p2.Y); 
        }
        /// <summary>
        /// This method returns the run (x2-x1) of two coordinate values provided.
        /// </summary>
        /// <param name="x1"> A double value representing the first X coordinate. </param>
        /// <param name="x2"> A double value representing the second X coordinate. </param>
        /// <returns> A double value representing the run (x2-x1) of two coordinates provided. </returns>
        public static double GetRun(double x1, double x2)
        {
            return x2- x1;
        }
        /// <summary>
        /// This method returns the run (x2-x1) of two provided coordinates
        /// </summary>
        /// <param name="p1"> A Point value representing the first coordinate. </param>
        /// <param name="p2"> A Point value representing the second coordinate. </param>
        /// <returns> The run (x2 - x1) of the provided points. </returns>
        public static double GetRun(Point p1, Point p2)
        {
            return GetRun(p1.X, p2.X);
        }
        /// <summary>
        /// Gives the distance between two points on a graph when given the X and Y coordinate values.
        /// </summary>
        /// <param name="x1"> A double value representing the first point's X coordinate. </param>
        /// <param name="x2"> A double value representing the second point's X coordinate. </param>
        /// <param name="y1"> A double value representing the first point's Y coordinate. </param>
        /// <param name="y2"> A double value representing the second point's Y coordinate. </param>
        /// <returns> The distance [d=√((x2 – x1)² + (y2 – y1)²)] between 2 points. </returns>
        public static double GetDistance(double x1,  double y1, double x2, double y2)
        {
            return GetHypotenuse( (GetRise(y1, y2)), GetRun(x1,x2));
        }
        /// <summary>
        /// Gives the distance between two points on a graph with two provided points.
        /// </summary>
        /// <param name="p1"> The first point you want to compare. </param>
        /// <param name="p2"> The second point you want to compare. </param>
        /// <returns> The distance between the two points. </returns>
        public static double GetDistance(Point p1, Point p2)
        {
            return GetDistance(p1.X, p2.X, p1.Y, p2.Y);
        }
        /// <summary>
        /// Determines the slope when given values for the x and y coordinates of 2 points.
        /// </summary>
        /// <param name="x1"> A double value for the first point's X coordinate. </param>
        /// <param name="y1"> A double value for the first point's Y coordinate. </param>
        /// <param name="x2"> A double value for the second point's X coordinate. </param>
        /// <param name="y2"> A double value for the second point's Y coordinate. </param>
        /// <returns> A double value representing the slope (Rise/Run).</returns>
        public static double GetSlope(double x1, double y1, double x2, double y2)
        {
            return (GetRise(y1, y2)) / (GetRun(x1, x2));
        }
        /// <summary>
        /// Determines the slope when given two points.
        /// </summary>
        /// <param name="p1"> The first point you want to compare. </param>
        /// <param name="p2"> The second point you want to compare. </param>
        /// <returns> The slope (Rise/Run) of the two points. </returns>
        public static double GetSlope(Point p1, Point p2)
        {
            return GetSlope(p1.X, p1.Y, p2.X, p2.Y);
        }
        /// <summary>
        /// Determines the Y intercept with the slope and values for the X and Y coordinates.
        /// </summary>
        /// <param name="slope"> The slope of a graph </param>
        /// <param name="x1"> A double value representing a point's X coordinate. </param>
        /// <param name="y1"> A double value representing a point's Y coordinate. </param>
        /// <returns> The Y intercept. </returns>
        public static double GetYIntercept (double slope, double x1, double y1)
        {
            return (y1-(slope*x1));
        }
        /// <summary>
        /// Determines the Y intercept when given the slope and one point.
        /// </summary>
        /// <param name="slope"> The slope value. </param>
        /// <param name="p1"> One point on the graph. </param>
        /// <returns> The Y intercept as a double value. </returns>
        public static double GetYIntercept(double slope, Point p1)
        {
            return GetYIntercept(slope, p1.X, p1.Y);
        }
        /// <summary>
        /// Determines if a triangle is a right triangle when given the three legs.
        /// </summary>
        /// <param name="leg1"> A double value representing the first leg of a triangle. </param>
        /// <param name="leg2"> A double value representing the second leg of a triangle. </param>
        /// <param name="leg3"> A double value representing the third leg of a triangle. </param>
        /// <returns> Returns true if it is a right triangle or false if it is not. </returns>
        public static bool IsRightTriangle(double leg1, double leg2, double leg3)
        {
            if (leg1 == GetHypotenuse(leg2, leg3)){
                return true;
            }
            else if( leg2 == GetHypotenuse(leg1, leg3)){
                return true;
            }
            else if (leg3 == GetHypotenuse(leg1, leg2)){
                return true;
            }
            else
                return false;
        }
        /// <summary>
        /// Generates a list of integers with random integer values in the range of the entered min and max values.
        /// </summary>
        /// <param name="min"> An int value for the minimum value. </param>
        /// <param name="max"> An int value for the maximum value. If max is less than min it is defaulted to min+1 </param>
        /// <param name="size"> An int value for the size of the list, if negative it will be set to a default of 0. </param>
        /// <returns> A list of random integers in the range of the entered min and max values. </int></returns>
        public static List<int> GetRandomList(int min, int max, int size)
        {
            Random rand = new Random();
            if (size < 0){
                size = 0;
            }
            if (max < min){
                max = min + 1;
            }
            List<int> list = new List<int>();
            for (int i = 0; i < size; i++)
            {
                list.Add(rand.Next(min,max));
            }
            return list;
        }
        /// <summary>
        /// Generates an array of integers with random integer values in the range of the entered min and max values.
        /// </summary>
        /// <param name="min"> An int value for the minimum value. </param>
        /// <param name="max"> An int value for the maximum value. If max is less than min it is defaulted to min+1 </param>
        /// <param name="size"> An int value for the size of the array, if negative it will be set to a default of 0. </param>
        /// <returns> An array of random integers in the range of the entered min and max values. </int></returns>
        public static int[] GetRandomArray(int min, int max, int size)
        {
            Random rand = new Random();
            if (size < 0)
            {
                size = 0;
            }
            if (max < min)
            {
                max = min + 1;
            }
            int[] list = new int[size];
            for (int i = 0; i < size; i++)
            {
                list[i] = rand.Next(min, max);
            }
            return list;
        }
        /// <summary>
        /// Takes a string and prints it returns it in the reversed order.
        /// </summary>
        /// <param name="stringToReverse"> A string value that will be returned in the reverse order. </param>
        /// <returns> The string in a reversed order. </returns>
        public static string Reverse(string stringToReverse)
        {
            string reversedVersion = "";
            for (int i = (stringToReverse.Length) - 1; i>=0; i--)
            {
                reversedVersion += stringToReverse[i];
            }
            return reversedVersion;
        }
        /// <summary>
        /// Determines the average value of the double values in a list of doubles.
        /// </summary>
        /// <param name="list"> A List of doubles to get the average values of. </param>
        /// <returns> The average value of the doubles in the list. </returns>
        public static double Average(List<double> list)
        {
            int count = 0;
            double average = 0;
            foreach(double d in list)
            {
                average += d;
                count++;
            }
            return (average / count);
        }
        /// <summary>
        /// Determines the average value of the double values in an array of doubles.
        /// </summary>
        /// <param name="array"> An array of doubles to get the average values of. </param>
        /// <returns> The average of value of the doubles in the array. </returns>
        public static double Average(double[] array)
        {
            List<double> list = new List<double>();
            foreach(double i in array)
            {
                list.Add(i);
            }
            return Average(list);
        }
        /// <summary>
        /// Determines the average value of the int values in a list of ints.
        /// </summary>
        /// <param name="list"> A List of ints to get the average values of. </param>
        /// <returns> The average value of the ints in the list. </returns>
        public static double Average(List<int> list)
        {
            int count = 0;
            double average = 0;
            foreach (int d in list)
            {
                average += d;
                count++;
            }
            return (average / count);
        }
        /// <summary>
        /// Determines the average value of the int values in an array of ints.
        /// </summary>
        /// <param name="array"> An array of integers to get the average value of. </param>
        /// <returns> The average of value of the integers  in the array. </returns>
        public static double Average(int[] array)
        {
            List<int> list = new List<int>();
            foreach (int i in array)
            {
                list.Add(i);
            }
            return Average(list);
        }
        /// <summary>
        /// Determines the number of real roots using the quadratic formula.
        /// </summary>
        /// <param name="a"> The A value of an equation in standard form. </param>
        /// <param name="b"> The B value of an equation in standard form. </param>
        /// <param name="c"> The C value of an equation in standard form.</param>
        /// <returns> Returns the number of real roots the equation has. </returns>
        public static int RootChecker(double a, double b, double c)
        {
            double d = (b * b) - (4 * a * c);
            if (d == 0)
                return 1;
            else if (d > 0)
                return 2;
            else
                return 0;
        }
        /// <summary>
        /// Finds the circumfrence of a circle when given the radius
        /// </summary>
        /// <param name="radius"> The radius of the circle you want to find the circumfrence of. </param>
        /// <returns> The circumfrence of the circle. </returns>
        public static double CircumfrenceFinder(double radius)
        {
            return 2 * Math.PI * radius;
        }
        /// <summary>
        /// Calculates the area of a triangle.
        /// </summary>
        /// <param name="height"> A double value representing the height of the triangle. </param>
        /// <param name="base1"> A double value representing the base of the triangle. </param>
        /// <returns> The area of a triangle [(Height*base)/2]. </returns>
        public static double AreaOfTriangle(double height, double base1)
        {
            return (height * base1) / 2;
        }
        /// <summary>
        /// Draws a dice face corrosponding to the number given.
        /// </summary>
        /// <param name="dice">An int value between 1-6 representing the die face you want printed. </param>
        public static void DiceDrawing(int dice)
        {
            int y = Console.CursorTop; int x = Console.CursorLeft;
            if (dice == 1){
                Console.SetCursorPosition(x, y + 1); Console.Write("_____");
                Console.SetCursorPosition(x, y + 2); Console.Write("|   |");
                Console.SetCursorPosition(x, y + 3); Console.Write("| o |");
                Console.SetCursorPosition(x, y + 4); Console.Write("|   |");
                Console.SetCursorPosition(x, y + 5); Console.Write("-----");
            }
            else if (dice == 2){
                Console.SetCursorPosition(x, y + 1); Console.Write("_____");
                Console.SetCursorPosition(x, y + 2); Console.Write("|o  |");
                Console.SetCursorPosition(x, y + 3); Console.Write("|   |");
                Console.SetCursorPosition(x, y + 4); Console.Write("|  o|");
                Console.SetCursorPosition(x, y + 5); Console.Write("-----");
            }
            else if (dice == 3){
                Console.SetCursorPosition(x, y + 1); Console.Write("_____");
                Console.SetCursorPosition(x, y + 2); Console.Write("|o  |");
                Console.SetCursorPosition(x, y + 3); Console.Write("| o |");
                Console.SetCursorPosition(x, y + 4); Console.Write("|  o|");
                Console.SetCursorPosition(x, y + 5); Console.Write("-----");
            }
            else if (dice == 4){
                Console.SetCursorPosition(x, y + 1); Console.Write("_____");
                Console.SetCursorPosition(x, y + 2); Console.Write("|o o|");
                Console.SetCursorPosition(x, y + 3); Console.Write("|   |");
                Console.SetCursorPosition(x, y + 4); Console.Write("|o o|");
                Console.SetCursorPosition(x, y + 5); Console.Write("-----");
            }
            else if (dice == 5){
                Console.SetCursorPosition(x, y + 1); Console.Write("_____");
                Console.SetCursorPosition(x, y + 2); Console.Write("|o o|");
                Console.SetCursorPosition(x, y + 3); Console.Write("| o |");
                Console.SetCursorPosition(x, y + 4); Console.Write("|o o|");
                Console.SetCursorPosition(x, y + 5); Console.Write("-----");
            }
            else if (dice == 6){
                Console.SetCursorPosition(x, y + 1); Console.Write("_____");
                Console.SetCursorPosition(x, y + 2); Console.Write("|o o|");
                Console.SetCursorPosition(x, y + 3); Console.Write("|o o|");
                Console.SetCursorPosition(x, y + 4); Console.Write("|o o|");
                Console.SetCursorPosition(x, y + 5); Console.Write("-----");
            }
        }
    }
}
