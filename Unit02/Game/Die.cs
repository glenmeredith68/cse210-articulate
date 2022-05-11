using System;

namespace Unit02.Game
{
    // TODO: Implement the Die class as follows...
    // 1) Add the class declaration. Use the following class comment.

    /// <summary>
    /// A small cube with a different number of spots on each of its six sides.
    /// 
    /// The responsibility of Die is to keep track of its currently rolled value and the points its
    /// worth.
    /// </summary> 
    public class Die
    {


        /// <summary>
        /// Constructs a new instance of Die.
        /// </summary>
        public Die()
        {
        }

        /// <summary>
        /// Generates a new random value and calculates the points for the die. Fives are 
        /// worth 50 points, ones are worth 100 points, everything else is worth 0 points.
        /// </summary>

        public int Roll()
        {
            Random randomObj = new Random();
            int randomNum = randomObj.Next(7);
            int points;
            if (randomNum == 1) {
                points = 100;
            } else if (randomNum == 5) {
                points = 50;
            } else {
                points = 0;
            }
            return points;
        }




    }

    // 2) Create the class constructor. Use the following method comment.



    // 3) Create the Roll() method. Use the following method comment.


}