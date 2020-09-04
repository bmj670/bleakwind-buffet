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
    public class PhillyPoacher
    {
        /// <value>
        /// Gets the Price of the entree.
        /// </<value>>
        public double Price => 7.32;

        /// <value>
        /// Gets the calories of the entree.
        /// </<value>>
        public uint Calories => 784;

        /// <value>
        /// Gets/Sets whether the entree contains sirloin.
        /// </value>
        public bool Sirloin { get; set; } = true;

        /// <value>
        /// Gets/Sets whether the entree contains onions.
        /// </value>
        public bool Onion { get; set; } = true;

        /// <value>
        /// Gets/Sets whether the entree contains a roll.
        /// </value>
        public bool Roll { get; set; } = true;

        /// <summary>
        /// Gets the special instructions for creating a Philly Poacher entree.
        /// </summary>
        /// <remarks>
        /// If there are no special instructions, it returns an empty list.
        /// </remarks>
        public List<string> SpecialInstructions
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
