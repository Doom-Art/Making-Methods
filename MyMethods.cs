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
            return y1- y2;
        }
        ///<summary>
        ///This method returns the rise (y2-y1) of two coordinates provided.
        ///</summary>
        ///<param name="p1"> A Point value representing the first coordinate.</param>
        ///<param name="p2"> A Point value representing the second coordinate.</param>
        ///<returns>A double value representing the rise (y2-y1) of two coordinates provided.</returns>
        public static double GetRise(Point p1, Point p2)
        {
            return GetRise(p1.Y, p2.Y); //lets use the method we know works to calculate the slope.
        }
    }
}
