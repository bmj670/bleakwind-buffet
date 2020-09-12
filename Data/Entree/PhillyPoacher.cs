/*
 * Author: Benjamin Manglona Jr.
 * Class name: PhillyPoacher.cs
 * Purpose: Class used to represent a Philly Poacher entree.
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entree
{
    /// <summary>
    /// A class representing a Philly Poacher entree.
    /// </summary>
    /// <remarks>
    /// A cheesesteak sandwich made from grilled sirloin, topped with onions on a fried roll.
    /// </remarks>
    public class PhillyPoacher : Entree
    {
        /// <summary>
        /// The price of the entree.
        /// </summary>
        /// <value>
        /// In U.S. Dollars
        /// </value>
        public override double Price => 7.23;

        /// <summary>
        /// The calories of the entree.
        /// </summary>
        public override uint Calories => 784;

        /// <summary>
        /// Gets/Sets whether the entree contains sirloin.
        /// </summary>
        public bool Sirloin { get; set; } = true;

        /// <summary>
        /// Gets/Sets whether the entree contains onions.
        /// </summary>
        public bool Onion { get; set; } = true;

        /// <summary>
        /// Gets/Sets whether the entree contains a roll.
        /// </summary>
        public bool Roll { get; set; } = true;

        /// <summary>
        /// The special instructions to create the entree.
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Sirloin) instructions.Add("Hold sirloin");
                if (!Onion) instructions.Add("Hold onions");
                if (!Roll) instructions.Add("Hold roll");

                return instructions;
            }
        }

        /// <summary>
        /// Changes the way the object is represented as a string.
        /// </summary>
        /// <returns>The name of the entree.</returns>
        public override string ToString()
        {
            return "Philly Poacher";
        }
    }
}
