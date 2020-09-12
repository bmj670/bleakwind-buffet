/*
 * Author: Benjamin Manglona Jr.
 * Class: MarkarthMilk.cs
 * Purpose: Class used to represent a Markarth Milk drink.
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// A class representing a Markarth Milk drink.
    /// </summary>
    public class MarkarthMilk : Drink
    {
        /// <summary>
        /// Gets/sets whether the drink contains ice.
        /// </summary>
        public bool Ice { get; set; } = false;

        /// <summary>
        /// The price of the drink.
        /// </summary>
        /// <value>
        /// In U.S. Dollars
        /// </value>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small: return 1.05;
                    case Size.Medium: return 1.11;
                    case Size.Large: return 1.22;
                    default: throw new NotImplementedException("Should never execute");
                }
            }
        }

        /// <summary>
        /// The calories of the drink.
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small: return 56;
                    case Size.Medium: return 72;
                    case Size.Large: return 93;
                    default: throw new NotImplementedException("Should never execute");
                }
            }
        }

        /// <summary>
        /// The special insructions to create the drink.
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (Ice) instructions.Add("Add ice");

                return instructions;
            }
        }

        /// <summary>
        /// Changes the way the object is represented as a string.
        /// </summary>
        /// <returns>The name of the entree.</returns>
        public override string ToString()
        {
            return $"{Size} Markarth Milk";
        }
    }
}
